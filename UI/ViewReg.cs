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
using TMS.UI;
namespace TMS.UI
{
    public partial class ViewReg : UserControl
    {
        public ViewReg()
        {
            InitializeComponent();
        }

        private void ViewReg_Load(object sender, EventArgs e)
        {
            RegTainsGrid.DataSource = RegisterTrainDL.registerTrains;
            CustomerGrid.DataSource = CustomerDL.CustomerList;
           
        }
    }
}
