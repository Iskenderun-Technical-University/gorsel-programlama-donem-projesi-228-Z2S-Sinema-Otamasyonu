using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Ajan_Kedi : Form
    {
        public Ajan_Kedi()
        {
            InitializeComponent();
        }

        public static Boolean deger = false;
        public static string x ;
        public static string y = "Ajan Kedi";
        public static string z;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ajan_Kedi_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;

            if (radioButton11.Checked == true)
            {
                x = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                x = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                x = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                x = radioButton14.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                z = dateTimePicker1.Value.ToString("dd:MM:yyyy");
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
