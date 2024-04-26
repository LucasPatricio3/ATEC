var count = 1;

function escreverTexto() {
    if(count % 2 != 0)
    {
        var texto = prompt("Digite o texto para o div esquerda:");
        document.getElementById("leftText").innerText += texto.toUpperCase() + "\n";
    }
    else 
    {
        var texto = prompt("Digite o texto para o div direita:");
        document.getElementById("rightText").innerText += texto.toUpperCase() + "\n";
    }
    count++;
}

function limparTextos() {
    document.getElementById("leftText").innerText = "";
    document.getElementById("rightText").innerText = "";
}