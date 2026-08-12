---
title: Analyze API Changes Before Upgrade
page_title: Telerik CLI migrate analyze - Detect WPF Breaking Changes
description: Use the Telerik CLI migrate analyze command to scan Telerik UI for WPF projects for API breaking changes between versions before upgrading.
slug: telerik-cli-migrate-analyzer
tags: telerik,cli,migrate,analyze,breaking changes,upgrade,upgrading,wpf,command line
published: True
position: 5
tag: new
---

# Detecting Breaking Changes with the Telerik CLI migrate Command

The `migrate analyze` command of the [Telerik CLI]({%slug telerik-cli%}) scans your Telerik UI for WPF source code and reports API breaking changes between two product versions. Use it before upgrading a project to a newer Telerik release to find out which of your usages need to change.

## Why Use the migrate Command

Upgrading to a newer Telerik UI for WPF release can occasionally involve breaking API changes, such as removed or renamed members. Instead of upgrading blindly and fixing compiler errors one at a time, `migrate analyze` scans your project up front and lists every affected file, the exact line and column, and guidance on how to update the code. The command works through static analysis, so it doesn't require your project to build successfully first.

## Prerequisites

The `migrate analyze` command requires the Telerik CLI to be installed as a .NET global tool.

```powershell
dotnet tool install -g Telerik.CLI
```

For more information, see [Setup and Installation with Telerik CLI]({%slug telerik-cli%}#how-to-install-the-telerik-cli).

## Quick Start

To analyze a project and let the command auto-detect your current Telerik version from the project references, run the following command.

```powershell
telerik migrate analyze --product wpf --project ./MyWpfApp.csproj
```

>note Auto-detection relies on the project referencing Telerik packages or assemblies in a recognizable way. If the command cannot determine your current version, pass `--from-version` explicitly.

## More Usage Examples

To pin an explicit version range instead of relying on auto-detection, use `--from-version` and `--to-version`.

```powershell
telerik migrate analyze --product wpf --project ./MyWpfApp.csproj --from-version 2020.3.915 --to-version 2026.2.701
```

To scan a source directory recursively without a project file, use `--directory`.

```powershell
telerik migrate analyze --product wpf --directory ./src --from-version 2024.4.1111
```

To analyze only specific files, use `--file` with one or more space-separated paths.

```powershell
telerik migrate analyze --product wpf --file MainWindow.xaml MainWindow.xaml.cs --from-version 2024.4.1111
```

To get machine-readable output for scripting or CI pipelines, add `--json`.

```powershell
telerik migrate analyze --product wpf --project ./MyWpfApp.csproj --json
```

## Output Formats

By default, the command prints a human-readable table to the console.

```text
Telerik version range: 2020.3.915 → 2026.2.701
Files discovered: 42, analyzed: 18
Breaking changes found: 7

--------------------------------------------------------------------------------
C:\MyApp\Views\ShellView.xaml
--------------------------------------------------------------------------------
  L14:C32  [Removed]  RadRibbonView.AllTabsEqualHeight
           This property was not used.
  L19:C45  [Removed]  QuickAccessToolBar.Position
           Use the QuickAccessToolBarPosition property of the RadRibbonView instead.
```

Pass the `--json` param to the `migrate` command to get the same information as structured data, suitable for CI pipelines.

```json
{
  "exitCode": 1,
  "message": "Analysis complete (2020.3.915 → 2026.2.701). 7 breaking change(s) detected.",
  "success": false,
  "data": [
    {
      "filePath": "C:\\MyApp\\Views\\ShellView.xaml",
      "line": 14,
      "column": 32,
      "typeName": "RadRibbonView",
      "member": "AllTabsEqualHeight",
      "memberKind": "property",
      "changeKind": "removed",
      "old": "",
      "new": "",
      "message": "This property was not used.",
      "confidence": "direct"
    }
  ]
}
```

To save the results to a file for later review, redirect the output.

```powershell
telerik migrate analyze --product wpf --project ./MyWpfApp.csproj --json > findings.json
```

## See Also

* [Setup and Installation with Telerik CLI]({%slug telerik-cli%})
* [Continue with the First Steps for Telerik UI for WPF]({%slug getting-started-first-steps%})
