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

__Telerik UI for WPF__ comes with support for __.NET Core 3.1__,  __.NET 6__, __.NET 7__ and __.NET 8__.

There is are sets of DLLs built against the different .NET versions which you can reference in an application and start using the Telerik controls. There are no .NET 8 dedicated Telerik assemblies, but their .NET 7 is supported in .NET 8 projects.

See how to migrate your app in the [Migrating to .NET Core]({%slug netcore-support-migration%}) article.

> The installation approaches for the __.NET__ versions of the Telerik dlls are the same as the ones for the __.NET Framework__ version. Read more in the [Getting Started]({%slug getting-started-first-steps%}) section of the documentation. 

## .NET Core 3.1 Requirements

To work with the Telerik `.NET Core 3.1` DLLs you will need to have the following installed.

* The latest [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2019 version with the latest update. The minimum version of Visual Studio is __v16.4__. 

>important Read more about the .NET Core requirements in the [Prerequisites for .NET Core on Windows](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore2x) MSDN article.

## .NET 6 Requirements

To work with the Telerik `.NET 6` DLLs you will need to have the following installed.

* The latest [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0).

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2019 version with the latest update.

>important Read more about the .NET 6 requirements in the [Install .NET on Windows](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60) MSDN article.

## .NET 7 Requirements

To work with the Telerik `.NET 7` DLLs you will need to have the following installed.

* The latest [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2022 (v17.2 latest preview or newer).

## Design-Time Support

The Telerik controls can be drag/dropped from the __Visual Studio Toolbox__. To enable this under .NET you will need to [reference the Telerik dlls via nuget]({%slug nuget-installation%}). Installing the nuget packages will add the corresponding controls in the toolbox. Drag and drop from the toolbox is available only for the projects that have the Telerik nuget packages installed.

Additionally, the Telerik controls introduce customized design-time support as using [smart tags]({%slug common-smart-tags%}), design-time selection, and also the standard control properties changing through the __Visual Studio Designer__

>tip Creating a project via the [Telerik Visual Studio Extensions]({%slug radcontrols-for-wpf-vs-extensions-project-creation%}), allows you to select a NuGet version and automatically add the packages in the project when created, thus adding the Telerik .NET controls into the Visual Studio Toolbox.

## See Also  
* [Deploying WPF .NET Core Application]({%slug netcore-support-deploy-using-visual-studio%})
