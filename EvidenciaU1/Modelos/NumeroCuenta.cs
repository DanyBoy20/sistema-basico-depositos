using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaU1.Modelos
{
    // CLASE NUMERO DE CUENTA, NOS SERVIRA PARA LOS DATOS DE LAS CUENTAS: NOMBRE DE USUARIO, CUENTA, NIP, SALDO
    class NumeroCuenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Nip { get; set; }
        public int Cuenta { get; set; }
        public double SaldoActual { get; set; }
        public string NombreCompleto {
            get {
                return $"{Nombre}{Apellido}";
            }
        }

    }
}
