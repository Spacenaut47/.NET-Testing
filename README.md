# MyDotnetApp

This is a clean .NET 8 solution containing:

- ✅ Console App
- ✅ ASP.NET Core Web API
- ✅ ASP.NET Core MVC App
- ✅ Class Library (`Products.Infrastructure`)
- ✅ XUnit Test Project with `Moq` mocking
- ✅ Code coverage with Coverlet + ReportGenerator
- ✅ Git with proper `.gitignore`


---

## ✅ Required Tools

Make sure the following are installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- [C# Extension for VS Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

---

## 📦 Install Required NuGet Packages

From the root folder, run:

```bash
# Navigate to test project folder
cd Products.Infrastructure.Test

# Add Moq for mocking
dotnet add package Moq

# Add Coverlet for code coverage
dotnet add package coverlet.collector

# Add test SDKs (if missing)
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit
dotnet add package xunit.runner.visualstudio

# Run Console App
dotnet run --project ConsoleApp

# Run Web API
dotnet run --project Category.Api

# Run MVC Web App
dotnet run --project Products.Mvc

# Run tests from test project
dotnet test Products.Infrastructure.Test

dotnet test

dotnet test --collect:"XPlat Code Coverage"

dotnet tool install -g dotnet-reportgenerator-globaltool

reportgenerator -reports:"TestResults/**/coverage.cobertura.xml" -targetdir:"CoverageReport"
start CoverageReport/index.html



