USE [WineStore]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 11/28/2016 9:49:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[DeliveryId] [int] NOT NULL,
	[DeliveryNo] [nvarchar](50) NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[SupplierId] [int] NOT NULL,
	[RefOrderId] [int] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Delivery] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
