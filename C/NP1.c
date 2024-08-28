#include "stdio.h"
#include "stdlib.h"
#include "conio.h"

int main(){
    //Variaveis
    int tipo_opr;
    float valor_opr, result;

    //Obter o valor da operação
    printf("Insira o valor da operacao...: ");
    scanf("%f", &valor_opr);

    //obter o tipo da operação
    printf("Escolha o tipo da opreração sendo 1 para Importacao e 2 para Exportacao...: ");
    scanf("%d", &tipo_opr);

    if(tipo_opr == 1){
        //Importação
        if(valor_opr <= 5000){
            result=valor_opr+(valor_opr*1);
            printf("Ate 5k = 100 porcento\n");
        } else {
            if(valor_opr >= 15000.01){
                result=valor_opr+(valor_opr*3);
                printf("mais de 15k = 300 porcento\n");
            } else {
                result=valor_opr+(valor_opr*2);
                printf("entre 5k e 15k = 200 porcento\n");
            }
        }
    } else {
        //Exportação
        if(valor_opr <= 10000){
            result=valor_opr+(valor_opr*1);
            printf("ate 10k = 100 porcento\n");
        } else {
            if(valor_opr >= 30000.01){
                result=valor_opr+(valor_opr*3);
                printf("mais de 30k = 300 porcento\n");
            } else {
                result=valor_opr+(valor_opr*2);
                printf("entre 11k e 30k = 200 porcento\n");
            }
        }
    }
    printf("Resultado da operacao: %.2f", result);

    return 0;
}