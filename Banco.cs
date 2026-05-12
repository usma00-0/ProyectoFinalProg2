public class Banco
{
    public ListaEnlazadaClientes Clientes { get; private set; }=new ListaEnlazadaClientes();
    public ColaAtencion Fila { get; private set; }=new ColaAtencion();
    private PilaTransacciones Historial = new PilaTransacciones();

    public void RealizarDeposito(int numCuenta, int monto)
    {
        NodoCliente cliente = Clientes.BuscarClientePorCuenta(numCuenta);
        if(cliente != null)
        {
            cliente.Saldo += monto;
            Historial.Apilar(new Transaccion("Depósito", numCuenta, monto)); //Guaardar en pila
            Console.WriteLine($"Deposito exitoso. Nuevo saldo: {cliente.Saldo}");
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
        }
    }

    public void RealizarRetiro(int numCuenta, int monto)
    {
        NodoCliente cliente = Clientes.BuscarClientePorCuenta(numCuenta);
        if(cliente != null)
        {
            [cite_start]if(cliente.Saldo >= monto)//Verificar saldo
            {
                cliente.Saldo -= monto;
                Historial.Apilar(new Transaccion("Retiro", numCuenta, monto));//Guardar en pila
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${cliente.Saldo}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }
        else
        {
            Console.WriteLine("Número de cuenta no encontrado.");
        }
    }
    
    public void DeshacerUltimaTransaccion()
    {
        Transaccion ultima = Historial.Desapilar();
        if(ultima == null)
        {
            Console.WriteLine("No hay transacciones para deshacer.");
            return;
        }

        NodoCliente cliente = Clientes.BuscarClientePorCuenta(ultima.NumCuenta);
        if(cliente != null)
        {
            if(ultima.Tipo == "Deposito")
            {
                cliente.Saldo -= ultima.Monto; //Revertir depósito
                Console.WriteLine($"Se deshizo un deposito de ${ultima.Monto}");
            }else if(ultima.Tipo == "Retiro")
            {
                cliente.Saldo += ultima.Monto; //Revertir retiro
                Console.WriteLine($"Se deshizo un retiro de ${ultima.Monto}");
            }
        }
    }
}