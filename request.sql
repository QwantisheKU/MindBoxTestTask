-- ������ �������� ��������� � ���������

SELECT p.[Name] AS "��� ��������", c.[Name] AS "��� ���������"
FROM dbo.Product AS p
LEFT JOIN dbo.ProductCategory pc ON pc.[ProductId] = p.[Id]
LEFT JOIN dbo.Category c ON pc.[CategoryId] = c.[Id]
ORDER BY 1, 2;