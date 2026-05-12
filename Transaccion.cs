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