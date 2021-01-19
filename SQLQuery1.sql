CREATE TABLE [dbo].[user_info](
[userID] [int] IDENTITY(1,1) NOT NULL,
[name] [nvarchar](200) NULL,
[email] [nvarchar](200) NULL,
[password] [nvarchar](50) NULL,
CONSTRAINT [PK_user_info] PRIMARY KEY CLUSTERED
(
[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[user_info] ON
INSERT [dbo].[user_info] ([userID], [name], [email], [password]) VALUES (1, N'Micky Johnny', N'Miki@NYP.com',
N'123456')
INSERT [dbo].[user_info] ([userID], [name], [email], [password]) VALUES (2, N'Twee Wee', N'TweeWee@SP.com',
N'654321')
INSERT [dbo].[user_info] ([userID], [name], [email], [password]) VALUES (3, N'Gilbert Chan', N'babyG@NUS.com',
N'789123')
SET IDENTITY_INSERT [dbo].[user_info] OFF