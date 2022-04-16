using SearchEngine.Services;

ServiceSearch serviceSearch= new();

Console.WriteLine("axtaris sozunu daxil edin");

var words=Console.ReadLine();

foreach (var word in serviceSearch.Searching(words))
{
    Console.WriteLine(word.Title+" "+word.Desc);
    Console.WriteLine("______________________");
}
