Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

* If a[i] > b[i], then Alice is awarded 1 point.
* If a[i] < b[i], then Bob is awarded 1 point.
* If a[i] = b[i], then neither person receives a point.
Comparison points is the total points a person earned.

Given a and b, determine their respective comparison points.

#### Example ####

a = [1, 2, 3]
b = [3, 2, 1]
* For elements *0*, Bob is awarded a point because a[0] .
* For the equal elements a[1] and b[1], no points are earned.
* *inally, for elements 2, a[2] > b[2] so Alice receives a point.
The return array is [1, 1] with Alice's score first and Bob's second.

#### Function Description ####

Complete the function compareTriplets in the editor below.

compareTriplets has the following parameter(s):

* int a[3]: Alice's challenge rating
* int b[3]: Bob's challenge rating

#### Return ####

* int[2]: Alice's score is in the first position, and Bob's score is in the second.

#### Input Format ####

The first line contains 3 space-separated integers, a[0], a[1], and a[2], the respective values in triplet a.
The second line contains 3 space-separated integers, b[0], b[1], and b[2], the respective values in triplet b.

#### Constraints ####

* 1 ≤ a[i] ≤ 100
* 1 ≤ b[i] ≤ 100

#### Sample Input 0 ####

` 
5 6 7
3 6 10 
`

#### Sample Output 0 ####

` 1 1`

__Explanation 0__

In this example:
* __a= (a[0], a[1], a[2]) = (5,6,7)__
* __b= (b[0], b[1], b[2]) = (3,6,10)__

Now, let's compare each individual score:

* __a[0]>b[0]__, so Alice receives __1__ point.
* __a[1]=b[1]__, so nobody receives a point.
* __a[2]< b[2]__, so Bob receives __1__ point.
Alice's comparison score is __1__, and Bob's comparison score is __1__. Thus, we return the array __[1,1]__.

#### Sample Input 1 ####

` 17 28 30
99 16 8 `

#### Sample Output 1 ####

`2 1`

#### Explanation 1 ####

Comparing the __0th__ elements, __17<99__ so Bob receives a point.
Comparing the __1st__ and __2nd__ elements,__30 > 8__  and __28>16__ so Alice receives two points.
The return array is __[2,1]__.