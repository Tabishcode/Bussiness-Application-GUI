using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.BL;
using TMS.UI;
using TMS.MUserForms;
using System.IO;

namespace TMS.DL
{
    class TrainDL
    {
        private static List<Trains> trainsList = new List<Trains>();

        internal static List<Trains> TrainsList { get => trainsList; set => trainsList = value; }
        public static void addTrainsToList(Trains train)
        {
            trainsList.Add(train);
        }
        public static void storeTrainsAfterChange()
        {
            string path = "TrainData.txt";
            StreamWriter file = new StreamWriter(path);

            for (int x = 0; x < trainsList.Count; x++)
            {
                file.WriteLine(trainsList[x].TrainName + "," + trainsList[x].GoingFrom + "," + trainsList[x].GoingTo + "," + trainsList[x].DepartureTime + "," + trainsList[x].AcFare + "," + trainsList[x].BussinessFare + "," + trainsList[x].EconomyFare);

            }
            file.Flush();
            file.Close();


        }
        public static void LoadTrainsFromFile()
        {
            string path = "TrainData.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)

                {
                    string[] word = record.Split(',');
                    Trains trains = new Trains(word[0], word[1], word[2], DateTime.Parse(word[3]), int.Parse(word[4]), int.Parse(word[5]), int.Parse(word[6]));
                    TrainDL.addTrainsToList(trains);
                }
                fileVariable.Close();
            }
        }
        public static Trains isValidTrainName(string TrainName)
        {
            foreach (Trains i in trainsList)
            {
                if ( i.TrainName == TrainName)
                {
                    return i ;
                }
            }
            return null;
        }


    }
}
