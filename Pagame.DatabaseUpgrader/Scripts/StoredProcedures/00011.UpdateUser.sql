IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE SPECIFIC_NAME = 'UpdateUser')
DROP PROCEDURE [dbo].[UpdateUser]
GO
CREATE PROCEDURE [dbo].[UpdateUser]
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
    UPDATE Users
    SET userName = @userName,
    email = @email
    phoneNumer = @phoneNumber
    roleId = @roleId
    salt = @salt
    password = @pword
    WHERE userId = @userId
END
GO