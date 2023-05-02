Console.WriteLine("Cümle giriniz: ");
string input = Console.ReadLine();
string[] kelimeler = input.Split(' ');
for (int i = 0; i < kelimeler.Length; i++)
{
    char[] chars = kelimeler[i].ToCharArray();
    Array.Reverse(chars);
    kelimeler[i] = new string(chars);
}
Console.WriteLine(string.Join(" ", kelimeler));