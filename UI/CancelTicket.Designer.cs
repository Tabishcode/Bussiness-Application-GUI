
namespace TMS.UI
{
    partial class CancelTicket
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
            this.searchBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.existLbl = new System.Windows.Forms.Label();
            this.wrongLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Animated = true;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderColor = System.Drawing.Color.SandyBrown;
            this.searchBtn.BorderRadius = 10;
            this.searchBtn.DefaultAutoSize = true;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.IndicateFocus = true;
            this.searchBtn.Location = new System.Drawing.Point(372, 234);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 38);
            this.searchBtn.TabIndex = 61;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseTransparentBackground = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(87, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(461, 32);
            this.label12.TabIndex = 60;
            this.label12.Text = "Cancel Ticket By Entering Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(221, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 59;
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(291, 149);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(311, 26);
            this.nameBx.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Enter Customer Name:";
            // 
            // existLbl
            // 
            this.existLbl.AutoSize = true;
            this.existLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existLbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.existLbl.Location = new System.Drawing.Point(488, 200);
            this.existLbl.Name = "existLbl";
            this.existLbl.Size = new System.Drawing.Size(114, 23);
            this.existLbl.TabIndex = 62;
            this.existLbl.Text = "Ticket Exist";
            this.existLbl.Visible = false;
            // 
            // wrongLbl
            // 
            this.wrongLbl.AutoSize = true;
            this.wrongLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongLbl.Location = new System.Drawing.Point(294, 188);
            this.wrongLbl.Name = "wrongLbl";
            this.wrongLbl.Size = new System.Drawing.Size(188, 22);
            this.wrongLbl.TabIndex = 63;
            this.wrongLbl.Text = "Please Enter Correct";
            this.wrongLbl.Visible = false;
            // 
            // CancelTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.wrongLbl);
            this.Controls.Add(this.existLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.label1);
            this.Name = "CancelTicket";
            this.Size = new System.Drawing.Size(794, 448);
            this.Load += new System.EventHandler(this.CancelTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton searchBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label existLbl;
        private System.Windows.Forms.Label wrongLbl;
    }
}
