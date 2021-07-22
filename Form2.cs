using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba car2 = new Araba();
            car2.renk = "Siyah";
            car2.hiz = 260;
            car2.motor = 1900;
            car2.fiyat = 150000;
            car2.durum = '0';
            car2.Yil = -2010;
            car2.Markasi = "Range Rover";
            label1.Text = car2.renk;
            label2.Text = car2.hiz.ToString() ;
            label3.Text = car2.motor.ToString();
            label4.Text = car2.fiyat.ToString();
            label5.Text = car2.durum.ToString();
            label6.Text = car2.Yil.ToString();
            label7.Text = car2.Markasi;

        }
    }
}
