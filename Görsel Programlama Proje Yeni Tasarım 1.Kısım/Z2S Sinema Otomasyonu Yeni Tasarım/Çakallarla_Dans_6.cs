using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Çakallarla_Dans_6 : Form
    {
        public Çakallarla_Dans_6()
        {
            InitializeComponent();
        }

        public static string time;
        public static Boolean deger=false;
        public static string filmsname = "Çakallarla Dans 6";
        public static string date;

        private void Çakallarla_Dans_6_Load(object sender, EventArgs e)
        {

        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;
            if (radioButton11.Checked == true)
            {
                time = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                time = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                time = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                time = radioButton14.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                date = dateTimePicker1.Value.ToString("dd:MM:yyyy");

                //hmk=Hesap Makinesi Kısmı
                Koltuk_Seçimi_Kısmı ksk = new Koltuk_Seçimi_Kısmı();
                ksk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçmiş tarihli randevu oluşturulamaz");
            }
        }

        /* private void button1_Click(object sender, EventArgs e)
          {
              Form2 frm2 = new Form2();
              frm2.Show();
              this.Hide();
            }*/
    }
}
