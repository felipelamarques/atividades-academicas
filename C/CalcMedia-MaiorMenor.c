#include "stdio.h"
#include "stdlib.h"

int main()
{
//Nome do programa
printf("Calculo de medias v3.0\n\nCalculo de media com uma quantidade determinada de notas.\nExpecificando as maiores e menores notas\n\n\n");

//Variáveis
float NotaMaior, NotaMenor, NotaObtida, NotaFinal, Media;
int QtdeNotas, i;

i=1;

//Quantidade de notas
printf("Digite a quantidade de notas: "); scanf("%d", &QtdeNotas);

for (i; i<=QtdeNotas; i++)
{
    /* true */
    printf("\ni: %d e menor/igual QtdeNotas: %d", i, QtdeNotas);
}
    /* false */
    printf("\ni: %d e maior que QtdeNotas: %d", i, QtdeNotas);

    return 0;
}