void hundert(){

    int zahlen[100];

    char help[20];

    int counter=0,min,max; double avg = 0.0;



    for(int i=0;i<100;i++){

        gets(help);

        if(help[0]>='0'&&help[0]<='9'){

            zahlen[i]=atoi(help);

            counter++;

        }

        else {

            break;

        }

    }



    min = max = zahlen[0];



    for(int i=0;i<counter;i++){

        avg = avg+ zahlen[i];

        if(zahlen[i]<min)

            min = zahlen[i];

        if(zahlen[i]>max)

            max = zahlen[i];

    }



    avg = avg/counter;



    printf("Groesste Zahl: %i, Kleinste Zahl: %i, Durchschnitt: %.2f\n",max,min,avg);

}
