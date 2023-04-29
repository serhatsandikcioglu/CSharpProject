Console.WriteLine("Sayıları giriniz: ");
string input = Console.ReadLine();
string[] stringsayilar = input.Split(" ");
List<int> sayilar = new List<int>();
double deger = 0;
for (int i = 0; i < stringsayilar.Length; i++)
{
    sayilar.Add(int.Parse(stringsayilar[i]));
}
for (int i = 0; i < sayilar.Count; i = i + 2)
{
    if (sayilar[i] == sayilar[i+1])
    {
        int toplam = sayilar[i] + sayilar[i + 1];
        deger = toplam * toplam;  
        Console.Write(deger + " ");
        deger = 0;
    }
    else
    {
        deger = sayilar[i] + sayilar[i + 1];
        Console.Write(deger + " ");
        deger = 0;
    }
    
}