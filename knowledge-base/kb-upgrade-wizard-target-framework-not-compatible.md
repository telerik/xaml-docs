---
title: "Project Target Framework Is Not Compatible" Error in Upgrade Project Wizard
description: Resolving the "Project target framework is not compatible. Please upgrade target framework." message in the Telerik UI for WPF Upgrade Project Wizard.
components: ["installerandvsextensions"]
type: troubleshooting
page_title: Project Target Framework Is Not Compatible in Upgrade Wizard
slug: kb-upgrade-wizard-target-framework-not-compatible
position: 0
tags: upgrade, wizard, target framework, not compatible, nuget, netcore, net8, net10, vs extensions
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.812| Telerik UI for WPF |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

When launching the **Upgrade Wizard** from the Visual Studio menu (**Extensions > Telerik > Telerik UI for WPF > Upgrade Wizard**), the dialog displays the following message even though the project targets a supported .NET version (such as .NET 8 or .NET 10) and a valid license key is present ("License Key File Found."):

`Project target framework is not compatible. Please upgrade target framework.`

## Cause

The **Upgrade Project Wizard** in the Progress Telerik UI for WPF Visual Studio Extension was designed specifically for legacy .NET Framework projects that use direct assembly (file-based) references.

The wizard does not support:
* **SDK-style projects** targeting modern .NET (.NET Core 3.1, .NET 6, .NET 7, .NET 8, .NET 9, .NET 10).
* Projects that reference Telerik components via **NuGet packages** (`<PackageReference>`).

When the wizard inspects an SDK-style or NuGet-based project, it cannot manage the package references through file-based distribution paths, and therefore reports that the target framework is not compatible. The presence of the "License Key File Found." message simply confirms that the extension detected a local `telerik-license.txt` file in `%appdata%\Telerik\`; it does not indicate compatibility with the Upgrade Wizard.

## Solution

Do not use the Upgrade Project Wizard for SDK-style projects that consume Telerik assemblies through NuGet packages. Instead, update the project using standard NuGet workflows.

If your modern .NET project uses direct Telerik assembly references (without NuGet), update the Telerik DLL references manually as described in [Upgrade Projects via Visual Studio Extension]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}).

### Update Packages via NuGet Package Manager

1. In Visual Studio, right-click the solution or project in **Solution Explorer** and select **Manage NuGet Packages for Solution...** (or **Manage NuGet Packages...**).
2. Switch to the **Updates** tab.
3. Select the Telerik packages (for example, `Telerik.Windows.Controls.for.Wpf.Xaml` or `Telerik.Windows.Controls.for.Wpf.NoXaml`).
4. Select the desired version and click **Update**.

### Update Directly in the Project File

You can edit the `.csproj` file directly to update the versions of all Telerik package references:

```xml
<ItemGroup>
    <PackageReference Include="Telerik.Windows.Controls.for.Wpf.Xaml" Version="2026.1.115" />
    <PackageReference Include="Telerik.Windows.Controls.Input.for.Wpf.Xaml" Version="2026.1.115" />
    <!-- Ensure Telerik.Licensing is also updated -->
    <PackageReference Include="Telerik.Licensing" Version="1.*" />
</ItemGroup>
```

### Clear Cached Build Artifacts

After updating package versions, clear the local build artifacts:

1. Close Visual Studio.
2. Delete the `bin` and `obj` folders in your project directory.
3. Reopen the solution in Visual Studio.
4. Select **Build > Clean Solution**, followed by **Build > Rebuild Solution**.

## See Also

* [Upgrade Projects via Visual Studio Extension]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})
* [Installing Telerik UI for WPF NuGet Packages]({%slug nuget-installation%})
* [Installing Your License Key]({%slug installing-license-key%})
* [.NET Support Overview]({%slug netcore-support-overview%})
