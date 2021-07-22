using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_Class
{
    class Araba:ArabaDetay //araba sınıfına arabadetay sınıfındaki değerleri aktardık kalıtım alarak
    { //araba sınıfının özellikleri
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        //private olan özellikler formdan çağrılmaz
        private int yil;
        private string Marka;
        //erişim belirteçi tanımlayalım 
        public int  Yil
        {//burada get ile değeri alıp set  kapsülleme yapıp label attık
            get
            {
                return yil;
            }
            set
            {
                yil = Math.Abs(value); //gelen yil değeri negatif girilse bile pozitife çevir
                //abs burada mutlak değer 
            }
        }
        public String Markasi
        {
            get
            {
                return Marka;
            }
            set
            {
                Marka = value.ToUpper(); //gelen marka değerini tamamen büyük harfe çevir
            }
        }
    }
}
