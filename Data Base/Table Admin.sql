USE [Grifindo_Leave_System]
GO

/****** Object:  Table [dbo].[Admin_Details]    Script Date: 12/13/2024 9:19:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Admin_Details](
	[Admin_ID] [varchar](20) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Date_of_Birth] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone_Number] [int] NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Department] [varchar](50) NULL,
 CONSTRAINT [PK_Admin_Details] PRIMARY KEY CLUSTERED 
(
	[Admin_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


