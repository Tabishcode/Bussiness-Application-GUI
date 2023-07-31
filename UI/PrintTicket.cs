using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.DL;
using TMS.BL;
namespace TMS.UI
{
    public partial class PrintTicket : UserControl
    {
        public PrintTicket()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Customer customer =  CustomerDL.isValidCustomerName(nameBx.Text);
            if(customer != null )
            {
                dearLbl.Text = "Dear,  " + customer.CustomerName;
                TrainNameLbl.Text = "Train Name:  " + customer.TrainName;
                FromLbl.Text = "Going From: " + customer.GoingFrom;
                ToLbl.Text = "Going To:" + customer.GoingTo;
                TypeLbl.Text = "Ticket Type: " + customer.TicketType;
                fareLbl.Text = "Fare: " + customer.Fare;
                dateTimeBx.Value = customer.DepartureTime;
            }
        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
