CREATE PROCEDURE [dbo].[TipoIdentificacionLista]
AS
	BEGIN
	SET NOCOUNT ON


	SELECT
	 IdTipoIdentificacion,
	 Descripcion
	FROM TipoIdentificacion


	END
