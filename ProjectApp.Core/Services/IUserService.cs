﻿using ProjectApp.Core.DTOS;
using ProjectApp.Core.DTOS.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.Core.Services
{
    public interface IUserService
    {
        Task<CustomResponseDto<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<CustomResponseDto<AppUserDto>> GetUserByNameAsync(string userName);

        Task<CustomResponseDto<AppRoleDto>> CreateRoleAsync(CreateRoleDto createRoleDto);
     


    }
}
