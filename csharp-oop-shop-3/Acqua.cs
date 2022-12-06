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
            if (litri  < 0 )
            {
                throw new ArgumentOutOfRangeException("litri", "La bottiglia non può avere una quantità di litri negativa");
            }
            else if(litri > 1.5)
            {
                throw new ArgumentOutOfRangeException("litri", "La bottiglia può contenere massimo 1,5 litri d'acqua");
            }
            else
            {
                SetLitri(litri);
            }
            if (ph < 0)
            {
                throw new ArgumentOutOfRangeException("ph", "L'acqua non può avere un valore di ph negativo");
            }
            else if(ph>10)
            {
                throw new ArgumentOutOfRangeException("ph", "L'acqua non può avere un valore di ph superiore a 10");
            }
            else
            {
                this.ph = ph;
            }
            

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
                throw new ArgumentOutOfRangeException("litri", "La bottiglia non può avere una quantità di litri negativa");
            }
            else if (litri > 1.5)
            {
                throw new ArgumentOutOfRangeException("litri", "La bottiglia può contenere massimo 1,5 litri d'acqua");
            }
            else
            {
                SetLitri(litri);
            }
        }
        public void SetPh(int ph)
        {
            if (ph < 0)
            {
                throw new ArgumentOutOfRangeException("ph", "L'acqua non può avere un valore di ph negativo");
            }
            else if (ph > 10)
            {
                throw new ArgumentOutOfRangeException("ph", "L'acqua non può avere un valore di ph superiore a 10");
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
