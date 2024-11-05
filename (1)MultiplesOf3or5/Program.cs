int toplam = 0;

Console.Write("Bir sayı girin: ");
int girdi = int.Parse(Console.ReadLine());

for (int i = 0; i < girdi; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        toplam += i;
    }
    
}
Console.WriteLine($"3 ve 5'in katları olan sayılar toplamı: {toplam}");
