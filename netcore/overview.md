---
title: .NET Core Support Overview 
page_title: .NET Core Support Overview 
description: Telerik UI for WPF allows you to create .NET Core projects. 
slug: netcore-support-overview
tags: get,started,first,steps,netcore,standard,sdk,visual,studio,vs
published: True
position: 0
---

## .NET Core Support Overview 

__Telerik UI for WPF__ comes with __.NET Core__ support. There is a set of dlls built against the .NET Core framework which you can reference in an application and start using the Telerik controls. See how to migrate your app in the [Migrаting to .NET Core]({%slug netcore-support-migration%}) article.

## Requirements

To work with the Telerik .NET Core dlls you will need to have the following installed.

* The latest [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2019 version with the latest update. The minimum version of Visual Studio is __v16.4__. 

>important Read more about the .NET Core requirements in the [Prerequisites for .NET Core on Windows](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore2x) MSDN article.

## Design-Time Support

The Telerik controls can be drag/dropped from the __Visual Studio Toolbox__. To enable this under .NET Core you will need to [reference the Telerik dlls via nuget]({%slug installation-installing-from-nuget-wpf%}). Installing the nuget packages will add the corresponding controls in the toolbox. Drag and drop from the toolbox is available only for the projects that have the Telerik nuget packages installed.

Additionally, the Telerik controls introduce customized design-time support as using [smart tags]({%slug common-smart-tags%}), design-time selection, and also the standard control properties changing through the __Visual Studio Designer__

>tip Creating a project via the [Telerik Visual Studio Extensions]({%slug radcontrols-for-wpf-vs-extensions-project-creation%}), allows you to select a NuGet version and automatically add the packages in the project when created, thus adding the Telerik .NET Core controls into the Visual Studio Toolbox.

## See Also

* [Deploying WPF .NET Core Application]({%slug netcore-support-deploy-using-visual-studio%})
