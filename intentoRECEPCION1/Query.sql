--Crear bd
create database Hotel;

create table Puesto (
Id_puesto int not null,
Nombre_puesto varchar (50),
Salario int,
Primary key (Id_puesto)
);

create table Asistencias(
Id_asistencia int not null,
Entrada varchar(50),
Salida varchar(50),
primary key (Id_asistencia)
);

create table Nomina(
Id_nomina int not null,
Id_puesto int not null,
Id_asistencia int not null,
Nomina varchar(50),
Tipo_pago varchar(50),
primary key (Id_nomina),
Foreign key (Id_puesto) references Puesto(Id_puesto),
Foreign key (Id_asistencia) references Asistencias(Id_asistencia)
);

create table Empleados(
Id_empleado int not null,
No_empleado int,
Nombre_empleado varchar(100),
Id_nomina int,
Direccion varchar(100),
Telefono int,
Correo varchar(50),
Contraseña varchar (15),
Primary key (Id_empleado),
Foreign key (Id_nomina) references Nomina(Id_nomina)
);


--Tablas hechas por Reservaciones
	--Tabla Habitaciones
create table Habitaciones(
Id_habitacion int identity,
No_cuarto int,
Tipo_habitacion varchar (30),
Estado_habitacion varchar (30),
Disponibilidad varchar(30),
Precio int,
Primary key (Id_habitacion)
);

	--Tabla Reservaciones
create table Reservaciones(
Id_reservacion int identity,
Id_empleado int not null,
Id_habitacion int not null,
Fecha_reservacion varchar (30),
Fecha_entrada varchar (30),
Fecha_salida varchar (30),
Nombre_cliente varchar (30),
Telefono_cliente float,
Tarjeta_pago varchar(16),
Total float,
primary key (Id_reservacion),
Foreign key (Id_habitacion) references Habitaciones(Id_habitacion),
Foreign key (Id_empleado) references Empleados(Id_empleado)
);

	--Tabla para las disponibilidades de las habitaciones
create table Disponibilidad_hab (
Id_dispo int identity,
Id_habitacion int not null,
Fecha_entrada varchar(30),
Fecha_salida varchar(30),
Estado varchar(30),
primary key (Id_dispo),
foreign key (Id_habitacion) references Habitaciones (Id_habitacion)
);

	-- solicitud Recepcion - Mantenimiento
create table solicitudes_recepcion_mantenimiento(
Id_solicitudM int identity,
Fecha_solicitud varchar (30),
Solicita varchar (60),
Habitacion int,
Estado_solicitud varchar (30),
primary key (Id_solicitudM),
foreign key (Habitacion) references Habitaciones(Id_habitacion)
);

	-- Cancelaciones Recepcion - Rh
create table solicitudes_recepcion_recursoshumanos (
Id_solicitudRH int identity,
Fecha_solicitud varchar (30),
Cliente varchar (60),
Devolucion float,
Estado_solicitud varchar (30),
primary key (Id_solicitudRH)
);
--Fin tablas hechas por reservaciones


create table Mantenimiento(
Id_mantenimiento int not null,
Id_habitacion int not null,
Id_empleado int not null,
Fecha date,
No_detalle int,
Primary key (Id_mantenimiento),
Foreign key (Id_habitacion) references Habitaciones(Id_habitacion),
Foreign key (Id_empleado) references Empleados(Id_empleado)
);

create table Proveedores(
Id_proveedor int not null,
Nombre varchar,
Telefono int,
Email varchar,
Rfc varchar,
primary key (Id_proveedor)
);

create table Inventario(
Id_inventario int not null,
Nombre varchar,
Descripcion varchar,
Cantidad int,
Id_proveedor int not null,
Primary key (Id_inventario),
Foreign key (Id_proveedor) references Proveedores(Id_proveedor)
);

create table Mobiliario(
Id_mobiliario int not null,
Id_habitacion int not null,
Id_inventario int not null,
Cantidad int,
Primary key (Id_mobiliario),
Foreign key (Id_habitacion) references Habitaciones(Id_habitacion),
Foreign key (Id_inventario) references Inventario(Id_inventario)
);

create table Salidas(
Id_salida int not null,
Id_inventario int not null,
Descripcion varchar,
Cantidad int,
Fecha date,
Primary key (Id_salida),
Foreign key (Id_inventario) references Inventario(Id_inventario)
);

create table Entradas(
Id_entrada int not null,
Id_inventario int not null,
Cantidad int,
Precio float,
Total float,
Fecha date,
Id_proveedor int not null,
Primary key (Id_entrada),
Foreign key (Id_inventario) references Inventario(Id_inventario),
Foreign key (Id_proveedor) references Proveedores(Id_proveedor)
);

create table Detalles_M(
No_detalle int,
Id_inventario int not null,
Cantidad int,
Descripcion varchar,
Foreign key (Id_inventario) references Inventario(Id_inventario)
)

-- Inserts para la bd

	--
insert into Puesto (Id_puesto, Nombre_puesto, Salario) values (1, 'Recepcionista', 20000);
insert into Asistencias (Id_asistencia, Entrada, Salida) values (1, 20, 20);
insert into Nomina (Id_nomina, Id_puesto, Id_asistencia, Nomina, Tipo_pago) values (1, 1, 1, 'No se que rayos', 'semanal');
insert into Empleados (Id_empleado, No_empleado, Nombre_empleado, Id_nomina, Direccion, Telefono, Correo, Contraseña) values (1, 1, 'Pepito', 1, 'ITH', 2459167, 'correo@correo.com', 123);

-- insert habitaciones
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (101, 'Sencilla', 'Disponible', 'Limpia', 1000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (102, 'Sencilla', 'Disponible', 'Limpia', 1000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (103, 'Sencilla', 'Disponible', 'Limpia', 1000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (104, 'Sencilla', 'Disponible', 'Limpia', 1000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (105, 'Sencilla', 'Disponible', 'Limpia', 1000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (106, 'Doble', 'Disponible', 'Limpia', 2000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (107, 'Doble', 'Disponible', 'Limpia', 2000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (108, 'Doble', 'Disponible', 'Limpia', 2000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (109, 'Doble', 'Disponible', 'Limpia', 2000);
insert into Habitaciones (No_cuarto, Tipo_habitacion, Disponibilidad, Estado_habitacion) values (110, 'Doble', 'Disponible', 'Limpia', 2000);

	--insert reservaciones
insert into Reservaciones (Id_empleado, Id_habitacion, Fecha_reservacion, Fecha_entrada, Fecha_salida, Nombre_cliente, Telefono_cliente, Tarjeta_pago, Total) values (1, 5, '15/11/2018', '20/11/2018', '22/11/2018', 'Fredi', 48310564458, 1234567890123456, 1000);
insert into Reservaciones (Id_empleado, Id_habitacion, Fecha_reservacion, Fecha_entrada, Fecha_salida, Nombre_cliente, Telefono_cliente, Tarjeta_pago, Total) values (1, 6, '15/11/2018', '20/11/2018', '22/11/2018', 'Mercurio', 7912462257, 1234567890123456, 2000);
insert into Disponibilidad_hab (Id_habitacion, Fecha_entrada, Fecha_salida, Estado) values (5 , '20/11/2018', '22/11/2018', 'No disponible');
insert into Disponibilidad_hab (Id_habitacion, Fecha_entrada, Fecha_salida, Estado) values (6 , '20/11/2018', '22/11/2018', 'No disponible');

--update Habitaciones set Disponibilidad = 'Disponible' where Id_habitacion = 6;
--Formato fechas año-mes-dia 2018-12-31



--Consultas
select * from Reservaciones;
select * from Habitaciones;
select * from Disponibilidad_hab;


select Id_habitacion, No_cuarto, Disponibilidad 
from Habitaciones 
where Tipo_habitacion = 'Doble' and  not Id_habitacion in (Select Id_habitacion 
from Disponibilidad_hab where Fecha_entrada like '27/11/2018%' and Fecha_salida like '29/11/2018%');
