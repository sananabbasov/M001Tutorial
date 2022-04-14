// Task 1 :

//Console.Write("Reqem daxil edin: ");
//Evvele:
//int ededConvert = Convert.ToInt32(Console.ReadLine());


//if (ededConvert > 999 || ededConvert<100)
//{
//    Console.WriteLine("100 ile 999 arasinda bir reqem secin.");
//    goto Evvele;
//}

//int yuzluk = ededConvert / 100;
//int onluq = (ededConvert % 100) / 10;
//int teklik = (ededConvert % 100) % 10;



//Console.WriteLine(yuzluk+ " Yuzluk \n" + onluq +" onluq \n" + teklik + " teklik");


// Task 2 :

//Evvele:

//Console.Write("Reqem daxil edin: ");
//int ededConvert = Convert.ToInt32(Console.ReadLine());

//int chekNubmer = ededConvert % 2;


//if (chekNubmer == 0)
//{
//    Console.WriteLine("Bu eded sade eded deyil.");
//    goto Evvele;
//}

//int x = 0;

//while (x < 7)
//{
//    ededConvert++;

//    if (ededConvert % 2 != 0 && ededConvert % 3 != 0 && ededConvert % 5 != 0)
//    {
//        Console.WriteLine(ededConvert);
//        x++;
//    }

//}
//Console.WriteLine(ededConvert);


//Task 3 :


//Console.Write("Reqem daxil edin: ");
//int birinciEded = Convert.ToInt32(Console.ReadLine());
//int ikinciEded = Convert.ToInt32(Console.ReadLine());
//int ucuncuEded = Convert.ToInt32(Console.ReadLine());

//List<int> reqemler = new List<int>();

//Console.Write("Reqem daxil edin: ");

//for (int i = 0; i < 3; i++)
//{
//    int reqem = Convert.ToInt32(Console.ReadLine());
//    reqemler.Add(reqem);
//}

//int[] myArr = reqemler.ToArray();

//int enBoyuk = myArr.Max();
//int enKicik = myArr.Min();

//Console.WriteLine(enBoyuk + enKicik);


int[,] myMap =
    {
        { 1,0,1,0 },
        { 1,0,0,0 },
        { 0,1,0,0 },
        { 1,0,0,1 }
    };

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        var reqemler = myMap[i, j];
        Console.Write(reqemler);
    }
    Console.WriteLine();
}

//Console.WriteLine("0 0 0 0\n0 1 0 0\n0 0 0 1\n1 0 0 0");