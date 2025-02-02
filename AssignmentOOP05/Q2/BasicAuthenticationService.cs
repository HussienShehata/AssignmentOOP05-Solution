using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService 
    {
        #region attributes

        public string? UserName { get; set; }
        public int Password { get; set; }
        public string? Role { get; set; }


        #endregion

        #region Constructor

        public BasicAuthenticationService()
        {
            
        }
        public BasicAuthenticationService(string username , int password, string role)
        {
            UserName = username;
            Password = password;    
            Role = role;
        }

        #endregion

        #region methods
        public bool AuthenticateUser(string UserName,int Password)
        {
            if (UserName is not null )
                if (UserName == this.UserName && Password == this.Password )
                return true;
                else
                return false;
            else
                return false;
        }

        public bool AuthorizeUse(string UserName , string Role)
        {
            if(UserName is not null || Role is not null)
               if (UserName == this.UserName && Role == this.Role)
                return true;
               else  
                return false;
            else 
                return false;
        } 
        #endregion
    }
}
