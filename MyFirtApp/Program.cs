int a = 9;
decimal b = 4.5M;
double c = 5.6;
string d = "Salam";
bool e = false;
var f = "Type";
var cem = a + b;


int[] myArr = { 1, 2, 3 };
string[] users = { "Zulfu", "Ruslan", "Sekine", "Ayxan", "Tofiq" };

//string[,] twoArray = {
//    { "Zulfu", "Abiyev" },
//    { "Ruslan","Quliyev" }
//};
//Console.WriteLine(twoArray[0,0] +" " + twoArray[0, 1]);

//for (int i = 0; i < users.Length; i++)
//{
//    Console.WriteLine(users[i]);
//}

int number = 0;

//while (number < 9)
//{
//    Console.WriteLine(number);
//    number++;
//}



bool isDelete = true;

//if (!isDelete)
//{
//    Console.WriteLine("Silinib.");
//}
//else if (!isDelete != false && false != true)
//{
//    Console.WriteLine("Bexte bext.");
//}
//else
//{
//    Console.WriteLine("Silinmeyib.");
//}

string currentEmail = "sanan@compar.az";
string currentPassword = "123456";

Console.Write("Emaili yazin: ");
string email = Console.ReadLine();

Console.Write("Sifreni yazin: ");
string pasword = Console.ReadLine();


if (email == currentEmail && pasword == currentPassword)
{
    Console.WriteLine("Xos geldiniz " + currentEmail);
}
else
{
    if (pasword != currentPassword)
    {
        Console.WriteLine("Sifre sehfi");
    }
    else if (email != currentEmail)
    {
        Console.WriteLine("Email sehdi");
    }
}

// CTRL + K + C , CTRL + K + U, CTRL + K + D, CTRL + Shift + B - Build

