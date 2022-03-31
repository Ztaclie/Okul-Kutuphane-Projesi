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

namespace OkulKutuphane.Forms
{
    public partial class IdareKitapAra_WithTur : Form
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public IdareKitapAra_WithTur()
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
                KitapAramaComboBox.Items.Add(item);
            }

            conn.Close();
        }

        private void IdareKitapAra_WithTur_Load(object sender, EventArgs e)
        {
            kayitGetir();
            kitapGetir();
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            kayitGetir();
            KitapAramaComboBox.SelectedIndex = -1;
        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            conn.Close();
            string a = KitapAramaComboBox.Text;
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table WHERE kitapTuru LIKE '%" + a + "%';";
            cmd = new SqlCommand(kayit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
