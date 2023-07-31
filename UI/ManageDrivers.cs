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
    public partial class ManageDrivers : UserControl
    {
        Driver driver;
        public ManageDrivers()
        {
            InitializeComponent();
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            driver = dataGridView.CurrentRow.DataBoundItem as Driver;
            nameBx.Text = driver.DriverName;
            IDBx.Text = driver.DriverID;
        }
        private void dataBind()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = DriverDL.DriverList;
            dataGridView.Refresh();
        }
        public void Clear()
        {
            nameBx.Text = String.Empty;
            IDBx.Text = String.Empty;
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = DriverDL.DriverList;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string Name = nameBx.Text;
            string ID =  IDBx.Text;
            if (Name != null && ID != null)
            {
                Driver driver = new Driver(Name, ID);
                DriverDL.AddDriverToList(driver);
                DriverDL.StoreAfterChangeDriverDetails();
                dataBind();
                Clear();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Driver driversObj = dataGridView.CurrentRow.DataBoundItem as Driver;
                DriverDL.DriverList.Remove(driversObj);
                DriverDL.StoreAfterChangeDriverDetails();
                dataBind();
                Clear();

            }
            catch
            {
                MessageBox.Show("Not Valid");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(driver != null)
            {
                  driver.DriverName = nameBx.Text;
                 driver.DriverID = IDBx.Text;
                DriverDL.StoreAfterChangeDriverDetails();
                Clear();
                dataBind();
            }
        }
    }
}
