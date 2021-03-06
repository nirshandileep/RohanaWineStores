USE [WineStore]
GO
/****** Object:  Table [dbo].[EmptyCategory]    Script Date: 11/28/2016 9:49:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmptyCategory](
	[CatogoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryCode] [nvarchar](50) NOT NULL,
	[AllowAdjustment] [bit] NOT NULL,
	[AllowSales] [bit] NOT NULL,
	[AllowPurchase] [bit] NOT NULL,
	[PurchasePrice] [decimal](18, 3) NOT NULL,
	[SellingPrice] [decimal](18, 3) NOT NULL,
	[CompanyPrice] [decimal](18, 3) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_EmptyCategory] PRIMARY KEY CLUSTERED 
(
	[CatogoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
