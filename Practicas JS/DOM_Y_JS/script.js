document.body.children[0].innerText = "Prueba completada exitosamente"
document.querySelector("body > h1").innerText = "XD"

//Crear elemento desde JS
const txt = document.createElement("p")// Crear elemento p
txt.innerText = "Texto creado desde JS :DDD"// Anhadir un nodo de texto dentro del elemento
txt.id = "txt-js"// Agregar un id al elemento
txt.classList.add("txts-js")// Agregar una clase al elemento
document.body.appendChild(txt)// Agregar elemento creado desde JS a mi DOM


//Manejo de formularios
const myForm = document.querySelector("#formulario")
myForm.querySelector("#username").value