namespace Du_an_cuoi_ki
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.bang_xep_hang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bang_xep_hang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "BẢNG XẾP HẠNG";
            // 
            // bang_xep_hang
            // 
            this.bang_xep_hang.AllowUserToOrderColumns = true;
            this.bang_xep_hang.BackgroundColor = System.Drawing.Color.Lime;
            this.bang_xep_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang_xep_hang.Location = new System.Drawing.Point(31, 87);
            this.bang_xep_hang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bang_xep_hang.Name = "bang_xep_hang";
            this.bang_xep_hang.RowHeadersWidth = 51;
            this.bang_xep_hang.RowTemplate.Height = 24;
            this.bang_xep_hang.Size = new System.Drawing.Size(382, 269);
            this.bang_xep_hang.TabIndex = 5;
            this.bang_xep_hang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_xep_hang_CellContentClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(435, 366);
            this.Controls.Add(this.bang_xep_hang);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(452, 411);
            this.Name = "Form4";
            this.Text = "Bảng xếp hạng";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang_xep_hang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView bang_xep_hang;
    }
}