Algoritmo "Exercicio3"

Var
Produtos_vendidos, Preco_unitario, Valor_compra, Desconto:Real
Pagamento, Pagamento_avista, Pagamento_parcelado:Real

Inicio

//Entradas
Escreval("Digite o número de produtos vendidos: ")
Leia(Produtos_vendidos) 
escreval(Produtos_vendidos, "produtos vendidos.")
Escreval("Digite o preço unitário de cada produto: ")
leia(Preco_unitario) 
escreval("R$", Preco_unitario, "Cada produto")
Escreval("Forma de pagamento: ")
Escreval("Digite '1' para pagamento á vista ou digite o número de parcelas: ")
leia(Pagamento)

//Processamento
Valor_compra <- (Preco_unitario*Produtos_vendidos)

se (Pagamento = 1) entao

    //Processamento_SE
    Desconto <- (Valor_compra*0.1)
    Pagamento_avista <- (Valor_compra-Desconto)

    //Saida_SE
    escreva("A compra de: R$", Valor_compra)
    escreva(" teve o desconto de R$", Desconto)
    escreva(", resultando no total de R$", Pagamento_avista, ", para ser pago á vista.")
senao

    //Processamento_SENAO
    Pagamento_parcelado <- (Valor_compra/Pagamento)

    //Saída_SENAO
    escreva("O total de R$", Valor_compra)
    escreva(", será parcelado em ", Pagamento)
    escreva(" parcelas de R$", Pagamento_parcelado, " cada.")

fimse

Fimalgoritmo