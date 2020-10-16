-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

insert into actor values ( 'Hampton', 'Avenue')
insert into actor  values ( 'Lisa', 'Byway')
select * from actor order by actor_id desc
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
insert into film (title, description, release_year, language_id, length)
values ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)
select * from film order by film_id desc
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
insert into film_actor (actor_id, film_id) values (201,1001)
insert into film_actor (actor_id, film_id) values (202,1001)

select * from film_actor 
-- 4. Add Mathmagical to the category table.
insert into category values ('Mathmagical')

select * from category 
-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
select * from film where title in ('Euclidean PI', 'EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE')


insert into film_category values (274,17)
insert into film_category values (494,17)
insert into film_category values (714,17)
insert into film_category values (996,17)
insert into film_category values (1001,17)

select * from film_category order by category_id desc

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
select * from film where film_id in (274, 494, 714, 996, 1001)

update film set rating = 'G' where film_id in (274, 494, 714, 996, 1001)
-- 7. Add a copy of "Euclidean PI" to all the stores.
select * from inventory order by film_id desc
insert into inventory values ((select film_id from film where title = 'Euclidean PI'),1)  
insert into inventory values ((select film_id from film where title = 'Euclidean PI'),2)  

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
delete film where film_id = 1001
--It fails because there are foriegn keys involved from other tables so it cannot be deleted. 


-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
delete category where category_id = 17
--Similar to above there are keys involved which does not allow us to delete the category. 

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
select * from film_category order by category_id desc
delete film_category where category_id = 17
--This succeeds because in the previous steps we made this as a forigen key which allowed for us to delete it here.


-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
delete category where category_id = 17

delete film where film_id = 1001

--We are able to delete mathemagical because there are no other references to it in the database, we are still unable to delete the film because there are references made in the database 


-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--What we would have to do to be able to remove the film from the database. So we would need to remove Euclidean PI from the film actors and anywhere else we had it inserted before we can remove it all together. 