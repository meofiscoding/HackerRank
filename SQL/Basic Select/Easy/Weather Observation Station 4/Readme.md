Find the difference between the total number of __CITY__ entries in the table and the number of distinct __CITY__ entries in the table.
The __STATION__ table is described as follows:

![Station.jpg](https://s3.amazonaws.com/hr-challenge-images/9336/1449345840-5f0a551030-Station.jpg)

where __LAT_N__ is the northern latitude and __LONG_W__ is the western longitude.

For example, if there are three records in the table with __CITY__ values 'New York', 'New York', 'Bengalaru', there are 2 different city names: 'New York' and 'Bengalaru'. The query returns __1__, because __total number of records - number of unique city names = 3 - 2 = 1__.