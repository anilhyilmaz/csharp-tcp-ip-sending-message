﻿namespace Sample
{
    partial class frmServer
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtserversorugoster = new System.Windows.Forms.TextBox();
            this.txtsorugoster = new System.Windows.Forms.Button();
            this.lblonlinesayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(252, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8910";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(102, 45);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 22);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(358, 42);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(451, 42);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(102, 89);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(424, 256);
            this.txtStatus.TabIndex = 6;
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(572, 42);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(75, 23);
            this.listele.TabIndex = 7;
            this.listele.Text = "listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(572, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 204);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtserversorugoster
            // 
            this.txtserversorugoster.Location = new System.Drawing.Point(572, 89);
            this.txtserversorugoster.Multiline = true;
            this.txtserversorugoster.Name = "txtserversorugoster";
            this.txtserversorugoster.Size = new System.Drawing.Size(405, 134);
            this.txtserversorugoster.TabIndex = 9;
            // 
            // txtsorugoster
            // 
            this.txtsorugoster.Enabled = false;
            this.txtsorugoster.Location = new System.Drawing.Point(870, 229);
            this.txtsorugoster.Name = "txtsorugoster";
            this.txtsorugoster.Size = new System.Drawing.Size(107, 25);
            this.txtsorugoster.TabIndex = 10;
            this.txtsorugoster.Text = "Soru Yayınla";
            this.txtsorugoster.UseVisualStyleBackColor = true;
            this.txtsorugoster.Click += new System.EventHandler(this.txtsorugoster_Click);
            // 
            // lblonlinesayisi
            // 
            this.lblonlinesayisi.AutoSize = true;
            this.lblonlinesayisi.Location = new System.Drawing.Point(801, 42);
            this.lblonlinesayisi.Name = "lblonlinesayisi";
            this.lblonlinesayisi.Size = new System.Drawing.Size(136, 17);
            this.lblonlinesayisi.TabIndex = 11;
            this.lblonlinesayisi.Text = "Baglı kullanici sayisi:";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 537);
            this.Controls.Add(this.lblonlinesayisi);
            this.Controls.Add(this.txtsorugoster);
            this.Controls.Add(this.txtserversorugoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Name = "frmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtserversorugoster;
        private System.Windows.Forms.Button txtsorugoster;
        private System.Windows.Forms.Label lblonlinesayisi;
    }
}

