CREATE PROCEDURE [acc].[ContratoObtener]
      @IdContrato int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     C.IdContrato,
	 C.TipoContrato,
	 C.FechaInicio,
	 C.FechaFin,
     
     E.IdEmpleado,
     E.Identificacion,
     E.Nombre

    FROM Contrato C
    INNER JOIN exp.Empleado E
       ON E.IdEmpleado= C.IdEmpleado
    WHERE
    (@IdContrato IS NULL OR IdContrato=@IdContrato)

END