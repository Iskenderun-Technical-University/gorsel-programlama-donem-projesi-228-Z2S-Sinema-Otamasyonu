using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Z2S_Sinema_Otomasyonu_Yeni_Tasarım
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //asy=Avatar Suyun Yolu
            Avatar_Suyun_Yolu asy = new Avatar_Suyun_Yolu();
            asy.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            //çd6=Çakallarla Dans 6
            Çakallarla_Dans_6 çd6 = new Çakallarla_Dans_6();
            çd6.Show();
            
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            //nhzy=Nasreddin Hoca Zaman Yolcusu
            Nasreddin_Hoca_Zaman_Yolcusu nhzy = new Nasreddin_Hoca_Zaman_Yolcusu();
            nhzy.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //yç=Yunus Çocuk
            Yunus_Çocuk yç = new Yunus_Çocuk();
            yç.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ak=Ajan Kedi
            Ajan_Kedi ak = new Ajan_Kedi();
            ak.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //bt=Buğday Tanesi
            Bugday_Tanesi bt = new Bugday_Tanesi();
            bt.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //şk=Şeytanın Kızı
            Şeytanın_Kızı şk = new Şeytanın_Kızı();
            şk.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //kg=Kurak Günler
            Kurak_Günler kg = new Kurak_Günler();
            kg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hmk=Hesap Makinesi Kısmı
            Hesap_Makinesi_Kısmı hmk = new Hesap_Makinesi_Kısmı();
            hmk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm1=Form 1
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
