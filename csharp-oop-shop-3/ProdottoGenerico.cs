using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{

    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double IVA;

        public Prodotto()
        {

        }


        public Prodotto(string nome, double prezzo, double IVA)
        {
            this.codice = CalcoloCodice();
            this.nome = nome;
            this.prezzo = Math.Round(prezzo, 2);
            this.IVA = IVA;
        }


        public Prodotto(string nome, string descrizione, double prezzo, double IVA)
        {
            this.codice = CalcoloCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = Math.Round(prezzo, 2);
            this.IVA = IVA;
        }

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public void SetDescription(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public double GetPrezzoIVA()
        {
            double prezzoIVA = (this.prezzo + (this.prezzo * this.IVA) / 100);
            prezzoIVA = Math.Round(prezzoIVA, 2);
            return prezzoIVA;

        }

        public void SetPrezzo(double prezzo)
        {
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                Console.WriteLine("Il prezzo non può avere un valore negativo!");
            }
        }

        public double GetIVA()
        {
            return this.IVA;
        }

        public void SetIVA(double IVA)
        {
            this.IVA = IVA;
        }

        private int CalcoloCodice()
        {

            Random generatoreRandom = new Random();
            int numeroCodice = generatoreRandom.Next(9999999);
            return numeroCodice;
        }

        public void SetCodice()
        {
            this.codice = CalcoloCodice();
        }


        public string StampaPrezzoBase()
        {
            string prezzoBase = (this.prezzo).ToString();
            prezzoBase += " euro";
            return prezzoBase;
        }

        public string StampaPrezzoIVA()
        {
            double prezzoIVA = this.GetPrezzoIVA();
            string prezzo = prezzoIVA.ToString();
            prezzo += " euro";
            return prezzo;
        }

        public string GetNomeEsteso()
        {
            string codiceStringa = this.codice.ToString();
            codiceStringa = codiceStringa.PadLeft(8, '0');
            return codiceStringa + this.nome;
        }

        public virtual void StampaProdotto()
        {
            Console.WriteLine("------ " + this.nome + " -----");
            Console.WriteLine();
            Console.WriteLine(this.descrizione);
            Console.WriteLine("Il codice del prodotto è: " + this.codice);
            Console.WriteLine("Il prezzo senza IVA del prodotto è: " + this.StampaPrezzoBase());
            Console.WriteLine("Il prezzo comprensivo di IVA è: " + this.StampaPrezzoIVA());
            Console.WriteLine("L'IVA del prodotto è al: " + this.IVA + "%");
            Console.WriteLine();
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }



    }


}