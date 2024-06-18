---
title: .NET Core Project Converter
page_title: .NET Core Project Converter
description: Telerik UI for WPF allows you to create .NET Core projects. 
slug: netcore-project-converter
tags: netcore,standard,converter,migration,migrate
published: True
include_in_navigation: false
position: 2
---

# .NET Core Project Converter

>important With Q2 2024 the Project Converter is no longer supported. The converter works only with Visual Studio 2019 and .NET Core 3.1 projects. The last Telerik version where .NET Core 3.1 assemblies were distributed was 2024.1.423.

Since R2 2020 Telerik UI for WPF suite provides tooling in Visual Studio 2019, via the [Telerik Visual Studio Extension]({%slug radcontrols-for-wpf-vs-extensions-overview-wpf%}), that will convert client projects that use .NET Framework 4.8 (or lower) into .NET Core projects to ease out the migration.

> The tooling is based on the [Try-Convert](https://github.com/dotnet/try-convert) tool and the [.NET Portability Analyzer ](https://github.com/microsoft/dotnet-apiport) that Microsoft offers to help .NET developers port their projects to .NET Core. Please have in mind that even though the conversion may be successful, we don't guarantee that the project will be compiled and you may need to fine-tune the output.

This article will guide you through the conversion process:

1. Let's start with an existing Telerik WPF project that uses .NET Framework 4.5:

	![net-core-project-converter 001](images/netcore-project-converter-0.png)  

2. Navigate to the __Extensions__ menu. If the Telerik menu item is not available, click __Manage Extensions__ and download it:

	![net-core-project-converter 002](images/netcore-project-converter-1.png)  

	![net-core-project-converter 003](images/netcore-project-converter-2.png)  

3. After restarting Visual Studio, you are expected to see the __.NET Core Project Converter__ option in the __Extensions__ menu and in the project's context menu as well:

	![net-core-project-converter 004](images/netcore-project-converter-3.png)  

	![net-core-project-converter 005](images/netcore-project-converter-4.png) 

4. Run the converter and follow the wizard:

	![net-core-project-converter 006](images/netcore-project-converter-5.png)
																	   
	![net-core-project-converter 007](images/netcore-project-converter-6.png)
																	 
	![net-core-project-converter 008](images/netcore-project-converter-7.png)
																	  
	![net-core-project-converter 009](images/netcore-project-converter-8.png)
																	  
	![net-core-project-converter 010](images/netcore-project-converter-9.png)
																	   
	![net-core-project-converter 011](images/netcore-project-converter-10.png)

5. Now, the project can be run using .NET Core 3.1

6. There is a backup folder containing the initial project.

	![net-core-project-converter 012](images/netcore-project-converter-11.png)

## See Also

* [.NET Core Support Overview]({%slug netcore-support-overview%})
* [Deploying WPF .NET Core Application]({%slug netcore-support-deploy-using-visual-studio%})
