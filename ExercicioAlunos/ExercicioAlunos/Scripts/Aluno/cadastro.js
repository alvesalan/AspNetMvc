function validarFormulario() {
    var textoCampoNome = document.getElementById("campo-nome").value;
    var textoCampoMatricula = document.getElementById("campo-matricula")
    /*var textoCampoNota1 = document.getElementById("campo-nota1")
    var textoCampoNota2 = document.getElementById("campo-nota2")
    var textoCampoNota3 = document.getElementById("campo-nota3")*/

    var quantidadeCaracterCampoNome = textoCampoNome.length;
    if (validarCampoNome() == false && validarCampoMatricula() == false) {
        event.preventDefault();
    }


}

function apagarElement(id) {
    if (document.contains(document.getElementById(id))) {
        document.getElementById(id).remove();
    }
}


function validarCampoNome() {
    var textoCampoNome = document.getElementById("campo-nome").value;
    document.getElementById("campo-nome").classList.remove("border-sucess");
    apagarElemento("span-campo-nome-menor-7");
    apagarElemento("span-campo-nome-maior-100");

    if (textoCampoNome.length < 7) {
        var elementoSpanNome = document.createElement("span");
        var texto = document.createTextNode("Nome deve conter no minimo 7 caracteres");
        elementoSpanNome.id = "span-campo-nome-menor-7";
        elementoSpanNome.classList.add("text-danger")
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoNome.length > 100) {
        var elementoSpanNome = document.createElement("span");
        elementoSpanNome.textContent = "Nome deve conter no maximo 100 caracteres";
        elementoSpanNome.classList.add("text-danger");
        elementoSpanNome.id = "span-campo-nome-maior-100";
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoNome.length >= 7 && textoCampoNome.length <= 100) {
        document.getElementById("campo-nome").classList.remove("border-danger");
        document.getElementById("campo-nome").classList.add("border-sucess");
        return true;
    }

}



function validarCampoMatricula() {

    var textoCampoMatricula = document.getElementById("campo-matricula").value;
    document.getElementById("campo-matricula").classList.remove("border-sucess");
    apagarElemento("span-campo-matricula-menor-1");
    apagarElemento("span-campo-matricula-maior-20");

    if (textoCampoMatricula.length < 1) {
        var elementoSpanMatricula = document.createElement("span");
        var texto = document.createTextNode("Matricula deve conter no minimo 1 caracteres");
        elementoSpanMatricula.id = "span-campo-matricula-menor-1";
        elementoSpanMatricula.classList.add("text-danger")
        document.getElementById("div-campo-matricula").appendChild(elementoSpanMatricula);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoMatricula.length > 20) {
            var elementoSpanMatricula = document.createElement("span");
        var texto = document.createTextNode("Matricula deve conter no maximo 20 caracteres");
        elementoSpanMatricula.id = "span-campo-matricula-menor-1";
        elementoSpanMatricula.classList.add("text-danger")
        document.getElementById("div-campo-matricula").appendChild(elementoSpanMatricula);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoMatricula.length >= 1 && textoCampoMatricula.length <= 20) {
        document.getElementById("campo-matricula").classList.remove("border-danger");
        document.getElementById("campo-matricula").classList.add("border-sucess");
        return true;
    }
}


function validarCampoNota1() {

}


function validarCampoNota2() {

}


function validarCampoNota3() {

}