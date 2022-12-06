using csharp_oop_shop_2;
using CSharpShop;

Acqua prodotto1 = new Acqua();

try
{
    Console.WriteLine("Dammi il nome del prodotto");
    prodotto1.SetNome(Console.ReadLine());
    prodotto1.SetCodice();
    Console.WriteLine("Scrivi la descrizone del prodotto");
    prodotto1.SetDescription(Console.ReadLine());
    Console.WriteLine("Scrivi il prezzo del prodotto");
    prodotto1.SetPrezzo(Double.Parse(Console.ReadLine()));
    Console.WriteLine("IVA del prodotto");
    prodotto1.SetIVA(Double.Parse(Console.ReadLine()));
    prodotto1.SetLitri(1.5);
    Console.WriteLine("Inserire la Sorgente");
    prodotto1.SetSorgente(Console.ReadLine());
    Console.WriteLine("Inserire il Ph");
    prodotto1.SetPh(int.Parse(Console.ReadLine()));
    Console.WriteLine("inserire i litri da bere");
    prodotto1.SetLitriDaBere(Double.Parse(Console.ReadLine())); 
        }
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Valore immesso errato, il valore di default è -1");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}


Sacchetto prodotto2 = new Sacchetto("Sacchetto di frutta", "Questo è un sacchetto di frutta", 55, 99, 3, "mela");
Elettrodomestico prodotto3 = new Elettrodomestico("XG37-12", "Lavatrice", 399, 22, "LG", "Lavatrice", "A+++");
CiboInScatola prodotto4 = new CiboInScatola(450, "Tonno", +2050, "Tonno in scatola", "Tonnoooooooooo", 12, 18);

List<Prodotto> prodotti = new List<Prodotto>();

prodotto1.StampaProdotto();

