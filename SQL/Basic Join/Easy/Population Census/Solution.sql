select sum(City.Population) from City inner join Country on City.CountryCode = Country.Code where Continent = 'Asia'