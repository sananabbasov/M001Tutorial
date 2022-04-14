decimal gaz = 0.22M;
decimal limitQiymet = 0.25M;
decimal serfiyat = 5100;
decimal illikLimit = 5000;
decimal netice;


if (serfiyat > illikLimit)
{
    netice = (serfiyat - illikLimit) * limitQiymet + gaz * illikLimit;
    Console.WriteLine(netice);
}
else
{
    Console.WriteLine(gaz*serfiyat);
}


