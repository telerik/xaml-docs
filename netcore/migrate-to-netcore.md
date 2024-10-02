---
title: Migrating to .NET
page_title: Migrating to .NET
description: This article shows how to migrate from an existing Telerik WPF .NET Framework project to a .NET 6 and later.
slug: netcore-support-migration
tags: get,started,first,steps,migrate,core,standard,visual,studio,
published: True
position: 1
---

# Migrating to .NET

This article shows how to migrate from an existing WPF .NET Framework project to a .NET one (.NET 6 or later).

1. Create a new __.NET__ application using Visual Studio. 
	
	#### Figure 1: Creating new project
	![{{ site.framework_name }} Creating new project](images/netcore-support-migration-0.png)	
	
	>tip You can also use the Telerik Visual Studio Extensions to create a new project. Read more about this in the [Integration]({%slug radcontrols-for-wpf-vs-extensions-project-creation%}) section of the documentation.
	
2. Add the existing files from the original project as linked files to the .NET project.
	
	#### Figure 2: Linking files from the original project
	![{{ site.framework_name }} Add Existing Items To Project](images/netcore-support-migration-1.png)
	
	![{{ site.framework_name }} Linking files from the original project](images/netcore-support-migration-2.png)
 
3. Reference the Telerik assemblies built against .NET.
	
	If Telerik UI for WPF is installed on the machine, you can find the dlls in the "*UI for WPF installation folder\Binaries\NET+version number*" folder. Otherwise, [download the .zip file]({%slug installation-installing-from-zip-wpf%}) with the dlls or install them via the [NuGet package manager]({%slug nuget-installation%}).
	
	#### Figure 3: Checking if a Telerik assembly is built against .NET  
	![{{ site.framework_name }} Checking if a Telerik assembly is built against .NET 6](images/netcore-support-migration-3.png)

4. Several controls rely on third party NuGet packages. These are automatically installed when adding the Telerik assemblies via NuGet or the Telerik Visual Studio Extension. In case you reference the assemblies manually, one or more of the following packages should be installed manually: `System.Data.OleDb`, `System.Drawing.Common` and `System.ServiceModel.Http`.

>tip The getting started experience in RadRichTextBox for .NET has been improved compared to its .NET Framework alternative. Check the [.NET Support]({%slug radrichtextbox-getting-started-net-core-support%}) help topic for more details on the changes you might encounter.

## See Also  
* [Deploy WPF .NET Application]({%slug netcore-support-deploy-using-visual-studio%})
* [Using RadRichTextBox in .NET]({%slug radrichtextbox-getting-started-net-core-support%})
