using PS223020_server.BusinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS223020_server.BusinesLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBLo> Auth(int PhoneNumberPrefix, int PhoneMumber, string Password);
        Task<UserInformationBLo> Regestration(int PhoneNumberPrefix, int PhoneMumber, string Password);
        Task<UserInformationBLo> Get(int UserId);
        Task<UserUpdateBlo> Update(int PhoneNumberPrefix, int PhoneMumber, string Password, UserUpdateBlo userUpdateBlo);
        Task<bool> DoesExist(int PhoneNumberPrefix, int PhoneMumber);
    }
}
