select CAST(round((abs(Min(Lat_N) - Max(Lat_N)) + abs(Min(Long_W) - Max(Long_W))),4) as decimal(10,4)) from Station