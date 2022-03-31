// See https://aka.ms/new-console-template for more information
using Dapper;
using System.Data.SqlClient;



string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30;
            Encrypt =False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

using var conn = new SqlConnection(connectionString);
var regions = conn.Query<Region>("Select * from Region");
////var nowyRegion = new Region()
////{
////    RegionID = 9,
////    Descriptions = "TestRegion"

////};
////foreach (var item in regions)
////{
////    Console.WriteLine($"{item.RegionID}: {item.Descriptions}");
////}
//var inserResult = conn.Execute("INSERT INTO Region(RegionID , RegionDescription) VALUES (@RegionID , @RegionDescription)",
//    new
//    {
//        Id = 8.0,
//        Description = "testAnon"
//    } );

var JoinResult = conn.Query<Territories, Region, Territories>(
    "SELECT * FROM Territories t JOIN Region r ON t.RegionID = r.RegionID" +
    " Where TerritoryDescription like @i",
    (territories, region) =>
    {
        territories.Regions = region;
        return territories;
    }, new { i = "N%" }
    , splitOn: "RegionID"
    );

foreach (var item in JoinResult)
{
    Console.WriteLine($"{item.TerritoryDescription}:{item.Regions.RegionDescription}");
}







//var JoinResult = conn.Query<Product, Category, Product>(
//    "SELECT * FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID",
//    (product,category) =>
//    {
//        product.Category = category;
//        return product;
//    },splitOn:"CategoryID"
//    );
//foreach (var item in JoinResult)
//{
//    Console.WriteLine($"{item.ProductName}:{item.Category.CategoryName}");
//}