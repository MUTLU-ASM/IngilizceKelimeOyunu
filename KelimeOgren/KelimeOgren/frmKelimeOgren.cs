using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KelimeOgren
{
    public partial class frmKelimeOgren : Form
    {
        public frmKelimeOgren()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;


        private void frmKelimeOgren_Load(object sender, EventArgs e)
        {
            getir();
            txtTurkce.Focus();
            timer1.Start();
        }

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            lblCevap.Text = sayi.ToString();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblİngilizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text==lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure==0)
            {
                timer1.Stop();
                MessageBox.Show("Süre Dolmuştur Bildiğiniz kelime sayısı : " + lblKelime.Text);
                txtTurkce.Enabled = false;
                lblİngilizce.Enabled = false;
                btnTekrarOyna.Visible = true;
            }
        }

        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            sure = 90;
            getir();
            txtTurkce.Focus();
            timer1.Start();
            
        }
    }
}
