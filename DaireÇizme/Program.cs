Console.Write("Dairenin yarıçapını girin: ");
int radius = int.Parse(Console.ReadLine());
for (int i = -radius; i <= radius; i++)
{
    for (int j = -radius; j <= radius; j++)
    {
        if (i * i + j * j <= radius * radius)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}