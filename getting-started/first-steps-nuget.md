---
title: First Steps
page_title: Get Started with Telerik UI for WPF
description: Learn how to create a WPF project, install and license Telerik UI for WPF NuGet packages, and display a RadTabControl.
components: ["general"]
slug: getting-started-first-steps
tags: nuget,lifecycle,application,telerik,cli
published: True
position: 0
---

# First Steps with Telerik UI for WPF

This guide helps you create a Windows Presentation Foundation (WPF) project and display a `RadTabControl` with Progress® Telerik® UI for WPF.

## Prerequisites

Before you start:

1. Use Windows and Visual Studio with the **.NET desktop development** workload. Check the [Telerik UI for WPF system requirements]({%slug installation-system-requirements-wpf%}) for supported environments.
1. Install the [.NET 8.0 Software Development Kit (SDK)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) for this tutorial.
1. Have a Telerik account with an active subscription or [trial license](https://www.telerik.com/try/ui-for-wpf).

## Set Up Telerik Development Environment

>tip If you have already set up your Telerik development environment and it doesn't need updating, skip to [create the WPF project](#create-the-wpf-project).

To configure your development environment with the [Telerik command-line interface (CLI)]({%slug telerik-cli%}), run these commands in PowerShell:

1. Install Telerik CLI. If it is already installed, update it with `dotnet tool update -g Telerik.CLI` instead.

	```powershell
	dotnet tool install -g Telerik.CLI
	```

1. Run the `telerik setup wpf` command and follow the authentication prompts.

	```powershell
	telerik setup wpf
	```

The `setup` command signs you in, downloads your license key, and configures the Telerik NuGet source. It also registers the Model Context Protocol (MCP) server configuration. Successful setup displays `Telerik UI for WPF setup complete! Your environment is configured and ready.`

For Q3 2026 and later packages, NuGet.org requires no Telerik feed configuration or authentication. You can use [manual license key installation]({%slug installing-license-key%}#manual-license-key-installation) instead of CLI setup.

## Create the WPF Project

To create a new WPF project in Visual Studio:

1. Select **File** > **New** > **Project**.
1. Select the **WPF Application** template.
1. Enter the project name and location, select **.NET 8.0** as the target framework, and click **Create**.

## Install Telerik Packages in the Project

>important Starting with Q3 2026, Telerik UI for WPF NuGet packages are available on [NuGet.org](https://www.nuget.org/). No Telerik feed configuration or authentication is required for this source.

For earlier versions, use the [Telerik NuGet server or a local package source]({%slug nuget-package-source-setup%}).

>tip The `Telerik.UI.for.Wpf.AllControls.Xaml` package contains all Telerik WPF control assemblies. To reference only the controls you need, use the [separate Telerik UI for WPF NuGet packages]({%slug nuget-available-packages%}). This example requires `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` and `Telerik.Licensing`.

To install the packages in your WPF application project:

1. Right-click the project name in Visual Studio and select **Manage NuGet Packages**.
1. Open the **Browse** tab.
1. In the **Package source** dropdown, select **nuget.org** for Q3 2026 and later releases.
1. Search for `Telerik.UI.for.Wpf.AllControls.Xaml`, select a release version, and install it in the project.

	Visual Studio adds a `PackageReference` with the selected version to your project file. Keep that version rather than replacing it with the floating version `*`.

1. Search for `Telerik.Licensing` and install it in the same application project.

>important NuGet-based projects require both the `Telerik.Licensing` package and a license key, even when packages come from NuGet.org. CLI setup downloads the key but does not replace the package requirement. See [license key installation]({%slug installing-license-key%}) for details.

## Add Telerik Controls in the Project

To add a `RadTabControl` to the WPF application:

1. Open the `MainWindow.xaml` file.

1. Add this namespace declaration to the existing `Window` opening tag in `MainWindow.xaml`. This Extensible Application Markup Language (XAML) attribute fragment maps the `telerik` prefix to the controls:

	```xaml
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	```
	
1. Replace the empty `Grid` in `MainWindow.xaml` with this fragment. Keep the existing `Window`, including its generated `x:Class` and namespace declarations. These must match your project's code-behind:

	```xaml
	<Grid>
		<telerik:RadTabControl>
			<telerik:RadTabItem Header="Home" />
			<telerik:RadTabItem Header="Insert" />
			<telerik:RadTabItem Header="View" />
		</telerik:RadTabControl>
	</Grid>
	```

1. Optionally, [set the theme with `StyleManager`]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager). This tutorial uses Xaml assemblies, which support this approach. To apply Windows11 to the control, add this attribute fragment to the existing `telerik:RadTabControl` opening tag:
	
	```xaml
	telerik:StyleManager.Theme="Windows11"
	```

1. Build and run the project. Verify that the window displays the **Home**, **Insert**, and **View** tab headers. The tab content is empty because this example sets only headers.

>important Telerik UI for WPF provides Xaml and NoXaml assemblies. Use Xaml assemblies for this tutorial and do not mix the two sets. See the [Xaml and NoXaml comparison]({%slug xaml-vs-noxaml%}) for their different theme requirements.

If package installation fails, check the selected version and [package source configuration]({%slug nuget-package-source-setup%}). If the build reports license errors or the application displays a watermark, check the [license activation errors and solutions]({%slug license-activation-errors-and-warnings%}).

## Next Steps

* [Get AI-powered development help with Telerik AI tools]({%slug ai-overview%})
* [Explore the available Telerik UI for WPF components]({%slug introduction%}#list-of-components)
* [Browse the Telerik UI for WPF desktop demos](https://demos.telerik.com/wpf/)
* [Explore the Telerik WPF Data Grid and its features]({%slug gridview-overview2%})
* [Choose a Telerik UI for WPF theme]({%slug styling-apperance-implicit-styles-overview%})

## See Also
* [Compare Xaml and NoXaml assemblies]({%slug xaml-vs-noxaml%})
* [Installation and Setup with Telerik CLI]({%slug telerik-cli%})