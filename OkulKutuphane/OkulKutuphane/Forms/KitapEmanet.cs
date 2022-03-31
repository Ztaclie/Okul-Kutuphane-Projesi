using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OkulKutuphane.DataBase_Folder;

namespace OkulKutuphane.Forms
{
    public partial class KitapEmanet : Form
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        emanetDal emntdal = new emanetDal();
     

        public KitapEmanet()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
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

        private void kayitGetir()
        {
            conn.Close();
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table";
            cmd = new SqlCommand(kayit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
            conn.Open();
            kayit = "SELECT * from dbo.emanet_table";
            cmd = new SqlCommand(kayit, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        void KayıtSil(int emanetID)
        {
            string sql = "DELETE FROM dbo.emanet_table WHERE emanetID=@emanetID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emanetID", emanetID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void Temizle()
        {
            kitapAdi_txtbox.Text = " ";
            kitapID_txtbox.Text = " ";
            emanetID_textbox.Text = " ";
            ogrNo_textbox.Text = " ";
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            kayitGetir();
            Temizle();
        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            string date = KitapVerilis_datetimer.Value.ToString();
            string dateplus;
            dateplus = KitapVerilis_datetimer.Value.AddDays(30).ToShortDateString();
            var result = emntdal.Update(int.Parse(emanetID_textbox.Text), int.Parse(ogrNo_textbox.Text), date, dateplus, int.Parse(kitapID_txtbox.Text), kitapAdi_txtbox.Text);
            kayitGetir();
            if (result)
            {
                MessageBox.Show("Başarili!!!");
                KitapTeslimAlma_label.Text = dateplus;
            }
            else
            {
                MessageBox.Show("Başarisiz!!!");
            }
            Temizle();
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {
            string date = KitapVerilis_datetimer.Value.ToString();
            string dateplus;
            //dateplus = KitapVerilis_datetimer.Value.ToShortDateString().ToString();
            dateplus = KitapVerilis_datetimer.Value.AddDays(30).ToShortDateString();
            var result = emntdal.Add(int.Parse(ogrNo_textbox.Text), date, dateplus,int.Parse(kitapID_txtbox.Text),kitapAdi_txtbox.Text);
            kayitGetir();
            if (result)
            {
                MessageBox.Show("Başarili!!!");
                KitapTeslimAlma_label.Text = dateplus;
            }
            else
            {
                MessageBox.Show("Başarisiz!!!");
            }
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            string a = kitapAdi_txtbox.Text;
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table WHERE kitapAdi LIKE '%" + a + "%';";
            cmd = new SqlCommand(kayit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void KitapEmanet_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapID_txtbox.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            kitapAdi_txtbox.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string dateplus;
            string a = KitapVerilis_datetimer.Value.ToShortDateString();
            emanetID_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ogrNo_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            KitapVerilis_datetimer.Text =dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            KitapTeslimAlma_label.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            kitapID_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            kitapAdi_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }
    }
}
