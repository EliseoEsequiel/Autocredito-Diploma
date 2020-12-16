-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2019 16:28:16
-- Generated from EDMX file: C:\Users\Eliseo E. Ruiz Diaz\Desktop\Autocred\Modelo\ModeloDatos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Autocred];
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

-- Creating table 'ArticuloSet'
CREATE TABLE [dbo].[ArticuloSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion_Art] nvarchar(max)  NOT NULL,
    [Stock] int  NOT NULL,
    [Pendientes] int  NOT NULL,
    [Requerimiento_Id_Req] int  NOT NULL
);
GO

-- Creating table 'RequerimientoSet'
CREATE TABLE [dbo].[RequerimientoSet] (
    [Id_Req] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Cant_Solic] int  NOT NULL,
    [Detalle_Orden_Id_Orden] int  NOT NULL,
    [Empleado_Id_Emp] int  NOT NULL
);
GO

-- Creating table 'Detalle_OrdenSet'
CREATE TABLE [dbo].[Detalle_OrdenSet] (
    [Id_Orden] int IDENTITY(1,1) NOT NULL,
    [Proveedor] nvarchar(max)  NOT NULL,
    [Ult_Mod] nvarchar(max)  NOT NULL,
    [Descripcion_Art] nvarchar(max)  NOT NULL,
    [Cant_Solic] nvarchar(max)  NOT NULL,
    [OrdenCompra_Id_Orden] int  NOT NULL
);
GO

-- Creating table 'OrdenCompraSet'
CREATE TABLE [dbo].[OrdenCompraSet] (
    [Id_Orden] int IDENTITY(1,1) NOT NULL,
    [Proveedor] nvarchar(max)  NOT NULL,
    [Ult_Mod] datetime  NOT NULL
);
GO

-- Creating table 'EmpleadoSet'
CREATE TABLE [dbo].[EmpleadoSet] (
    [Id_Emp] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Direc_calle] nvarchar(max)  NOT NULL,
    [Direc_Nro] int  NOT NULL,
    [Direc_Ciudad] nvarchar(max)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProveedorSet'
CREATE TABLE [dbo].[ProveedorSet] (
    [Id_Prov] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Direc_calle] nvarchar(max)  NOT NULL,
    [Direc_Nro] int  NOT NULL,
    [Direc_Ciudad] nvarchar(max)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [OrdenCompra_Id_Orden] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ArticuloSet'
ALTER TABLE [dbo].[ArticuloSet]
ADD CONSTRAINT [PK_ArticuloSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id_Req] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [PK_RequerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Req] ASC);
GO

-- Creating primary key on [Id_Orden] in table 'Detalle_OrdenSet'
ALTER TABLE [dbo].[Detalle_OrdenSet]
ADD CONSTRAINT [PK_Detalle_OrdenSet]
    PRIMARY KEY CLUSTERED ([Id_Orden] ASC);
GO

-- Creating primary key on [Id_Orden] in table 'OrdenCompraSet'
ALTER TABLE [dbo].[OrdenCompraSet]
ADD CONSTRAINT [PK_OrdenCompraSet]
    PRIMARY KEY CLUSTERED ([Id_Orden] ASC);
GO

-- Creating primary key on [Id_Emp] in table 'EmpleadoSet'
ALTER TABLE [dbo].[EmpleadoSet]
ADD CONSTRAINT [PK_EmpleadoSet]
    PRIMARY KEY CLUSTERED ([Id_Emp] ASC);
GO

-- Creating primary key on [Id_Prov] in table 'ProveedorSet'
ALTER TABLE [dbo].[ProveedorSet]
ADD CONSTRAINT [PK_ProveedorSet]
    PRIMARY KEY CLUSTERED ([Id_Prov] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OrdenCompra_Id_Orden] in table 'ProveedorSet'
ALTER TABLE [dbo].[ProveedorSet]
ADD CONSTRAINT [FK_ProveedorOrdenCompra]
    FOREIGN KEY ([OrdenCompra_Id_Orden])
    REFERENCES [dbo].[OrdenCompraSet]
        ([Id_Orden])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorOrdenCompra'
CREATE INDEX [IX_FK_ProveedorOrdenCompra]
ON [dbo].[ProveedorSet]
    ([OrdenCompra_Id_Orden]);
GO

-- Creating foreign key on [OrdenCompra_Id_Orden] in table 'Detalle_OrdenSet'
ALTER TABLE [dbo].[Detalle_OrdenSet]
ADD CONSTRAINT [FK_Detalle_OrdenOrdenCompra]
    FOREIGN KEY ([OrdenCompra_Id_Orden])
    REFERENCES [dbo].[OrdenCompraSet]
        ([Id_Orden])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Detalle_OrdenOrdenCompra'
CREATE INDEX [IX_FK_Detalle_OrdenOrdenCompra]
ON [dbo].[Detalle_OrdenSet]
    ([OrdenCompra_Id_Orden]);
GO

-- Creating foreign key on [Detalle_Orden_Id_Orden] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [FK_RequerimientoDetalle_Orden]
    FOREIGN KEY ([Detalle_Orden_Id_Orden])
    REFERENCES [dbo].[Detalle_OrdenSet]
        ([Id_Orden])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientoDetalle_Orden'
CREATE INDEX [IX_FK_RequerimientoDetalle_Orden]
ON [dbo].[RequerimientoSet]
    ([Detalle_Orden_Id_Orden]);
GO

-- Creating foreign key on [Empleado_Id_Emp] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [FK_RequerimientoEmpleado]
    FOREIGN KEY ([Empleado_Id_Emp])
    REFERENCES [dbo].[EmpleadoSet]
        ([Id_Emp])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientoEmpleado'
CREATE INDEX [IX_FK_RequerimientoEmpleado]
ON [dbo].[RequerimientoSet]
    ([Empleado_Id_Emp]);
GO

-- Creating foreign key on [Requerimiento_Id_Req] in table 'ArticuloSet'
ALTER TABLE [dbo].[ArticuloSet]
ADD CONSTRAINT [FK_ArticuloRequerimiento]
    FOREIGN KEY ([Requerimiento_Id_Req])
    REFERENCES [dbo].[RequerimientoSet]
        ([Id_Req])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticuloRequerimiento'
CREATE INDEX [IX_FK_ArticuloRequerimiento]
ON [dbo].[ArticuloSet]
    ([Requerimiento_Id_Req]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------