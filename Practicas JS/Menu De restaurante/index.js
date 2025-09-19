const usuario = {
    nombre: "Carlos",
    edad: 18,
    deuda: 0
}

let pedido = []
let costoPedido = 0
let ventas = 0

const showMenu = () => {
    console.log(`CODIGO - PRODUCTO - COSTO`)

    for(let producto of productos){
        console.log(`${producto.codigo}-${producto.nombre} - ${producto.precio}`)
    }
}
const verPedido = () => pedido
const verVentas = () => ventas


const pedirProducto = cod =>{
    if(!cod || typeof cod !== "string") return "Ingrese un codigo valido" //Si en la nomenclatura if solo se va a realizar un return  se puede usar asi
    const productoEncontrado = productos.find(producto => producto.codigo === cod)
    if(!productoEncontrado) return "El producto no existe"

    pedido.push(productoEncontrado)
    console.log("Su producto ha diso agregado correctamente. Su pedido es: ")
    return verPedido()
}


const calcularCosto = () =>{
    let costo = 0
    for(let producto of pedido){
        costo =+ producto.precio
    }
    costoPedido = costo
    return costoPedido
}

const finalizarPedido = () => {
    calcularCosto()
    usuario.deuda = costoPedido
    
    pedido = []
    costoPedido = 0
    ventas++;
    return `${usuario.nombre}, debes de pagar $${usuario.deuda}.`
}

const pagarDeuda = dineroCliente => {
    if(typeof dineroCliente === "number"){
        switch (true) {
        
            case dineroCliente < usuario.deuda:
                usuario.deuda -= dineroCliente
                console.log(`Todavia le falta por cancelar: $${usuario.deuda}`) 
                break
            case dineroCliente > usuario.deuda:
                let cambio = dineroCliente - usuario.deuda
                usuario.deuda = 0
                console.log(`Gracias por cancelar su compra. Su cambio es de ${cambio}`)
                break
            case dineroCliente === usuario.deuda:
                usuario.deuda = 0
                console.log("Gracias por cancelar su compra")
                break
        } 
    }else{
        return "Ingrese un monto valido"
    }
    
}

