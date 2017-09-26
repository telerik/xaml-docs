---
title: Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version
page_title: Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version
description: Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version
slug: installation-upgrading-from-trial-to-developer-license-wpf
tags: upgrading,telerik,ui,trial,to,telerik,ui,developer,license,or,newer,version
published: True
position: 1
site_name: WPF
---

# Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version

The purpose of this topic is to explain you how to upgrade Telerik UI Trial to Telerik Developer License or a newer version.

## Automatic Upgrade to newer version of UI for WPF

Utilize the VS Extensions wizards for this purpose:

* [Latest Version Acquirer Tool]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})

* [Upgrading to a new UI for WPF distribution]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})

## Upgrade to Newer Version or Other License of UI for WPF

In order to upgrade your controls to a newer version of the suite, you need to perform the following instructions:

* Download the installation method you prefer:
             	  
	* [MSI file for automatic installation.]({%slug installation-installing-from-msi-wpf%})

	* [ZIP file for manual (advanced) installation.]({%slug installation-installing-from-zip-wpf%})

	* [DLL files only (a.k.a. HOTFIX).]({%slug installation-installing-hotfix-wpf%})

>If you have installed the trial version of UI for WPF and try to install the developer version of the same release, you will receive the following message:
>![Common Installing Already Installed WPF](images/Common_Installing_AlreadyInstalled_WPF.png)
>So, you should remove the trial version first.

* If the upgrade is major (i.e. from Q2 2011 to Q3 2011), check the [Release History](http://www.telerik.com/products/wpf/whats-new.aspx).

* Back up your application.

* Update all the Telerik references in your project in Visual Studio to point to the new DLLs.

* Clean the solution.

* Recompile your project.

* Run the project.

## How to check the version of dll files using Visual Studio:

In order to check are the dll files trial or dev version, you need to perform the following instructions:

1. Open the project containing the dll-s with Visual Studio. 
  
2. Double click on one of the following dll files so the properties window of the dll to be shown: *Telerik.Windows.Controls* or *Telerik.Windows.Documents.Core*.
          
3. Expand the Version folder.
   
4. Double Click on the version and you will see the whole information about the dll.
          
If this is Trial Version this will be written in the FileDescription property.
        
__For example:__

* Telerik.Windows.Controls Trial Version
          
If your dll files contain this message in the FileDescription then they are Trial version and you have to replace them with Development assemblies.
        
>In case the project does not build: 
>* Please make sure that all the assemblies you have referenced are with the same version. 
>* If this does not help, delete the bin and obj folders of the project manually and Rebuild.
            
## See Also

 * [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%})
