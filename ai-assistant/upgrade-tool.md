---
title: Upgrade Tool
page_title: Telerik UI for WPF Upgrade Tool
description: Learn how to use the telerik_upgrade_assistant tool from the Telerik WPF MCP Server to analyze your WPF projects for breaking changes when upgrading between Telerik UI for WPF versions.
slug: ai-upgrade-tool
tags: telerik,wpf,ai,coding assistant,upgrade,migration,breaking changes,mcp
position: 2
---

# Telerik UI for WPF Upgrade Tool

The `telerik_upgrade_assistant` tool is part of the [Telerik WPF MCP Server]({%slug ai-mcp-server%}) (version 1.8.0 and later). It helps you analyze your existing WPF projects for breaking changes when upgrading between Telerik UI for WPF versions.

The tool integrates with the [Telerik CLI]({%slug telerik-cli%}) (`telerik migrate analyze` command) and returns structured findings to the AI model, which can then interpret and apply the necessary code fixes automatically.

## Prerequisites

To use the upgrade tool, you need:

* The [Telerik WPF MCP Server]({%slug ai-mcp-server%}) version 1.8.0 or later installed and configured.
* The [Telerik CLI]({%slug telerik-cli%}) global .NET tool. If not already installed, the upgrade tool will detect this and prompt you to install it automatically.
* A WPF project (`.csproj`) that references Telerik UI for WPF assemblies.

>tip If the Telerik CLI is not installed on your machine, the tool will ask for your permission to install it via `dotnet tool install --global Telerik.CLI`. It will also check for available updates and apply them when needed.

## How It Works

The upgrade tool follows a four-step process:

1. **CLI Readiness**&mdash;Checks whether the `Telerik.CLI` is installed globally (`dotnet tool list --global`). If it is missing, the tool asks for your permission and installs it. It also checks for updates via `telerik upgrade --global` and applies them if needed.

2. **Project Resolution**&mdash;Validates the provided `.csproj` path. If the path is invalid or missing, the tool uses MCP elicitation to prompt you for the correct path directly in the IDE.

3. **Analysis**&mdash;Invokes the `telerik migrate analyze --product wpf --project <path-to-csproj> --json` command. When `--from-version` and `--to-version` are explicitly provided, the tool passes them to the CLI. Otherwise, the CLI auto-detects the currently installed Telerik version.

4. **Results**&mdash;Parses the JSON output and returns a structured markdown report grouped by file, including line numbers, member names, change kinds, old/new signatures (if available), and a next-steps section for the AI model to act on.

## Telerik CLI Command Options

The underlying `telerik migrate analyze` command supports the following options for the WPF product:

| Option | Description |
|--------|-------------|
| `--product wpf` | Specifies the Telerik product to analyze (required). |
| `--project <path>` | Path to a `.csproj` file to analyze. |
| `--directory <path>` | Path to a directory containing source files to analyze. |
| `--file <paths>` | One or more specific source files to analyze. |
| `--from-version <version>` | The source Telerik version to migrate from. Auto-detected if omitted. |
| `--to-version <version>` | The target Telerik version to migrate to. Defaults to the latest version if omitted. |
| `--json` | Returns machine-readable JSON output (used internally by the MCP tool). |

#### Example CLI Commands

```powershell
# Analyze an entire WPF project
telerik migrate analyze --product wpf --project ./MyApp.csproj

# Specify a version range and analyze a directory
telerik migrate analyze --product wpf --directory ./src --from-version 2024.4.1111 --to-version 2025.1.130

# Analyze specific files with JSON output
telerik migrate analyze --product wpf --file Form1.cs Form2.cs --json
```

## Understanding the Results

The upgrade tool returns a structured report that includes:

* **File path**&mdash;The source file where a breaking change was detected.
* **Line number**&mdash;The exact line in the file.
* **Member name**&mdash;The affected API member (property, method, event, or class).
* **Change kind**&mdash;The type of breaking change (removed, renamed, signature changed, etc.).
* **Old signature**&mdash;The previous API signature (when available).
* **New signature**&mdash;The replacement API signature (when available).
* **Next steps**&mdash;Recommended actions for resolving each finding.

The AI model uses this information to suggest precise code modifications or apply them directly to your project files.

## See Also

* [Telerik WPF MCP Server]({%slug ai-mcp-server%})
* [Telerik CLI]({%slug telerik-cli%})
* [Telerik WPF AI Coding Assistant Overview]({%slug ai-overview%})
