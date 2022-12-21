package Java.Easy.JavaSort;

import java.util.*;

class Student {
    private int id;
    private String fname;
    private double cgpa;

    public Student(int id, String fname, double cgpa) {
        super();
        this.id = id;
        this.fname = fname;
        this.cgpa = cgpa;
    }

    public int getId() {
        return id;
    }

    public String getFname() {
        return fname;
    }

    public double getCgpa() {
        return cgpa;
    }
}

//Complete the code
public class Solution {
    public static void main(String[] args) {
        int i = 2;
        int prime = 0;
        List<Integer> primes = new ArrayList<Integer>();
        while (i < 1000) {
            int j = i - 1;
            prime = 1;
            while (j > 1) {
                if (i % j == 0) {
                    prime = 0;
                    break;
                }
                j--;
            }
            if (prime == 1) {
                primes.add(i);
            }
            i++;
        }
    }
}



