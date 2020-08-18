using EvidenciaU1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaU1
{
    // clase principal
    class Program
    {
        // metodo principal desde donde inicia la ejecucion del programa
        static void Main(string[] args)
        {
            // instancia (objeto) de la clase CajeroAutomatico
            var cajero = new CajeroAutomatico();
            bool seguir = true; // variable boleana para determinar si el programa sigue ejecutandose
            while (seguir) // si la variable SEGUIR es verdadera en su valor
            {
                Console.WriteLine("CAJEROS AUTOMATICOS DHP");   // mensaje de titulo             
                Console.WriteLine("--------Menu-----------"); // mensaje
                Console.WriteLine("1- Crear nueva cuenta"); // mensaje
                Console.WriteLine("2- Depositar"); // mensaje
                Console.WriteLine("3- Salir"); // mensaje
                Console.WriteLine("-----------------------"); // es solo estetico, para darle una vista organizada, puede eliminarse sin repercutir en codigo
                Console.WriteLine("----Elija una opcion----"); // mensaje
                // ** int.TryPArse es la mejor manera de validar y convertir un dato a otro tipo de dato en una sola linea
                // lo que hago aqui es leer/recibir lo que el usuario escribe con teclado y a su vez lo asigno (out)
                // a una variable (llamada "opt" en este caso) del tipo que deseo convertir
                var opcion = int.TryParse(Console.ReadLine(), out int opt);
                switch (opt) // la variable que va a ser revisada segun su valor
                {
                    case 1: // si la variable vale 1
                        cajero.NuevaCuenta(); // ejecuta el metodo Nuevacuenta del objeto cajero
                        break;
                    case 2: // si la variable vale 1
                        cajero.Deposito(); // ejecuta el metodo Deposito del objeto cajero
                        break;
                    case 3: // si la variable vale 1
                        seguir = false; // cambio el valor de la variable para salir del programa
                        break;
                }
            }
        }
    }
}
