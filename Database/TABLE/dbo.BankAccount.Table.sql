USE [WineStore]
GO
/****** Object:  Table [dbo].[BankAccount]    Script Date: 11/28/2016 9:49:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankAccount](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[AccountNo] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[CurrentBalance] [decimal](18, 3) NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_BankAccount] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
