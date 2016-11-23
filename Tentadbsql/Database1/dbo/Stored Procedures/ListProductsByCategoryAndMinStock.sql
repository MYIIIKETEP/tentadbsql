-- =============================================
-- Author:		Dr Smoak
-- Create date: 2016-11-21
-- Description:	
-- =============================================
CREATE PROCEDURE ListProductsByCategoryAndMinStock 
	-- Add the parameters for the stored procedure here
	@CategoryID int = 0, 
	@MinimumInStock smallint = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from SupplierProductView
	Where CategoryID=@CategoryID and UnitsinStock>=@MinimumInStock

END
