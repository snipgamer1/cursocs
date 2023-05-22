int positiveCount = 0;
int negativeCount = 0;
int zeroCount = 0;
string input;

do
{
    Console.Write("Ingresa un numero (o 'q' para salir): ");
    input = Console.ReadLine();
    if (input != "q")
    {
        int num = Convert.ToInt32(input);
        if (num > 0)
        {
            positiveCount++;
        }
        else if (num < 0)
        {
            negativeCount++;
        }
        else
        {
            zeroCount++;
        }
    }
} while (input != "q");

Console.WriteLine("Positive count: {0}", positiveCount);
Console.WriteLine("Negative count: {0}", negativeCount);
Console.WriteLine("Zero count: {0}", zeroCount);