---
title: Installation Approaches
page_title: Installation Approaches
description: "Learn which installation approach to choose when starting your work with the Telerik UI for WPF controls."
slug: installation-installing-which-file-do-i-need
tags: which,file,do,i,need,to,install?
published: True
position: 1
---

# Installation Approaches

To start working with Telerik UI for WPF, you can choose the installation approach that corresponds to your needs and requirements.

The Telerik UI for WPF suite supports the following installation approaches:

* Installation through the Telerik NuGet feed (__recommended approach__).

* Installation through the Telerik UI for WPF MSI file.

* Installation through the Telerik UI for WPF ZIP file.

* Installation with the Telerik Visual Studio extension.

## NuGet Installation

The [NuGet](https://docs.microsoft.com/en-us/nuget/what-is-nuget) packages are a single ZIP file with the `.nupkg` extension that contains the compiled code (DLLs), other related files, and a descriptive manifest that includes information such as the version package number.

* For more information about how to install Telerik UI for WPF with NuGet, refer to the article on [installation with NuGet]({% slug nuget-installation %}).

* For more information about restoring Telerik UI for WPF NuGet packages in your CI workflow, refer to the article on [using token-based NuGet authentication]({% slug nuget-keys %}).

## MSI File Installation

The [MSI](http://en.wikipedia.org/wiki/Windows_Installer) files are intended for easy installation of a product. The Telerik UI for WPF MSI file installs the controls in the following directory `C:\Program Files (x86)\Progress\` by default.

If you already have Telerik UI installed from an MSI, you can safely install an updated version. The installer will keep your existing installation. The new files will be placed in a separate folder and the new installation will not damage the common installer files.



## ZIP File Installation

The [ZIP](http://en.wikipedia.org/wiki/ZIP_%28file_format%29) is used for advanced manual installation and for upgrading and updating purposes.

For more information about how to install Telerik UI for WPF from a ZIP file, refer to the article on [first steps with the ZIP file installation]({% slug installation-installing-from-zip-wpf %}).

## Visual Studio Extension Installation

The Telerik UI for WPF library provides an option for preconfigured manual installation using the Telerik Visual Studio (VS) extension, which contains the Telerik UI for WPF DLLs and referenced assembly files.

For more information about how to install Telerik UI for WPF with the VS extension, refer to the article on [first steps with the Telerik VS extension installation]({% slug radcontrols-for-wpf-vs-extensions-project-creation %}).
