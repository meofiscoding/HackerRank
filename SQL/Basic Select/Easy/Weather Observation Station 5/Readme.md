Query the two cities in __STATION__ with the shortest and longest CITY names, as well as their respective lengths (i.e.: number of characters in the name). If there is more than one smallest or largest city, choose the one that comes first when ordered alphabetically.
The __STATION__ table is described as follows:

![Station.jpg](https://s3.amazonaws.com/hr-challenge-images/9336/1449345840-5f0a551030-Station.jpg)

where __LAT_N__ is the northern latitude and __LONG_W__ is the western longitude.

#### Sample Input#### 

For example, __CITY__ has four entries: __DEF, ABC, PQRS__ and __WXY__.

#### Sample Output#### 

`
ABC 3
PQRS 4
`

#### Explanation#### 

When ordered alphabetically, the __CITY__ names are listed as __ABC, DEF, PQRS,__ and __WXY__, with lengths __3,3,4__ and __3__. The longest name is __PQRS__, but there are __3__ options for shortest named city. Choose __ABC__, because it comes first alphabetically.

#### Note ####
You can write two separate queries to get the desired output. It need not be a single query.