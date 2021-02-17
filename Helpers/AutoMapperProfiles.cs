using AutoMapper;
using EMS.DTOs;
using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles( )
        {
            CreateMap<AppUser, UserDTO>();
            CreateMap<Menu, MenuDTO>();
            CreateMap<Permission, PermissionDTO>();
            CreateMap<UserHoliday, UserHolidayDTO>();
            CreateMap<UserInOutTime, UserInOutTimeDTO>();
            CreateMap<UserLeaveApplication, UserLeaveApplicationDTO>();
            CreateMap<Website, WebsiteDTO>();
        }
    }
}
