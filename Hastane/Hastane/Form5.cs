using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="Admin" )
            {
                if(textBox2.Text == "1234")
                {

                    Form4 frm4 = new Form4();
                    frm4.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Şifreniz Yanlış");

                }


            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Yanlış");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }
    }
}
