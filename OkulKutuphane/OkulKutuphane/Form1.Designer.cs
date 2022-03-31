
namespace OkulKutuphane
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.log_cvp_label = new System.Windows.Forms.Label();
            this.log_password_txtbx = new System.Windows.Forms.TextBox();
            this.log_user_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookLoginButton = new System.Windows.Forms.PictureBox();
            this.AdminLoginButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookLoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLoginButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblCountDown);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 40);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDown.Font = new System.Drawing.Font("DragonSlapper", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(77, 5);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(26, 26);
            this.lblCountDown.TabIndex = 9;
            this.lblCountDown.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OkulKutuphane.Properties.Resources.ZtashiaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("DragonSlapper", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(560, 0);
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
            this.btnMaximize.Location = new System.Drawing.Point(596, 0);
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
            this.btnClose.Location = new System.Drawing.Point(632, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // log_cvp_label
            // 
            this.log_cvp_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_cvp_label.AutoSize = true;
            this.log_cvp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.log_cvp_label.Location = new System.Drawing.Point(166, 69);
            this.log_cvp_label.Name = "log_cvp_label";
            this.log_cvp_label.Size = new System.Drawing.Size(0, 25);
            this.log_cvp_label.TabIndex = 16;
            // 
            // log_password_txtbx
            // 
            this.log_password_txtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_password_txtbx.Location = new System.Drawing.Point(372, 168);
            this.log_password_txtbx.Name = "log_password_txtbx";
            this.log_password_txtbx.PasswordChar = '*';
            this.log_password_txtbx.Size = new System.Drawing.Size(101, 20);
            this.log_password_txtbx.TabIndex = 15;
            // 
            // log_user_txtbx
            // 
            this.log_user_txtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_user_txtbx.Location = new System.Drawing.Point(372, 124);
            this.log_user_txtbx.Name = "log_user_txtbx";
            this.log_user_txtbx.Size = new System.Drawing.Size(101, 20);
            this.log_user_txtbx.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon Numarasi:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DragonSlapper", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Okul Numarası:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BookLoginButton
            // 
            this.BookLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.BookLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BookLoginButton.Image = global::OkulKutuphane.Properties.Resources.WHITE_book;
            this.BookLoginButton.Location = new System.Drawing.Point(277, 211);
            this.BookLoginButton.Name = "BookLoginButton";
            this.BookLoginButton.Size = new System.Drawing.Size(120, 112);
            this.BookLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookLoginButton.TabIndex = 11;
            this.BookLoginButton.TabStop = false;
            this.BookLoginButton.Click += new System.EventHandler(this.BookLoginButton_Click);
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.AdminLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminLoginButton.Image = global::OkulKutuphane.Properties.Resources.WHWHITE_user;
            this.AdminLoginButton.Location = new System.Drawing.Point(593, 300);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(57, 58);
            this.AdminLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminLoginButton.TabIndex = 18;
            this.AdminLoginButton.TabStop = false;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OkulKutuphane.Properties.Resources.Library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 370);
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.log_cvp_label);
            this.Controls.Add(this.log_password_txtbx);
            this.Controls.Add(this.log_user_txtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookLoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookLoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLoginButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label log_cvp_label;
        private System.Windows.Forms.TextBox log_password_txtbx;
        private System.Windows.Forms.TextBox log_user_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BookLoginButton;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.PictureBox AdminLoginButton;
    }
}

