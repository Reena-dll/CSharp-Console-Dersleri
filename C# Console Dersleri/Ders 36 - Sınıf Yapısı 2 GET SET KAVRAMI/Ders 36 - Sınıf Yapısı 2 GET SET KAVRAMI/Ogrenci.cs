using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_36___Sınıf_Yapısı_2_GET_SET_KAVRAMI
{
    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        } 

        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public int YASI
        {
            get { return yas; }
            set
            {
                if (value<18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }

        public string ALANI
        {
            get { return alan; }
            set { alan = value; }
        }

        

    }
}
