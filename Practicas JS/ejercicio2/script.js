
//Efecto de Blur
const imgSrc = document.querySelector(".poster").children[0].src
const blurBg = document.querySelector(".blur")
blurBg.style.backgroundImage = `url(${imgSrc})`


// Mostrar y esconder el menu lateral
const btnEsconder = document.getElementById("btn-esconder")
const sideBar = document.querySelector("#mainMenu")
btnEsconder.addEventListener("click", () =>{
    sideBar.classList.toggle("hide")
    
})