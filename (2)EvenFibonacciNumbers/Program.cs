Console.Write("Sınır giriniz: ");
int sinir = Convert.ToInt32(Console.ReadLine());

int toplam = 1;
int cikti = 0;


for (int i = 2; i < sinir; i+= toplam)
{
    Console.WriteLine("Birinci sayı:" + toplam +"  ||  "+ "İkinci sayı:" + i +"  ||  "+ "Çift sayılar toplamı:" + cikti);
    
    toplam += i;
    
    if (toplam % 2 == 0){
        cikti += toplam;
    }else if (i % 2 == 0)
    {
        cikti += i;
    }
}
Console.WriteLine("Çift sayılar toplamı: " +cikti);

// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89