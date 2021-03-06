USE [WineStore]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/28/2016 9:49:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierCode] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](350) NOT NULL,
	[CurrentBalance] [decimal](18, 3) NOT NULL,
	[EmptyPurchaseBalance] [decimal](18, 3) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_CurrentBalance]  DEFAULT ((0)) FOR [CurrentBalance]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_EmptyPurchaseBalance]  DEFAULT ((0)) FOR [EmptyPurchaseBalance]
GO
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_DisplayOrder]  DEFAULT ((0)) FOR [DisplayOrder]
GO
