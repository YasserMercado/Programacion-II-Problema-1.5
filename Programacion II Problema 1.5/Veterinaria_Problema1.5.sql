create database VETERINARIA
go
use VETERINARIA
go

create table TIPO_MASCOTAS(
id_tipo int identity (1,1),
tipo varchar (50),
constraint pk_tipo_mascotas primary key (id_tipo),
)

create table CLIENTES(
id_cliente int identity (1,1),
nombre varchar (50),
apellido varchar (50),
sexo varchar (1),
constraint pk_clientes primary key (id_cliente),
)

create table MASCOTAS(
id_mascota int identity (1,1),
nombre varchar (50),
edad int,
id_tipo int,
id_cliente int,
constraint pk_mascotas primary key (id_mascota),
constraint fk_mascotas_tipo_mascotas foreign key (id_tipo) references tipo_mascotas(id_tipo),
constraint fk_mascotas_clientes foreign key (id_cliente) references clientes(id_cliente),
)

create table ATENCIONES(
id_atencion int identity (1,1),
descripcion varchar (100),
importe int,
id_mascota int,
constraint pk_atenciones primary key (id_atencion),
constraint fk_atenciones_mascotas foreign key (id_mascota) references mascotas(id_mascota)
)

insert into CLIENTES(nombre, apellido, sexo)
values ('Raul', 'Gonzales', 'M')
insert into CLIENTES(nombre, apellido, sexo)
values ('Griselda', 'Gomez', 'F')
insert into CLIENTES(nombre, apellido, sexo)
values ('Laura', 'Duarte', 'F')
insert into CLIENTES(nombre, apellido, sexo)
values ('Dario', 'Alvarez', 'M')
insert into CLIENTES(nombre, apellido, sexo)
values ('Gonzalo', 'Veron', 'M')
insert into CLIENTES(nombre, apellido, sexo)
values ('Maria', 'Velez', 'F')
insert into CLIENTES(nombre, apellido, sexo)
values ('Laura', 'Perez', 'F')
insert into CLIENTES(nombre, apellido, sexo)
values ('Marcos', 'Sanchez', 'M')
insert into CLIENTES(nombre, apellido, sexo)
values ('German', 'Robet', 'M')
insert into CLIENTES(nombre, apellido, sexo)
values ('Fernanda', 'Dantes', 'F')

insert into TIPO_MASCOTAS(tipo)
values ('Gato')
insert into TIPO_MASCOTAS(tipo)
values ('Perro')
insert into TIPO_MASCOTAS(tipo)
values ('Araña')
insert into TIPO_MASCOTAS(tipo)
values ('Vaca')
insert into TIPO_MASCOTAS(tipo)
values ('Caballo')
insert into TIPO_MASCOTAS(tipo)
values ('Serpiente')