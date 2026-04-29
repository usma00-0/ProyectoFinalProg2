public class RegistroClientes
{
    private NodoCliente cabeza;

    public void AgregarCliente(int cedula, string nombre, string apellido, int numCuenta, int saldo)
    {
        NodoCliente nuevoCliente = new NodoCliente(cedula, nombre, apellido, numCuenta, saldo);

        if (cabeza == null)
        {
            cabeza = nuevoCliente;
        }
        else
        {
            NodoCliente actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoCliente;
        }
        Console.WriteLine("Cliente agregado exitosamente.");
    }
}