using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
    class Driver
    {
        private string driverName;
        private string driverID;
        public Driver(string DriverName, string DriverID)
        {
            this.DriverName = DriverName;
            this.DriverID = DriverID;
        }
        public string DriverName { get => driverName; set => driverName = value; }
        public string DriverID { get => driverID; set => driverID = value; }
    }
}
