package Java.Medium;

import java.io.*;
import java.util.*;

public class Array_Sum_Hours_Glass {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        List<List<Integer>> arr = new ArrayList<>();

        for (int i = 0; i < 6; i++) {
            String[] arrRowTempItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

            List<Integer> arrRowItems = new ArrayList<>();

            for (int j = 0; j < 6; j++) {
                int arrItem = Integer.parseInt(arrRowTempItems[j]);
                arrRowItems.add(arrItem);
            }

            arr.add(arrRowItems);
        }

        bufferedReader.close();

        // LOGIC CODE GOES HERE
        int larges = -100;
        int count_line = 0;
        List<Integer> line1 = new ArrayList<>();
        List<Integer> line2 = new ArrayList<>();
        List<Integer> line3 = new ArrayList<>();
        while (count_line < arr.size() - 2) {
            int j = count_line + 2;
            for (int i = count_line; i <= j; i++) {
                if (i == j - 2) {
                    GetSumLine(arr, i, line1);
                } else if (i == j - 1) {
                    for (int get_body = 1; get_body < arr.get(i).size() - 1; get_body++) {
                        line2.add(arr.get(i).get(get_body));
                    }
                } else {
                    GetSumLine(arr, i, line3);
                }
            }

            for (int op = 0; op < line1.size(); op++) {
                int max = line1.get(op) + line2.get(op) + line3.get(op);
                if (max > larges) {
                    larges = max;
                }
            }
            count_line++;
            line1.clear();
            line2.clear();
            line3.clear();
        }

        System.out.println(larges);

    }

    public static void GetSumLine(List<List<Integer>> arr, int count_line, List<Integer> line) {
        for (int newbie = 0; newbie < arr.get(count_line).size() - 2; newbie++) {
            line.add(arr.get(count_line).get(newbie) + arr.get(count_line).get(newbie + 1)
                    + arr.get(count_line).get(newbie + 2));
        }
    }
}
