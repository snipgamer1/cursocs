Console.Write("Ingresa Ancho: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa alto: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Relleno? (true/false): ");
bool fill = Convert.ToBoolean(Console.ReadLine());

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if (i == 1 || i == height || j == 1 || j == width || fill)
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