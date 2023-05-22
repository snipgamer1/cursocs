Console.Write("Ingresa el numero: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= 10)
{
    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
    i++;
}