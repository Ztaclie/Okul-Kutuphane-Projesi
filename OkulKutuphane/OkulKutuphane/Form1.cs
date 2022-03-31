using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OkulKutuphane.DataBase_Folder;

namespace OkulKutuphane
{
    public partial class GirisForm : Form
    {
        int countDown = 3;
        int tur;
        OgrenciKitapAramaForm ogrkitap = new OgrenciKitapAramaForm();

        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public GirisForm()
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

        public void logoDegis(int a) // 1(TRUE) gelirse TURUNCU 0(FALSE) gelirse SİYAH LOGO
        {
            if (a == 1)
            {
                BookLoginButton.ImageLocation = ".\\Picts\\WHITE_icons8-fire-90.png";
            }
            else if (a == 2)
            {
                BookLoginButton.ImageLocation = ".\\Picts\\ORANGE_icons8-fire-90.png";
            }
            else if (a == 3)
            {
                BookLoginButton.ImageLocation = ".\\Picts\\RED_icons8-fire-90.png";
            }
            else
            {
                BookLoginButton.ImageLocation = ".\\Picts\\BLACK_icons8-fire-90.png";
            }
            BookLoginButton.Load();

        }

        void OgrenciGiris()
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
                string sorgu = "SELECT * FROM dbo.ogrenciler_table where ogrNo = '" + user + "' AND ogrSifre = '" + password + "'";
                cmd = new SqlCommand(sorgu, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //log_cvp_label.Text = "Tebrikler! Başarılı bir şekilde giriş yaptınız.";
                    Hide();
                    ogrkitap.Show();
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
                OgrenciGiris();
            }
            
        }
        

        private void BookLoginButton_Click(object sender, EventArgs e)
        {
                OgrenciGiris();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            IdareGirisForm formm = new IdareGirisForm();
            formm.Show();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            log_user_txtbx.Text = "201238019";
            log_password_txtbx.Text = "5527174814";
        }
    }
}
