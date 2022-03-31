using OkulKutuphane.DataBase_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKutuphane.Forms
{
    public partial class IdareKitapAra_WithAd : Form
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        public IdareKitapAra_WithAd()
        {
            InitializeComponent();
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

        private void AraButton_Click(object sender, EventArgs e)
        {
            conn.Close();
            string a = KitapAramaTxtBox.Text;
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table WHERE kitapAdi LIKE '%" + a + "%';";
            cmd = new SqlCommand(kayit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            kayitGetir();
            KitapAramaTxtBox.Text = " ";
        }

        private void IdareKitapAra_WithAd_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
