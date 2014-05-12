
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2014 13:49:33
-- Generated from EDMX file: D:\KRUNAL\PErsonal\APM_AC\APM_AC\DB_Access\APMACMaintanceEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [APM_ACMaintance];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ACMasters'
CREATE TABLE [dbo].[ACMasters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ACTypeMasterId] int  NOT NULL,
    [PurchaseDate] datetime  NULL,
    [LastServiceDate] datetime  NULL,
    [Note] nvarchar(max)  NOT NULL,
    [LocationMasterId] int  NOT NULL
);
GO

-- Creating table 'ACTypeMasters'
CREATE TABLE [dbo].[ACTypeMasters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ACName] nvarchar(max)  NOT NULL,
    [ACCompanyName] nvarchar(max)  NOT NULL,
    [Tons] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'LocationMasters'
CREATE TABLE [dbo].[LocationMasters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AddLine1] nvarchar(max)  NULL,
    [AddLine2] nvarchar(max)  NULL,
    [AddLine3] nvarchar(max)  NULL
);
GO

-- Creating table 'PersonMasters'
CREATE TABLE [dbo].[PersonMasters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Mobile] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [DOJ] datetime  NULL,
    [DOB] datetime  NULL
);
GO

-- Creating table 'ACServiceHistories'
CREATE TABLE [dbo].[ACServiceHistories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ServiceDate] datetime  NOT NULL,
    [Note] nvarchar(max)  NULL,
    [PersonMasterId] int  NOT NULL,
    [ACMasterId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ACMasters'
ALTER TABLE [dbo].[ACMasters]
ADD CONSTRAINT [PK_ACMasters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ACTypeMasters'
ALTER TABLE [dbo].[ACTypeMasters]
ADD CONSTRAINT [PK_ACTypeMasters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LocationMasters'
ALTER TABLE [dbo].[LocationMasters]
ADD CONSTRAINT [PK_LocationMasters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonMasters'
ALTER TABLE [dbo].[PersonMasters]
ADD CONSTRAINT [PK_PersonMasters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ACServiceHistories'
ALTER TABLE [dbo].[ACServiceHistories]
ADD CONSTRAINT [PK_ACServiceHistories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ACTypeMasterId] in table 'ACMasters'
ALTER TABLE [dbo].[ACMasters]
ADD CONSTRAINT [FK_ACTypeMasterACMaster]
    FOREIGN KEY ([ACTypeMasterId])
    REFERENCES [dbo].[ACTypeMasters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ACTypeMasterACMaster'
CREATE INDEX [IX_FK_ACTypeMasterACMaster]
ON [dbo].[ACMasters]
    ([ACTypeMasterId]);
GO

-- Creating foreign key on [LocationMasterId] in table 'ACMasters'
ALTER TABLE [dbo].[ACMasters]
ADD CONSTRAINT [FK_LocationMasterACMaster]
    FOREIGN KEY ([LocationMasterId])
    REFERENCES [dbo].[LocationMasters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationMasterACMaster'
CREATE INDEX [IX_FK_LocationMasterACMaster]
ON [dbo].[ACMasters]
    ([LocationMasterId]);
GO

-- Creating foreign key on [PersonMasterId] in table 'ACServiceHistories'
ALTER TABLE [dbo].[ACServiceHistories]
ADD CONSTRAINT [FK_PersonMasterACServiceHistory]
    FOREIGN KEY ([PersonMasterId])
    REFERENCES [dbo].[PersonMasters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonMasterACServiceHistory'
CREATE INDEX [IX_FK_PersonMasterACServiceHistory]
ON [dbo].[ACServiceHistories]
    ([PersonMasterId]);
GO

-- Creating foreign key on [ACMasterId] in table 'ACServiceHistories'
ALTER TABLE [dbo].[ACServiceHistories]
ADD CONSTRAINT [FK_ACMasterACServiceHistory]
    FOREIGN KEY ([ACMasterId])
    REFERENCES [dbo].[ACMasters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ACMasterACServiceHistory'
CREATE INDEX [IX_FK_ACMasterACServiceHistory]
ON [dbo].[ACServiceHistories]
    ([ACMasterId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------