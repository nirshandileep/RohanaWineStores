USE [WineStore]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 11/28/2016 9:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProduct]
@ProductId AS INT,
@ProductCode AS NVARCHAR(50),
@ProductDesc AS NVARCHAR(250),
@SupplierId AS INT,
@PurchasePrice AS DECIMAL(18,3),
@SellingPrice AS DECIMAL(18,3),
@Margin AS DECIMAL(18,3),
@MinimumQty AS DECIMAL(18,3),
@UomId AS SMALLINT,
@DisplayOrder AS INT,
@ProductType AS TINYINT,
@AllowSales AS TINYINT,
@IsActive AS BIT,
@CreatedUser AS INT
AS
BEGIN

	IF @ProductId = 0
	BEGIN

		INSERT INTO [dbo].[Product]
			   ([ProductCode]
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
			   ,[CreatedDate])
		 VALUES
			   (@ProductCode
			   ,@ProductDesc
			   ,@SupplierId
			   ,@PurchasePrice
			   ,@SellingPrice
			   ,@Margin
			   ,@MinimumQty
			   ,@UomId
			   ,@DisplayOrder
			   ,@ProductType
			   ,@AllowSales
			   ,@IsActive
			   ,@CreatedUser
			   ,GETDATE())
	END
	ELSE
	BEGIN

		UPDATE [dbo].[Product]
		SET [ProductCode] = @ProductCode
			,[ProductDesc] = @ProductDesc
			,[SupplierId] = @SupplierId
			,[PurchasePrice] = @PurchasePrice
			,[SellingPrice] = @SellingPrice
			,[Margin] = @Margin
			,[MinimumQty] = @MinimumQty
			,[UomId] = @UomId
			,[DisplayOrder] = @DisplayOrder
			,[ProductType] = @ProductType
			,[AllowSales] = @AllowSales
			,[IsActive] = @IsActive
		WHERE [ProductId] = @ProductId

	END

END
GO
