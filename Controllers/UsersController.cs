using AutoMapper;
using EMS.DTOs;
using EMS.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EMS.Controllers
{
    //[Authorize]
    public class UsersController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        
        [HttpGet]
        public async Task<IEnumerable<MemberDTO>> GetUsers()
        {
            var users = await _userRepository.GetAppUsers();

            return users;
            
        }
        
        [HttpGet("{username}")]
        public async Task<MemberDTO> GetUser(string username)
        {
            return await _userRepository.GetAppUser(username);
        }
    }
}
