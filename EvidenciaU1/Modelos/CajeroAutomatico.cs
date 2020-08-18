using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaU1.Modelos
{
    // CLASE CAJERO AUTOMATIVO - AQUI DEFINIREMOS LOS METODOS PARA CREAR A LOS USUARIOS Y LAS ACCIONES
    //  DEL CAJERO AUTOMATICO: DEPOSITO
    class CajeroAutomatico
    {
        // creo una lista de tipo NumeroCuenta, que corresponde a la clase del mismo nombre
        public List<NumeroCuenta> Cuentas { get; set; }

        // el constructor 
        public CajeroAutomatico()
        {
            Cuentas = new List<NumeroCuenta>();
        }

        // metodo para crear nuevas cuentas
        public void NuevaCuenta()
        {
            // instancia (objeto) de la clase NumeroCuenta
            var cuenta = new NumeroCuenta();
            Console.Clear(); // me servira para limpiar pantalla
            Console.WriteLine("CREAR CUENTA BANCARIA"); // mensaje en pantalla
            Console.WriteLine("---------------------"); // es solo estetico, para darle una vista organizada, puede eliminarse sin repercutir en codigo
            Console.Write("Escribe su nombre: "); // mensaje pidiendo datos
            cuenta.Nombre = Console.ReadLine(); // capturo lo que el usuario escribe con teclado y lo asigno a variable Nombre
            Console.Write("Escribe tu apellido: "); // mensaje pidiendo datos
            cuenta.Apellido = Console.ReadLine(); // capturo lo que el usuario escribe con teclado y lo asigno a variable 
            Console.Write("Genere y escriba Nip: "); // mensaje pidiendo datos
            cuenta.Nip = int.Parse(Console.ReadLine()); // capturo lo que el usuario escribe con teclado y lo asigno a variable 
            cuenta.SaldoActual = 0.0; // asigno el saldo inicial
            cuenta.Id = Cuentas.Count + 1; // asigno un numero a la cuenta
            Cuentas.Add(cuenta); // añado toda la informacion a la lista
            Console.Clear(); // limpio pantalla
            Console.WriteLine("Cuenta creada, presione cualquier tecla para continuar"); // mensaje en pantalla
            Console.ReadKey(); // espero que el usuario presione una tecla, lo ocupo solo como una breve pausa y se pueda leer la pantalla
            Console.Clear();// limpio pantalla
        }

        // metodo para depositar
        public void Deposito()
        {
            Console.Clear(); // limpio pantalla
            Console.Write("Ingrese su numero de cuenta: "); // mensaje pidiendo datos
            // ** int.TryPArse es la mejor manera de validar y convertir un dato a otro tipo de dato en una sola linea
            // lo que hago aqui es leer/recibir lo que el usuario escribe con teclado y a su vez lo asigno (out)
            // a una variable (llamada "numeroCuenta" en este caso) del tipo que deseo convertir
            int.TryParse(Console.ReadLine(), out int numeroCuenta);
            // teniendo ya el valor que ingreso el usuario, lo que hago es una busqueda en mi lista llamada Cuentas
            // las listas tienen varios metodos de busqueda, entre ellos "FirstOrDefault" lo que hago con ese metodo es 
            // buscar el id de la variable cuentas y compararlo con numeroCuenta, si no lo encuentra dara nulo
            // si lo encuentra devolvera el valor encontrado
            var cuenta = Cuentas.FirstOrDefault(a => a.Id == numeroCuenta);
            // si la busqueda de la cuenta es diferente de null, es decir, encontro un valor y lo asigno a variable cuenta
            if (cuenta != null)
            {
                int nipo = cuenta.Nip; // si encontro el valor, el nip que corresponde al valor que devolvio lo asigno a una variable, en este caso el NIP
                Console.Write("Ingrese su Nip: "); // mensaje pidiendo datos
                // ** mismos comenatrios que linea 51
                int.TryParse(Console.ReadLine(), out int numeroNip);
                if (nipo == numeroNip) // si el nip es correcto
                {
                    Console.Write("Inserte la cantidad a depositar: "); // mensaje pidiendo datos
                    double.TryParse(Console.ReadLine(), out double saldo);
                    Console.WriteLine("--------------------"); // es solo estetico, para darle una vista organizada, puede eliminarse sin repercutir en codigo
                    Console.WriteLine("Saldo anterior: ${0}", cuenta.SaldoActual); // mensaje mostrando el saldo anterior
                    Console.WriteLine("Deposito: ${0}", saldo);// mensaje mostrando cuanto se deposito
                    cuenta.SaldoActual += saldo; // agrego al saldo actual lo que el usuario deposito
                    Console.WriteLine("saldo actual: ${0}", cuenta.SaldoActual);// mensaje mostrando el saldo actual
                    Console.WriteLine("--------------------"); // es solo estetico, para darle una vista organizada, puede eliminarse sin repercutir en codigo
                    Console.WriteLine(); // un espacio en blanco
                    Console.WriteLine("Presione una tecla para continuar"); // mensaje en pantalla
                    Console.ReadKey(); // espero que el usuario presione una tecla, lo ocupo solo como una breve pausa y se pueda leer la pantalla
                    Console.Clear(); // limpio pantalla
                }
                else
                {
                    Console.Clear(); // limpio pantalla
                    Console.WriteLine("Contraseña incorrecta, presione una tecla para continuar"); // mensaje de error
                    Console.ReadKey(); // espero que el usuario presione una tecla, lo ocupo solo como una breve pausa y se pueda leer la pantalla
                    Console.Clear(); // limpio pantalla
                }
            }
            else
            {
                Console.Clear(); // limpio pantalla
                Console.WriteLine("La cuenta ingresada no existe, presione una tecla para continuar"); // mensaje de error
                Console.ReadKey(); // espero que el usuario presione una tecla, lo ocupo solo como una breve pausa y se pueda leer la pantalla
                Console.Clear(); // limpio pantalla
            }
        }
    }
}
