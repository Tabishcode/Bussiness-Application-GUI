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
using TMS.MUserForms;
using TMS.UI;
namespace TMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            if(!checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.ShowDialog();

            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
            if (UserName != null && Password != null)
            {
                MUser user = new MUser(UserName, Password);
                MUser mUser = MUserDL.isValidLoginData(UserName, Password);
                if (mUser != null)
                {
                    //Main Form
                    if(mUser.isAdmin())
                    {
                        AdminMenu admin = new AdminMenu(UserName);
                        admin.ShowDialog();
                        
                    }
                    else
                    {
                        CustomerMain customer = new CustomerMain(UserName);
                        customer.ShowDialog();
                    }
                }
                }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
