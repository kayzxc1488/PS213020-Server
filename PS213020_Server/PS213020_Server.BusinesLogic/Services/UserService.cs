using PS213020_Server.BusinesLogic.Core.Interfaces;
using PS213020_Server.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS213020_Server.BusinesLogic.Services
{
    public class UserService : IUserService
    {
        public Task<UserInformationBLo> Auth(int PhoneNumberPrefix, int PhoneMumber, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int PhoneNumberPrefix, int PhoneMumber)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBLo> Get(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBLo> Regestration(int PhoneNumberPrefix, int PhoneMumber, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateBlo> Update(int PhoneNumberPrefix, int PhoneMumber, string Password, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }
    }
}
