package Java.Hard;

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Result {

    /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     * 1. INTEGER n
     * 2. 2D_INTEGER_ARRAY queries
     */

    public static long arrayManipulation(int n, List<List<Integer>> queries) {
        // Write your code here
        long[] array = new long[n + 1];
        int m = queries.size();
        while (m-- > 0) {
            array[queries.get(m).get(0) - 1] += queries.get(m).get(2);
            array[queries.get(m).get(1)] -= queries.get(m).get(2);
        }

        /* Find max value */
        long sum = 0;
        long max = 0;
        for (int i = 0; i < n; i++) {
            sum += array[i];
            max = Math.max(max, sum);
        }
        return max;
    }

}

public class Array_Manipulation {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        // BufferedWriter bufferedWriter = new BufferedWriter(new
        // FileWriter(System.getenv("OUTPUT_PATH")));

        String[] firstMultipleInput = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        int n = Integer.parseInt(firstMultipleInput[0]);

        int m = Integer.parseInt(firstMultipleInput[1]);

        List<List<Integer>> queries = new ArrayList<>();

        IntStream.range(0, m).forEach(i -> {
            try {
                queries.add(
                        Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                                .map(Integer::parseInt)
                                .collect(toList()));
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        long result = Result.arrayManipulation(n, queries);
        System.out.println(result);
        // bufferedWriter.write(String.valueOf(result));
        // bufferedWriter.newLine();

        bufferedReader.close();
        // bufferedWriter.close();
    }
}
