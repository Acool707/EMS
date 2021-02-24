using EMS.Data;
using EMS.DTOs;
using EMS.Entities;
using EMS.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Controllers
{
    public class AccountController : BaseController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;

        public AccountController(DataContext context, ITokenService tokenService, IUserRepository userRepository)
        {
            _context = context;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Resgister(RegisterDTO registerDTO)
        {
            if (await UserExist(registerDTO.Username)) 
                return BadRequest("Username is taken!");

            using var hmac = new HMACSHA512();

            
            //ICollection<Menu> menuList;

            //foreach(var item in registerDTO.Menus)
            //{
            //    menu.MenuType = item.item_id;
            //    menu.AppUserId = 
            //}

            var user = new AppUser
            {
                UserName = registerDTO.Username.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDTO.Password)),
                PasswordSalt = hmac.Key,
                FirstName = registerDTO.Firstname,
                LastName = registerDTO.LastName,
                MiddleNames = registerDTO.Middlename,
                Company = registerDTO.Company,
                DOB = registerDTO.DOB,
                SSN = registerDTO.SSN,
                UserType = registerDTO.UserType,
                Department = registerDTO.Department,
                Location = registerDTO.Location,
                Email = registerDTO.Email,
                PhoneNumber = registerDTO.PhoneNumber,
                WhatsappNumber = registerDTO.WhatsappNumber
                
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            
            var newUser = await _userRepository.GetAppUser(registerDTO.Username);

            foreach(var item in registerDTO.Menus)
            {
                Menu menu = new Menu
                {
                    MenuType = item.item_id,
                    AppUserId = newUser.Id
                };
                _context.menu.Add(menu);
                await _context.SaveChangesAsync();
            }

            foreach (var item in registerDTO.Websites)
            {
                Website website = new Website
                {
                    WebsiteType = item.item_id,
                    AppUserId = newUser.Id
                };
                _context.website.Add(website);
                await _context.SaveChangesAsync();
            }

            return new UserDTO
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user)
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDTO.Username);

            if (user == null) return Unauthorized("Invalid Username");

            var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDTO.Password));

            for(int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) 
                    return Unauthorized("Invalid Password");
            }

            return new UserDTO
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user)
            };
        }

        public async Task<bool> UserExist(string Username)
        {

            return await _context.Users.AnyAsync(x => x.UserName == Username);
        }
    }
}
