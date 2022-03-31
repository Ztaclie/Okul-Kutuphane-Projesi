using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OkulKutuphane.DataBase_Folder;
using System.Runtime.InteropServices;

namespace OkulKutuphane
{
    public partial class IdareGirisForm : Form
    {
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        int countDown = 3;
        IdareMenuForn idrmenu = new IdareMenuForn();


        public IdareGirisForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblCountDown.Text = countDown.ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        void IdareGiris()
        {
            try
            {
                int user = int.Parse(log_user_txtbx.Text);
                double password = Convert.ToDouble(log_password_txtbx.Text);
                if (user == null)
                {
                    user = 0;
                }
                if (password == null)
                {
                    password = 0;
                }
                string sorgu = "SELECT * FROM dbo.idare_table where idareNo = '" + user + "' AND idareSifre = '" + password + "'";
                cmd = new SqlCommand(sorgu, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //log_cvp_label.Text = "Tebrikler! Başarılı bir şekilde giriş yaptınız.";
                    Hide();
                    idrmenu.Show();
                }
                else
                {
                    log_cvp_label.Text = "Okul numaranızı ve şifrenizi kontrol ediniz.";
                    countDown--;
                    lblCountDown.Text = countDown.ToString();
                    if (countDown <= 0)
                    {
                        Application.Exit();
                    }
                }
                conn.Close();
            }
            catch (FormatException)
            {
                log_user_txtbx.Text = 0.ToString();
                log_password_txtbx.Text = 0.ToString();
                IdareGiris();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BookLoginButton_Click(object sender, EventArgs e)
        {
            IdareGiris();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            log_user_txtbx.Text = "660";
            log_password_txtbx.Text = "123";
        }
    }
}
