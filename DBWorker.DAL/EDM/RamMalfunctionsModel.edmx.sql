
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2019 21:00:20
-- Generated from EDMX file: C:\Users\fibon\source\repos\DBWorker\DBWorker.DAL\EDM\RamMalfunctionsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RamMulfunctiosDB];
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

-- Creating table 'RAMs'
CREATE TABLE [dbo].[RAMs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Size] int  NOT NULL,
    [PruductionDate] datetime  NOT NULL,
    [MemoryFrequency] int  NULL,
    [UsePropose] nvarchar(max)  NOT NULL,
    [IsBuffered] bit  NOT NULL,
    [Warranty] datetime  NOT NULL,
    [Manufacturer_Id] int  NOT NULL,
    [RAMMulfunction_Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Manufacturers'
CREATE TABLE [dbo].[Manufacturers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [IsCertified] bit  NOT NULL
);
GO

-- Creating table 'RAMMediaTypes'
CREATE TABLE [dbo].[RAMMediaTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserServiceLinks'
CREATE TABLE [dbo].[UserServiceLinks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Link] nvarchar(max)  NOT NULL,
    [Malfunction_Id] int  NOT NULL
);
GO

-- Creating table 'RAMMedias'
CREATE TABLE [dbo].[RAMMedias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [RAM_Id] int  NOT NULL,
    [RAMMediaType_Id] int  NOT NULL
);
GO

-- Creating table 'Malfunctions'
CREATE TABLE [dbo].[Malfunctions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AppearsDate] datetime  NOT NULL,
    [RAMMulfunction_Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RAMMulfunctions'
CREATE TABLE [dbo].[RAMMulfunctions] (
    [Id] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FixIssues'
CREATE TABLE [dbo].[FixIssues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [TimeSpan] datetime  NOT NULL,
    [Malfunction_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RAMs'
ALTER TABLE [dbo].[RAMs]
ADD CONSTRAINT [PK_RAMs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Manufacturers'
ALTER TABLE [dbo].[Manufacturers]
ADD CONSTRAINT [PK_Manufacturers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RAMMediaTypes'
ALTER TABLE [dbo].[RAMMediaTypes]
ADD CONSTRAINT [PK_RAMMediaTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserServiceLinks'
ALTER TABLE [dbo].[UserServiceLinks]
ADD CONSTRAINT [PK_UserServiceLinks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RAMMedias'
ALTER TABLE [dbo].[RAMMedias]
ADD CONSTRAINT [PK_RAMMedias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Malfunctions'
ALTER TABLE [dbo].[Malfunctions]
ADD CONSTRAINT [PK_Malfunctions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RAMMulfunctions'
ALTER TABLE [dbo].[RAMMulfunctions]
ADD CONSTRAINT [PK_RAMMulfunctions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FixIssues'
ALTER TABLE [dbo].[FixIssues]
ADD CONSTRAINT [PK_FixIssues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Manufacturer_Id] in table 'RAMs'
ALTER TABLE [dbo].[RAMs]
ADD CONSTRAINT [FK_ManufacturerRAM]
    FOREIGN KEY ([Manufacturer_Id])
    REFERENCES [dbo].[Manufacturers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerRAM'
CREATE INDEX [IX_FK_ManufacturerRAM]
ON [dbo].[RAMs]
    ([Manufacturer_Id]);
GO

-- Creating foreign key on [RAM_Id] in table 'RAMMedias'
ALTER TABLE [dbo].[RAMMedias]
ADD CONSTRAINT [FK_RAMRAMMedia]
    FOREIGN KEY ([RAM_Id])
    REFERENCES [dbo].[RAMs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RAMRAMMedia'
CREATE INDEX [IX_FK_RAMRAMMedia]
ON [dbo].[RAMMedias]
    ([RAM_Id]);
GO

-- Creating foreign key on [Malfunction_Id] in table 'UserServiceLinks'
ALTER TABLE [dbo].[UserServiceLinks]
ADD CONSTRAINT [FK_MalfunctionUserServiceLink]
    FOREIGN KEY ([Malfunction_Id])
    REFERENCES [dbo].[Malfunctions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MalfunctionUserServiceLink'
CREATE INDEX [IX_FK_MalfunctionUserServiceLink]
ON [dbo].[UserServiceLinks]
    ([Malfunction_Id]);
GO

-- Creating foreign key on [RAMMediaType_Id] in table 'RAMMedias'
ALTER TABLE [dbo].[RAMMedias]
ADD CONSTRAINT [FK_RAMMediaTypeRAMMedia]
    FOREIGN KEY ([RAMMediaType_Id])
    REFERENCES [dbo].[RAMMediaTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RAMMediaTypeRAMMedia'
CREATE INDEX [IX_FK_RAMMediaTypeRAMMedia]
ON [dbo].[RAMMedias]
    ([RAMMediaType_Id]);
GO

-- Creating foreign key on [RAMMulfunction_Id] in table 'RAMs'
ALTER TABLE [dbo].[RAMs]
ADD CONSTRAINT [FK_RAMMulfunctionsRAM]
    FOREIGN KEY ([RAMMulfunction_Id])
    REFERENCES [dbo].[RAMMulfunctions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RAMMulfunctionsRAM'
CREATE INDEX [IX_FK_RAMMulfunctionsRAM]
ON [dbo].[RAMs]
    ([RAMMulfunction_Id]);
GO

-- Creating foreign key on [RAMMulfunction_Id] in table 'Malfunctions'
ALTER TABLE [dbo].[Malfunctions]
ADD CONSTRAINT [FK_RAMMulfunctionsMalfunction]
    FOREIGN KEY ([RAMMulfunction_Id])
    REFERENCES [dbo].[RAMMulfunctions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RAMMulfunctionsMalfunction'
CREATE INDEX [IX_FK_RAMMulfunctionsMalfunction]
ON [dbo].[Malfunctions]
    ([RAMMulfunction_Id]);
GO

-- Creating foreign key on [Malfunction_Id] in table 'FixIssues'
ALTER TABLE [dbo].[FixIssues]
ADD CONSTRAINT [FK_MalfunctionFixIssue]
    FOREIGN KEY ([Malfunction_Id])
    REFERENCES [dbo].[Malfunctions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MalfunctionFixIssue'
CREATE INDEX [IX_FK_MalfunctionFixIssue]
ON [dbo].[FixIssues]
    ([Malfunction_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------