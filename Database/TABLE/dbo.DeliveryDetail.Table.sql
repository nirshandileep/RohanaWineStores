USE [WineStore]
GO
/****** Object:  Table [dbo].[DeliveryDetail]    Script Date: 11/28/2016 9:49:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryDetail](
	[DeliveryId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Qty] [decimal](18, 3) NOT NULL,
 CONSTRAINT [PK_DeliveryDetail] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
