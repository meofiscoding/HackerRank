import java.io.*;
import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.stream.Stream;

import static java.util.stream.Collectors.toList;

public class Solution {

    public static void main(String[] args) throws IOException{
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        String[] firstMultipleInput = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
        int n = Integer.parseInt(firstMultipleInput[0]);
        List<Integer> arr_list = new ArrayList<>();
        String[] arrRowTempItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
        IntStream.range(0, n).forEach(i -> {
            int arrItem = Integer.parseInt(arrRowTempItems[i]);
            arr_list.add(arrItem);
        });
        String[] number_of_queries = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
        int k = Integer.parseInt(number_of_queries[0]);
        for(int i=0;i<k;i++){
           String query= bufferedReader.readLine();
           if(query.equals("Insert")){
               String[] second_line = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");
               arr_list.add(Integer.parseInt(second_line[0]),Integer.parseInt(second_line[1]));
           }
           else {
               String second_line = bufferedReader.readLine();
               arr_list.remove(Integer.parseInt(second_line));
           }
        }
        bufferedReader.close();
        arr_list.forEach((index) -> System.out.print(index+" "));
    }
}
