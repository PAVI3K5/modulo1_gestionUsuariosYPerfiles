USE [BugTracker]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PERFILES]    Script Date: 5/10/2020 17:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		PAV I Grupo8 Modulo 1
-- Create date: 02/10/20
-- Description:	Permite obtener todos los perfiles
-- =============================================
CREATE PROCEDURE [dbo].[SP_CONSULTAR_PERFILES]
AS
BEGIN
	SELECT id_perfil, nombre, borrado from Perfiles where borrado=0 order by nombre
END

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PERFILES_CON_BORRADO]    Script Date: 5/10/2020 17:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		PAV I Grupo8 Modulo 1
-- Create date: 02/10/20
-- Description:	Permite obtener todos los perfiles con borrado
-- =============================================
CREATE PROCEDURE [dbo].[SP_CONSULTAR_PERFILES_CON_BORRADO]
AS
BEGIN
	SELECT id_perfil, nombre, borrado from Perfiles order by nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_USUARIOS]    Script Date: 5/10/2020 17:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PAV I Grupo8 Modulo 1
-- Create date: 02/10/20
-- Description:	Permite filtrar los perfiles por nombre
-- =============================================
CREATE PROCEDURE [dbo].[SP_CONSULTAR_USUARIOS]
AS
BEGIN
	SELECT id_usuario, usuario, email, estado from Usuarios where borrado=0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_USUARIOS_POR_NOMBRE]    Script Date: 5/10/2020 17:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PAV I Grupo8 Modulo 1
-- Create date: 02/10/20
-- Description:	Permite filtrar los perfiles por nombre
-- =============================================
CREATE PROCEDURE [dbo].[SP_CONSULTAR_USUARIOS_POR_NOMBRE]
	-- Add the parameters for the stored procedure here
	@Param1 varchar(max)
AS
BEGIN
	SELECT id_usuario, usuario, email, estado, password
    FROM Usuarios
	WHERE borrado = 0 
	and usuario = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_FILTRAR_PERFILES_POR_NOMBRE]    Script Date: 5/10/2020 17:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PAV I Grupo8 Modulo 1
-- Create date: 02/10/20
-- Description:	Permite filtrar los perfiles por nombre
-- =============================================
CREATE PROCEDURE [dbo].[SP_FILTRAR_PERFILES_POR_NOMBRE]
	-- Add the parameters for the stored procedure here
	@Param1 varchar(max)
AS
BEGIN
	SELECT  id_perfil, nombre, borrado 
	from Perfiles 
	where borrado=0 
	and NOMBRE 
	LIKE @Param1+'%' 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_FILTRAR_PERFILES_POR_NOMBRE_CON_BORRADOS]    Script Date: 5/10/2020 17:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PAV I Grupo8 Modulo 1
-- Create date: 02/10/20
-- Description:	Permite filtrar los perfiles por nombre
-- =============================================
CREATE PROCEDURE [dbo].[SP_FILTRAR_PERFILES_POR_NOMBRE_CON_BORRADOS]
	-- Add the parameters for the stored procedure here
	@Param1 varchar(max)
AS
BEGIN
	SELECT  id_perfil, nombre, borrado 
	from Perfiles
	where NOMBRE 
	LIKE @Param1+'%' 

END
GO
