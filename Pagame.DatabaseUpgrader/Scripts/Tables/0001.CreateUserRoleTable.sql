CREATE TABLE [dbo].[UserRoles] (
    id IDENTITY(1,1) NOT NULL PRIMARY KEY,
    roleName VARCHAR(50) NOT NULL
);

INSERT INTO UserRoles (roleName)
VALUES ('ADMIN')
INSERT INTO UserRoles (roleName)
VALUES ('MEMBER')
GO
    