Julia conducted a __15__ days of learning SQL contest. The start date of the contest was March 01, 2016 and the end date was March 15, 2016.

Write a query to print total number of unique hackers who made at least __1__ submission each day (starting on the first day of the contest), and find the hacker_id and name of the hacker who made maximum number of submissions each day. If more than one such hacker has a maximum number of submissions, print the lowest hacker_id. The query should print this information for each day of the contest, sorted by the date.
---
__Input Format__

The following tables hold contest data:

* Hackers: The hacker_id is the id of the hacker, and name is the name of the hacker.
![](https://s3.amazonaws.com/hr-challenge-images/19597/1458511164-12adec3b8b-ScreenShot2016-03-21at3.26.47AM.png)

* Submissions: The submission_date is the date of the submission, submission_id is the id of the submission, hacker_id is the id of the hacker who made the submission, and score is the score of the submission. 

![](https://s3.amazonaws.com/hr-challenge-images/19597/1458511251-0b534030b9-ScreenShot2016-03-21at3.26.56AM.png)

__Sample Input__

For the following sample input, assume that the end date of the contest was March 06, 2016.

Hackers Table: 
![](https://s3.amazonaws.com/hr-challenge-images/19597/1458511957-814a2c7bf2-ScreenShot2016-03-21at3.27.06AM.png)

 Submissions Table: 
 ![](https://s3.amazonaws.com/hr-challenge-images/19597/1458512015-ff6a708164-ScreenShot2016-03-21at3.27.21AM.png)

__Sample Output__
`
2016-03-01 4 20703 Angela
2016-03-02 2 79722 Michael
2016-03-03 2 20703 Angela
2016-03-04 2 20703 Angela
2016-03-05 1 36396 Frank
2016-03-06 1 20703 Angela
`

__Explanation__

On March 01, 2016 hackers __20703__, __36396__, __53473__, and __79722__ made submissions. There are __4__ unique hackers who made at least one submission each day. As each hacker made one submission, __20703__ is considered to be the hacker who made maximum number of submissions on this day. The name of the hacker is Angela.

On March 02, 2016 hackers __15758__, __20703__, and __79722__ made submissions. Now __20703__, and __79722__ were the only ones to submit every day, so there are __2__ unique hackers who made at least one submission each day.__79722__ made __2__ submissions, and name of the hacker is Michael.

On March 03, 2016 hackers __20703__,__36396__, and __79722__ made submissions. Now __20703__ and __79722__ were the only ones, so there are __2__ unique hackers who made at least one submission each day. As each hacker made one submission so __20703__ is considered to be the hacker who made maximum number of submissions on this day. The name of the hacker is Angela.

On March 04, 2016 hackers __20703__, __44065__, __53473__, and __79722__ made submissions. Now __20703__ and __79722__ only submitted each day, so there are __2__ unique hackers who made at least one submission each day. As each hacker made one submission so __20703__ is considered to be the hacker who made maximum number of submissions on this day. The name of the hacker is Angela.

On March 05, 2016 hackers __20703__,__36396__, __38289__ and __62529__ made submissions. Now __20703__ only submitted each day, so there is only __1__ unique hacker who made at least one submission each day. __36396__ made __2__ submissions and name of the hacker is Frank.

On March 06, 2016 only __20703__ made submission, so there is only __1__ unique hacker who made at least one submission each day.__20703__  made __1__ submission and name of the hacker is Angela.

 
