# STORE PROCEDURES

- Tabla [NOMBRE DE LA TABLA]
    1. [Consulta]
    2. Los datos que se actualizan son: [los datos]


create procedure updateAlmacen(
	@id int,
	@Estado varchar(50),
	@Descripcion varchar(50)
)

as

begin 
	update Almacen
	set Estado = @Estado
	where IdAlmacen = @id
end