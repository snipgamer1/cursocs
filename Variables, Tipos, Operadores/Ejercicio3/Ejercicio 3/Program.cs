int numero = 20;
char letra = 'a';


bool esMayorOIgualA18 = numero >= 18;
bool esA = letra == 'a';

bool ambasVerdaderas = esMayorOIgualA18 && esA;
bool unaVerdadera = esMayorOIgualA18 || esA;

Console.WriteLine("¿El número es mayor o igual a 18? " + esMayorOIgualA18);
Console.WriteLine("¿El char es 'a'? " + esA);
Console.WriteLine("¿Se cumplen dos condiciones a la vez? " + ambasVerdaderas);
Console.WriteLine("¿Se cumple una de dos condiciones a la vez? " + unaVerdadera);