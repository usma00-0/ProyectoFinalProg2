public class RegistroClientes
{
    private NodoCliente cabeza;
    private int contadorClientes = 1;

    public void AgregarCliente(int cedula, string nombre, string apellido, int numCuenta, int saldo)
    {
        NodoCliente nuevoCliente = new NodoCliente(contadorClientes++,cedula, nombre, apellido, numCuenta, saldo);

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
        Console.WriteLine("Cliente agregado exitosamente. ID: " + nuevoCliente.Id);
    }
}