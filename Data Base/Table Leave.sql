USE [Grifindo_Leave_System]
GO

/****** Object:  Table [dbo].[tblLeave]    Script Date: 12/13/2024 9:23:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLeave](
	[LeaveID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [varchar](50) NOT NULL,
	[LeaveType] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[TimeSlot] [varchar](20) NULL,
	[Reason] [varchar](255) NULL,
	[Status] [varchar](20) NULL,
	[AdminComment] [varchar](255) NULL,
	[AppliedDate] [datetime] NULL,
 CONSTRAINT [PK_tblLeave] PRIMARY KEY CLUSTERED 
(
	[LeaveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblLeave] ADD  CONSTRAINT [DF_tblLeave_Status]  DEFAULT ('Pending') FOR [Status]
GO

ALTER TABLE [dbo].[tblLeave] ADD  DEFAULT (getdate()) FOR [AppliedDate]
GO

ALTER TABLE [dbo].[tblLeave]  WITH CHECK ADD  CONSTRAINT [FK_tblLeave_Add_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Add_Employee] ([Employee_ID])
GO

ALTER TABLE [dbo].[tblLeave] CHECK CONSTRAINT [FK_tblLeave_Add_Employee]
GO


