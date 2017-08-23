namespace TV_Application
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tv = new AxWMPLib.AxWindowsMediaPlayer();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBeyazTV = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Enabled = true;
            this.tv.Location = new System.Drawing.Point(147, 12);
            this.tv.Name = "tv";
            this.tv.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tv.OcxState")));
            this.tv.Size = new System.Drawing.Size(1005, 389);
            this.tv.TabIndex = 1;
            // 
            // pBar
            // 
            this.pBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pBar.Location = new System.Drawing.Point(147, 407);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(1005, 22);
            this.pBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kanal Listesi";
            // 
            // rbBeyazTV
            // 
            this.rbBeyazTV.AutoSize = true;
            this.rbBeyazTV.ForeColor = System.Drawing.SystemColors.Control;
            this.rbBeyazTV.Location = new System.Drawing.Point(23, 60);
            this.rbBeyazTV.Name = "rbBeyazTV";
            this.rbBeyazTV.Size = new System.Drawing.Size(77, 17);
            this.rbBeyazTV.TabIndex = 6;
            this.rbBeyazTV.TabStop = true;
            this.rbBeyazTV.Text = "BEYAZ TV";
            this.rbBeyazTV.UseVisualStyleBackColor = true;
            this.rbBeyazTV.CheckedChanged += new System.EventHandler(this.rbBeyazTV_CheckedChanged);
            this.rbBeyazTV.Click += new System.EventHandler(this.rbBeyazTV_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(23, 83);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Örnek Kanal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Location = new System.Drawing.Point(23, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Örnek Kanal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton3.Location = new System.Drawing.Point(23, 129);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Örnek Kanal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton4.Location = new System.Drawing.Point(23, 152);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Örnek Kanal";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1164, 442);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbBeyazTV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.tv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TV-KOLİK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer tv;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBeyazTV;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

