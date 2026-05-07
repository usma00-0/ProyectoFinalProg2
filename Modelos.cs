public class NodoCliente
{
    public int Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int NumCuenta { get; set; }
    public int Saldo { get; set; }

    public NodoCliente Siguiente { get; set; }
    public int Id { get; set; }

    public NodoCliente(int cedula, string nombre, string apellido, int numCuenta, int saldo)
    {
        Cedula = cedula;
        Nombre = nombre;
        Apellido = apellido;
        NumCuenta = numCuenta;
        Saldo = saldo;
        Siguiente = null;
    }
}

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

public class Transaccion
{
    public string Tipo { get; set;}
    public int NumCuenta { get; set;}
    public int Monto { get; set;}

    public Transaccion(string tipo, int numCuenta, int monto)
    {
        Tipo = tipo;
        NumCuenta = numCuenta;
        Monto = monto;
    }
}

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