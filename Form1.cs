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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//oluşturduğumuz class dan nesne türeteceğiz
            Araba car = new Araba(); //Araba classından car isminde nesne yaptık 
            car.renk = "Mavi";
            car.hiz = 240;
            car.motor = 1600;
            car.fiyat = 120000;
            car.durum = '0';
            car.Yil = -2012;
            car.Markasi = "Porsche";
            car.sahip = "Hüsnü Karaca";
            car.muayeneyil = 2022;
            car.plaka = "06 AB 1938";
            //şimdi cara tanımladığımız özellikleri form1 de bulunan label yazdıralım
            label1.Text = car.renk;
            label2.Text = car.hiz.ToString(); //değer integer stringe çevirdik
            label3.Text = car.motor.ToString();
            label4.Text = car.fiyat.ToString();
            label5.Text = car.durum.ToString();
            label6.Text = car.Yil.ToString();
            label7.Text = car.Markasi;
            label8.Text = car.sahip;
            label9.Text = car.muayeneyil.ToString() ;
            label10.Text = car.plaka;
        }
    }
}
