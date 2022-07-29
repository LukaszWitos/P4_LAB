using lab5;
using Microsoft.EntityFrameworkCore;
using zadanie_4;
Console.WriteLine("Hello, World!");

var context = new MyDbContext();
context.Database.EnsureCreated();

var autor =
    new Autor()
    {
        Imie = "Konrad",
        Nazwisko = "Witos"
    };
    new Autor()
    {
        Imie = "Zbychu",
        Nazwisko = "Inny"
    };


autor.Ksiazka.Add(new Ksiazka()
{
    Tytul = "Cos o czyms",
    rok = 2000,
    Autor = "Witos"
});
autor.Ksiazka.Add(new Ksiazka()
{
    Tytul = "Północ nieba",
    rok = 2004,
    Autor = "Inny"
});
context.Autor.Add(autor);




context.SaveChanges();

Console.WriteLine("Podaj nazwisko autora:");

var nazwa = Console.ReadLine();

var wyszukanie = context.Ksiazka
    .Where(Ksiazka => Ksiazka.Autor == nazwa);

foreach (var Ksiazka in wyszukanie)
{
    Console.WriteLine($"{Ksiazka.Autor}{Ksiazka.Tytul}{Ksiazka.rok}");
}

Console.WriteLine("Podaj tytuł książki:");

var nazwa2 = Console.ReadLine();

var wyszukanie2 = context.Ksiazka
    .Where(Ksiazka => Ksiazka.Tytul == nazwa2);

foreach (var Ksiazka in wyszukanie)
{
    Console.WriteLine($"{Ksiazka.Autor}{Ksiazka.Tytul}{Ksiazka.rok}");
}

/*

foreach (var Ksiazka in context.Ksiazka)
{
    Console.Write($"{Ksiazka.Id}\n");
    Console.Write($"{Ksiazka.Tytul}\n");
    Console.Write($"{Ksiazka.Autor}\n");
}

*/




/*foreach (var item in context.Clients
    .Include(x => x.Orders)
    .ToList())
{
    Console.WriteLine(item.Name);
}*/