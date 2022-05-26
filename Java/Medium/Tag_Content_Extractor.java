package Java.Medium;

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Tag_Content_Extractor {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int testCases = Integer.parseInt(in.nextLine());
        while (testCases > 0) {
            String line = in.nextLine();
            String regex = "(\\w*[^<>])|<\\/?(.*?)>";
            // Write your code here
            Pattern p = Pattern.compile(regex);
            Matcher m = p.matcher(line);
            List<String> arr = new ArrayList<>();
            String gr1 = "";
            while (m.find()) {
                String check_group0 = m.group(0).replaceAll(" ", "");
                if (check_group0.equals("<>") == false && check_group0.contains("/") == false
                        || check_group0.equals("</>") == false && check_group0.contains("/")) {
                    arr.add(m.group(0));
                }

                gr1 += m.group(1);
                gr1 = gr1.replaceAll("null", "");
                if (arr.size() > 0) {
                    if (gr1.equals("") == false && gr1.contains(arr.get(0))) {
                        arr.remove(0);
                    }
                }

            }
            String newline = "";
            boolean check = false;
            for (int i = 0; i < arr.size(); i++) {
                if (gr1.contains(arr.get(i))) {
                    for (int j = i + 1; j < arr.size(); j++) {
                        if (gr1.contains((arr.get(j))) == false) {
                            if (arr.get(i - 1).equals(arr.get(j).replace("/", "")) && arr.get(j).contains("/")) {
                                for (int newbie = i; newbie < j; newbie++) {
                                    if (newbie == (j - 1)) {
                                        newline += arr.get(i) + "\n";
                                    } else {
                                        newline += arr.get(i);
                                    }

                                    arr.remove(i);
                                    check = true;

                                }
                            } else {
                                i = j + 1;
                                continue;

                            }
                        }
                        if (check)
                            break;

                    }
                    check = false;

                }
            }
            // System.out.println(testCases);
            if (newline.equals("")) {
                System.out.println("None");
            }
            System.out.print(newline);
            // System.out.println(arr);
            testCases--;
        }

    }
}
