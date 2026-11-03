---
title: AI Upgrade Plugin
page_title: WPF AI Upgrade Plugin (Copilot CLI) - Telerik UI for WPF
description: Use the Telerik WPF AI Upgrade Plugin in GitHub Copilot CLI to upgrade Telerik versions, migrate assembly references to NuGet, and configure license activation.
components: ["general"]
slug: ai-upgrade-plugin
tags: telerik,wpf,ai,upgrade plugin,github copilot cli,microsoft upgrade agent,version upgrade,assembly to nuget,licensing,xaml,noxaml
position: 4
---

# AI Upgrade Plugin (Copilot CLI)

The Telerik WPF Upgrade Plugin extends Microsoft's Upgrade Agent in GitHub Copilot CLI with modernization workflows for Telerik UI for WPF. Use it to upgrade Telerik versions, migrate direct assembly references to NuGet packages, and configure licensing. It also adds Telerik-specific guidance to Microsoft's .NET upgrade scenarios while preserving your application's Xaml or NoXaml flavor.

This plugin is separate from the [Telerik WPF MCP Server]({%slug ai-mcp-server%}) and its [MCP Upgrade Assistant tool]({%slug ai-upgrade-assistant%}). The plugin orchestrates a modernization workflow through Microsoft's Upgrade Agent and uses Telerik MCP tools for tasks such as breaking-change analysis.

## Prerequisites

Before installing the plugin, make sure you have:

* <a href="https://learn.microsoft.com/en-us/dotnet/core/porting/github-copilot-upgrade/install?pivots=copilot-cli" target="_blank">GitHub Copilot CLI with Upgrade Agent support</a>.
* A Telerik account with an active DevCraft or Telerik UI for WPF license, or a <a href="https://www.telerik.com/try/ui-for-wpf" target="_blank">free trial</a>.
* .NET 10 SDK or later. The plugin uses `dnx` to run the `Telerik.WPF.MCP` tool server. This requirement applies to the tool server, not your application's target framework; the target WPF application can use any supported .NET version, including .NET Framework.
* A [Telerik license key file]({%slug installing-license-key%}) for workflows that call Telerik MCP tools.

For breaking-change analysis, the plugin also uses the [Telerik CLI]({%slug telerik-cli%}). If it is not installed, the MCP upgrade tool can prompt you to install it.

## Install the Plugin

Run the following commands inside GitHub Copilot CLI, not in your system shell.

1. Add the Microsoft and Telerik plugin marketplaces:

   ```text
   /plugin marketplace add microsoft/upgrade-agent-plugins
   /plugin marketplace add telerik/ai-plugins
   ```

2. Install Microsoft's Upgrade Agent and the Telerik WPF Upgrade Plugin:

   ```text
   /plugin install upgrade-agent@upgrade-agent-plugins
   /plugin install telerik-wpf-upgrade-plugin@telerik-ai-plugins
   ```

3. Enter `/agent` and select **Upgrade**.

4. Describe the upgrade you want to perform. For example, to update Telerik without changing the application's .NET target:

   ```text
   Upgrade Telerik UI for WPF in my solution to the latest version compatible with its current target framework.
   ```

   To upgrade both .NET and Telerik, use a prompt such as:

   ```text
   Upgrade my WPF solution to .NET 10, then upgrade Telerik UI for WPF to the latest compatible version.
   ```

   You can also specify a particular Telerik version that is available to your account.

## Select a Telerik Modernization Scenario

The agent chooses a scenario based on your request. The WPF plugin provides the following scenarios; it does not provide the WinForms control-conversion scenario.

| Scenario | Use it when | What it does |
|---|---|---|
| `telerik-wpf-version-upgrade` | Your project already uses Telerik UI for WPF and you want a newer Telerik version. | Updates NuGet packages or retargets direct assembly references in place, offers NuGet migration as an optional improvement, handles licensing as needed, and detects and addresses breaking changes. |
| `telerik-wpf-assembly-to-nuget` | You only want to replace direct Telerik assembly references with NuGet packages. | Detects the current Telerik version, reference style, and Xaml/NoXaml flavor; configures the NuGet feed; maps assemblies to packages; and migrates references without changing the Telerik version or .NET target. |
| `telerik-wpf-licensing` | You want to activate, repair, or migrate Telerik licensing. | Detects the current licensing mechanism, applies the appropriate setup or repair, and verifies activation. |

>important Telerik scenarios do not change the project's target framework. For a move to modern .NET or a newer modern .NET version, run Microsoft's `dotnet-version-upgrade` scenario first. For a change between .NET Framework versions, run `dotnet-framework-version-upgrade` first. Then run `telerik-wpf-version-upgrade` if a Telerik version upgrade is also needed. The resulting target framework determines which Telerik versions are compatible.

## Follow Scenario Progress

The plugin defines the following workflow stages. Microsoft's Upgrade Agent manages progress reporting; the exact tasks depend on the selected scenario and project assessment.

| Stage | What happens |
|---|---|
| **Pre-Initialization** | Identifies in-scope projects, checks scenario prerequisites, and confirms workflow parameters. |
| **Assessment** | Inspects the project and records relevant versions, target frameworks, reference style, Xaml/NoXaml flavor, and potential issues in `assessment.md`. |
| **Planning** | Creates an ordered task list based on the assessment, including dependencies and completion criteria, in `plan.md`. |
| **Execution** | Performs the planned tasks and validates changes. A version upgrade can update Telerik references, address breaking changes, and build the project. |
| **Post-Completion** | Summarizes completed work, verification, and any remaining issues or follow-up actions. |

## Extend Microsoft's .NET Upgrade Scenarios

The plugin adds Telerik-specific guidance to Microsoft's existing .NET Upgrade Agent scenarios. These extensions are not selectable scenarios and do not replace Microsoft's workflows.

| Extension | Extends | Telerik-specific guidance |
|---|---|---|
| `telerik-wpf-for-dotnet-framework-upgrade` | `dotnet-framework-version-upgrade` | Verifies Telerik compatibility with .NET Framework 4.8.1, offers rather than requires NuGet migration, and preserves the Xaml/NoXaml flavor. |
| `telerik-wpf-for-dotnet-version-upgrade` | `dotnet-version-upgrade` | Handles modern .NET-to-newer .NET and .NET Framework-to-modern .NET upgrades. Requires NuGet migration when direct Telerik assembly references are present and preserves the Xaml/NoXaml flavor. |

## Preserve Xaml and NoXaml Theming

Telerik UI for WPF provides [Xaml and NoXaml assembly sets]({%slug xaml-vs-noxaml%}). The plugin detects the flavor per project and preserves it when it updates or migrates references.

* **Xaml** assemblies include styles in the control assemblies and support theme selection through `StyleManager`.
* **NoXaml** assemblies use implicit styles from theme assemblies or copied theme XAML. When a project references a theme assembly, NuGet migration adds the corresponding theme package, such as `Telerik.Windows.Themes.Fluent.for.Wpf`, alongside the control packages. Projects that use copied theme XAML can keep that approach.
* Mixed Xaml and NoXaml references in one project or application block migration. The agent reports the conflicts and asks which flavor to use before it proceeds.

Theme XAML copied from a `Themes.Implicit` folder is version-specific. NuGet updates and .NET retargeting do not refresh those files. The agent asks for the updated theme source folder rather than manually rewriting theme XAML. After a .NET Framework-to-.NET migration, use the theme files from the target release's `NET` folder.

## Telerik Packages and License Activation

Assembly-to-NuGet migration uses the minimal set of Telerik UI for WPF packages that match your project's assemblies, target framework, and Xaml/NoXaml flavor. It does not replace every reference with a single all-controls package.

For Q1 2025 and later releases, Telerik control NuGet packages include `Telerik.Licensing` transitively. For projects that keep direct assembly references, the plugin detects and preserves existing script-key activation and verifies that it remains valid for the target version. An explicit `Telerik.Licensing` package reference is not universally required for that path. The licensing scenario can also set up or repair activation for add-in and plugin hosts that have no standard WPF entry point. For activation instructions, see [Installing Your Telerik License Key]({%slug installing-license-key%}).

The same Telerik license key is used for MCP tool access and NuGet-based application activation:

* `telerik-wpf-version-upgrade` requires the key because it calls Telerik MCP tools.
* `telerik-wpf-assembly-to-nuget` does not require an MCP license check before project discovery because reference migration does not call Telerik MCP tools. It checks application activation during migration builds for Q1 2025 and later packages and reports deferred missing-license warnings. Successful reference migration does not, by itself, activate the application.

On Windows, prefer the shared license file at `%AppData%\Telerik\telerik-license.txt`. The plugin also checks `TELERIK_LICENSE_PATH` and `TELERIK_LICENSE` environment variables. For project-specific NuGet activation, place `telerik-license.txt` next to the project file; do not rely on a solution-root file to activate projects in subfolders. Do not place the key in the build output or application installation folder.

## See Also

* [Telerik WPF MCP Server Setup]({%slug ai-mcp-server%})
* [Telerik WPF MCP Upgrade Assistant]({%slug ai-upgrade-assistant%})
* [Telerik CLI Migrate Analyzer]({%slug telerik-cli-migrate-analyzer%})
* <a href="https://learn.microsoft.com/en-us/dotnet/core/porting/github-copilot-upgrade/overview" target="_blank">Microsoft GitHub Copilot Upgrade Agent</a>