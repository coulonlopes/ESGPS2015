
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/08/2015 17:42:05
-- Generated from EDMX file: C:\Users\Suporte DEI\Desktop\EGPS\ClassLibrary1\HealthBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HealthBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MedicoUtente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Utentes] DROP CONSTRAINT [FK_MedicoUtente];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consultas] DROP CONSTRAINT [FK_MedicoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoProficiencia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medicos] DROP CONSTRAINT [FK_MedicoProficiencia];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicoLogIn]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medicos] DROP CONSTRAINT [FK_MedicoLogIn];
GO
IF OBJECT_ID(N'[dbo].[FK_HelpDeskLogIn]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HelpDesks] DROP CONSTRAINT [FK_HelpDeskLogIn];
GO
IF OBJECT_ID(N'[dbo].[FK_UtenteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consultas] DROP CONSTRAINT [FK_UtenteConsulta];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Medicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medicos];
GO
IF OBJECT_ID(N'[dbo].[Proficiencias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proficiencias];
GO
IF OBJECT_ID(N'[dbo].[Utentes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Utentes];
GO
IF OBJECT_ID(N'[dbo].[Consultas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consultas];
GO
IF OBJECT_ID(N'[dbo].[HelpDesks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HelpDesks];
GO
IF OBJECT_ID(N'[dbo].[LogIns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogIns];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Medicos'
CREATE TABLE [dbo].[Medicos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Cedula] int  NOT NULL,
    [Nif] int  NOT NULL,
    [CheckIn] datetime  NOT NULL,
    [CheckOut] datetime  NOT NULL,
    [Proficiencia_Id] int  NOT NULL,
    [LogIn_Id] int  NOT NULL
);
GO

-- Creating table 'Proficiencias'
CREATE TABLE [dbo].[Proficiencias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Utentes'
CREATE TABLE [dbo].[Utentes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [DataNasc] datetime  NOT NULL,
    [Sns] int  NOT NULL,
    [MedicoId] int  NOT NULL,
    [BICC] int  NOT NULL,
    [CodigoPostal] int  NOT NULL,
    [Telefone] int  NOT NULL
);
GO

-- Creating table 'Consultas'
CREATE TABLE [dbo].[Consultas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Sintomas] nvarchar(max)  NOT NULL,
    [Diagnostico] nvarchar(max)  NOT NULL,
    [MedicoId] int  NOT NULL,
    [UtenteId] int  NOT NULL
);
GO

-- Creating table 'HelpDesks'
CREATE TABLE [dbo].[HelpDesks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [LogIn_Id] int  NOT NULL
);
GO

-- Creating table 'LogIns'
CREATE TABLE [dbo].[LogIns] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Medicos'
ALTER TABLE [dbo].[Medicos]
ADD CONSTRAINT [PK_Medicos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Proficiencias'
ALTER TABLE [dbo].[Proficiencias]
ADD CONSTRAINT [PK_Proficiencias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Utentes'
ALTER TABLE [dbo].[Utentes]
ADD CONSTRAINT [PK_Utentes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [PK_Consultas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HelpDesks'
ALTER TABLE [dbo].[HelpDesks]
ADD CONSTRAINT [PK_HelpDesks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LogIns'
ALTER TABLE [dbo].[LogIns]
ADD CONSTRAINT [PK_LogIns]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MedicoId] in table 'Utentes'
ALTER TABLE [dbo].[Utentes]
ADD CONSTRAINT [FK_MedicoUtente]
    FOREIGN KEY ([MedicoId])
    REFERENCES [dbo].[Medicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoUtente'
CREATE INDEX [IX_FK_MedicoUtente]
ON [dbo].[Utentes]
    ([MedicoId]);
GO

-- Creating foreign key on [MedicoId] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([MedicoId])
    REFERENCES [dbo].[Medicos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoConsulta'
CREATE INDEX [IX_FK_MedicoConsulta]
ON [dbo].[Consultas]
    ([MedicoId]);
GO

-- Creating foreign key on [Proficiencia_Id] in table 'Medicos'
ALTER TABLE [dbo].[Medicos]
ADD CONSTRAINT [FK_MedicoProficiencia]
    FOREIGN KEY ([Proficiencia_Id])
    REFERENCES [dbo].[Proficiencias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoProficiencia'
CREATE INDEX [IX_FK_MedicoProficiencia]
ON [dbo].[Medicos]
    ([Proficiencia_Id]);
GO

-- Creating foreign key on [LogIn_Id] in table 'Medicos'
ALTER TABLE [dbo].[Medicos]
ADD CONSTRAINT [FK_MedicoLogIn]
    FOREIGN KEY ([LogIn_Id])
    REFERENCES [dbo].[LogIns]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoLogIn'
CREATE INDEX [IX_FK_MedicoLogIn]
ON [dbo].[Medicos]
    ([LogIn_Id]);
GO

-- Creating foreign key on [LogIn_Id] in table 'HelpDesks'
ALTER TABLE [dbo].[HelpDesks]
ADD CONSTRAINT [FK_HelpDeskLogIn]
    FOREIGN KEY ([LogIn_Id])
    REFERENCES [dbo].[LogIns]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HelpDeskLogIn'
CREATE INDEX [IX_FK_HelpDeskLogIn]
ON [dbo].[HelpDesks]
    ([LogIn_Id]);
GO

-- Creating foreign key on [UtenteId] in table 'Consultas'
ALTER TABLE [dbo].[Consultas]
ADD CONSTRAINT [FK_UtenteConsulta]
    FOREIGN KEY ([UtenteId])
    REFERENCES [dbo].[Utentes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtenteConsulta'
CREATE INDEX [IX_FK_UtenteConsulta]
ON [dbo].[Consultas]
    ([UtenteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------