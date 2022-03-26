using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_38___Sınıf_Yapısı_4_Kalıtım
{
    class Ucak:Yolcu  // Kalıtım için yolcu sınıfını buraya aktardık. 
    {

        private string marka;
        private string kalkis;
        private string varis;

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }

        public string KALKİS
        {
            get { return kalkis; }
            set { kalkis = value.ToUpper(); }
        }

        public string VARİS
        {
            get { return varis; }
            set { varis = value.ToUpper(); }

        }

    }
}
