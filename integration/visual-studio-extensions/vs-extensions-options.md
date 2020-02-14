---
title: Options
page_title: Options
description: Progress Telerik WPF Visual Studio Extension options dialog provides settings, so you can configure the extension to best suit your needs.
slug: radcontrols-vs-extensions-options
tags: options
published: True
position: 8
---

# Options

__Progress Telerik UI for {{ site.framework_name }} Extension__ options dialog provides settings, so you can configure the extension to best suit your needs.

It can be accessed through the __Visual Studio | Telerik | VSExtensions Options…__ menu.

![VSExtentions Options Dialog Menu](images/VSExtentions_OptionsDialogMenu.png)

The __Options__ dialog contains two sets of options that affect the __Telerik UI for {{ site.framework_name }}__.

![VSExtentions Options Dialog General](images/VSExtentions_OptionsDialogGeneral.png)

The settings under the __General__ category affect all of the installed __Telerik Visual Studio Extensions__.

## Project Setup

{% if site.site_name == 'Silverlight' %}__Add referenced assemblies to solution and source control__ - Sets the default value for the __Add referenced assemblies to solution__ option in the Project Configuration Wizard{% else %}__Copy referenced assemblies to solution and integrate with source control__ - When enabled, the referenced assemblies will be copied to the solution when using Telerik wizards{% endif %}

## Project Upgrade Notifications for Detected Local Distributions

__Suggest project upgrades for Telerik product version available on my computer__: When enabled, you will be prompted to upgrade upon opening a project, which is not using the latest version of Telerik UI for {{ site.framework_name }} installed on your system

__Suggest upgrades when an equal Dev release is detected on projects using a Trial__: When enabled, you will be prompted to upgrade if a licensed version of Telerik UI for {{ site.framework_name }} is available on your system, but the current project uses a trial version

## Select a Folder for Downloads

Configures the path where the extensions look for and store distributions.

>Changing the folder path will not move existing folder contents from your previous path. Please, move your previous folder contents manually in case you still want to use them.

## {{ site.framework_name }} Options

All settings under the Telerik UI for {{ site.framework_name }} category affect only the Telerik {{ site.framework_name }} projects.

![VSExtensions Options Dialog Product Specific](images/VSExtentions_WPF_OptionsDialog.png)

## Latest Version Retrieval

__Include internal builds in Latest Version update and retrieval__: When enabled, the __[Latest Version Acquirer]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})__ tool will retrieve internal builds as well as official releases when checking for a new version.

## Notifications

__Show me a message when a newer version is available on [www.telerik.com](http://www.telerik.com)__: When enabled, you will receive notifications if a new version of __Telerik UI for {{ site.framework_name }}__ is available on the Telerik website.