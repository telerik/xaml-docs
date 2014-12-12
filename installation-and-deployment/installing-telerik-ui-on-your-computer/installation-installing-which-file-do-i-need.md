---
title: Which File Do I Need to Install?
page_title: Which File Do I Need to Install?
description: Which File Do I Need to Install?
slug: installation-installing-which-file-do-i-need
tags: which,file,do,i,need,to,install?
published: True
position: 0
---

# Which File Do I Need to Install?

The following topic describes the installation packages for the Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} and for the Demos solution.

Each installation package comes in three types:

* __MSI__ file for automatic installation.

* __ZIP__ file for manual (advanced) installation.

* __DLL__ files only (a.k.a. HOTFIX).

{% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} Demos application comes in a zip package which you can extract on your machine.

## MSI File For Automatic Installation

The [MSI](http://en.wikipedia.org/wiki/Windows_Installer) files are intended for easy and automatic installation of a product. It installs the controls on your computer in a folder in your Program Files named Telerik, and automatically creates the necessary virtual folders and projects.

For more information about how to install UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} from MSI file, read [here]{% if site.site_name == 'WPF' %}({%slug installation-installing-from-msi-wpf%}).{% endif %}{% if site.site_name == 'Silverlight' %}({%slug installation-installing-from-msi%}).{% endif %}

>tipIf you already have Telerik UI installed from a MSI, you can safely install an updated version - the installer will keep your existing installation. The new files will be placed in a separate folder and the new installation does not damage the common installer files.

## ZIP File For Manual Installation

The [ZIP](http://en.wikipedia.org/wiki/ZIP_%28file_format%29) is used to manual (advanced) installs and for upgrading/updating purposes.

For more information about how to install Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} from ZIP file, read [here]{% if site.site_name == 'WPF' %}({%slug installation-installing-from-zip-wpf%}).{% endif %}{% if site.site_name == 'Silverlight' %}({%slug installation-installing-from-zip%}).{% endif %}

## DLL Files Only (HOTFIX)

__DLL Files Only__ are used for updating/upgrading a product to a newer version. This is a bare-bones upgrade option for the Telerik UI controls. The hotfix contains only those files that you need to replace in your project to upgrade to the new version.

For more information about how to use HOTFIX DLL Files, read [here]{% if site.site_name == 'WPF' %}({%slug installation-installing-hotfix-wpf%}).{% endif %}{% if site.site_name == 'Silverlight' %}({%slug installation-installing-hotfix%}).{% endif %}

>tipThe latest __MSI__ and __ZIP__ packages available for download already have all updates/HOTFIXES applied. There is no need to update them further.

## Demos Application

The Demos Application ZIP package does not include the Telerik assemblies, so in order to build the Demos solution, you should have the latest UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} components installed on your machine and that the example projects reference these assemblies. The referenced Telerik assemblies in the Examples projects by default are taken from the Telerik {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} installation directory on your machine.
      

>tipIf you have multiple UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} installations on your machine the projects might sometimes reference an older installed version of the components. In that case you can run the {% if site.site_name == 'WPF' %}[Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}){% endif %}{% if site.site_name == 'Silverlight' %}[Upgrade Wizard]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%}){% endif %} to update the referenced assemblies to use the latest version of the components in the projects you need to run.
   
{% if site.site_name == 'Silverlight' %}   
# See Also

 * [Installing UI for Silverlight from MSI File]({%slug installation-installing-from-msi%})
 
 * [Installing UI for Silverlight from ZIP File]({%slug installation-installing-from-zip%})

 * [Using the Hotfix (DLLs Only)]({%slug installation-installing-hotfix%})
 {% endif %}
