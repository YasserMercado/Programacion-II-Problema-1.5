CREATE PROCEDURE SP_CLIENTES
AS 
SELECT apellido + ' ' + nombre 'Nombre Completo', id_cliente
FROM CLIENTES