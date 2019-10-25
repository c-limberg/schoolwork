void namen() {

  char arr[200];

  gets(arr);

  int counter = 0;



  if (strchr(arr, '=') == NULL) {

    printf("Fehler. Kein Gleichheitszeichen gefunden.");

    exit(0);

  }



    char name[32], wert[128];



    for (int i = 0; arr[i]!='='; i++) {

      if (i > 31) {

        printf("Fehler. Name zu lang.");

        exit(0);

      } else {

            name[i] = arr[i];

            counter++;

      }

    }



    if (counter > 0) {

        if (strlen(strchr(arr, '=')) + 1 > 128) {

        printf("Fehler. Wert zu lang.");

        exit(0);

        }



        strcpy(wert, strchr(arr, '=') + 1);

        printf("Name: %s, Wert: %s", name, wert);

        } else {

      printf("Fehler. Kein Name eingegeben.");

    }

}

