using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework; //Usando NUnit.

namespace EjemploNUnit.Test
{
    /**
     * Notas:
     * 1. Uso del sistema AAA: Acomodo, Acción y Aserción. 
     * 2. Conveción de nombramiento de los casos de prueba:"When_StateUnderTest_Expect_ExpectedBehavior".
     * 3. TextFixture: Simboliza que esta clase es un clase especial para pruebas. 
     * 4. TestCase:  Simboliza que la siguiente función es un caso de prueba.
     * */

    [TestFixture]
    class CinemaTest
    {
        [TestCase]
        public void When_DiscountForStudents_Is_15()
        {
            // 1. Acomodo:

            //Se genera un tickete de prueba.
            Ticket ticketOne = new Ticket
            {
                NameMovie = "El bromas",
                Premiere = false,
                Price = 2500
            };

            //Se genera un cliente de prueba con datos aleatorios.
            Client clientOne = new Client
            {
                Name = "Juliana",
                Age = 19,
                Type = "Student"
            };

            //Se genera un 'cinema' para ejecutar los método de clientes y tiquetes.
            Cinema cinemaOne = new Cinema();

            //2. Acción: Al ser un estudiante tiene derecho a un descuento de 15%, por lo que debería ser reducido el costo. 
            cinemaOne.DiscountStudents(clientOne, ticketOne);

            //3. Aserción: Acá se compraba y se verifica que el precio tenga el descuento. 
            Assert.AreEqual(ticketOne.Price, 2125);
        }

        [TestCase]
        public void When_FoodName_Is_Invalid()
        {
            //1. Acomodo

            //Se generan palomitas, que es una clase que hereda las propiedades de la clase comida.
            Popcorn saladPopcorn = new Popcorn
            {
                Price = 700,
                Name = "Palomitas Saladas $"
            };

            //2. Acción: Se ejecuta la función que busca si el nombre tiene carácteres de valor de moneda.
            var validation = saladPopcorn.VerifyChars();

            //3. Aserción: Aca se verífica que el sea cierto la busqueda de errores en el nombre. 
            Assert.IsTrue(validation);

        }

        [TestCase(18)]
        [TestCase(28)]
        [TestCase(8, ExpectedResult = false)]
        [TestCase(Author = "Randy")]
        public void When_ClientIs18_Is_True(int Age)
        {
            //1. Acomodo

            //Se genera un cliente de prueba, con la excepción de que esta vez la edad tiene tres valores diferentes.
            Client clientOne = new Client
            {
                Name = "Maria",
                Age = 19,
                Type = "Student"
            };

            //Se genera un 'cinema' para ejecutar los metodos de clientes y tiquetes.
            Cinema cinemaOne = new Cinema();

            //2. Acción: Se ejecuta la función que busca si el nombre tiene carácteres de valor de moneda.
            var validation = cinemaOne.AgeRestriction(clientOne);

            //3. Aserción: Aca se verifica que el sea cierto la búsqueda de errores en el nombre. 
            Assert.IsTrue(validation);

        }

    }   
}
