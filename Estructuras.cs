public class ListaEnlazadaClientes
{
    private NodoCliente cabeza;

    public bool AgregarCliente(int cedula, string nombre, string apellido, int numCuenta, int saldo)
    {
        [cite_start]//No permite duplicados
        if(BuscarClientePorCedula(cedula) != null || BuscarClientePorCuenta(numCuenta) != null)
        {
            Console.WriteLine("Ya existe un cliente con esa cédula o número de cuenta");
            return false;
        }

        NodoCliente nuevoCliente = new NodoCliente(cedula, nombre, apellido, numCuenta, saldo);

        if(cabeza == null)
        {
          cabeza = nuevoCliente;  
        }
        else
        {
            NodoCliente actual = cabeza;
            while(actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoCliente;
        }
        Console.WriteLine("Cliente agregado exitosamente");
        return true;
    }
}