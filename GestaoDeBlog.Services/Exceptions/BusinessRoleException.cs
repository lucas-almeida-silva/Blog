using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeBlog.Services.Exceptions
{
    public class BusinessRoleException : Exception
    {
        public BusinessRoleException()
        {
        }
        public BusinessRoleException(string message) : base(message)
        {
        }
    }
}
