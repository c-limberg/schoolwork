double turmhoehe(){

        double hoehe, schatten, winkel;



        printf("Wie lang ist der Schatten in Metern? ");

        scanf("%lf",&schatten);



        printf("Was ist der Winkel des Schattens in Grad? ");

        scanf("%lf",&winkel);



        winkel = winkel*(M_PI/180);

        hoehe = schatten*(tan(winkel));



        printf("Der Turm ist %.2f Meter hoch.",hoehe);

        return hoehe;

    }
