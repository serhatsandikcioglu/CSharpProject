Console.WriteLine("Bir Cümle Giriniz: ");
string cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(' ');

for (int i = 0; i < kelimeler.Length; i++)
{
    char[] harfler = kelimeler[i].ToCharArray();
    Array.Reverse(harfler);
    kelimeler[i] = new string(harfler);
}

string tersCumle = string.Join(" ", kelimeler);
Console.WriteLine(tersCumle);