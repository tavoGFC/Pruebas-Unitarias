var personas = ['Gustavo', 'Manuel'];

function verificar(opcion){
  var mensaje;
  opcion = prompt("Introduzca su nombre:", "");
  
  if (opcion == null || opcion == ""){
    mensaje = "Has cancelado o introducido el nombre vacío";
  } 
  else{
    if (personas.indexOf(opcion) >= 0){
      mensaje = "Bienbenido"
    }
    else{
      mensaje = "No se encuentra en nuestra base de datos";
    }
  }
  document.getElementById("TextView").innerHTML = mensaje;
}