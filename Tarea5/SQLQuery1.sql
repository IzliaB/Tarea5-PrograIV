use BDATOS

insert into Carreras(nombre_carrera)
       values('Informàtica'),
	         ('Diseño Gràfico'),
			 ('Administraciòn'),
			 ('Logistica')

select * from Carreras

SELECT id_carrera, nombre_carrera
                          FROM Carreras
                          ORDER BY nombre_carrera

INSERT INTO Alumnos(nombre_alumno, id_carrera)
                                    VALUES ('Jose Perdomo', 1)
									select * from Alumnos

UPDATE Alumnos
                          SET
                          nombre_alumno = 'Alexander',
                          id_carrera = 2

SELECT 
                      a.numero_cuenta,
                      c.nombre_carrera, 
                      a.nombre_alumno
                      FROM
                      Alumnos a
                      JOIN
                      Carreras c
                      ON
                      a.id_carrera = c.id_carrera  

					Insert Alumnos(numero_cuenta,nombre_alumno, id_carrera)
                                    VALUES (5,'dfhfgh', 3)
                     