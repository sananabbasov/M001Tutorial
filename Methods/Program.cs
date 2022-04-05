using Methods.Helper;

int km = 0;
int benzin = 100;
int kmlitr = 10;
// 100 (benzin) - 10 (km)
// 10(neceKm) - x

evvele:
Console.WriteLine("1. Herekete basla.");
Console.WriteLine("2. Benzin doldur.");
Console.WriteLine("3. Yurus.");
Console.WriteLine("4. Serfiyyat.");
Console.WriteLine("5. Cixis.");

var menuNumber = Console.ReadLine();

MoveCar moveCar = new();


switch (Convert.ToInt32(menuNumber))
{
    case 1:
        moveCar.HerekeBasla(km,benzin,kmlitr);
        goto evvele;
        break;
    case 2:
        Console.WriteLine("2 reqemini secdiniz.");
        goto evvele;
        break;
    case 3:
        Console.WriteLine("3 reqemini secdiniz.");
        goto evvele;
        break;
    case 4:
        Console.WriteLine("4 reqemini secdiniz.");
        goto evvele;
        break;
    case 5:
        Console.WriteLine("Cixis duymesine kliklediniz.");
        break;
    default:
        Console.WriteLine("Zehmet olmasa menudaki reqemlerin birini secin.");
        goto evvele;
        break;
}







//int Hesabla(int reqem1, int reqem2)
//{
//    Console.WriteLine(Hesabla(reqem1, reqem2));
//    return reqem1 + reqem2;
//}

//int a = 5;
//int b = 6;
//Hesabla(a, b);

//void Topla(int reqem1, int reqem2)
//{
//    Console.WriteLine(reqem1+reqem2);
//}


//Topla(5, 7);


//string SeoUrl(string url)
//{
//    var seo = url
//        .ToLower()
//        .Replace(' ', '-')
//        .Replace('ə', 'e')
//        .Replace('ü', 'u')
//        .Replace('ö', 'o')
//        .Replace('ı', 'i')
//        .Replace('ğ', 'g')
//        .Replace('ş', 's')
//        .Replace('ç', 'c')
//        .Replace('.', ' ');


//    return seo;
//}


//Console.WriteLine(SeoUrl("Azərbaycan dili geneoloji bölgüyə əsasən türk dillərinə mənsubdur."));