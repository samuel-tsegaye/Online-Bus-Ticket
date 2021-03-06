USE [bus]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin](
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OFF_INFO2]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OFF_INFO2](
	[id] [int] NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Phone] [int] NULL,
	[Email] [varchar](60) NULL,
 CONSTRAINT [PK_OFF_INFO2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DRI_INFO]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DRI_INFO](
	[id] [int] NOT NULL,
	[firsname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[plate] [varchar](50) NULL,
 CONSTRAINT [PK_DRI_INFO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ticket1]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ticket1](
	[Ticket_No] [int] NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[departure] [varchar](50) NULL,
	[arrival] [varchar](50) NULL,
	[car_plate] [varchar](50) NULL,
	[price] [varchar](50) NULL,
 CONSTRAINT [PK_ticket1] PRIMARY KEY CLUSTERED 
(
	[Ticket_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SCHE_SCH1]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[SCHE_SCH1](
	[Id] [varchar](50) NOT NULL,
	[Date] [varchar](50) NULL,
	[Station] [varchar](50) NULL,
	[Car_plate] [varchar](50) NULL,
	[Distance] [varchar](50) NULL,
	[Depature] [varchar](50) NULL,
	[Arrival] [varchar](50) NULL,
	[Time] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
 CONSTRAINT [PK_SCHE_SCH1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_info]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_info](
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [int] NOT NULL,
	[City] [varchar](50) NULL,
 CONSTRAINT [PK_User_info] PRIMARY KEY CLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_acc1]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_acc1](
	[Phone] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User_acc1] PRIMARY KEY CLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[offacc2]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[offacc2](
	[Id] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_offacc2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dri_acc1]    Script Date: 06/16/2022 21:35:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dri_acc1](
	[id] [int] NOT NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_dri_acc1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_dri_acc1_DRI_INFO]    Script Date: 06/16/2022 21:35:44 ******/
ALTER TABLE [dbo].[dri_acc1]  WITH CHECK ADD  CONSTRAINT [FK_dri_acc1_DRI_INFO] FOREIGN KEY([id])
REFERENCES [dbo].[DRI_INFO] ([id])
GO
ALTER TABLE [dbo].[dri_acc1] CHECK CONSTRAINT [FK_dri_acc1_DRI_INFO]
GO
/****** Object:  ForeignKey [FK_offacc2_OFF_INFO2]    Script Date: 06/16/2022 21:35:44 ******/
ALTER TABLE [dbo].[offacc2]  WITH CHECK ADD  CONSTRAINT [FK_offacc2_OFF_INFO2] FOREIGN KEY([Id])
REFERENCES [dbo].[OFF_INFO2] ([id])
GO
ALTER TABLE [dbo].[offacc2] CHECK CONSTRAINT [FK_offacc2_OFF_INFO2]
GO
/****** Object:  ForeignKey [FK_SCHE_SCH_SCHE_SCH1]    Script Date: 06/16/2022 21:35:44 ******/
ALTER TABLE [dbo].[SCHE_SCH1]  WITH CHECK ADD  CONSTRAINT [FK_SCHE_SCH_SCHE_SCH1] FOREIGN KEY([Id])
REFERENCES [dbo].[SCHE_SCH1] ([Id])
GO
ALTER TABLE [dbo].[SCHE_SCH1] CHECK CONSTRAINT [FK_SCHE_SCH_SCHE_SCH1]
GO
/****** Object:  ForeignKey [FK_User_acc1_User_info]    Script Date: 06/16/2022 21:35:44 ******/
ALTER TABLE [dbo].[User_acc1]  WITH CHECK ADD  CONSTRAINT [FK_User_acc1_User_info] FOREIGN KEY([Phone])
REFERENCES [dbo].[User_info] ([Phone])
GO
ALTER TABLE [dbo].[User_acc1] CHECK CONSTRAINT [FK_User_acc1_User_info]
GO
