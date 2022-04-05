string name = "Zulfu";
int cardNumber = 1234567890;
int password = 1234;
int balans = 40;



Console.Write("16 reqemli sifreni yazin: ");
var currentCard = Console.ReadLine();

Console.Write("Sifreni daxil edin: ");
var currentPas = Console.ReadLine();


if (cardNumber == Convert.ToInt32(currentCard) && password == Convert.ToInt32(currentPas))
{
    Console.WriteLine(name + "bey xos geldiniz");
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Balansiniz: " + balans + " AZN");
    Console.BackgroundColor = ConsoleColor.Black;
}
else
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("16 reqemli kod ve ya sifre yanlisdi.");
    Console.BackgroundColor = ConsoleColor.Black;
}