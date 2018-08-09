function validarFormulario() {
    var textoCampoNome = document.getElementById("campo-nome").value;
    var textoCampoCPF = document.getElementById("campo-cpf").value;
    var tempoCampoSalario = document.getElementById("campo-salario")
    var textoCampoTempoEmpresa = documento.getElementById("campo-tempo-empresa").value;

    var quantidadeCaracterCampoNome = textoCampoNome.length;


    if (quantidadeCaracterCampoNome < 7 || quantidadeCaracterCampoNome > 100) {
        alert("Campo nome deve conter no minimo 7 caracteres e no maximo 100 caracteres");
    }

    var quantidadeCaracteresCampoCpf = textoCampoCPF.length;
    if (quantidadeCaracterCampoNome < 16) {
        alert("CPF deve conter 16 digitos")
    }

    var salario = parsetFloat(textoCampoSalario);
    if (salario < 1200) {
        alert("Salario deve ser maior que R$ 1.200,00 ");
    }
    else if (salario > 100000) {
        alert("Salario deve ser menor que R$ 100.000,00")
    }

}