---
title: Telerik CLI
page_title: Telerik CLI - Installation, Setup, and Command Reference for Telerik UI for WPF
description: Install and use the Telerik CLI to set up the Telerik NuGet feed, create WPF projects from templates, and update Telerik UI for WPF packages from the command line.
slug: wpf/getting-started/telerik-cli
tags: telerik,cli,command line,cli,dotnet tool,nuget,setup,install,create project,update,template,wpf,telerik,getting started,environment
published: True
position: 2
tag: new
---

# Telerik CLI

The Telerik CLI is a .NET global tool that automates common Telerik development tasks from the command line. Use the Telerik CLI to configure the Telerik NuGet package source, create new projects from Telerik templates, and update Telerik UI for WPF packages without opening Visual Studio.

The Telerik CLI works on Windows, macOS, and Linux. It requires the .NET SDK (version 6.0 or later) and a valid Telerik account with an active Subscription or Trial license.

## Command Reference

The following table lists all Telerik CLI commands with their purpose and usage.

| Command | Description | Usage |
|---|---|---|
| `dotnet tool install -g Telerik.CLI` | Installs the Telerik CLI as a .NET global tool. | Run once to install the CLI on your machine. |
| `dotnet tool update -g Telerik.CLI` | Updates the Telerik CLI to the latest version. | Run periodically to get the latest features and fixes. |
| `telerik setup wpf` | Runs the full Telerik UI for WPF developer-machine setup in one command. | Run to authenticate, configure the Telerik NuGet feed, download your license key, and register the Telerik MCP server configuration. |
| `telerik nuget config` | Configures the Telerik NuGet server to your package sources. | Run to set up the `https://nuget.telerik.com/v3/index.json` feed in your NuGet configuration. |
| `telerik license get-key` | Downloads your Telerik license key and saves it as `telerik-license.txt`. | Run to download your license key file. |
| `telerik mcp config` | Installs and configures the Telerik MCP Server for your IDE. | Run to set up AI coding assistance in Visual Studio, VS Code, or Cursor. |
| `telerik login` | Authenticates with your Telerik account. Use `--no-browser` for manual authentication. | Run to store credentials for subsequent commands. |
| `telerik whoami` | Displays the currently logged-in Telerik user account email. | Run to verify your authentication state. |
| `telerik logout` | Logs out from the Telerik CLI. | Run to log out the credentials from your Telerik account. |

## How to Install the Telerik CLI

The [Telerik CLI NuGet](https://www.nuget.org/packages/Telerik.CLI) package is hosted on `nuget.org`. 

To install the Telerik CLI .NET tool globally on your machine, run the following command in your preferred command shell:

```powershell
dotnet tool install -g Telerik.CLI
```

The `dotnet tool install` command provides a few ways for you to install .NET tools on your machine.
* To install the Telerik CLI globally, use the `-g` option.
* To install the Telerik CLI in a custom location, use the `--tool-path` option.
* To install the Telerik CLI in the current folder only, omit the `-g` and `--tool-path` options.

#### Verify Telerik CLI Installation

To verify the installation:

```powershell
dotnet tool list -g
```

#### Update Telerik CLI

To update to the latest version:

```powershell
dotnet tool update -g Telerik.CLI
```

>note The Telerik CLI requires .NET SDK 6.0 or later. Download the .NET SDK from <a href="https://dotnet.microsoft.com/download" target="_blank">the official .NET website</a>.

## Set Up Telerik Environment

To prepare your development machine for Telerik UI for WPF in one step, run the `setup` command in a terminal:

```powershell
telerik setup wpf
```

The `setup` command runs the following steps in sequence to prepare your environment for Telerik UI for WPF:

1. [`telerik login`](#log-in-to-your-telerik-account) to authenticate with your Telerik account.
2. [`telerik nuget config`](#set-up-telerik-nuget-feed) to add the Telerik NuGet package source.
3. [`telerik license get-key`](#get-license-key) to download and store your license key.
4. [`telerik mcp config`](#install-mcp-server) to register the Telerik MCP server configuration for the detected IDEs.

When the CLI is running in an interactive terminal, `telerik setup` prompts you through each stage. To use the command in an automated environment, pass `--no-interactive`.

When the setup completes successfully, the Telerik CLI displays the following confirmation message:

```text
Telerik UI for WPF setup complete! Your environment is configured and ready.
```

### Common `telerik setup` Options

Use the following options to customize the setup flow:

* `--scope user|project` to choose whether the Telerik NuGet source is stored in the user-level or project-level `NuGet.Config` file.
* `--nuget-path <path>` to specify the path to the `NuGet.Config` file or project directory. This option is required when `--scope project` is used.
* `--force` to overwrite an existing Telerik NuGet source configuration without prompting.
* `--no-browser` to use manual authentication when browser-based sign-in is blocked.
* `--interactive` or `--no-interactive` to control whether the command prompts for each step.
* `--json` to return machine-readable output.

For example, to configure a project-local `NuGet.Config` file without prompts:

```powershell
telerik setup wpf --scope project --nuget-path . --force --no-interactive 
```


## Log In to Your Telerik Account

Most Telerik CLI commands are related to your Telerik identity. It's recommended to log in first, so that all the other commands work without the need for additional authentication:

```powershell
telerik login
```

The `login` command opens `https://identity.telerik.com` in a browser window where you need to provide your Telerik account credentials. The browser performs a few redirects to complete the login.

If this browser integration fails due to security or network restrictions, you can authenticate manually by using the `--no-browser` option.

#### Using `--no-browser` (Manual Authentication)

If automatic browser-based authentication is blocked (for example, by corporate network policies, restricted browsers, or headless CI environments), use the `--no-browser` switch to perform a manual login flow:

```powershell
telerik login --no-browser
```

When you run `telerik login --no-browser` the CLI will:

1. Print a short URL and a one-time code in the terminal.
2. Instruct you to open the URL on any device or browser with network access (for example, your desktop browser or a browser on another machine).
3. Ask you to enter the one-time code and sign in to your Telerik account in the browser.

After successful authentication, the browser will display a confirmation message and you can return to the CLI. The CLI will detect the completed sign-in and store the session token locally.

The Telerik CLI stores a session token in:

| Operating System | Path |
| --- | --- |
| Windows | `%AppData%\Telerik` |
| macOS / Linux | `~/.telerik` |

The session token is valid for one month.

#### Check Login State

To see which Telerik user is logged in the CLI, use the `whoami` command:

```powershell
telerik whoami
```

The CLI will output your Telerik user account email.

#### Log Out from Your Telerik Account

To log out from the Telerik CLI, use the `logout` command.

```powershell
telerik logout
```

## Get License Key

To download or update your [Telerik license key]({%slug installing-license-key%}), use the `license get-key` command:

```powershell
telerik license get-key
```

The `license get-key` command downloads your up-to-date Telerik license key and creates a `telerik-license.txt` file in your operating system user's folder.


## Install MCP Server

To install the Telerik MCP servers, use the `mcp config` command:

```powershell
telerik mcp config
```

By default, the command creates or updates the global `.mcp.json` configuration files for all supported IDEs and registers all currently available Telerik MCP servers for Telerik products.

| IDE | Operating System | Configuration File Path |
| --- | --- | --- |
| Visual Studio | Windows | `%USERPROFILE%\.mcp.json` |
| VS Code | Windows | `%APPDATA%\Code\User\mcp.json`  |
| VS Code | macOS | `~/Library/Application Support/Code/User/mcp.json` |
| VS Code | Linux | `~/.config/Code/User/mcp.json`  |
| Cursor  | Windows | `%USERPROFILE%\.cursor\mcp.json` |
| Cursor | macOS, Linux | `~/.cursor/mcp.json` |

### Install WPF MCP Server

You can also fine-tune the process with the following options:

* Specify which Telerik products you are interested in, for example, just `wpf`.
* `--ide` specifies your preferred IDE. The supported values are `visualstudio`, `vscode`, `cursor`, and `all`.

```powershell
telerik mcp config wpf --ide visualstudio
```

This command installs and configures only the Telerik WPF MCP server and targets only Visual Studio by creating or updating the `.mcp.json` file with the WPF MCP entry.

### JSON Output for Scripts and CI

Use `--json` to return machine-readable output:

```powershell
telerik mcp config wpf --ide visualstudio --json
```

Example output:

```json
{
  "exitCode": 0,
  "message": "MCP servers registered successfully.",
  "data": {
    "registeredIdes": [
      "Visual Studio"
    ],
    "registered": [
      {
        "ide": "Visual Studio",
        "configPath": "C:\\Users\\username\\.mcp.json"
      }
    ]
  },
  "success": true
}
```

## Set Up Telerik NuGet Feed

To [add the Telerik NuGet server to your package sources]({%slug nuget-package-source-setup%}), use the `nuget config` command:

```powershell
telerik nuget config
```

By default, the `nuget config` command updates your [global `NuGet.Config` file](https://learn.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior). The newly added Telerik NuGet feed name is `TelerikNuGetV3`. The command generates a new API key that you can delete and revoke from the [API Keys page in your Telerik account](https://www.telerik.com/account/downloads/api-keys).

> Telerik NuGet API keys expire in two years.

You can use the `nuget config` command with the following options:

* `--scope project` and `--path` that points to the folder that contains the `NuGet.Config` file to modify. The default `--scope` value is `user`.
* `--api-key` to provide an existing Telerik NuGet API key inline, otherwise the CLI generates a new one.
* `--force` to overwrite any existing Telerik credentials in the `NuGet.Config` file.

```powershell
telerik nuget config --scope project --path . --force
```

## Help

To get help about the tool or a specific command in the Telerik CLI, use the `-h` option:

```powershell
telerik -h

telerik setup -h

telerik nuget -h

telerik nuget config -h
```

#### Uninstall Telerik CLI

To uninstall the Telerik CLI:

```powershell
dotnet tool uninstall -g Telerik.CLI
```

## Prerequisites

The following table lists the requirements to run the Telerik CLI.

| Requirement | Minimum version | Notes |
|---|---|---|
| .NET SDK | 6.0 | Required to install and run .NET global tools. |
| Operating system | Windows, macOS, or Linux | Any OS supported by the .NET SDK. |
| Telerik account | N/A | Active Subscription or Trial license required. |

## See Also

* [Set Up the Telerik NuGet Package Source]({%slug nuget-package-source-setup%})
* [First Steps with Telerik UI for WPF]({%slug nuget-setup-lifecycle%})
* [Restoring NuGet Packages in Your CI Workflow]({%slug nuget-keys%})
