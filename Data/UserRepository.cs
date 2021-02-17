
using AutoMapper;
using AutoMapper.QueryableExtensions;
using EMS.DTOs;
using EMS.Entities;
using EMS.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetAppUser(string username)
        {
            return await _context.Users
                .Where(x => x.UserName == username)
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<UserDTO>> GetAppUsers()
        {
            return await _context.Users
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByUsernameAsync(string username)
        {
            return await _context.Users
                .Include(m => m.Menus)
                .Include(p => p.Permissions)
                .Include(w => w.Websites)
                .Include(uh => uh.userHolidays)
                .Include(uiot => uiot.userInOutTimes)
                .Include(ula => ula.userLeaveApplications)
                .SingleOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                .Include(m => m.Menus)
                .Include(p => p.Permissions)
                .Include(w => w.Websites)
                .Include(uh => uh.userHolidays)
                .Include(uiot => uiot.userInOutTimes)
                .Include(ula => ula.userLeaveApplications)
                .ToListAsync(); ;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
