public class ConsulClientes
{
    private NodoCliente cabeza;

    public void ConsultarCliente(int cedula)
    {
        NodoCliente actual = cabeza;
        while (actual != null)
        {
            if (actual.Cedula == cedula)
            {
                Console.WriteLine("Cliente encontrado:");
                Console.WriteLine("Cédula: " + actual.Cedula);
                Console.WriteLine("Nombre: " + actual.Nombre);
                Console.WriteLine("Apellido: " + actual.Apellido);
                Console.WriteLine("Número de Cuenta: " + actual.NumCuenta);
                Console.WriteLine("Saldo: " + actual.Saldo);
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Cliente no encontrado con cédula: " + cedula);
    }
}