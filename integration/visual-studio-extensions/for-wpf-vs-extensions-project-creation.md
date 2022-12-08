---
title: Create Project
page_title: Create Project
description: The article shows how to use the UI for WPF Extension wizard to create a new project.
slug: radcontrols-for-wpf-vs-extensions-project-creation
tags: project,creation
published: True
position: 1
site_name: WPF
---

# Create Project

__Progress Telerik UI for WPF Extension__ allows you to quickly create an application pre-configured to use Telerik UI for WPF. 

The fastest way to have such a project is by using the Progress Telerik UI for WPF Extension menu. The following steps show how create a new project with Telerik dlls referenced.

1. Find the Telerik extensions menu in Visual Studio. The menu can appear on different places based on the Visual Studio version. With versions prior to VS 2019, the Telerik option is found as a separate option in the horizontal file menu. In VS 2019 the menu is hidden in the Extensions Visual Studio menu. __Figure 1__ shows where to find the extensions in the different Visual Studio versions.

	#### Figure 1: Telerik Visual Studio Extensions menu location in Visual Studio 2017 and 2019
	![WPF Telerik Visual Studio Extensions Menu Location in Visual Studio 2017](images/radcontrols-for-wpf-vs-extensions-project-creation-0.png)  	
	
	![WPF Telerik Visual Studio Extensions Menu Location in Visual Studio 2019](images/radcontrols-for-wpf-vs-extensions-project-creation-1.png)
	
2. Click on the __Create New Telerik Project__ option and configure the project. 

	#### Figure 2: Configure your new project menu
	![WPF Configure your new project menu](images/radcontrols-for-wpf-vs-extensions-project-creation-2.png)
	
3. In the __Create New Project Wizard__ select the project template you want to use. The wizard allows you to define a blank project with only the `Telerik.Windows.Controls.dll` referenced, or to use one of the [Office-inspired templates]({%slug visual-studio-templates%}) (Calendar, Word-Inspired, etc.). 
	
	During this step you can also select the project's language (C# or VB.NET) and also the version of Telerik UI for WPF. 
	
	#### Figure 3: Create New Project Wizard
	![WPF Create New Project Wizard](images/radcontrols-for-wpf-vs-extensions-project-creation-3.png)
		
	Creating a new .NET Core project allows you to automatically add nuget package references in the newly created project. To do this, choose a version with "NuGet" in its name from the __Create New Project Wizard__. 

	#### Figure 4: Create New Project Wizard - NuGet options
	![WPF Create New Project Wizard - NuGet options](images/radcontrols-for-wpf-vs-extensions-project-creation-4.png)

You can also start the Telerik's __Create New Project Wizard__ (see step 2) from the Visual Studio's New Project Wizard.

#### Figure 5: Visual Studio New Project Wizard
![WPF Visual Studio New Project Wizard](images/radcontrols-for-wpf-vs-extensions-project-creation-5.png)

>tip The __Create New Project Wizard__ allows you to download a Telerik version that is not available on your machine.

> If you prefer the Telerik assemblies to be copied into your solution folder, the **Copy referenced assemblies to solution and source control** option could be selected only into the [Visual Studio Extensions Options]({%slug radcontrols-vs-extensions-options%}).

## See Also
 * [Automatic Dependency Resolving]({%slug radcontrols-for-wpf-vs-extensions-automatic-resolving%})
 * [Upgrade Project]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})
 * [Download New Version]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})
 * [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
