USE [WineStore]
GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 11/28/2016 9:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProducts]
@ProductId AS INT
AS
BEGIN
	
	SELECT [ProductId]
      ,[ProductCode]
      ,[ProductDesc]
      ,[SupplierId]
      ,[PurchasePrice]
      ,[SellingPrice]
      ,[Margin]
      ,[MinimumQty]
      ,[UomId]
      ,[DisplayOrder]
      ,[ProductType]
      ,[AllowSales]
      ,[IsActive]
      ,[CreatedUser]
      ,[CreatedDate]
  FROM [dbo].[Product] A
  WHERE A.ProductId = CASE WHEN @ProductId = 0 THEN A.ProductId ELSE @ProductId END

END
GO
