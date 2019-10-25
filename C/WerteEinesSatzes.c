void textval(){
    char *text; int i;

    printf("Gebe einen Satz ein.\n");
    scanf("%[^.!?]*c",text);

    printf("\tZeichen\tDezimal\tHexadezimal\tOktal\n\t-------------------------------------\n");

    for(i=0;i<strlen(text);i++){
        if(text[i]!='\n')
        printf("%i.\t%c\t%d\t%x\t\t%o\n",i+1,text[i],text[i],text[i],text[i]);
    }
}
