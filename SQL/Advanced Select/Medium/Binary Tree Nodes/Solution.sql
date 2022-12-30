select N, CASE
    WHEN N not in (select P from BST where P is not null) THEN 'Leaf'
    WHEN N in (select P from BST) AND P IS NOT NULL THEN 'Inner'
    WHEN P IS NULL THEN 'Root'
    END
    from BST order by N
