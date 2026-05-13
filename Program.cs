class Program
{
    static void Main()
    {
        Banco miBanco = new Banco();
        int opcion = 0;

        do
        {
            Console.WriteLine("Simulador de Banco");
            Console.WriteLine("1. Registrar cliente");
            Console.WriteLine("2. Listar clientes");
            Console.WriteLine("3. Buscar cliente");
            Console.WriteLine("4. Agregar cliente a la cola de atención");
            Console.WriteLine("5. Atender siguiente cliente");
            Console.WriteLine("6. Realizar depósito");
            Console.WriteLine("7. Realizar retiro");
            Console.WriteLine("8. Consultar saldo");
            Console.WriteLine("9. Deshacer última transacción");
            Console.WriteLine("10. Mostrar cola de atención");
            Console.WriteLine("11. Mostrar total de clientes");
            Console.WriteLine("12. Mostrar total de dinero del banco");
            Console.WriteLine("13. Salir");
            Console.Write("Seleccione una opción: ");

            if(!int.TryParse(Console.ReadLine(), out opcion)) continue;

            switch (opcion)
            {
                case 1:
                Console.Write("Cédula: "); int ced = int.Parse(Console.ReadLine());
                Console.Write("Nombre: "); string nom = Console.ReadLine();
                Console.Write("Apellido: "); string ape = Console.ReadLine();
                Console.Write("Número de cuenta: "); int cta = int.Parse(Console.ReadLine());
                Console.Write("Saldo inicial: "); int saldo = int.Parse(Console.ReadLine());
                miBanco.Clientes.AgregarCliente(ced, nom, ape, cta, saldo);
                break;
                case 2:
                miBanco.Clientes.MostrarTodos();
                break;
                case 3:
                Console.Write("Ingrese cédula a buscar: ");
                NodoCliente c = miBanco.Clientes.BuscarClientePorCedula(int.Parse(Console.ReadLine()));
                if(c != null)
                    {
                        Console.WriteLine($"Encontrado: {c.Nombre} {c.Apellido}, Cuenta: {c.NumCuenta}");
                    }
                    else
                    {
                        Console.WriteLine("Cliente no encontrado");
                    }
                break;
                case 4:
                Console.Write("Ingrese cédula del cliente para encolar: ");
                miBanco.Clientes.Encolar(int.Parse(Console.ReadLine()));
                break;
                case 5:
                int cedulaAtendida = miBanco.Fila.Desencolar();
                if(cedulaAtendida != -1)
                    {
                        Console.WriteLine($"Atendido al cliente con cedula: {cedulaAtendida}");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en espera");
                    }
                    break;
                case 6:
                Console.Write("Numero de cuenta: "); int ctaDeposito = int.Parse(Console.ReadLine());
                Console.Write("Monto a depositar: "); int montoDeposito = int.Parse(Console.ReadLine());
                miBanco.RealizarDeposito(ctaDeposito, montoDeposito);
                break;
                case 7:
                Console.Write("Numero de cuenta: "); int ctaRetiro = int.Parse(Console.ReadLine());
                Console.Write("Monto a retirar: "); int montoRetiro = int.Parse(Console.ReadLine());
                miBanco.RealizarRetiro(ctaRetiro, montoRetiro);
                break;
                case 8:
                Console.Write("Numero de cuenta a consultar: ");
                NodoCliente clienteConsulta = miBanco.Clientes.BuscarClientePorCuenta(int.Parse(Console.ReadLine()));
                if(clienteConsulta != null)
                    {
                        Console.WriteLine($"Saldo dactual: {clienteConsulta.Saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Cuenta no encontrada");
                    }
                break;
                case 9:
                miBanco.DeshacerUltimaTransaccion();
                break;
                case 10:
                miBanco.Fila.MostrarCola();
                break;
                case 11:
                Console.WriteLine($"Total de clientes registrados: {miBanco.Clientes.ContarClientes()}");
                break;
                case 12:
                Console.WriteLine($"Total de dinero en el banco: {miBanco.Clientes.CalcularDineroTotal()}");
                break;
                case 13:
                Console.WriteLine("Saliendo del programa...");
                break;
                default:
                Console.WriteLine("Opción no válida, intente nuevamente.");
                break;
            }
        } while (opcion != 13);
    }
}