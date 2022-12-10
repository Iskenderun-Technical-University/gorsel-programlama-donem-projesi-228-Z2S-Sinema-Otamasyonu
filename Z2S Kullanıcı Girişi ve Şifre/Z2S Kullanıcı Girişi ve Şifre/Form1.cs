using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z2S_Kullanıcı_Girişi_ve_Şifre
{
    public partial class Kullanici_Girisi_ve_Sifre : Form
    {
        public Kullanici_Girisi_ve_Sifre()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vizyondaki_Filmler_ve_Bilgileri vfvb = new Vizyondaki_Filmler_ve_Bilgileri();
            vfvb.Show();
            this.Hide();

        }
    }
}
