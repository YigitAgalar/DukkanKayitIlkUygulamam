using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dükkan_Kayıt_2
{
    public partial class MüşteriKayıt : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Müsteriler;Integrated Security=True");
        public MüşteriKayıt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MüşteriKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıtlar fr2 = new Kayıtlar();
            fr2.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Müsteriler (isimsoyisim,plaka,kilometre,markavemodel,yapılanislem,tarih,telefonno) values ('"+txtisim.Text+"','"+txtplaka.Text+"','"+txtkilometre.Text+"','"+txtmarkamodel.Text+"','"+txtislem.Text+"','"+dtpTarih.Value.ToString("yyyy-MM-dd")+"','"+TxtTelefon.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void mskTxtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         
        }
    }
}
//Data Source=.\SQLEXPRESS;Initial Catalog=Müsteriler;Integrated Security=True