
namespace TMS.UI
{
    partial class ManageDrivers
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
            this.DriverNameLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.IDBx = new System.Windows.Forms.TextBox();
            this.DriverIDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(395, 141);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(206, 26);
            this.nameBx.TabIndex = 55;
            // 
            // DriverNameLbl
            // 
            this.DriverNameLbl.AutoSize = true;
            this.DriverNameLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DriverNameLbl.Location = new System.Drawing.Point(251, 141);
            this.DriverNameLbl.Name = "DriverNameLbl";
            this.DriverNameLbl.Size = new System.Drawing.Size(138, 26);
            this.DriverNameLbl.TabIndex = 48;
            this.DriverNameLbl.Text = "DriverName";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(643, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(478, 157);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
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
            this.AddBtn.Location = new System.Drawing.Point(533, 351);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(180, 45);
            this.AddBtn.TabIndex = 46;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(754, 353);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteBtn.TabIndex = 45;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.UpdateBtn.Location = new System.Drawing.Point(992, 351);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(180, 45);
            this.UpdateBtn.TabIndex = 44;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // IDBx
            // 
            this.IDBx.Location = new System.Drawing.Point(398, 230);
            this.IDBx.Name = "IDBx";
            this.IDBx.Size = new System.Drawing.Size(206, 26);
            this.IDBx.TabIndex = 57;
            // 
            // DriverIDLbl
            // 
            this.DriverIDLbl.AutoSize = true;
            this.DriverIDLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverIDLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DriverIDLbl.Location = new System.Drawing.Point(251, 230);
            this.DriverIDLbl.Name = "DriverIDLbl";
            this.DriverIDLbl.Size = new System.Drawing.Size(99, 26);
            this.DriverIDLbl.TabIndex = 56;
            this.DriverIDLbl.Text = "Driver ID";
            // 
            // ManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IDBx);
            this.Controls.Add(this.DriverIDLbl);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.DriverNameLbl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Name = "ManageDrivers";
            this.Size = new System.Drawing.Size(1509, 506);
            this.Load += new System.EventHandler(this.ManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label DriverNameLbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2GradientButton AddBtn;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateBtn;
        private System.Windows.Forms.TextBox IDBx;
        private System.Windows.Forms.Label DriverIDLbl;
    }
}
