using Ecommerce.Services;

ProductServices services = new();

Evvele:
Console.WriteLine("1. Ana Sehife");
Console.WriteLine("2. Mehsullar");


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
    default:
        break;
}




