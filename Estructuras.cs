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

    public NodoCliente BuscarClientePorCedula(int cedula)
    {
        NodoCliente actual = cabeza;
        while(actual != null)
        {
            if(actual.Cedula == cedula) return actual;
            actual = actual.Siguiente;
        }
        return null;
    }

    public NodoCliente BuscarClientePorCuenta(int numCuenta)
    {
        NodoCliente actual = cabeza;
        while(actual != null)
        {
            if(actual.NumCuenta == numCuenta) return actual;
            actual = actual.Siguiente;
        }
        return null;
    }

    public void MostrarTodos()
    {
        NodoCliente actual = cabeza;
        if(actual == null) Console.WriteLine("No hay clientes registrados");
        while(actual != null)
        {
            Console.WriteLine($"Cédula: {actual.Cedula}, Nombre: {actual.Nombre} {actual.Apellido}, Cuenta: {actual.NumCuenta}, Saldo: {actual.Saldo}");
            actual = actual.Siguiente;
        }
    }
}