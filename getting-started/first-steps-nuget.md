---
title: First Steps
page_title: Get Started with Telerik UI for WPF
description: Learn how to create a WPF project, install Telerik UI for WPF via Telerik CLI, verify the setup, and upgrade the referenced assemblies.
slug: nuget-setup-lifecycle
tags: nuget,lifecycle,application,telerik,cli
published: True
position: 0
---

# First Steps with Telerik UI for WPF

## Prerequisites

Before you start, make sure to:

1. Install Visual Studio with the `.NET desktop development` workload.
1. Install [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.

## Set Up Telerik Development Environment

>tip If you have already set up your Telerik development environment and it doesn't need updating, skip to [Create the WPF Project](#create-the-wpf-project).

The fastest way to set up your Telerik development environment is to use the [Telerik CLI]({%slug telerik-cli%}) .NET tool commands in a command shell (cmd, powershell, etc.).

1. Install Telerik CLI

	```
	dotnet tool install -g Telerik.CLI
	```

1. Run the `telerik setup wpf` command

	```
	telerik setup wpf
	```

The `setup` command performs [multiple actions at once]({%slug telerik-cli%}) to configure your Telerik development environment - login, license key installation, nuget package source configuration and mcp server setup.

## Create the WPF Project

Create a new WPF project in Visual Studio.

1. Select __File > New > Project__.
1. Choose the __WPF Application__ template.
1. Enter the project details, like project name and directory location, and click __Create__.

## Install Telerik Packages in the Project

>important Starting with **Q3 2026**, all Telerik UI for WPF NuGet packages will be available on [NuGet.org](https://www.nuget.org/). If you install packages from NuGet.org, you do not need to configure the Telerik NuGet server.

1. Right-click on the project name in Visual Studio and select **Manage NuGet Packages**.
1. Open the **Browse** tab.
1. In the __Package source__ drop down menu on the right, make sure to select the Telerik nuget package source or the __All__ option.
1. Search for `Telerik.UI.for.Wpf.AllControls.Xaml` and install it in the project.

	```
	<PackageReference Include="Telerik.UI.for.Wpf.AllControls.Xaml" Version="*" />
	```

>tip This tutorial shows how to install the `Telerik.UI.for.Wpf.AllControls.Xaml` package that contains all Telerik WPF assemblies. To reduce the final application size, you can install only the required [separate packages]({%slug nuget-available-packages%}). For example, this demo only requires the `Telerik.Windows.Controls.Navigation.Xaml` package.

## Add Telerik Controls in the Project

1. Open the `MainWindow.xaml` file.

1. Add the `telerik` schema in XAML.

	```xaml
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	```
	
1. Add a Telerik control. For this example, we'll use `RadTabControl`.

	```xaml
	<Window x:Class="TelerikWpfApplication.MainWindow"
			xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
			xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
			xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
			xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
			xmlns:local="clr-namespace:TelerikWpfApplication" 
			xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
			mc:Ignorable="d"
			Title="MainWindow"
			Height="450"
			Width="800">
		<Grid>
			<telerik:RadTabControl>
				<telerik:RadTabItem Header="Home" />
				<telerik:RadTabItem Header="Insert" />
				<telerik:RadTabItem Header="View" />
			</telerik:RadTabControl>
		</Grid>
	</Window>
	```

1. __(optional)__ Open the `MainWindow.xaml.cs` and [set the Telerik theme]({%slug styling-apperance-implicit-styles-overview%}). This tutorial uses the [XAML]({%slug xaml-vs-noxaml%}) version of the Telerik dlls, so we need to use `StyleManager` for the theme setting.
	
	```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			StyleManager.ApplicationTheme = new Windows11Theme();
			this.InitializeComponent();
		}
	}
	```

1. Build and run the project. 

>important Telerik UI for WPF comes with two sets of dlls, named Xaml and NoXaml. This tutorial was created with the Xaml dlls set in mind. Read more about this in the [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%}) article.

## Next Steps

<article-card-container>
    <article-card
        href="/ai-assistant/overview"
        src="images/chat_light_large.svg"
        title="Use Telerik AI Tools"
        darkSrc="images/chat_dark_large.svg"
        description="Telerik UI for WPF AI-powered development assistance through a unified MCP server that delivers intelligent, context-aware help directly in your IDE.">
    </article-card>
    <article-card
        href="/introduction#list-of-components"
        src="images/editor_ai_integration_light_large.svg"
        title="Use Components"
        darkSrc="images/editor_ai_integration_dark_large.svg"
        description="Check the list of available Telerik WPF components.">
    </article-card>
    <article-card
        href="https://demos.telerik.com/wpf/"
        src="images/grid_ai_chat_integration_light_large.svg"
        title="Browse WPF Demos"
        darkSrc="images/grid_ai_chat_integration_dark_large.svg"
        description="Explore the examples via the Telerik UI for WPF Desktop Examples application.">
    </article-card>   
    <article-card
        href="/controls/radgridview/overview2"
        src="images/data_highlight_light_large.svg"
        title="Get Started with RadGridView"
        darkSrc="images/data_highlight_dark_large.svg"
        description="Bind the Telerik WPF Data Grid to data and choose from the variety of built-in features.">
    </article-card>
    <article-card
        href="/styling-and-appearance/styling-apperance-setting-a-theme-overview"
        src="images/themingt_light_large.svg"
        title="Theming"
        darkSrc="images/theming_dark_large.svg"
        description="Review the built-in themes.">
    </article-card>
</article-card-container>

## See Also
* [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})
* [Installation and Setup with Telerik CLI]({%slug telerik-cli%})