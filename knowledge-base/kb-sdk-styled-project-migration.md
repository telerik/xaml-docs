---
title: How to Migrate a .NET Framework Project to SDK-Style
description: Convert an existing Telerik UI for WPF .NET Framework project to SDK-style format and move packages.config dependencies to PackageReference.
type: how-to
page_title: Migrate .NET Framework Project to SDK-Style
slug: kb-sdk-styled-project-migration
position: 0
tags: migration, sdk-style, csproj, net framework, packagereference, packages config
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to modernize an existing .NET Framework project by converting it to the SDK-style project format.

SDK-style projects simplify project files, improve NuGet package management, support multi-targeting, and make future migration to .NET easier.

## Solution

The general recommendation is to migrate to .NET when possible, because it provides better performance and long-term support.

If you must stay on .NET Framework, you can still improve maintainability by converting the project to SDK-style.

### Why use SDK-style for .NET Framework projects

* Simplified and cleaner project definition. Instead of explicitly defining each file and reference in the .csproj file, much of this is handled by the SDK.
* Improved NuGet package management through [PackageReference](https://learn.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files).
* Multi-targeting support (for example, net462, net48, net8).
* Full support for the dotnet CLI.
* Easier future migration to .NET.

### Convert to SDK-style

1. Open the project `.csproj` file and replace its content with:

	```xml
	<Project Sdk="Microsoft.NET.Sdk">
		<PropertyGroup>
			<OutputType>WinExe</OutputType>
			<TargetFramework>net48</TargetFramework>
			<UseWPF>true</UseWPF>
		</PropertyGroup>
	</Project>
	```

	If you have build-specific settings, re-apply them in the new `.csproj` file.

2. In the project's __Properties__ folder, remove the following assembly attributes from `AssemblyInfo.cs`:

	```csharp
	//[assembly: AssemblyConfiguration("")]
	//[assembly: AssemblyCompany("Progress")]
	//[assembly: AssemblyProduct("WpfApp1")]
	//[assembly: AssemblyVersion("1.0.0.0")]
	//[assembly: AssemblyFileVersion("1.0.0.0")]
	```

	If you do not have custom code in `AssemblyInfo.cs`, you can delete the file instead.

	If you also do not have custom settings in `Resources.resx` or `Settings.settings`, you can delete the entire __Properties__ folder.

3. Build and run the project.

### Move NuGet definitions from packages.config to PackageReference

If you use `packages.config`, move the Telerik package references into an `ItemGroup` in the `.csproj` file.

__packages.config (before)__
```xml
	<packages>
		<package id="Telerik.Windows.Controls.for.Wpf.Xaml" version="2025.2.521" targetFramework="net46" />
		<package id="Telerik.Windows.Controls.Navigation.for.Wpf.Xaml" version="2025.2.521" targetFramework="net46" />
		<package id="Telerik.Windows.Controls.GridView.for.Wpf.Xaml" version="2025.2.521" targetFramework="net46" />
	</packages>
```

__PackageReference (after)__
```xml
	<Project Sdk="Microsoft.NET.Sdk">
		<PropertyGroup>
			<OutputType>WinExe</OutputType>
			<TargetFramework>net48</TargetFramework>
			<UseWPF>true</UseWPF>
		</PropertyGroup>
		<ItemGroup>
			<PackageReference Include="Telerik.Windows.Controls.for.Wpf.Xaml" Version="2025.2.521" />
			<PackageReference Include="Telerik.Windows.Controls.Navigation.for.Wpf.Xaml" Version="2025.2.521" />
			<PackageReference Include="Telerik.Windows.Controls.GridView.for.Wpf.Xaml" Version="2025.2.521" />
		</ItemGroup>
	</Project>
```

## See Also

* [.NET Project SDKs](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview)
* [Demystifying the SDK Project](https://dansiegel.net/post/2018/08/21/demystifying-the-sdk-project)
* [Installing UI for WPF Using NuGets]({%slug nuget-installation%})
