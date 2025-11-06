---
title: MCP Server as a NuGet Package
page_title: Telerik WPF MCP (Model Context Protocol) Server as a NuGet Package
description: Learn how to add and use the Telerik WPF MCP Server via a NuGet package with the dnx command as a WPF AI coding assistant and code generator for better developer productivity. The Telerik WPF MCP server provides proprietary context about Telerik UI for WPF to AI-powered software.
slug: ai-mcp-server-as-a-nuget
tags: telerik,WPF,ai,ai server,dotnetWPF,coding assistant,nuget
position: 25
---

# Telerik WPF MCP Server (NuGet)

The Telerik WPF [MCP (Model Context Protocol) Server](https://modelcontextprotocol.io/introduction) is also available as a NuGet package. This NuGet distribution exposes the same AI Coding Assistant functionality as the npm package, but is executed through the `dnx` command introduced with the .NET 10 SDK. It supplies specialized context about Telerik UI for WPF components so AI-powered IDEs and tools can generate more accurate, tailored XAML and C# code.

## Prerequisites

To use the Telerik WPF MCP server via NuGet, you need:

* .NET 10 SDK (Preview 6 or newer) installed. The SDK is required for the `dnx` command.
* An [MCP-compatible client](https://modelcontextprotocol.io/clients) that supports MCP tools (latest version recommended).
* A WPF project targeting `net10.0-windows` if you want local project context to be part of AI responses.
* A valid [Telerik license key]({%slug installing-license-key%}).

## Server Installation

The NuGet-based server does not require a manual `dotnet add package` step. The `dnx` command will download and execute the NuGet package on demand.

## Server Configuration

Use these settings when configuring the server in your MCP client:

| Setting | Value |
|---------|-------|
| Package Name | `Telerik.WPF.MCP` |
| Type | `stdio` |
| Command | `dnx` |
| Arguments | `Telerik.WPF.MCP`, `--yes` |
| Server Name | `telerik-wpf-assistant` (customizable) |

### Workspace-Specific Setup

Add a `.mcp.json` file to your solution (root) folder:

```json
{
  "inputs": [],
  "servers": {
    "telerik-wpf-assistant": {
      "type": "stdio",
      "command": "dnx",
      "args": ["Telerik.WPF.MCP", "--yes"],
      "env": {
        "TELERIK_LICENSE_PATH": "THE_PATH_TO_YOUR_LICENSE_FILE",
        // or
        "TELERIK_LICENSE": "YOUR_LICENSE_KEY"
      }
    }
  }
}
```

Restart Visual Studio and enable the `telerik-wpf-assistant` tool in the [Copilot Chat window's tool selection dropdown](https://learn.microsoft.com/en-us/visualstudio/ide/mcp-servers?view=vs-2022#configuration-example-with-github-mcp-server).

![](images/ai-mcp-server-0.png)

### Global Setup

To enable the server globally for all projects, add the `.mcp.json` file to your user directory (`%USERPROFILE%`, e.g., `C:\Users\YourName\.mcp.json`).

## License Configuration

Add your [Telerik license key]({%slug installing-license-key%}) using one of these options in the `env` section.

__Option 1: License File Path (Recommended)__

```json
"env": {
  "TELERIK_LICENSE_PATH": "THE_PATH_TO_YOUR_LICENSE_FILE"
}
```

The `THE_PATH_TO_YOUR_LICENSE_FILE` should point to the `telerik-license.txt` file, usually in the AppData folder. Often it will look like:

`"TELERIK_LICENSE_PATH": "%appdata%/Telerik/telerik-license.txt"`

__Option 2: Direct License Key__

```json
"env": {
  "TELERIK_LICENSE": "YOUR_LICENSE_KEY_HERE"
}
```

> Option 1 is recommended unless you're sharing settings across different systems. Remember to [update your license key]({%slug installing-license-key%}#updating-your-license-key) when necessary.

## Visual Studio Usage

After configuration and restart:

1. Open Copilot Chat.
2. Enable the `telerik-wpf-assistant` tool.
3. Grant permissions when prompted (per session, workspace, or always).

![](images/ai-mcp-server-1.png)

Start fresh sessions for unrelated prompts to avoid context pollution. You can check the Output pane of Visual Studio for diagnostics (select output from GitHub Copilot).

![](images/ai-mcp-server-2.png)

## Usage

Begin prompts with any of these triggers to explicitly invoke the server:

- `/telerik` / `@telerik` / `#telerik`
- `/telerikwpf` / `@telerikwpf` / `#telerikwpf`
- `#telerik-wpf-assistant`

## Sample Prompts

Examples you can try:

* `/telerik Give me an example of binding an ObservableCollection<Customer> to a RadGridView, including sorting and grouping.`
* `/telerikWPF Create a RadComboBox bound to a list of countries in MVVM, displaying country names but binding the SelectedValue to a CountryCode property.`
* `/telerik Show XAML and ViewModel code for a RadTreeView bound to a hierarchical ObservableCollection<Category> where each category contains products. Expand all categories by default.`

## Number of Requests

@[template](/_contentTemplates/ai-coding-assistant.md#number-of-requests)

## See Also

* [Telerik WPF GitHub Copilot Extension]({%slug ai-copilot-extension%})
* [AI Coding Assistant Overview]({%slug ai-overview%})
* [npm-based Telerik WPF MCP Server]({%slug ai-mcp-server%})
