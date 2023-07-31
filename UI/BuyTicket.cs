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
    public partial class BuyTicket : UserControl
    {
        bool flagForTicket = false;
        public BuyTicket()
        {
            InitializeComponent();
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {

        }

        private void checkBtn1_Click(object sender, EventArgs e)
        {
            RegisterTrain registerTrain = RegisterTrainDL.isDestinationExist(comboGoingFrom.Text, ComboGoingTo.Text);
            if(CustomerDL.isValidCustomerName(nameBx.Text) == null && registerTrain != null)
            {
                correctLbl.Visible = true;
                wrongLbl.Visible = false;
                flagForTicket = true;
            }
            else
            {
                correctLbl.Visible = false;
                wrongLbl.Visible = true;
            }
            if (registerTrain != null && correctLbl.Visible == true)
            {
                AcSeatLbl.Text = registerTrain.AcSeats.ToString();
                BusinessLbl.Text = registerTrain.BussinessFare.ToString();
                EconomyLbl.Text = registerTrain.EconomySeats.ToString();
                
            }

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            bool flagToStore = false;
            bool flagAc = false;
            bool falgBusiness = false;
            bool flagEconomy = false;
            RegisterTrain registerTrain = RegisterTrainDL.isDestinationExist(comboGoingFrom.Text, ComboGoingTo.Text);
            if (flagForTicket)
            {
                if (AcChk.Checked && registerTrain.AcSeats > 0)
                {

                    flagAc = true;
                    flagToStore = true;
                    registerTrain.AcSeats--;
                    MessageBox.Show("AC Ticket has been booked");
                }
                else if (BusinessChk.Checked && registerTrain.BusinessSeats > 0)
                {
                    falgBusiness = true;
                    flagToStore = true;
                    registerTrain.BusinessSeats--;
                    MessageBox.Show("Business Ticket has been booked");
                }
                else if (EconomyChk.Checked && registerTrain.EconomySeats > 0)
                {
                    flagEconomy = true;
                    flagToStore = true;
                    registerTrain.EconomySeats--;
                    MessageBox.Show("Economy Ticket has been booked");
                }
                else
                {
                    MessageBox.Show("Please Enter Correct");
                }
            }
            if(flagToStore)
            {
                string TicketType = getTicketType(flagAc, falgBusiness, flagEconomy);
                float fare = RegisterTrainDL.getFare(TicketType,registerTrain);
                Customer customer = new Customer(registerTrain.TrainName, registerTrain .GoingFrom, registerTrain .GoingTo,registerTrain.DepartureTime, TicketType, fare, nameBx.Text);
                CustomerDL.StoreCustomerDetailToList(customer);
              CustomerDL.StoreCustomerDetailToFile(customer, nameBx.Text);
                RegisterTrainDL.StoreAfterChangeLinkedTrainToFile();
            }
        }
        public string  getTicketType(bool Ac,bool Business,bool Economy)
        {
            if(Ac)
            {
                return "Ac";
            }
            else if(Business)
            {
                return "Business";
            }
            else if(Economy)
            {
                return "Economy";
            }
            return null;
        }

        private void EconomyChk_CheckedChanged(object sender, EventArgs e)
        {
            AcChk.Checked = false;
            BusinessChk.Checked = false;
        }

        private void BusinessChk_CheckedChanged(object sender, EventArgs e)
        {
            AcChk.Checked = false;
            EconomyChk.Checked = false;
        }

        private void AcChk_CheckedChanged(object sender, EventArgs e)
        {
            BusinessChk.Checked = false;
            EconomyChk.Checked = false;
        }
    }
}
