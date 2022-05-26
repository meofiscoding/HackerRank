package Java.Easy;

import java.io.*;
import java.math.BigInteger;
import java.util.*;

public class Big_Integer {
    Scanner in = new Scanner(System.in);
    BigInteger a = new BigInteger(in.nextLine());
    BigInteger b = new BigInteger(in.nextLine());
    System.out.println(a.add(b));
    System.out.println(a.multiply(b));
}
