
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/17/2022 18:34:57
-- Generated from EDMX file: C:\Users\sshvets\Desktop\C-Banking--Admin-Panel-master\Banking_adm_pn\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [banking_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Admin_Table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admin_Table];
GO
IF OBJECT_ID(N'[dbo].[debit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[debit];
GO
IF OBJECT_ID(N'[dbo].[Deposit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deposit];
GO
IF OBJECT_ID(N'[dbo].[employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[employee];
GO
IF OBJECT_ID(N'[dbo].[FD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FD];
GO
IF OBJECT_ID(N'[dbo].[Transfer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transfer];
GO
IF OBJECT_ID(N'[dbo].[userAccount]', 'U') IS NOT NULL
    DROP TABLE [dbo].[userAccount];
GO
IF OBJECT_ID(N'[dbo].[userTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[userTable];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Admin_Table'
CREATE TABLE [dbo].[Admin_Table] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL
);
GO

-- Creating table 'debit'
CREATE TABLE [dbo].[debit] (
    [sno] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(50)  NULL,
    [AccountNo] decimal(18,0)  NULL,
    [Name] nvarchar(50)  NULL,
    [OldBalance] decimal(18,0)  NULL,
    [Mode] nvarchar(50)  NULL,
    [DebAmount] decimal(18,0)  NULL
);
GO

-- Creating table 'Deposit'
CREATE TABLE [dbo].[Deposit] (
    [sno] int IDENTITY(1,1) NOT NULL,
    [AccountNo] decimal(18,0)  NULL,
    [Name] nvarchar(50)  NULL,
    [OldBalance] decimal(18,0)  NULL,
    [Mode] nvarchar(50)  NULL,
    [DipAmount] decimal(18,0)  NULL,
    [Date] nvarchar(50)  NULL
);
GO

-- Creating table 'employee'
CREATE TABLE [dbo].[employee] (
    [user_id] int IDENTITY(1,1) NOT NULL,
    [Emp_name] nvarchar(50)  NULL,
    [Gender] nvarchar(50)  NULL,
    [DateBirth] nvarchar(50)  NULL,
    [Phone] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [Password] nvarchar(50)  NULL
);
GO

-- Creating table 'FD'
CREATE TABLE [dbo].[FD] (
    [sno] int IDENTITY(1,1) NOT NULL,
    [Account_No] decimal(18,0)  NULL,
    [Mode] nvarchar(50)  NULL,
    [Rupees] nvarchar(50)  NULL,
    [Period] int  NULL,
    [Interest_rate] decimal(18,0)  NULL,
    [Maturity_Date] nvarchar(50)  NULL,
    [Maturity_Amount] decimal(18,0)  NULL,
    [Start_Date] nvarchar(50)  NULL
);
GO

-- Creating table 'Transfer'
CREATE TABLE [dbo].[Transfer] (
    [sno] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(50)  NULL,
    [Account_No] decimal(18,0)  NULL,
    [Name] nvarchar(50)  NULL,
    [balance] decimal(18,0)  NULL,
    [ToTransfer] decimal(18,0)  NULL
);
GO

-- Creating table 'userAccount'
CREATE TABLE [dbo].[userAccount] (
    [Account_No] decimal(18,0)  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [DOB] nvarchar(50)  NULL,
    [PhoneNo] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [District] nvarchar(50)  NULL,
    [State] nvarchar(50)  NULL,
    [Picture] varbinary(max)  NULL,
    [Gender] nvarchar(50)  NULL,
    [maritial_status] nvarchar(50)  NULL,
    [Mother_Name] nvarchar(50)  NULL,
    [Father_Name] nvarchar(50)  NULL,
    [balance] decimal(18,0)  NULL,
    [Date] nvarchar(50)  NULL
);
GO

-- Creating table 'userTable'
CREATE TABLE [dbo].[userTable] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Admin_Table'
ALTER TABLE [dbo].[Admin_Table]
ADD CONSTRAINT [PK_Admin_Table]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [sno] in table 'debit'
ALTER TABLE [dbo].[debit]
ADD CONSTRAINT [PK_debit]
    PRIMARY KEY CLUSTERED ([sno] ASC);
GO

-- Creating primary key on [sno] in table 'Deposit'
ALTER TABLE [dbo].[Deposit]
ADD CONSTRAINT [PK_Deposit]
    PRIMARY KEY CLUSTERED ([sno] ASC);
GO

-- Creating primary key on [user_id] in table 'employee'
ALTER TABLE [dbo].[employee]
ADD CONSTRAINT [PK_employee]
    PRIMARY KEY CLUSTERED ([user_id] ASC);
GO

-- Creating primary key on [sno] in table 'FD'
ALTER TABLE [dbo].[FD]
ADD CONSTRAINT [PK_FD]
    PRIMARY KEY CLUSTERED ([sno] ASC);
GO

-- Creating primary key on [sno] in table 'Transfer'
ALTER TABLE [dbo].[Transfer]
ADD CONSTRAINT [PK_Transfer]
    PRIMARY KEY CLUSTERED ([sno] ASC);
GO

-- Creating primary key on [Account_No] in table 'userAccount'
ALTER TABLE [dbo].[userAccount]
ADD CONSTRAINT [PK_userAccount]
    PRIMARY KEY CLUSTERED ([Account_No] ASC);
GO

-- Creating primary key on [Id] in table 'userTable'
ALTER TABLE [dbo].[userTable]
ADD CONSTRAINT [PK_userTable]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------