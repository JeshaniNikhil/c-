public class Main {
    public static void main(String[] args) {
//      int a[]=new int[3];
//      a[0]=10;
//      a[1]=20;
//      a[2]=30;
//      for (int i=0;i<a.length;i++)
//      {
//          System.out.printf(String.valueOf(a[i]));
//      }
//         int b[][]=new int[2][2];
//                b[0][0]=10;
//                b[0][1]=20;
//                b[1][1]=30;
//                b[1][0]=40;
//                for (int i=0;i<b.length;i++)
//                {
//                    for (int j=0;j<b.length;j++)
//                    {
//                        System.out.println(b[i][j]);
//                    }
//                }
//        // jagged array
        int a[][] = new int[2][];
        a[0] = new int[2];
        a[1] = new int[2];
            int count=1;
        for (int i = 0; i < a.length; i++) {
            for (int j = 0; j < a[i].length; j++) {
                a[i][j] = count++;
            }
        }

        for (int i = 0; i < a.length; i++) {
            {
                for (int j = 0; j < a[i].length; j++) {
                    System.out.print(a[i][j] + " ");
                }
                System.out.println();
            }
        }
    }
}