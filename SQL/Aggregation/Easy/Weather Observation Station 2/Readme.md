Query the following two values from the __STATION__ table:

1. The sum of all values in LAT_N rounded to a scale of __2__ decimal places.
2. The sum of all values in LONG_W rounded to a scale of __2__ decimal places.
#### Input Format#### 

The __STATION__ table is described as follows:

![Station.jpg](https://s3.amazonaws.com/hr-challenge-images/9336/1449345840-5f0a551030-Station.jpg)

where LAT_N is the northern latitude and LONG_W is the western longitude.

#### Output Format#### 

Your results must be in the form:

`lat lon`
where _lat_ is the sum of all values in LAT_N and _lon_ is the sum of all values in LONG_W. Both results must be rounded to a scale of __2__ decimal places.