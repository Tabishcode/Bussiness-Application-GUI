
namespace TMS.UI
{
    partial class UnRegTrain
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
            this.headLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proceedBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TrainBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBtn1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // headLbl
            // 
            this.headLbl.AutoSize = true;
            this.headLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headLbl.Location = new System.Drawing.Point(573, 39);
            this.headLbl.Name = "headLbl";
            this.headLbl.Size = new System.Drawing.Size(239, 34);
            this.headLbl.TabIndex = 9;
            this.headLbl.Text = "UnRegister Trains";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(259, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Train Name to Unregister";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(809, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valid Train name";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(609, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Not Exist or in use";
            this.label3.Visible = false;
            // 
            // proceedBtn
            // 
            this.proceedBtn.AutoRoundedCorners = true;
            this.proceedBtn.BackColor = System.Drawing.Color.Transparent;
            this.proceedBtn.BorderColor = System.Drawing.Color.SandyBrown;
            this.proceedBtn.BorderRadius = 15;
            this.proceedBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.proceedBtn.DefaultAutoSize = true;
            this.proceedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proceedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proceedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proceedBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proceedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proceedBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.proceedBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.proceedBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.proceedBtn.ForeColor = System.Drawing.Color.White;
            this.proceedBtn.Location = new System.Drawing.Point(810, 297);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(109, 33);
            this.proceedBtn.TabIndex = 21;
            this.proceedBtn.Text = "Proceed";
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // TrainBx
            // 
            this.TrainBx.Location = new System.Drawing.Point(614, 138);
            this.TrainBx.Name = "TrainBx";
            this.TrainBx.Size = new System.Drawing.Size(305, 26);
            this.TrainBx.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(483, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Do You Want to UnRegister That Train ?";
            this.label2.Visible = false;
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
            this.checkBtn1.Location = new System.Drawing.Point(939, 138);
            this.checkBtn1.Name = "checkBtn1";
            this.checkBtn1.Size = new System.Drawing.Size(190, 33);
            this.checkBtn1.TabIndex = 25;
            this.checkBtn1.Text = "check Availability";
            this.checkBtn1.UseTransparentBackground = true;
            this.checkBtn1.Click += new System.EventHandler(this.checkBtn1_Click);
            // 
            // UnRegTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.TrainBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headLbl);
            this.Name = "UnRegTrain";
            this.Size = new System.Drawing.Size(1343, 392);
            this.Load += new System.EventHandler(this.UnRegTrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton proceedBtn;
        private System.Windows.Forms.TextBox TrainBx;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton checkBtn1;
    }
}
