#include <stdio.h>
#include <stdlib.h>

void brettausgeben();
void ziehen();
int getspalte(char[]);
int getzeile(char[]);

char schachbrett[8][8] =
    {
        {'T','S','L','K','D','L','S','T'},
        {'B','B','B','B','B','B','B','B'},
        {' ',' ',' ',' ',' ',' ',' ',' '},
        {' ',' ',' ',' ',' ',' ',' ',' '},
        {' ',' ',' ',' ',' ',' ',' ',' '},
        {' ',' ',' ',' ',' ',' ',' ',' '},
        {'b','b','b','b','b','b','b','b'},
        {'t','s','l','k','d','l','s','t'}
    };

int main()
{
    brettausgeben();
    for(;;){
    ziehen();
    brettausgeben();
    }
}

void brettausgeben(){

    char bg = 219;
    char up = 196;

    printf("  H G F E D C B A\n  ________________\n");

    for(int i=0;i<8;i++){
            printf("%d|",i+1);
        for(int j=0;j<8;j++){
            printf("%c ",schachbrett[i][j]);
        }
        printf("|%d",i+1);
        printf("\n");
    }
    printf("  %c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c\n  H G F E D C B A\n",up,up,up,up,up,up,up,up,up,up,up,up,up,up,up,up,up);
}

void ziehen(){

    char fig;

    int vonSpalte = getspalte("Von");
    int vonZeile = getzeile("Von");
    int nachSpalte = getspalte("Nach");
    int nachZeile = getzeile("Nach");

    printf("Von: %d %d Nach %d %d\n",vonSpalte,vonZeile,nachSpalte,nachZeile);

    fig = schachbrett[vonZeile][vonSpalte];
    schachbrett[vonZeile][vonSpalte]=' ';
    schachbrett[nachZeile][nachSpalte]=fig;
}

int getspalte(char welche[]){

    char spalte[2];
    int ispalte;

    printf("%s Spalte: ",welche);
    gets(spalte);                       //gewuenschte spalte einlesen
    ispalte = abs(spalte[0]-'H');       //differenz zwischen H und erstem buchstaben der eingabe ermitteln (ascii werte)

    return ispalte;

}

int getzeile(char welche[]){

    char zeile[2];
    int izeile;

    printf("%s Zeile: ",welche);
    gets(zeile);
    izeile = abs(zeile[0]-'1');

    return izeile;
}
