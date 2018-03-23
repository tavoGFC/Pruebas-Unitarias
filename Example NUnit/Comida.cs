using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNUnit.Test
{
    public abstract class Comida
    {
        public string nombre { get; set; }
        public int costo { get; set; }

        //Verifica que el nombre de la comida no tenga el simbolo de dolar aumentado
        public bool contieneValoresErroneos()
        {
            if (this.nombre.Contains("$"))
            {
                return true;
            }
            return false;
        }



    }
    
}
