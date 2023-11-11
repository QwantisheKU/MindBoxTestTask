CREATE TABLE dbo.Category
(
    [Id]    INT PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL
);

CREATE TABLE dbo.Product
(
    [Id]    INT PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL
);

CREATE TABLE dbo.ProductCategory
(
    [ProductId]  INT NOT NULL,
    [CategoryId] INT NOT NULL,
    FOREIGN KEY ([ProductId]) REFERENCES dbo.Product ([Id]),
    FOREIGN KEY ([CategoryId]) REFERENCES dbo.Category ([Id]),
    PRIMARY KEY ([ProductId], [CategoryId])
);

INSERT INTO dbo.Category([Id], [Name])
VALUES (1, 'Sneakers'), (2, 'Pyrotechnics');
INSERT INTO dbo.Product([Id], [Name])
VALUES (1, 'PUMA ALL-STARS'), (2, 'Corsair 1');
INSERT INTO dbo.ProductCategory([ProductId], [CategoryId])
VALUES (1, 1), (2, 2);