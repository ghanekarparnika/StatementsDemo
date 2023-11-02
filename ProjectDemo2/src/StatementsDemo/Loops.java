package StatementsDemo;

import java.util.Scanner;

public class Loops {
    public static void main(String[] args) {

        //for loop
        for (int i = 1; i <= 10; i++) {
            System.out.println(i);
        }
        System.out.println("========================================");
        //Nested for loop
        for (int i = 1; i <= 3; i++) {
            for (int j = 0; j < i; j++) {

                System.out.print(" *");
            }
            System.out.println();
        }

        System.out.println("========================================");

        //do-while
        int k=0;
        do {
            System.out.println("Good Morning");
            k++;
        }while (k<=6);

        System.out.println("========================================");

        //For-each
        String [] arr={"You","are","the","Winner"};
        for(String value:arr)
        {
            System.out.print(value+" ");
        }
        System.out.println();

        //while
       while (true) {
            System.out.println("========================================");
            System.out.println("Welcome to E-tour");
            System.out.println("Please choose your package:");
            System.out.println("1.Jammu Kashmir\n2.Manali\n3.Rajasthan\n4.Goa\n5.Booking\n6.Exit");
            Scanner sc = new Scanner(System.in);
            int choice = sc.nextInt();
            switch (choice) {
                case 1:
                    System.out.println("Place-JammuKashmir\nAmmount-25000");
                    break;
                case 2:
                    System.out.println("Place-Manali\nAmmount-25000");
                    break;
                case 3:
                    System.out.println("Place-Rajsthan\nAmmount-25000");
                    break;
                case 4:
                    System.out.println("Place-Goa\nAmmount-25000");
                    break;
                case 5:
                    System.out.println("Booked Successfully\nThank you...");
                    break;
                case 6:
                    System.out.println("Visit Again\nThank you");
                    System.exit(0);
                default:
                    System.out.println("invalid Input");

            }

        }




    }

}
