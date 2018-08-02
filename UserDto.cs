using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.limoliner.model;

namespace com.limoliner.dto
{
    public class UserDto
    {
        public string UserName{get;set;}
        public string Password { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }

        public UserDto(){}
        public UserDto(UserModel um)
        {
            UserName = um.UserName;
            Password = um.Password;
            Name = um.Name;
            MobileNo = um.MobilNo;
            EmailId = um.EmailId;

        }
    }

}
