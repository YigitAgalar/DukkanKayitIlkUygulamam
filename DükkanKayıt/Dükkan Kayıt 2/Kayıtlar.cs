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
    public partial class Kayıtlar : Form
    {
        public Kayıtlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = Müsteriler; Integrated Security = True");
       
        private void verilerigoster()
        
            
        
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Müsteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read()){
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["isimsoyisim"].ToString());
                ekle.SubItems.Add( oku["plaka"].ToString());
                ekle.SubItems.Add(oku["kilometre"].ToString());
                ekle.SubItems.Add(oku["markavemodel"].ToString());
                ekle.SubItems.Add(oku["yapılanislem"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
                ekle.SubItems.Add(oku["telefonno"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriKayıt fr = new MüşteriKayıt();
            fr.Show();
            

        }

        private void Kayıtlar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Müsteriler where plaka like '%"+txtAra.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["isimsoyisim"].ToString());
                ekle.SubItems.Add(oku["plaka"].ToString());
                ekle.SubItems.Add(oku["kilometre"].ToString());
                ekle.SubItems.Add(oku["markavemodel"].ToString());
                ekle.SubItems.Add(oku["yapılanislem"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
                ekle.SubItems.Add(oku["telefonno"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
          id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtisim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtplaka.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtkilometre.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtmarkamodel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtislem.Text = listView1.SelectedItems[0].SubItems[5].Text;
            dtpTarih.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtTelefon.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void txtmarkamodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtisim.Clear();
            txtislem.Clear();
            txtkilometre.Clear();
            txtmarkamodel.Clear();
            txtplaka.Clear();
            TxtTelefon.Clear();
            dtpTarih.ResetText();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Müsteriler set isimsoyisim='"+ txtisim.Text +"',plaka='"+ txtplaka.Text +"',kilometre='"+ txtkilometre.Text +"',markavemodel='"+txtmarkamodel.Text+"',yapılanislem='"+txtislem.Text+"',tarih='"+dtpTarih.Value.ToString("yyyy-MM-dd")+"',telefonno='"+TxtTelefon.Text+"' where Müsteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }
    }
}
//Data Source=.\SQLEXPRESS;Initial Catalog=Müsteriler;Integrated Security=True