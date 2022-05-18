// See https://aka.ms/new-console-template for more information
using lab5;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var context = new MyDbContext();
context.Database.EnsureCreated();
/*var client =
    new Client()
    {
        Name = "Jan Kowalski"
    };

client.Orders.Add(new Order()
{
    Price = 10m
});
 context.Clients.Add(client);

context.SaveChanges();
*/
foreach (var item in context.Clients
    .Include(x => x.Orders)
    .ToList())
{
    Console.WriteLine(item.Name);
}