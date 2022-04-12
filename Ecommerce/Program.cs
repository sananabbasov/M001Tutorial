using Ecommerce.Models;
using Ecommerce.Services;



// CRUD


ProductServices services = new();

Evvele:
Console.WriteLine("1. Ana Sehife");
Console.WriteLine("2. Mehsullar");
Console.WriteLine("3. Mehsul elave et");
Console.WriteLine("4. Mehsulu sil");
Console.WriteLine("5. Mehsulu yenile");


var menu = Console.ReadLine();

switch (Convert.ToInt32(menu))
{
    case 1:



        Console.Clear();
        foreach (var product in services.GetHamisiGetir())
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("| " + product.Name + " | Baxis sayi: " + product.BaxisSayi + " |");
            Console.WriteLine("_________________________________________");
        }
        Console.WriteLine("Id daxil edin: ");
        var klikle = Console.ReadLine();



        var service = services.GetBiriniGetir(Convert.ToInt32(klikle));
        Console.WriteLine(service.Name + " " + service.OtaqSayi);


        goto Evvele;

        break;
    case 2:


        Console.WriteLine("Qiymet daxil edin: ");
        var filter = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(filter))
        {
            filter = "0";
        }


        foreach (var product in services.GetFilterEleGetir(Convert.ToInt32(filter)))
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("| " + product.Name + " | Qiymet: " + product.Price + " |");
            Console.WriteLine("_________________________________________");
        }


        goto Evvele;

        break;


    case 3:

        Console.Write("ID: ");
        var id = Console.ReadLine();
        Console.Write("Mehsul adi: ");
        var name = Console.ReadLine();
        Console.Write("Price: ");
        var price = Console.ReadLine();
        Console.Write("Sahe: ");
        var sahe = Console.ReadLine();
        Console.Write("Description: ");
        var description = Console.ReadLine();

        Product yeniMehsul = new()
        {
            Id = Convert.ToInt32(id),
            Name = name,
            Price = Convert.ToDecimal(price),
            Sahe = Convert.ToDecimal(sahe),
            BaxisSayi = 0,
            PublishDate = DateTime.Now, 
            UpdatedDate = DateTime.Now, 
            Description = description,
            Kupca = false,
            OtaqSayi = 0,
            Kateqoriya = "Villa"
            
            
        };

        services.AddProduct(yeniMehsul);
        goto Evvele;
        break;

    case 4:
        Console.Write("ID: ");
        var mehsulId = Console.ReadLine();

        services.RemoveProduct(Convert.ToInt32(mehsulId));
        Console.WriteLine("Mehsul ugurla silindi.");

        goto Evvele;

        break;
    case 5:
        Console.Write("ID: ");
        var updateId = Console.ReadLine();

        services.editProduct(Convert.ToInt32(updateId));
        Console.WriteLine("Mehsul ugurla yenilendi.");

        goto Evvele;

        break;
    default:
        break;
}




