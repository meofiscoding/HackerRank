#### Task ####
Given an integer, __n__, perform the following conditional actions:

* If __n__ is odd, print `Weird`
* If __n__ is even and in the inclusive range of __2__ to __5__, print `Not Weird`
* If __n__ is even and in the inclusive range of __6__ to __20__, print `Weird`
* If __n__ is even and greater than __20__, print `Not Weird`

#### Input Format ####

A single line containing a positive integer, __n__.

#### Constraints ####

* __1 <= n <= 100__

#### Output Format ####

Print `Weird` if the number is weird. Otherwise, print `Not Weird`.

#### Sample Input 0 ####

`3`

#### Sample Output 0 ####

`Weird` 

#### Explanation 0 ####
__n = 3__

 __n__ is odd and odd numbers are weird, so print `Weird.`

#### Sample Input 1 ####

`24`

#### Sample Output 1 ####

`Not Weird`

#### Explanation 1 ####
__n = 24__

__n > 20__ and __n__ is even, so it is not weird.