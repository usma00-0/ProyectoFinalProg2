public class InfoBanco
{
    public void MostrarInformacion()
    {
        Console.WriteLine("Informacion General del Banco");
        Console.WriteLine($"Clientes registrados: {RegistroCliente()}");
        Console.WriteLine($"Dinero Total: {RegistroCuenta()}");
    }
public void MostrarClientes()
    {
        Console.WriteLine($"Clientes registrados: {RegistroCliente()}");
    }
}