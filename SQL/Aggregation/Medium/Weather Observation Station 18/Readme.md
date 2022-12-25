Consider __P1(a,b)__ and __P2(a,b)__ to be two points on a 2D plane.

* __a__ happens to equal the minimum value in Northern Latitude (LAT_N in __STATION__).
* __b__ happens to equal the minimum value in Western Longitude (LONG_W in __STATION__).
* __c__ happens to equal the maximum value in Northern Latitude (LAT_N in __STATION__).
* __d__ happens to equal the maximum value in Western Longitude (LONG_W in __STATION__).
Query the [Manhattan Distance](https://xlinux.nist.gov/dads/HTML/manhattanDistance.html) between points __P1(a,b)__ and __P2(a,b)__ and round it to a scale of __4__ decimal places.

#### Input Format ####

The __STATION__ table is described as follows:

![](https://s3.amazonaws.com/hr-challenge-images/9336/1449345840-5f0a551030-Station.jpg)

where LAT_N is the northern latitude and LONG_W is the western longitude.