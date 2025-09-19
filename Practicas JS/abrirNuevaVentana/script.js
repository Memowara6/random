const btnAbrir = document.getElementById("abrir")
const btnCerrar = document.getElementById("cerrar")

let ventana

btnAbrir.addEventListener("click", () =>{
    ventana = window.open("https://www.google.com/", "_blank", "width=500px, height=500px")
})

// No funciona - debe de estar desactualizado
btnCerrar.addEventListener("click", () =>{
    window.close()
})
