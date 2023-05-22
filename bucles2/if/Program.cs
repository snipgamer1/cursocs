Console.Write("Introduce nombre: ");
string name = Console.ReadLine();
Console.Write("Introduce email: ");
string email = Console.ReadLine();
Console.Write("Introduce codigo del cupon (o 'none' si no tiene): ");
string coupon = Console.ReadLine();

double price = 100; // fixed price of product
double discount = 0;

if (coupon == "SAVE10")
{
    discount = 0.1;
}
else 
{
    discount = 0;
}

double finalPrice = price - (price * discount);
Console.WriteLine("Final price: {0}", finalPrice);
        