Console.WriteLine("Highest Divisible Triangular Number");


int n = 1;
int CokcaBolunenDeger = 0;

while (true)
{
    CokcaBolunenDeger = (n * (n + 1)) / 2;
    int bolensayisi = BolenSayisi(CokcaBolunenDeger);

    if (bolensayisi > 500)
    {
        Console.WriteLine(CokcaBolunenDeger);
        break;
    }

    n++;
}

static int BolenSayisi(int n)
{
    int sayac = 0;

    for (int i = 1; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            if (n / i == i)
                sayac++;
            else
                sayac += 2;
        }
    }

    return sayac;
}