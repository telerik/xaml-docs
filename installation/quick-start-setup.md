---
title: Installation
page_title: Setup the Telerik WPF Telerik CLI - Installation, Setup, and Command Reference for Telerik UI for WPF
description: Install and use the Telerik CLI to set up the Telerik NuGet feed, create WPF projects from templates, and update Telerik UI for WPF packages from the command line.
slug: telerik-cli
tags: telerik,cli,command line,cli,dotnet tool,nuget,setup,install,create project,update,template,wpf,telerik,getting started,environment
published: True
position: 1
---

# Quick Start Installation

The easiest way to install the Telerik UI for WPF product is to use the [Telerik CLI]({%slug telerik-cli%}). This is a .NET global tool that automates common Telerik development tasks from the command line.

## Setup Development Environment

To setup the environemnt needed to start development with Telerik UI for WPF you can install the Telerik CLI tool and all the `setup` command. This will log you into your Telerik account, download [license key]({%slug nuget-installation%}) and setup the [Telerik NuGet package source]({%slug nuget-package-source-setup%}).

1. Open any terminal and install the Telerik CLI.

	```
	dotnet tool install -g Telerik.CLI
	```
	
1. Call the `telerik setup wpf` command in the terminal.

	```
	telerik setup wpf
	```

1. Use the __NuGet Package Manager__ to install the needed Telerik packages. For example, `Telerik.UI.for.Wpf.AllControls.Xaml`. 

	```
	<PackageReference Include="Telerik.UI.for.Wpf.AllControls.Xaml" Version="*" />
	```

### Install License Key

> This step is automatically executed when the `telerik setup wpf` command is invoked.

To download and install a Telerik license key, you can use the `telerik license get-key` command.

```
telerik license get-key
```

### Setup Telerik NuGet Package Source

> This step is automatically executed when the `telerik setup wpf` command is invoked.

>important Starting with the Q3 2026 release, all Telerik UI for WPF NuGet packages will also be available on NuGet.org. If you use nuget.org, you will not need to configure the Telerik NuGet server.

To automatically configure the Telerik NuGet feed, you can use the `telerik nuget config` command. This adds a package source in the NuGet.config file that points to `https://nuget.telerik.com/v3/index.json`.

```
telerik nuget config
```

### Other Installation Options

The __recommended installation approach__ is using __Telerik CLI__ and __NuGet packages__, as it is easier to use and maintain. In addition to that, Telerik distributes several more of installation options. 

* [MSI installer]({%slug installation-guide%}#tab-2-msi-installation)

* [ZIP file]({%slug installation-guide%}#tab-3-zip-installation)

* [Visual Studio Extension]({%slug installation-guide%}#tab-4-vsx-installation)

* [Progress Control Panel]({%slug installation-guide%}#tab-5-progress-control-panel)