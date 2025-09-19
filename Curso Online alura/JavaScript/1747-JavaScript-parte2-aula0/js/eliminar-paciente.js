var tabla = document.querySelector("#tabla-pacientes");

tabla.addEventListener("dblclick", function(event){
    
    event.target.parentNode.classList.add("fadeOut");
    setTimeout(function(){
        event.target.parentNode.remove();
    }, 500);
});





/*idea por terminar = editar el valor de una casilla
tabla.addEventListener("click", function(event){
    var cambio = prompt("Realize el cambio");
    event.target.innerHTML = cambio;
    
})
*/
