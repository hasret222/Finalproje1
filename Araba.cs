using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Araba
    {
        public static int Sayac { get; private set; }

        private string _model;
        private int _kapiSayisi;

        public int KoltukSayisi { get; set; }
        public double Hiz { get; set; }

        public string Model
        {
            get => _model;
            set => _model = value.ToUpper();
        }

        public int KapiSayisi
        {
            get => _kapiSayisi;
            set => _kapiSayisi = Math.Abs(value);
        }

        public Araba()
        {
            Sayac++;
        }

        public Araba(int kapiSayisi, int koltukSayisi, double hiz, string model)
        {
            KapiSayisi = kapiSayisi;
            KoltukSayisi = koltukSayisi;
            Hiz = hiz;
            Model = model;
            Sayac++;
        }
        public abstract double FiyatHesapla();
        public abstract string TipiGoster();
        public override string ToString()
        {
            return $"Model: {Model}\nHiz: {Hiz}\nKapi Sayisi: {KapiSayisi}\nKoltuk Sayisi: {KoltukSayisi}";
        }
    
}

}
