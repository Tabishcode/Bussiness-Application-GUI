using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.BL;
using TMS.DL;
namespace TMS.UI
{
    public partial class RegTrains : UserControl
    {
        bool flagForTrainName = false ;
        bool flagForDriverName = false ;
        Trains trains = null ;
        Driver driver = null ;
        public RegTrains()
        {
            InitializeComponent();


        }

        private void checkBtn1_Click(object sender, EventArgs e)
        {
            trains = TrainDL.isValidTrainName(TrainBx.Text);
            if (TrainBx.Text != null   && trains != null && !RegisterTrainDL.isTrainExist(TrainBx.Text))
            {
                flagForTrainName = true;
                label3.Visible = false;
                label4.Visible = true;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = false;
            }

        }
        private void checkBtn2_Click(object sender, EventArgs e)
        {
            driver = DriverDL.isValidDriver(driverBx.Text);
            if(driverBx.Text != null && !RegisterTrainDL.isDriverExist(driverBx.Text) && driver != null  )
            {
                flagForDriverName = true;
                label5.Visible = false;
                driverValidLbl.Visible = true;
            }
            else
            {
                label5.Visible = true;
                driverValidLbl.Visible = false;
            }

        }
        private void proceedBtn_Click(object sender, EventArgs e)
        {

            if(flagForDriverName && flagForTrainName && CommonBL.isValidInteger(acBx.Text) != 0 &&  CommonBL.isValidInteger(BusinessBx.Text) != 0 && CommonBL.isValidInteger(EconomyBx.Text) != 0)
            {
                RegisterTrain registerTrain = new RegisterTrain(trains.TrainName, trains.GoingFrom, trains.GoingTo, trains.DepartureTime, trains.AcFare, trains.BussinessFare, trains.EconomyFare, driver.DriverName, driver.DriverID, int.Parse(acBx.Text), int.Parse(BusinessBx.Text), int.Parse(EconomyBx.Text));
                MessageBox.Show(registerTrain.DriverName);
                RegisterTrainDL.addRegTrainsToList(registerTrain);
                RegisterTrainDL.addRegTrainsToFileAfterChange();
                MessageBox.Show("Train Registered Succesfully");
                Clear();         
            }
        }
        public void Clear()
        {
            acBx.Text = String.Empty;
            BusinessBx.Text = String.Empty;
            EconomyBx.Text = String.Empty;
            TrainBx.Text = string.Empty;
            driverBx.Text = string.Empty;
            label4.Visible = false;
            driverValidLbl.Visible = false;
        }

        private void RegTrains_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
