USE [ProdukteDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 11.07.2018 00:30:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_LOGIN]

@ID VARCHAR(50), @PWD VARCHAR(50)

AS 

SELECT * FROM Benutzer 
WHERE BNr=@ID AND Pass=@PWD