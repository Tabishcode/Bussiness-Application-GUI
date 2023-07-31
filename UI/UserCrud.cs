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
    public partial class UserCrud : Form
    {
        public UserCrud()
        {
            InitializeComponent();
        }
        MUser user;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserCrud_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = MUserDL.mUsersList;

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e) //Add Button
        {
            string Name = NameTxt.Text;
            string Password = PasswordTxt.Text;
            string Role = RoleTxt.Text;
            MUser user = new MUser(Name, Password, Role);
            MUserDL.AddIntoList(user);
            Clear();
            MUserDL.StoreAllUserIntoFile(Program.path);
            dataBind();

        }
        private void dataBind()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = MUserDL.mUsersList;
            dataGridView.Refresh();
        }
        public void  Clear()
        {
            NameTxt.Text = String.Empty;
            PasswordTxt.Text = String.Empty; 
            RoleTxt.Text = String.Empty;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                MUser user = dataGridView.CurrentRow.DataBoundItem as MUser;
                MUserDL.getList.Remove(user);
                MUserDL.StoreAllUserIntoFile(Program.path);
                dataBind();

            }
            catch
            {
               
            }

          }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            if (user!=null)
            {
                user.UserName = NameTxt.Text;
                user.Password = PasswordTxt.Text;
                user.Role = RoleTxt.Text;
                MUserDL.StoreAllUserIntoFile(Program.path);
                dataBind();
                Clear();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            user = dataGridView.CurrentRow.DataBoundItem as MUser;
            NameTxt.Text = user.UserName;
            PasswordTxt.Text = user.Password;
            RoleTxt.Text = user.Role;
        }
    }
}
