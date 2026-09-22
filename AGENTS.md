# Repository Guidelines

## Project Structure & Module Organization

`Credit.slnx` is the .NET 10 solution. Business code is grouped under `Modules/`: `Applications` owns credit applications, `Calculations` performs simulations, and `Processes` contains interchangeable Camunda, Conductor, Elsa, Saga, and Temporal workflow hosts. Keep their shared message contracts compatible. `Modules/Aspire/Aspire/Aspire.AppHost` orchestrates services and containers; `Aspire.ServiceDefaults` supplies common telemetry and resilience. Frontends live in `Modules/Front/` (Blazor and Next.js). Shared CQRS and configuration helpers are in `Common/`, and architecture images are in `img/`. Treat `external/camunda-startup/` as a vendored Git subtree.

## Build, Test, and Development Commands

- `dotnet build Credit.slnx` restores and builds the full solution.
- `dotnet test Credit.slnx` runs any .NET tests included in the solution.
- `aspire start --apphost Modules/Aspire/Aspire/Aspire.AppHost/Aspire.AppHost.csproj` starts the distributed application (Docker is required).
- `dotnet run --project Modules/Aspire/Aspire/Aspire.AppHost` is the direct AppHost alternative.
- In `Modules/Front/credit.front.next`, run `npm ci`, then `npm run dev`, `npm run build`, or `npm run lint`.

Select workflow, database, and UI providers through AppHost parameters or `appsettings.json`; for example, append `-- --Parameters:processProvider=camunda --Parameters:databaseProvider=postgres`.

## Coding Style & Naming Conventions

Use four-space indentation in C#, file-scoped namespaces where practical, nullable reference types, and async methods ending in `Async`. Follow existing PascalCase types/methods and camelCase locals/parameters. Keep Web API `Program.cs` files thin and place domain behavior in `*.Application`. NuGet versions belong in `Directory.Packages.props`, not individual projects. TypeScript follows the repository ESLint configuration; use PascalCase React components and camelCase functions.

## Testing Guidelines

The repository currently has no dedicated automated test project. Add regression tests under `Tests/` when changing domain or provider behavior; name .NET test projects `*.Tests` and test classes after the subject. Run the relevant services through Aspire before integration testing, and document required endpoints and environment variables.

## Commit & Pull Request Guidelines

Recent commits use short, imperative, module-prefixed subjects such as `Elsa simplify workflow` and `Processes.Saga remove duplicated messages`. Keep each commit focused. Pull requests should explain behavior changes, list affected providers, include validation commands, link relevant issues, and add screenshots for UI changes. If a workflow step is changed for only some providers, state that scope explicitly.
