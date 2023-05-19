string nombre = Console.ReadLine();
string apellido = Console.ReadLine();
int edad = Convert.ToInt32(Console.ReadLine());
bool sabeProgramar = Convert.ToBoolean(Console.ReadLine());

string mensaje = "Hola, mi nombre es " + nombre + " " + apellido + ". Tengo " + edad + " años.";
if (sabeProgramar)
{
    mensaje += " Sé programar.";
}
else
{
    mensaje += " No sé programar.";
}

Console.WriteLine(mensaje);