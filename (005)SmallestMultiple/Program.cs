Console.Write("Kaça kadar olan sayıların en küçük ortak katını bulmak istiyorsunuz: ");
int k = Convert.ToInt32(Console.ReadLine());


long sonuc = 1;

for (int i = 1; i <= k; i++)
{
    sonuc = EKOK(sonuc, i);
}

Console.WriteLine(sonuc);



static long EBOB(long a, long b)
{   
    while (b != 0)
    {
        long temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static long EKOK(long a, long b)
{
    return a * b / EBOB(a, b);
}
