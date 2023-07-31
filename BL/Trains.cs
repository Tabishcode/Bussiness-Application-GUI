using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
    class Trains
    {
        private string trainName;
        private string goingFrom;
        private string goingTo;
        private DateTime departureTime;
        private int acFare;
        private int bussinessFare;
        private int economyFare;
        public Trains(string TrainName, string GoingFrom, string GoingTo,DateTime departureTime, int AcFare, int BussinessFare, int EconomyFare)
        {
            this.TrainName = TrainName;
            this.GoingFrom = GoingFrom;
            this.GoingTo = GoingTo;
            this.DepartureTime = departureTime;
            this.AcFare = AcFare;
            this.BussinessFare = BussinessFare;
            this.EconomyFare = EconomyFare;
        }

        public string TrainName { get => trainName; set => trainName = value; }
        public string GoingFrom { get => goingFrom; set => goingFrom = value; }
        public string GoingTo { get => goingTo; set => goingTo = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
        public int AcFare { get => acFare; set => acFare = value; }
        public int BussinessFare { get => bussinessFare; set => bussinessFare = value; }
        public int EconomyFare { get => economyFare; set => economyFare = value; }
     
    }
}
