Write a query identifying the type of each record in the __TRIANGLES__ table using its three side lengths. Output one of the following statements for each record in the table:

* __Equilateral__: It's a triangle with __3__ sides of equal length.
* __Isosceles__: It's a triangle with __2__ sides of equal length.
* __Scalene__: It's a triangle with __3__ sides of differing lengths.
* __Not A Triangle__: The given values of A, B, and C don't form a triangle.

#### Input Format #### 

The __TRIANGLES__ table is described as follows:

![](https://s3.amazonaws.com/hr-challenge-images/12887/1443815629-ac2a843fb7-1.png)

Each row in the table denotes the lengths of each of a triangle's three sides.

#### Sample Input #### 

![](https://s3.amazonaws.com/hr-challenge-images/12887/1443815827-cbfc1ca12b-2.png)

#### Sample Output #### 
`
Isosceles
Equilateral
Scalene
Not A Triangle
`
#### Explanation #### 

Values in the tuple __(20, 20, 23)__ form an Isosceles triangle, because __A == B__.
Values in the tuple __(20, 20, 20)__ form an Equilateral triangle, because __A == B == C__. Values in the tuple __(20, 21, 22)__ form a Scalene triangle, because __A != B != C__.
Values in the tuple __(13, 14, 30)__ cannot form a triangle because the combined value of sides __A__ and __B__ is not larger than that of side __C__.