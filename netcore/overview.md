---
title: .NET Support Overview 
page_title: .NET Core Support Overview 
description: Telerik UI for WPF allows you to create .NET Core, .NET 6 and dot NET 7 and 8 projects. 
slug: netcore-support-overview
tags: get,started,first,steps,netcore,standard,sdk,visual,studio,vs
published: True
position: 0
---

# .NET Support Overview 

__Telerik UI for WPF__ comes with support for __.{{ site.minimum_net_core_version }}__ and later.

Telerik provides sets of DLLs built against the different .NET versions which you can reference in an application and start using the Telerik controls. 

See how to migrate your app in the [Migrating to .NET Core]({%slug netcore-support-migration%}) article.

The installation approaches for the __.NET__ versions of the Telerik dlls are the same as the ones for the __.NET Framework__ version. Read more in the [Getting Started]({%slug getting-started-first-steps%}) section of the documentation. The additional setting for .{{ site.minimum_net_core_version }} and later is that several controls rely on third party NuGet packages. These are automatically installed when adding the Telerik assemblies via NuGet or the Telerik Visual Studio Extension. In case you reference the assemblies manually, one or more of the following packages should be installed manually: `System.Data.OleDb`, `System.Drawing.Common` and `System.ServiceModel.Http`.

## .{{ site.minimum_net_core_version }} Requirements

To work with the Telerik .{{ site.minimum_net_core_version }} DLLs you will need to have the following installed.

* The latest [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2022 (v17.2 latest preview or newer).

## Design-Time Support and Visual Studio ToolBox

The Telerik controls can be drag/dropped from the __Visual Studio Toolbox__. To enable this under .NET you will need to [reference the Telerik dlls via nuget]({%slug nuget-installation%}). Installing the nuget packages will add the corresponding controls in the toolbox. Drag and drop from the toolbox is available only for the projects that have the Telerik nuget packages installed.

Additionally, the Telerik controls introduce customized design-time support as using [smart tags]({%slug common-smart-tags%}), design-time selection, and also the standard control properties changing through the __Visual Studio Designer__

>tip Creating a project via the [Telerik Visual Studio Extensions]({%slug radcontrols-for-wpf-vs-extensions-project-creation%}), allows you to select a NuGet version and automatically add the packages in the project when created, thus adding the Telerik .NET controls into the Visual Studio Toolbox.

## See Also  
* [Telerik Version Distributions]({%slug installation-distributions%})
* [Deploying WPF .NET Core Application]({%slug netcore-support-deploy-using-visual-studio%})
