CREATE DATABASE [Grifindo_Leave_System]
GO

/****** Object:  Table [dbo].[Add_Employee]    Script Date: 12/13/2024 9:17:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Add_Employee](
	[Employee_ID] [varchar](50) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Date_of_Birth] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone_Number] [int] NOT NULL,
	[Password] [int] NOT NULL,
	[Employee_Status] [varchar](50) NOT NULL,
	[Date_of_Joining] [date] NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Job_Title] [varchar](50) NOT NULL,
	[Department] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Add_Employee] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


