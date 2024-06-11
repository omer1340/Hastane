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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string baglantı = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hastane;Integrated Security=True ";
        SqlConnection connect = new SqlConnection(baglantı);

        private void Form2_Load(object sender, EventArgs e)
        {
            txtİsim.ReadOnly = true;
            txtİsim.Enabled = false;

            txtTel.ReadOnly = true;
            txtTel.Enabled = false;

            txtCinsiyet.ReadOnly = true;
            txtCinsiyet.Enabled = false;

            txtDogumTarih.ReadOnly = true;
            txtDogumTarih.Enabled = false;
        }

        private void buttonSorgu_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta Where Tc = '"+maskedTc.Text+"'",connect);

            SqlDataReader read = komut.ExecuteReader();

            while(read.Read())
            {
                txtİsim.Text = read["İsim"].ToString();
                txtTel.Text = read["Telefon"].ToString();
                txtCinsiyet.Text = read["Cinsiyet"].ToString();
                txtDogumTarih.Text = read["DoğumTarihi"].ToString();
            }
            connect.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
