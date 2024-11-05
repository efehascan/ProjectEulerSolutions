Console.Write("Asal çarpanlarını bulmak istediğiniz sayıyı giriniz: ");
long hedef = long.Parse(Console.ReadLine());

long ekle = 0;

for (long i = 2; i < hedef; i++)
{

    if (hedef % i == 0 && isPrime(i))
    {
            ekle += i;
            Console.WriteLine(i);
    }
}

Console.WriteLine("Program finished");

bool isPrime(long kontrol)
{
    bool asal = true;
    for (long i = 2; i < kontrol; i++)
    {
        if (kontrol % i == 0 )
        {
            asal = false;
            break;
        }
    }
    return asal;
}