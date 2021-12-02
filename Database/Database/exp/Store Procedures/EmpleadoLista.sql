CREATE PROCEDURE [exp].[EmpleadoLista]
    
AS
BEGIN
  SET NOCOUNT ON

  SELECT 
   IdEmpleado,
   Identificacion

    FROM EXP.Empleado 
   

END
