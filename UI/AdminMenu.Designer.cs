
namespace TMS.UI
{
    partial class AdminMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RegisterTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UnRegisterTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.viewRegisteredBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ManageDriverBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.HeadLbl);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1741, 91);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(197, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train Managment System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.RegisterTrainBtn);
            this.panel2.Controls.Add(this.UnRegisterTrainBtn);
            this.panel2.Controls.Add(this.viewRegisteredBtn);
            this.panel2.Controls.Add(this.ManageDriverBtn);
            this.panel2.Controls.Add(this.manageTrainBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1741, 65);
            this.panel2.TabIndex = 1;
            // 
            // RegisterTrainBtn
            // 
            this.RegisterTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTrainBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterTrainBtn.Location = new System.Drawing.Point(661, -3);
            this.RegisterTrainBtn.Name = "RegisterTrainBtn";
            this.RegisterTrainBtn.Size = new System.Drawing.Size(263, 65);
            this.RegisterTrainBtn.TabIndex = 5;
            this.RegisterTrainBtn.Text = "Register Trains";
            this.RegisterTrainBtn.Click += new System.EventHandler(this.RegisterTrainBtn_Click);
            // 
            // UnRegisterTrainBtn
            // 
            this.UnRegisterTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UnRegisterTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UnRegisterTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UnRegisterTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UnRegisterTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnRegisterTrainBtn.ForeColor = System.Drawing.Color.White;
            this.UnRegisterTrainBtn.Location = new System.Drawing.Point(1024, 3);
            this.UnRegisterTrainBtn.Name = "UnRegisterTrainBtn";
            this.UnRegisterTrainBtn.Size = new System.Drawing.Size(222, 65);
            this.UnRegisterTrainBtn.TabIndex = 4;
            this.UnRegisterTrainBtn.Text = "UnRegister Trains";
            this.UnRegisterTrainBtn.Click += new System.EventHandler(this.UnRegisterTrainBtn_Click);
            // 
            // viewRegisteredBtn
            // 
            this.viewRegisteredBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewRegisteredBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewRegisteredBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewRegisteredBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewRegisteredBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRegisteredBtn.ForeColor = System.Drawing.Color.White;
            this.viewRegisteredBtn.Location = new System.Drawing.Point(1373, 0);
            this.viewRegisteredBtn.Name = "viewRegisteredBtn";
            this.viewRegisteredBtn.Size = new System.Drawing.Size(222, 65);
            this.viewRegisteredBtn.TabIndex = 3;
            this.viewRegisteredBtn.Text = "View Registered";
            this.viewRegisteredBtn.Click += new System.EventHandler(this.viewRegisteredBtn_Click);
            // 
            // ManageDriverBtn
            // 
            this.ManageDriverBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManageDriverBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManageDriverBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManageDriverBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManageDriverBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageDriverBtn.ForeColor = System.Drawing.Color.White;
            this.ManageDriverBtn.Location = new System.Drawing.Point(354, -3);
            this.ManageDriverBtn.Name = "ManageDriverBtn";
            this.ManageDriverBtn.Size = new System.Drawing.Size(222, 65);
            this.ManageDriverBtn.TabIndex = 2;
            this.ManageDriverBtn.Text = "Manage Drivers";
            this.ManageDriverBtn.Click += new System.EventHandler(this.ManageDriverBtn_Click);
            // 
            // manageTrainBtn
            // 
            this.manageTrainBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manageTrainBtn.BorderColor = System.Drawing.Color.Red;
            this.manageTrainBtn.CustomBorderColor = System.Drawing.Color.Red;
            this.manageTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTrainBtn.ForeColor = System.Drawing.Color.White;
            this.manageTrainBtn.Location = new System.Drawing.Point(3, 0);
            this.manageTrainBtn.Name = "manageTrainBtn";
            this.manageTrainBtn.Size = new System.Drawing.Size(222, 65);
            this.manageTrainBtn.TabIndex = 0;
            this.manageTrainBtn.Text = "Manage Trains ";
            this.manageTrainBtn.Click += new System.EventHandler(this.manageTrainBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 156);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1741, 579);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Animated = true;
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.BorderColor = System.Drawing.Color.Red;
            this.logOutBtn.CustomBorderColor = System.Drawing.Color.Red;
            this.logOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutBtn.FillColor = System.Drawing.Color.Red;
            this.logOutBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(1540, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(123, 36);
            this.logOutBtn.TabIndex = 14;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseTransparentBackground = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMS.Properties.Resources.train;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLbl.ForeColor = System.Drawing.Color.White;
            this.HeadLbl.Location = new System.Drawing.Point(741, 29);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(165, 32);
            this.HeadLbl.TabIndex = 3;
            this.HeadLbl.Text = "Welcome , ";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 735);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button RegisterTrainBtn;
        private Guna.UI2.WinForms.Guna2Button UnRegisterTrainBtn;
        private Guna.UI2.WinForms.Guna2Button viewRegisteredBtn;
        private Guna.UI2.WinForms.Guna2Button ManageDriverBtn;
        private Guna.UI2.WinForms.Guna2Button manageTrainBtn;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
        private System.Windows.Forms.Label HeadLbl;
    }
}