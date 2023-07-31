
namespace TMS.UI
{
    partial class ManageTrains
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrainNameLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.DepartLbl = new System.Windows.Forms.Label();
            this.AcSeatLbl = new System.Windows.Forms.Label();
            this.EcoLbl = new System.Windows.Forms.Label();
            this.BusinessLbl = new System.Windows.Forms.Label();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.comboGoingFrom = new System.Windows.Forms.ComboBox();
            this.comboGoingTo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EconomyBx = new System.Windows.Forms.TextBox();
            this.BusinessBx = new System.Windows.Forms.TextBox();
            this.AcBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainNameLbl
            // 
            this.TrainNameLbl.AutoSize = true;
            this.TrainNameLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TrainNameLbl.Location = new System.Drawing.Point(171, 84);
            this.TrainNameLbl.Name = "TrainNameLbl";
            this.TrainNameLbl.Size = new System.Drawing.Size(127, 26);
            this.TrainNameLbl.TabIndex = 26;
            this.TrainNameLbl.Text = "TrainName";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BorderRadius = 10;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdateBtn.FillColor2 = System.Drawing.Color.DarkOrange;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.Snow;
            this.UpdateBtn.Location = new System.Drawing.Point(1014, 330);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(180, 45);
            this.UpdateBtn.TabIndex = 22;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.Red;
            this.DeleteBtn.FillColor2 = System.Drawing.Color.Brown;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(776, 332);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteBtn.TabIndex = 23;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BorderColor = System.Drawing.Color.Maroon;
            this.AddBtn.BorderRadius = 10;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.Snow;
            this.AddBtn.Location = new System.Drawing.Point(555, 330);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(180, 45);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PasswordLbl.Location = new System.Drawing.Point(162, 129);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(136, 26);
            this.PasswordLbl.TabIndex = 28;
            this.PasswordLbl.Text = "Going From";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(539, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(980, 202);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RoleLbl.Location = new System.Drawing.Point(192, 169);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(106, 26);
            this.RoleLbl.TabIndex = 27;
            this.RoleLbl.Text = "Going To";
            this.RoleLbl.Click += new System.EventHandler(this.RoleLbl_Click);
            // 
            // DepartLbl
            // 
            this.DepartLbl.AutoSize = true;
            this.DepartLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DepartLbl.Location = new System.Drawing.Point(114, 215);
            this.DepartLbl.Name = "DepartLbl";
            this.DepartLbl.Size = new System.Drawing.Size(174, 26);
            this.DepartLbl.TabIndex = 29;
            this.DepartLbl.Text = "Departure Time";
            // 
            // AcSeatLbl
            // 
            this.AcSeatLbl.AutoSize = true;
            this.AcSeatLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcSeatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AcSeatLbl.Location = new System.Drawing.Point(183, 260);
            this.AcSeatLbl.Name = "AcSeatLbl";
            this.AcSeatLbl.Size = new System.Drawing.Size(95, 26);
            this.AcSeatLbl.TabIndex = 30;
            this.AcSeatLbl.Text = "Ac Fare";
            // 
            // EcoLbl
            // 
            this.EcoLbl.AutoSize = true;
            this.EcoLbl.CausesValidation = false;
            this.EcoLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EcoLbl.Location = new System.Drawing.Point(112, 349);
            this.EcoLbl.Name = "EcoLbl";
            this.EcoLbl.Size = new System.Drawing.Size(165, 26);
            this.EcoLbl.TabIndex = 31;
            this.EcoLbl.Text = "Economy Fare";
            // 
            // BusinessLbl
            // 
            this.BusinessLbl.AutoSize = true;
            this.BusinessLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BusinessLbl.Location = new System.Drawing.Point(114, 299);
            this.BusinessLbl.Name = "BusinessLbl";
            this.BusinessLbl.Size = new System.Drawing.Size(163, 26);
            this.BusinessLbl.TabIndex = 32;
            this.BusinessLbl.Text = "Bussiness Fare";
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(318, 84);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(206, 26);
            this.nameBx.TabIndex = 33;
            this.nameBx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboGoingFrom
            // 
            this.comboGoingFrom.FormattingEnabled = true;
            this.comboGoingFrom.Items.AddRange(new object[] {
            "Lahore",
            "Multan",
            "DG Khan",
            "Karachi",
            "Islamabad",
            "Kot Adu",
            "Abbot Abbad",
            "Layyah",
            "Quetta",
            "Peshawar",
            "Askhr",
            "RYK"});
            this.comboGoingFrom.Location = new System.Drawing.Point(318, 127);
            this.comboGoingFrom.Name = "comboGoingFrom";
            this.comboGoingFrom.Size = new System.Drawing.Size(121, 28);
            this.comboGoingFrom.TabIndex = 34;
            this.comboGoingFrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboGoingTo
            // 
            this.comboGoingTo.FormattingEnabled = true;
            this.comboGoingTo.Items.AddRange(new object[] {
            "Lahore",
            "Multan",
            "DG Khan",
            "Karachi",
            "Islamabad",
            "Kot Adu",
            "Abbot Abbad",
            "Layyah",
            "Quetta",
            "Peshawar",
            "Askhr",
            "RYK"});
            this.comboGoingTo.Location = new System.Drawing.Point(318, 169);
            this.comboGoingTo.Name = "comboGoingTo";
            this.comboGoingTo.Size = new System.Drawing.Size(121, 28);
            this.comboGoingTo.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 26);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // EconomyBx
            // 
            this.EconomyBx.Location = new System.Drawing.Point(316, 351);
            this.EconomyBx.Name = "EconomyBx";
            this.EconomyBx.Size = new System.Drawing.Size(123, 26);
            this.EconomyBx.TabIndex = 41;
            // 
            // BusinessBx
            // 
            this.BusinessBx.Location = new System.Drawing.Point(316, 301);
            this.BusinessBx.Name = "BusinessBx";
            this.BusinessBx.Size = new System.Drawing.Size(123, 26);
            this.BusinessBx.TabIndex = 42;
            // 
            // AcBx
            // 
            this.AcBx.Location = new System.Drawing.Point(316, 260);
            this.AcBx.Name = "AcBx";
            this.AcBx.Size = new System.Drawing.Size(123, 26);
            this.AcBx.TabIndex = 43;
            // 
            // ManageTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.AcBx);
            this.Controls.Add(this.BusinessBx);
            this.Controls.Add(this.EconomyBx);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboGoingTo);
            this.Controls.Add(this.comboGoingFrom);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.BusinessLbl);
            this.Controls.Add(this.EcoLbl);
            this.Controls.Add(this.AcSeatLbl);
            this.Controls.Add(this.DepartLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.TrainNameLbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Name = "ManageTrains";
            this.Size = new System.Drawing.Size(1522, 448);
            this.Load += new System.EventHandler(this.ManageTrains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrainNameLbl;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateBtn;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton AddBtn;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Label DepartLbl;
        private System.Windows.Forms.Label AcSeatLbl;
        private System.Windows.Forms.Label EcoLbl;
        private System.Windows.Forms.Label BusinessLbl;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.ComboBox comboGoingFrom;
        private System.Windows.Forms.ComboBox comboGoingTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox EconomyBx;
        private System.Windows.Forms.TextBox BusinessBx;
        private System.Windows.Forms.TextBox AcBx;
    }
}
