using OOP.Models;
using OOP.Services;

ProductManager productManager = new();

foreach (var product in productManager.Getall())
{
    Console.WriteLine(product.Id + ". " +product.Name);
}


Console.Write("Meqale id daxil edin: ");
var meqaleId =  Console.ReadLine();

var productDesc = productManager.GetById(Convert.ToInt32(meqaleId));
Console.WriteLine(productDesc.Name+"\n"+productDesc.Desc);
