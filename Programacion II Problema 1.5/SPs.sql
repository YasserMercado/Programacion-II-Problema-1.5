CREATE PROCEDURE SP_CLIENTES
AS 
SELECT apellido + ' ' + nombre 'Nombre Completo', id_cliente
FROM CLIENTES

CREATE PROCEDURE SP_TIPO_MASCOTAS
AS 
SELECT tipo, id_tipo
FROM TIPO_MASCOTAS

ALTER PROCEDURE SP_CONSULTA
@nombre varchar (50), @edad int,
@descripcion varchar(100), @importe int
AS
INSERT INTO MASCOTAS(nombre, edad)
VALUES (@nombre, @edad)
INSERT INTO ATENCIONES(descripcion, importe)
VALUES (@descripcion, @importe)