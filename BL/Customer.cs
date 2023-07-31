using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
    class Customer : MUser
    {
        private string customerName;
        private string trainName;
        private string goingFrom;
        private string goingTo;
        private DateTime departureTime;
        private string ticketType;
        private float fare;

        public string CustomerName { get => customerName; set => customerName = value; }
        public string TrainName { get => trainName; set => trainName = value; }
        public string GoingFrom { get => goingFrom; set => goingFrom = value; }
        public string GoingTo { get => goingTo; set => goingTo = value; }
        public DateTime  DepartureTime { get => departureTime; set => departureTime = value; }
        public string TicketType { get => ticketType; set => ticketType = value; }
        public float Fare { get => fare; set => fare = value; }

        public Customer(string UserName, string Password, string role) : base(UserName, Password, role)
        {
        }
        public Customer()
        {

        }
        public Customer(string TrainName, string GoingFrom, string GoingTo, DateTime  DepartureTime, string TicketType, float fare, string CustomerName)
        {
            this.TrainName = TrainName;
            this.GoingFrom = GoingFrom;
            this.GoingTo = GoingTo;
            this.DepartureTime = DepartureTime;
            this.TicketType = TicketType;
            this.Fare = fare;
            this.CustomerName = CustomerName;
        }


    }
}
