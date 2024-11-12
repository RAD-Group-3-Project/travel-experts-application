CREATE TABLE Users
(
    userid        INT IDENTITY (1,1),
    user_login    VARCHAR(50) NOT NULL,
    user_password VARCHAR(50) NOT NULL,
    is_admin      BIT         NOT NULL
);
GO
INSERT INTO Users (user_login, user_password, is_admin)
VALUES ('admin', 'admin', 1)
INSERT INTO Users (user_login, user_password, is_admin)
VALUES ('agent', 'agent', 0)
GO

ALTER TABLE Agencies
    ADD is_active BIT NOT NULL DEFAULT 1;

ALTER TABLE Agents
    ADD is_active BIT NOT NULL DEFAULT 1;
