int[] sayilar = new int[6];
int[] kasaSayilar = new int[6];
int tahmin = 0;

Console.WriteLine("lütfen 6 adet 1 den 10 a kadar sayı giriniz sayı giriniz");
Random rnd = new Random();

for (int i = 0; i < 6; i++)
{
    kasaSayilar[i] = rnd.Next(10);
    System.Console.Write("{0} sayıyı giriniz :", (i + 1));
    sayilar[i] = int.Parse(Console.ReadLine()!);
}
foreach (var num in sayilar)
{
    foreach (var item in kasaSayilar)
    {
        tahmin = num == item ? tahmin++ : tahmin;
    }
}
Console.WriteLine("{0} Adet Doğru Tahminde Bulundunuz!", tahmin);
Console.WriteLine("Random sayılar :");
for (int i = 0; i < kasaSayilar.Length; i++)
{
    Console.WriteLine("{0}", kasaSayilar[i]);
}

