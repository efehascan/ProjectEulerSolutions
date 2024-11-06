Console.WriteLine("Summation of primes");
// a + b + c = 1000 --> c = 1000 - a - b 
// a < b < c 
//b'ye a + 1 değer vermemizin sebebi a'dan küçük olması

for (int a = 1; a <= 1000; a++)
{
    for (int b = a + 1; b <= 1000; b++)
    {
        int c = 1000 - a - b;
        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            Console.WriteLine("Çarpım: " + (a * b * c));
            return;
        }
    }
}