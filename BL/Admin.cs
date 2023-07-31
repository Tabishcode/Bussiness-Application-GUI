using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
    class Admin : MUser
    {
        public Admin(string userName, string Password, string role) : base(userName, Password, role)
        {

        }

    }
}
