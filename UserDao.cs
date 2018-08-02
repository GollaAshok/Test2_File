using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.limoliner.model;
 
namespace com.limoliner.Dao
{
    interface UserDao
    {
        bool AddUser(UserModel um);
        bool UpdateUser(UserModel um);
        bool DeleteUser(UserModel um);
        bool ValidatUser(UserModel um);
        UserModel GetUser(UserModel um);
        List<UserModel> GetAllUsers();

    }
}
