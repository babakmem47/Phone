USE [Telephone]
GO
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([Id], [Name], [Gender], [TelDirect], [TelInternal], [Mobile], [WorkPlace], [FieldOfActivity], [SetadId], [Description]) VALUES (1, N'خانم نوری', 1, N'88724466', NULL, NULL, N'شرکت فراز پرداز', N'تجهیزات شبکه فروش', NULL, N'روتر  سوئیچ فایروال')
INSERT [dbo].[People] ([Id], [Name], [Gender], [TelDirect], [TelInternal], [Mobile], [WorkPlace], [FieldOfActivity], [SetadId], [Description]) VALUES (2, N'خداداد', 0, N'83869894', N'9894', N'09362191561', N'مبین نت', N'بستر وایمکس', NULL, N'TDLTE وایرلس')
INSERT [dbo].[People] ([Id], [Name], [Gender], [TelDirect], [TelInternal], [Mobile], [WorkPlace], [FieldOfActivity], [SetadId], [Description]) VALUES (3, N'امیرحسین حلبی ساز', 0, N'84433200', N'3200', N'09128996642', N'ساختمان نگین', N'کارمند قراردادی', 6, N'کابل کشی پسیو شبکه')
INSERT [dbo].[People] ([Id], [Name], [Gender], [TelDirect], [TelInternal], [Mobile], [WorkPlace], [FieldOfActivity], [SetadId], [Description]) VALUES (4, N'دربندی', 0, NULL, NULL, NULL, N'ساختمان کالج', N'کارمند رسمی', 11, N'عملیات آی تی')
SET IDENTITY_INSERT [dbo].[People] OFF
