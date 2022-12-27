Samantha was tasked with calculating the average monthly salaries for all employees in the __EMPLOYEES__ table, but did not realize her keyboard's __0__ key was broken until after completing the calculation. She wants your help finding the difference between her miscalculation (using salaries with any zeros removed), and the actual average salary.

Write a query calculating the amount of error (i.e.: __actual - miscalculated__ average monthly salaries), and round it up to the next integer.

#### Input Format#### 

The __EMPLOYEES__ table is described as follows:

![](https://s3.amazonaws.com/hr-challenge-images/12893/1443817108-adc2235c81-1.png)

__Note__: Salary is per month.

#### Constraints#### 

__1000 < Salary , 10^5__

#### Sample Input#### 

![](https://s3.amazonaws.com/hr-challenge-images/12893/1443817161-299cc6eb7f-2.png)

#### Sample Output#### 

`2061`
#### Explanation#### 

The table below shows the salaries without zeros as they were entered by Samantha:

![](https://s3.amazonaws.com/hr-challenge-images/12893/1443817229-eb00d44a3b-3.png)

Samantha computes an average salary of __98.00__. The actual average salary is __2159.00__.

The resulting error between the two calculations is __2159.00 - 98.00 = 2061.00__. Since it is equal to the integer __2061__, it does not get rounded up.

 
