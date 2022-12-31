We define an employee's total earnings to be their monthly __salary x months__ worked, and the maximum total earnings to be the maximum total earnings for any employee in the __Employee__ table. Write a query to find the maximum total earnings for all employees as well as the total number of employees who have maximum total earnings. Then print these values as __2__ space-separated integers.

__Input Format__

The __Employee__ table containing employee data for a company is described as follows:

![](https://s3.amazonaws.com/hr-challenge-images/19629/1458557872-4396838885-ScreenShot2016-03-21at4.27.13PM.png)

where employee_id is an employee's ID number, name is their name, months is the total number of months they've been working for the company, and salary is the their monthly salary.

__Sample Input__

![](https://s3.amazonaws.com/hr-challenge-images/19631/1458559098-23bf583125-ScreenShot2016-03-21at4.32.59PM.png)

__Sample Output__

`69952 1`
__Explanation__

The table and earnings data is depicted in the following diagram: 
![](https://s3.amazonaws.com/hr-challenge-images/19631/1458559218-9f37585c7a-ScreenShot2016-03-21at4.49.23PM.png)

The maximum earnings value is __69952__. The only employee with earnings __= 69952__ is Kimberly, so we print the maximum earnings value (__69952__) and a count of the number of employees who have earned __$69952__ (which is __1__) as two space-separated values.