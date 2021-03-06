USE [WineStore]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/28/2016 9:49:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](50) NOT NULL,
	[ProductDesc] [nvarchar](250) NOT NULL,
	[SupplierId] [int] NOT NULL,
	[PurchasePrice] [decimal](18, 3) NOT NULL,
	[SellingPrice] [decimal](18, 3) NOT NULL,
	[Margin] [decimal](18, 3) NOT NULL,
	[MinimumQty] [decimal](18, 3) NOT NULL,
	[UomId] [smallint] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[ProductType] [tinyint] NOT NULL,
	[AllowSales] [tinyint] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_SupplierId]  DEFAULT ((0)) FOR [SupplierId]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_PurchasePrice]  DEFAULT ((0)) FOR [PurchasePrice]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_SellingPrice]  DEFAULT ((0)) FOR [SellingPrice]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Margin]  DEFAULT ((0)) FOR [Margin]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_MinimumQty]  DEFAULT ((0)) FOR [MinimumQty]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_UomId]  DEFAULT ((0)) FOR [UomId]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_DisplayOrder]  DEFAULT ((0)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_ProductType]  DEFAULT ((1)) FOR [ProductType]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_AllowSales]  DEFAULT ((1)) FOR [AllowSales]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1-Arrack, 2-Beer, 3-FL, 4-Other' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'ProductType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1-Sales Only, 2-Sales and Empty Sales, 3-Empty Sales only' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'AllowSales'
GO
