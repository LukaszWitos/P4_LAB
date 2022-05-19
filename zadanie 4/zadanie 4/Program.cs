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
        Nazwisko = "dsa"
    };


autor.Ksiazka.Add(new Ksiazka()
{
    Tytul = "Cos o czyms",
    rok = 2000,
    Autor = "Konrad"
});
context.Autor.Add(autor);




context.SaveChanges();

foreach (var author in context.Autor.Where
    (a => a.Nazwisko == "Konrad")
    .Include
    (a => a.Ksiazka)) ;
/*foreach (var item in context.Clients
    .Include(x => x.Orders)
    .ToList())
{
    Console.WriteLine(item.Name);
}*/