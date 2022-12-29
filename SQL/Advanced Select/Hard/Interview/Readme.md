Samantha interviews many candidates from different colleges using coding challenges and contests. Write a query to print the contest_id, hacker_id, name, and the sums of total_submissions, total_accepted_submissions, total_views, and total_unique_views for each contest sorted by contest_id. Exclude the contest from the result if all four sums are __0__.

__Note__: A specific contest can be used to screen candidates at more than one college, but each college only holds __1__ screening contest.

---

#### Input Format #### 

The following tables hold interview data:

* Contests: The contest_id is the id of the contest, hacker_id is the id of the hacker who created the contest, and name is the name of the hacker. 

![](https://s3.amazonaws.com/hr-challenge-images/19596/1458517426-e017c3460e-ScreenShot2016-03-21at4.57.47AM.png)

* Colleges: The college_id is the id of the college, and contest_id is the id of the contest that Samantha used to screen the candidates. 

![](https://s3.amazonaws.com/hr-challenge-images/19596/1458517503-fd4aa63111-ScreenShot2016-03-21at4.57.56AM.png)

* Challenges: The challenge_id is the id of the challenge that belongs to one of the contests whose contest_id Samantha forgot, and college_id is the id of the college where the challenge was given to candidates. 

![](https://s3.amazonaws.com/hr-challenge-images/19596/1458517661-a642f750ce-ScreenShot2016-03-21at4.58.04AM.png)

* View_Stats: The challenge_id is the id of the challenge, total_views is the number of times the challenge was viewed by candidates, and total_unique_views is the number of times the challenge was viewed by unique candidates. 

![](https://s3.amazonaws.com/hr-challenge-images/19596/1458517983-b4302286a8-ScreenShot2016-03-21at4.58.15AM.png)

* Submission_Stats: The challenge_id is the id of the challenge, total_submissions is the number of submissions for the challenge, and total_accepted_submission is the number of submissions that achieved full scores. 

![](https://s3.amazonaws.com/hr-challenge-images/19596/1458518090-80983c916a-ScreenShot2016-03-21at4.58.27AM.png)

---

#### Sample Input#### 

Contests Table: ![](https://s3.amazonaws.com/hr-challenge-images/19596/1458519044-d788f8a6ee-ScreenShot2016-03-21at4.58.39AM.png)

Colleges Table: ![](https://s3.amazonaws.com/hr-challenge-images/19596/1458519098-912836d6ac-ScreenShot2016-03-21at4.59.22AM.png)

Challenges Table: ![](https://s3.amazonaws.com/hr-challenge-images/19596/1458519120-c531743caf-ScreenShot2016-03-21at4.59.32AM.png) 

View_Stats Table:  ![](https://s3.amazonaws.com/hr-challenge-images/19596/1458519152-107a67866b-ScreenShot2016-03-21at4.59.43AM.png)

Submission_Stats Table: ![](https://s3.amazonaws.com/hr-challenge-images/19596/1458519173-091aba871a-ScreenShot2016-03-21at4.59.55AM.png)

#### Sample Output #### 

`66406 17973 Rose 111 39 156 56`
`66556 79153 Angela 0 0 11 10`
`94828 80275 Frank 150 38 41 15`

#### Explanation #### 

The contest __66406__ is used in the college __11219__. In this college __11219__, challenges  __47127__ and __18765__ are asked, so from the view and submission stats:

* Sum of total submissions = __27 + 56 + 28 = 111__

* Sum of total accepted submissions = __10 + 18 + 11 = 39__

* Sum of total views = __43 + 72 + 26 + 15 = 156__

* Sum of total unique views = __10 + 13 + 19 + 14 = 56__

Similarly, we can find the sums for contests __66556__ and __94828__.
