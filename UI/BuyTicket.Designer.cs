
namespace TMS.UI
{
    partial class BuyTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGoingFrom = new System.Windows.Forms.ComboBox();
            this.ComboGoingTo = new System.Windows.Forms.ComboBox();
            this.correctLbl = new System.Windows.Forms.Label();
            this.wrongLbl = new System.Windows.Forms.Label();
            this.checkBtn1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BusinessLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EconomyLbl = new System.Windows.Forms.Label();
            this.AcSeatLbl = new System.Windows.Forms.Label();
            this.AcChk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BusinessChk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.EconomyChk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.buyBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Customer Name:";
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(399, 59);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(311, 26);
            this.nameBx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = " Going From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(268, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = " Going To";
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
            this.comboGoingFrom.Location = new System.Drawing.Point(399, 119);
            this.comboGoingFrom.Name = "comboGoingFrom";
            this.comboGoingFrom.Size = new System.Drawing.Size(121, 28);
            this.comboGoingFrom.TabIndex = 35;
            // 
            // ComboGoingTo
            // 
            this.ComboGoingTo.FormattingEnabled = true;
            this.ComboGoingTo.Items.AddRange(new object[] {
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
            this.ComboGoingTo.Location = new System.Drawing.Point(399, 177);
            this.ComboGoingTo.Name = "ComboGoingTo";
            this.ComboGoingTo.Size = new System.Drawing.Size(121, 28);
            this.ComboGoingTo.TabIndex = 36;
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.BackColor = System.Drawing.Color.ForestGreen;
            this.correctLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLbl.ForeColor = System.Drawing.Color.Navy;
            this.correctLbl.Location = new System.Drawing.Point(477, 254);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(144, 22);
            this.correctLbl.TabIndex = 40;
            this.correctLbl.Text = "Seats Available";
            this.correctLbl.Visible = false;
            // 
            // wrongLbl
            // 
            this.wrongLbl.AutoSize = true;
            this.wrongLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongLbl.Location = new System.Drawing.Point(332, 232);
            this.wrongLbl.Name = "wrongLbl";
            this.wrongLbl.Size = new System.Drawing.Size(188, 22);
            this.wrongLbl.TabIndex = 39;
            this.wrongLbl.Text = "Please Enter Correct";
            this.wrongLbl.Visible = false;
            // 
            // checkBtn1
            // 
            this.checkBtn1.BackColor = System.Drawing.Color.Transparent;
            this.checkBtn1.BorderColor = System.Drawing.Color.SandyBrown;
            this.checkBtn1.BorderRadius = 10;
            this.checkBtn1.DefaultAutoSize = true;
            this.checkBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkBtn1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkBtn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBtn1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBtn1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkBtn1.ForeColor = System.Drawing.Color.White;
            this.checkBtn1.IndicateFocus = true;
            this.checkBtn1.Location = new System.Drawing.Point(593, 207);
            this.checkBtn1.Name = "checkBtn1";
            this.checkBtn1.Size = new System.Drawing.Size(190, 33);
            this.checkBtn1.TabIndex = 38;
            this.checkBtn1.Text = "check Availability";
            this.checkBtn1.UseTransparentBackground = true;
            this.checkBtn1.Click += new System.EventHandler(this.checkBtn1_Click);
            // 
            // BusinessLbl
            // 
            this.BusinessLbl.AutoSize = true;
            this.BusinessLbl.BackColor = System.Drawing.Color.Honeydew;
            this.BusinessLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessLbl.ForeColor = System.Drawing.Color.Navy;
            this.BusinessLbl.Location = new System.Drawing.Point(502, 355);
            this.BusinessLbl.Name = "BusinessLbl";
            this.BusinessLbl.Size = new System.Drawing.Size(20, 22);
            this.BusinessLbl.TabIndex = 45;
            this.BusinessLbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(268, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "seats:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(661, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 48;
            this.label12.Text = "seats:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(446, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 49;
            this.label13.Text = "seats:";
            // 
            // EconomyLbl
            // 
            this.EconomyLbl.AutoSize = true;
            this.EconomyLbl.BackColor = System.Drawing.Color.Honeydew;
            this.EconomyLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EconomyLbl.ForeColor = System.Drawing.Color.Navy;
            this.EconomyLbl.Location = new System.Drawing.Point(717, 353);
            this.EconomyLbl.Name = "EconomyLbl";
            this.EconomyLbl.Size = new System.Drawing.Size(20, 22);
            this.EconomyLbl.TabIndex = 50;
            this.EconomyLbl.Text = "0";
            // 
            // AcSeatLbl
            // 
            this.AcSeatLbl.AutoSize = true;
            this.AcSeatLbl.BackColor = System.Drawing.Color.Honeydew;
            this.AcSeatLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcSeatLbl.ForeColor = System.Drawing.Color.Navy;
            this.AcSeatLbl.Location = new System.Drawing.Point(324, 356);
            this.AcSeatLbl.Name = "AcSeatLbl";
            this.AcSeatLbl.Size = new System.Drawing.Size(20, 22);
            this.AcSeatLbl.TabIndex = 51;
            this.AcSeatLbl.Text = "0";
            // 
            // AcChk
            // 
            this.AcChk.Animated = true;
            this.AcChk.AutoSize = true;
            this.AcChk.BackColor = System.Drawing.Color.Navy;
            this.AcChk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AcChk.CheckedState.BorderRadius = 0;
            this.AcChk.CheckedState.BorderThickness = 0;
            this.AcChk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AcChk.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcChk.ForeColor = System.Drawing.Color.White;
            this.AcChk.Location = new System.Drawing.Point(242, 330);
            this.AcChk.Name = "AcChk";
            this.AcChk.Size = new System.Drawing.Size(102, 23);
            this.AcChk.TabIndex = 52;
            this.AcChk.Text = "AC Class";
            this.AcChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AcChk.UncheckedState.BorderRadius = 0;
            this.AcChk.UncheckedState.BorderThickness = 0;
            this.AcChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AcChk.UseVisualStyleBackColor = false;
            this.AcChk.CheckedChanged += new System.EventHandler(this.AcChk_CheckedChanged);
            // 
            // BusinessChk
            // 
            this.BusinessChk.Animated = true;
            this.BusinessChk.AutoSize = true;
            this.BusinessChk.BackColor = System.Drawing.Color.Navy;
            this.BusinessChk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BusinessChk.CheckedState.BorderRadius = 0;
            this.BusinessChk.CheckedState.BorderThickness = 0;
            this.BusinessChk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BusinessChk.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessChk.ForeColor = System.Drawing.Color.White;
            this.BusinessChk.Location = new System.Drawing.Point(438, 330);
            this.BusinessChk.Name = "BusinessChk";
            this.BusinessChk.Size = new System.Drawing.Size(153, 23);
            this.BusinessChk.TabIndex = 53;
            this.BusinessChk.Text = "BUSSINESS Class";
            this.BusinessChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BusinessChk.UncheckedState.BorderRadius = 0;
            this.BusinessChk.UncheckedState.BorderThickness = 0;
            this.BusinessChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BusinessChk.UseVisualStyleBackColor = false;
            this.BusinessChk.CheckedChanged += new System.EventHandler(this.BusinessChk_CheckedChanged);
            // 
            // EconomyChk
            // 
            this.EconomyChk.Animated = true;
            this.EconomyChk.AutoSize = true;
            this.EconomyChk.BackColor = System.Drawing.Color.Navy;
            this.EconomyChk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EconomyChk.CheckedState.BorderRadius = 0;
            this.EconomyChk.CheckedState.BorderThickness = 0;
            this.EconomyChk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EconomyChk.CheckMarkColor = System.Drawing.Color.Lime;
            this.EconomyChk.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EconomyChk.ForeColor = System.Drawing.Color.White;
            this.EconomyChk.Location = new System.Drawing.Point(665, 327);
            this.EconomyChk.Name = "EconomyChk";
            this.EconomyChk.Size = new System.Drawing.Size(160, 23);
            this.EconomyChk.TabIndex = 54;
            this.EconomyChk.Text = "ECONOMY Class";
            this.EconomyChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EconomyChk.UncheckedState.BorderRadius = 0;
            this.EconomyChk.UncheckedState.BorderThickness = 0;
            this.EconomyChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EconomyChk.UseVisualStyleBackColor = false;
            this.EconomyChk.CheckedChanged += new System.EventHandler(this.EconomyChk_CheckedChanged);
            // 
            // buyBtn
            // 
            this.buyBtn.Animated = true;
            this.buyBtn.BackColor = System.Drawing.Color.Transparent;
            this.buyBtn.BorderColor = System.Drawing.Color.SandyBrown;
            this.buyBtn.BorderRadius = 10;
            this.buyBtn.DefaultAutoSize = true;
            this.buyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buyBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buyBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyBtn.IndicateFocus = true;
            this.buyBtn.Location = new System.Drawing.Point(876, 353);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(128, 38);
            this.buyBtn.TabIndex = 55;
            this.buyBtn.Text = "Buy Now";
            this.buyBtn.UseTransparentBackground = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMS.Properties.Resources.GETTICKET;
            this.pictureBox1.Location = new System.Drawing.Point(1058, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.EconomyChk);
            this.Controls.Add(this.BusinessChk);
            this.Controls.Add(this.AcChk);
            this.Controls.Add(this.AcSeatLbl);
            this.Controls.Add(this.EconomyLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BusinessLbl);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.wrongLbl);
            this.Controls.Add(this.checkBtn1);
            this.Controls.Add(this.ComboGoingTo);
            this.Controls.Add(this.comboGoingFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.label1);
            this.Name = "BuyTicket";
            this.Size = new System.Drawing.Size(1461, 469);
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGoingFrom;
        private System.Windows.Forms.ComboBox ComboGoingTo;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.Label wrongLbl;
        private Guna.UI2.WinForms.Guna2GradientButton checkBtn1;
        private System.Windows.Forms.Label BusinessLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label EconomyLbl;
        private System.Windows.Forms.Label AcSeatLbl;
        private Guna.UI2.WinForms.Guna2CheckBox AcChk;
        private Guna.UI2.WinForms.Guna2CheckBox BusinessChk;
        private Guna.UI2.WinForms.Guna2CheckBox EconomyChk;
        private Guna.UI2.WinForms.Guna2GradientButton buyBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
