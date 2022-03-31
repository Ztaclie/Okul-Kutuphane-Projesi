
namespace OkulKutuphane.Forms
{
    partial class IdareKitapAra_WithYazar
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
            this.KitapAramaComboBox = new System.Windows.Forms.ComboBox();
            this.AraButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.YenileButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapAramaComboBox
            // 
            this.KitapAramaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KitapAramaComboBox.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.KitapAramaComboBox.FormattingEnabled = true;
            this.KitapAramaComboBox.Location = new System.Drawing.Point(259, 12);
            this.KitapAramaComboBox.Name = "KitapAramaComboBox";
            this.KitapAramaComboBox.Size = new System.Drawing.Size(121, 34);
            this.KitapAramaComboBox.TabIndex = 53;
            // 
            // AraButton
            // 
            this.AraButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AraButton.BackColor = System.Drawing.Color.White;
            this.AraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AraButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.AraButton.ForeColor = System.Drawing.Color.Black;
            this.AraButton.Location = new System.Drawing.Point(430, 14);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(44, 33);
            this.AraButton.TabIndex = 52;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = false;
            this.AraButton.Click += new System.EventHandler(this.AraButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Kitap Yazari:";
            // 
            // YenileButton
            // 
            this.YenileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YenileButton.BackColor = System.Drawing.Color.White;
            this.YenileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YenileButton.Font = new System.Drawing.Font("DragonSlapper", 10F);
            this.YenileButton.ForeColor = System.Drawing.Color.Black;
            this.YenileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YenileButton.Location = new System.Drawing.Point(149, 259);
            this.YenileButton.Name = "YenileButton";
            this.YenileButton.Size = new System.Drawing.Size(44, 33);
            this.YenileButton.TabIndex = 50;
            this.YenileButton.Text = "Yenile";
            this.YenileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.YenileButton.UseVisualStyleBackColor = false;
            this.YenileButton.Click += new System.EventHandler(this.YenileButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(393, 189);
            this.dataGridView1.TabIndex = 49;
            // 
            // IdareKitapAra_WithYazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 304);
            this.Controls.Add(this.KitapAramaComboBox);
            this.Controls.Add(this.AraButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YenileButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IdareKitapAra_WithYazar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdareKitapAra_WithYazar";
            this.Load += new System.EventHandler(this.IdareKitapAra_WithYazar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KitapAramaComboBox;
        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YenileButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}