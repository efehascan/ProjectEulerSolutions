Console.WriteLine("Sum Square Difference");
Console.Write("Ilk kaç sayıyla işlemi yapmak istiyorsunuz: ");
int sumSquareDifference = int.Parse(Console.ReadLine());

double b = 0;
double a = 0;


for (int i = 1; i <= sumSquareDifference; i++)
{
    b += Math.Pow(i, 2);
}

for (int i = 1; i <= sumSquareDifference; i++)
{
    a += i;
}
a = Math.Pow(a, 2);

Console.WriteLine(a - b);