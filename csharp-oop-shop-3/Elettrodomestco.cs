using CSharpShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        private string marca;
        private string tipo;
        private string classeenergetica;


        public Elettrodomestico(string nome, string descrizione, double prezzo, double IVA, string marca, string tipo, string classeenergetica) : base(nome, descrizione, prezzo, IVA)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.classeenergetica = classeenergetica;
        }

        public string GetMarca()
        {
            return marca;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public string GetClasseEnergetica()
        {
            return classeenergetica;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public void SetClasseEnergetica(string classeenergetica)
        {
            this.classeenergetica = classeenergetica;
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("La marca del prodotto è: " + this.marca);
            Console.WriteLine("L'elettrodomestico è un: " + this.tipo);
            Console.WriteLine("La classe energetica del prodotto è: " + this.classeenergetica);
        }
    }
}
