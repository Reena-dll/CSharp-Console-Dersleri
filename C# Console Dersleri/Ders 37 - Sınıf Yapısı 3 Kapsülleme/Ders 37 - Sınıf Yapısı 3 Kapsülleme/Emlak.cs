using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_37___Sınıf_Yapısı_3_Kapsülleme
{
    class Emlak
    {

        private string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;


        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); } // Girlen Semt ismini Büyük harf ile yazdırma komutu.
        }

        public string RENK
        {
            get { return renk; }
            set { renk = value.ToLower() ; } // Girilen Renk  ismini küçük harfler ile yazdırma komutu.
        }

        public int odasayi
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); } // Girilen oda sayisi değerini Mutlak değerli bir şekilde aldırma.
        }

        public int katnumara
        {
            get { return katno; }
            set { katno = Math.Abs(value); }  // Girilen kat numara değerini Mutlak değerli bir şekilde aldırma.
        }

        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }  // Girilen alan değerini Mutlak değerli bir şekilde aldırma.
        }
    }
}
