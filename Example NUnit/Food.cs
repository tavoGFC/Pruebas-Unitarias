using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNUnit.Test
{
    public abstract class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }

        // Verifica que el nombre de la comida no tenga el símbolo de dolar.
        public bool VerifyChars()
        {
            if (this.Name.Contains("$"))
            {
                return true;
            }
            return false;
        }
    }
}
