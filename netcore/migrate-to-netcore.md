---
title: Migrating to .NET Core
page_title: Migrating to .NET Core
description: This article shows how to migrate from an existing Telerik WPF .NET Framework project to a .NET Core one.
slug: netcore-support-migration
tags: get,started,first,steps,migrate,core,standard,visual,studio,
published: True
position: 1
---

# Migrating to .NET Core

This article shows how to migrate from an existing WPF .NET Framework project to a .NET one (.NET Core 3.1, .NET 5, .NET 6 or .NET 7).

>tip Before proceeding with this topic you can check if your application's code is compatible with .NET Core using the [Microsoft Portability Analyzer](https://devblogs.microsoft.com/dotnet/are-your-windows-forms-and-wpf-applications-ready-for-net-core-3-0/) tool.

1. Create a new __.NET Core 3.1__ application using Visual Studio. 
	
	#### Figure 1: Creating new project
	![WPF Creating new project](images/netcore-support-migration-0.png)	
	
	>tip You can also use the Telerik Visual Studio Extensions to create a new project. Read more about this in the [Integration]({%slug radcontrols-for-wpf-vs-extensions-project-creation%}) section of the documentation.
	
2. Add the existing files from the original project as linked files to the .NET Core project.
	
	#### Figure 2: Linking files from the original project
	![WPF Add Existing Items To Project](images/netcore-support-migration-1.png)
	
	![WPF Linking files from the original project](images/netcore-support-migration-2.png)
 
3. Reference the Telerik assemblies built against .NET Core 3.1.
	
	If Telerik UI for WPF is installed on the machine, you can find the dlls in the "*UI for WPF installation folder\Binaries\NetCore*" folder. Otherwise, [download the .zip file]({%slug installation-installing-from-zip-wpf%}) with the dlls or install them via the [NuGet package manager]({%slug nuget-installation%}).
	
	#### Figure 3: Checking if a Telerik assembly is built against .NET Core 3.1
	![WPF Checking if a Telerik assembly is built against .NET Core 3.1](images/netcore-support-migration-3.png)
	
4. If you are not using nuget packages to install the Telerik dlls, you will need to install the [Microsoft.Windows.Compatibility](https://www.nuget.org/packages/Microsoft.Windows.Compatibility) package manually.

## Tips

* If your project has images with [__Build Action__](https://docs.microsoft.com/en-us/visualstudio/ide/build-actions?view=vs-2019) set to Resource, change it to Embeded Resource or Content.

* If you use the __AssemblyInfo__ or __App.manifest__ files from your original project, add them manually in the .NET Core project. The new project template uses a different approach and generates the same assembly attributes as part of the build process.
	
	#### __[XML] Example 1: GenerateAssemblyInfo attribute__
	{{region netcore-support-migration-0}}
		<generateassemblyinfo>false</generateassemblyinfo>
	{{endregion}}

* The getting started experience in RadRichTextBox for .NET Core has been improved compared to its .NET Framework alternative. Check the [.NET Core Support]({%slug radrichtextbox-getting-started-net-core-support%}) help topic for more details on the changes you might encounter.

## See Also

* [Deploy WPF .NET Core Application]({%slug netcore-support-deploy-using-visual-studio%})
* [Using RadRichTextBox in .NET Core]({%slug radrichtextbox-getting-started-net-core-support%})
