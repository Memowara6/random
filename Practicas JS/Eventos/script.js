const cambiarColor = () =>{
    const h1Elemt = document.getElementsByTagName("h1")[0]
    h1Elemt.style.color = "red"
    alert("Se cambiara el titulo a color rojo al escuchar el evento onClick")
}

const crearMensaje = () =>{
    const newP = document.createElement("p")
    newP.innerHTML = "Creaste un nuevo mensaje"
    document.body.appendChild(newP)
}

const pintarRojo = () =>{
    const pCamaleon = document.querySelector(".camaleon")
    pCamaleon.style.color = "red"
}
const pintarAzul = () =>{
    const pCamaleon = document.querySelector(".camaleon")
    pCamaleon.style.color = "blue"
}
const pintarVerde = () =>{
    const pCamaleon = document.querySelector(".camaleon")
    pCamaleon.style.color = "green"
}

const aparecerTxt = () =>{
    const newP = document.createElement("p")
    newP.innerHTML = "APARECI!!!!"
    const cuadroAparecer = document.querySelector(".cuadroSpawn")
    cuadroAparecer.appendChild(newP)
}

const desaparecerTxt = () =>{
    const cuadroAparecer = document.querySelector(".cuadroSpawn")
    const p = document.querySelector(".cuadroSpawn p") 
    cuadroAparecer.removeChild(p)
}
