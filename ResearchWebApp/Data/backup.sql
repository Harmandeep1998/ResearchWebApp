SET IDENTITY_INSERT [dbo].[Papers] ON 
GO
INSERT [dbo].[Papers] ([Id], [PaperName], [ISSN]) VALUES (1, N'International Journal of Management, IT & Engineering', N'2249-0558')
GO
INSERT [dbo].[Papers] ([Id], [PaperName], [ISSN]) VALUES (2, N'International Journal of Marketing and Technology', N'2249-1058')
GO
INSERT [dbo].[Papers] ([Id], [PaperName], [ISSN]) VALUES (3, N'International Journal of Physical and Social Sciences', N'2249-5894')
GO
INSERT [dbo].[Papers] ([Id], [PaperName], [ISSN]) VALUES (4, N'International Journal of Research in Social Sciences', N'2249-2496')
GO
SET IDENTITY_INSERT [dbo].[Papers] OFF
GO
SET IDENTITY_INSERT [dbo].[Fees] ON 
GO
INSERT [dbo].[Fees] ([Id], [Amount], [PaperID]) VALUES (1, 35, 1)
GO
INSERT [dbo].[Fees] ([Id], [Amount], [PaperID]) VALUES (2, 40, 2)
GO
INSERT [dbo].[Fees] ([Id], [Amount], [PaperID]) VALUES (3, 45, 3)
GO
INSERT [dbo].[Fees] ([Id], [Amount], [PaperID]) VALUES (4, 30, 4)
GO
SET IDENTITY_INSERT [dbo].[Fees] OFF
GO
SET IDENTITY_INSERT [dbo].[Issues] ON 
GO
INSERT [dbo].[Issues] ([Id], [MonthName], [Year], [Volume], [IssueNo], [Title], [Authors], [PageNo], [PaperID]) VALUES (1, N'September', 2021, 11, 9, N'Assessments of Growth of Micro and Small Enterprises (MSEs): A Review of Empirical Evidence from Ethiopia', N'Yohannis Bekele Kemiso', N'1-6', 1)
GO
INSERT [dbo].[Issues] ([Id], [MonthName], [Year], [Volume], [IssueNo], [Title], [Authors], [PageNo], [PaperID]) VALUES (2, N'September', 2021, 11, 9, N'SOCIO-ECONOMIC IMPACT OF COVID-19 AND LOCKDOWN IN KERALA', N'Dr. Laisa Thomas, Vidya Dinesh', N'7-18', 1)
GO
INSERT [dbo].[Issues] ([Id], [MonthName], [Year], [Volume], [IssueNo], [Title], [Authors], [PageNo], [PaperID]) VALUES (3, N'September', 2021, 11, 9, N'Financial Distress Analysis Using Altman Z-Score Method in Trading, Service and Investment Companies in the Restaurant, Hotel and Tourism Sub-Sectors in Indonesia', N'Sweetly Mumu', N'19-30', 1)
GO
SET IDENTITY_INSERT [dbo].[Issues] OFF
GO
SET IDENTITY_INSERT [dbo].[EditorialBoards] ON 
GO
INSERT [dbo].[EditorialBoards] ([Id], [PaperName], [Title], [Description]) VALUES (1, N'DR HARSH SADAWARTI', N'Patron', N'PROFESSOR & DIRECTOR RIMT-Institute of Engineering & Technology MANDI GOBINDGARH PUNJAB-INDIA')
GO
INSERT [dbo].[EditorialBoards] ([Id], [PaperName], [Title], [Description]) VALUES (2, N'PROF. (DR) ROSHAN LAL', N'Editors', N'Professor and Head Ganpati Business School Bilaspur Haryana (INDIA)')
GO
INSERT [dbo].[EditorialBoards] ([Id], [PaperName], [Title], [Description]) VALUES (3, N'Dr. Vikas Arora', N'Editors', N'Director-Integrated Campus SUNSHINE Group of Institutions Rajkot-360005(Gujarat) Haryana (INDIA)')
GO
INSERT [dbo].[EditorialBoards] ([Id], [PaperName], [Title], [Description]) VALUES (4, N'P. MADHU SUDANA RAO', N'Editorial Advisory Board', N'Professor College Of Business and Economics Mekelle University ETHIOPIA.')
GO
INSERT [dbo].[EditorialBoards] ([Id], [PaperName], [Title], [Description]) VALUES (5, N'DR.M.LATHANATRAJAN', N'Editorial Advisory Board', N'Prof & HOD /MBA Vivekanandha College of Engineering for women Thiruchengode. 637205')
GO
SET IDENTITY_INSERT [dbo].[EditorialBoards] OFF
GO
