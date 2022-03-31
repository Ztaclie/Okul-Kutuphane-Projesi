
namespace OkulKutuphane.Forms
{
    partial class IdareStokIslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.YenileButton = new System.Windows.Forms.Button();
            this.AraButton = new System.Windows.Forms.Button();
            this.KitapAramaTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kitapID_txtbox = new System.Windows.Forms.TextBox();
            this.kitapAdi_txtbox = new System.Windows.Forms.TextBox();
            this.kitapSayfasi_txtbox = new System.Windows.Forms.TextBox();
            this.kitapYazar_combobox = new System.Windows.Forms.ComboBox();
            this.kitapTuru_combobox = new System.Windows.Forms.ComboBox();
            this.kitapRaf_combobox = new System.Windows.Forms.ComboBox();
            this.kitapKitaplik_combobox = new System.Windows.Forms.ComboBox();
            this.Ekle_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.Sil_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 40);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("DragonSlapper", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(613, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("DragonSlapper", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(649, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("DragonSlapper", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(685, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kitap ID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kitap Adi:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kitap Yazar:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Kitap Tur:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Kitap Sayfa:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Kitap Raf Numarasi:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Kitap Kitaplik Numarasi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(363, 213);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // YenileButton
            // 
            this.YenileButton.BackColor = System.Drawing.Color.White;
            this.YenileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YenileButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.YenileButton.ForeColor = System.Drawing.Color.Black;
            this.YenileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YenileButton.Location = new System.Drawing.Point(316, 305);
            this.YenileButton.Name = "YenileButton";
            this.YenileButton.Size = new System.Drawing.Size(64, 31);
            this.YenileButton.TabIndex = 49;
            this.YenileButton.Text = "Yenile";
            this.YenileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YenileButton.UseVisualStyleBackColor = false;
            this.YenileButton.Click += new System.EventHandler(this.YenileButton_Click);
            // 
            // AraButton
            // 
            this.AraButton.BackColor = System.Drawing.Color.White;
            this.AraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AraButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.AraButton.ForeColor = System.Drawing.Color.Black;
            this.AraButton.Location = new System.Drawing.Point(599, 46);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(44, 33);
            this.AraButton.TabIndex = 52;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = false;
            this.AraButton.Click += new System.EventHandler(this.AraButton_Click);
            // 
            // KitapAramaTxtBox
            // 
            this.KitapAramaTxtBox.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.KitapAramaTxtBox.Location = new System.Drawing.Point(454, 46);
            this.KitapAramaTxtBox.Name = "KitapAramaTxtBox";
            this.KitapAramaTxtBox.Size = new System.Drawing.Size(93, 34);
            this.KitapAramaTxtBox.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(315, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 26);
            this.label8.TabIndex = 50;
            this.label8.Text = "Kitap Adi:";
            // 
            // kitapID_txtbox
            // 
            this.kitapID_txtbox.Enabled = false;
            this.kitapID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kitapID_txtbox.Location = new System.Drawing.Point(94, 59);
            this.kitapID_txtbox.Name = "kitapID_txtbox";
            this.kitapID_txtbox.Size = new System.Drawing.Size(100, 26);
            this.kitapID_txtbox.TabIndex = 53;
            // 
            // kitapAdi_txtbox
            // 
            this.kitapAdi_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kitapAdi_txtbox.Location = new System.Drawing.Point(94, 92);
            this.kitapAdi_txtbox.Name = "kitapAdi_txtbox";
            this.kitapAdi_txtbox.Size = new System.Drawing.Size(100, 26);
            this.kitapAdi_txtbox.TabIndex = 54;
            // 
            // kitapSayfasi_txtbox
            // 
            this.kitapSayfasi_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kitapSayfasi_txtbox.Location = new System.Drawing.Point(110, 187);
            this.kitapSayfasi_txtbox.Name = "kitapSayfasi_txtbox";
            this.kitapSayfasi_txtbox.Size = new System.Drawing.Size(100, 26);
            this.kitapSayfasi_txtbox.TabIndex = 55;
            // 
            // kitapYazar_combobox
            // 
            this.kitapYazar_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kitapYazar_combobox.FormattingEnabled = true;
            this.kitapYazar_combobox.Location = new System.Drawing.Point(112, 125);
            this.kitapYazar_combobox.Name = "kitapYazar_combobox";
            this.kitapYazar_combobox.Size = new System.Drawing.Size(121, 24);
            this.kitapYazar_combobox.TabIndex = 56;
            // 
            // kitapTuru_combobox
            // 
            this.kitapTuru_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kitapTuru_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kitapTuru_combobox.FormattingEnabled = true;
            this.kitapTuru_combobox.Location = new System.Drawing.Point(110, 156);
            this.kitapTuru_combobox.Name = "kitapTuru_combobox";
            this.kitapTuru_combobox.Size = new System.Drawing.Size(121, 24);
            this.kitapTuru_combobox.TabIndex = 57;
            // 
            // kitapRaf_combobox
            // 
            this.kitapRaf_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kitapRaf_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kitapRaf_combobox.FormattingEnabled = true;
            this.kitapRaf_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.kitapRaf_combobox.Location = new System.Drawing.Point(161, 220);
            this.kitapRaf_combobox.Name = "kitapRaf_combobox";
            this.kitapRaf_combobox.Size = new System.Drawing.Size(49, 24);
            this.kitapRaf_combobox.TabIndex = 58;
            // 
            // kitapKitaplik_combobox
            // 
            this.kitapKitaplik_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kitapKitaplik_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kitapKitaplik_combobox.FormattingEnabled = true;
            this.kitapKitaplik_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.kitapKitaplik_combobox.Location = new System.Drawing.Point(189, 251);
            this.kitapKitaplik_combobox.Name = "kitapKitaplik_combobox";
            this.kitapKitaplik_combobox.Size = new System.Drawing.Size(53, 24);
            this.kitapKitaplik_combobox.TabIndex = 59;
            // 
            // Ekle_button
            // 
            this.Ekle_button.BackColor = System.Drawing.Color.White;
            this.Ekle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle_button.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.Ekle_button.ForeColor = System.Drawing.Color.Black;
            this.Ekle_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle_button.Location = new System.Drawing.Point(26, 305);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(64, 31);
            this.Ekle_button.TabIndex = 60;
            this.Ekle_button.Text = "Ekle";
            this.Ekle_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ekle_button.UseVisualStyleBackColor = false;
            this.Ekle_button.Click += new System.EventHandler(this.Ekle_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.BackColor = System.Drawing.Color.White;
            this.guncelle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle_button.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.guncelle_button.ForeColor = System.Drawing.Color.Black;
            this.guncelle_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelle_button.Location = new System.Drawing.Point(110, 305);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(84, 31);
            this.guncelle_button.TabIndex = 61;
            this.guncelle_button.Text = "Guncelle";
            this.guncelle_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guncelle_button.UseVisualStyleBackColor = false;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // Sil_button
            // 
            this.Sil_button.BackColor = System.Drawing.Color.White;
            this.Sil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil_button.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.Sil_button.ForeColor = System.Drawing.Color.Black;
            this.Sil_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sil_button.Location = new System.Drawing.Point(613, 305);
            this.Sil_button.Name = "Sil_button";
            this.Sil_button.Size = new System.Drawing.Size(64, 31);
            this.Sil_button.TabIndex = 62;
            this.Sil_button.Text = "Sil";
            this.Sil_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sil_button.UseVisualStyleBackColor = false;
            this.Sil_button.Click += new System.EventHandler(this.Sil_button_Click);
            // 
            // IdareStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 372);
            this.Controls.Add(this.Sil_button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.Ekle_button);
            this.Controls.Add(this.kitapKitaplik_combobox);
            this.Controls.Add(this.kitapRaf_combobox);
            this.Controls.Add(this.kitapTuru_combobox);
            this.Controls.Add(this.kitapYazar_combobox);
            this.Controls.Add(this.kitapSayfasi_txtbox);
            this.Controls.Add(this.kitapAdi_txtbox);
            this.Controls.Add(this.kitapID_txtbox);
            this.Controls.Add(this.AraButton);
            this.Controls.Add(this.KitapAramaTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YenileButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IdareStokIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdareStokIslemleri";
            this.Load += new System.EventHandler(this.IdareStokIslemleri_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button YenileButton;
        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.TextBox KitapAramaTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kitapID_txtbox;
        private System.Windows.Forms.TextBox kitapAdi_txtbox;
        private System.Windows.Forms.TextBox kitapSayfasi_txtbox;
        private System.Windows.Forms.ComboBox kitapYazar_combobox;
        private System.Windows.Forms.ComboBox kitapTuru_combobox;
        private System.Windows.Forms.ComboBox kitapRaf_combobox;
        private System.Windows.Forms.ComboBox kitapKitaplik_combobox;
        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button Sil_button;
    }
}