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
    public partial class UnRegTrain : UserControl
    {
        RegisterTrain train;
        bool flagForTrain = false;
        public UnRegTrain()
        {
            InitializeComponent();
        }

        private void UnRegTrain_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBtn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List" + RegisterTrainDL.registerTrains.Count);
            train = RegisterTrainDL.getTrainObj(TrainBx.Text);
            MessageBox.Show(TrainBx.Text);
            if (train != null )
            {
                flagForTrain = true;
                label4.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
            }
            else
            {
                label4.Visible = false;
                label3.Visible = true;
                label2.Visible = false;
            }

        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            if(flagForTrain)
            {
                RegisterTrainDL.removeTrainFromList(train);
                RegisterTrainDL.StoreAfterChangeLinkedTrainToFile();
                MessageBox.Show("UnRegistered Succesfully");
            }
        }
    }
}