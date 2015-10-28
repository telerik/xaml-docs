---
title: Automatic Dependency resolving
page_title: Automatic Dependency resolving
description: Automatic Dependency resolving
slug: radcontrols-for-wpf-vs-extensions-automatic-resolving
tags: automatic,dependency,resolving
published: True
position: 6
site_name: WPF
---

# Automatic Dependency resolving



## 

To improve the experience of your clients and reduce your application’s size it is crucial to use only the subset of UI for WPF assemblies you really need, as described in the Installation and Deployment Section.

Some controls require multiple assemblies and mistakes are likely to happen. For example, in the urge to optimize, you could remove an assembly the project needs, thus breaking the application compilation. 

When using the __New Project Wizard__ or __Project Configuration Wizard__, the possibility to make such mistakes is lowered to a minimum, thanks to the dependency analysis in the Visual Studio Extensions. 

![Project Configuration Wizard](images/VSExtensions_WPF_ProjectConfigWizard.png)

The VSExtensions assembly list control is controlled by the dependency analyzer, which will not let you select UI for WPF assemblies without selecting the assemblies they depend on. Both the aspects are covered: 

* Selecting a __Telerik UI__ assembly will also select the additional assemblies it depends on as well. 

* Deselecting a __Telerik UI__ assembly will also deselect assemblies depending on it along with it. 

>Note that not all assemblies are listed.

# See Also

 * [Project creation and configuration]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%})

 * [Upgrading to a new UI for WPF distribution]({%slug radcontrols-for-wpf-vs-extensions-upgrading%})

 * [Latest Version Acquirer Tool]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})
