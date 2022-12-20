using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Avatar_Suyun_Yolu : Form
    {
        public Avatar_Suyun_Yolu()
        {
            InitializeComponent();
        }
        public static Boolean deger = false;
        public static string saat;
        public static string filmadi = "Avatar Suyun Yolu";
        public static string tarih;

        private void Avatar_Suyun_Yolu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;

            if (radioButton7.Checked == true)
            {
                saat = radioButton7.Text;
            }
            else if (radioButton8.Checked == true)
            {
                saat = radioButton8.Text;
            }
            else if (radioButton9.Checked == true)
            {
                saat = radioButton9.Text;
            }
            else if (radioButton10.Checked == true)
            {
                saat = radioButton10.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                tarih = dateTimePicker1.Value.ToString("dd:MM:yyyy");
                //ksk=Koltuk Seçimi kısmı
                Koltuk_Seçimi_Kısmı ksk = new Koltuk_Seçimi_Kısmı();
                ksk.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Geçmiş tarihli randevu oluşturulamaz");
            }
             
    {


            }

            /*private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
