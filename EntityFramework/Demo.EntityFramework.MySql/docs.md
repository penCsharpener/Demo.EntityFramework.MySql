# docs



```powershell
dotnet tool install -g dotnet-ef --version 3.0.0-preview6.19304.10

dotnet-ef dbcontext scaffold "server=localhost;database=northwind;user=northwind;pwd=;port=3307" "Pomelo.EntityFrameworkCore.MySql"
-o ./Models -f
```