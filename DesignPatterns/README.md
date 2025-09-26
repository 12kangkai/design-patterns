# DesignPatterns (scaffold)

仓库说明：
- 每个设计模式为独立的 Console 项目（按 Creational/Structural/Behavioral 分类）。
- 目标 .NET 框架： net8.0（可修改 Directory.Build.props）。
- 示例默认是模板，请在各项目中替换 Program.cs 来实现具体示例，并填写项目内 README.md。

示例：运行 Factory Method 示例


新增模式：
1. 新建项目：`dotnet new console -n NewPatternDemo -o <Category>/NewPatternDemo --framework net8.0`
2. `dotnet sln add <Category>/NewPatternDemo/NewPatternDemo.csproj`
3. 提交并遵循仓库约定（README、注释）。
