using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TwitterAPI.Core.UserManagement;

namespace TwitterAPI.Services
{
    public class UserService : IUserService
    {
        private IUserProvider userProvider;
        private IMapper mapper;
        public UserService(IUserProvider userProvider, IMapper mapper)
        {
            this.userProvider = userProvider;
            this.mapper = mapper;
        }
        public UserDto GetCurrentUser()
        {
            var user = userProvider.GetCurrentUser();
            return mapper.Map<UserDto>(user);
        }
    }
}
