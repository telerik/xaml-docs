---
title: Frequently Asked Questions
page_title: Installing License Key - Frequently Asked Questions
description: The article lists the frequently asked questions (FAQ) on how to install a license key for the Telerik UI for WPF product.
slug: license-frequently-asked-questions
tags: installing,ui,for,wpf,file,license,key,ci,service,faq,asked,questions
published: True
position: 3
---

# Frequently Asked Questions About Installing Telerik License Key

This article lists the answers to the most frequently asked questions (FAQs) about working with the Telerik UI for WPF license key.

## Does the license key expire?

Yes, the license key expires at the end of your support subscription:

* For trial users, this is at the end of your 30-day trial.

* For commercial license holders, this is when your subscription term expires.

You will need to obtain and install a new license key after starting a trial, renewing a license, or upgrading a license.

> An expired perpetual license key is valid for all Telerik UI for WPF versions published before its expiration date.

## Will the product function with an expired license key?

This depends on your license type.

* __Perpetual licenses__ will continue to function normally with an expired license key. However, the following will happen if you update or install a package version which is released after the expiration date of the license:

	* A watermark appears on application startup.
	* A modal dialog appears on application startup.
	* A warning message is logged in the build log.	
		
	See the [Invalid License]({%slug license-activation-errors-and-warnings%}#invalid-license) section for more information.

* __Subscription licenses__ used in deployed applications will continue to function normally. However, the following will happen if you rebuild the application with an expired subscription license:

	* A watermark appears on application startup.
	* A modal dialog appears on application startup.
	* A warning message is logged in the build log.	
		
	See the [Invalid License]({%slug license-activation-errors-and-warnings%}#invalid-license) section for more information.

* __Trial licenses__ will prevent the applications from functioning normally once the trial period has expired. The following will happen if you try to build or run the application:
	
	* A watermark appears on application startup.
	* A modal dialog appears on application startup.
	* A warning message is logged in the build log.	
		
	See the [Invalid License]({%slug license-activation-errors-and-warnings%}#invalid-license) section for more information.

## I updated the version of the UI for WPF packages in my project and the invalid license errors have appeared. What is the cause of this behavior?

The most likely cause is that the newly installed Telerik UI for WPF components were released after the expiration date of your current license. To fix this issue:

1. [Download a new license key]({%slug installing-license-key%}#downloading-the-license-key).

1. [Activate the new license key]({%slug installing-license-key%}) in your project.

## Can I use the same license key in multiple builds?

You can use your personal license key in multiple pipelines, builds, and environments.

However, each individual developer must use a unique personal license key.

## Do I need an Internet connection to activate the license?

No, the license activation and validation are performed entirely offline.

## Do I have to add the license key to source control?

No, you do not have to add the `telerik-license.txt` license key file or its contents to source control.

Build servers must use the `TELERIK_LICENSE` environment variable described in [Adding the License Key to CI Services]({%slug installing-license-to-ci-services%}).

> Do not store the license key in plaintext, for example, in a GitHub Actions Workflow definition.

## What happens if both the environment variable and the license key file are present?

If both the `TELERIK_LICENSE` environment variable and the `telerik-license.txt` file are present, then the environment variable will be used.

To enforce the use of the license key file, unset the environment variable.

## My team has more than one license holder. Which key do we have to use?

* To activate Telerik UI for WPF on your development machine, use the key associated with your personal account.

* To activate Telerik UI for WPF in a CI/CD environment, use any of the license keys in your team.

## Are earlier versions of Telerik UI for WPF affected?

No, versions released prior to January 2025 (Q1) do not require a license key.

## Why I see the missing license key message when the Telerik components are used in a class library even if the license key is properly installed?

If you reference the Telerik components in a class library that is used in the main project, you will need to install the `Telerik.Licensing` package also in the main project. Otherwise, you will see the invalid/not found license key message. An alternative solution would be to set the following attributes to the `PackageReference` installing the Telerik product in the class library project - `IncludeAssets` to `All` and `PrivateAssets` to `None`.

Both approaches are shown in the [following KB article]({%slug kb-installation-missing-license-in-class-library-setup%}).

## Why I see the "No License Found" dialog after installing the license key?

The [following KB article]({%slug kb-licensing-no-license-found-message%}) describes most common reasons where the missing license message is displayed after installing the license key.

## See Also  
* [License Activation Errors and Warnings]({%slug license-activation-errors-and-warnings%})
* [Setting Up Your License Key]({%slug installing-license-key%})
* [Adding the License Key to CI Services]({%slug installing-license-to-ci-services%})
