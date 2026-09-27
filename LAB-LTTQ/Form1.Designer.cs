namespace LAB_LTTQ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbODia = new System.Windows.Forms.ComboBox();
            this.cbThuMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBaiHat = new System.Windows.Forms.ListBox();
            this.rtbLoiBaiHat = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // cbODia
            // 
            this.cbODia.FormattingEnabled = true;
            this.cbODia.Location = new System.Drawing.Point(150, 35);
            this.cbODia.Name = "cbODia";
            this.cbODia.Size = new System.Drawing.Size(258, 28);
            this.cbODia.TabIndex = 2;
            this.cbODia.SelectedIndexChanged += new System.EventHandler(this.cbODia_SelectedIndexChanged);
            // 
            // cbThuMuc
            // 
            this.cbThuMuc.FormattingEnabled = true;
            this.cbThuMuc.Location = new System.Drawing.Point(150, 78);
            this.cbThuMuc.Name = "cbThuMuc";
            this.cbThuMuc.Size = new System.Drawing.Size(258, 28);
            this.cbThuMuc.TabIndex = 2;
            this.cbThuMuc.SelectedIndexChanged += new System.EventHandler(this.cbThuMuc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tập tin";
            // 
            // lbBaiHat
            // 
            this.lbBaiHat.FormattingEnabled = true;
            this.lbBaiHat.ItemHeight = 20;
            this.lbBaiHat.Location = new System.Drawing.Point(22, 178);
            this.lbBaiHat.Name = "lbBaiHat";
            this.lbBaiHat.Size = new System.Drawing.Size(385, 224);
            this.lbBaiHat.TabIndex = 3;
            this.lbBaiHat.SelectedIndexChanged += new System.EventHandler(this.lbBaiHat_SelectedIndexChanged);
            // 
            // rtbLoiBaiHat
            // 
            this.rtbLoiBaiHat.Location = new System.Drawing.Point(426, 35);
            this.rtbLoiBaiHat.Name = "rtbLoiBaiHat";
            this.rtbLoiBaiHat.Size = new System.Drawing.Size(324, 653);
            this.rtbLoiBaiHat.TabIndex = 4;
            this.rtbLoiBaiHat.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(22, 408);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(386, 280);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 702);
            this.Controls.Add(this.rtbLoiBaiHat);
            this.Controls.Add(this.lbBaiHat);
            this.Controls.Add(this.cbThuMuc);
            this.Controls.Add(this.cbODia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbODia;
        private System.Windows.Forms.ComboBox cbThuMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbBaiHat;
        private System.Windows.Forms.RichTextBox rtbLoiBaiHat;
    }
}

