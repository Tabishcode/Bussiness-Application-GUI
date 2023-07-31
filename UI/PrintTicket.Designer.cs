
namespace TMS.UI
{
    partial class PrintTicket
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
            this.nameBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrainNameLbl = new System.Windows.Forms.Label();
            this.dearLbl = new System.Windows.Forms.Label();
            this.FromLbl = new System.Windows.Forms.Label();
            this.ToLbl = new System.Windows.Forms.Label();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.fareLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dateTimeBx = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(381, 140);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(311, 26);
            this.nameBx.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMS.Properties.Resources.ticket;
            this.pictureBox1.Location = new System.Drawing.Point(737, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // TrainNameLbl
            // 
            this.TrainNameLbl.AutoSize = true;
            this.TrainNameLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainNameLbl.ForeColor = System.Drawing.Color.White;
            this.TrainNameLbl.Location = new System.Drawing.Point(799, 158);
            this.TrainNameLbl.Name = "TrainNameLbl";
            this.TrainNameLbl.Size = new System.Drawing.Size(126, 23);
            this.TrainNameLbl.TabIndex = 10;
            this.TrainNameLbl.Text = "Train Name:";
            // 
            // dearLbl
            // 
            this.dearLbl.AutoSize = true;
            this.dearLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dearLbl.ForeColor = System.Drawing.Color.White;
            this.dearLbl.Location = new System.Drawing.Point(863, 101);
            this.dearLbl.Name = "dearLbl";
            this.dearLbl.Size = new System.Drawing.Size(74, 23);
            this.dearLbl.TabIndex = 11;
            this.dearLbl.Text = "Dear , ";
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLbl.ForeColor = System.Drawing.Color.White;
            this.FromLbl.Location = new System.Drawing.Point(795, 228);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(130, 23);
            this.FromLbl.TabIndex = 12;
            this.FromLbl.Text = "Going From:";
            this.FromLbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLbl.ForeColor = System.Drawing.Color.White;
            this.ToLbl.Location = new System.Drawing.Point(822, 263);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(103, 23);
            this.ToLbl.TabIndex = 13;
            this.ToLbl.Text = "Going To:";
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLbl.ForeColor = System.Drawing.Color.White;
            this.TypeLbl.Location = new System.Drawing.Point(812, 295);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(125, 23);
            this.TypeLbl.TabIndex = 14;
            this.TypeLbl.Text = "Ticket Type:";
            this.TypeLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // fareLbl
            // 
            this.fareLbl.AutoSize = true;
            this.fareLbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fareLbl.ForeColor = System.Drawing.Color.White;
            this.fareLbl.Location = new System.Drawing.Point(851, 327);
            this.fareLbl.Name = "fareLbl";
            this.fareLbl.Size = new System.Drawing.Size(52, 23);
            this.fareLbl.TabIndex = 15;
            this.fareLbl.Text = "Fare";
            this.fareLbl.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(768, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date and Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(851, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Thank You for using our service";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(908, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ticket Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(169, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(502, 32);
            this.label12.TabIndex = 19;
            this.label12.Text = "Print Your Ticket By Entering Name ";
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
            this.searchBtn.Location = new System.Drawing.Point(528, 213);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 38);
            this.searchBtn.TabIndex = 56;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseTransparentBackground = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dateTimeBx
            // 
            this.dateTimeBx.Location = new System.Drawing.Point(931, 190);
            this.dateTimeBx.Name = "dateTimeBx";
            this.dateTimeBx.Size = new System.Drawing.Size(200, 26);
            this.dateTimeBx.TabIndex = 57;
            // 
            // PrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.dateTimeBx);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fareLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.ToLbl);
            this.Controls.Add(this.FromLbl);
            this.Controls.Add(this.dearLbl);
            this.Controls.Add(this.TrainNameLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.label1);
            this.Name = "PrintTicket";
            this.Size = new System.Drawing.Size(1304, 637);
            this.Load += new System.EventHandler(this.PrintTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TrainNameLbl;
        private System.Windows.Forms.Label dearLbl;
        private System.Windows.Forms.Label FromLbl;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label fareLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GradientButton searchBtn;
        private System.Windows.Forms.DateTimePicker dateTimeBx;
    }
}
