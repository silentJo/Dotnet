using LinQEntityFramework1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Security.Cryptography;
/*
Console.WriteLine("B1 - Lister tous les Customers habitants dans une ville saisie au clavier.");
Console.WriteLine("Entrez le nom d'une ville : ");
var city = Console.ReadLine();

using (NorthwindContext dc = new NorthwindContext())
{
IQueryable<Customer> custs = from c in dc.Customers 
where c.City == city
orderby c.CustomerId
select c;
foreach (Customer cust in custs)
{
Console.WriteLine("{0} - {1}", cust.CompanyName, cust.ContactName);
}
}
*/

/*
var cat1 = "Beverages";
var cat2 = "Condiments";
Console.WriteLine("B2 - Afficher les produits de la catégorie {0} et {1}. Utilisez le lazy loading  (pas d’include !), cat1, cat2);
using (NorthwindContext dc = new NorthwindContext())
{
    IQueryable<Product> cat1 = from p in dc.Products
                                where p.Category.CategoryName == cat1
                                select p;
    Console.WriteLine("Catégorie : {0}", cat1);
    foreach (Product p in cat1)
    {
        Console.WriteLine("{0}", p.ProductName);

    }
    IQueryable<Product> cat2 = from p in dc.Products
                               where p.Category.CategoryName == cat2
                               select p;
    Console.WriteLine("\nCatégorie : {0}", cat2);
    foreach (Product p in cat2)
    {
        Console.WriteLine("{0}", p.ProductName);
    }
}
*/

/*
var cat1 = "Beverages";
var cat2 = "Condiments";
Console.WriteLine("B3 - Afficher les produits de la catégorie {0} et {1}. Utilisez le eager loading ! ", cat1, cat2);
NorthwindContext context = new NorthwindContext();
IQueryable<Category> categories = from Category cat in context.Categories.Include("Products")
                                  where cat.CategoryName == cat1 || cat.CategoryName == cat2
                                  select cat;
foreach (Category cate in categories)
{
    Console.WriteLine("\n{0} :", cate.CategoryName);
    foreach (Product product in cate.Products)
    {
        Console.WriteLine("{0}", product.ProductName);
    }

}
*/

/*
Console.WriteLine("C1.1 - Mettez le nom de tous les clients en majuscule");
NorthwindContext context = new NorthwindContext();
var customers = context.Customers;
foreach (Customer customer in customers)
{
    customer.ContactName = customer.ContactName.ToUpper();
}
try
{
    context.SaveChanges();
} catch (Exception e)
{
    Console.WriteLine("Exceotion ORM : " + e);
}
Console.WriteLine("Done\n");
Console.WriteLine("C1.2 - Affichez le nom de tous les clients");
foreach (Customer customer in customers)
{
    Console.WriteLine("{0}", customer.ContactName);
}
*/

/*
Console.WriteLine("D1.1 - Ajoutez une catégorie à partir d’un nom saisi au clavier");
NorthwindContext context = new NorthwindContext();
Category cat = new Category();
Console.WriteLine("Entrez le nom de la catégorie : ");
cat.CategoryName = Console.ReadLine();
context.Categories.Add(cat);
context.SaveChanges();

Console.WriteLine("D1.2 - Vérifiez que l’ajout a bien été effectué en DB");
foreach(Category c in context.Categories)
{
    Console.WriteLine("{0}", c.CategoryName);
}
*/

Console.WriteLine("E1 - Supprimez la catégorie ajoutée à l'exercice précédent");
