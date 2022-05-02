# STORE PROCEDURES

- Tabla [NOMBRE DE LA TABLA]
        1. [create procedure updateAlmacen(@id int, @Estado varchar(50), @Descripcion varchar(50)) AS
        begin 
            update Almacen
            set (Estado = @Estado), (Descripcion = @Descripcion)
            where IdAlmacen = @id
        end;]

        2. Los datos que se actualizan son: [los datos]


