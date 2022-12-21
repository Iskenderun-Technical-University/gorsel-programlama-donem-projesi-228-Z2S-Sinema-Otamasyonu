using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Hesap_Makinesi_Kısmı : Form
    {
        public Hesap_Makinesi_Kısmı()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, kahve, su, bilet;

            misir = Convert.ToInt16(textBox1.Text);
            cay = Convert.ToInt16(textBox2.Text);
            kahve = Convert.ToInt16(textBox3.Text);
            su = Convert.ToInt16(textBox4.Text);
            bilet = Convert.ToInt16(textBox5.Text);

            int toplam;
            toplam = misir * 30 + cay * 10 + kahve * 15 + su * 5 + bilet * 60;

            kasatutar = kasatutar + toplam;

            label12.Text = toplam.ToString();
            label13.Text = kasatutar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int misir, cay, kahve, su, bilet;

            misir = Convert.ToInt16(textBox1.Text);
            cay = Convert.ToInt16(textBox2.Text);
            kahve = Convert.ToInt16(textBox3.Text);
            su = Convert.ToInt16(textBox4.Text);
            bilet = Convert.ToInt16(textBox5.Text);

            int toplam;
            toplam = misir * 30 + cay * 10 + kahve * 15 + su * 5 + bilet * 50;

            kasatutar = kasatutar + toplam;

            label12.Text = toplam.ToString();
            label13.Text = kasatutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Avatar_Suyun_Yolu.deger == true)
            {
                listBox1.Items.Add(Avatar_Suyun_Yolu.saat);
                listBox1.Items.Add(Avatar_Suyun_Yolu.filmadi);
                listBox1.Items.Add(Avatar_Suyun_Yolu.tarih);
                Avatar_Suyun_Yolu.deger = false;
            }
            else if (Çakallarla_Dans_6.deger == true)
            {
                listBox1.Items.Add(Çakallarla_Dans_6.time);
                listBox1.Items.Add(Çakallarla_Dans_6.filmsname);
                listBox1.Items.Add(Çakallarla_Dans_6.date);
                Çakallarla_Dans_6.deger=false;
            }

            else if (Nasreddin_Hoca_Zaman_Yolcusu.deger == true)
            {
                listBox1.Items.Add(Nasreddin_Hoca_Zaman_Yolcusu.saatdegeri);
                listBox1.Items.Add(Nasreddin_Hoca_Zaman_Yolcusu.filmadidegeri);
                listBox1.Items.Add(Nasreddin_Hoca_Zaman_Yolcusu.tarihdegeri);
               Nasreddin_Hoca_Zaman_Yolcusu.deger = false;
            }

            else if (Yunus_Çocuk.deger == true)
            {
                listBox1.Items.Add(Yunus_Çocuk.timedeger);
                listBox1.Items.Add(Yunus_Çocuk.filmsnamedeger);
                listBox1.Items.Add(Yunus_Çocuk.datedeger);
                Yunus_Çocuk.deger = false;
            }

            else if (Ajan_Kedi.deger == true)
            {
                listBox1.Items.Add(Ajan_Kedi.x);
                listBox1.Items.Add(Ajan_Kedi.y);
                listBox1.Items.Add(Ajan_Kedi.z);
                Ajan_Kedi.deger = false;
            }

            else if (Bugday_Tanesi.deger == true)
            {
                listBox1.Items.Add(Bugday_Tanesi.timee);
                listBox1.Items.Add(Bugday_Tanesi.filmsnamee);
                listBox1.Items.Add(Bugday_Tanesi.datee);
                Bugday_Tanesi.deger = false;
            }

            else if (Şeytanın_Kızı.deger == true)
            {
                listBox1.Items.Add(Şeytanın_Kızı.saatt);
                listBox1.Items.Add(Şeytanın_Kızı.filmadii);
                listBox1.Items.Add(Şeytanın_Kızı.tarihh);
                Şeytanın_Kızı.deger = false;
            }

            else if (Kurak_Günler.deger == true)
            {
                listBox1.Items.Add(Kurak_Günler.a);
                listBox1.Items.Add(Kurak_Günler.b);
                listBox1.Items.Add(Kurak_Günler.c);
                Kurak_Günler.deger = false;
            }



            foreach (string koltukismi in Koltuk_Seçimi_Kısmı.koltuk_sec)
            {
                listBox1.Items.Add(koltukismi);
            }




        }

        private void Hesap_Makinesi_Kısmı_Load(object sender, EventArgs e)
        {

        }
    }
}
