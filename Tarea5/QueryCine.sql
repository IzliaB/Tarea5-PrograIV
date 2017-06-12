Create Database Cine
use Cine
create table peliculas(
                       id_pelicula int IDENTITY(1,1) PRIMARY KEY NOT NULL,
                       nombre_pelicula varchar(50) NOT NULL
                      )

create table tickets(
                     id_ticket int IDENTITY(1,1) PRIMARY KEY NOT NULL,
                     id_pelicula int NOT NULL,
                     fecha_funcion date,
                     precio_pelicula money
					 CONSTRAINT FK_PeliculasTicket FOREIGN KEY (id_pelicula)
                     REFERENCES peliculas(id_pelicula)
                    )

SELECT MAX(id_ticket)+1 as Contador FROM tickets

CREATE SEQUENCE Test.CountBy1  
    START WITH 1  
    INCREMENT BY 1 ;

insert into peliculas(nombre_pelicula)
       values('Piratas del Caribe Y la venganza del Salazar'),
	         ('Un espía y medio'),
			 ('Como ser un latin lovers'),
			 ('La mujer maravilla')
	
select * from peliculas

insert into tickets(id_pelicula,fecha_funcion,precio_pelicula)
        values(1,'08/06/2017',90)

select * from tickets

SELECT 
                      t.id_ticket,
                      t.fecha_funcion,
                      t.precio_pelicula as precio ,
                      p.nombre_pelicula as pelicula
                      FROM
                      tickets t
                      JOIN
                      peliculas p
                      ON
                      t.id_pelicula = p.id_pelicula
                      ORDER BY t.id_ticket 

SELECT
                             id_pelicula, nombre_pelicula
                             FROM
                             peliculas
                             ORDER BY nombre_pelicula
SELECT 
                      p.id_pelicula,
                      p.nombre_pelicula as pelicula
                      FROM
                      peliculas p
                      ORDER BY p.id_pelicula 

SELECT id_pelicula FROM  peliculas