using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNUnit
{
    class Cinema
    {

        //Descuento hacia un cliente del tipo estudiante, le reduce el costo en 15%.
        public void DiscountStudents(Client client, Ticket ticket)
        {
            if (client.Type.Equals("Student") && ticket.Date == false)
            {
                int discount = ticket.Price * 15 / 100;
                ticket.Price = ticket.Price - discount;
            }
        }
    
        // Verificación que si el cliente es menor y la película es para mayores de 18 no puede ingresar a verla.
        public bool AgeRestriction(Client client)
        {
            return client.Age >= 18;
           /*  if (client.Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }    */
        }   
    }
}
