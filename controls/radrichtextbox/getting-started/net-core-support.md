---
title: .NET Core Support
page_title: .NET Core Support
description: Check our &quot;.NET Core Support&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-getting-started-net-core-support
tags: netcore,.net core
published: True
position: 1
---

# .NET Core Support

Similarly to the other controls in **UI for WPF**, RadRichTextBox can be used in .NET Core applications.

This article describes the differences with the .NET Framework version you might encounter.

## Assembly References

To use RadRichTextBox, you need to add references to the following assemblies:

* **Telerik.Windows.Controls**
* **Telerik.Windows.Controls.RichTextBox**
* **Telerik.Windows.Data**
* **Telerik.Windows.Documents.Core**

In order to use the built-in UI, you should add references to the following assemblies:

* **Telerik.Windows.Controls.Input**
* **Telerik.Windows.Controls.Navigation**
* **Telerik.Windows.Controls.ImageEditor**
* **Telerik.Windows.Controls.RibbonView**

The default en-US dictionary for SpellChecking is located in:
* **Telerik.Windows.Documents.Proofing.Dictionaries.En-US**.

>If you are migrating from .NET Framework, note that **Telerik.Windows.Documents.dll** and **Telerik.Windows.Controls.RichTextBoxUI.dll** that you have used in the .NET Framework version **have been unified** into a new, single one for the .NET Core version of the control. The associated .xaml files are changed respectively. The name of the new assembly is **Telerik.Windows.Controls.RichTextBox.dll**. 

## Paths to Resources

Due to the merging of the assemblies, the resources' paths are modified as well. For example, the .NET Framework version uses paths like the following one: *pack://application:,,,/Telerik.Windows.Controls.RichTextBoxUI;component/**. The alternative for using RadRichTextBox in .NET Core environment is:

#### __[XAML]__

{{region xaml-radrichtextbox-getting-started-net-core-support-2}}

    pack://application:,,,/Telerik.Windows.Controls.RichTextBox;component/RichTextBoxUI/*
{{endregion}}

## Reorganized Resource Dictionaries 

When using implicit themes, you need to merge the XAML resources so you can have styling for the controls. RadRichTextBox for .NET Core needs the following resources:

#### __[XAML]__
{{region xaml-radrichtextbox-getting-started-net-core-support-3}}
    
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/System.Windows.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.Input.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.Navigation.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.RibbonView.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.RichTextBox.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.ImageEditor.xaml" />
{{endregion}}
