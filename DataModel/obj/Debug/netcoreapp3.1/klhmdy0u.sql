IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Businesses] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [BusinessName] nvarchar(250) NOT NULL,
    [Cuit_Cuil] nvarchar(20) NULL,
    [Address] nvarchar(250) NULL,
    [Phone] nvarchar(250) NULL,
    CONSTRAINT [PK_Businesses] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Roles] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [RoleName] nvarchar(250) NOT NULL,
    [Description] nvarchar(250) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Users] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [BusinessId] nvarchar(450) NOT NULL,
    [FirstName] nvarchar(250) NULL,
    [LastName] nvarchar(250) NULL,
    [Email] nvarchar(250) NULL,
    [Phone] nvarchar(250) NULL,
    [Address] nvarchar(250) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Users_Businesses_BusinessId] FOREIGN KEY ([BusinessId]) REFERENCES [Businesses] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Accounts] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [UserName] nvarchar(50) NOT NULL,
    [UserPass] nvarchar(50) NOT NULL,
    [Confirm] bit NOT NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Accounts_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Accounts_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Categories] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [CategoryName] nvarchar(250) NOT NULL,
    [Description] nvarchar(1000) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Categories_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Histories] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [OptionId] nvarchar(max) NOT NULL,
    [TypeId] int NOT NULL,
    [Action] nvarchar(250) NOT NULL,
    [ModuleAction] nvarchar(250) NOT NULL,
    CONSTRAINT [PK_Histories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Histories_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [IncreasePriceAfterTwelves] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [HourFrom] datetime2 NOT NULL,
    [HourTo] datetime2 NOT NULL,
    [Porcent] decimal(18,2) NOT NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_IncreasePriceAfterTwelves] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncreasePriceAfterTwelves_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [PaymentTypes] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [PaymentName] nvarchar(250) NOT NULL,
    [Description] nvarchar(250) NULL,
    CONSTRAINT [PK_PaymentTypes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PaymentTypes_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Providers] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [Name] nvarchar(250) NOT NULL,
    [Address] nvarchar(250) NULL,
    [Phone] nvarchar(250) NULL,
    [Cuit_Cuil] nvarchar(250) NULL,
    CONSTRAINT [PK_Providers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Providers_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SubCategories] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [CategoryId] nvarchar(450) NOT NULL,
    [SubCategoryName] nvarchar(250) NOT NULL,
    [Description] nvarchar(1000) NULL,
    CONSTRAINT [PK_SubCategories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SubCategories_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Sales] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(max) NULL,
    [PaymentTypeId] nvarchar(450) NOT NULL,
    [InvoiceCode] bigint NOT NULL,
    [Total] decimal(18,2) NOT NULL,
    [finalizeSale] bit NOT NULL,
    [SaleType] nvarchar(max) NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Sales_PaymentTypes_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Products] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NULL,
    [ProviderId] nvarchar(450) NULL,
    [CategoryId] nvarchar(450) NULL,
    [ProductCode] nvarchar(max) NULL,
    [ProductName] nvarchar(max) NULL,
    [PurchasePrice] decimal(18,2) NOT NULL,
    [SalePrice] decimal(18,2) NOT NULL,
    [Stock] int NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Products_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_Providers_ProviderId] FOREIGN KEY ([ProviderId]) REFERENCES [Providers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [HistoryPrices] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [ProductId] nvarchar(450) NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [PriceSale] decimal(18,2) NOT NULL,
    [PricePurchase] decimal(18,2) NOT NULL,
    [typeUpdate] int NOT NULL,
    CONSTRAINT [PK_HistoryPrices] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_HistoryPrices_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_HistoryPrices_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Lots] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [ProductId] nvarchar(450) NULL,
    [LotCode] nvarchar(max) NULL,
    [ExpiredDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Lots] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Lots_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SaleDetails] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [productId] nvarchar(450) NULL,
    [SaleId] nvarchar(450) NULL,
    [price] decimal(18,2) NOT NULL,
    [quantity] int NOT NULL,
    CONSTRAINT [PK_SaleDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SaleDetails_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sales] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetails_Products_productId] FOREIGN KEY ([productId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessName', N'CreatedDate', N'Cuit_Cuil', N'FinalDate', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Businesses]'))
    SET IDENTITY_INSERT [Businesses] ON;
INSERT INTO [Businesses] ([Id], [Address], [BusinessName], [CreatedDate], [Cuit_Cuil], [FinalDate], [ModifiedDate], [Phone], [state])
VALUES (N'de07358c-3a51-42fb-8690-c383b91b5844', N'San Lorenzo', N'Almacen', '2022-10-20T13:53:03.5486800-03:00', N'30-45785215-9', NULL, NULL, N'3419875425', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessName', N'CreatedDate', N'Cuit_Cuil', N'FinalDate', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Businesses]'))
    SET IDENTITY_INSERT [Businesses] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'RoleName', N'state') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [RoleName], [state])
VALUES (N'82a0bec6-8266-443a-84a2-af85ad69348b', '2022-10-20T13:53:03.5566891-03:00', N'Tiene acceso en todo', NULL, NULL, N'Admin', 1),
(N'66e3d763-3f6c-49f1-ad72-3b64051c4879', '2022-10-20T13:53:03.5567537-03:00', N'Tiene acceso para realizar ventas, con limite', NULL, NULL, N'Empleado(a)', 1),
(N'0ac46b16-ef03-452c-9586-ba4251496b3f', '2022-10-20T13:53:03.5567547-03:00', N'Solo puede hacer control de stock', NULL, NULL, N'Almacenero(a)', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'RoleName', N'state') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessId', N'CreatedDate', N'Email', N'FinalDate', N'FirstName', N'LastName', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [Address], [BusinessId], [CreatedDate], [Email], [FinalDate], [FirstName], [LastName], [ModifiedDate], [Phone], [state])
VALUES (N'362c2637-2ad9-449a-9498-dbd74be87ee8', N'San Lorenzo', N'de07358c-3a51-42fb-8690-c383b91b5844', '2022-10-20T13:53:03.5537304-03:00', N'almacensanlorenzo@gmail.com', NULL, N'Almacen', N'San Lorenzo', NULL, N'3416987542', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessId', N'CreatedDate', N'Email', N'FinalDate', N'FirstName', N'LastName', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] ON;
INSERT INTO [Accounts] ([Id], [Confirm], [CreatedDate], [FinalDate], [ModifiedDate], [RoleId], [UserId], [UserName], [UserPass], [state])
VALUES (N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', CAST(1 AS bit), '2022-10-20T13:53:03.4969949-03:00', NULL, NULL, N'82a0bec6-8266-443a-84a2-af85ad69348b', N'362c2637-2ad9-449a-9498-dbd74be87ee8', N'almacen', N'odeNiMDGrhgpMHmoHQKCQg==', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] ON;
INSERT INTO [Accounts] ([Id], [Confirm], [CreatedDate], [FinalDate], [ModifiedDate], [RoleId], [UserId], [UserName], [UserPass], [state])
VALUES (N'ed456bd3-2578-45a8-81f6-938c6a4cf9b3', CAST(1 AS bit), '2022-10-20T13:53:03.5250661-03:00', NULL, NULL, N'66e3d763-3f6c-49f1-ad72-3b64051c4879', N'362c2637-2ad9-449a-9498-dbd74be87ee8', N'cajero', N'odeNiMDGrhgpMHmoHQKCQg==', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CategoryName', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'state') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] ON;
INSERT INTO [Categories] ([Id], [AccountId], [CategoryName], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [state])
VALUES (N'4444da14-84ac-48de-a7da-a4f4ddd28858', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'ABARROTES', '2022-10-20T13:53:03.5665085-03:00', N'Este tipo de recinto comercial ofrece alimentos envasados o de venta al peso, desde panes hasta productos lácteos pasando por conservas. Los abarrotes, en algunos países sudamericanos, se denominan almacenes.', NULL, NULL, 1),
(N'9cb3d8c8-226e-4f1a-b04d-258db3329c75', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'OTROS PRODUCTOS', '2022-10-20T13:53:03.5665432-03:00', N'Que no tiene una categoria especifico', NULL, NULL, 1),
(N'27d5e91e-1229-49cd-964b-cc812a81faeb', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'JARCERÍA / PRODUCTOS DE LIMPIEZA', '2022-10-20T13:53:03.5665429-03:00', N'Jarciería es el término que se refiere a toda aquella mercadería que se denomina comúnmente instrumentos de limpieza. Existe gran variedad de jarciería a la venta ya sea en la típica tienda de autoservicio o bien en compañías especializadas.', NULL, NULL, 1),
(N'db2ca371-5ba5-49d9-81cf-f04f49a61b0e', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'HELADOS', '2022-10-20T13:53:03.5665426-03:00', N'En su forma más simple, el helado o crema helada es un alimento congelado que por lo general se hace de productos lácteos tales como leche o crema.', NULL, NULL, 1),
(N'21fcbb68-3e40-4550-b142-a302fc264a47', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'USO DOMÉSTICO', '2022-10-20T13:53:03.5665424-03:00', N'USO DOMÉSTICO.', NULL, NULL, 1),
(N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'AUTOMEDICACIÓN', '2022-10-20T13:53:03.5665418-03:00', N'La automedicación es la utilización de medicamentos por iniciativa propia sin ninguna intervención por parte del médico (ni en el diagnóstico de la enfermedad, ni en la prescripción o supervisión del tratamiento)', NULL, NULL, 1),
(N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'ALIMENTOS PREPARADOS', '2022-10-20T13:53:03.5665415-03:00', N'Alimento listo para el consumo: alimento que está en forma comestible, sin necesidad de lavado, cocimiento, o preparación adicional por parte del establecimiento de comida o consumidor, y se espera que sea consumido en esa forma.', NULL, NULL, 1),
(N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'BEBIDAS', '2022-10-20T13:53:03.5665412-03:00', N'Bebida es cualquier líquido que se ingiere. La bebida más consumida es el agua. Otros ejemplos son las bebidas alcohólicas, bebidas gaseosas, infusiones o zumos. En Chile se le llama bebida exclusivamente a las gaseosas.', NULL, NULL, 1),
(N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'HIGIENE PERSONAL', '2022-10-20T13:53:03.5665421-03:00', N'La higiene personal es el concepto básico del aseo, de la limpieza y del cuidado del cuerpo humano.', NULL, NULL, 1),
(N'c0f96f74-96cf-438a-b89f-0888182b3e75', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'HARINAS Y PAN', '2022-10-20T13:53:03.5665406-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, 1),
(N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'CONFITERÍA/DULCERIA', '2022-10-20T13:53:03.5665403-03:00', N'El término repostería es el que se utiliza para denominar al tipo de gastronomía que se basa en la preparación, y decoración de platos dulces tales como pies, tartas, pasteles, galletas, budines, etc.', NULL, NULL, 1),
(N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'BOTANAS', '2022-10-20T13:53:03.5665399-03:00', N'Es un tipo de aperitivo, ese plato que da inicio a una comida y se comparte entre los comensales. Algunas de las botanas más tradicionales generalmente están hechas con una masa de maíz que termina siendo tortillas, totopos, tostadas… y normalmente se acompañan con diferentes salsas.', NULL, NULL, 1),
(N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'LÁCTEOS', '2022-10-20T13:53:03.5665392-03:00', N'El grupo de los lácteos (también productos lácteos, lácticos o derivados lácteos) incluye alimentos como la leche y sus derivados procesados. Las plantas industriales que producen estos alimentos pertenecen a la industria láctea y se caracterizan por la manipulación de un producto altamente perecedero, como la leche, que debe vigilarse y analizarse correctamente durante todos los pasos de la cadena de frío hasta su llegada al consumidor.', NULL, NULL, 1),
(N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'BEBIDAS ALCOHÓLICAS', '2022-10-20T13:53:03.5665388-03:00', N'Las bebidas alcohólicas son aquellas bebidas que contienen etanol en su composición. Las bebidas alcohólicas desempeñan un papel social importante en muchas culturas del mundo, debido a su efecto de droga recreativa depresora.', NULL, NULL, 1),
(N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'PRODUCTOS ENLATADOS', '2022-10-20T13:53:03.5665385-03:00', N'Un alimento enlatado, es por ende, un alimento fresco, incorporado en un recipiente metálico, herméticamente cerrado el cual se somete a un proceso de calentamiento a temperaturas superiores a los 100 °C, para conservarlo, lo más parecido posible, a su estado en forma natural hasta el momento de consumirlo.', NULL, NULL, 1),
(N'b296430c-42de-41f8-8fc2-3f7fadb44218', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'FRUTAS Y VERDURAS', '2022-10-20T13:53:03.5665409-03:00', N'Las frutas y verduras se consideran partes comestibles de las plantas (por ejemplo, estructuras portadoras de semillas, flores, brotes, hojas, tallos, brotes y raíces), ya sean cultivadas o cosechadas en forma silvestre, en estado crudo o en forma mínimamente elaborada.', NULL, NULL, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CategoryName', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'state') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'PaymentName', N'state') AND [object_id] = OBJECT_ID(N'[PaymentTypes]'))
    SET IDENTITY_INSERT [PaymentTypes] ON;
INSERT INTO [PaymentTypes] ([Id], [AccountId], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [PaymentName], [state])
VALUES (N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601468-03:00', N'Especie', NULL, NULL, N'Especie', 1),
(N'f5f737fd-860c-485b-972a-927d385f4ab5', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5600174-03:00', N'Efectivo', NULL, NULL, N'Efectivo', 1),
(N'4c1ffed9-2f0c-4294-8b82-d236da387b39', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601427-03:00', N'Tarjeta de debito', NULL, NULL, N'Tarjeta de debito', 1),
(N'3700a7b3-0e1b-49e2-87ce-490d06d2512c', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601455-03:00', N'Tarjeta de credito', NULL, NULL, N'Tarjeta de credito', 1),
(N'50e82295-a08f-42fa-aae0-26813bc261db', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601459-03:00', N'Cheques', NULL, NULL, N'Cheques', 1),
(N'1535f60d-2db1-4c65-90bc-c1ded55b07aa', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601462-03:00', N'Mercado pago', NULL, NULL, N'Mercado pago', 1),
(N'876d4600-b062-4e84-937d-8a79f88c1e47', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601465-03:00', N'Transferencia bancaria', NULL, NULL, N'Transferencia bancaria', 1),
(N'da40a532-f06a-4fff-8f66-a7563fef8941', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-20T13:53:03.5601471-03:00', N'Cuenta Corriente', NULL, NULL, N'Cuenta Corriente', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'PaymentName', N'state') AND [object_id] = OBJECT_ID(N'[PaymentTypes]'))
    SET IDENTITY_INSERT [PaymentTypes] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'SubCategoryName', N'state') AND [object_id] = OBJECT_ID(N'[SubCategories]'))
    SET IDENTITY_INSERT [SubCategories] ON;
INSERT INTO [SubCategories] ([Id], [CategoryId], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [SubCategoryName], [state])
VALUES (N'81806b92-46ce-4177-bcad-3c572857aec5', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236297-03:00', N'Aceite comestibles', NULL, NULL, N'Aceite comestibles', 1),
(N'fefb0f12-c610-44ba-a425-b58344af0a3c', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237606-03:00', N'Gasas', NULL, NULL, N'Gasas', 1),
(N'9f8fff37-92e9-465b-ae5d-8940ae1e1cd3', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237609-03:00', N'Analgésicos', NULL, NULL, N'Analgésicos', 1),
(N'198c65d6-cb58-4d3f-be56-f1bc93fc0277', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237612-03:00', N'Antigripales', NULL, NULL, N'Antigripales', 1),
(N'0d2d3a77-64c7-4fb3-aee0-366d262d3ce3', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237615-03:00', N'Antiácidos', NULL, NULL, N'Antiácidos', 1),
(N'ed6b2c4a-bcf3-4d0b-8e98-83ddd98653b6', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237618-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'65ade45e-c4b5-4b7d-9d71-2cfae455fe31', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237621-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'c7296d61-4b18-46e9-8e26-7a809e636cb8', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237624-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'b3ae5bf6-5836-4e90-9c69-637afde26bd7', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237627-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'8efb933d-b689-4110-8cff-4a4e20f46104', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237629-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'ad774f0a-e895-47c4-8b7e-9593c5d37f8e', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237603-03:00', N'Alcohol', NULL, NULL, N'Alcohol', 1),
(N'c31961f5-e6ab-4f1f-a398-04ff4c7c2368', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237632-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'4d85744f-add3-4f9e-88c8-2c34ab4f815a', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237644-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'9ba0b0c7-d09a-42e5-920d-fac472cfdad9', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237648-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'933336aa-5883-46b4-b6af-3f5c89b5b973', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237652-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'8aee87a6-643f-4197-abe7-ee9956cfe636', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237656-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'796cfb96-7b0d-4558-a4a9-08a9fed29071', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237660-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'8126f485-7a77-49c9-a3cb-de1be3b682bd', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237664-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'85bb728e-2c64-4d40-9189-735313307bf8', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237668-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'b71dd199-bb0d-44d2-98a1-71466e29b4ae', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237672-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'70bc49ab-7e64-461a-a350-d18323fe6743', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237676-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'10db0819-5466-420d-acca-5ecaa864ec0a', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237640-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'8ac143dd-a639-4bad-9243-5706bf358ae1', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237600-03:00', N'Preservativos', NULL, NULL, N'Preservativos', 1),
(N'19fe7044-5f20-4720-9bf3-9214b1d9fbef', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237597-03:00', N'Agua oxigenada', NULL, NULL, N'Agua oxigenada', 1),
(N'ee9c7eb3-842a-4671-a046-96facfb2bcb6', N'07dd4e15-386e-44c7-8f63-801c1dddeb1a', '2022-10-20T13:53:03.6237594-03:00', N'Suero', NULL, NULL, N'Suero', 1),
(N'6d5403fe-eb3b-4e6a-b66f-5584d61c75d5', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237328-03:00', N'Agua saborizada', NULL, NULL, N'Agua saborizada', 1),
(N'b94e325c-2fa5-4c2e-ae97-66c53f7f23b1', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237339-03:00', N'Jarabes', NULL, NULL, N'Jarabes', 1),
(N'530edb0d-938c-4ae4-869a-567bf6bb529c', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237343-03:00', N'Jugos/Néctares', NULL, NULL, N'Jugos/Néctares', 1),
(N'7b3bdb7e-f9d4-4bfc-ab00-ad75b1e32185', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237347-03:00', N'Naranjadas', NULL, NULL, N'Naranjadas', 1),
(N'f586c0df-265a-46d3-9f7d-1219f269c2d6', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237354-03:00', N'Bebidas de soya', NULL, NULL, N'Bebidas de soya', 1),
(N'7002138f-f7fb-4a43-a880-060188703c09', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237359-03:00', N'Bebidas en polvo', NULL, NULL, N'Bebidas en polvo', 1),
(N'74bd441c-c526-4aa8-9948-467be87158e6', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237364-03:00', N'Bebidas infantiles', NULL, NULL, N'Bebidas infantiles', 1),
(N'25bb2d73-56d5-4479-bce5-a63aa1ca63d6', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237369-03:00', N'Bebidas isotónicas', NULL, NULL, N'Bebidas isotónicas', 1),
(N'c5ebff6a-ea3a-426c-a06c-38cfdf3fcc31', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237372-03:00', N'Energetizantes', NULL, NULL, N'Energetizantes', 1),
(N'09e77b14-a1c5-4094-8ae2-5af32ab26d5d', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237375-03:00', N'Isotónicos', NULL, NULL, N'Isotónicos', 1),
(N'fa7b0ef7-a5b5-48a8-80dd-bdbb51b3827a', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237378-03:00', N'Refrescos', NULL, NULL, N'Refrescos', 1),
(N'e06b976c-4745-4368-a615-3d011811589e', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237382-03:00', N'Pastas listas para comer', NULL, NULL, N'Pastas listas para comer', 1),
(N'1174d492-edd1-4f9c-b7cf-ce8a6f68abc3', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237385-03:00', N'Sopas en vaso', NULL, NULL, N'Sopas en vaso', 1),
(N'8a195233-1a00-4dbf-a41d-3c4c0d18b574', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237388-03:00', N'Carnes y Embutidos', NULL, NULL, N'Carnes y Embutidos', 1),
(N'6557a6d3-5317-44c2-98fd-333064c87b13', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237392-03:00', N'Salchicha', NULL, NULL, N'Salchicha', 1),
(N'77e2ee32-b9fc-4600-b28b-1ec5b0190e7d', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237395-03:00', N'Mortadela', NULL, NULL, N'Mortadela', 1),
(N'a055a422-56d0-4852-ac24-5a5925002c35', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237398-03:00', N'Tocino', NULL, NULL, N'Tocino', 1),
(N'a93e6d6a-fe84-4977-88f9-9eb5dac3c7e4', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237401-03:00', N'Jamón', NULL, NULL, N'Jamón', 1),
(N'14348004-c92e-45b9-8cd4-c82060d3f291', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237404-03:00', N'Manteca', NULL, NULL, N'Manteca', 1),
(N'e5bc3319-2a58-4df3-89bd-17edc123cc0a', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237407-03:00', N'Chorizo', NULL, NULL, N'Chorizo', 1),
(N'88cfed2e-4469-4d95-8f08-252ce4f74e8f', N'13e20bf2-8bff-4201-b3bf-30cf7e2cdb12', '2022-10-20T13:53:03.6237591-03:00', N'Carne de puerco/res/pollo', NULL, NULL, N'Carne de puerco/res/pollo', 1),
(N'b9d66a36-38d6-4d57-bad3-b0e949a5a574', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237680-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'08bf4c2a-55b9-4449-ba44-7a18e61157fa', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237684-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'65749701-c848-42a3-8549-b90938b0a98f', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237688-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'c90a0767-fb77-4136-ab65-7719945e803a', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237698-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'0c64f205-d9ca-4a4b-90ec-eac98fbf523c', N'db2ca371-5ba5-49d9-81cf-f04f49a61b0e', '2022-10-20T13:53:03.6237823-03:00', N'Paletas/ Helados', NULL, NULL, N'Paletas/ Helados', 1),
(N'f66ac072-f4db-4bae-9ad3-25afe5d653b8', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237826-03:00', N'Veladoras/Velas', NULL, NULL, N'Veladoras/Velas', 1),
(N'422edf4a-d9e6-40f4-9cc1-9b0dcd0756ac', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237830-03:00', N'Cepillo de plástico', NULL, NULL, N'Cepillo de plástico', 1),
(N'66c6219a-a5eb-49d5-9a73-d36bb76d821a', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237834-03:00', N'Vasos desechables', NULL, NULL, N'Vasos desechables', 1),
(N'8ef9734c-7ed8-4ce0-9899-d96b3da864eb', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237838-03:00', N'Cinta adhesiva', NULL, NULL, N'Cinta adhesiva', 1),
(N'fb894ec4-3008-46d0-bcbd-10c66df049af', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237846-03:00', N'Cucharas de plástico', NULL, NULL, N'Cucharas de plástico', 1),
(N'9538e426-3d8a-4575-aaeb-671bfadfcf4c', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237850-03:00', N'Escobas/Trapeadores/Mechudos', NULL, NULL, N'Escobas/Trapeadores/Mechudos', 1),
(N'df953e9b-49b2-4c98-bf43-c0b89ffd2671', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237854-03:00', N'Trampas para ratas', NULL, NULL, N'Trampas para ratas', 1),
(N'6eea4362-7ae5-4631-b3ca-571d523b3176', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237860-03:00', N'Tenedores de plástico', NULL, NULL, N'Tenedores de plástico', 1),
(N'3b2730ed-eee3-4d6a-b7e2-46934dd2cd25', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237866-03:00', N'Extensiones/Multicontacto', NULL, NULL, N'Extensiones/Multicontacto', 1),
(N'4636fd58-00ad-4f6c-ab97-6a91a2a6e210', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237870-03:00', N'Recogedor de metal/plástico', NULL, NULL, N'Recogedor de metal/plástico', 1),
(N'3ba56596-8256-46a0-85b1-fcedb255c8a2', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237874-03:00', N'Popotes', NULL, NULL, N'Popotes', 1),
(N'b1aac6b6-1e84-45a6-ac41-52e14a8ea1fa', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237880-03:00', N'Platos desechables', NULL, NULL, N'Platos desechables', 1),
(N'19634b95-60be-45ec-8ca8-e508e273af05', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237889-03:00', N'Focos', NULL, NULL, N'Focos', 1),
(N'aae444bc-4a86-4e9f-bfbd-71ad73da07a2', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237897-03:00', N'Fusibles', NULL, NULL, N'Fusibles', 1),
(N'0d54b411-6a42-49b1-8a8a-ee2ac22aa1be', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237901-03:00', N'Jergas/Franelas', NULL, NULL, N'Jergas/Franelas', 1),
(N'8c066537-f8d7-4031-9172-872081e1d0a3', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237906-03:00', N'Matamoscas', NULL, NULL, N'Matamoscas', 1),
(N'591bac37-162a-4314-b0ae-46e9db02f691', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237909-03:00', N'Pegamento', NULL, NULL, N'Pegamento', 1),
(N'dfce1885-ecbe-432e-9148-8a2d34809082', N'27d5e91e-1229-49cd-964b-cc812a81faeb', '2022-10-20T13:53:03.6237913-03:00', N'Mecate/cuerda', NULL, NULL, N'Mecate/cuerda', 1),
(N'98a5dd90-ba52-4534-998f-5da2e95e38b4', N'9cb3d8c8-226e-4f1a-b04d-258db3329c75', '2022-10-20T13:53:03.6237924-03:00', N'Hielo', NULL, NULL, N'Hielo', 1),
(N'60366d57-cfe4-473a-a473-6e58fce5c928', N'9cb3d8c8-226e-4f1a-b04d-258db3329c75', '2022-10-20T13:53:03.6237928-03:00', N'Tarjetas telefónicas', NULL, NULL, N'Tarjetas telefónicas', 1),
(N'b4f45ffb-8b76-4304-bd06-706a228b5b10', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237819-03:00', N'Desinfectantes', NULL, NULL, N'Desinfectantes', 1),
(N'a1746970-5277-4100-87fb-27843e3e7572', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237324-03:00', N'Agua natural', NULL, NULL, N'Agua natural', 1),
(N'11ae28fa-b2e2-44fb-8d65-aba73b937ead', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237816-03:00', N'Fibras limpiadoras', NULL, NULL, N'Fibras limpiadoras', 1),
(N'cdea20ca-087d-4fb5-8553-105c1e2d9a84', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237800-03:00', N'Cloro para ropa', NULL, NULL, N'Cloro para ropa', 1),
(N'a77e5bf6-0d96-4922-999e-09b4909ebae5', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237701-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'cb924254-4f5b-4e25-aafc-b3c6e51a26a7', N'9fc02177-e0ba-42cf-bc95-cd2f7abc4418', '2022-10-20T13:53:03.6237705-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'HIGIENE PERSONAL', 1),
(N'e7af707d-2029-4d1d-a10b-9a5c55d98ca2', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237709-03:00', N'Suavizante de telas', NULL, NULL, N'Suavizante de telas', 1),
(N'fec5fe83-b884-4d56-a5fe-6d7ab2156574', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237715-03:00', N'Ácido muriático', NULL, NULL, N'Ácido muriático', 1),
(N'a2a399bc-e461-40b5-85e0-dddc7b5ddea4', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237719-03:00', N'Sosa caustica', NULL, NULL, N'Sosa caustica', 1),
(N'b0a7966c-e4ab-426c-8628-c86106fbf3fe', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237729-03:00', N'Aluminio', NULL, NULL, N'Aluminio', 1),
(N'7be30abf-7504-480b-b0af-580ccc0be9ec', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237734-03:00', N'Pilas', NULL, NULL, N'Pilas', 1),
(N'a8e6b961-8f12-4679-a05c-0d72fdb4f755', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237737-03:00', N'Shampoo para ropa', NULL, NULL, N'Shampoo para ropa', 1),
(N'7e36389e-2514-4c1a-9b02-956cccb72b7a', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237743-03:00', N'Servilletas', NULL, NULL, N'Servilletas', 1),
(N'f7f2a895-0a64-4e47-bbab-9bd914eaa86e', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237747-03:00', N'Servitoallas', NULL, NULL, N'Servitoallas', 1),
(N'd295440a-24c8-4a8f-879a-41f9c883fa4b', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237750-03:00', N'Aromatizantes', NULL, NULL, N'Aromatizantes', 1),
(N'65bb2650-2d2a-46b4-841b-39bc67d3b132', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237753-03:00', N'Cera para automóvil', NULL, NULL, N'Cera para automóvil', 1),
(N'b83339e8-ec1b-44a4-8045-cb6e22905cd7', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237757-03:00', N'Cera para calzados', NULL, NULL, N'Cera para calzados', 1),
(N'd6d038ac-c428-4761-8d24-dc0703e8e4c2', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237761-03:00', N'Pastillas sanitarias', NULL, NULL, N'Pastillas sanitarias', 1),
(N'0dee8e1a-a3a8-411a-864a-542bf690fb34', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237764-03:00', N'Limpiadores líquidos', NULL, NULL, N'Limpiadores líquidos', 1),
(N'76ac4c24-9bc2-4897-a9a2-60529d306a14', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237770-03:00', N'Limpiadores para pisos', NULL, NULL, N'Limpiadores para pisos', 1),
(N'63eaca83-cacf-4d84-9b29-2fa454a9c206', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237777-03:00', N'Jabón de barra', NULL, NULL, N'Jabón de barra', 1),
(N'4c1f4d08-7a4b-43d3-beca-4959700e41bc', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237781-03:00', N'Detergentes para trastes', NULL, NULL, N'Detergentes para trastes', 1),
(N'2267271b-d123-4f63-8e8e-c1719a4ad20d', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237786-03:00', N'Detergente para ropa', NULL, NULL, N'Detergente para ropa', 1),
(N'b0c6bb87-7bb1-43d4-b6fa-43eb67694604', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237790-03:00', N'Cerillos', NULL, NULL, N'Cerillos', 1),
(N'bb40a622-9e9e-4c19-ae9f-545dc86bef0d', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237795-03:00', N'Cloro/Blanqueador', NULL, NULL, N'Cloro/Blanqueador', 1),
(N'add2357f-a4bd-480d-9652-df476b521e4c', N'21fcbb68-3e40-4550-b142-a302fc264a47', '2022-10-20T13:53:03.6237810-03:00', N'Insecticidas', NULL, NULL, N'Insecticidas', 1),
(N'24a39fa6-79d3-47c7-9e55-180bf92c2d89', N'9cb3d8c8-226e-4f1a-b04d-258db3329c75', '2022-10-20T13:53:03.6237932-03:00', N'Recargas móviles', NULL, NULL, N'Recargas móviles', 1),
(N'd8fa7bc2-e8b5-44c4-b4ee-79f0db884832', N'087aa814-3f3d-4cfb-83ef-e11256d6ecdb', '2022-10-20T13:53:03.6237319-03:00', N'Agua mineral', NULL, NULL, N'Agua mineral', 1),
(N'5df74c33-8b66-4999-a511-6aecc01faa33', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237310-03:00', N'Naranjas', NULL, NULL, N'Naranjas', 1),
(N'a8f90356-989c-47a5-a6f6-ab338f283018', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236647-03:00', N'Frutas en almíbar', NULL, NULL, N'Frutas en almíbar', 1),
(N'42496afc-b727-48cb-ae26-eb20c859bba7', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236650-03:00', N'Sardinas', NULL, NULL, N'Sardinas', 1),
(N'9d6c9083-6b73-45c9-a61b-28800cfc5d0a', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236654-03:00', N'Atún en agua/aceite', NULL, NULL, N'Atún en agua/aceite', 1),
(N'e3a46fc4-de62-41cc-8a11-305cbbf77ebb', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236657-03:00', N'Chiles enlatados', NULL, NULL, N'Chiles enlatados', 1),
(N'1bc53107-6800-4b35-b4f3-c3363fb89a19', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236661-03:00', N'Chiles envasados', NULL, NULL, N'Chiles envasados', 1),
(N'2cd8ebea-b8e5-408e-b098-4a6f635bc6bd', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236664-03:00', N'Ensaladas enlatadas', NULL, NULL, N'Ensaladas enlatadas', 1),
(N'c3165ffb-7ad1-4730-8b00-a335edac1cc5', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236667-03:00', N'Granos de elote enlatados', NULL, NULL, N'Granos de elote enlatados', 1),
(N'9c8dde52-8d6c-4b7c-9651-fef58287be61', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236671-03:00', N'Sopa en lata', NULL, NULL, N'Sopa en lata', 1),
(N'25202d3f-46e2-4706-aa39-f1100063aeca', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236674-03:00', N'Vegetales en conserva', NULL, NULL, N'Vegetales en conserva', 1),
(N'07735a2d-1e10-404d-8ae4-28c05bab0e6b', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236643-03:00', N'Frijoles enlatados', NULL, NULL, N'Frijoles enlatados', 1),
(N'30c5ec35-19f7-4d52-aaa1-cfcf21987603', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236677-03:00', N'Bebidas preparadas', NULL, NULL, N'Bebidas preparadas', 1),
(N'cf17f4d4-cfc1-4c06-9f6a-6eac5062ede9', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236691-03:00', N'Anís', NULL, NULL, N'Anís', 1),
(N'7027f120-3478-4896-81cf-21bcff739315', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236699-03:00', N'Brandy', NULL, NULL, N'Brandy', 1),
(N'55136ca5-1c33-4e44-9e4d-34a06c6086f8', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236703-03:00', N'Ginebra.', NULL, NULL, N'Ginebra', 1),
(N'dd56fb2d-90d1-404d-bf33-3a2163a6fc20', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236706-03:00', N'Cordiales', NULL, NULL, N'Cordiales', 1),
(N'1a27fb1d-7b20-41a2-9c53-43e5afa27698', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236716-03:00', N'Mezcal', NULL, NULL, N'Mezcal', 1),
(N'247700b0-7887-45b1-b670-4e97c0b90b44', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6237064-03:00', N'Jerez', NULL, NULL, N'Jerez', 1),
(N'bca46483-d119-4a9a-a72b-676d761ebb6a', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6237072-03:00', N'Ron', NULL, NULL, N'Ron', 1),
(N'dd2d472b-252b-4963-a802-6e615657df04', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6237077-03:00', N'Tequila', NULL, NULL, N'Tequila', 1),
(N'a5b8701d-c62c-476e-b22f-e666def4152a', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6237081-03:00', N'Sidra', NULL, NULL, N'Sidra', 1),
(N'6ad37caa-6ee5-4f73-ab41-ea2be3d77828', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6236681-03:00', N'Cerveza', NULL, NULL, N'Cerveza', 1),
(N'13722a31-d37e-4c44-9226-fef2dd6ab09e', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236638-03:00', N'Chícharos enlatados', NULL, NULL, N'Chícharos enlatados', 1),
(N'90bb3117-ea6e-4868-9fc3-7504f685c03e', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236629-03:00', N'Chícharo con zanahoria', NULL, NULL, N'Chícharo con zanahoria', 1),
(N'41e9e143-03db-4b0f-a51b-6b9160d357fc', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236625-03:00', N'Champiñones enteros/rebanados', NULL, NULL, N'Champiñones enteros/rebanados', 1),
(N'c4a81f89-6f44-4c1c-bfd6-adf1f0a312e3', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236523-03:00', N'Aderezos', NULL, NULL, N'Aderezos', 1),
(N'51858237-ae9b-4731-88c2-f19a2d344c3c', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236530-03:00', N'Crema para café', NULL, NULL, N'Crema para café', 1),
(N'dc85f186-d18b-4a8b-a504-698fda19a9b6', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236534-03:00', N'Pure de tomate', NULL, NULL, N'Pure de tomate', 1),
(N'9a15a184-1821-4b06-9b6d-8624e62f42fb', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236537-03:00', N'Alimento para bebe', NULL, NULL, N'Alimento para bebe', 1),
(N'a4d3cc0d-8e39-460c-a02d-18fc2dced014', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236545-03:00', N'Alimento para mascotas', NULL, NULL, N'Alimento para mascotas', 1),
(N'6c9aa2b5-8cef-4621-b526-d94b08c17e46', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236549-03:00', N'Avena', NULL, NULL, N'Avena', 1),
(N'fd74c75f-db36-4101-bcd4-9b5d672f2c5a', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236553-03:00', N'Azúcar', NULL, NULL, N'Azúcar', 1),
(N'84990688-e3f9-45af-8f22-03c77262c614', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236557-03:00', N'Cereales', NULL, NULL, N'Cereales', 1),
(N'b21274b8-1f85-4034-aa24-f47ae1f46d00', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236562-03:00', N'Especias', NULL, NULL, N'Especias', 1),
(N'77c79cbb-b53e-40aa-aa80-043d4f221bec', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236567-03:00', N'Harina', NULL, NULL, N'Harina', 1),
(N'e5eab8bf-d214-4bb2-a42a-e73d6c8890d8', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236571-03:00', N'Sal', NULL, NULL, N'Sal', 1),
(N'995a74e1-98b5-4489-977d-f84113df2bc1', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236575-03:00', N'Sopas en sobre', NULL, NULL, N'Sopas en sobre', 1),
(N'1579c57f-cf33-4645-bfcc-4d09f92a70a3', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236585-03:00', N'Catsup', NULL, NULL, N'Catsup', 1),
(N'24a73edb-d737-42fa-a380-b2fdddd9ef44', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236589-03:00', N'Mayonesa', NULL, NULL, N'Mayonesa', 1),
(N'1a3985b7-65b2-4fc3-bf00-7d5764bd59f2', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236593-03:00', N'Mermelada', NULL, NULL, N'Mermelada', 1),
(N'208b7941-a0a1-47bb-8b6c-5108c0f4cc2b', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236597-03:00', N'Miel', NULL, NULL, N'Miel', 1),
(N'005dc5af-61c1-4b54-9266-03407ca75d10', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236602-03:00', N'Te', NULL, NULL, N'Te', 1),
(N'84bb56bb-c36d-4117-a4cf-e768990761eb', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236607-03:00', N'Vinagre', NULL, NULL, N'Vinagre', 1),
(N'524bbae4-38ca-4f9b-9603-aebcd65ecf84', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236611-03:00', N'Huevo', NULL, NULL, N'Huevo', 1),
(N'7fc35ef8-08f5-4504-b578-012b873574d9', N'4444da14-84ac-48de-a7da-a4f4ddd28858', '2022-10-20T13:53:03.6236615-03:00', N'Pastas', NULL, NULL, N'Pastas', 1),
(N'82fe357c-af4b-436b-b648-983a6092aa65', N'96e050b3-4f1c-4280-8ce0-1f32b6af87f1', '2022-10-20T13:53:03.6236621-03:00', N'Aceitunas', NULL, NULL, N'Aceitunas', 1),
(N'def25cbf-86db-4ae4-ae45-7a63a8d71c6c', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6237084-03:00', N'Whiskey', NULL, NULL, N'Whiskey', 1),
(N'fef25062-8fc1-4006-8514-e234bfa63a05', N'eeb60ffd-ff0d-4367-afc6-e28bef23f1ef', '2022-10-20T13:53:03.6237088-03:00', N'Vodka', NULL, NULL, N'Vodka', 1),
(N'c7b90037-1c6d-4ad4-8397-5f04014ba97f', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237095-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, N'Leche condensada', 1),
(N'1d5721d3-a787-4b8d-9d6f-ffb5d5262b21', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237104-03:00', N'Leche en polvo', NULL, NULL, N'Leche deslactosada', 1),
(N'eb4ed592-7499-4ea3-9c4d-aea95c4a86b1', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237222-03:00', N'Malvaviscos', NULL, NULL, N'Malvaviscos', 1),
(N'0c71411a-1acc-44ce-b5ba-c2bb01fac508', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237226-03:00', N'Pulpa de tamarindo', NULL, NULL, N'Pulpa de tamarindo', 1),
(N'c8cb23d4-2d87-41ec-a592-9535d366f9db', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237229-03:00', N'Pastillas de dulce', NULL, NULL, N'Pastillas de dulce', 1),
(N'95dc66d1-1de1-46de-a588-a5080f197aae', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237233-03:00', N'Paletas de dulce', NULL, NULL, N'Paletas de dulce', 1),
(N'9cdba6b6-d54a-467c-ae55-baa752ec67c7', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237237-03:00', N'Tortillas de harina/maíz', NULL, NULL, N'Tortillas de harina/maíz', 1),
(N'4ba4eaad-c72c-4bf4-8715-2d1d58f1901b', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237244-03:00', N'Galletas dulces', NULL, NULL, N'Galletas dulces', 1),
(N'd571e083-40cd-41db-8448-f55d4cc16780', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237249-03:00', N'Galletas saladas', NULL, NULL, N'Galletas saladas', 1),
(N'86775899-0796-4ede-b76f-b2fb4b30aced', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237252-03:00', N'Pastelillos', NULL, NULL, N'Pastelillos', 1),
(N'bd91bd5a-4f03-48d5-ab41-ff3900b3b566', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237256-03:00', N'Pan de caja', NULL, NULL, N'Pan de caja', 1),
(N'1faacaec-d09a-4fb5-ab7f-3ca55c754ccd', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237260-03:00', N'Pan dulce', NULL, NULL, N'Pan dulce', 1),
(N'f467869a-bbb7-4647-bb04-82e7bfd07eb5', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237265-03:00', N'Pan molido', NULL, NULL, N'Pan molido', 1),
(N'c346edb2-02df-4453-9ba6-a8c718d671bd', N'c0f96f74-96cf-438a-b89f-0888182b3e75', '2022-10-20T13:53:03.6237270-03:00', N'Pan tostado', NULL, NULL, N'Pan tostado', 1),
(N'4b799d8f-ee08-4e8e-930e-ab8403392c4b', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237273-03:00', N'Aguacates', NULL, NULL, N'Aguacates', 1),
(N'a39c1fd6-2a60-4b29-8ba9-3e263406caf2', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237278-03:00', N'Ajos', NULL, NULL, N'Ajos', 1),
(N'bb789c84-5913-4a64-984b-20ad85a99de1', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237281-03:00', N'Cebollas', NULL, NULL, N'Cebollas', 1),
(N'6cf0328c-d542-43be-baed-72af19417433', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237285-03:00', N'Chiles', NULL, NULL, N'Chiles', 1),
(N'ce775a23-82b1-4cdf-9736-a378cdb88c8c', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237289-03:00', N'Cilantro/Perejil', NULL, NULL, N'Cilantro/Perejil', 1),
(N'a64360a1-d91a-4405-9996-56ef3a89e32c', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237293-03:00', N'Jitomate', NULL, NULL, N'Jitomate', 1),
(N'63efd264-3e31-480b-b86c-27c500705826', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237297-03:00', N'Papas', NULL, NULL, N'Papas', 1),
(N'5656e6aa-f9cb-4add-99cb-a9f2696480a0', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237302-03:00', N'Limones', NULL, NULL, N'Limones', 1),
(N'20db2648-207a-474b-a97d-d53451152de3', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237306-03:00', N'Manzanas', NULL, NULL, N'Manzanas', 1),
(N'a37d971a-c292-4b59-8883-04362047cb2f', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237218-03:00', N'Mazapán', NULL, NULL, N'Mazapán', 1),
(N'8f762c3f-368d-412b-bd04-3090847b30ea', N'b296430c-42de-41f8-8fc2-3f7fadb44218', '2022-10-20T13:53:03.6237314-03:00', N'Plátanos', NULL, NULL, N'Plátanos', 1),
(N'dca0c0d8-69a7-451c-bbe3-db4e4237daaf', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237214-03:00', N'Gomas de mascar', NULL, NULL, N'Gomas de mascar', 1),
(N'a93bf77b-505b-46f8-8442-795bd47d83b2', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237203-03:00', N'Chocolate en polvo', NULL, NULL, N'Chocolate en polvo', 1),
(N'6f9c9a1a-7ea6-40a2-9a50-feaa658493c7', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237108-03:00', N'Leche evaporada', NULL, NULL, N'Leche evaporada', 1),
(N'0c64e944-3a0b-49f4-a323-6edccc48ba35', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237113-03:00', N'Leche light', NULL, NULL, N'Leche light', 1),
(N'd75240b2-f901-46af-80be-fcb9a7bd174b', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237117-03:00', N'Leche pasteurizada', NULL, NULL, N'Leche pasteurizada', 1),
(N'6d2eac00-615c-4802-8706-ed8f3b339e26', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237120-03:00', N'Leche saborizada', NULL, NULL, N'Leche saborizada', 1),
(N'3e237426-d168-4f88-bdd5-44236546870a', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237123-03:00', N'Leche semidescremada', NULL, NULL, N'Leche semidescremada', 1),
(N'62664ce7-b8a0-4531-bfb9-932595f7d7a4', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237127-03:00', N'Crema', NULL, NULL, N'Crema', 1),
(N'ad74e8ce-c6cf-4f0d-a7c3-0b86a5690808', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237135-03:00', N'Yoghurt', NULL, NULL, N'Yoghurt', 1),
(N'35532f1d-0adf-460a-ad91-63e270f7a4db', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237139-03:00', N'Mantequilla', NULL, NULL, N'Mantequilla', 1),
(N'410e6eda-1fb4-4ced-84d2-3542b87ada40', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237143-03:00', N'Margarina', NULL, NULL, N'Margarina', 1),
(N'3861c055-4277-4c56-8114-5f2c1b898f5c', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237148-03:00', N'Media crema', NULL, NULL, N'Media crema', 1),
(N'b0848172-c1be-469b-b874-5143c420a137', N'4af6f8b7-b1a5-4375-8319-079e3d8487fe', '2022-10-20T13:53:03.6237152-03:00', N'Queso', NULL, NULL, N'Queso', 1),
(N'6399abe6-056a-425c-a41e-371e7f135bce', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237156-03:00', N'Papas', NULL, NULL, N'Papas', 1),
(N'e28f8d28-5cb6-4f56-918e-c822a0060452', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237160-03:00', N'Palomitas', NULL, NULL, N'Palomitas', 1),
(N'46c73d3e-d21b-4914-87a9-ebac432901e7', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237164-03:00', N'Frituras de maíz', NULL, NULL, N'Frituras de maíz', 1),
(N'5c19e99c-2b96-49cc-a968-7e5d270b1201', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237171-03:00', N'Cacahuates', NULL, NULL, N'Cacahuates', 1),
(N'bc0083b3-7fce-4fb2-92df-9d6be798366a', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237175-03:00', N'Botanas saladas', NULL, NULL, N'Botanas saladas', 1),
(N'82305cb1-de65-4b90-8734-87c5a768e7b3', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237179-03:00', N'Barras alimenticias', NULL, NULL, N'Barras alimenticias', 1),
(N'0e59c12d-d29f-4667-a3af-c1060d16ae94', N'e7c4059e-04a1-4f4a-b5c9-b86da231147f', '2022-10-20T13:53:03.6237187-03:00', N'Nueces y semillas', NULL, NULL, N'Nueces y semillas', 1),
(N'0be5b0f7-62f6-4411-b540-82b51abc865a', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237191-03:00', N'Caramelos', NULL, NULL, N'Caramelos', 1),
(N'dbcc02e0-7b1e-406e-b3e0-a0f333b0062e', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237195-03:00', N'Dulces enchilados', NULL, NULL, N'Dulces enchilados', 1),
(N'8bac1ef3-473c-41a7-95a3-209fbea0c9b7', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237198-03:00', N'Chocolate de mesa', NULL, NULL, N'Chocolate de mesa', 1),
(N'52cd0e99-22b0-4e17-ba9f-ad448b3b8766', N'f350cdda-f912-4fd3-85c9-f99863ab6c2e', '2022-10-20T13:53:03.6237210-03:00', N'Chocolates', NULL, NULL, N'Chocolates', 1),
(N'62433dfd-835e-4651-99f5-78ea6eefec3f', N'9cb3d8c8-226e-4f1a-b04d-258db3329c75', '2022-10-20T13:53:03.6237936-03:00', N'Cigarros', NULL, NULL, N'Cigarros', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'SubCategoryName', N'state') AND [object_id] = OBJECT_ID(N'[SubCategories]'))
    SET IDENTITY_INSERT [SubCategories] OFF;

GO

CREATE INDEX [IX_Accounts_RoleId] ON [Accounts] ([RoleId]);

GO

CREATE INDEX [IX_Accounts_UserId] ON [Accounts] ([UserId]);

GO

CREATE INDEX [IX_Categories_AccountId] ON [Categories] ([AccountId]);

GO

CREATE INDEX [IX_Histories_AccountId] ON [Histories] ([AccountId]);

GO

CREATE INDEX [IX_HistoryPrices_AccountId] ON [HistoryPrices] ([AccountId]);

GO

CREATE INDEX [IX_HistoryPrices_ProductId] ON [HistoryPrices] ([ProductId]);

GO

CREATE INDEX [IX_IncreasePriceAfterTwelves_AccountId] ON [IncreasePriceAfterTwelves] ([AccountId]);

GO

CREATE INDEX [IX_Lots_ProductId] ON [Lots] ([ProductId]);

GO

CREATE INDEX [IX_PaymentTypes_AccountId] ON [PaymentTypes] ([AccountId]);

GO

CREATE INDEX [IX_Products_AccountId] ON [Products] ([AccountId]);

GO

CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);

GO

CREATE INDEX [IX_Products_ProviderId] ON [Products] ([ProviderId]);

GO

CREATE INDEX [IX_Providers_AccountId] ON [Providers] ([AccountId]);

GO

CREATE INDEX [IX_SaleDetails_SaleId] ON [SaleDetails] ([SaleId]);

GO

CREATE INDEX [IX_SaleDetails_productId] ON [SaleDetails] ([productId]);

GO

CREATE INDEX [IX_Sales_PaymentTypeId] ON [Sales] ([PaymentTypeId]);

GO

CREATE INDEX [IX_SubCategories_CategoryId] ON [SubCategories] ([CategoryId]);

GO

CREATE INDEX [IX_Users_BusinessId] ON [Users] ([BusinessId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221020165304_addtablesubcategory', N'3.1.0');

GO

