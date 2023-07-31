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
namespace TMS.MUserForms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
            string Role = comboBox1.Text;
            MUser mUser = new MUser(UserName, Password, Role);
            if (mUser != null)
            {
                MUserDL.AddIntoList(mUser);
                MUserDL.StoreAllUserIntoFile(Program.path);
                MessageBox.Show("User Added succesfully");
            }
            else
            {
                MessageBox.Show("User Not Added");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
