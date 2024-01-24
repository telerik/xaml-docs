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

Similarly to the other controls in UI for WPF, `RadRichTextBox` can be used in .NET Core applications.

This article describes the differences with the .NET Framework version you might encounter.

## Assembly References

To use RadRichTextBox, you need to add references to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.RichTextBox__
* __Telerik.Windows.Data__
* __Telerik.Windows.Documents.Core__

To use the built-in UI, you should add references to the following assemblies:

* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.ImageEditor__
* __Telerik.Windows.Controls.RibbonView__

## Migration from .NET Framework

If you are migrating from .NET Framework, note that there are several changes made to the assemblies. Several DLLs are now merged in а new assembly that is named __Telerik.Windows.Controls.RichTextBox.dll__. These merged DLLs are the following ones:

* __Telerik.Windows.Documents.dll__
* __Telerik.Windows.Controls.RichTextBoxUI.dll__
* __Telerik.Windows.Documents.FormatProviders.Html__
* __Telerik.Windows.Documents.FormatProviders.MsRichTextBoxXaml__
* __Telerik.Windows.Documents.FormatProviders.OpenXml__
* __Telerik.Windows.Documents.FormatProviders.Pdf__
* __Telerik.Windows.Documents.FormatProviders.Rtf__
* __Telerik.Windows.Documents.FormatProviders.Xaml__
* __Telerik.Windows.Documents.Proofing.Dictionaries.En-US__

>important The associated __.xaml__ files are changed respectively.

>important MEF is not supported by the .NetCore version of the RadRichTextBox control. For more information, check the [MEF]({%slug radrichtextbox-mef%}) article.

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
