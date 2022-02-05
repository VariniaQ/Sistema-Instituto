INSERT INTO LOCALIDAD VALUES
(1,"Caballito"),
('',"Liniers"),
('',"Mataderos"),
('',"Parque Avellaneda"),
('',"Floresta"),
('',"Flores"),
('',"Almagro"),
('',"Monserrat"),
('',"Parque Chacabuco"),
('',"Palermo");

INSERT INTO RANGODIRECTIVO VALUES
(1,"Profesor titular"),
('',"Profesor asociado"),
('',"Profesor adjunto"),
('',"Ayudante de primera"),
('',"Ayudante de segunda"),
('',"Jefe de trabajos practicos");

INSERT INTO MOTIVOLICENCIA VALUES
(1,"Licencia ordinaria para descanso anual"),
('',"Licencia por tratamiento de salud"),
('',"Licencia por maternidad"),
('',"Licencia por fallecimiento de conyuge"),
('',"Licencia por matrimonio"),
('',"Licencia por disposiciones comunes");

INSERT INTO SUELDO VALUES
(1,5,25000),
('',1,40000),
('',3,28000),
('',4,30000),
('',2,35000),
('',6,30000);

INSERT INTO USUARIO VALUES
(1,1, '1'),
('',49122455, '49122455');

INSERT INTO PROFESIONES VALUES 
(1,"Ingenieria Industrial", 6, 12000, 12, 1000),
('',"Ingenieria Electronica", 6, 12000, 12, 1000),
('',"Ingenieria Civil", 6, 12000, 12, 1000),
('',"Ingenieria Mecanica", 6, 12000, 12, 1000),
('',"Ciencias Sociales", 3, 6000, 6, 1000),
('',"Derecho", 6, 12000, 12, 1000),
('',"Ciencias Economicas", 3, 6000, 6, 1000),
('',"Ingenieria Informatica y Sistemas", 6, 12000, 12, 1000);

INSERT INTO CLASES VALUES 
(1,1, 20,NULL),
('',2, 15,NULL),
('',3, 15,NULL),
('',4, 20,NULL),
('',5, 10,NULL),
('',6, 20,NULL),
('',7, 10,NULL),
('',8, 15,NULL);

INSERT INTO ALUMNOS VALUES
(1, "Miguel","Marconi", 1, "Paso de Carasca 2501", 1569685474, "miguel@gmail.com", 49456893, "Masculino", "Soltero", false, 0, 0, null),
('', "Juarez","Marcelo", 2, "Libertador 30", 1123568978, "marcelo@gmail.com", 49698741, "Masculino", "Casado", false, 0, 0, null),
('', "Hidalgo","Margarita", 3, "Abascal 869", 1512457836, "margarita@gmail.com", 49751236, "Femenino", "Soltero", false, 0, 0, null);

INSERT INTO DOCENTE VALUES
(1,"Luro","Maria Josefina",3,"Oliden 1971",1147857855,"lurojosefina@bue.edu.ar",49452452,"Femenino","1999/08/06",3,1),
('',"Nevarez","Marcos",1,"Rojas 258",1119785452,"nevarezmarcos@gmail.com",49852154,"Masculino","1985/01/01",6,2),
('',"Torres","Tobias",5,"Campana 144",1147851244,"torrestobias@bue.edu.ar",49122455,"Masculino","1980/03/17",3,1);

INSERT INTO ALUMNOCLASE VALUES 
(1, 1),
(1, 2),
(1, 3),
(4, 1),
(8, 3);
