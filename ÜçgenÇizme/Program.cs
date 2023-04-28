Console.Write("Üçgenin boyutunu girin: ");
int size = int.Parse(Console.ReadLine());
for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}