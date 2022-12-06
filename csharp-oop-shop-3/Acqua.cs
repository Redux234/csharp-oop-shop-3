using CSharpShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Acqua : Prodotto
    {
        private double litri;
        private int ph;
        private string sorgente;




        public Acqua(string nome, string descrizione, double prezzo, double IVA, double litri, int ph, string sorgente) : base(nome, descrizione, prezzo, IVA)
        {
            this.sorgente = sorgente;
            SetLitri(litri);
            this.ph = ph;

        }


        public double GetLitri()
        {
            return litri;
        }
        public int GetPh()
        {
            return ph;
        }
        public string GetSorgente()
        {
            return sorgente;
        }

        public void SetLitri(double litri)
        {
            if (litri < 0)
            {
                this.litri = 0;

            }
            else if (litri > 1.5)
            {
                this.litri = 1.5;
            }
            else
            {
                this.litri = litri;
            }
        }
        public void SetPh(int ph)
        {
            if (ph < 0)
            {
                ph = 0;
            }
            else if (ph > 7)
            {
                ph = 7;
            }
            else
            {
                this.ph = ph;
            }
        }
        public void SetSorgente(string sorgente)
        {
            this.sorgente = sorgente;
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Litri: " + this.litri);
            Console.WriteLine("Ph: " + this.ph);
            Console.WriteLine("La sorgente è: " + this.sorgente);
        }

    }



}
