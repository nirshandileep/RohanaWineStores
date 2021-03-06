USE [WineStore]
GO
/****** Object:  StoredProcedure [dbo].[GetSuppliers]    Script Date: 11/28/2016 9:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSuppliers]
@SupplierId AS INT
AS
BEGIN
	
	SELECT [SupplierId]
      ,[SupplierCode]
      ,[Name]
      ,[CurrentBalance]
      ,[EmptyPurchaseBalance]
      ,[DisplayOrder]
      ,[CreatedUser]
      ,[CreatedDate]
  FROM [dbo].[Supplier] A
  WHERE A.[SupplierId] = CASE WHEN @SupplierId = 0 THEN A.[SupplierId] ELSE @SupplierId END

END
GO
