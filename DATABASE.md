# STORE PROCEDURES

# ALMACEN

- Tabla [createAlmacen]
    1. [create procedure createAlmacen(@id int, @Descripcion varchar(50), @Estado varchar(50)) as
begin 
	insert into Almacen(Descripcion, Estado)
	values(@Descripcion, @Estado)
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [readAlmacen]
    1. [create procedure readAlmacen(@id int) as
begin 
	select * from Almacen
	where IdAlmacen = @id
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [deleteAlmacen]
    1. [create procedure deleteAlmacen(@id int) as
begin 
	delete from Almacen
	where IdAlmacen = @id
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [updateAlmacen]
    1. [create procedure updateAlmacen(@id int, @Estado varchar(50), @Descripcion varchar(50)) AS
    begin 
        update Almacen
        set Estado = @Estado, Descripcion = @Descripcion
        where IdAlmacen = @id
    end;]

    2. Los datos que se actualizan son: [los datos]


