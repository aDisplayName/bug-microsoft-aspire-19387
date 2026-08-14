bug-microsoft-aspire-19387
---
Sample code for https://github.com/microsoft/aspire/issues/19387

# Launch Profile
The `aspire-starter.AppHost\aspire-starter.AppHost.csproj` project has two launch profiles in [launchSettings](.\aspire-starter.AppHost\Properties\launchSettings.json)
* h1: Launch only the Backend API server `aspire-starter.ApiService\aspire-starter.ApiService.csproj`
* h2: Launch both Backend API seerver `aspire-starter.ApiService\aspire-starter.ApiService.csproj` and `aspire-starter.Web\aspire-starter.Web.csproj` Web Frontend.

# VS Code Launch Settings
The [VS Code launch config](.\.vscode\launch.json) is configured to launch both Launch Profiles of the Aspire Host App.
