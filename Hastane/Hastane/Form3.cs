using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string baglantı = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Hastane;Integrated Security=True ";
        SqlConnection connect = new SqlConnection(baglantı);

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBölüm.Items.Add("Beyin Cerrahisi");
            comboBölüm.Items.Add("Cildiye");
            comboBölüm.Items.Add("Ordodonti");
            comboBölüm.Items.Add("Radyoloji");
            comboBölüm.Items.Add("Genel Cerrahi");

            comboSaat.Items.Add("08:30");
            comboSaat.Items.Add("09:30");
            comboSaat.Items.Add("10:30");
            comboSaat.Items.Add("11:30");
            comboSaat.Items.Add("12:30");

            comboBölüm2.Items.Add("Beyin Cerrahisi");
            comboBölüm2.Items.Add("Cildiye");
            comboBölüm2.Items.Add("Ordodonti");
            comboBölüm2.Items.Add("Radyoloji");
            comboBölüm2.Items.Add("Genel Cerrahi");

            dataGridView1.Columns.Add("Column1", "Tc Kimlik Numarası");
            dataGridView1.Columns.Add("Column2", "Randevu Tarihi");
            dataGridView1.Columns.Add("Column3", "Randevu Saati");
            dataGridView1.Columns.Add("Column4", "Bölüm");
            dataGridView1.Columns.Add("Column5", "Doktor");






        }

        private void comboBölüm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBölüm.Text == "Beyin Cerrahisi")
            {
                comboDoktor.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Beyin Cerrahisi'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm.Text == "Cildiye")
            {
                comboDoktor.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Cildiye'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm.Text == "Ordodonti")
            {
                comboDoktor.Items.Clear();

                comboDoktor.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Ordodonti'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm.Text == "Radyoloji")
            {
                comboDoktor.Items.Clear();

                comboDoktor.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Radyoloji'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm.Text == "Genel Cerrahi")
            {
                

                comboDoktor.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Genel Cerrahi'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            connect.Open();

            string checkHastaQuery = "SELECT COUNT (*) AS [Kayıt] FROM Hasta WHERE Tc =@Tc";
            SqlCommand checkHastaCommand = new SqlCommand(checkHastaQuery, connect);

           
            checkHastaCommand.Parameters.AddWithValue("@Tc", maskedTc.Text);



             int rowCount = (int)checkHastaCommand.ExecuteScalar();

             if (rowCount ==1) {

                string checkRandevuQuery = "SELECT COUNT(*) FROM Randevu WHERE RandevuTarihi = @Tarih AND RandevuSaati = @Saat AND Bölüm=@Bölüm AND DoktorAdı=@Doktor";
                SqlCommand checkRandevuCommand = new SqlCommand(checkRandevuQuery, connect);

                checkRandevuCommand.Parameters.AddWithValue("@Tarih", maskedTarih.Text);
                checkRandevuCommand.Parameters.AddWithValue("@Saat", comboSaat.Text);
                checkRandevuCommand.Parameters.AddWithValue("@Bölüm", comboBölüm.Text);
                checkRandevuCommand.Parameters.AddWithValue("@Doktor", comboDoktor.Text);

                int rowCount2 = (int)checkRandevuCommand.ExecuteScalar();

                if (rowCount2==0)
                {
                    string insertQuery = "INSERT INTO Randevu (HastaTc, RandevuTarihi, RandevuSaati, Bölüm, DoktorAdı) VALUES (@Tc, @Tarih, @Saat, @Bolum, @Doktor)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connect);
                    insertCommand.Parameters.AddWithValue("@Tc", maskedTc.Text);
                    insertCommand.Parameters.AddWithValue("@Tarih", maskedTarih.Text);
                    insertCommand.Parameters.AddWithValue("@Saat", comboSaat.Text);
                    insertCommand.Parameters.AddWithValue("@Bolum", comboBölüm.Text);
                    insertCommand.Parameters.AddWithValue("@Doktor", comboDoktor.Text);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Randevu başarıyla eklendi.");


                }
                else
                {

                    MessageBox.Show("Seçilen randevu tarihinde ve saatinde başka bir randevu bulunuyor.");


                }



            }
            else
            {
                
                MessageBox.Show("Hasta Kaydınız Yoktur.");

            }



            connect.Close();
        }

        private void comboBölüm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBölüm2.Text == "Beyin Cerrahisi")
            {
                comboDoktor2.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Beyin Cerrahisi'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor2.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm2.Text == "Cildiye")
            {
                comboDoktor2.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Cildiye'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor2.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm2.Text == "Ordodonti")
            {
                comboDoktor2.Items.Clear();

                
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Ordodonti'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor2.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm2.Text == "Radyoloji")
            {
                comboDoktor2.Items.Clear();

                
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Radyoloji'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor2.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }
            else if (comboBölüm2.Text == "Genel Cerrahi")
            {


                comboDoktor2.Items.Clear();
                SqlCommand doktorcekme = new SqlCommand("SELECT * FROM Doktor WHERE Bölüm ='Genel Cerrahi'", connect);

                SqlDataReader dr;

                connect.Open();

                dr = doktorcekme.ExecuteReader();

                while (dr.Read())
                {
                    comboDoktor2.Items.Add(dr["İsim"]);


                }

                connect.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();

            string randevugöster = "SELECT * FROM Randevu WHERE Bölüm =@Bölüm AND DoktorAdı=@Doktor AND RandevuTarihi=@RandevuTarih";
            SqlCommand command = new SqlCommand(randevugöster, connect);

            command.Parameters.AddWithValue("@Bölüm",comboBölüm2.Text);
            command.Parameters.AddWithValue("@Doktor",comboDoktor2.Text);
            command.Parameters.AddWithValue("@RandevuTarih",maskedTarih2.Text);


            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Rows.Clear(); 

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string hastaTc = (string)reader["HastaTc"];
                DateTime randevuTarihi = ((DateTime)reader["RandevuTarihi"]).Date;
                
                string formatRandevuTarihi = randevuTarihi.ToString("dd.MM.yyyy");

                TimeSpan randevuSaati = (TimeSpan)reader["RandevuSaati"];
                string bolum = (string)reader["Bölüm"];
                string doktorAdi = (string)reader["DoktorAdı"];

                // DataGridView'e satır ekle
                dataGridView1.Rows.Add(hastaTc, formatRandevuTarihi, randevuSaati, bolum, doktorAdi);
            }

            reader.Close();
            connect.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
