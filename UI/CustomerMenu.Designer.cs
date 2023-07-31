
namespace TMS.UI
{
    partial class CustomerMenu
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
            this.HeadLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageTrainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelTicketBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.logOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.cancelTicketBtn);
            this.panel1.Controls.Add(this.manageTrainBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.HeadLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 162);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLbl.ForeColor = System.Drawing.Color.White;
            this.HeadLbl.Location = new System.Drawing.Point(334, 36);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(165, 32);
            this.HeadLbl.TabIndex = 2;
            this.HeadLbl.Text = "Welcome , ";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1434, 348);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // manageTrainBtn
            // 
            this.manageTrainBtn.Animated = true;
            this.manageTrainBtn.AutoRoundedCorners = true;
            this.manageTrainBtn.BackColor = System.Drawing.Color.Transparent;
            this.manageTrainBtn.BorderColor = System.Drawing.Color.Orange;
            this.manageTrainBtn.BorderRadius = 31;
            this.manageTrainBtn.CustomBorderColor = System.Drawing.Color.OrangeRed;
            this.manageTrainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageTrainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageTrainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageTrainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageTrainBtn.FillColor = System.Drawing.Color.Red;
            this.manageTrainBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.manageTrainBtn.ForeColor = System.Drawing.Color.White;
            this.manageTrainBtn.Location = new System.Drawing.Point(140, 83);
            this.manageTrainBtn.Name = "manageTrainBtn";
            this.manageTrainBtn.Size = new System.Drawing.Size(222, 65);
            this.manageTrainBtn.TabIndex = 9;
            this.manageTrainBtn.Text = "View All Trains";
            this.manageTrainBtn.UseTransparentBackground = true;
            this.manageTrainBtn.Click += new System.EventHandler(this.manageTrainBtn_Click);
            // 
            // cancelTicketBtn
            // 
            this.cancelTicketBtn.Animated = true;
            this.cancelTicketBtn.AutoRoundedCorners = true;
            this.cancelTicketBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelTicketBtn.BorderColor = System.Drawing.Color.Red;
            this.cancelTicketBtn.BorderRadius = 31;
            this.cancelTicketBtn.CustomBorderColor = System.Drawing.Color.Red;
            this.cancelTicketBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelTicketBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelTicketBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelTicketBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelTicketBtn.FillColor = System.Drawing.Color.Red;
            this.cancelTicketBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.cancelTicketBtn.ForeColor = System.Drawing.Color.White;
            this.cancelTicketBtn.Location = new System.Drawing.Point(1130, 83);
            this.cancelTicketBtn.Name = "cancelTicketBtn";
            this.cancelTicketBtn.Size = new System.Drawing.Size(222, 65);
            this.cancelTicketBtn.TabIndex = 10;
            this.cancelTicketBtn.Text = "Cancel Ticket";
            this.cancelTicketBtn.UseTransparentBackground = true;
            this.cancelTicketBtn.Click += new System.EventHandler(this.cancelTicketBtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Red;
            this.guna2Button2.BorderRadius = 31;
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(818, 83);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(222, 65);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Text = "Print Your Ticket";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Red;
            this.guna2Button3.BorderRadius = 31;
            this.guna2Button3.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Red;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(491, 83);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(222, 65);
            this.guna2Button3.TabIndex = 12;
            this.guna2Button3.Text = "Go Online Ticket";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.logOutBtn.Location = new System.Drawing.Point(1288, 19);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(123, 36);
            this.logOutBtn.TabIndex = 13;
            this.logOutBtn.Text = "LogOut";
            this.logOutBtn.UseTransparentBackground = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMS.Properties.Resources.icons8_user;
            this.pictureBox1.Location = new System.Drawing.Point(766, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1438, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button cancelTicketBtn;
        private Guna.UI2.WinForms.Guna2Button manageTrainBtn;
        private Guna.UI2.WinForms.Guna2Button logOutBtn;
    }
}