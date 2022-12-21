using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Şeytanın_Kızı : Form
    {
        public Şeytanın_Kızı()
        {
            InitializeComponent();
        }

        public static Boolean deger = false;
        public static string saatt;
        public static string filmadii = "Şeytanın Kızı";
        public static string tarihh;


        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Şeytanın_Kızı_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;

            if (radioButton11.Checked == true)
            {
                saatt = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                saatt = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                saatt = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                saatt = radioButton14.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                tarihh = dateTimePicker1.Value.ToString("dd:MM:yyyy");
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
