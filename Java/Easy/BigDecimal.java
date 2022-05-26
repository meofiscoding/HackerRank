package Java.Easy;

import java.math.BigDecimal;
import java.util.*;

public class BigDecimal {
    public static void main(String[] args) {
        // Input
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String[] s = new String[n + 2];
        for (int i = 0; i < n; i++) {
            s[i] = sc.next();
        }
        sc.close();
        for (int i = 0; i < n; i++) {
            // Track number of elements swapped during a single array traversal

            for (int j = 0; j < n - 1; j++) {
                // Swap adjacent elements if they are in decreasing order
                BigDecimal a = new BigDecimal(s[j]);
                BigDecimal b = new BigDecimal(s[j + 1]);
                if (a.compareTo(b) < 0) {
                    String temp = s[j];
                    s[j] = s[j + 1];
                    s[j + 1] = temp;
                }
            }
        }

        // Output
        for (int i = 0; i < n; i++) {
            System.out.println(s[i]);
        }
    }
}
