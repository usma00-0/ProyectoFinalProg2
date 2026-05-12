public class NodoPila
{
    public Transaccion Datos {get; set;}
    public NodoPila Siguiente { get; set;}

    public NodoPila(Transaccion datos)
    {
        Datos = datos;
        Siguiente = null;
    }
}