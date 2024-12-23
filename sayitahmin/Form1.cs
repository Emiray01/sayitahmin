using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi, tahmin=0,tahminhak=10;

        Random tahminsayi = new Random();
        public void Form1_Load(object sender, EventArgs e)
        {
            sayi = tahminsayi.Next(0,101);
        }

        private void tahminet_btn_Click(object sender, EventArgs e)
        {
            tahmin =Convert.ToInt32(tahmin_txt.Text);

            if (tahmin != sayi)
            {
                tahminhak = tahminhak-1;
                tahminhak_lbl.Text = Convert.ToString(tahminhak);
            }
            if (tahmin == sayi)
            {
                tahminhak = tahminhak + 5;
                tahminhak_lbl.Text = Convert.ToString(tahminhak);
                MessageBox.Show("Doğru bildiniz");
                sayi=tahminsayi.Next(0,101);
            }
            else if (tahmin > sayi)
            {
                MessageBox.Show("Sayıyı Azalt");
            }
            else if (tahmin < sayi)
            {
                MessageBox.Show("Sayıyı Arttır");
            }
            if (tahminhak == 0)
            {
                MessageBox.Show("Kaybettiniz! Tahmin Hakkınız kalmadı");
                Application.Exit();
            }

        }
    }
}