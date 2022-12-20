using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Yunus_Çocuk : Form
    {
        public Yunus_Çocuk()
        {
            InitializeComponent();
        }

        public static Boolean deger = false;
        public static string timedeger;
        public static string filmsnamedeger = "Yunus Çocuk";
        public static string datedeger;

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Yunus_Çocuk_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;

            if (radioButton11.Checked == true)
            {
                timedeger = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                timedeger = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                timedeger = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                timedeger = radioButton14.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                datedeger = dateTimePicker1.Value.ToString("dd:MM:yyyy");
                //ksk=Koltuk Seçimi kısmı
                Koltuk_Seçimi_Kısmı ksk = new Koltuk_Seçimi_Kısmı();
                ksk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçmiş tarihli randevu oluşturulamaz");
            }
        }
    }
}
