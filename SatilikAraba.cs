using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{

    public class SatilikAraba : Araba
    {
        public double Satisfiyat { get; set; }

        public SatilikAraba() { }

        public SatilikAraba(double satisfiyat, int kapiSayisi, string model, int koltukSayisi, double hiz)
            : base(kapiSayisi, koltukSayisi, hiz, model)
        {
            Satisfiyat = satisfiyat;
        }
        public override double FiyatHesapla()
        {
            return Satisfiyat;
        }
        public override string TipiGoster()
        {
            return "Satılık Araba";
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nSatis Fiyati: {Satisfiyat}";
        }
    }

}
