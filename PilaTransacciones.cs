public class PilaTransacciones
{
    private NodoPila tope;

    public void Apilar(Transaccion transaccion)
    {
        NodoPila nuevo = new NodoPila(transaccion);
        nuevo.Siguiente = tope;
        tope = nuevo;
        Console.WriteLine($"Transacción de {transaccion.Tipo} por {transaccion.Monto} ha sido apilada.");
    }

    public Transaccion Desapilar()
    {
        if (EstaVacia())
        {
            return null; // Indica que la pila está vacía
        }

        Transaccion transaccion = tope.Datos;
        tope = tope.Siguiente;
        return transaccion;
    }

    public bool EstaVacia()
    {
        return tope == null;
    }
}