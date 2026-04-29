public class ColaAtencion
{
    private NodoCola frente;
    private NodoCola final;
    public void Encolar(string cliente)
    {
        NodoCola nuevo = new NodoCola(cliente);
        if (final == null)
        {
            frente = nuevo;
            final = nuevo;
        }
        else
        {
            final.Siguiente = nuevo;
            final = nuevo;
        }
        Console.WriteLine($"Cliente {cliente} ha sido agregado a la cola de atención.");
    }
    public int Desencolar()
    {
        if (EstaVacia())
        return -1;

        int cedula = frente.Cliente;
        frente = frente.Siguiente;
        if (frente == null)
        final = null;

        return cedula; 
    }
public int VerSiguiente()
    {
        if (EstaVacia())
        return -1;
        return frente.Cliente;
    }
public void MostrarCola()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La cola de atención está vacía.");
            return;
        }
        Console.WriteLine("Clientes en la cola de atención:");
        NodoCola actual = frente;
        while (actual != null)
        {
            Console.WriteLine($"Cliente: {actual.Cliente}");
            actual = actual.Siguiente;
        }
    }
public bool EstaVacia()
    {
        return frente == null;
    }

}
