using System;
using System.Collections.Generic;
using System.Text;

namespace PS223020_server.Shared.Exceptions
{
    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions(string message) : base(message)
        {
            
        }
    }
}
