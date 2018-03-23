class Persona{

  constructor(nombre, carnet){

    this.nombre = nombre;

    this.carnet = carnet;

  }



}



class Estudiante extends Persona{

  mostrarDatos(){

    return (this.nombre + ' - ' + this.carnet);

  }

  tipoPersona(){

    return (Estudiante.name);

  }

}



class Funcionario extends Persona{

  mostrarDatos(){

    return (this.nombre + ' - ' + this.carnet);

  }

  tipoPersona(){

    return (Funcionario.name);

  }

}



var p1 = new Estudiante('Gustavo', '2014035394');

var p2 = new Funcionario('Manuel', '20105245');





QUnit.test( "Prueba para Estudiante", function(assert){

  assert.equal(p2.tipoPersona(), "Estudiante", "Se espera que: " + p2.mostrarDatos() + " sea estudiante");

});





QUnit.test( "Prueba para Funcionario", function(assert){

  assert.equal(p2.tipoPersona(), "Funcionario", "Se espera que: " + p2.mostrarDatos() + " sea funcionario");

});
