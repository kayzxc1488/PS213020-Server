using System;
using System.Collections.Generic;
using System.Text;

namespace PS223020_server.BusinesLogic.Core.Models
{
    public class UserInformationBLo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string AvatarUrl { get; set; }
        public string Introduction { get; set; }
    }
}
