CREATE PROCEDURE SP_CLIENTES
AS 
SELECT apellido + ' ' + nombre 'Nombre Completo', id_cliente
FROM CLIENTES

CREATE PROCEDURE SP_TIPO_MASCOTAS
AS 
SELECT tipo, id_tipo
FROM TIPO_MASCOTAS

CREATE PROCEDURE SP_CONSULTA
@nombre varchar (50), @edad int, @id_tipo int, @id_cliente int,
@descripcion varchar(100), @importe int
AS
INSERT INTO MASCOTAS(nombre, edad, id_tipo, id_cliente)
VALUES (@nombre, @edad, @id_tipo, @id_cliente)
INSERT INTO ATENCIONES(descripcion, importe)
VALUES (@descripcion, @importe)