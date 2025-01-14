---
title: Installing License Key
page_title: Installing License Key
description: The article describes how to install a license key for the Telerik UI for WPF product.
slug: installing-license-key
tags: installing,ui,for,wpf,file,license,key
published: True
position: 0
---

# Installing License Key

Starting with the 2025 Q1 release, the UI components from the WPF library require activation through a license key (trial or commercial). This article describes how to download, install, and update your personal license key.

## Setting Up Your UI for WPF License Key

To install the license key and activate the UI components:

1. [Download the license key](#downloading-the-license-key).

1. [Install or update the license key file on your system or in your project](#installing-the-license-key).

	The implementation of the 2025 WPF licensing requirements will occur in two phases:

	* Phase 1&mdash;Starting with the 2025 Q1 release, a missing or invalid license causes [warnings during build](LINK TO ARTICLE). The commercial distributions of the UI components do not exhibit any functional restrictions.

	* Phase 2&mdash;Starting with the 2025 Q2 release, a missing or invalid license will result in [build errors and run-time indicators]({%slug license-activation-errors-and-warnings%}), such as watermarks and banners.

	Note that future updates of the library may restrict or disable some features when no valid license is present.

## Downloading the License Key

To download a license key for Telerik UI for WPF, you must have either a developer license or a trial license. If you are new to Telerik UI for WPF, sign up for a [free trial](https://www.telerik.com/try/ui-for-wpf) first, and then follow the steps below.

1. Go to the [License Keys](https://www.telerik.com/account/your-licenses/license-keys) page in your Telerik account.
2. Click the __Download License Key__ button.
 
	ADD SCREENSHOT HERE

	The [Progress Control Panel](https://www.telerik.com/download-trial-file/v2/control-panel), [automated MSI installer]({%slug installation-installing-from-msi-wpf%}), and the [Visual Studio Extensions]({%slug radcontrols-for-wpf-vs-extensions-overview-wpf%}) will automatically download and store your license key in your home directory. This makes it available for all projects that you develop on your local machine.

	Note to documentation authors:
	The MSI installer and VSE articles will require updates that address the added license key.

## Installing or Updating Your License Key

Whenever you purchase a new Telerik UI for WPF license or renew an existing one, always [download](#downloading-the-license-key) and install a new license key. The new license key includes information about all previous license purchases. The procedure for the installation of a new license key and update of a license key is the same:

1. Copy the [downloaded](#downloading-the-license-key) `telerik-license.txt` license key file to your home directory (`%AppData%\Telerik\telerik.license.txt`). This makes the license key available to all projects that you develop on your computer.

	Alternatively, copy the `telerik-license.txt` license key file to the root folder of your project. This makes the license key available only to this project. Do not commit the file to source control as this is your personal license key.

1. Add the `Telerik.Licensing` NuGet package as a project dependency. This package will automatically locate the license file at build time. If your project doesn’t use NuGet packages, see the next document section.

### Installing a License Key in Projects without NuGet References

If you’re not using NuGet packages in your project, add the license as a code snippet:

1. Go to the [License Keys](https://www.telerik.com/account/your-licenses/license-keys) page in your Telerik account.

1. On the UI for WPF row, click the __View key__ link in the __SCRIPT KEY__ column. 
	
	image here

1. Copy the C# code snippet into a new file, for example, `TelerikLicense.cs`.

1. Add the `TelerikLicense.cs` file to your project.

	Do not publish the license key code snippet in publicly accessible repositories. This is your personal license key.

## See Also  
* [License Activation Errors and Warnings]({%slug license-activation-errors-and-warnings%})
* [Adding the License Key to CI Services]({%slug installing-license-to-ci-services%})
* [Frequently Asked Questions about Your UI for WPF License Key]({%slug license-frequently-asked-questions%})