namespace LAB_LTTQ
{
    partial class HienThi
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
            this.dgvtSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtSach
            // 
            this.dgvtSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtSach.Location = new System.Drawing.Point(28, 26);
            this.dgvtSach.Name = "dgvtSach";
            this.dgvtSach.RowHeadersWidth = 51;
            this.dgvtSach.RowTemplate.Height = 24;
            this.dgvtSach.Size = new System.Drawing.Size(734, 398);
            this.dgvtSach.TabIndex = 0;
            // 
            // HienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvtSach);
            this.Name = "HienThi";
            this.Text = "HienThi";
            this.Load += new System.EventHandler(this.HienThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtSach;
    }
}