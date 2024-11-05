using System.Runtime.CompilerServices;

Console.Write("Kaçıncı asal sayıyı bulmak istediğinizi yazın: ");
long hedef = long.Parse(Console.ReadLine());

int sayac = 0;
long sayi = 1;

while (sayac < hedef)
{
    sayi++;
    if (isPrime(sayi))
    {
        sayac++;
    }
}

Console.WriteLine("10001. Asal sayı: " + sayi);
Console.WriteLine("Program finished");

bool isPrime(long kontrol)
{
    if (kontrol <= 1) return false;
    for (long i = 2; i <= Math.Sqrt(kontrol); i++)
    {
        if (kontrol % i == 0 )
        {
            return false;
        }
    }
    return true;
}
