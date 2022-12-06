using CSharpShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Sacchetto : Prodotto
    {
        private int pezzifrutta;
        private string frutta;


        public Sacchetto(string nome, string descrizione, double prezzo, double IVA, int pezzifrutta, string frutta) : base(nome, descrizione, prezzo, IVA)
        {
            this.pezzifrutta = pezzifrutta;
            this.frutta = frutta;
        }

        public int GetPezzifrutta()
        {
            return pezzifrutta;
        }

        public string GetFrutta()
        {
            return frutta;
        }

        public void SetPezziFrutta(int pezziFrutta)
        {
            if (pezzifrutta > 5)
            {
                this.pezzifrutta = 5;
            }
            else if (pezzifrutta < 0)
            {
                this.pezzifrutta = 0;
            }
            else
            {
                this.pezzifrutta = pezziFrutta;
            }
        }

        public void SetFrutta(string frutta)
        {
            this.frutta = frutta;
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Il tuo sacchetto ha " + this.pezzifrutta + "pezzi di frutta");
            Console.WriteLine("Il tuo sacchetto ha come frutta: " + this.frutta);
        }
    }

}
