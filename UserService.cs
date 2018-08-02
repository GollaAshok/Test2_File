using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.limoliner.dto;

namespace com.limoliner.Service
{
    interface UserService
    {
        bool AddUser(UserDto ud);
        UserDto GetUser(UserDto ud);
        bool updateUser(UserDto ud);
        bool DeleteUser(UserDto ud);
        bool ValidatUser(UserDto ud);
        List<UserDto> GetAllUsers();

    }
}
