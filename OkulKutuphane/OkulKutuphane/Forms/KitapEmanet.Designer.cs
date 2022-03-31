
namespace OkulKutuphane.Forms
{
    partial class KitapEmanet
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
            this.YenileButton = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapID_txtbox = new System.Windows.Forms.TextBox();
            this.kitapAdi_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrNo_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emanetID_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KitapVerilis_datetimer = new System.Windows.Forms.DateTimePicker();
            this.KitapTeslimAlma_label = new System.Windows.Forms.Label();
            this.Ekle_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.Sil_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.YenileButton);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 40);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // YenileButton
            // 
            this.YenileButton.BackColor = System.Drawing.Color.Transparent;
            this.YenileButton.FlatAppearance.BorderSize = 0;
            this.YenileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YenileButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.YenileButton.ForeColor = System.Drawing.Color.White;
            this.YenileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YenileButton.Location = new System.Drawing.Point(510, 3);
            this.YenileButton.Name = "YenileButton";
            this.YenileButton.Size = new System.Drawing.Size(61, 34);
            this.YenileButton.TabIndex = 50;
            this.YenileButton.Text = "Yenile";
            this.YenileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YenileButton.UseVisualStyleBackColor = false;
            this.YenileButton.Click += new System.EventHandler(this.YenileButton_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("DragonSlapper", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(605, 0);
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
            this.btnMaximize.Location = new System.Drawing.Point(641, 0);
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
            this.btnClose.Location = new System.Drawing.Point(677, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(485, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(222, 347);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(222, 347);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kitap ID:";
            // 
            // kitapID_txtbox
            // 
            this.kitapID_txtbox.Enabled = false;
            this.kitapID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kitapID_txtbox.Location = new System.Drawing.Point(314, 50);
            this.kitapID_txtbox.Name = "kitapID_txtbox";
            this.kitapID_txtbox.Size = new System.Drawing.Size(100, 26);
            this.kitapID_txtbox.TabIndex = 54;
            // 
            // kitapAdi_txtbox
            // 
            this.kitapAdi_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kitapAdi_txtbox.Location = new System.Drawing.Point(314, 82);
            this.kitapAdi_txtbox.Name = "kitapAdi_txtbox";
            this.kitapAdi_txtbox.Size = new System.Drawing.Size(100, 26);
            this.kitapAdi_txtbox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(243, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Kitap Adi:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(237, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ogrenci No:";
            // 
            // ogrNo_textbox
            // 
            this.ogrNo_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ogrNo_textbox.Location = new System.Drawing.Point(334, 293);
            this.ogrNo_textbox.Name = "ogrNo_textbox";
            this.ogrNo_textbox.Size = new System.Drawing.Size(100, 26);
            this.ogrNo_textbox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(237, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Emanet iD:";
            // 
            // emanetID_textbox
            // 
            this.emanetID_textbox.Enabled = false;
            this.emanetID_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emanetID_textbox.Location = new System.Drawing.Point(334, 252);
            this.emanetID_textbox.Name = "emanetID_textbox";
            this.emanetID_textbox.Size = new System.Drawing.Size(100, 26);
            this.emanetID_textbox.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("DragonSlapper", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(237, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Kitap Verilis:";
            // 
            // KitapVerilis_datetimer
            // 
            this.KitapVerilis_datetimer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.KitapVerilis_datetimer.Location = new System.Drawing.Point(334, 214);
            this.KitapVerilis_datetimer.Name = "KitapVerilis_datetimer";
            this.KitapVerilis_datetimer.Size = new System.Drawing.Size(100, 20);
            this.KitapVerilis_datetimer.TabIndex = 62;
            // 
            // KitapTeslimAlma_label
            // 
            this.KitapTeslimAlma_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KitapTeslimAlma_label.AutoSize = true;
            this.KitapTeslimAlma_label.BackColor = System.Drawing.Color.Transparent;
            this.KitapTeslimAlma_label.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.KitapTeslimAlma_label.ForeColor = System.Drawing.Color.Black;
            this.KitapTeslimAlma_label.Location = new System.Drawing.Point(242, 145);
            this.KitapTeslimAlma_label.Name = "KitapTeslimAlma_label";
            this.KitapTeslimAlma_label.Size = new System.Drawing.Size(17, 18);
            this.KitapTeslimAlma_label.TabIndex = 63;
            this.KitapTeslimAlma_label.Text = "?";
            // 
            // Ekle_button
            // 
            this.Ekle_button.BackColor = System.Drawing.Color.White;
            this.Ekle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle_button.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.Ekle_button.ForeColor = System.Drawing.Color.Black;
            this.Ekle_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle_button.Location = new System.Drawing.Point(241, 332);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(64, 31);
            this.Ekle_button.TabIndex = 64;
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
            this.guncelle_button.Location = new System.Drawing.Point(311, 332);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(84, 31);
            this.guncelle_button.TabIndex = 65;
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
            this.Sil_button.Location = new System.Drawing.Point(401, 332);
            this.Sil_button.Name = "Sil_button";
            this.Sil_button.Size = new System.Drawing.Size(64, 31);
            this.Sil_button.TabIndex = 66;
            this.Sil_button.Text = "Sil";
            this.Sil_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sil_button.UseVisualStyleBackColor = false;
            this.Sil_button.Click += new System.EventHandler(this.Sil_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(421, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 26);
            this.button1.TabIndex = 68;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitapEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sil_button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.Ekle_button);
            this.Controls.Add(this.KitapTeslimAlma_label);
            this.Controls.Add(this.KitapVerilis_datetimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emanetID_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogrNo_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitapAdi_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitapID_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapEmanet";
            this.Load += new System.EventHandler(this.KitapEmanet_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kitapID_txtbox;
        private System.Windows.Forms.TextBox kitapAdi_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ogrNo_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emanetID_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker KitapVerilis_datetimer;
        private System.Windows.Forms.Label KitapTeslimAlma_label;
        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button Sil_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button YenileButton;
    }
}