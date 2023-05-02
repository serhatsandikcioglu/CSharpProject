using Microsoft.VisualBasic;

Console.WriteLine("Cümle giriniz: ");
string input = Console.ReadLine();
string[] kelimeler = input.Split(' ');
string unsuz = "bcçdfgğhjklmnprsştvyz";
int ikili = 0;

foreach (var item in kelimeler)
{
    bool kontrol = false;

    for (int i = 0; i < item.Length - 1; i++)
    {
        if (unsuz.Contains(item[i]) && unsuz.Contains(item[i + 1]))
        {
            kontrol = true; break;
        }

    }
    Console.Write(kontrol + " ");
}