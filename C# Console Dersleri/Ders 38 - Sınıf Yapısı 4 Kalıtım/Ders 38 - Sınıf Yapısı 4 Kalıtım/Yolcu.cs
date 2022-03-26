using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ders_38___Sınıf_Yapısı_4_Kalıtım
{
    class Yolcu
    {
        private string ad;
        private string soyad;    
        private int yas;
        private string cinsiyet;
        
        
        public string AD
        {
            get { return ad; }
            set { ad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }  // Yazının baş harfini büyük yapması için bu metodu kullandık xd.
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
        }

      

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public string CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToLower(); }
        }

    }
}
