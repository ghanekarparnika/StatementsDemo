package pkg1;

public class Patterns {
    public static void main(String[] args) {
        int[][] values = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        char [][] arr={{'x','o','x'},{'x','o','x'},{'x','o','x'}};
        /*for(int i = 0; i < values.length; i++) {
            for (int j = 0; j < values[i].length; j++) {
                System.out.print(values[i][j] + " ");
            }
            System.out.println();
        }*/
        for(int i=0;i<arr.length;i++)
        {
            for(int j=0;j<arr[i].length;j++)
            {
                System.out.print(arr[i][j]+" ");
            }
            System.out.println();
        }
    }
}
