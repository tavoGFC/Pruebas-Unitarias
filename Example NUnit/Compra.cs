using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNUnit
{
    class Compra
    {

        //Descuento hacia un cliente del tipo estudiante, le reduce el costo en 15%.
        public void descuentosClientes(Cliente cliente, Ticket ticket)
        {
            if (cliente.tipoCliente.Equals("Estudiante") && ticket.estreno == false)
            {
                int descuento = ticket.costo * 15 / 100;
                ticket.costo = ticket.costo - descuento;
            }
        }
    
        // Verificación que si el cliente es menor y la película es para mayores de 18 no puede ingresar a verla.
        public bool restriccionPeliculas(Cliente cliente)
        {
            if (cliente.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }   
    }
}
