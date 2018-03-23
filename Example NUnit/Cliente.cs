using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNUnit
{
   
    class Cliente
    {
        public string nombreCompleto { get; set; }
        public int edad { get; set; }
        public string tipoCliente { get; set; } //Clientes: estudiantes (15%) o regulares (0%).
    }
}
