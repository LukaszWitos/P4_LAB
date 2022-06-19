using lab5;
using Microsoft.EntityFrameworkCore;
using projekt;
using System.Linq;

Console.WriteLine("Hello, World!");

var context = new MyDbContext();
context.Database.EnsureCreated();


List<wlasciciel> wlasciciele = new List<wlasciciel>();

wlasciciele.Add(new wlasciciel
{
    imie = "Zbyszek",
    nazwisko = "Waligóra",
    numer_tel = 5324532
});

wlasciciele.Add(new wlasciciel
{
    imie = "Konrad",
    nazwisko = "Miech",
    numer_tel = 3211513
});

wlasciciele.Add(new wlasciciel
{
    imie = "Łukasz",
    nazwisko = "Piech",
    numer_tel = 3252353
});
wlasciciele.ForEach(x =>
{
    context.wlasciciel.Add(x);
});



List<samochod> samochody = new List<samochod>();

samochody.Add(new samochod
{
    marka = "Ford",
    VIN = 43243252,
    Status = "Zarejestrowany"
});

samochody.Add(new samochod
{
    marka = "Mazda",
    VIN = 352525253,
    Status = "Zarejestrowany"
});

samochody.Add(new samochod
{
    marka = "BMW",
    VIN = 43252346,
    Status = "Niezarejestrowany"
});
samochody.ForEach(x =>
{
    context.samochod.Add(x);
});


List<dokumenty> dokumenties = new List<dokumenty>();

dokumenties.Add(new dokumenty
{
    stan = "Wydane",
    numer = 432
});

dokumenties.Add(new dokumenty
{
    stan = "Wydane",
    numer = 132
});

dokumenties.Add(new dokumenty
{
    stan = "Niewydane",
    numer = 0
});
dokumenties.ForEach(x =>
{
    context.dokumenty.Add(x);
});


context.SaveChanges();

Console.WriteLine("Witam, w aplikacji Ewidencji samochodów aby wykonać akcję:");
Console.WriteLine("Wyświetlenie danych    - 1");
Console.WriteLine("Wprowadzenie samochodu - 2");
Console.WriteLine("Edycja danych          - 3");

int a = Convert.ToInt32(Console.ReadLine());



switch (a)
{
    case 1:

        

        foreach (var samochod in context.samochod)
        {
            Console.Write($"{samochod.marka}\n");
            Console.Write($"{samochod.VIN}\n");
            Console.Write($"{samochod.Status}\n");
        }


        break;
    case 2:

        Console.WriteLine("Wprowadź markę");
        var marka = Console.ReadLine();
        Console.WriteLine("Wprowadź VIN");
        var VIN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wprowadź Status");
        var Status = Console.ReadLine();

        context.samochod.Add(new samochod
        {
            marka = marka,
            VIN = VIN,
            Status = Status
        });

        context.SaveChanges();


        break;
    case 3:


        Console.WriteLine("Podaj ID samochodu");

        var p = Convert.ToInt32(Console.ReadLine());
        var tabelka = context.samochod.Where(x => x.id == p).FirstOrDefault();

        Console.WriteLine("Wprowadź markę");
        tabelka.marka = Console.ReadLine();
        Console.WriteLine("Wprowadź VIN");
        tabelka.VIN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wprowadź Status");
        tabelka.Status = Console.ReadLine();


        context.SaveChanges();




        break;
    default:


        break;
}





//foreach (var author in context.Autor.Where
//   (a => a.Nazwisko == "bob")
//    .Include
//    (a => a.Ksiazka)) ;