USE [WineStore]
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 11/28/2016 9:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSupplier]
@SupplierId AS INT,
@SupplierCode AS NVARCHAR(50),
@Name AS NVARCHAR(350),
@CurrentBalance AS DECIMAL(18,3),
@EmptyPurchaseBalance AS DECIMAL(18,3),
@DisplayOrder AS INT,
@CreatedUser AS INT
AS
BEGIN

	IF @SupplierId = 0
	BEGIN

		INSERT INTO [dbo].[Supplier]
			   ([SupplierCode]
			   ,[Name]
			   ,[CurrentBalance]
			   ,[EmptyPurchaseBalance]
			   ,[DisplayOrder]
			   ,[CreatedUser]
			   ,[CreatedDate])
		 VALUES
			   (@SupplierCode
				,@Name
				,@CurrentBalance
				,@EmptyPurchaseBalance
				,@DisplayOrder
			    ,@CreatedUser
			    ,GETDATE())
	END
	ELSE
	BEGIN

		UPDATE [dbo].[Supplier]
		   SET [SupplierCode] = @SupplierCode
			  ,[Name] = @Name
			  ,[CurrentBalance] = @CurrentBalance
			  ,[EmptyPurchaseBalance] = @EmptyPurchaseBalance
			  ,[DisplayOrder] = @DisplayOrder
		WHERE SupplierId = @SupplierId

	END

END
GO
