USE [Grifindo_Leave_System]
GO

/****** Object:  Table [dbo].[tblEmployeeLeave]    Script Date: 12/13/2024 9:22:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEmployeeLeave](
	[LeaveTypeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [varchar](50) NOT NULL,
	[AnnualLeave] [int] NOT NULL,
	[CasualLeave] [int] NOT NULL,
	[ShortLeave] [int] NOT NULL,
	[AppliedDate] [date] NULL,
	[OffDay] [varchar](50) NULL,
	[HalfDayLeave] [int] NULL,
 CONSTRAINT [PK_tblEmployeeLeave] PRIMARY KEY CLUSTERED 
(
	[LeaveTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblEmployeeLeave] ADD  DEFAULT (getdate()) FOR [AppliedDate]
GO

ALTER TABLE [dbo].[tblEmployeeLeave]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployeeLeave_Add_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Add_Employee] ([Employee_ID])
GO

ALTER TABLE [dbo].[tblEmployeeLeave] CHECK CONSTRAINT [FK_tblEmployeeLeave_Add_Employee]
GO


