USE [possa]
GO

/****** Object:  Table [dbo].[tbl_POSException]    Script Date: 8/6/2016 1:21:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_POSException](
	[POSExceptionID] [int] IDENTITY(1,1) NOT NULL,
	[ExceptionType] [varchar](300) NULL,
	[ExceptionModule] [varchar](300) NULL,
	[ExceptionCode] [varchar](300) NULL,
	[Source] [varchar](300) NULL,
	[Message] [varchar](max) NULL,
	[QueryString] [varchar](max) NULL,
	[TargetSite] [varchar](max) NULL,
	[StrackTrace] [varchar](max) NULL,
	[ServerName] [varchar](max) NULL,
	[UserAgent] [varchar](300) NULL,
	[UserIP] [varchar](300) NULL,
	[UserAuthentication] [varchar](300) NULL,
	[UserName] [varchar](300) NULL,
	[RequestUrl] [varchar](max) NULL,
	[InvoiceID] [int] NULL,
	[RowCreatedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_POSException] PRIMARY KEY CLUSTERED 
(
	[POSExceptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


