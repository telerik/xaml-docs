---
title: Installing UI for WPF (Using ZIP File)
page_title: Installing Telerik UI from ZIP File
description: The article describes how to install the Telerik WPF product using the zip archive file.
slug: installation-installing-from-zip-wpf
tags: installing,ui,for,from,zip,file
published: True
position: 6
---

# Installing UI for WPF Using ZIP File

This article describes how to install Telerik UI for WPF manually from a ZIP file. 

> Note that the recommended installation approach is to use the [Telerik NuGet packages]({%slug nuget-installation%})

## Downloading ZIP Package

Open the [Telerik UI for WPF download page](https://www.telerik.com/account/product-download?product=RCWPF) and download the `Telerik_UI_for_WPF_[version]_[license]_Dlls.zip` file. Then, extract the .zip file in the desired location. 

The .zip contains the Telerik dlls along with some extra files. The following shows the contents of the archive:

* __Binaries__: Contains the XAML version of the Telerik dlls.

* __Binaries.NoXaml__: Contains the the NoXaml verison of the Telerik dlls.

	Read more about this in the [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%}) article.

* __LicenseAgreements__: Contains the UI for WPF EULA, and the license agreements of any third party libraries used by UI for WPF.

* __Themes.Implicit__: Contains .xaml resource files (ResourceDictionaries) holding all the styles and templates of the Telerik controls.

## Using the Telerik dlls in a WPF Project

To use the Telerik dlls, create a new WPF project using the Visual Studio project template from the __File --> New --> Project__ menu. 

![WPF Create WPF Application](images/msi-or-zip-setup-lifecyle-0.png)

Set a __Project name__ and __Location__ for the project. For this example, we will use `TelerikWPFApplication` for the project's name.

![WPF Setup Project Name and Location](images/msi-or-zip-setup-lifecyle-1.png)

This will create an empty WPF project where you can reference the Telerik dlls.

![WPF Empty Project Visual Studio](images/msi-or-zip-setup-lifecyle-2.png)

### Referencing Telerik Assemblies

Use the Visual Studio's Reference Manager to browse and reference the Telerik dlls. 

![WPF Reference Manager](images/msi-or-zip-setup-lifecyle-3.png)
![WPF Reference Manager Browse Dialog](images/msi-or-zip-setup-lifecyle-4.png)
![WPF Added References](images/msi-or-zip-setup-lifecyle-5.png)

If you need to set a [Telerik theme]({%slug common-styling-appearance-available-themes%}) different than the default one check the [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%}) and the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) articles.

### Installing a License Key

To use the Telerik WPF product you will need to install a valid license key. Otherwise, you will see warning messages and banners related to the licensing. See how to activate a license in the [Installing License Key]({%slug installing-license-key%}) article.

### Adding Telerik Controls

After you create the WPF project and reference the Telerik assemblies, add any UI and related code-behind, models, and styles. This example will show a fundamental setup, including a RadTabControl with few tabs defined in XAML.

__Adding Telerik control in the UI__
```XAML
	<Window x:Class="TelerikWpfApplication.MainWindow"
		xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
		xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
		xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
		xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
		xmlns:local="clr-namespace:TelerikWpfApplication" xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		mc:Ignorable="d"
		Title="MainWindow" Height="450" Width="800">
		<Grid>
			<telerik:RadTabControl>
				<telerik:RadTabItem Header="Home" />
				<telerik:RadTabItem Header="Insert" />
				<telerik:RadTabItem Header="View" />
			</telerik:RadTabControl>
		</Grid>
	</Window>
```

![WPF Project with Added Tab Control](images/msi-or-zip-setup-lifecyle-6.png)

### Deploying the Application

To deploy a WPF application, you can use several different approaches, like XCopy, ClickOnce, or Windows Installer deployment. Read more about this in the [Deploy a WPF Application](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/app-development/deploying-a-wpf-application-wpf?view=netframeworkdesktop-4.8) MSDN article. 

### Redistributing Telerik Application

Several rules should be kept in mind when redistributing an application with Telerik dlls. Read more about this in the [Redistributing Telerik Assemblies]({%slug protecting-telerik-radcontrols-assembly%}) article.

### Upgrading the Project

To upgrade the project, download the new version of the .msi or the .zip file and install it accordingly. Then remove the old Telerik references from the WPF project and [include the new ones](#referencing-telerik-assemblies). At this point, double-check if all the Telerik assemblies have the same version (for example, 2020.3.102) and if all or of the same type ([Xaml or NoXaml]({%slug xaml-vs-noxaml%})). To check this, right-click the .dll file (for example, Telerik.Windows.Controls.dll) and choose the __Properties__ option. 

![WPF Telerik Assembly Properties Menu Option](images/msi-or-zip-setup-lifecyle-8.png)
![WPF Telerik Assembly No Xaml File Description](images/msi-or-zip-setup-lifecyle-9.png)

Delete the __bin__ and __obj__ folders of the projects that reference Telerik dlls in the solution and then __Clean__, and __Rebuild__ them. This will ensure that no older Telerik dlls are cached and used during the compilation.

![WPF Delete bin and obj Folders](images/msi-or-zip-setup-lifecyle-7.png)
![WPF Clean and Rebuild Solution](images/msi-or-zip-setup-lifecyle-10.png)

## See Also  
* [System Requirements]({%slug installation-system-requirements-wpf%})
* [Download Product Files]({%slug download-product-files-wpf%})
* [Installing WPF Demos Application]({%slug installing-wpf-demos%})