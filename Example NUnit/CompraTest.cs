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
    class CompraTest
    {
        [TestCase]
        public void When_DescuentoParaEstudiantes_Es_15()
        {
            // 1. Acomodo:

            //Se genera un tickete de prueba.
            Ticket ticketUno = new Ticket
            {
                nombrePelicula = "Las cronicas del relator",
                costo = 2500,
                estreno = false
            };

            //Se genera un cliente de prueba con datos aleatorios.
            Cliente clienteUno = new Cliente
            {
                nombreCompleto = "Juliana",
                edad = 19,
                tipoCliente = "Estudiante"
            };

            //Se genera un compra para ejecutar los metodos de clientes y ticketes.
            Compra compraUno = new Compra();

            //2. Acción: Al ser un estudiante tiene derecho a un descuento de 15%, por lo que deberia ser reducido el costo. 
            compraUno.descuentosClientes(clienteUno, ticketUno);

            //3. Aserción: Aca se compraba y se verifica que el precio tenga el descuento. 
            Assert.AreEqual(ticketUno.costo, 2125);
        }

        [TestCase]
        public void When_NombreComida_Es_Invalido()
        {
            //1. Acomodo

            //Se generan palomitas, que es una clase que hereda las propiedades de la clase comida.
            Palomitas palomitasSaladas = new Palomitas
            {
                costo = 700,
                nombre = "Palomitas Saladas $"
            };

            //2. Acción: Se ejecuta la funcion que busca si el nombre tiene caracteres de valor de moneda.
            var validacion = palomitasSaladas.contieneValoresErroneos();

            //3. Aserción: Aca se verifica que el sea cierto la busqueda de errores en el nombre. 
            Assert.IsTrue(validacion);

        }

        [TestCase(18)]
        [TestCase(28)]
        [TestCase(8, ExpectedResult = false)]
        [TestCase(Author = "Randy")]
        public void When_ClienteEsMayorDeEdad_Es_Cierto(int edades)
        {
            //1. Acomodo

            //Se genera un cliente de prueba, con la excepcion de que esta vez la edad tiene tres valors diferentes.
            Cliente clienteUno = new Cliente
            {
                nombreCompleto = "Valeska",
                edad = edades,
                tipoCliente = "Regular"
            };

            //Se genera un compra para ejecutar los metodos de clientes y ticketes.
            Compra compraUno = new Compra();

            //2. Acción: Se ejecuta la funcion que busca si el nombre tiene caracteres de valor de moneda.
            var validacion = compraUno.restriccionPeliculas(clienteUno);

            //3. Aserción: Aca se verifica que el sea cierto la busqueda de errores en el nombre. 
            Assert.IsTrue(validacion);

        }

    }   
}
