CREATE PROCEDURE InsertarMeteoritos
	@nombre varchar,
	@diametro float,
	@fecha varchar,
	@velocidad varchar,
	@planeta varchar
AS
	insert into dbo.Meteoro(nombre,diametro,fecha,velocidad,planeta)
	Values(@nombre, @diametro, @fecha, @velocidad, @planeta) 
RETURN 
