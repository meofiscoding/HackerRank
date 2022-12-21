-- Get min(coin_needed) for each Wands group by [power],code and not evil
with a as(select w.code, wp.age, min(w.coins_needed) as coins, w.power from Wands w 
inner join Wands_Property wp 
on w.code = wp.code 
where wp.is_evil = 0 
group by w.power,wp.age , w.code
)
-- Join with Wands to get id
select w.id, a.age, a.coins, a.power from a inner join Wands w on a.code = w.code and a.coins = w.coins_needed and a.power = w.power

-- Order by Stuff
order by a.power DESC, a.age DESC

