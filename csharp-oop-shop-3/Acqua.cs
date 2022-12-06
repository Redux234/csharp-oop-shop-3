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
        private double litriDaBere;

        public Acqua()
        {

        }

        public Acqua(string nome, string descrizione, double prezzo, double IVA, double litri, int ph, string sorgente, double litriDaBere) : base(nome, descrizione, prezzo, IVA)
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
            if (litriDaBere > litri)
            {
                throw new ArgumentOutOfRangeException("litriDaBere", "Non puoi bere più acqua di quanta è nella bottiglia");
            }
            else if (litriDaBere < 0)
            {
                throw new ArgumentOutOfRangeException("litriDaBere", "Non puoi bere una quantità negativa di acqua");
            }
            else
            {
                this.litriDaBere = litriDaBere;
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
        public double GetLitriDaBere()
        {
            return litriDaBere;
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
                this.litri = litri;
            }
        }
        public void SetPh(int ph)
        {
            if (ph < 0)
            {
                this.ph = -1;
                throw new ArgumentOutOfRangeException("ph", "L'acqua non può avere un valore di ph negativo");
            }
            else if (ph > 10)
            {
                this.ph = -1;
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

        public void SetLitriDaBere(double litriDaBere)
        {
            if (litriDaBere > litri)
            {
                throw new ArgumentOutOfRangeException("litriDaBere", "Non puoi bere più acqua di quanta è nella bottiglia");
            }
            else if (litriDaBere < 0)
            {
                throw new ArgumentOutOfRangeException("litriDaBere", "Non puoi bere una quantità negativa di acqua");
            }
            else
            {
                this.litriDaBere = litriDaBere;
            }
        }

        private double AcquaBevuta()
        {
            double acquabevuta = this.litri - this.litriDaBere;
            return acquabevuta;
        }


        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Litri: " + this.litri);
            Console.WriteLine("Ph: " + this.ph);
            Console.WriteLine("La sorgente è: " + this.sorgente);
            Console.WriteLine("Hai bevuto " + this.litriDaBere + " litri");
            Console.WriteLine("L'acqua rimasta è " + AcquaBevuta());
        }

    }



}
