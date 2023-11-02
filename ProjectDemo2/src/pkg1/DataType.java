package pkg1;

public class DataType {
    public static void main(String[] args) {

        int a=1;
        System.out.println(a+" is of integer DataType");
        double d=2.0;
         System.out.println(d+" is of double DataType");
        char c ='s';
        System.out.println(c+" is of character DataType");
        float f=3.5F;
        System.out.println(f+" is of float DataType");
        long Temp=123445777L;
        System.out.println(Temp+" is of long DataType");
        boolean check=true;
        System.out.println(check+" is of boolean DataType");
        byte memory=127;
        System.out.println(memory+" is of byte DataType");
        System.out.println("=========================================");
        //declaration of an array
        int [] arr;
        arr=new int[3];
        arr[0]=1;
        arr[1]=2;
        arr[2]=3;
        //second way
       int [] arr1 =new int[4];
        arr1[0]=21;
        arr1[1]=22;
        arr1[2]=23;
        arr1[3]=24;
        //3rd way
        int [] arr2={1,2,3};

        String [] str={"ok","write","syntax"};

        //for loop
        for(int i=0;i<arr.length;i++)
        {
            System.out.println(arr[i]);
        }
        System.out.println("========================================");
        //for each
        for (int value:arr) {
            System.out.println(value);

        }
        for (String value:str) {
            System.out.print(value+" ");

        }

    }
}



