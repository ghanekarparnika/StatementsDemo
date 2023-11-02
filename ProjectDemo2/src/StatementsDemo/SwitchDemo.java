package StatementsDemo;

import java.util.Scanner;

public class SwitchDemo {
    public static void main(String[] args) {
        /*System.out.println("Please Enter your choice:");
        System.out.println("1.Java Tutorial\n2.DotNet Tutorial\n3.DataStructure Tutorial\n4.Python Tutorial\n5.Exit");
        Scanner sc= new Scanner(System.in);
        int choice= sc.nextInt();
        switch (choice)
        {
            case 1:
                System.out.println("Welcome to java tutorial");
                break;
            case 2:
                System.out.println("Welcome to DotNet tutorial");
                break;
            case 3:
                System.out.println("Welcome to DataStructure Tutorial");
                break;
            case 4:
                System.out.println("Welcome to python Tutorial");
                break;
            case 5:
                System.out.println("Thank you for visit");
                break;
            default:
                System.out.println("invalid Input");

        }*/


       /* System.out.println("Enter number between 1 t0 7");
        Scanner sc= new Scanner(System.in);
        int choice =sc.nextInt();
        switch (choice)
        {
            case 1:
                System.out.println("It is Sunday");
                break;
            case 2:
                System.out.println("It is Mon");
                break;
            case 3:
                System.out.println("It is Tue");
                break;
            case 4:
                System.out.println("It is wed");
                break;
            case 5:
                System.out.println("It is thus");
                break;
            case 6:
                System.out.println("It is fir");
                break;
            case 7:
                System.out.println("It is sat");
                break;

            default:
                System.out.println("invalid input");
        }*/

        System.out.println("Enter any number");
        Scanner sc= new Scanner(System.in);
        int num =sc.nextInt();
        if(num > 0)
        {
            System.out.println("number is positive");
            num=num+10;
            System.out.println("result:"+num);
        }else if(num<0)
        {
            System.out.println("num is negative");

        }else System.out.println("num is zero");
    }
}
