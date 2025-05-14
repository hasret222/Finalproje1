using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class KiralikAraba : Araba
    {
        public double Kira { get; set; }
        public double deposito { get; set; }
        public KiralikAraba()
        {



        }

        public KiralikAraba(double kira, double deposito, int kapiSayisi, int koltukSayisi, double hız, string model) : base(kapiSayisi, koltukSayisi, hız, model)
        {
            Kira = kira;
            this.deposito = deposito;


        }
        public override double FiyatHesapla()
        {
            return Kira + deposito;
        }
        public override string TipiGoster()
        {
            return "Kiralık Araba";
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nKira:{this.Kira}\nDeposito:{this.deposito}";

        }



    }
}
