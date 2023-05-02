Console.WriteLine("Sayıları giriniz: ");
string[] sayilarSayilar = Console.ReadLine().Split(" ");
List<int> sayilar = new List<int>();
List<int> küçükSayilar = new List<int>();
List<int> büyükSayilar = new List<int>();
int küçükSonuc = 0;
int büyükSonuc = 0;
foreach (string item in sayilarSayilar)
{
    sayilar.Add(int.Parse(item));
}
foreach (var item in sayilar)
{
	if (item <= 67)
	{
		küçükSayilar.Add(item);
	}
	else if (item > 67)
	{
		büyükSayilar.Add(item);
	}
}
foreach (var item in küçükSayilar)
{
	küçükSonuc += 67 - item;
}
foreach (var item in büyükSayilar)
{
	büyükSonuc += (item - 67) * (item - 67);
}
Console.Write(küçükSonuc + " ");
Console.WriteLine(büyükSonuc);