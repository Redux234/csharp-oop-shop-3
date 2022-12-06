using CSharpShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class CiboInScatola : Prodotto
    {
        private int peso;
        private string cibo;
        private int annoscadenza;


        public CiboInScatola(int peso, string cibo, int annoscadenza, string nome, string descrizione, double prezzo, double IVA) : base(nome, descrizione, prezzo, IVA)

        {
            SetPeso(peso);
            this.cibo = cibo;
            this.annoscadenza = annoscadenza;

        }

        public int GetPeso()
        {
            return peso;
        }
        public string GetCibo()
        {
            return cibo;
        }
        public int GetAnnoscadenza()
        {
            return annoscadenza;
        }

        public void SetPeso(int peso)
        {
            if (peso > 300)
            {
                peso = 300;
            }
            else if (peso < 0)
            {
                peso = 0;
            }
            else
            {
                this.peso = peso;
            }
        }
        public void SetCibo(string cibo)
        {
            this.cibo = cibo;
        }
        public void SetAnnoScadenza(int annoscadenza)
        {
            if (annoscadenza < 2022)
            {
                Console.Write("è scaduto");
            }
            else
            {
                this.annoscadenza = annoscadenza;
            }
        }


        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Il cibo in scatola pesa: " + this.peso + " grammi");
            Console.WriteLine("Stai mangiando: " + this.cibo);
            Console.WriteLine("Il prodotto scadrà nel: " + this.annoscadenza);
        }
    }


}
