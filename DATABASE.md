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



- Tabla [updateAlmacen]
    1. [create procedure updateAlmacen(@id int, @Estado varchar(50), @Descripcion varchar(50)) AS
begin 
    update Almacen
    set Estado = @Estado, Descripcion = @Descripcion
    where IdAlmacen = @id
end
]

    2. Los datos que se actualizan son: [los datos]



- Tabla [deleteAlmacen]
    1. [create procedure deleteAlmacen(@id int) as
begin 
	delete from Almacen
	where IdAlmacen = @id
end]

    2. Los datos que se actualizan son: [los datos]




# Articulos

- Tabla [createArticulos]
    1. [create procedure createArticulos(
	@idArticulo int,
	@Descripcion varchar(50),
	@Existencia int,
	@IdInventario int,
	@CostoUnit decimal,
	@Estado varchar(50)
)

as

begin 
	insert into Articulos(Descripcion, Existencia, IdInventario, CostoUnit, Estado)
	values(@Descripcion, @Existencia, @IdInventario, @CostoUnit, @Estado)
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [readArticulos]
    1. [create procedure readArticulos(@idArticulo int)
as

begin 
	select * from Articulos
	where IdArticulo = @idArticulo;
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [updateArticulos]
    1. [create procedure updateArticulos(
	@idArticulo int,
	@Descripcion varchar(50),
	@Existencia int,
	@IdInventario int,
	@CostoUnit decimal,
	@Estado varchar(50)
)

as

begin 
	update Articulos
	set Descripcion = @Descripcion, Existencia = @Existencia, IdInventario = @IdInventario, CostoUnit = @CostoUnit, Estado = @Estado
	where IdArticulo = @idArticulo;
end]

    2. Los datos que se actualizan son: [los datos]


- Tabla [deleteArticulos]
    1. [create procedure deleteArticulos(@idArticulo int)
as

begin 
	delete from Articulos
	where IdArticulo = @idArticulo;
end]

    2. Los datos que se actualizan son: [los datos]




# PreguntasSeguridad

- Tabla [createPreguntasSeguridad]
    1. [create procedure createPreguntasSeguridad(
	@IdPreguntaSeguridad int,
	@DescripcionPregunta varchar(50)
)

as

begin 
	insert into PreguntasSeguridad(DescripcionPregunta)
	values(@DescripcionPregunta);
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [readPreguntasSeguridad]
    1. [create procedure readPreguntasSeguridad(
	@IdPreguntaSeguridad int,
	@DescripcionPregunta varchar(50)
)

as

begin 
	select * from PreguntasSeguridad 
	where IdPreguntaSeguridad = @IdPreguntaSeguridad;
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [updatePreguntasSeguridad]
    1. [create procedure updatePreguntasSeguridad(
	@IdPreguntaSeguridad int,
	@DescripcionPregunta varchar(50)
)

as

begin 
	update PreguntasSeguridad 
	set DescripcionPregunta = @DescripcionPregunta;
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [deletePreguntasSeguridad]
    1. [create procedure deletePreguntasSeguridad(
	@IdPreguntaSeguridad int,
	@DescripcionPregunta varchar(50)
)

as

begin 
	delete from PreguntasSeguridad
	where IdPreguntaSeguridad = @IdPreguntaSeguridad
end]

    2. Los datos que se actualizan son: [los datos]



# TiposInventario

- Tabla [createTipoInventario]
    1. [create procedure createTipoInventario(
	@IdInventario int,
	@Descripcion varchar(50),
	@CuentaContable varchar(50),
	@Estado varchar(50)
)

as

begin 
	insert into TiposInventario(Descripcion, CuentaContable, Estado)
	values(@Descripcion, @CuentaContable, @Estado);
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [readTipoInventario]
    1. [create procedure readTipoInventario(
	@IdInventario int,
	@Descripcion varchar(50),
	@CuentaContable varchar(50),
	@Estado varchar(50)
)

as

begin 
	select * from TiposInventario
	where IdInventario = @IdInventario;
end]

    2. Los datos que se actualizan son: [los datos]


- Tabla [updateTipoInventario]
    1. [create procedure updateTipoInventario(
	@IdInventario int,
	@Descripcion varchar(50),
	@CuentaContable varchar(50),
	@Estado varchar(50)
)

as

begin 
	update TiposInventario
	set Descripcion = @Descripcion, CuentaContable = @CuentaContable, Estado = @Estado;
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [deleteTipoInventario]
    1. [create procedure deleteTipoInventario(
	@IdInventario int,
	@Descripcion varchar(50),
	@CuentaContable varchar(50),
	@Estado varchar(50)
)

as

begin 
	delete from TiposInventario
	where IdInventario = @IdInventario;
end]

    2. Los datos que se actualizan son: [los datos]



#  Transacciones

- Tabla [createTransacciones]
    1. [create procedure createTransacciones(
	@IdTransaccion int,
	@IdTipoTransaccion int,
	@IdArticulo int,
	@Fecha date,
	@Cantidad int,
	@Monto decimal
)

as

begin 
	insert into Transacciones(IdTipoTransaccion, IdArticulo, Fecha, Cantidad, Monto)
	values(@IdTipoTransaccion, @IdArticulo, @Fecha, @Cantidad, @Monto);
end]

    2. Los datos que se actualizan son: [los datos]



- Tabla [readTransacciones]
    1. [create procedure readTransacciones(
	@IdTransaccion int,
	@IdTipoTransaccion int,
	@IdArticulo int,
	@Fecha date,
	@Cantidad int,
	@Monto decimal
)

as

begin 
	select * from Transacciones
	where IdTransaccion = @IdTransaccion;
end]

    2. Los datos que se actualizan son: [los datos]


- Tabla [updateTransacciones]
    1. [create procedure updateTransacciones(
	@IdTransaccion int,
	@IdTipoTransaccion int,
	@IdArticulo int,
	@Fecha date,
	@Cantidad int,
	@Monto decimal
)

as

begin 
	update Transacciones
	set IdTipoTransaccion = @IdTipoTransaccion, IdArticulo = @IdArticulo, Fecha = @Fecha, Cantidad = @Cantidad, Monto = @Monto
end]

    2. Los datos que se actualizan son: [los datos]


- Tabla [deleteTransacciones]
    1. [create procedure deleteTransacciones(
	@IdTransaccion int,
	@IdTipoTransaccion int,
	@IdArticulo int,
	@Fecha date,
	@Cantidad int,
	@Monto decimal
)

as

begin 
	delete from Transacciones
	where IdTransaccion = @IdTransaccion;
end]

    2. Los datos que se actualizan son: [los datos]



# Usuarios

- Tabla [createUsuarios]
    1. [create procedure createUsuarios(
	@IdUsuario int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@IdPreguntaSeguridad int,
	@RespuestaSeguridad varchar(50),
	@Contraseña varchar(50),
	@FechaCreacion date
)

as

begin 
	insert into Usuarios(Nombre, Apellido, IdPreguntaSeguridad, RespuestaSeguridad, Contraseña, FechaCreacion)
	values(@Nombre, @Apellido, @IdPreguntaSeguridad, @RespuestaSeguridad, @Contraseña, @FechaCreacion)
end]

    2. Los datos que se actualizan son: [los datos]




- Tabla [readTUsuarios]
    1. [create procedure readUsuarios(
	@IdUsuario int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@IdPreguntaSeguridad int,
	@RespuestaSeguridad varchar(50),
	@Contraseña varchar(50),
	@FechaCreacion date
)

as

begin 
	select * from Usuarios
	where IdUsuario = @IdUsuario;
end]

    2. Los datos que se actualizan son: [los datos]




- Tabla [updateUsuarios]
    1. [create procedure updateUsuarios(
	@IdUsuario int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@IdPreguntaSeguridad int,
	@RespuestaSeguridad varchar(50),
	@Contraseña varchar(50),
	@FechaCreacion date
)

as

begin 
	update Usuarios
	set Nombre = @Nombre, Apellido = @Apellido, IdPreguntaSeguridad = @IdPreguntaSeguridad, RespuestaSeguridad = @RespuestaSeguridad, 
	Contraseña = @Contraseña, FechaCreacion = @FechaCreacion;
end]

    2. Los datos que se actualizan son: [los datos]




- Tabla [deleteUsuarios]
    1. [create procedure deleteUsuarios(
	@IdUsuario int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@IdPreguntaSeguridad int,
	@RespuestaSeguridad varchar(50),
	@Contraseña varchar(50),
	@FechaCreacion date
)

as

begin 
	delete from Usuarios where IdPreguntaSeguridad = @IdPreguntaSeguridad;
end]

    2. Los datos que se actualizan son: [los datos]