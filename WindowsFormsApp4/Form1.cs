using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string ad = txt_Ad.Text;
            string soyad = txt_Soyad.Text;
            try
            {
                if (ad == "Ege" && soyad == "Aydın")
                {
                    MessageBox.Show("Hoşgeldiniz Efendim");
                }
                else
                {
                    MessageBox.Show("Yanlış ad yada soyad");
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Lütfen hatalı tuşlama yapmayınız");
            }
        }
    }
}
