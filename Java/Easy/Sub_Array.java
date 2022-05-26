package Java.Easy;

import java.io.*;
import java.util.*;

public class Sub_Array {
    public static void main(String[] args) throws IOException {
        /*
         * Enter your code here. Read input from STDIN. Print output to STDOUT. Your
         * class should be named Solution.
         */
        Scanner in = new Scanner(System.in);
        int test = in.nextInt();
        List<Integer> arr = new ArrayList<>();
        int count = 0;
        for (int i = 0; i < test; i++) {
            int a = in.nextInt();
            if (a < 0)
                count++;
            arr.add(a);
        }

        for (int i = 0; i < arr.size() - 1; i++) {
            int sum = arr.get(i);
            for (int j = i + 1; j < arr.size(); j++) {
                sum += arr.get(j);
                if (sum < 0) {
                    count++;
                }
            }
        }
        System.out.println(count);
    }
}
