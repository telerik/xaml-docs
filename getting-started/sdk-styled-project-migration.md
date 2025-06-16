---
title: Migrate to SDK-Style .NET Framework Project
page_title: Migrate to SDK-Style .NET Framework Project
description:  Migrate to SDK-Style .NET Framework Project.
slug: sdk-styled-project-migration
tags: upgrading,telerik,ui,trial,to,telerik,ui,developer,license,or,newer,version,netframework
published: True
position: 4
---

# Migrate to SDK-Style .NET Framework Project

The SDK-Style project template is a modernized way of creating .NET projects which was introduced with .NET Core.

The [SDK-Style projects](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview) are basically a set of MSBuild targets and tasks that execute the project-related tasks like compiling, packing, and publishing code. It is used by default when creating .NET projects in Visual Studio, but it is supported also in .NET Framework projects (starting with .NET Framework 4.6.2), where the classic project template is still used by default. 

## General Recommendation

The __general recommendation__ here is to __migrate to .NET__ which has noticeable performance improvements compared to .NET Framework. The newer framework also comes with other improvements related to security, testing, better APIs and more. Additional to that, .NET comes with a long term support from Microsoft.

If you cannot migrate to .NET, you can still improve your .NET Framework project by using the SDK-Style template. This change will bring the __following benefits__.

## Why to Use the SDK-Style Project Template

* Simplified and much cleaner project definition. Instead of defining each file, reference and setting in the .csproj file, a lot of these come automatically from the SDK.
* Improved NuGet package management. Using this approach will allow you to use the [PackageReference](https://learn.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files) approach more easily. Edits in the packages configuration can happen very swiftly by just updating the `.csproj` file.
* Multi-targeting support. You can define multiple target frameworks (net462, net48, net8, etc.) and the build will output files for the different frameworks. Previously you needed to use multiple projects or define conditions in the .csproj file that handle these cases and also run multiple builds.
* Full support for the dotnet CLI.
* Easier migration to .NET in the future.

## Migrating to the SDK-Style Template

The following guide describes how to update your project .NET Framework project to use the newer project template. This approach is applicable for .NET Framework 4.6.2 to 4.8 projects.

1. Open the `.csproj` file of the project and replace its contents with the following XML.

	#### __[XML]__
	{{region sdk-styled-project-migration-0}}
		<Project Sdk="Microsoft.NET.Sdk">
			<PropertyGroup>
				<OutputType>WinExe</OutputType>
				<TargetFramework>net48</TargetFramework>
				<UseWPF>true</UseWPF>
			</PropertyGroup>
		</Project>
	{{endregion}}	
	
	If you have settings specific to your build you may want to re-apply them in the new .csproj file definition.
	
1. Go to the __Properties__ folder of the project and remove the following assembly attributes from the `AssemblyInfo.cs` file.

	#### __[C#]__
	{{region sdk-styled-project-migration-1}}
		//[assembly: AssemblyConfiguration("")]
		//[assembly: AssemblyCompany("Progress")]
		//[assembly: AssemblyProduct("WpfApp1")]
		//[assembly: AssemblyVersion("1.0.0.0")]
		//[assembly: AssemblyFileVersion("1.0.0.0")]
	{{endregion}}	

	If you don't have anything custom in the `AssemblyInfo.cs` file you can delete it instead of removing only the specific attributes.
	
 	Also, if you don't have custom settings in the `Resources.resx` or the `Settings.settings` file you can __delete the entire Properties folder__.

1. Build and run your project.

### Moving NuGets from the packages.config file to PackageReferences

If you use NuGet packages installed with the `packages.config` file you can move them in a new `ItemGroup` added in the `.csproj` file. The following example shows before and after NuGet definition:

#### __[XML] packages.config definition (before)__
{{region sdk-styled-project-migration-2}}
	<packages>
		<package id="Telerik.Windows.Controls.for.Wpf.Xaml" version="2025.2.521" targetFramework="net46" />
		<package id="Telerik.Windows.Controls.Navigation.for.Wpf.Xaml" version="2025.2.521" targetFramework="net46" />
		<package id="Telerik.Windows.Controls.GridView.for.Wpf.Xaml" version="2025.2.521" targetFramework="net46" />
	</packages>
{{endregion}}	

#### __[XML] PackageReference definitions (after)__
{{region sdk-styled-project-migration-3}}
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
{{endregion}}	

## See Also  
* [.NET Project SDKs](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview)
* [Demystifying the SDK Project](https://dansiegel.net/post/2018/08/21/demystifying-the-sdk-project)
* [Installing UI for WPF Using NuGets]({%slug nuget-installation%})
