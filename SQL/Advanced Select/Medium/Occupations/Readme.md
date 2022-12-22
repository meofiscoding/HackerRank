[Pivot](https://www.c-sharpcorner.com/UploadFile/f0b2ed/pivot-and-unpovit-in-sql-server/) the Occupation column in __OCCUPATIONS__ so that each Name is sorted alphabetically and displayed underneath its corresponding Occupation. The output column headers should be Doctor, Professor, Singer, and Actor, respectively.

__Note__: Print __NULL__ when there are no more names corresponding to an occupation.

#### Input Format ####

The __OCCUPATIONS__ table is described as follows:
![picture alt](https://s3.amazonaws.com/hr-challenge-images/12889/1443816414-2a465532e7-1.png)

Occupation will only contain one of the following values: __Doctor, Professor, Singer__ or __Actor__.

#### Sample Input ####

![picture alt](https://s3.amazonaws.com/hr-challenge-images/12890/1443817648-1b2b8add45-2.png)

#### Sample Output ####

` Jenny    Ashley     Meera  Jane
Samantha Christeen  Priya  Julia
NULL     Ketty      NULL   Maria `

#### Explanation ####

The first column is an alphabetically ordered list of Doctor names.
The second column is an alphabetically ordered list of Professor names.
The third column is an alphabetically ordered list of Singer names.
The fourth column is an alphabetically ordered list of Actor names.
The empty cell data for columns with less than the maximum number of names per occupation (in this case, the Professor and Actor columns) are filled with __NULL__ values.