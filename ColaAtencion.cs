public class ColaAtencion
{
    private NodoCola cabeza;
    private NodoCola cola;

    public void Encolar(int cedulaCliente)
    {
        NodoCola nuevo = new NodoCola(cedulaCliente);
        if(cola == null)
        {
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            cola.Siguiente = nuevo;
            cola = nuevo;
        }
        Console.WriteLine($"Cliente con cédula {cedulaCliente} ha sido encolado para atención.");
    }

    public int Desencolar()
    {
        if (EstaVacia())
        {
            return -1; // Indica que la cola está vacía
        }
        int cedula = cabeza.CedulaCliente;
        cabeza = cabeza.Siguiente;
        if(cabeza == null)
        {
            cola = null;
        }
        return cedula;
    }

    public void MostrarCola()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La cola de atención está vacía.");
            return;
        }
        NodoCola actual = cabeza;
        Console.WriteLine("Clientes en la cola de atención:");
        while (actual != null)
        {
            Console.WriteLine($"Cedula: {actual.CedulaCliente}");
            actual = actual.Siguiente;
        }
    }
    public bool EstaVacia()
    {
        return cabeza == null;
    }
}