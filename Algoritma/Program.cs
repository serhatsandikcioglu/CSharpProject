Console.WriteLine("Bir kelime ve bir sayı giriniz: ");
string input = Console.ReadLine();
string[] parts = input.Split(",");
string word = parts[0];
int number = int.Parse(parts[1]);
string newword = word.Remove(number, 1);
Console.WriteLine(newword);