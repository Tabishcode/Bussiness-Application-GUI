using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.MUserForms;
using TMS.BL;
using TMS.DL;
using TMS.UI;
namespace TMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegisterTrainDL.LoadRegisterTrainToList();
            CustomerDL.LoadCustomerDataFromFile();
            DriverDL.ReadDriverFromFile();
            TrainDL.LoadTrainsFromFile();
            MUserDL.readDataFromFile(path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static string path = "E:\\OOP\\TMS\\DL\\MUser.txt";
    }
}
