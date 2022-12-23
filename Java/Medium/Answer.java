package com.company;

import java.util.*;

public class Solution {

    public static boolean canWin(int leap, int[] game) {
        // Return true if you can win the game; otherwise, return false.
        List<Integer> entry = new ArrayList<>();
        List<Integer> check = new ArrayList<>();
        int i = 0;
        while (i < game.length - 1) {
            if (!entry.contains(i)) {
                entry.add(i);
            }

            if (game[i + 1] == 0 && !check.contains(i + 1)) {
                i = i + 1;
                continue;
            }
            if (i + leap > game.length - 1 || game[i + leap] == 0 && !check.contains(i + leap)) {
                i = i + leap;
            } else {
                check.add(0, (entry.get(entry.size() - 1)));
                entry.remove(entry.size() - 1);
                if (entry.size() == 0) {
                    return false;
                }
                while (i > 0) {
                    if (game[i - 1] == 0) {
                        i = i - 1;
                        if (game[i + leap] != 0 && !check.contains(i + leap)) {
                            if (entry.contains(i)) {
                                check.add(0, (entry.get(entry.size() - 1)));
                                entry.remove(entry.size() - 1);
                            }
                            if (entry.size() == 0) {
                                return false;
                            }

                        } else if (check.contains(i + leap)) {
                            check.add(0, (entry.get(entry.size() - 1)));
                            entry.remove(entry.size() - 1);
                        } else if (game[i + leap] == 0) {
                            i += leap;
                            break;
                        }
                        if (entry.size() == 0) {
                            return false;
                        }

                    } else {
                        check.add(0, (entry.get(entry.size() - 1)));
                        entry.remove(entry.size() - 1);
                        if (entry.size() == 0) {
                            return false;
                        }
                        i = entry.get(entry.size() - 1);

                        break;
                    }
                }
            }
        }
        return true;
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int q = scan.nextInt();
        while (q-- > 0) {
            //check if q is at 2531 index
            if (q == 4999- 2531){
            int n = scan.nextInt();
            int leap = scan.nextInt();

            int[] game = new int[n];
            for (int i = 0; i < n; i++) {
                game[i] = scan.nextInt();
            }

            System.out.println((canWin(leap, game)) ? "YES" : "NO");
            }


        }
        scan.close();
    }
}
