namespace AjandaApp_1
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
            this.txtBaşlık = new System.Windows.Forms.TextBox();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.lblAçıklama = new System.Windows.Forms.Label();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpAramaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBaşlık
            // 
            this.txtBaşlık.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaşlık.Location = new System.Drawing.Point(237, 79);
            this.txtBaşlık.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaşlık.Name = "txtBaşlık";
            this.txtBaşlık.Size = new System.Drawing.Size(412, 38);
            this.txtBaşlık.TabIndex = 0;
            this.txtBaşlık.Text = " ";
            this.txtBaşlık.TextChanged += new System.EventHandler(this.txtBaşlık_TextChanged);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.Location = new System.Drawing.Point(86, 92);
            this.lblBaslık.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(124, 25);
            this.lblBaslık.TabIndex = 1;
            this.lblBaslık.Text = "BAŞLIK       :";
            this.lblBaslık.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAçıklama
            // 
            this.lblAçıklama.AutoSize = true;
            this.lblAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAçıklama.Location = new System.Drawing.Point(86, 143);
            this.lblAçıklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAçıklama.Name = "lblAçıklama";
            this.lblAçıklama.Size = new System.Drawing.Size(127, 25);
            this.lblAçıklama.TabIndex = 2;
            this.lblAçıklama.Text = "AÇIKLAMA :";
            this.lblAçıklama.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAçıklama.Location = new System.Drawing.Point(238, 143);
            this.txtAçıklama.MinimumSize = new System.Drawing.Size(4, 100);
            this.txtAçıklama.Multiline = true;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAçıklama.Size = new System.Drawing.Size(411, 252);
            this.txtAçıklama.TabIndex = 3;
            this.txtAçıklama.TextChanged += new System.EventHandler(this.txtAçıklama_TextChanged);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(82, 434);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(128, 25);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih             :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(236, 434);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(234, 30);
            this.dtpTarih.TabIndex = 5;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblNotlar
            // 
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Location = new System.Drawing.Point(666, 106);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(93, 25);
            this.lblNotlar.TabIndex = 6;
            this.lblNotlar.Text = "NOTLAR";
            this.lblNotlar.Click += new System.EventHandler(this.lblNotlar_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnKaydet.Location = new System.Drawing.Point(236, 493);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(163, 30);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstNotlar
            // 
            this.lstNotlar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 25;
            this.lstNotlar.Location = new System.Drawing.Point(671, 146);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(455, 379);
            this.lstNotlar.TabIndex = 8;
            this.lstNotlar.SelectedIndexChanged += new System.EventHandler(this.lstNotlar_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Location = new System.Drawing.Point(435, 493);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 30);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTemizle.Location = new System.Drawing.Point(435, 558);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(161, 30);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(236, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpAramaTarihi
            // 
            this.dtpAramaTarihi.Location = new System.Drawing.Point(848, 558);
            this.dtpAramaTarihi.Name = "dtpAramaTarihi";
            this.dtpAramaTarihi.Size = new System.Drawing.Size(278, 30);
            this.dtpAramaTarihi.TabIndex = 13;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Silver;
            this.btnAra.Location = new System.Drawing.Point(671, 558);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(161, 29);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 641);
            this.Controls.Add(this.dtpAramaTarihi);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblNotlar);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtAçıklama);
            this.Controls.Add(this.lblAçıklama);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.txtBaşlık);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaşlık;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Label lblAçıklama;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpAramaTarihi;
        private System.Windows.Forms.Button btnAra;
    }
}

