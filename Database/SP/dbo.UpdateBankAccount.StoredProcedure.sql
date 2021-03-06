USE [WineStore]
GO
/****** Object:  StoredProcedure [dbo].[UpdateBankAccount]    Script Date: 11/28/2016 9:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBankAccount]
@AccountId AS INT,
@AccountNo AS NVARCHAR(50),
@Description AS NVARCHAR(150),
@CurrentBalance AS DECIMAL(18,3),
@CreatedUser AS INT
AS
BEGIN

	IF @AccountId = 0
	BEGIN

		INSERT INTO [dbo].[BankAccount]
			   ([AccountNo]
			   ,[Description]
			   ,[CurrentBalance]
			   ,[CreatedUser]
			   ,[CreatedDate])
		 VALUES
			   (@AccountNo
				,@Description
				,@CurrentBalance
			    ,@CreatedUser
			    ,GETDATE())
	END
	ELSE
	BEGIN

		UPDATE [dbo].[BankAccount]
		   SET [AccountNo] = @AccountNo
			  ,[Description] = @Description
			  ,[CurrentBalance] = @CurrentBalance
		 WHERE [AccountId] = @AccountId

	END

END
GO
