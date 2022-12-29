Random rnd = new Random();

int sayi = rnd.Next(100);

if (sayi % 2 == 0)
{

    System.Console.Write("{0} çift sayıdır", sayi);
}
else
{
    System.Console.WriteLine("{0} tek sayıdır", sayi);
}