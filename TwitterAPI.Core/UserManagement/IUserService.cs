using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterAPI.Core.UserManagement
{
    public interface IUserService
    {
        UserDto GetCurrentUser();
    }
}
