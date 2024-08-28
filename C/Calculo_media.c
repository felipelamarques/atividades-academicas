#include <stdio.h>
#include <stdlib.h>

int main (void)
{
/*Cabeçalho*/ printf("Programa de calculos de media v2.0\n\n");
/*Variáveis números decimais*/ float Media, Nota1, Nota2, Nota_final, Proximo_passo; int Numero_Divisao;

/*Obter 1ª nota*/
    printf("Digite a primeira nota: ");
    scanf("%f", &Nota1);
    Nota_final=Nota1;
    Numero_Divisao=1;

/*Calculo da media*/ Media = Nota_final/Numero_Divisao;
    printf("          - Media: %.2f", Media);

/*Adicionar mais notas ou finalizar*/
    while (2)
        {
        printf("\n\nDigite a proxima nota ou digite '00' para finalizar: ");
        scanf("%f", &Nota2);
        Nota_final=(Nota_final+Nota2);
        Proximo_passo=Nota2; 
    
             if (Proximo_passo == 00)
            {
                /*Final do calculo de média*/
                printf("Media final: %.2f", Media);
                break;
            }
        Numero_Divisao++;
        Media = Nota_final/Numero_Divisao;
        printf("          - Media: %.2f", Media);
        }
    return 0;
}