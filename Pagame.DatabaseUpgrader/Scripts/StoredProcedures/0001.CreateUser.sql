IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_NAME = 'AddUser')
DROP PROCEDURE [dbo].[AddUser]
GO
CREATE PROCEDURE [dbo].[AddUser]
    @userId UNIQUEIDENTIFIER,
    @userName VARCHAR(50),
    @email VARCHAR(50),
    @phoneNumber VARCHAR(50),
    @roleId INT,
    @salt VARCHAR(10),
    @pword VARCHAR(128)
AS  
BEGIN  
SETNOCOUNTON;
    INSERT INTO Users(userId, userName, email, phoneNumber, roleId, salt, password)
    VALUES (@userId, @userName, @email, @phoneNumber, @roleId, @salt, @pword);
END
GO