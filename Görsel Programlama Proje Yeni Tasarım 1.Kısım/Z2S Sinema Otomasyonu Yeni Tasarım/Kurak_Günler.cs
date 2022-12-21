using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Kurak_Günler : Form
    {
        public Kurak_Günler()
        {
            InitializeComponent();
        }

        public static Boolean deger = false;
        public static string a;
        public static string b = "Kurak Günler";
        public static string c;

        private void Kurak_Günler_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deger = true;

            if (radioButton11.Checked == true)
            {
                a = radioButton11.Text;
            }
            else if (radioButton12.Checked == true)
            {
                a = radioButton12.Text;
            }
            else if (radioButton13.Checked == true)
            {
                a = radioButton13.Text;
            }
            else if (radioButton14.Checked == true)
            {
                a = radioButton14.Text;
            }
            if (DateTime.Now <= dateTimePicker1.Value)
            {
                c = dateTimePicker1.Value.ToString("dd:MM:yyyy");
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
