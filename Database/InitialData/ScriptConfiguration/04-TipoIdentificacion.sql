DROP TABLE IF EXISTS #TipoIdentificacionTemp

SELECT 
IdTipoIdentificacion, Descripcion INTO #TipoIdentificacionTemp
FROM (
VALUES
(1, 'CEDULA RESIDENCIA'),
(2, 'CÉDULA'),
(3, 'DIMEX'),
(4, 'PASAPORTE'),
(5, 'CEDULA JURIDICA'),
(6, 'CEDULA EXTRANJERA'),
(7, 'CARNE REFUGIADO')
)AS TEMP (IdTipoIdentificacion, Descripcion)


----ACTUALIZAR DATOS---
UPDATE P SET
  P.Descripcion= TM.Descripcion
FROM Dbo.TipoIdentificacion P
INNER JOIN #TipoIdentificacionTemp TM
    ON P.IdTipoIdentificacion= TM.IdTipoIdentificacion


----INSERTAR DATOS---

SET IDENTITY_INSERT dbo.TipoIdentificacion ON

INSERT INTO dbo.TipoIdentificacion(
IdTipoIdentificacion, Descripcion)
SELECT
IdTipoIdentificacion, Descripcion
FROM #TipoIdentificacionTemp


EXCEPT
SELECT
IdTipoIdentificacion, Descripcion
FROM dbo.TipoIdentificacion


SET IDENTITY_INSERT dbo.TipoIdentificacion OFF

GO