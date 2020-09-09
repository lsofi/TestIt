USE [TestIt]

--Usuarios
INSERT INTO Usuarios
VALUES ('JNeschisi', 1234, 0)

INSERT INTO Usuarios
VALUES ('GCarranza', 1234, 0)

INSERT INTO Usuarios
VALUES ('ACornejo', 1234, 0)

INSERT INTO Usuarios
VALUES ('SJuarez', 1234, 0)


--Equipos
INSERT INTO Equipos
VALUES ('FFT', 0)

INSERT INTO Equipos
VALUES ('Atletico VC', 0)

INSERT INTO Equipos
VALUES ('HandballGo', 0)


--Deportes
INSERT INTO Deportes
VALUES ('Futbol', 0)

INSERT INTO Deportes
VALUES ('Handball', 0)


--Categorias
INSERT INTO Categorias
VALUES ('Infantil', 0)

INSERT INTO Categorias
VALUES ('Menor', 0)

INSERT INTO Categorias
VALUES ('Cadete', 0)

INSERT INTO Categorias
VALUES ('Juvenil', 0)

INSERT INTO Categorias
VALUES ('Reserva', 0)

INSERT INTO Categorias
VALUES ('Primera', 0)

INSERT INTO Categorias
VALUES ('Adulto', 0)


--Deportistas
INSERT INTO Deportistas
VALUES (40333222, 'Perez', 'Ramon', 180, 75, 0, '1995-02-22', 1, 1, 1, 0 )

INSERT INTO Deportistas
VALUES (42222456, 'Vilanova', 'Santiago', 173, 72, 0, '1999-06-04', 1, 1, 1, 0)

INSERT INTO Deportistas
VALUES (39534778, 'Romero', 'Valentina', 163, 62,  1, '1998-01-02', 2, 1, 2, 0)

INSERT INTO Deportistas
VALUES (33587100, 'Mallo', 'Maria', 167, 65, 1, '1994-06-04', 2, 1, 2, 0)

INSERT INTO Deportistas
VALUES (44587122, 'Brasiolo', 'Sol', 159, 60, 1, '2000-09-17', 3, 2, 3, 0)

INSERT INTO Deportistas
VALUES (42587122, 'Salas', 'Lucrecia', 164, 63, 1, '1999-11-11', 3, 2, 3, 0)

INSERT INTO Deportistas
VALUES (38422356, 'Lopez', 'Juan', 183, 0, 78, '1996-08-02', 3, 2, 4, 0 )

INSERT INTO Deportistas
VALUES (39106225, 'Vilanova', 'Santiago', 179, 74, 0, '1997-07-29', 3, 2, 4, 0)