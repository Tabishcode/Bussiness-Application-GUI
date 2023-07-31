using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BL;
using TMS.DL;
using TMS.UI;
using System.Windows.Forms;
using System.IO;
namespace TMS.DL
{
    class RegisterTrainDL
    {
        static public List<RegisterTrain> registerTrains = new List<RegisterTrain>();
        public static void addRegTrainsToList(RegisterTrain train)
        {
            registerTrains.Add(train);
        }
        public static void addRegTrainsToFile(RegisterTrain train)
        {
            string path = "RegisterTrain.txt";
            StreamWriter file = new StreamWriter(path,true);
                file.WriteLine(train .TrainName + "," + train .GoingFrom + "," + train .GoingTo + "," + train .DepartureTime + "," + train .AcFare + "," + train.BussinessFare + "," + train .EconomyFare + "," + train .DriverName + "," + train .DriverID + "," + train .AcSeats + "," + train.BusinessSeats + "," + train.EconomySeats);
            file.Flush();
            file.Close();
        }
        public static void addRegTrainsToFileAfterChange()
        {
            string path = "RegisterTrain.txt";
            StreamWriter file = new StreamWriter(path);
            foreach(var i in registerTrains )
            {
                file.WriteLine(i.TrainName + "," + i.GoingFrom + "," + i.GoingTo + "," + i.DepartureTime + "," + i.AcFare + "," + i.BussinessFare + "," + i.EconomyFare + "," + i.DriverName + "," + i.DriverID + "," + i.AcSeats + "," + i.BusinessSeats + "," + i.EconomySeats);
            }
            file.Flush();
            file.Close();
        }
        public static void LoadRegisterTrainToList()
        {
            string path = "RegisterTrain.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] word = record.Split(',');
                    RegisterTrain regTrain = new RegisterTrain (word[0], word[1], word[2],DateTime.Parse( word[3]), int.Parse(word[4]), int.Parse(word[5]), int.Parse(word[6]), word[7], word[8], int.Parse(word[9]), int.Parse(word[10]), int.Parse(word[11]));
                    addRegTrainsToList(regTrain);
                }
                fileVariable.Close();
            }
            else
            {
                MessageBox.Show("File Register Trains Not Found");
            }
        }
        public static bool  isTrainExist(string name)
        {
            foreach (var i in registerTrains )
            {
                if (i.TrainName == name)
                {
                    return true;
                }
            }
                return false;

        }
        public static bool isDriverExist(string name)
        {
            foreach (var i in registerTrains)
            {
                if (i.DriverName == name)
                {
                    return true;
                }
            }
            return false;

        }
        public static RegisterTrain getTrainObj(string name)
        {
            foreach (var i in registerTrains)
            {
                if (i.TrainName == name)
                {
                    return i;
                }
            }
            return null ;

        }
        public static void StoreAfterChangeLinkedTrainToFile()
        {
            string path = "RegisterTrain.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (var i in registerTrains)
            {
                file.WriteLine(i.TrainName + "," + i.GoingFrom + "," + i.GoingTo + "," + i.DepartureTime + "," + i.AcFare + "," + i.BussinessFare + "," + i.EconomyFare + "," + i.DriverName + "," + i.DriverID + "," + i.AcSeats + "," + i.BusinessSeats + "," + i.EconomySeats);
            }
            file.Flush();
            file.Close();
        }
        public static  void removeTrainFromList(RegisterTrain train)
        {
            registerTrains.Remove(train);
        }
        public static RegisterTrain isDestinationExist(string GoingFrom, string GoingTo)
        {
            foreach (var i in registerTrains)
            {
                if (i.GoingFrom == GoingFrom && i.GoingTo == GoingTo)
                {
                    return i;
                }
            }
            return null;
        }
        public static float getFare(string TicketType,RegisterTrain train)
        {
            if(TicketType == "Ac")
            {
                return train.AcFare;
            }
            else if(TicketType == "Business")
            {
                return train.BussinessFare;
            }
            else if(TicketType == "Economy")
            {
                return train.EconomyFare;
            }
            return 0;
        }
    }
}
