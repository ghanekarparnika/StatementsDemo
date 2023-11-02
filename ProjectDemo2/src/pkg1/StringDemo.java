package pkg1;

public class StringDemo {
    public static void main(String[] args) {
        //getting memory in string constant pool
        String str1="Parni";
        String str2="Parni";
        //getting memory in heap area
        String str3= new String ("Parni");

        //equals checks content in the string
        System.out.println(str1.equals(str2));//true
        System.out.println(str2.equals(str3));//true
        //== operator checks reference
        System.out.println(str1 == str2);//true
        System.out.println(str1 == str3);//false
        System.out.println("============================");

        //array stores same type of datatypes
        //static in nature
        int [] arr={1,2,3};
        System.out.println(arr.length);
        arr[3]=10;
        System.out.println(arr.length);
        for(int value:arr)
        {
            System.out.println(value);
        }

    }



}
