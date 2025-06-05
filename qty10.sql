USE sakila;
-- 10) Presente los clientes con su total de compra (dinero), cantidad de películas, sujeto a que hayan rentado más de 29 películas y el dinero sea superior $150. 
-- 		Dicho query debe ser etiquetado como ranking = '01-Premiun Customer' y presentado conjuntamente con:
-- 	---> los clientes cuyo total de compra (dinero) este por debajo de $65 o solo hayan rentado menos de 15 pelóculas. 
-- 			Este segundo query debe ser etiquetado como Ranking='02-Low Customer'.
create view vw_clientes_rentas_categoria as
select 
	customer.customer_id codigo_cliente,
    customer.first_name nombre_cliente,
    customer.last_name apellido_cliente,
    sum(payment.amount) total_facturado,
    count(rental.rental_id) total_renta,
    case
		when sum(payment.amount)>150 and count(rental.rental_id)>29 then '01-Premiun Customer'
    	when sum(payment.amount)<65 and count(rental.rental_id)<15 then '02-Low Customer'
        else ''
    end categoria_cliente
from rental
inner join payment
	on rental.rental_id = payment.rental_id
inner join customer
	on payment.customer_id = customer.customer_id
group by customer.customer_id,
    customer.first_name,
    customer.last_name
;




CREATE OR REPLACE VIEW tclientesRentasCategorias AS
SELECT 
    ROW_NUMBER() OVER (ORDER BY SUM(payment.amount) DESC) AS id,
    customer.customer_id AS codigo_cliente,
    customer.first_name AS nombre_cliente,
    customer.last_name AS apellido_cliente,
    SUM(payment.amount) AS total_facturado,
    COUNT(rental.rental_id) AS total_renta,
    CASE
        WHEN SUM(payment.amount) > 150 AND COUNT(rental.rental_id) > 29 THEN '01-Premiun Customer'
        WHEN SUM(payment.amount) < 65 AND COUNT(rental.rental_id) < 15 THEN '02-Low Customer'
        ELSE ''
    END AS categoria_cliente,
	sysdate() fecha_carga
FROM rental
INNER JOIN payment ON rental.rental_id = payment.rental_id
INNER JOIN customer ON payment.customer_id = customer.customer_id
GROUP BY 
    customer.customer_id,
    customer.first_name,
    customer.last_name;
