using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Bugday_Tanesi : Form
    {
        public Bugday_Tanesi()
        {
            InitializeComponent();
        }


        public static Boolean deger = false;
        public static string timee;
        public static string filmsnamee = "Buğday Tanesi";
        public static string datee;

        private void Bugday_Tanesi_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;

            if (radioButton11.Checked == true)
            {
                timee = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                timee = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                timee = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                timee = radioButton14.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                datee = dateTimePicker1.Value.ToString("dd:MM:yyyy");
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
