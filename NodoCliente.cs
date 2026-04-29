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