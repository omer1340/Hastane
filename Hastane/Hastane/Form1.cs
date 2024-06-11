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

namespace Hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string baglantı = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hastane;Integrated Security=True ";
        SqlConnection connect = new SqlConnection(baglantı);


        private void Kaydet_Click(object sender, EventArgs e)
        {
            connect.Open();

            string checkHastaQuery = "SELECT COUNT (*) AS [Kayıt] FROM Hasta WHERE Tc =@Tc";
            SqlCommand checkHastaCommand = new SqlCommand(checkHastaQuery, connect);


            checkHastaCommand.Parameters.AddWithValue("@Tc", masktxtTc.Text);



            int rowCount = (int)checkHastaCommand.ExecuteScalar();

            if(rowCount== 0)
            {
                string kayıt = "Insert Into Hasta (Tc,İsim,Telefon,Cinsiyet,DoğumTarihi) values (@Tc,@İsim,@Telefon,@Cinsiyet,@DoğumTarihi)";
                SqlCommand komut = new SqlCommand(kayıt, connect);

                komut.Parameters.AddWithValue("@Tc", masktxtTc.Text);
                komut.Parameters.AddWithValue("@İsim", txtİsim.Text);
                komut.Parameters.AddWithValue("@Telefon", masktxtTc.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@DoğumTarihi", masktxtDogum.Text);

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Kayıt Eklendi");

            }
            else
            {
                MessageBox.Show("Bu kimlik numarasına ait Hasta kaydı vardır.");
            }


                  
                
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
