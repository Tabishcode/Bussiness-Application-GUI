
namespace TMS.UI
{
    partial class ViewReg
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
            this.RegTainsGrid = new System.Windows.Forms.DataGridView();
            this.headLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RegTainsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RegTainsGrid
            // 
            this.RegTainsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegTainsGrid.Location = new System.Drawing.Point(3, 60);
            this.RegTainsGrid.Name = "RegTainsGrid";
            this.RegTainsGrid.RowHeadersWidth = 62;
            this.RegTainsGrid.RowTemplate.Height = 28;
            this.RegTainsGrid.Size = new System.Drawing.Size(1498, 233);
            this.RegTainsGrid.TabIndex = 26;
            // 
            // headLbl
            // 
            this.headLbl.AutoSize = true;
            this.headLbl.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headLbl.Location = new System.Drawing.Point(207, 31);
            this.headLbl.Name = "headLbl";
            this.headLbl.Size = new System.Drawing.Size(608, 26);
            this.headLbl.TabIndex = 27;
            this.headLbl.Text = "All Registered Trains with Derivers to Run on Platform are:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(350, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "All Customers are:";
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(198, 347);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.RowHeadersWidth = 62;
            this.CustomerGrid.RowTemplate.Height = 28;
            this.CustomerGrid.Size = new System.Drawing.Size(846, 233);
            this.CustomerGrid.TabIndex = 29;
            // 
            // ViewReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headLbl);
            this.Controls.Add(this.RegTainsGrid);
            this.Name = "ViewReg";
            this.Size = new System.Drawing.Size(1501, 607);
            this.Load += new System.EventHandler(this.ViewReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegTainsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RegTainsGrid;
        private System.Windows.Forms.Label headLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomerGrid;
    }
}
