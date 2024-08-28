#include "stdio.h"
#include "stdlib.h"
#include "conio.h"
#include "time.h"
#include "locale.h"

//Estruturas
typedef struct 
{
    int Id, Nota;
    char Justificativa[255], Tema[255], Obra[255];
    time_t Data_Hora;
}Info_Avaliacao;

int main()
{
    Info_Avaliacao Info_Avaliacao;
    //code
    fprintf(arq_csv, "%d, %s, %s, %d, %s, %02d/%02d/%04d %02d:%02d:%02d", /*ID*/, /*Tema*/, /*Obra*/, /*Nota*/, /*Justificativa*/, /*Data e Hora*/info->tm_mday, info->tm_mon + 1, info->tm_year + 1900,
           info->tm_hour, info->tm_min, info->tm_sec);
    return 0;
}