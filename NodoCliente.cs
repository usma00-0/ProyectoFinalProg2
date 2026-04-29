public class NodoCliente
{
    public int Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int NumCuenta { get; set; }
    public int Saldo { get; set; }

    public NodoCliente Siguiente { get; set; }

    
}