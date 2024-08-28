#include "stdio.h"
#include "stdlib.h"
#include "conio.h"

float Imposto (float real_dinheiro_iof, float real_cartao_iof, float operacao_dinheiro, float operacao_cartao)
{
    //variaveis de imposto
    float imposto_dinheiro, imposto_cartao;

    //definição do imposto
    imposto_cartao = 0,6; imposto_cartao = 3,5;

    //calculo do imposto
    operacao_dinheiro = real_dinheiro_iof*imposto_dinheiro;
    operacao_cartao = real_cartao_iof*imposto_cartao;

    return 0;

}

int main () 
{
    //variaveis
    float qtde_dolar, cotacao;
    float real, iof_dinheiro, iof_cartao, real_dinheiro_iof, real_cartao_iof;
    float operacao_dinheiro, operacao_cartao;

    //definicao do iof
    iof_dinheiro = 0,011; iof_cartao = 0,053;

    //obter dolares e cotação
    printf("Digite a quantidade de dolares: "); scanf("%f", &qtde_dolar);
    printf("\nDigite a cotacao do dolar: "); scanf("%f", &cotacao);

    //calculos
    real = qtde_dolar * cotacao;
    real_dinheiro_iof = real + iof_dinheiro;
    real_cartao_iof = real + iof_cartao;

    Imposto(real_dinheiro_iof, real_cartao_iof, operacao_dinheiro, operacao_cartao);

    printf("\nOperacao em dinheiro: %.2f", operacao_dinheiro);
    printf("\nOperacao em cartao: %.2f", operacao_cartao);
    return 0;
}