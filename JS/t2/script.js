function escreverTexto() {
    var nameForm = document.getElementById("name").value
    var emailForm = document.getElementById("email").value
    var numForm = document.getElementById("num").value
    var cursoForm = document.getElementById("curso").value
    var classificForm = document.getElementById("classific").value
    document.getElementById("head1").textContent = `Nome: ${nameForm} | Email: ${emailForm} | Número de Aluno: ${numForm} | Curso: ${cursoForm} | Classificação: ${classificForm}`
}