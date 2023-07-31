using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
   public  class MUser
    {
        protected string userName;
        protected string password;
        private string role;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
         public   MUser()
        {

        }
        public MUser(string UserName, string Password, string Role)
        {
            this.UserName = UserName;
            this.password = Password;
            this.role = Role;
        }
        public MUser(string UserName, string Password)
        {
            this.UserName = UserName;
            this.password = Password;
            this.role = "NA";
        }
        public bool isAdmin()
        {
            if ( this.role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
