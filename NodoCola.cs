public class NodoCola
{
    public int CedulaCliente {get; set;}
    public NodoCola Siguiente { get; set;}

    public NodoCola(int cedulaCliente)
    {
        CedulaCliente = cedulaCliente;
        Siguiente = null;
    }
}