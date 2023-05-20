Cliente cliente = new Cliente();
cliente.NombreCompleto = "Juan Pérez";
cliente.Telefono =5551234;
cliente.Direccion = "Calle 123";
cliente.Email = "juan.perez@example.com";
cliente.EsNuevoCliente = true;

cliente.PresentarDatos();

public struct Cliente
{
    public Cliente(string NombreCompleto1, int Telefono1, string Direccion1, string Email1, bool EsNuevoCliente1)
    {
        NombreCompleto = NombreCompleto1;
        Telefono = Telefono1;
        Direccion = Direccion1;
        Email = Email1;
        EsNuevoCliente = EsNuevoCliente1;
    }
    public string NombreCompleto { get; set; }
    public int Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool EsNuevoCliente { get; set; }

    public void PresentarDatos()
    {
        Console.WriteLine("Nombre completo: " + NombreCompleto);
        Console.WriteLine("Teléfono: " + Telefono);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("¿Es nuevo cliente?: " + EsNuevoCliente);
    }
}