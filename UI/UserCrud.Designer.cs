
namespace TMS.UI
{
    partial class UserCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoleTxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.DefaultText = "";
            this.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.Location = new System.Drawing.Point(200, 66);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = '\0';
            this.NameTxt.PlaceholderText = "";
            this.NameTxt.SelectedText = "";
            this.NameTxt.Size = new System.Drawing.Size(200, 44);
            this.NameTxt.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Location = new System.Drawing.Point(200, 142);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '\0';
            this.PasswordTxt.PlaceholderText = "";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.Size = new System.Drawing.Size(200, 44);
            this.PasswordTxt.TabIndex = 6;
            // 
            // RoleTxt
            // 
            this.RoleTxt.BackColor = System.Drawing.Color.Transparent;
            this.RoleTxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleTxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoleTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoleTxt.ItemHeight = 30;
            this.RoleTxt.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.RoleTxt.Location = new System.Drawing.Point(200, 217);
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.Size = new System.Drawing.Size(140, 36);
            this.RoleTxt.TabIndex = 8;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor2 = System.Drawing.Color.Black;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(628, 389);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(180, 45);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor2 = System.Drawing.Color.Black;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(341, 389);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor2 = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(93, 389);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(180, 45);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(441, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(727, 202);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserNameLbl.Location = new System.Drawing.Point(17, 66);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(157, 32);
            this.UserNameLbl.TabIndex = 16;
            this.UserNameLbl.Text = "UserName";
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoleLbl.Location = new System.Drawing.Point(45, 217);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(78, 32);
            this.RoleLbl.TabIndex = 17;
            this.RoleLbl.Text = "Role";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordLbl.Location = new System.Drawing.Point(12, 142);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(147, 32);
            this.PasswordLbl.TabIndex = 18;
            this.PasswordLbl.Text = "Password";
            // 
            // UserCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 536);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RoleTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.NameTxt);
            this.Name = "UserCrud";
            this.Text = "UserCrud";
            this.Load += new System.EventHandler(this.UserCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox NameTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2ComboBox RoleTxt;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateBtn;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton AddBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Label PasswordLbl;
    }
}