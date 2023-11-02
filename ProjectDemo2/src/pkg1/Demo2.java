package pkg1;

import java.util.Scanner;

public class Demo2 {
    public static void main(String[] args) {
        System.out.println("Its all about self study");
        System.out.println("Enter Any two integers:");
        Scanner sc= new Scanner(System.in);
        int num1=sc.nextInt();
        int num2=sc.nextInt();
        int result = num1+num2;
        System.out.println("Addition="+result);
        int result1=num1*num2;
        System.out.println("Multiplication="+result1);
        int result2=num1/num2;
        System.out.println("Division="+result2);
    }
}
