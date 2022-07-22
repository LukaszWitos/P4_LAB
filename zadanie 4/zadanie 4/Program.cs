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
        Nazwisko = "bob"
    };


autor.Ksiazka.Add(new Ksiazka()
{
    Tytul = "Cos o czyms",
    rok = 2000,
    Autor = "Konrad"
});
context.Autor.Add(autor);




context.SaveChanges();

var wyszukanie = context.Ksiazka
    .Where(Ksiazka => Ksiazka.Autor == "Konrad");

foreach (var Ksiazka in wyszukanie)
{
    Console.WriteLine($"{Ksiazka.Autor}{Ksiazka.Tytul}{Ksiazka.rok}");
}


foreach (var Ksiazka in context.Ksiazka)
{
    Console.Write($"{Ksiazka.Id}\n");
    Console.Write($"{Ksiazka.Tytul}\n");
    Console.Write($"{Ksiazka.Autor}\n");
}






/*foreach (var item in context.Clients
    .Include(x => x.Orders)
    .ToList())
{
    Console.WriteLine(item.Name);
}*/