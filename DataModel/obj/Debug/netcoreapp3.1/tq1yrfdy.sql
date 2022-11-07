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
    [Description] nvarchar(250) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Categories_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [IncreasePriceAfterTwelve] (
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
    CONSTRAINT [PK_IncreasePriceAfterTwelve] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_IncreasePriceAfterTwelve_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE
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

CREATE TABLE [Sale] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [AccountId] nvarchar(450) NOT NULL,
    [PaymentTypeId] nvarchar(max) NULL,
    [Total] decimal(18,2) NOT NULL,
    [finalizeSale] bit NOT NULL,
    [SaleType] nvarchar(max) NULL,
    CONSTRAINT [PK_Sale] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Sale_PaymentTypes_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE CASCADE
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
    [ExpirationDate] datetime2 NOT NULL,
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

CREATE TABLE [SaleDetail] (
    [Id] nvarchar(450) NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [ModifiedDate] datetime2 NULL,
    [FinalDate] datetime2 NULL,
    [state] int NOT NULL,
    [productId] nvarchar(450) NULL,
    [SaleId] nvarchar(450) NULL,
    [price] decimal(18,2) NOT NULL,
    [quantity] int NOT NULL,
    CONSTRAINT [PK_SaleDetail] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SaleDetail_Sale_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sale] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaleDetail_Products_productId] FOREIGN KEY ([productId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessName', N'CreatedDate', N'Cuit_Cuil', N'FinalDate', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Businesses]'))
    SET IDENTITY_INSERT [Businesses] ON;
INSERT INTO [Businesses] ([Id], [Address], [BusinessName], [CreatedDate], [Cuit_Cuil], [FinalDate], [ModifiedDate], [Phone], [state])
VALUES (N'de07358c-3a51-42fb-8690-c383b91b5844', N'San Lorenzo', N'Almacen', '2022-09-21T12:10:26.6015610-03:00', N'30-45785215-9', NULL, NULL, N'3419875425', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessName', N'CreatedDate', N'Cuit_Cuil', N'FinalDate', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Businesses]'))
    SET IDENTITY_INSERT [Businesses] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'RoleName', N'state') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([Id], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [RoleName], [state])
VALUES (N'82a0bec6-8266-443a-84a2-af85ad69348b', '2022-09-21T12:10:26.6142466-03:00', N'Tiene acceso en todo', NULL, NULL, N'Admin', 1),
(N'66e3d763-3f6c-49f1-ad72-3b64051c4879', '2022-09-21T12:10:26.6143151-03:00', N'Tiene acceso para realizar ventas, con limite', NULL, NULL, N'Empleado(a)', 1),
(N'0ac46b16-ef03-452c-9586-ba4251496b3f', '2022-09-21T12:10:26.6143159-03:00', N'Solo puede hacer control de stock', NULL, NULL, N'Almacenero(a)', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'RoleName', N'state') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessId', N'CreatedDate', N'Email', N'FinalDate', N'FirstName', N'LastName', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] ON;
INSERT INTO [Users] ([Id], [Address], [BusinessId], [CreatedDate], [Email], [FinalDate], [FirstName], [LastName], [ModifiedDate], [Phone], [state])
VALUES (N'362c2637-2ad9-449a-9498-dbd74be87ee8', N'San Lorenzo', N'de07358c-3a51-42fb-8690-c383b91b5844', '2022-09-21T12:10:26.6075325-03:00', N'almacensanlorenzo@gmail.com', NULL, N'Almacen', N'San Lorenzo', NULL, N'3416987542', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Address', N'BusinessId', N'CreatedDate', N'Email', N'FinalDate', N'FirstName', N'LastName', N'ModifiedDate', N'Phone', N'state') AND [object_id] = OBJECT_ID(N'[Users]'))
    SET IDENTITY_INSERT [Users] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] ON;
INSERT INTO [Accounts] ([Id], [Confirm], [CreatedDate], [FinalDate], [ModifiedDate], [RoleId], [UserId], [UserName], [UserPass], [state])
VALUES (N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', CAST(1 AS bit), '2022-09-21T12:10:26.5485619-03:00', NULL, NULL, N'82a0bec6-8266-443a-84a2-af85ad69348b', N'362c2637-2ad9-449a-9498-dbd74be87ee8', N'almacen', N'odeNiMDGrhgpMHmoHQKCQg==', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CategoryName', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'state') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] ON;
INSERT INTO [Categories] ([Id], [AccountId], [CategoryName], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [state])
VALUES (N'4444da14-84ac-48de-a7da-a4f4ddd28858', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', N'Perfumeria', '2022-09-21T12:10:26.6303652-03:00', N'Se encuentra todo sobre perfumeria', NULL, NULL, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CategoryName', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'state') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'PaymentName', N'state') AND [object_id] = OBJECT_ID(N'[PaymentTypes]'))
    SET IDENTITY_INSERT [PaymentTypes] ON;
INSERT INTO [PaymentTypes] ([Id], [AccountId], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [PaymentName], [state])
VALUES (N'f5f737fd-860c-485b-972a-927d385f4ab5', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6184267-03:00', N'Efectivo', NULL, NULL, N'Efectivo', 1),
(N'4c1ffed9-2f0c-4294-8b82-d236da387b39', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6185311-03:00', N'Tarjeta de debito', NULL, NULL, N'Tarjeta de debito', 1),
(N'3700a7b3-0e1b-49e2-87ce-490d06d2512c', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6185370-03:00', N'Tarjeta de credito', NULL, NULL, N'Tarjeta de credito', 1),
(N'50e82295-a08f-42fa-aae0-26813bc261db', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6185373-03:00', N'Cheques', NULL, NULL, N'Cheques', 1),
(N'1535f60d-2db1-4c65-90bc-c1ded55b07aa', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6185376-03:00', N'Mercado pago', NULL, NULL, N'Mercado pago', 1),
(N'876d4600-b062-4e84-937d-8a79f88c1e47', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6185379-03:00', N'Transferencia bancaria', NULL, NULL, N'Transferencia bancaria', 1),
(N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-09-21T12:10:26.6185383-03:00', N'Especie', NULL, NULL, N'Especie', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'PaymentName', N'state') AND [object_id] = OBJECT_ID(N'[PaymentTypes]'))
    SET IDENTITY_INSERT [PaymentTypes] OFF;

GO

CREATE INDEX [IX_Accounts_RoleId] ON [Accounts] ([RoleId]);

GO

CREATE INDEX [IX_Accounts_UserId] ON [Accounts] ([UserId]);

GO

CREATE INDEX [IX_Categories_AccountId] ON [Categories] ([AccountId]);

GO

CREATE INDEX [IX_IncreasePriceAfterTwelve_AccountId] ON [IncreasePriceAfterTwelve] ([AccountId]);

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

CREATE INDEX [IX_Sale_AccountId] ON [Sale] ([AccountId]);

GO

CREATE INDEX [IX_SaleDetail_SaleId] ON [SaleDetail] ([SaleId]);

GO

CREATE INDEX [IX_SaleDetail_productId] ON [SaleDetail] ([productId]);

GO

CREATE INDEX [IX_Users_BusinessId] ON [Users] ([BusinessId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220921151027_initialmigration', N'3.1.0');

GO

ALTER TABLE [Sale] DROP CONSTRAINT [FK_Sale_PaymentTypes_AccountId];

GO

DROP INDEX [IX_Sale_AccountId] ON [Sale];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sale]') AND [c].[name] = N'PaymentTypeId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Sale] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Sale] ALTER COLUMN [PaymentTypeId] nvarchar(450) NOT NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Sale]') AND [c].[name] = N'AccountId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Sale] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Sale] ALTER COLUMN [AccountId] nvarchar(max) NULL;

GO

UPDATE [Accounts] SET [CreatedDate] = '2022-09-21T13:05:08.2326761-03:00'
WHERE [Id] = N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca';
SELECT @@ROWCOUNT;


GO

UPDATE [Businesses] SET [CreatedDate] = '2022-09-21T13:05:08.2808019-03:00'
WHERE [Id] = N'de07358c-3a51-42fb-8690-c383b91b5844';
SELECT @@ROWCOUNT;


GO

UPDATE [Categories] SET [CreatedDate] = '2022-09-21T13:05:08.3052911-03:00'
WHERE [Id] = N'4444da14-84ac-48de-a7da-a4f4ddd28858';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.3001386-03:00'
WHERE [Id] = N'1535f60d-2db1-4c65-90bc-c1ded55b07aa';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.3001378-03:00'
WHERE [Id] = N'3700a7b3-0e1b-49e2-87ce-490d06d2512c';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.3000993-03:00'
WHERE [Id] = N'4c1ffed9-2f0c-4294-8b82-d236da387b39';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.3001382-03:00'
WHERE [Id] = N'50e82295-a08f-42fa-aae0-26813bc261db';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.3001390-03:00'
WHERE [Id] = N'876d4600-b062-4e84-937d-8a79f88c1e47';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.3001393-03:00'
WHERE [Id] = N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-21T13:05:08.2999993-03:00'
WHERE [Id] = N'f5f737fd-860c-485b-972a-927d385f4ab5';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-09-21T13:05:08.2951553-03:00'
WHERE [Id] = N'0ac46b16-ef03-452c-9586-ba4251496b3f';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-09-21T13:05:08.2951545-03:00'
WHERE [Id] = N'66e3d763-3f6c-49f1-ad72-3b64051c4879';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-09-21T13:05:08.2950930-03:00'
WHERE [Id] = N'82a0bec6-8266-443a-84a2-af85ad69348b';
SELECT @@ROWCOUNT;


GO

UPDATE [Users] SET [CreatedDate] = '2022-09-21T13:05:08.2908985-03:00'
WHERE [Id] = N'362c2637-2ad9-449a-9498-dbd74be87ee8';
SELECT @@ROWCOUNT;


GO

CREATE INDEX [IX_Sale_PaymentTypeId] ON [Sale] ([PaymentTypeId]);

GO

ALTER TABLE [Sale] ADD CONSTRAINT [FK_Sale_PaymentTypes_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220921160509_modifyrelacionPaymenttype', N'3.1.0');

GO

ALTER TABLE [IncreasePriceAfterTwelve] DROP CONSTRAINT [FK_IncreasePriceAfterTwelve_Accounts_AccountId];

GO

ALTER TABLE [Sale] DROP CONSTRAINT [FK_Sale_PaymentTypes_PaymentTypeId];

GO

ALTER TABLE [SaleDetail] DROP CONSTRAINT [FK_SaleDetail_Sale_SaleId];

GO

ALTER TABLE [SaleDetail] DROP CONSTRAINT [FK_SaleDetail_Products_productId];

GO

ALTER TABLE [SaleDetail] DROP CONSTRAINT [PK_SaleDetail];

GO

ALTER TABLE [Sale] DROP CONSTRAINT [PK_Sale];

GO

ALTER TABLE [IncreasePriceAfterTwelve] DROP CONSTRAINT [PK_IncreasePriceAfterTwelve];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'ExpirationDate');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Products] DROP COLUMN [ExpirationDate];

GO

EXEC sp_rename N'[SaleDetail]', N'SaleDetails';

GO

EXEC sp_rename N'[Sale]', N'Sales';

GO

EXEC sp_rename N'[IncreasePriceAfterTwelve]', N'IncreasePriceAfterTwelves';

GO

EXEC sp_rename N'[SaleDetails].[IX_SaleDetail_productId]', N'IX_SaleDetails_productId', N'INDEX';

GO

EXEC sp_rename N'[SaleDetails].[IX_SaleDetail_SaleId]', N'IX_SaleDetails_SaleId', N'INDEX';

GO

EXEC sp_rename N'[Sales].[IX_Sale_PaymentTypeId]', N'IX_Sales_PaymentTypeId', N'INDEX';

GO

EXEC sp_rename N'[IncreasePriceAfterTwelves].[IX_IncreasePriceAfterTwelve_AccountId]', N'IX_IncreasePriceAfterTwelves_AccountId', N'INDEX';

GO

ALTER TABLE [Sales] ADD [InvoiceCode] bigint NOT NULL DEFAULT CAST(0 AS bigint);

GO

ALTER TABLE [SaleDetails] ADD CONSTRAINT [PK_SaleDetails] PRIMARY KEY ([Id]);

GO

ALTER TABLE [Sales] ADD CONSTRAINT [PK_Sales] PRIMARY KEY ([Id]);

GO

ALTER TABLE [IncreasePriceAfterTwelves] ADD CONSTRAINT [PK_IncreasePriceAfterTwelves] PRIMARY KEY ([Id]);

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

UPDATE [Accounts] SET [CreatedDate] = '2022-09-25T22:31:58.0292279-03:00'
WHERE [Id] = N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca';
SELECT @@ROWCOUNT;


GO

UPDATE [Businesses] SET [CreatedDate] = '2022-09-25T22:31:58.0827269-03:00'
WHERE [Id] = N'de07358c-3a51-42fb-8690-c383b91b5844';
SELECT @@ROWCOUNT;


GO

UPDATE [Categories] SET [CreatedDate] = '2022-09-25T22:31:58.1025835-03:00'
WHERE [Id] = N'4444da14-84ac-48de-a7da-a4f4ddd28858';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0988230-03:00'
WHERE [Id] = N'1535f60d-2db1-4c65-90bc-c1ded55b07aa';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0988192-03:00'
WHERE [Id] = N'3700a7b3-0e1b-49e2-87ce-490d06d2512c';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0987345-03:00'
WHERE [Id] = N'4c1ffed9-2f0c-4294-8b82-d236da387b39';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0988202-03:00'
WHERE [Id] = N'50e82295-a08f-42fa-aae0-26813bc261db';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0988257-03:00'
WHERE [Id] = N'876d4600-b062-4e84-937d-8a79f88c1e47';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0988260-03:00'
WHERE [Id] = N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-09-25T22:31:58.0985865-03:00'
WHERE [Id] = N'f5f737fd-860c-485b-972a-927d385f4ab5';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-09-25T22:31:58.0940878-03:00'
WHERE [Id] = N'0ac46b16-ef03-452c-9586-ba4251496b3f';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-09-25T22:31:58.0940872-03:00'
WHERE [Id] = N'66e3d763-3f6c-49f1-ad72-3b64051c4879';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-09-25T22:31:58.0940411-03:00'
WHERE [Id] = N'82a0bec6-8266-443a-84a2-af85ad69348b';
SELECT @@ROWCOUNT;


GO

UPDATE [Users] SET [CreatedDate] = '2022-09-25T22:31:58.0896092-03:00'
WHERE [Id] = N'362c2637-2ad9-449a-9498-dbd74be87ee8';
SELECT @@ROWCOUNT;


GO

CREATE INDEX [IX_Lots_ProductId] ON [Lots] ([ProductId]);

GO

ALTER TABLE [IncreasePriceAfterTwelves] ADD CONSTRAINT [FK_IncreasePriceAfterTwelves_Accounts_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [Accounts] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [SaleDetails] ADD CONSTRAINT [FK_SaleDetails_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sales] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaleDetails] ADD CONSTRAINT [FK_SaleDetails_Products_productId] FOREIGN KEY ([productId]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Sales] ADD CONSTRAINT [FK_Sales_PaymentTypes_PaymentTypeId] FOREIGN KEY ([PaymentTypeId]) REFERENCES [PaymentTypes] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220926013159_addtableLots', N'3.1.0');

GO

UPDATE [Accounts] SET [CreatedDate] = '2022-10-04T11:38:56.9880390-03:00'
WHERE [Id] = N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] ON;
INSERT INTO [Accounts] ([Id], [Confirm], [CreatedDate], [FinalDate], [ModifiedDate], [RoleId], [UserId], [UserName], [UserPass], [state])
VALUES (N'ed456bd3-2578-45a8-81f6-938c6a4cf9b3', CAST(1 AS bit), '2022-10-04T11:38:57.0282749-03:00', NULL, NULL, N'66e3d763-3f6c-49f1-ad72-3b64051c4879', N'362c2637-2ad9-449a-9498-dbd74be87ee8', N'cajero', N'odeNiMDGrhgpMHmoHQKCQg==', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Confirm', N'CreatedDate', N'FinalDate', N'ModifiedDate', N'RoleId', N'UserId', N'UserName', N'UserPass', N'state') AND [object_id] = OBJECT_ID(N'[Accounts]'))
    SET IDENTITY_INSERT [Accounts] OFF;

GO

UPDATE [Businesses] SET [CreatedDate] = '2022-10-04T11:38:57.0412849-03:00'
WHERE [Id] = N'de07358c-3a51-42fb-8690-c383b91b5844';
SELECT @@ROWCOUNT;


GO

UPDATE [Categories] SET [CreatedDate] = '2022-10-04T11:38:57.0534694-03:00'
WHERE [Id] = N'4444da14-84ac-48de-a7da-a4f4ddd28858';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0494619-03:00'
WHERE [Id] = N'1535f60d-2db1-4c65-90bc-c1ded55b07aa';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0494611-03:00'
WHERE [Id] = N'3700a7b3-0e1b-49e2-87ce-490d06d2512c';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0494577-03:00'
WHERE [Id] = N'4c1ffed9-2f0c-4294-8b82-d236da387b39';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0494614-03:00'
WHERE [Id] = N'50e82295-a08f-42fa-aae0-26813bc261db';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0494621-03:00'
WHERE [Id] = N'876d4600-b062-4e84-937d-8a79f88c1e47';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0494623-03:00'
WHERE [Id] = N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-04T11:38:57.0493749-03:00'
WHERE [Id] = N'f5f737fd-860c-485b-972a-927d385f4ab5';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-04T11:38:57.0467809-03:00'
WHERE [Id] = N'0ac46b16-ef03-452c-9586-ba4251496b3f';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-04T11:38:57.0467802-03:00'
WHERE [Id] = N'66e3d763-3f6c-49f1-ad72-3b64051c4879';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-04T11:38:57.0467397-03:00'
WHERE [Id] = N'82a0bec6-8266-443a-84a2-af85ad69348b';
SELECT @@ROWCOUNT;


GO

UPDATE [Users] SET [CreatedDate] = '2022-10-04T11:38:57.0446398-03:00'
WHERE [Id] = N'362c2637-2ad9-449a-9498-dbd74be87ee8';
SELECT @@ROWCOUNT;


GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221004143857_addaccount', N'3.1.0');

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

UPDATE [Accounts] SET [CreatedDate] = '2022-10-10T15:48:51.9729042-03:00'
WHERE [Id] = N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca';
SELECT @@ROWCOUNT;


GO

UPDATE [Accounts] SET [CreatedDate] = '2022-10-10T15:48:52.0038871-03:00'
WHERE [Id] = N'ed456bd3-2578-45a8-81f6-938c6a4cf9b3';
SELECT @@ROWCOUNT;


GO

UPDATE [Businesses] SET [CreatedDate] = '2022-10-10T15:48:52.0353798-03:00'
WHERE [Id] = N'de07358c-3a51-42fb-8690-c383b91b5844';
SELECT @@ROWCOUNT;


GO

UPDATE [Categories] SET [CreatedDate] = '2022-10-10T15:48:52.0503439-03:00'
WHERE [Id] = N'4444da14-84ac-48de-a7da-a4f4ddd28858';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0470646-03:00'
WHERE [Id] = N'1535f60d-2db1-4c65-90bc-c1ded55b07aa';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0470642-03:00'
WHERE [Id] = N'3700a7b3-0e1b-49e2-87ce-490d06d2512c';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0470565-03:00'
WHERE [Id] = N'4c1ffed9-2f0c-4294-8b82-d236da387b39';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0470644-03:00'
WHERE [Id] = N'50e82295-a08f-42fa-aae0-26813bc261db';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0470649-03:00'
WHERE [Id] = N'876d4600-b062-4e84-937d-8a79f88c1e47';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0470651-03:00'
WHERE [Id] = N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-10T15:48:52.0469825-03:00'
WHERE [Id] = N'f5f737fd-860c-485b-972a-927d385f4ab5';
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'PaymentName', N'state') AND [object_id] = OBJECT_ID(N'[PaymentTypes]'))
    SET IDENTITY_INSERT [PaymentTypes] ON;
INSERT INTO [PaymentTypes] ([Id], [AccountId], [CreatedDate], [Description], [FinalDate], [ModifiedDate], [PaymentName], [state])
VALUES (N'da40a532-f06a-4fff-8f66-a7563fef8941', N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca', '2022-10-10T15:48:52.0470654-03:00', N'Cuenta Corriente', NULL, NULL, N'Cuenta Corriente', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountId', N'CreatedDate', N'Description', N'FinalDate', N'ModifiedDate', N'PaymentName', N'state') AND [object_id] = OBJECT_ID(N'[PaymentTypes]'))
    SET IDENTITY_INSERT [PaymentTypes] OFF;

GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-10T15:48:52.0441922-03:00'
WHERE [Id] = N'0ac46b16-ef03-452c-9586-ba4251496b3f';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-10T15:48:52.0441916-03:00'
WHERE [Id] = N'66e3d763-3f6c-49f1-ad72-3b64051c4879';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-10T15:48:52.0441462-03:00'
WHERE [Id] = N'82a0bec6-8266-443a-84a2-af85ad69348b';
SELECT @@ROWCOUNT;


GO

UPDATE [Users] SET [CreatedDate] = '2022-10-10T15:48:52.0409982-03:00'
WHERE [Id] = N'362c2637-2ad9-449a-9498-dbd74be87ee8';
SELECT @@ROWCOUNT;


GO

CREATE INDEX [IX_Histories_AccountId] ON [Histories] ([AccountId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221010184853_addhistorictableandplus', N'3.1.0');

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

UPDATE [Accounts] SET [CreatedDate] = '2022-10-12T15:50:38.7193198-03:00'
WHERE [Id] = N'3e67c8f7-24ce-4f2e-bada-8344f5d0f8ca';
SELECT @@ROWCOUNT;


GO

UPDATE [Accounts] SET [CreatedDate] = '2022-10-12T15:50:38.7459316-03:00'
WHERE [Id] = N'ed456bd3-2578-45a8-81f6-938c6a4cf9b3';
SELECT @@ROWCOUNT;


GO

UPDATE [Businesses] SET [CreatedDate] = '2022-10-12T15:50:38.7583463-03:00'
WHERE [Id] = N'de07358c-3a51-42fb-8690-c383b91b5844';
SELECT @@ROWCOUNT;


GO

UPDATE [Categories] SET [CreatedDate] = '2022-10-12T15:50:38.7715933-03:00'
WHERE [Id] = N'4444da14-84ac-48de-a7da-a4f4ddd28858';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697952-03:00'
WHERE [Id] = N'1535f60d-2db1-4c65-90bc-c1ded55b07aa';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697947-03:00'
WHERE [Id] = N'3700a7b3-0e1b-49e2-87ce-490d06d2512c';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697925-03:00'
WHERE [Id] = N'4c1ffed9-2f0c-4294-8b82-d236da387b39';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697950-03:00'
WHERE [Id] = N'50e82295-a08f-42fa-aae0-26813bc261db';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697954-03:00'
WHERE [Id] = N'876d4600-b062-4e84-937d-8a79f88c1e47';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697957-03:00'
WHERE [Id] = N'c3eb2f61-7bd0-47ed-8a16-98e1b7d24b44';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7697959-03:00'
WHERE [Id] = N'da40a532-f06a-4fff-8f66-a7563fef8941';
SELECT @@ROWCOUNT;


GO

UPDATE [PaymentTypes] SET [CreatedDate] = '2022-10-12T15:50:38.7696936-03:00'
WHERE [Id] = N'f5f737fd-860c-485b-972a-927d385f4ab5';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-12T15:50:38.7669544-03:00'
WHERE [Id] = N'0ac46b16-ef03-452c-9586-ba4251496b3f';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-12T15:50:38.7669537-03:00'
WHERE [Id] = N'66e3d763-3f6c-49f1-ad72-3b64051c4879';
SELECT @@ROWCOUNT;


GO

UPDATE [Roles] SET [CreatedDate] = '2022-10-12T15:50:38.7669105-03:00'
WHERE [Id] = N'82a0bec6-8266-443a-84a2-af85ad69348b';
SELECT @@ROWCOUNT;


GO

UPDATE [Users] SET [CreatedDate] = '2022-10-12T15:50:38.7647771-03:00'
WHERE [Id] = N'362c2637-2ad9-449a-9498-dbd74be87ee8';
SELECT @@ROWCOUNT;


GO

CREATE INDEX [IX_HistoryPrices_AccountId] ON [HistoryPrices] ([AccountId]);

GO

CREATE INDEX [IX_HistoryPrices_ProductId] ON [HistoryPrices] ([ProductId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221012185039_addhistorypricetable', N'3.1.0');

GO

