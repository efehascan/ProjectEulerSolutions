Console.WriteLine("Summation of primes");
long toplam = 0;

for (int i = 0; i < 2000000; i++)
{
    if (isPrime(i))
    {
        toplam += i;
    }
}
Console.WriteLine(toplam);


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
