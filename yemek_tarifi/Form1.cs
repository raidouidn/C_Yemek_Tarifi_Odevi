using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemek_tarifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> tarifler = new List<string>();
        string tarif = "";


        int i = 1;
        private void BtnAdimEkle_Click(object sender, EventArgs e)
        {
            
            LblAdim.Text = i + ".Adım : ";
            tarif = tarif + TxtAdim.Text + "\n";
            i++;
            TxtAdim.Text = " ";
        }

        private void BtnTarifiKaydet_Click(object sender, EventArgs e)
        {
            LblAdim.Text = "1.Adım : ";
            tarif = TxtTarifAdi.Text + "\n" + tarif;
            tarifler.Add(tarif + "\n");
            TxtTarifAdi.Text = " ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int sayi = tarifler.Count;
            richTextBox1.Clear();
            for (int i = 0; i < sayi; i++)
            {
                richTextBox1.Text += tarifler[i].ToString();
            }
        }
    }
}
