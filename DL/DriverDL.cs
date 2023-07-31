using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BL;
using TMS.DL;
using TMS.UI;
using System.IO;
namespace TMS.DL
{
    class DriverDL
    {
        private static List<Driver> driverList = new List<Driver>();
        internal static List<Driver> DriverList { get => driverList; set => driverList = value; }
        public static void AddDriverToList(Driver driver)
        {
            driverList.Add(driver);
        }
        public static void ReadDriverFromFile()
        {
            string path = "DriverData.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)

                {
                    string[] word = record.Split(',');

                    Driver drivers = new Driver(word[0], word[1]);
                    AddDriverToList(drivers);
                }
                fileVariable.Close();
            }
        }
        public static void StoreDriverDetailsToFile(Driver driver)
        {
            string path = "DriverData.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(driver.DriverName + "," + driver.DriverID);
            file.Flush();
            file.Close();
        }
        public static void StoreAfterChangeDriverDetails()
        {
            string path = "DriverData.txt";
            StreamWriter file = new StreamWriter(path);
            for (int x = 0; x < driverList.Count; x++)
            {
                file.WriteLine(driverList[x].DriverName + "," + driverList[x].DriverID);
            }
            file.Flush();
            file.Close();
        }
        public static Driver isValidDriver(string checkName)
        {
            foreach (var i in driverList)
            {
                if (i.DriverName == checkName)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
