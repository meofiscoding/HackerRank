package Java.Medium;

import java.io.*;
import java.util.*;
import java.util.stream.IntStream;
import java.util.stream.Stream;

import static java.util.stream.Collectors.toList;

public class Array_List_Problem {

    public static void main(String[] args) throws IOException {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        String[] firstMultipleInput = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
        int n = Integer.parseInt(firstMultipleInput[0]);
        List<List<Integer>> arr_list = new ArrayList<>();
        List<List<Integer>> queries = new ArrayList<>();
        IntStream.range(0, n).forEach(i -> {
            try {
                arr_list.add(
                        Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                                .map(Integer::parseInt)
                                .collect(toList())
                );

            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
            arr_list.get(i).remove(0);
        });
        String[] second = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
        int m = Integer.parseInt(second[0]);
        IntStream.range(0, m).forEach(i -> {
            try {
                queries.add(
                        Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
                                .map(Integer::parseInt)
                                .collect(toList())
                );

            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        });

        for(List<Integer> line: queries ){
            try{

                System.out.println(arr_list.get(line.get(0)-1).get(line.get(1)-1));

            }catch (Exception e){
                System.out.println("ERROR!");
            }
        }



    }
}
