USE [TestIt]

--Usuarios
INSERT INTO Usuarios
VALUES (1, 'JNeschisi', 1234, 0)

INSERT INTO Usuarios
VALUES (2, 'GCarranza', 1234, 0)

INSERT INTO Usuarios
VALUES (3, 'ACornejo', 1234, 0)

INSERT INTO Usuarios
VALUES (4, 'SJuarez', 1234, 0)


--Equipos
INSERT INTO Equipos
VALUES (1, 'FFT', 0)

INSERT INTO Equipos
VALUES (2, 'Atletico VC', 0)

INSERT INTO Equipos
VALUES (3, 'HandballGo', 0)


--Deportes
INSERT INTO Deportes
VALUES (1, 'Futbol', 0)

INSERT INTO Deportes
VALUES (2, 'Handball', 0)


--Categorias
INSERT INTO Categorias
VALUES (1, 'Infantil', 0)

INSERT INTO Categorias
VALUES (2, 'Menor', 0)

INSERT INTO Categorias
VALUES (3, 'Cadete', 0)

INSERT INTO Categorias
VALUES (4, 'Juvenil', 0)

INSERT INTO Categorias
VALUES (5, 'Reserva', 0)

INSERT INTO Categorias
VALUES (6, 'Primera', 0)

INSERT INTO Categorias
VALUES (7, 'Adulto', 0)


--Deportistas
INSERT INTO Deportistas
VALUES (1, 40333222, 'Perez', 'Ramon', 180, 75, 0, '1995-02-22', 1, 1, 1, 0 )

INSERT INTO Deportistas
VALUES (2, 42222456, 'Vilanova', 'Santiago', 173, 72, 0, '1999-06-04', 1, 1, 1, 0)

INSERT INTO Deportistas
VALUES (3, 39534778, 'Romero', 'Valentina', 163, 62,  1, '1998-01-02', 2, 1, 2, 0)

INSERT INTO Deportistas
VALUES (4, 33587100, 'Mallo', 'Maria', 167, 65, 1, '1994-06-04', 2, 1, 2, 0)

INSERT INTO Deportistas
VALUES (5, 44587122, 'Brasiolo', 'Sol', 159, 60, 1, '2000-09-17', 3, 2, 3, 0)

INSERT INTO Deportistas
VALUES (6, 42587122, 'Salas', 'Lucrecia', 164, 63, 1, '1999-11-11', 3, 2, 3, 0)

INSERT INTO Deportistas
VALUES (7, 38422356, 'Lopez', 'Juan', 183, 0, 78, '1996-08-02', 3, 2, 4, 0 )

INSERT INTO Deportistas
VALUES (8, 39106225, 'Vilanova', 'Santiago', 179, 74, 0, '1997-07-29', 3, 2, 4, 0)