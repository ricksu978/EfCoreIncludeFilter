# EfCoreIncludeFilter
## C#
```csharp
var query = dbContext.Categories
    .Include(c => c.Records.OrderByDescending(r => r.LastUpdate).Take(1))
    .Where(c => c.Id == 1 || c.Id == 2 || c.Id == 3)
    ;
```
## Result
```
Category #1:
        Record #22, Last Update = 2021/11/08
Category #2:
        Record #21, Last Update = 2021/11/05
Category #3:
        Record #18, Last Update = 2021/11/02

SELECT [c].[Id], [t0].[Id], [t0].[CategoryId], [t0].[LastUpdate]
FROM [Categories] AS [c]
LEFT JOIN (
    SELECT [t].[Id], [t].[CategoryId], [t].[LastUpdate]
    FROM (
        SELECT [r].[Id], [r].[CategoryId], [r].[LastUpdate], ROW_NUMBER() OVER(PARTITION BY [r].[CategoryId] ORDER BY [r].[LastUpdate] DESC) AS [row]
        FROM [Records] AS [r]
    ) AS [t]
    WHERE [t].[row] <= 1
) AS [t0] ON [c].[Id] = [t0].[CategoryId]
WHERE [c].[Id] IN (1, 2, 3)
ORDER BY [c].[Id], [t0].[CategoryId], [t0].[LastUpdate] DESC, [t0].[Id]
```
