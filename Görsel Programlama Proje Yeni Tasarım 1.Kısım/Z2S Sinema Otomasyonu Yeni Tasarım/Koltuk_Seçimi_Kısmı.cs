using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Koltuk_Seçimi_Kısmı : Form
    {
        public Koltuk_Seçimi_Kısmı()
        {
            InitializeComponent();
        }
        public static List<string> koltuk_sec = new List<string>();

        private void Koltuk_Seçimi_Kısmı_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                koltuk_sec.Add(checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                koltuk_sec.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                koltuk_sec.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                koltuk_sec.Add(checkBox4.Text);
            }
            if (checkBox5.Checked == true)
            {
                koltuk_sec.Add(checkBox5.Text);
            }
            if (checkBox6.Checked == true)
            {
                koltuk_sec.Add(checkBox6.Text);
            }
            if (checkBox7.Checked == true)
            {
                koltuk_sec.Add(checkBox7.Text);
            }
            if (checkBox8.Checked == true)
            {
                koltuk_sec.Add(checkBox8.Text);
            }
            if (checkBox9.Checked == true)
            {
                koltuk_sec.Add(checkBox9.Text);
            }
            if (checkBox10.Checked == true)
            {
                koltuk_sec.Add(checkBox10.Text);
            }
            if (checkBox11.Checked == true)
            {
                koltuk_sec.Add(checkBox11.Text);
            }
            if (checkBox12.Checked == true)
            {
                koltuk_sec.Add(checkBox12.Text);
            }
            if (checkBox13.Checked == true)
            {
                koltuk_sec.Add(checkBox13.Text);
            }
            if (checkBox14.Checked == true)
            {
                koltuk_sec.Add(checkBox14.Text);
            }
            if (checkBox15.Checked == true)
            {
                koltuk_sec.Add(checkBox15.Text);
            }
            if (checkBox16.Checked == true)
            {
                koltuk_sec.Add(checkBox16.Text);
            }
            if (checkBox17.Checked == true)
            {
                koltuk_sec.Add(checkBox17.Text);
            }
            if (checkBox18.Checked == true)
            {
                koltuk_sec.Add(checkBox18.Text);
            }


            Hesap_Makinesi_Kısmı hsk = new Hesap_Makinesi_Kısmı();
            hsk.Show();
        }
    }
}
