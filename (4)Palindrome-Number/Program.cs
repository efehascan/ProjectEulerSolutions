Console.Write("Sınır sayısı girin: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Hangi sayıya kadar çarparak ilerlesin?");
Console.Write("A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("B: ");
int b = int.Parse(Console.ReadLine());

List<int> palindromlar = new List<int>();
List<int> palindromCarpmali = new List<int>();

for (int i = 1; i <= x; i++)
{
    if (i % 10 == 0 && i != 0)
    {
        // Bütün denenen değerleri görmek isterseniz aşağıdaki kodu etkinleştirin
        // if you want to see all of values, you must activate the code below
        // Console.WriteLine($"i: {i} - False"); 
        continue;
    }

    int number = 0;
    int gecicidegisken = i;

    while (gecicidegisken > 0)
    {
        number = number * 10 + gecicidegisken % 10;
        gecicidegisken /= 10;
    }
    if (number == i)
    {
        Console.WriteLine($"i: {i} - Palindrom");
        palindromlar.Add(i);
    }
}

for (int i = 0; i <= a; i++)
{
    for (int j = 0; j <= b; j++)
    {
        int carpim = i * j;
        if (kontrol(carpim))
        {
            Console.WriteLine($"Palindrom: {carpim} = {i} x {j}");
            palindromCarpmali.Add(carpim);
        }
    }
}

if (palindromCarpmali.Any())
{
    int palindromMax = palindromCarpmali.Max();
    Console.WriteLine($"En büyük Çarpmalı Palindrom: {palindromMax}");
}else{
    Console.WriteLine("Hiç çarpmalı palindrom bulunamadı.");
}

if (palindromlar.Any())
{
    int palindromMax = palindromlar.Max();
    Console.WriteLine($"En büyük Palindrom: {palindromMax}");
} else {
    Console.WriteLine("Hiç palindrom bulunamadı.");
}

bool kontrol(int sayi)
{
    int orjinal = sayi;
    int ters = 0;
    while (sayi > 0)
    {
        ters = ters * 10 + sayi % 10;
        sayi /= 10;
    }
    
    return orjinal == ters;
}