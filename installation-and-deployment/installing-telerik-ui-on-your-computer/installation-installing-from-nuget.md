---
title: Installing UI for Silverlight from a NuGet package
page_title: Installing UI for Silverlight from a NuGet package
description: Installing UI for Silverlight from a NuGet package
slug: installation-installing-from-nuget
tags: installing,ui,for,silverlight,from,a,nuget,package
published: True
position: 5
site_name: Silverlight
---

# Installing UI for Silverlight from a NuGet package

The following topic describes what steps you should perform in order to install Telerik UI for Silverlight from a [NuGet package](http://www.nuget.org/).
   
We’re providing a common NuGet package containing all the assemblies from the UI for Silverlight suite as well as separate packages for the different assemblies. It is up to you to decide which one is more suitable to your project. 

>importantThe provided NuGet packages include only __NoXaml binaries__. Check the [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) help topic for more details on the NoXaml binaries and Implicit Styles.
 
We will go through the following sections: 

* [Downloading the NuGet packages](#downloading-the-NuGet-packages)

* [Installing Silverlight Controls Package](#installing-silverlight-controls-package)

## Downloading the NuGet packages

In order to download the latest NuGet packages, follow the instructions below:

*  Log into your [Telerik account](http://www.telerik.com/account.aspx).
          
* Click __Products & Subscriptions__ and then select UI for Silverlight from the dropdown (or Trial downloads if you are a trial user).
          
![Common Installing FromMSIFiles 005](images/Common_InstallingFromMSIFiles_005.png)

>If you've purchased Telerik DevCraft Complete/Ultimate bundle, you will see it in the Products & Subscriptions dropdown.
>![Common Installing FromMSIFiles 005 Ultimate](images/Common_InstallingFromMSIFiles_005_Ultimate.png)

* Click "Download Installer and other resources" button.
![Common Installing Download Button](images/Common_Installing_Download_Button.png)

>Again, if you've purchased Telerik DevCraft Complete/Ultimate bundle, you will be redirected to a page with all the products in the suite.
>Scroll to "UI for Silverlight" product. Click "Browse all product files" to go to the detailed download page.
>![Common Installing FromMSIFiles 009](images/Common_InstallingFromMSIFiles_009.png)

* Click either “NuGet installation” or “NuGet installation – Separate Packages”.![Common Installing From Nu Get 01](images/Common_InstallingFromNuGet_01.png)

* Download the .zip file and extract it into the folder where your Telerik NuGet packages are located.

## Installing Silverlight Controls Package
      
The next steps show how to install the complete NuGet package which includes all the assemblies.The approach is the same for the separate packages. 

Once you open the __“Manage NuGet Packages”__ dialog in Visual Studio (right-click Project References -> Manage NuGet Packages), you can select the Telerik NuGet folder and the available packages there will be shown: 
![Common Installing From Nu Get 02](images/Common_InstallingFromNuGet_02.png)

>If you haven’t set the Telerik NuGet folder until now, you can do it by clicking __Settings__ button on the __“Manage NuGet Packages”__ dialog, then add the folder where you’ve extracted the .nupkg file (for example C://Telerik NuGet) as a new package source inside the __Options__ dialog:
>![Common Installing From Nu Get 03](images/Common_InstallingFromNuGet_03.png)

Click the “Install” button and the references will be automatically added to your project as shown below:![Common Installing From Nu Get 04](images/Common_InstallingFromNuGet_04.png)

You can now use the Telerik Silverlight controls in your project. 

>tipAdditionally, you can create a private NuGet Feed and deploy the Telerik NuGet packages there - for more details refer to [this blog post](http://blogs.telerik.com/careypayette/posts/13-03-11/power-your-projects-with-telerik---now-with-the-convenience-of-nuget).

# See Also

 * [Which File Do I Need to Install?]({%slug installation-installing-which-file-do-i-need%})

 * [Installing UI for Silverlight from MSI File]({%slug installation-installing-from-msi%})

 * [Installing UI for Silverlight from ZIP File]({%slug installation-installing-from-zip%})
