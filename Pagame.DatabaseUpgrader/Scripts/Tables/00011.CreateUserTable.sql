CREATE TABLE [dbo].[Users] (
    userId UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    userName VARCHAR(50) NOT NULL,
    userEmail VARCHAR(50) NOT NULL,
    phoneNumber VARCHAR(50) NULL,
    roleId INT NOT NULL,
    salt VARCHAR(10) NOT NULL,
    password VARCHAR(128) NOT NULL,
    isDeleted INT DEFAULT (0) NOT NULL
);
GO
    