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
    public partial class ManageTrains : UserControl
    {
        Trains trains;
        public ManageTrains()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoleLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageTrains_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = TrainDL.TrainsList;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string Name = nameBx.Text;
            string GoingFrom = comboGoingFrom.Text;
            string GoingTo = comboGoingTo.Text;
            DateTime dateTime =  dateTimePicker1.Value;
            string AcFare = AcBx.Text;
            string BusinessFare = BusinessBx.Text;
            string EconomyFare = EconomyBx.Text;

            if (TrainDL.isValidTrainName(Name) == null  && Name != null && GoingFrom != null && GoingTo != null && dateTime != null && AcFare != null && BusinessFare != null && EconomyFare != null && CommonBL.isValidInteger(AcFare) != 0 && CommonBL.isValidInteger(BusinessFare) != 0 && CommonBL.isValidInteger(EconomyFare) != 0)
            {
                Trains trainsObj = new Trains(Name, GoingFrom, GoingTo, dateTime, int.Parse(AcFare), int.Parse(BusinessFare), int.Parse(EconomyFare));
                TrainDL.addTrainsToList(trainsObj);
                TrainDL.storeTrainsAfterChange();
                MessageBox.Show("Train Added succesfully");
                Clear();
                dataBind();
            }
        }
        private void dataBind()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = TrainDL.TrainsList;
            dataGridView.Refresh();
        }
        public void Clear()
        {
             nameBx .Text = String.Empty;
            comboGoingFrom.Text = String.Empty;
            comboGoingTo.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Today;
            AcBx.Text = string.Empty;
            BusinessBx.Text = string.Empty;
            EconomyBx.Text = string.Empty;
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            trains = dataGridView.CurrentRow.DataBoundItem as Trains;
            nameBx.Text = trains.TrainName;
            comboGoingFrom.Text = trains.GoingFrom;
            comboGoingTo.Text = trains.GoingTo;
            dateTimePicker1.Value = trains.DepartureTime;
            AcBx.Text = (trains.AcFare).ToString();
            BusinessBx.Text = trains.BussinessFare.ToString();
            EconomyBx.Text = trains.EconomyFare.ToString();


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Trains trainsObj = dataGridView.CurrentRow.DataBoundItem as Trains;
                if (! RegisterTrainDL.isTrainExist(trainsObj.TrainName))
                {
                    TrainDL.TrainsList.Remove(trainsObj);
                    TrainDL.storeTrainsAfterChange();
                    dataBind();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Could't Delete | Its Registered ");
                }
            }
            catch
            {
                MessageBox.Show("Not Valid");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (trains != null && TrainDL.isValidTrainName(nameBx.Text) == null) 
            {
              trains.TrainName =   nameBx.Text ;
               trains.GoingFrom = comboGoingFrom.Text;
               trains.GoingTo =  comboGoingTo.Text ;
               trains.DepartureTime =  dateTimePicker1.Value ;
              trains.AcFare = int.Parse( AcBx.Text) ;
               trains.BussinessFare = int.Parse( BusinessBx.Text );
              trains.EconomyFare =  int.Parse( EconomyBx.Text);
                TrainDL.storeTrainsAfterChange();
                dataBind();
                Clear();
            }
        }
    }
}
