with a as

-- List all total_challenge by hacker_id
(select c.hacker_id, h.name, Count(challenge_id)as total_challenge from Challenges c inner join Hackers h on h.hacker_id = c.hacker_id group by c.hacker_id, h.name)

-- Join part
select * from a where total_challenge not in 

-- List all duplicate total number
(select total_challenge from a where total_challenge < (select max(total_challenge) from a) group by total_challenge having count(total_challenge) > 1) 

-- Arrange
order by total_challenge DESC, hacker_id ASC
