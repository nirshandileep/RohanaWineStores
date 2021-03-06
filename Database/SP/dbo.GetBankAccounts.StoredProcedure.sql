USE [WineStore]
GO
/****** Object:  StoredProcedure [dbo].[GetBankAccounts]    Script Date: 11/28/2016 9:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBankAccounts]
@BankAccountId AS INT
AS
BEGIN
	
	SELECT [AccountId]
	  ,[AccountNo]
	  ,[Description]
	  ,[CurrentBalance]
      ,[CreatedUser]
      ,[CreatedDate]
  FROM [dbo].[BankAccount] A
  WHERE A.[AccountId] = CASE WHEN @BankAccountId = 0 THEN A.[AccountId] ELSE @BankAccountId END

END
GO
