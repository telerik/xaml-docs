---
title: Installing UI for WPF from a NuGet package
page_title: Installing UI for WPF from a NuGet package
description: Installing UI for WPF from a NuGet package
slug: installation-installing-from-nuget-wpf
tags: installing,ui,for,wpf,from,a,nuget,package
published: True
position: 6
site_name: WPF
---

# Installing UI for WPF from a NuGet package



The following topic describes what steps you should perform in order to install Telerik UI for WPF from a [NuGet package](http://www.nuget.org/).
      
We’re providing a common NuGet package containing all the assemblies from the UI for WPF suite as well as separate packages for the different assemblies. It is up to you to decide which one is more suitable to your project. 

>importantThe provided NuGet packages contain either __NoXaml binaries__ or __XAML binaries__. Check the [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) help topic for more details on the NoXaml binaries and Implicit Styles.
        
We will go through the following sections: 

* [Downloading the NuGet packages](#downloading-the-nuget-packages)

* [Installing WPF Controls Package](#installing-wpf-controls-package)

* [Add the Telerik NuGet Server](#add-the-telerik-nuget-server)

## Downloading the NuGet packages

In order to download the latest NuGet packages, follow the instructions below:

* Log into your [Telerik account](http://www.telerik.com/account.aspx).
          
* Click __Products & Subscriptions__ and then select UI for WPF from the dropdown (or Trial downloads if you are a trial user).
![Common Installing FromMSIFiles 005 WPF](images/Common_InstallingFromMSIFiles_005_WPF.png)

>If you've purchased Telerik DevCraft Complete/Ultimate bundle, you will see it in the Products & Subscriptions dropdown.
>![Common Installing FromMSIFiles 005 Ultimate](images/Common_InstallingFromMSIFiles_005_Ultimate.png)

* Click "Download Installer and other resources" button.

![Common Installing Download Button](images/Common_Installing_Download_Button.png)

>Again, if you've purchased Telerik DevCraft Complete/Ultimate bundle, you will be redirected to a page with all the products in the suite.
>Scroll to "UI for WPF" product. Click "Browse all product files" to go to the detailed download page.
>![Common Installing FromMSIFiles 009 WPF](images/Common_InstallingFromMSIFiles_009_WPF.png)

* Click either “NuGet installation” or “NuGet installation – Separate Packages”.![Common Installing From Nu Get 01 wpf](images/Common_InstallingFromNuGet_01_wpf.png)

* Download the .zip file and extract it into the folder where your Telerik NuGet packages are located.

## Installing WPF Controls Package
      
The next steps show how to install the complete NuGet package which includes all the assemblies.The approach is the same for the separate packages. 

Once you open the __“Manage NuGet Packages”__ dialog in Visual Studio (right-click Project References -> Manage NuGet Packages), you can select the Telerik NuGet folder and the available packages there will be shown:
![Common Installing From Nu Get 02 wpf](images/Common_InstallingFromNuGet_02_wpf.png)

>If you haven’t set the Telerik NuGet folder until now, you can do it by clicking __Settings__ button on the __“Manage NuGet Packages”__ dialog, then add the folder where you’ve extracted the .nupkg file (for example C://Telerik NuGet) as a new package source inside the __Options__ dialog:
>![Common Installing From Nu Get 03](images/Common_InstallingFromNuGet_03.png)

Click the “Install” button and the references will be automatically added to your project as shown below:
![Common Installing From Nu Get 04 wpf](images/Common_InstallingFromNuGet_04_wpf.png)

You can now use the Telerik WPF controls in your project. 

>tipAdditionally, you can create a private NuGet Feed and deploy the Telerik NuGet packages there - for more details refer to [this blog post](http://blogs.telerik.com/careypayette/posts/13-03-11/power-your-projects-with-telerik---now-with-the-convenience-of-nuget).

## Add the Telerik NuGet Server

Through the Telerik NuGet Server users can easily include the Telerik UI for WPF suite and update to latest official version without having to log into their Telerik account. The following steps will demonstrate how this can be done in Visual Studio.

*  Navigate to the Package Manager Settings menu.

![](images/Common_InstallingFromNuGet_05_wpf.png)

* Add new source in the Package Sources section.

![](images/Common_InstallingFromNuGet_06_wpf.png)

* In the Source field fill the address of the Telerik NuGet Server and click Update.

![](images/Common_InstallingFromNuGet_07_wpf.png)

* The Telerik Server is added and ready to use. Click on the Manage NuGet Packages menu.

![](images/Common_InstallingFromNuGet_08_wpf.png)

* Set the Telerik Server as a package source. Enter user credentials when prompted and search for the needed package.

![](images/Common_InstallingFromNuGet_09_wpf.png)

          
## See Also

 * [Which File Do I Need to Install?]({%slug installation-installing-which-file-do-i-need%})

 * [Installing UI for WPF from MSI File]({%slug installation-installing-from-msi-wpf%})

 * [Installing UI for WPF from ZIP File]({%slug installation-installing-from-zip-wpf%})
