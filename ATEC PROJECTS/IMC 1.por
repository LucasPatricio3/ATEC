programa
{
	
	funcao inicio()
	{
    real peso, altura, imc

    escreva("Introduza o peso: ")
    leia(peso)

    escreva("Introduza a altura(em metros): ")
    leia(altura)

    imc = peso/(altura*altura) 
    IMCClassificacao(24.9)


  }
  funcao IMCClassificacao(real imc)
  {
      //O switch-case do Portugol(escolha-caso) não suporta casos comparativos ex. imc < 18.5, então tive de criar esta atrocidade :(

      se (imc < 18.5) {escreva("Um IMC de " + imc + " é classificado como Magreza")}

      senao se (imc <= 24.9) {escreva("Um IMC de " + imc + " é classificado como Normal")}

      senao se (imc <= 29.9) {escreva("Um IMC de " + imc + " é classificado como Sobrepeso")}

      senao se (imc <= 34.9) {escreva("Um IMC de " + imc + " é classificado como Obesidade grau I")}

      senao se (imc <= 39.9) {escreva("Um IMC de " + imc + " é classificado como Obesidade grau II")}
      
      senao se (imc >= 40) {escreva("Um IMC de " + imc + " é classificado como Obesidade grau III")}
  }
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 207; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */