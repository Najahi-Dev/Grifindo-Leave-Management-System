USE [Grifindo_Leave_System]
GO

/****** Object:  Table [dbo].[tblRoster]    Script Date: 12/13/2024 9:24:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblRoster](
	[RosterID] [int] IDENTITY(1,1) NOT NULL,
	[Employee_ID] [varchar](50) NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
 CONSTRAINT [PK__tblRoste__D1F45DE89DD83404] PRIMARY KEY CLUSTERED 
(
	[RosterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblRoster]  WITH CHECK ADD  CONSTRAINT [FK_tblRoster_Add_Employee] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Add_Employee] ([Employee_ID])
GO

ALTER TABLE [dbo].[tblRoster] CHECK CONSTRAINT [FK_tblRoster_Add_Employee]
GO


