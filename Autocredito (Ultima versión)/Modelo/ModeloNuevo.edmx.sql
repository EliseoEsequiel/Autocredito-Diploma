
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/09/2020 19:33:22
-- Generated from EDMX file: C:\Users\Emiliano\Desktop\Autocredito DIPLOMA\Autocredito (Ultima versión)\Modelo\ModeloNuevo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Autocredito];
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

-- Creating table 'RequerimientoSet'
CREATE TABLE [dbo].[RequerimientoSet] (
    [Id_Req] int IDENTITY(1,1) NOT NULL,
    [Cantidad] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Estado] bit  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Articulo_Id] int  NOT NULL
);
GO

-- Creating table 'ArticuloSet'
CREATE TABLE [dbo].[ArticuloSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Stock] int  NOT NULL,
    [Pendientes] int  NOT NULL,
    [Stock_Min] int  NOT NULL,
    [Pedido_Max] int  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Rubro_Id] int  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Alias] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Grupo_Id] int  NOT NULL
);
GO

-- Creating table 'GrupoSet'
CREATE TABLE [dbo].[GrupoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Borrado] bit  NOT NULL
);
GO

-- Creating table 'RubroSet'
CREATE TABLE [dbo].[RubroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Borrado] bit  NOT NULL
);
GO

-- Creating table 'DetalleCompraSet'
CREATE TABLE [dbo].[DetalleCompraSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cantidad] nvarchar(max)  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Requerimiento_Id_Req] int  NOT NULL,
    [Orden_Compra_Id] int  NULL
);
GO

-- Creating table 'Orden_CompraSet'
CREATE TABLE [dbo].[Orden_CompraSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ultima_Modificacion] datetime  NOT NULL,
    [Fecha_Limite] datetime  NULL,
    [Borrado] bit  NOT NULL,
    [Proveedor_Id] int  NOT NULL,
    [Estados_Id] int  NOT NULL
);
GO

-- Creating table 'ProveedorSet'
CREATE TABLE [dbo].[ProveedorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Razon_Social] nvarchar(max)  NOT NULL,
    [Direccion_Calle] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Direccion_Nro] nvarchar(max)  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Rubro_Id] int  NOT NULL
);
GO

-- Creating table 'EstadosSet'
CREATE TABLE [dbo].[EstadosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Borrado] bit  NOT NULL
);
GO

-- Creating table 'Remitos'
CREATE TABLE [dbo].[Remitos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Orden_Compra_Id] int  NOT NULL
);
GO

-- Creating table 'ComentariosSet'
CREATE TABLE [dbo].[ComentariosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Estado] bit  NOT NULL,
    [Faltantes] int  NOT NULL,
    [Borrado] bit  NOT NULL,
    [Articulo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Req] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [PK_RequerimientoSet]
    PRIMARY KEY CLUSTERED ([Id_Req] ASC);
GO

-- Creating primary key on [Id] in table 'ArticuloSet'
ALTER TABLE [dbo].[ArticuloSet]
ADD CONSTRAINT [PK_ArticuloSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GrupoSet'
ALTER TABLE [dbo].[GrupoSet]
ADD CONSTRAINT [PK_GrupoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RubroSet'
ALTER TABLE [dbo].[RubroSet]
ADD CONSTRAINT [PK_RubroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetalleCompraSet'
ALTER TABLE [dbo].[DetalleCompraSet]
ADD CONSTRAINT [PK_DetalleCompraSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orden_CompraSet'
ALTER TABLE [dbo].[Orden_CompraSet]
ADD CONSTRAINT [PK_Orden_CompraSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProveedorSet'
ALTER TABLE [dbo].[ProveedorSet]
ADD CONSTRAINT [PK_ProveedorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadosSet'
ALTER TABLE [dbo].[EstadosSet]
ADD CONSTRAINT [PK_EstadosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Remitos'
ALTER TABLE [dbo].[Remitos]
ADD CONSTRAINT [PK_Remitos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ComentariosSet'
ALTER TABLE [dbo].[ComentariosSet]
ADD CONSTRAINT [PK_ComentariosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Articulo_Id] in table 'RequerimientoSet'
ALTER TABLE [dbo].[RequerimientoSet]
ADD CONSTRAINT [FK_RequerimientoArticulo]
    FOREIGN KEY ([Articulo_Id])
    REFERENCES [dbo].[ArticuloSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequerimientoArticulo'
CREATE INDEX [IX_FK_RequerimientoArticulo]
ON [dbo].[RequerimientoSet]
    ([Articulo_Id]);
GO

-- Creating foreign key on [Grupo_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioGrupo]
    FOREIGN KEY ([Grupo_Id])
    REFERENCES [dbo].[GrupoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioGrupo'
CREATE INDEX [IX_FK_UsuarioGrupo]
ON [dbo].[UsuarioSet]
    ([Grupo_Id]);
GO

-- Creating foreign key on [Rubro_Id] in table 'ArticuloSet'
ALTER TABLE [dbo].[ArticuloSet]
ADD CONSTRAINT [FK_ArticuloRubro]
    FOREIGN KEY ([Rubro_Id])
    REFERENCES [dbo].[RubroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticuloRubro'
CREATE INDEX [IX_FK_ArticuloRubro]
ON [dbo].[ArticuloSet]
    ([Rubro_Id]);
GO

-- Creating foreign key on [Requerimiento_Id_Req] in table 'DetalleCompraSet'
ALTER TABLE [dbo].[DetalleCompraSet]
ADD CONSTRAINT [FK_DetalleCompraRequerimiento]
    FOREIGN KEY ([Requerimiento_Id_Req])
    REFERENCES [dbo].[RequerimientoSet]
        ([Id_Req])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleCompraRequerimiento'
CREATE INDEX [IX_FK_DetalleCompraRequerimiento]
ON [dbo].[DetalleCompraSet]
    ([Requerimiento_Id_Req]);
GO

-- Creating foreign key on [Orden_Compra_Id] in table 'DetalleCompraSet'
ALTER TABLE [dbo].[DetalleCompraSet]
ADD CONSTRAINT [FK_DetalleCompraOrden_Compra]
    FOREIGN KEY ([Orden_Compra_Id])
    REFERENCES [dbo].[Orden_CompraSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleCompraOrden_Compra'
CREATE INDEX [IX_FK_DetalleCompraOrden_Compra]
ON [dbo].[DetalleCompraSet]
    ([Orden_Compra_Id]);
GO

-- Creating foreign key on [Rubro_Id] in table 'ProveedorSet'
ALTER TABLE [dbo].[ProveedorSet]
ADD CONSTRAINT [FK_RubroProveedor]
    FOREIGN KEY ([Rubro_Id])
    REFERENCES [dbo].[RubroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RubroProveedor'
CREATE INDEX [IX_FK_RubroProveedor]
ON [dbo].[ProveedorSet]
    ([Rubro_Id]);
GO

-- Creating foreign key on [Proveedor_Id] in table 'Orden_CompraSet'
ALTER TABLE [dbo].[Orden_CompraSet]
ADD CONSTRAINT [FK_ProveedorOrden_Compra]
    FOREIGN KEY ([Proveedor_Id])
    REFERENCES [dbo].[ProveedorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorOrden_Compra'
CREATE INDEX [IX_FK_ProveedorOrden_Compra]
ON [dbo].[Orden_CompraSet]
    ([Proveedor_Id]);
GO

-- Creating foreign key on [Estados_Id] in table 'Orden_CompraSet'
ALTER TABLE [dbo].[Orden_CompraSet]
ADD CONSTRAINT [FK_EstadosOrden_Compra]
    FOREIGN KEY ([Estados_Id])
    REFERENCES [dbo].[EstadosSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadosOrden_Compra'
CREATE INDEX [IX_FK_EstadosOrden_Compra]
ON [dbo].[Orden_CompraSet]
    ([Estados_Id]);
GO

-- Creating foreign key on [Orden_Compra_Id] in table 'Remitos'
ALTER TABLE [dbo].[Remitos]
ADD CONSTRAINT [FK_RemitosOrden_Compra]
    FOREIGN KEY ([Orden_Compra_Id])
    REFERENCES [dbo].[Orden_CompraSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RemitosOrden_Compra'
CREATE INDEX [IX_FK_RemitosOrden_Compra]
ON [dbo].[Remitos]
    ([Orden_Compra_Id]);
GO

-- Creating foreign key on [Articulo_Id] in table 'ComentariosSet'
ALTER TABLE [dbo].[ComentariosSet]
ADD CONSTRAINT [FK_ComentariosArticulo]
    FOREIGN KEY ([Articulo_Id])
    REFERENCES [dbo].[ArticuloSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComentariosArticulo'
CREATE INDEX [IX_FK_ComentariosArticulo]
ON [dbo].[ComentariosSet]
    ([Articulo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------