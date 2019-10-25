void primzahl(){

    int counter = 0;



    for(int i=2;i<1000;i++){

        int teilbar = 0;

        for(int j=2;j<i;j++){

            if(i!=j&&i%j==0){

                teilbar=1;

            }

        }

        if(teilbar==0){

            counter++;

            printf("%i\n",i);

        }

    }



    printf("%i",counter);

}
