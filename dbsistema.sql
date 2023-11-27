--Tabla categoría
create table categoria (
	idcategoria integer primary key identity,
	nombre varchar(50) not null unique,
	descripcion varchar(256) null,
	estado bit default(1)
);
go
--Tabla artículo
create table articulo (
	idarticulo integer primary key identity,
	idcategoria integer not null,
	codigo varchar(50) null,
	nombre varchar(100) not null unique,
	precio_venta decimal(11,2) not null,
	stock integer not null,
	descripcion varchar(256) null,
	imagen varchar(128) null,
	estado bit default(1),
	FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
);
go

-- default cadena vacia
--alter table articulo alter column imagen varchar(128) not null default('');
--ALTER TABLE articulo
--ADD CONSTRAINT DF_imagen DEFAULT '' FOR imagen;

--Tabla Persona
create table persona(
	idpersona integer primary key identity,
	tipo_persona varchar(20) not null,
	nombre varchar(100) not null,
	tipo_documento varchar(20) null,
	num_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) null
);
go

--Tabla rol
create table rol (
	idrol integer primary key identity,
	nombre varchar(30) not null,
	descripcion varchar(255) null,
	estado bit default(1)
);
go

--Tabla usuario
create table usuario(
	idusuario integer primary key identity,
	idrol integer not null,
	nombre varchar(100) not null,
	tipo_documento varchar(20) null,
	num_documento varchar(20) null,
	direccion varchar(70) null,
	telefono varchar(20) null,
	email varchar(50) not null,
	clave varbinary(MAX) not null,
	estado bit default(1),
	FOREIGN KEY (idrol) REFERENCES rol (idrol)
);
go

--Tabla ingreso
create table ingreso(
	idingreso integer primary key identity,
	idproveedor integer not null,
	idusuario integer not null,
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) null,
	num_comprobante varchar (10) not null,
	fecha datetime not null,
	impuesto decimal (4,2) not null,
	total decimal (11,2) not null,
	estado varchar(20) not null,
	FOREIGN KEY (idproveedor) REFERENCES persona (idpersona),
	FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)
);
go

--Tabla detalle_ingreso
create table detalle_ingreso (
	iddetalle_ingreso integer primary key identity,
	idingreso integer not null,
	idarticulo integer not null,
	cantidad integer not null,
	precio decimal(11,2) not null,
	FOREIGN KEY (idingreso) REFERENCES ingreso (idingreso) ON DELETE CASCADE,
	FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);
go

--Tabla venta
create table venta(
	idventa integer primary key identity,
	idcliente integer not null,
	idusuario integer not null,
	tipo_comprobante varchar(20) not null,
	serie_comprobante varchar(7) null,
	num_comprobante varchar (10) not null,
	fecha datetime not null,
	impuesto decimal (4,2) not null,
	total decimal (11,2) not null,
	estado varchar(20) not null,
	FOREIGN KEY (idcliente) REFERENCES persona (idpersona),
	FOREIGN KEY (idusuario) REFERENCES usuario (idusuario)
);
go

--Tabla detalle_venta
create table detalle_venta (
	iddetalle_venta integer primary key identity,
	idventa integer not null,
	idarticulo integer not null,
	cantidad integer not null,
	precio decimal(11,2) not null,
	descuento decimal(11,2) not null,
	FOREIGN KEY (idventa) REFERENCES venta (idventa) ON DELETE CASCADE,
	FOREIGN KEY (idarticulo) REFERENCES articulo (idarticulo)
);
go

-- Creamos 3 insert para cada tabla --
-- Insertar en la tabla categoria --
insert into categoria (nombre, descripcion) values ('Seleccionar', '');
insert into categoria (nombre, descripcion) values ('Laptops', 'Laptops de última generación');
insert into categoria (nombre, descripcion) values ('Celulares', 'Celulares de última generación');
insert into categoria (nombre, descripcion) values ('Accesorios', 'Accesorios para celulares y laptops');
go
-- Insertar en la tabla articulo --
insert into articulo (idcategoria, codigo, nombre, precio_venta, stock, descripcion, imagen) values (2, 'LAP001', 'Laptop HP', 1000, 10, 'Laptop HP 8GB RAM', '');
insert into articulo (idcategoria, codigo, nombre, precio_venta, stock, descripcion, imagen) values (2, 'LAP002', 'Laptop Dell', 1200, 10, 'Laptop Dell 8GB RAM', '');
insert into articulo (idcategoria, codigo, nombre, precio_venta, stock, descripcion, imagen) values (3, 'CEL001', 'Celular Samsung', 500, 10, 'Celular Samsung 8GB RAM', '');
go
-- Insertar en la tabla persona --
insert into persona (tipo_persona, nombre, tipo_documento, num_documento, direccion, telefono, email) values ('Proveedor', 'Juan Perez', 'DNI', '12345678', 'Av. Lima 123', '44556677', 'juanperez@proveedpr.com');
insert into persona (tipo_persona, nombre, tipo_documento, num_documento, direccion, telefono, email) values ('Cliente', 'Maria Diaz', 'DNI', '87654321', 'Av. Lima 456', '11223344', 'mariadiaz@gmail.com');
insert into persona (tipo_persona, nombre, tipo_documento, num_documento, direccion, telefono, email) values ('Cliente', 'Pedro Rodriguez', 'DNI', '12345678', 'Av. Lima 789', '12345678', 'pedrito@gmail.com');
go
-- Insertar en la tabla rol --
insert into rol (nombre, descripcion) values ('Seleccionar', '');
insert into rol (nombre, descripcion) values ('Administrador', 'Administradores de la empresa');
insert into rol (nombre, descripcion) values ('Vendedor', 'Vendedores de la empresa');
insert into rol (nombre, descripcion) values ('Almacenero', 'Almaceneros de la empresa');
go
-- Insertar en la tabla usuario --
insert into usuario (idrol, nombre, tipo_documento, num_documento, direccion, telefono, email, clave) values (2, 'JuanCarlos', 'DNI', '12345678', 'Av. Lima 123', '12345678', 'juancarlos@empresa.com', CONVERT(varbinary,'admin'));
insert into usuario (idrol, nombre, tipo_documento, num_documento, direccion, telefono, email, clave) values (3, 'MarcosTadeus', 'DNI', '87654321', 'Av. Lima 456', '11223344', 'marcostadeus@empresa.com', CONVERT(varbinary,'vendedor'));
insert into usuario (idrol, nombre, tipo_documento, num_documento, direccion, telefono, email, clave) values (4, 'AlbertoLopez', 'DNI', '12345678', 'Av. Lima 789', '44556677', 'albertolopez@empresa.com', CONVERT(varbinary,'almacenero'));
go
-- Insertar en la tabla ingreso --
insert into ingreso (idproveedor, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (1, 1, 'Boleta', '001', '0000001', '2020-01-01', 0.18, 1000, 'Aceptado');
insert into ingreso (idproveedor, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (1, 1, 'Boleta', '001', '0000002', '2020-01-02', 0.18, 1200, 'Aceptado');
insert into ingreso (idproveedor, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (1, 1, 'Boleta', '001', '0000003', '2020-01-03', 0.18, 500, 'Aceptado');
go
-- Insertar en la tabla detalle_ingreso --
insert into detalle_ingreso (idingreso, idarticulo, cantidad, precio) values (1, 1, 10, 1000);
insert into detalle_ingreso (idingreso, idarticulo, cantidad, precio) values (2, 2, 10, 1200);
insert into detalle_ingreso (idingreso, idarticulo, cantidad, precio) values (3, 3, 10, 500);
go
-- Insertar en la tabla venta --
insert into venta (idcliente, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (2, 1, 'Boleta', '001', '0000001', '2020-01-01', 0.18, 1000, 'Aceptado');
insert into venta (idcliente, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (2, 1, 'Boleta', '001', '0000002', '2020-01-02', 0.18, 1200, 'Aceptado');
insert into venta (idcliente, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (3, 1, 'Boleta', '001', '0000003', '2020-01-03', 0.18, 500, 'Aceptado');
go
-- Insertar en la tabla detalle_venta --
insert into detalle_venta (idventa, idarticulo, cantidad, precio, descuento) values (1, 1, 10, 1000, 0);
insert into detalle_venta (idventa, idarticulo, cantidad, precio, descuento) values (2, 2, 10, 1200, 0);
insert into detalle_venta (idventa, idarticulo, cantidad, precio, descuento) values (3, 3, 10, 500, 0);
go


-- Ahora los procesos CRUD de Categoria--
-- todos los nombres de los procedimiento en ingles--

-- Obtener por id --
create proc category_get_by_id
@idcategory integer
as
select idcategoria as ID, nombre as Name, descripcion as Description, estado as State
from categoria 
where idcategoria = @idcategory;
go

-- Listar --
create proc category_list
as
select idcategoria as ID, nombre as Name, descripcion as Description, estado as State
from categoria 
order by idcategoria desc;
go

-- Buscar --
create proc category_search
@name varchar(50)
as
select idcategoria as ID, nombre as Name, descripcion as Description, estado as State
from categoria 
where nombre like '%' + @name + '%' or descripcion like '%' + @name + '%'
order by idcategoria desc;
go

-- Insertar --
create proc category_insert
@name varchar(50),
@description varchar(256)
as
insert into categoria (nombre, descripcion) values (@name, @description);
go

-- Actualizar --
create proc category_update
@idcategory integer,
@name varchar(50),
@description varchar(256)
as
update categoria set nombre = @name, descripcion = @description where idcategoria = @idcategory;
go

-- Eliminar --	
create proc category_delete
@idcategory integer
as
delete from categoria where idcategoria = @idcategory;
go

-- Desactivar --
create proc category_disable
@idcategory integer
as
update categoria set estado = 0 where idcategoria = @idcategory;
go

-- Activar --
create proc category_enable
@idcategory integer
as
update categoria set estado = 1 where idcategoria = @idcategory;
go

-- Obtener solo las categorias activas --
create proc active_category_list
as
select idcategoria as ID, nombre as Name, descripcion as Description, estado as State
from categoria 
where estado = 1
go

-- El mismo CRUD pero de Articulo--

-- Listar --
create proc article_list
as
select a.idarticulo as ID, a.idcategoria as IDCategory, c.nombre as Category, a.codigo as Code, a.nombre as Name, a.precio_venta as Price, a.stock as Stock, a.descripcion as Description, a.imagen as Image, a.estado as State
from articulo a inner join categoria c on a.idcategoria = c.idcategoria
order by a.idarticulo desc;
go

-- Obtener por id --
create proc article_get_by_id
@idarticle integer
as
select a.idarticulo as ID, a.idcategoria as IDCategory, c.nombre as Category, a.codigo as Code, a.nombre as Name, a.precio_venta as Price, a.stock as Stock, a.descripcion as Description, a.imagen as Image, a.estado as State
from articulo a inner join categoria c on a.idcategoria = c.idcategoria
where a.idarticulo = @idarticle;
go

-- Buscar --
create proc article_search
@name varchar(50)
as
select a.idarticulo as ID, a.idcategoria as IDCategory, c.nombre as Category, a.codigo as Code, a.nombre as Name, a.precio_venta as Price, a.stock as Stock, a.descripcion as Description, a.imagen as Image, a.estado as State
from articulo a inner join categoria c on a.idcategoria = c.idcategoria
where a.nombre like '%' + @name + '%' or a.descripcion like '%' + @name + '%' or a.codigo like '%' + @name + '%'
order by a.idarticulo desc;
go

-- Insertar --
create proc article_insert
@idcategory integer,
@code varchar(50),
@name varchar(100),
@price decimal(11,2),
@stock integer,
@description varchar(256),
@image varchar(128)
as
insert into articulo (idcategoria, codigo, nombre, precio_venta, stock, descripcion, imagen) values (@idcategory, @code, @name, @price, @stock, @description, @image);
go

-- Actualizar --
create proc article_update
@idarticle integer,
@idcategory integer,
@code varchar(50),
@name varchar(100),
@price decimal(11,2),
@stock integer,
@description varchar(255),
@image varchar(128)
as
update articulo set idcategoria = @idcategory, codigo = @code, nombre = @name, precio_venta = @price, stock = @stock, descripcion = @description, imagen = @image where idarticulo = @idarticle;
go

-- Eliminar --
create proc article_delete
@idarticle integer
as
delete from articulo where idarticulo = @idarticle;
go

-- Desactivar --
create proc article_disable
@idarticle integer
as
update articulo set estado = 0 where idarticulo = @idarticle;
go

-- Activar --
create proc article_enable
@idarticle integer
as
update articulo set estado = 1 where idarticulo = @idarticle;
go



-- El mismo CRUD pero de Persona--

-- Listar --
create proc person_list
as
select idpersona as ID, tipo_persona as Type, nombre as Name, tipo_documento as DocumentType, num_documento as DocumentNumber, direccion as Address, telefono as Phone, email as Email
from persona
order by idpersona desc;
go

-- Buscar --
create proc person_search
@name varchar(50)
as
select idpersona as ID, tipo_persona as Type, nombre as Name, tipo_documento as DocumentType, num_documento as DocumentNumber, direccion as Address, telefono as Phone, email as Email
from persona
where nombre like '%' + @name + '%' or num_documento like '%' + @name + '%'
order by idpersona desc;
go

-- Insertar --
create proc person_insert
@type varchar(20),
@name varchar(100),
@documenttype varchar(20),
@documentnumber varchar(20),
@address varchar(70),
@phone varchar(20),
@email varchar(50)
as
insert into persona (tipo_persona, nombre, tipo_documento, num_documento, direccion, telefono, email) values (@type, @name, @documenttype, @documentnumber, @address, @phone, @email);
go

-- Actualizar --
create proc person_update
@idperson integer,
@type varchar(20),
@name varchar(100),
@documenttype varchar(20),
@documentnumber varchar(20),
@address varchar(70),
@phone varchar(20),
@email varchar(50)
as
update persona set tipo_persona = @type, nombre = @name, tipo_documento = @documenttype, num_documento = @documentnumber, direccion = @address, telefono = @phone, email = @email
where idpersona = @idperson;
go

-- Eliminar --
create proc person_delete
@idperson integer
as
delete from persona where idpersona = @idperson;
go

-- Desactivar --
--create proc person_disable
--@idperson integer
--as
--update persona set estado = 0 where idpersona = @idperson;
--go

-- Activar --
--create proc person_enable
--@idperson integer
--as
--update persona set estado = 1 where idpersona = @idperson;
--go


-- El mismo CRUD pero de Rol--

-- Listar --
create proc role_list
as
select idrol as ID, nombre as Name, descripcion as Description, estado as State
from rol
order by idrol desc;
go

-- Buscar --
create proc role_search
@name varchar(50)
as
select idrol as ID, nombre as Name, descripcion as Description, estado as State
from rol
where nombre like '%' + @name + '%' or descripcion like '%' + @name + '%'
order by idrol desc;
go

-- Obtener por id --
create proc role_get_by_id
@idrole integer
as
select idrol as ID, nombre as Name, descripcion as Description, estado as State
from rol
where idrol = @idrole;
go

-- Obtener solo los roles activos --
create proc active_role_list
as
select idrol as ID, nombre as Name, descripcion as Description, estado as State
from rol
where estado = 1
go

-- Insertar --
create proc role_insert
@name varchar(30),
@description varchar(255)
as
insert into rol (nombre, descripcion) values (@name, @description);
go

-- Actualizar --
create proc role_update
@idrole integer,
@name varchar(30),
@description varchar(255)
as
update rol set nombre = @name, descripcion = @description where idrol = @idrole;
go

-- Eliminar --
create proc role_delete
@idrole integer
as
delete from rol where idrol = @idrole;
go

-- Desactivar --
create proc role_disable
@idrole integer
as
update rol set estado = 0 where idrol = @idrole;
go

-- Activar --
create proc role_enable
@idrole integer
as
update rol set estado = 1 where idrol = @idrole;
go


-- El mismo CRUD pero de Usuario--

-- Listar --
create proc user_list
as
select u.idusuario as ID, u.idrol as IDRole, r.nombre as Role, u.nombre as Name, u.tipo_documento as DocumentType, u.num_documento as DocumentNumber, u.direccion as Address, u.telefono as Phone, u.email as Email, u.estado as State
from usuario u inner join rol r on u.idrol = r.idrol
order by u.idusuario desc;
go

-- Buscar --
create proc user_search
@name varchar(50)
as
select u.idusuario as ID, u.idrol as IDRole, r.nombre as Role, u.nombre as Name, u.tipo_documento as DocumentType, u.num_documento as DocumentNumber, u.direccion as Address, u.telefono as Phone, u.email as Email, u.estado as State
from usuario u inner join rol r on u.idrol = r.idrol
where u.nombre like '%' + @name + '%' or u.num_documento like '%' + @name + '%' or u.email like '%' + @name + '%'
order by u.idusuario desc;
go

-- Obtener por id --
create proc user_get_by_id
@iduser integer
as
select u.idusuario as ID, u.idrol as IDRole, r.nombre as Role, u.nombre as Name, u.tipo_documento as DocumentType, u.num_documento as DocumentNumber, u.direccion as Address, u.telefono as Phone, u.email as Email, u.estado as State
from usuario u inner join rol r on u.idrol = r.idrol
where u.idusuario = @iduser;
go

-- Insertar --
create proc user_insert
@idrole integer,
@name varchar(100),
@documenttype varchar(20),
@documentnumber varchar(20),
@address varchar(70),
@phone varchar(20),
@email varchar(50),
@password varbinary(MAX)
as
insert into usuario (idrol, nombre, tipo_documento, num_documento, direccion, telefono, email, clave) values (@idrole, @name, @documenttype, @documentnumber, @address, @phone, @email, HASHBYTES('SHA2_256',@password));
go

-- Actualizar --
create proc user_update
@iduser integer,
@idrole integer,
@name varchar(100),
@documenttype varchar(20),
@documentnumber varchar(20),
@address varchar(70),
@phone varchar(20)
as
update usuario set idrol = @idrole, nombre = @name, tipo_documento = @documenttype, num_documento = @documentnumber, direccion = @address, telefono = @phone
where idusuario = @iduser;
go

-- Actualizar contraseña --
create proc user_update_password
@iduser integer,
@password varbinary(MAX)
as
update usuario set clave = HASHBYTES('SHA2_256',@password)
where idusuario = @iduser;
go

-- Actualizar email --
create proc user_update_email
@iduser integer,
@email varchar(50)
as
update usuario set email = @email
where idusuario = @iduser;
go


-- Eliminar --
create proc user_delete
@iduser integer
as
delete from usuario where idusuario = @iduser;
go

-- Desactivar --
create proc user_disable
@iduser integer
as
update usuario set estado = 0 where idusuario = @iduser;
go

-- Activar --
create proc user_enable
@iduser integer
as
update usuario set estado = 1 where idusuario = @iduser;
go

-- User Login --
create proc user_login
@email varchar(50),
@password varbinary(MAX)
as
select u.idusuario as ID, u.idrol as IDRole, r.nombre as Role, u.nombre as Name, u.estado as State
from usuario u inner join rol r on u.idrol = r.idrol
where u.email = @email and u.clave = HASHBYTES('SHA2_256',@password) and u.estado = 1;
go


-- El mismo CRUD pero de Ingreso--

-- Listar --
create proc income_list
as
select i.idingreso as ID, i.idproveedor as IDProvider, p.nombre as Provider, i.idusuario as IDUser, u.nombre as "User", i.tipo_comprobante as VoucherType, i.serie_comprobante as VoucherSerie, i.num_comprobante as VoucherNumber, i.fecha as Date, i.impuesto as Tax, i.total as Total, i.estado as State
from ingreso i inner join persona p on i.idproveedor = p.idpersona inner join usuario u on i.idusuario = u.idusuario
order by i.idingreso desc;
go

-- Buscar --
create proc income_search
@text varchar(50)
as
select i.idingreso as ID, i.idproveedor as IDProvider, p.nombre as Provider, i.idusuario as IDUser, u.nombre as "User", i.tipo_comprobante as VoucherType, i.serie_comprobante as VoucherSerie, i.num_comprobante as VoucherNumber, i.fecha as Date, i.impuesto as Tax, i.total as Total, i.estado as State
from ingreso i inner join persona p on i.idproveedor = p.idpersona inner join usuario u on i.idusuario = u.idusuario
where i.num_comprobante like '%' + @text + '%' or p.nombre like '%' + @text + '%'
order by i.idingreso desc;
go

-- Insertar --
create proc income_insert
@idprovider integer,
@iduser integer,
@vouchertype varchar(20),
@voucherserie varchar(7),
@vouchernumber varchar(10),
@date datetime,
@tax decimal(4,2),
@total decimal(11,2),
@state varchar(20)
as
insert into ingreso (idproveedor, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (@idprovider, @iduser, @vouchertype, @voucherserie, @vouchernumber, @date, @tax, @total, @state);
go

-- Actualizar --
create proc income_update
@idincome integer,
@idprovider integer,
@iduser integer,
@vouchertype varchar(20),
@voucherserie varchar(7),
@vouchernumber varchar(10),
@date datetime,
@tax decimal(4,2),
@total decimal(11,2),
@state varchar(20)
as
update ingreso set idproveedor = @idprovider, idusuario = @iduser, tipo_comprobante = @vouchertype, serie_comprobante = @voucherserie, num_comprobante = @vouchernumber, fecha = @date, impuesto = @tax, total = @total, estado = @state
where idingreso = @idincome;
go

-- Eliminar --
create proc income_delete
@idincome integer
as
delete from ingreso where idingreso = @idincome;
go

-- Cambiar estado de un ingreso --
create proc income_change_state
@idincome integer,
@state varchar(20)
as
update ingreso set estado = @state where idingreso = @idincome;
go




-- El mismo CRUD pero de Detalle de Ingreso--

-- Listar --
create proc income_detail_list
@idincome integer
as
select di.iddetalle_ingreso as ID, di.idingreso as IDIncome, di.idarticulo as IDArticle, a.nombre as Article, di.cantidad as Quantity, di.precio as Price
from detalle_ingreso di inner join articulo a on di.idarticulo = a.idarticulo
where di.idingreso = @idincome
order by di.iddetalle_ingreso desc;
go

-- Insertar --
create proc income_detail_insert
@idincome integer,
@idarticle integer,
@quantity integer,
@price decimal(11,2)
as
insert into detalle_ingreso (idingreso, idarticulo, cantidad, precio) values (@idincome, @idarticle, @quantity, @price);
go

-- Actualizar --
create proc income_detail_update
@iddetailincome integer,
@idincome integer,
@idarticle integer,
@quantity integer,
@price decimal(11,2)
as
update detalle_ingreso set idingreso = @idincome, idarticulo = @idarticle, cantidad = @quantity, precio = @price
where iddetalle_ingreso = @iddetailincome;
go

-- Eliminar --
create proc income_detail_delete
@iddetailincome integer
as
delete from detalle_ingreso where iddetalle_ingreso = @iddetailincome;
go

-- Eliminar todos los detalles de un ingreso --
create proc income_detail_delete_all
@idincome integer
as
delete from detalle_ingreso where idingreso = @idincome;
go

-- Listar los artículos que se encuentran en el inventario --
create proc income_detail_list_article
as
select a.idarticulo as ID, a.idcategoria as IDCategory, c.nombre as Category, a.codigo as Code, a.nombre as Name, a.precio_venta as Price, a.stock as Stock, a.descripcion as Description, a.imagen as Image, a.estado as State
from articulo a inner join categoria c on a.idcategoria = c.idcategoria
where a.stock > 0
order by a.idarticulo desc;
go



-- El mismo CRUD pero de Venta--

-- Listar --
create proc sale_list
as
select v.idventa as ID, v.idcliente as IDClient, p.nombre as Client, v.idusuario as IDUser, u.nombre as "User", v.tipo_comprobante as VoucherType, v.serie_comprobante as VoucherSerie, v.num_comprobante as VoucherNumber, v.fecha as Date, v.impuesto as Tax, v.total as Total, v.estado as State
from venta v inner join persona p on v.idcliente = p.idpersona inner join usuario u on v.idusuario = u.idusuario
order by v.idventa desc;
go

-- Buscar --
create proc sale_search
@text varchar(50)
as
select v.idventa as ID, v.idcliente as IDClient, p.nombre as Client, v.idusuario as IDUser, u.nombre as "User", v.tipo_comprobante as VoucherType, v.serie_comprobante as VoucherSerie, v.num_comprobante as VoucherNumber, v.fecha as Date, v.impuesto as Tax, v.total as Total, v.estado as State
from venta v inner join persona p on v.idcliente = p.idpersona inner join usuario u on v.idusuario = u.idusuario
where v.num_comprobante like '%' + @text + '%' or p.nombre like '%' + @text + '%' or u.nombre like '%' + @text + '%'
order by v.idventa desc;
go

-- Insertar --
create proc sale_insert
@idclient integer,
@iduser integer,
@vouchertype varchar(20),
@voucherserie varchar(7),
@vouchernumber varchar(10),
@date datetime,
@tax decimal(4,2),
@total decimal(11,2),
@state varchar(20)
as
insert into venta (idcliente, idusuario, tipo_comprobante, serie_comprobante, num_comprobante, fecha, impuesto, total, estado) values (@idclient, @iduser, @vouchertype, @voucherserie, @vouchernumber, @date, @tax, @total, @state);
go

-- Actualizar --
create proc sale_update
@idsale integer,
@idclient integer,
@iduser integer,
@vouchertype varchar(20),
@voucherserie varchar(7),
@vouchernumber varchar(10),
@date datetime,
@tax decimal(4,2),
@total decimal(11,2),
@state varchar(20)
as
update venta set idcliente = @idclient, idusuario = @iduser, tipo_comprobante = @vouchertype, serie_comprobante = @voucherserie, num_comprobante = @vouchernumber, fecha = @date, impuesto = @tax, total = @total, estado = @state
where idventa = @idsale;
go

-- Eliminar --
create proc sale_delete
@idsale integer
as
delete from venta where idventa = @idsale;
go

-- Cambiar estado de una venta --
create proc sale_change_state
@idsale integer,
@state varchar(20)
as
update venta set estado = @state where idventa = @idsale;
go




-- El mismo CRUD pero de Detalle de Venta--

-- Listar --
create proc sale_detail_list
@idsale integer
as
select dv.iddetalle_venta as ID, dv.idventa as IDSale, dv.idarticulo as IDArticle, a.nombre as Article, dv.cantidad as Quantity, dv.precio as Price, dv.descuento as Discount
from detalle_venta dv inner join articulo a on dv.idarticulo = a.idarticulo
where dv.idventa = @idsale
order by dv.iddetalle_venta desc;
go

-- Insertar --
create proc sale_detail_insert
@idsale integer,
@idarticle integer,
@quantity integer,
@price decimal(11,2),
@discount decimal(11,2)
as
insert into detalle_venta (idventa, idarticulo, cantidad, precio, descuento) values (@idsale, @idarticle, @quantity, @price, @discount);
go

-- Actualizar --
create proc sale_detail_update
@iddetailsale integer,
@idsale integer,
@idarticle integer,
@quantity integer,
@price decimal(11,2),
@discount decimal(11,2)
as
update detalle_venta set idventa = @idsale, idarticulo = @idarticle, cantidad = @quantity, precio = @price, descuento = @discount
where iddetalle_venta = @iddetailsale;
go

-- Eliminar --
create proc sale_detail_delete
@iddetailsale integer
as
delete from detalle_venta where iddetalle_venta = @iddetailsale;
go

-- Eliminar todos los detalles de una venta --
create proc sale_detail_delete_all
@idsale integer
as
delete from detalle_venta where idventa = @idsale;
go

-- Listar los artículos que se encuentran en el inventario --
create proc sale_detail_list_article
as
select a.idarticulo as ID, a.idcategoria as IDCategory, c.nombre as Category, a.codigo as Code, a.nombre as Name, a.precio_venta as Price, a.stock as Stock, a.descripcion as Description, a.imagen as Image, a.estado as State
from articulo a inner join categoria c on a.idcategoria = c.idcategoria
where a.stock > 0
order by a.idarticulo desc;
go


-- Listar los artículos que se encuentran en el inventario y que su nombre contenga el texto que se le pasa como parámetro --
create proc sale_detail_list_article_text
@text varchar(50)
as
select a.idarticulo as ID, a.idcategoria as IDCategory, c.nombre as Category, a.codigo as Code, a.nombre as Name, a.precio_venta as Price, a.stock as Stock, a.descripcion as Description, a.imagen as Image, a.estado as State
from articulo a inner join categoria c on a.idcategoria = c.idcategoria
where a.stock > 0 and a.nombre like '%' + @text + '%'
order by a.idarticulo desc;
go


-- Aca la lista completa de cada procedimiento almacenado segun cada entidad y los parametros que solicita de hacerlo --
/*
Categoria:
	category_list
	category_search (name)
	category_insert (name, description)
	category_update (idcategory, name, description)
	category_delete (idcategory)
	category_disable (idcategory)
	category_enable (idcategory)

Articulo:
	article_list
	article_search (name)
	article_insert (idcategory, code, name, price, stock, description, image)
	article_update (idarticle, idcategory, code, name, price, stock, description, image)
	article_delete (idarticle)
	article_disable (idarticle)
	article_enable (idarticle)

Persona:
	person_list
	person_search (name)
	person_insert (type, name, documenttype, documentnumber, address, phone, email)
	person_update (idperson, type, name, documenttype, documentnumber, address, phone, email)
	person_delete (idperson)
	person_disable (idperson)
	person_enable (idperson)

Rol:
	role_list
	role_search (name)
	role_insert (name, description)
	role_update (idrole, name, description)
	role_delete (idrole)
	role_disable (idrole)
	role_enable (idrole)

Usuario:
	user_list
	user_search (name)
	user_insert (idrole, name, documenttype, documentnumber, address, phone, email, password)
	user_update (iduser, idrole, name, documenttype, documentnumber, address, phone, password)
	user_delete (iduser)
	user_disable (iduser)
	user_enable (iduser)

Ingreso:
	income_list
	income_search (text)
	income_insert (idprovider, iduser, vouchertype, voucherserie, vouchernumber, date, tax, total, state)
	income_update (idincome, idprovider, iduser, vouchertype, voucherserie, vouchernumber, date, tax, total, state)
	income_delete (idincome)
	income_change_state (idincome, state)

Detalle de Ingreso:
	income_detail_list (idincome)
	income_detail_insert (idincome, idarticle, quantity, price)
	income_detail_update (iddetailincome, idincome, idarticle, quantity, price)
	income_detail_delete (iddetailincome)
	income_detail_delete_all (idincome)
	income_detail_list_article

Venta:
	sale_list
	sale_search (text)
	sale_insert (idclient, iduser, vouchertype, voucherserie, vouchernumber, date, tax, total, state)
	sale_update (idsale, idclient, iduser, vouchertype, voucherserie, vouchernumber, date, tax, total, state)
	sale_delete (idsale)
	sale_change_state (idsale, state)

Detalle de Venta:
	sale_detail_list (idsale)
	sale_detail_insert (idsale, idarticle, quantity, price, discount)
	sale_detail_update (iddetailsale, idsale, idarticle, quantity, price, discount)
	sale_detail_delete (iddetailsale)
	sale_detail_delete_all (idsale)
	sale_detail_list_article
	sale_detail_list_article_text (text)
*/