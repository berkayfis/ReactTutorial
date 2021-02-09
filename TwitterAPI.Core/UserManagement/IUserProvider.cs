using System;
using System.Collections.Generic;
using System.Text;
using TwitterAPI.Core.Context;

namespace TwitterAPI.Core.UserManagement
{
    public interface IUserProvider
    {
        User GetCurrentUser();
    }
}
