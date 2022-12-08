---
title: Latest Internal Build (LIB)
page_title: Using Latest Internal Build Assemblies
description: This article describes what is Telerik WPF LIB and how to download it to get the lastest bug fixes.
slug: installation-installing-lib
tags: using,the,hotfix,(dlls,only), lib, latest, internal, build
published: True
position: 6
---

# Latest Internal Build

This article describes what is LIB and how to download it.

## What is LIB

The Latest Internal Build (LIB) is a weekly distribution of the UI for {{ site.framework_name }} assemblies, built against the latest development environment. It contains all the newest bug fixes. And it is released on a weekly basis. 

The purpose of the LIB is to allow the users to test the latest bug fixes. So, if you have experienced any problem with the current official distributions there is a possibility that the issue has already been addressed in the latest internal build. 

>important The LIB are intended for development only and are not recommended for production purposes as these distributions have not gone through the complete QA process.

>tip Features are usually not included in the LIB.

## How to Download it

The LIB is __available as a NuGet__ package. Read how to get it in the {% if site.framework_name == 'WPF' %}[Installing Latest Internal Build NuGet Packages]({%slug nuget-installation%}#installing-latest-internal-build-nuget-packages){% else %}[Installing Latest Internal Build NuGet Packages]({%slug nuget-installation%}){% endif %} section of the documentation.

Alternatively you can __download the LIB assemblies__ from [your telerik.com account](https://www.telerik.com/account/).

1. Open the Download page of your telerik.com account.
2. Find the Telerik UI for {{ site.framework_name }} product and open its download page.
{% if site.framework_name == 'WPF' %}
![WPF Progress Site Telerik UI for WPF Product Title](images/installation-installing-lib-0.png)
{% else %}
![Silverlight Progress Site Telerik UI for Silverlight Product Title](images/installation-installing-lib-sl-0.png)
{% endif %}
3. Click on the __Latest Internal Build__ button. This will download an archive with the UI for {{ site.framework_name }} __assemblies__.
{% if site.framework_name == 'WPF' %}
![WPF Progress Site Telerik UI for WPF Latest Internal Build Button](images/installation-installing-lib-1.png)
{% else %}
![Silverlight Progress Site Telerik UI for Silverlight Latest Internal Build Button](images/installation-installing-lib-sl-1.png)
{% endif %}
To get a specific version of the LIB, open the __Internal Bulds tab__ on the download page. And select a version from the list.
{% if site.framework_name == 'WPF' %}
![WPF Progress Site Telerik UI for WPF Internal Builds Tab](images/installation-installing-lib-2.png)
{% else %}
![Silverlight Progress Site Telerik UI for Silverlight Internal Builds Tab](images/installation-installing-lib-sl-2.png)
{% endif %}
## Version Number Breakdown

The numbers in the name of the dlls are determined by the source code build date. In other words, the version number corresponds to the date when the dlls were built.

The following image shows the name of the LIB dlls generated on 8th of April (4th month), after the R1 2019 release.

![WPF Internal Build Version Number Breakdown](images/installation-installing-lib-3.png)
 
## See Also  
{% if site.framework_name == 'WPF' %}       
 * [Trial License Limitations]({%slug installation-installing-license-limitations-wpf%})
 * [Adding UI for WPF to the Visual Studio Toolbox]({%slug installation-adding-to-vs-2015-toolbox-wpf%})
 * [Creating an Application and Adding UI for WPF]({%slug installation-adding-to-application-create-application-and-adding-control%})
 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license-wpf%})
{% else %}
 * [Trial License Limitations]({%slug installation-installing-license-limitations%})
 * [Adding UI for Silverlight to the Visual Studio Toolbox]({%slug installation-adding-to-vs-2015-toolbox-sl%})
 * [Creating an Application and Adding UI for Silverlight]({%slug installation-adding-to-application-create-application-and-adding-control%})
 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license%})
 {% endif %}