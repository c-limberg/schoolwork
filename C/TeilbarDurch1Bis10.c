void teilbar()
{
    int zahl = 10;
    int i;

    for(i=1;i<=10;i++){
            printf("Zahl ist jetzt: %i, Divisor ist jetzt: %i\n",zahl,i);
        if(zahl%i!=0){
            i=0;
            zahl++;
            printf("Nicht teilbar. Divisor wird wieder auf 1 gesetzt, Zahl wird um eins vergroessert.\n");
        }
    }

    printf("%i",zahl);
}
