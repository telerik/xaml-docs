---
title: Resolving Design Time Errors
page_title: Resolving Design Time Errors
description: This article shows how to resolve common design-time errors that appear in the Visual Studio designer.
slug: troubleshooting-design-time-errors
tags: design, time, error
published: True
position: 2
---

# Resolving Design Time Errors

This article shows how to resolve common design-time errors that appear in the Visual Studio designer.

Such issues might occur in the following situations. 

* After an upgrade to a newer version of UI for {{ site.framework_name }}. Or after a downgrade to a previous version.

* Mixing [Xaml and NoXaml]({%slug xaml-vs-noxaml%}) dlls, or mixing the corresponding [theming mechanisms]({%slug styling-apperance-implicit-styles-overview%}) (StyleManager and Implicit Styles).

* Referencing Telerik dlls from different locations on the file system. For example, if you get the Telerik.Windows.Controls.dll assembly from C:\TelerikDlls and Telerik.Windows.Navigation.dll from C:\TelerikAssemblies.	

* etc.

__To resolve this__ you can use the following steps.

1. Make sure that all Telerik dlls are the [Xaml or the NoXaml]({%slug xaml-vs-noxaml%}) version. In other words avoid mixing them. Choose only one type. 

2. Make sure that all Telerik dlls come from the same place (directory).

3. Make sure that only the StyleManager or the Implicit Styles [theming mechanism]({%slug styling-apperance-implicit-styles-overview%}) is used. If you reference XAML dlls use StyleManager. If you reference NoXaml, use Implicit Styles.

4. Close all .xaml tabs in Visual Studio.

5. Close Visual Studio.

6. Clear Visual Studio designer's cache. To do this, go to the following directory: *%LOCALAPPDATA%\Microsoft\VisualStudio\14.0\Designer\ShadowCache*. Then delete all subfolders.
	
	> The folder named *14.0* in the shadow cache directory path corresponds to the Visual Studio version that you are using. The name of this folder could be different on your machine.
	
7. Open your project's local folder and manually delete the *bin* and *obj* folders.

8. Open your solution's local folder and manually delete the *.vs* folder.

	> Remember that deleting *.vs* folder you will lose local debug settings and startup project configuration. This can fix IntelliSense or build errors.

9. Open the project in Visual Studio again.

10. [Clean and Rebuild](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2017) the project.

## See Also
* [Missing Controls in the UI]({%slug troubleshooting-invisible-controls%})
{% if site.framework_name == 'WPF' %}* [Popup Content Position]({%slug troubleshooting-popup-content-position%}){% endif %}
