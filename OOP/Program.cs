using OOP.Models;

Product product1 = new();

product1.Name = "iPhone 13 Pro 256GB Gold";
product1.Desc = "Cox bahali telefondu";
product1.Hit = 56;


Product product2 = new()
{
    Name = "Iphone X",
    Desc = "Kohne telefondu",
    Hit = 500
};


List<string> myList = new();

myList.Add(product1.Name);
myList.Add(product2.Name);


//Console.WriteLine(product1.Name +"\n"+ product2.Name);


foreach (var list in myList)
{
    Console.WriteLine(list);
}





var a = 5;
var b = 4;
var c = 3;
a = b;
c = a;




//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5, 6 };
//arr1[0] = 100; // 100, 2, 3 

//arr2 = arr1;


//for (int i = 0; i < arr2.Length; i++)
//{
//    Console.WriteLine(arr2[i]);

//}