
namespace OkulKutuphane.Forms
{
    partial class IdareKitapAra_WithAd
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
            this.AraButton = new System.Windows.Forms.Button();
            this.KitapAramaTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YenileButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AraButton
            // 
            this.AraButton.BackColor = System.Drawing.Color.White;
            this.AraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AraButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.AraButton.ForeColor = System.Drawing.Color.Black;
            this.AraButton.Location = new System.Drawing.Point(395, 13);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(44, 33);
            this.AraButton.TabIndex = 42;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = false;
            this.AraButton.Click += new System.EventHandler(this.AraButton_Click);
            // 
            // KitapAramaTxtBox
            // 
            this.KitapAramaTxtBox.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.KitapAramaTxtBox.Location = new System.Drawing.Point(250, 13);
            this.KitapAramaTxtBox.Name = "KitapAramaTxtBox";
            this.KitapAramaTxtBox.Size = new System.Drawing.Size(93, 34);
            this.KitapAramaTxtBox.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(111, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Kitap Adi:";
            // 
            // YenileButton
            // 
            this.YenileButton.BackColor = System.Drawing.Color.White;
            this.YenileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YenileButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.YenileButton.ForeColor = System.Drawing.Color.Black;
            this.YenileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YenileButton.Location = new System.Drawing.Point(114, 258);
            this.YenileButton.Name = "YenileButton";
            this.YenileButton.Size = new System.Drawing.Size(44, 33);
            this.YenileButton.TabIndex = 39;
            this.YenileButton.Text = "Yenile";
            this.YenileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YenileButton.UseVisualStyleBackColor = false;
            this.YenileButton.Click += new System.EventHandler(this.YenileButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(393, 189);
            this.dataGridView1.TabIndex = 38;
            // 
            // IdareKitapAra_WithAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 304);
            this.Controls.Add(this.AraButton);
            this.Controls.Add(this.KitapAramaTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YenileButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IdareKitapAra_WithAd";
            this.Text = "IdareKitapAra_WithAd";
            this.Load += new System.EventHandler(this.IdareKitapAra_WithAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.TextBox KitapAramaTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YenileButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}