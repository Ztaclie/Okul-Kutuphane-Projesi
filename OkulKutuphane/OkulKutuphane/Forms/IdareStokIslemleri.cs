using OkulKutuphane.DataBase_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKutuphane.Forms
{
    public partial class IdareStokIslemleri : Form
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        kitapDal ktpdal = new kitapDal();
        
        public IdareStokIslemleri()
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
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        void kitapGetir()
        {
            List<string> turs = new List<string>();

            conn.Close();
            conn.Open();
            string kayit = "SELECT turAdi from dbo.turler";
            cmd = new SqlCommand(kayit, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                turs.Add(dr["turAdi"].ToString());
            }


            foreach (string item in turs)
            {
                kitapTuru_combobox.Items.Add(item);
            }

            conn.Close();
        }

        void Temizle()
        {
            kitapID_txtbox.Text = " ";
            kitapAdi_txtbox.Text = " ";
            kitapKitaplik_combobox.SelectedIndex = -1;
            kitapRaf_combobox.SelectedIndex = -1;
            kitapSayfasi_txtbox.Text = " ";
            kitapTuru_combobox.SelectedIndex = -1;
            kitapYazar_combobox.SelectedIndex = -1;
        }

        void yazarGetir()
        {
            List<string> readers = new List<string>();

            conn.Close();
            conn.Open();
            string kayit = "SELECT kitapYazari from dbo.kitap_table";
            cmd = new SqlCommand(kayit, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                readers.Add(dr["kitapYazari"].ToString());
            }


            foreach (string item in readers)
            {
                kitapYazar_combobox.Items.Add(item);
            }

            conn.Close();
        }
        void rafVEkitaplikGetir()
        {
            List<int> raf = new List<int>();
            List<int> ktplik = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                raf.Add(i);
            }
            for (int i = 1; i <= 5; i++)
            {
                ktplik.Add(i);
            }
            foreach (int item in raf)
            {
                kitapRaf_combobox.Items.Add(item);
            }
            foreach (int item in ktplik)
            {
                kitapKitaplik_combobox.Items.Add(item);
            }
        }

        private void Ekle_button_Click(object sender, EventArgs e)
        {

            var result=ktpdal.Add(kitapAdi_txtbox.Text, kitapYazar_combobox.Text, kitapTuru_combobox.Text, int.Parse(kitapSayfasi_txtbox.Text), int.Parse(kitapRaf_combobox.Text), int.Parse(kitapKitaplik_combobox.Text));
            kayitGetir();
            if(result)
            {
                MessageBox.Show("Başarili!!!");
            }
            else
            {
                MessageBox.Show("Başarisiz!!!");
            }
            Temizle();
        }

        private void guncelle_button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ktpdal.Update(int.Parse(kitapID_txtbox.Text), kitapAdi_txtbox.Text, kitapYazar_combobox.Text, kitapTuru_combobox.Text, int.Parse(kitapSayfasi_txtbox.Text), int.Parse(kitapRaf_combobox.Text), int.Parse(kitapKitaplik_combobox.Text));
                kayitGetir();
                if (result)
                {
                    MessageBox.Show("Başarili!!!");
                }
                else
                {
                    MessageBox.Show("Başarisiz!!!");
                }
                Temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("LÜTFEN DATAGRIDVIEW'DAN HUCRE SECİN!!!", "DIKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }
            
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            kayitGetir();
            Temizle();
        }

        void KayıtSil(int kitapID)
        {
            string sql = "DELETE FROM dbo.kitap_table WHERE kitapID=@kitapID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kitapID", kitapID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
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

        private void AraButton_Click(object sender, EventArgs e)
        {
            conn.Close();
            string a = KitapAramaTxtBox.Text;
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table WHERE kitapAdi LIKE '%" + a + "%';";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            cmd = new SqlCommand(kayit, conn);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        private void IdareStokIslemleri_Load(object sender, EventArgs e)
        {
            kayitGetir();
            kitapGetir();
            yazarGetir();
            //rafVEkitaplikGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapID_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            kitapAdi_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kitapYazar_combobox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            kitapTuru_combobox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            kitapSayfasi_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            kitapRaf_combobox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            kitapKitaplik_combobox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
