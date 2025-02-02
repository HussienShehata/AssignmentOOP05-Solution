using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Q2
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string name ,int password);
        public bool AuthorizeUse(string name , string role);
    }
}
