var pacientes = document.querySelectorAll(".paciente");


for(var i = 0;i< pacientes.length;i++){
    var paciente = pacientes[i];

    var tdPeso = paciente.querySelector(".info-peso");
    var peso = tdPeso.textContent;

    var tdAltura = paciente.querySelector(".info-altura");
    var altura = tdAltura.textContent;

    var tdIMC = paciente.querySelector(".info-imc");


    pesoEsValido = validarPeso(peso);
    alturaEsValida = validarAltura(altura);

    if((!validarPeso)){
        console.log("Peso incorrecto");
        tdIMC.textContent = "Peso incorrecto";
        pesoEsValido = false;
        paciente.classList.add("paciente-incorrecto");
    }

    if((!validarAltura)){
        console.log("Altura incorrecta");
        tdIMC.textContent = "Altura incorrecta";
        alturaEsValida = false;
        paciente.classList.add("paciente-incorrecto");
    }

    if(pesoEsValido && alturaEsValida){
        tdIMC.textContent = calcularIMC(peso,altura);
    }

}


function calcularIMC(peso,altura){
    var imc = peso / (altura * altura);
    return imc.toFixed(2);
}

//validadores
function validarPeso(peso){
    if((peso > 0) && (peso < 600)){
        return true;
    }else{
            return false;
        }
}


function validarAltura(altura){
    if((altura >= 1) && (altura < 5)){
        return true;
    }else{
            return false;
        }
}
 


