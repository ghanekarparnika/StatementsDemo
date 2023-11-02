package StatementsDemo;

public class Conditional {
    public static void main(String[] args) {
        //if statement
        int age=26;
        if(age>=18)
        {
            System.out.println("Starting voting process...");
        }
        System.out.println("===============================================");
        //if-else statement
        String username="Parnika";
        String password="parni#123";
        if(username=="Parnika" && password=="parni#23")
        {
            System.out.println("Welcome back Parnika");
        }
        else
            System.out.println("Invalid username or password");

        System.out.println("===============================================");
        //if-else-if
        int marks=98;
        if(marks<35)
        {
            System.out.println("Fail");
        } else if (marks>=35&&marks<50) {
            System.out.println("Pass");
        }else if (marks>=50&&marks<60) {
            System.out.println("Second Class");
        }else if (marks>=60&&marks<80) {
            System.out.println("First class");
        }else if (marks>=90) {
            System.out.println("First class with distinction");
        }
    }

}
