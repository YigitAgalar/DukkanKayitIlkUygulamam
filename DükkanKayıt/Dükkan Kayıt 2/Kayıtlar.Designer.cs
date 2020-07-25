namespace Dükkan_Kayıt_2
{
    partial class Kayıtlar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kilometre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MarkaModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İşlem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YeniKayıtBTN = new System.Windows.Forms.Button();
            this.txtkilometre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtislem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmarkamodel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.PlakaAra = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.AdSoyad,
            this.Plaka,
            this.Kilometre,
            this.MarkaModel,
            this.İşlem,
            this.Tarih,
            this.Telefon});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 351);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1020, 186);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 37;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Text = "AdSoyad";
            this.AdSoyad.Width = 143;
            // 
            // Plaka
            // 
            this.Plaka.Text = "Plaka";
            this.Plaka.Width = 121;
            // 
            // Kilometre
            // 
            this.Kilometre.Text = "Kilometre";
            this.Kilometre.Width = 86;
            // 
            // MarkaModel
            // 
            this.MarkaModel.Text = "MarkaModel";
            this.MarkaModel.Width = 139;
            // 
            // İşlem
            // 
            this.İşlem.Text = "Yapılan İş";
            this.İşlem.Width = 225;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 134;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon No";
            this.Telefon.Width = 112;
            // 
            // YeniKayıtBTN
            // 
            this.YeniKayıtBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.YeniKayıtBTN.Location = new System.Drawing.Point(590, 544);
            this.YeniKayıtBTN.Name = "YeniKayıtBTN";
            this.YeniKayıtBTN.Size = new System.Drawing.Size(191, 31);
            this.YeniKayıtBTN.TabIndex = 17;
            this.YeniKayıtBTN.Text = "Yeni Kayıt Oluştur";
            this.YeniKayıtBTN.UseVisualStyleBackColor = true;
            this.YeniKayıtBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkilometre
            // 
            this.txtkilometre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtkilometre.Location = new System.Drawing.Point(145, 113);
            this.txtkilometre.Multiline = true;
            this.txtkilometre.Name = "txtkilometre";
            this.txtkilometre.Size = new System.Drawing.Size(229, 35);
            this.txtkilometre.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label8.Location = new System.Drawing.Point(12, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kilometre";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtplaka
            // 
            this.txtplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtplaka.Location = new System.Drawing.Point(145, 60);
            this.txtplaka.Multiline = true;
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(229, 35);
            this.txtplaka.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label7.Location = new System.Drawing.Point(12, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Plaka";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpTarih.Location = new System.Drawing.Point(149, 291);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(229, 24);
            this.dtpTarih.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefon Numarası";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label5.Location = new System.Drawing.Point(14, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarih";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtislem
            // 
            this.txtislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtislem.Location = new System.Drawing.Point(421, 53);
            this.txtislem.Multiline = true;
            this.txtislem.Name = "txtislem";
            this.txtislem.Size = new System.Drawing.Size(229, 262);
            this.txtislem.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label4.Location = new System.Drawing.Point(417, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Yapılan işlem";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmarkamodel
            // 
            this.txtmarkamodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtmarkamodel.Location = new System.Drawing.Point(145, 170);
            this.txtmarkamodel.Multiline = true;
            this.txtmarkamodel.Name = "txtmarkamodel";
            this.txtmarkamodel.Size = new System.Drawing.Size(229, 35);
            this.txtmarkamodel.TabIndex = 23;
            this.txtmarkamodel.TextChanged += new System.EventHandler(this.txtmarkamodel_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Marka ve Model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtisim
            // 
            this.txtisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtisim.Location = new System.Drawing.Point(145, 7);
            this.txtisim.Multiline = true;
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(229, 35);
            this.txtisim.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "İsim Soyisim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(193, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Kayıtları Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtTelefon.Location = new System.Drawing.Point(147, 234);
            this.TxtTelefon.Multiline = true;
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(229, 35);
            this.TxtTelefon.TabIndex = 35;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuncelle.Location = new System.Drawing.Point(732, 50);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(191, 31);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAra.Location = new System.Drawing.Point(732, 93);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(191, 31);
            this.btnAra.TabIndex = 38;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAra.Location = new System.Drawing.Point(732, 130);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(229, 35);
            this.txtAra.TabIndex = 39;
            // 
            // PlakaAra
            // 
            this.PlakaAra.AutoSize = true;
            this.PlakaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.PlakaAra.Location = new System.Drawing.Point(672, 133);
            this.PlakaAra.Name = "PlakaAra";
            this.PlakaAra.Size = new System.Drawing.Size(54, 18);
            this.PlakaAra.TabIndex = 40;
            this.PlakaAra.Text = "PLAKA";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTemizle.Location = new System.Drawing.Point(732, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(191, 31);
            this.btnTemizle.TabIndex = 41;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Kayıtlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 586);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.PlakaAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkilometre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtislem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarkamodel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YeniKayıtBTN);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(1039, 633);
            this.MinimumSize = new System.Drawing.Size(1039, 633);
            this.Name = "Kayıtlar";
            this.Text = "Kayıtlar";
            this.Load += new System.EventHandler(this.Kayıtlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button YeniKayıtBTN;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader Plaka;
        private System.Windows.Forms.ColumnHeader Kilometre;
        private System.Windows.Forms.ColumnHeader MarkaModel;
        private System.Windows.Forms.ColumnHeader İşlem;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.TextBox txtkilometre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtislem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmarkamodel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label PlakaAra;
        private System.Windows.Forms.Button btnTemizle;
    }
}