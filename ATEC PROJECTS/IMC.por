programa
{	
	inclua biblioteca Texto --> Txt
	inclua biblioteca Tipos --> Tp

	real peso, altura, imc
     cadeia pesoTxt, alturaTxt
     logico isOk = verdadeiro
	
	funcao inicio()
	{

		faca
		{
	     	escreva("Introduza o peso: ")
	     	leia(pesoTxt)
	     	se (Tp.cadeia_e_real(pesoTxt) ou Tp.cadeia_e_inteiro(pesoTxt, 10))
	     	{
	     		peso = Tp.cadeia_para_real(pesoTxt)
	     	}
			
		}enquanto(peso <= 0 e (Tp.cadeia_e_real(pesoTxt) == falso ou Tp.cadeia_e_inteiro(pesoTxt, 10)))
	
	     faca
		{
	     	escreva("Introduza a altura: ")
	     	leia(alturaTxt)
	     	se (Tp.cadeia_e_real(alturaTxt) ou Tp.cadeia_e_inteiro(alturaTxt, 10))
	     	{
	     		altura = Tp.cadeia_para_real(alturaTxt)
	     	}
			
		}enquanto(altura <= 0 e (Tp.cadeia_e_real(alturaTxt) == falso ou Tp.cadeia_e_inteiro(alturaTxt, 10)))
	
	     imc = peso/(altura*altura) 
	     IMCClassificacao()


	  }
	  funcao IMCClassificacao()
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
 * @POSICAO-CURSOR = 254; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {peso, 6, 6, 4};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */