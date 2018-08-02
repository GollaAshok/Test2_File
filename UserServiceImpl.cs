using com.limoliner.Dao;
using com.limoliner.Dao.Impl;
using com.limoliner.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using com.limoliner.dto;


namespace com.limoliner.Service.Impl
{
    public class UserServiceImpl : UserService

    {
        UserModel um = new UserModel();
        UserDao dao = new UserDaoImpl();
        public bool AddUser(UserDto ud)
        {
            um.UserName = ud.UserName;
            um.Password = ud.Password;
            um.Name = ud.Name;
            um.MobilNo = ud.MobileNo;
            um.EmailId = ud.EmailId;

            return dao.AddUser(um);
        }

        public UserDto GetUser(UserDto ud)
        {
            
           throw new NotImplementedException();
        }

        public bool updateUser(UserDto ud)
        {
            um.UserName = ud.UserName;
            um.Password = ud.Password;
            um.Name = ud.Name;
            um.MobilNo = ud.MobileNo;
            um.EmailId = ud.EmailId;

            return dao.UpdateUser(um);
        }

        public bool DeleteUser(UserDto ud)
        {
            um.UserName = ud.UserName;
            um.Password = ud.Password;
            um.Name = ud.Name;
            um.MobilNo = ud.MobileNo;
            um.EmailId = ud.EmailId;

            return dao.DeleteUser(um);
        }

        public bool ValidatUser(UserDto ud)
        {
            //throw new NotImplementedException();
           
            um.UserName = ud.UserName;
            um.Password = ud.Password;
            um.Name = ud.Name;

            return dao.ValidatUser(um);
        }

        public List<UserDto> GetAllUsers()
        {
            List<UserDto> udl = new List<UserDto>();
            List<UserModel> uml = dao.GetAllUsers();
            for (int i = 0; i < uml.Count; i++ )
            {
                udl.Add(new UserDto(uml[i]));
            }

            return udl;
        }
    }
}