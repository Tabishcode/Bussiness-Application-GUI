using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
    class RegisterTrain
    {
        // Train Class paremeters
        private string trainName;
        private int acSeats;
        private int businessSeats;
        private int economySeats;
        private string goingFrom;
        private string goingTo;
        private DateTime departureTime;
        private int acFare;
        private int bussinessFare;
        private int economyFare;
        //Driver Class Paremeters
        private string driverName;
        private string driverID;
        public RegisterTrain()
        {

        }
        public RegisterTrain (string TrainName, string GoingFrom, string GoingTo, DateTime DepartureTime, int AcFare, int BussinessFare, int EconomyFare, string DriverName, string DriverID, int AcSeats, int BussinessSeats, int EconomySeats)
        {
            this.TrainName = TrainName;
            this.GoingFrom = GoingFrom;
            this.GoingTo = GoingTo;
            this.DepartureTime = DepartureTime;
            this.AcFare = AcFare;
            this.BussinessFare = BussinessFare;
            this.EconomyFare = EconomyFare;
            this.DriverName = DriverName;
            this.DriverID = DriverID;
            this.AcSeats = AcSeats;
            this.BusinessSeats = BussinessSeats;
            this.EconomySeats = EconomySeats;
        }

        public string TrainName { get => trainName; set => trainName = value; }
        public int AcSeats { get => acSeats; set => acSeats = value; }
        public int BusinessSeats { get => businessSeats; set => businessSeats = value; }
        public int EconomySeats { get => economySeats; set => economySeats = value; }
        public string GoingFrom { get => goingFrom; set => goingFrom = value; }
        public string GoingTo { get => goingTo; set => goingTo = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
        public int AcFare { get => acFare; set => acFare = value; }
        public int BussinessFare { get => bussinessFare; set => bussinessFare = value; }
        public int EconomyFare { get => economyFare; set => economyFare = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        public string DriverID { get => driverID; set => driverID = value; }
    }
}
