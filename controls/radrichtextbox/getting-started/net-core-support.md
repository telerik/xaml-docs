---
title: .NET Support
page_title: .NET 6 Support
description: Check our &quot;.NET Support&quot; documentation article for the RadRichTextBox WPF control.
slug: radrichtextbox-getting-started-net-core-support
tags: netcore,.net core,6,7
published: True
position: 1
---

# .NET Support

Similarly to the other controls in UI for WPF, `RadRichTextBox` can be used in {{ site.minimum_net_core_version }} and later applications.

This article describes the differences with the .NET Framework version you might encounter.

## Assembly References in {{ site.minimum_net_core_version }} and Later

To use RadRichTextBox in a {{ site.minimum_net_core_version }} or later project, you need to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.RichTextBox__
* __Telerik.Windows.Data__
* __Telerik.Windows.Documents.Core__

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

To use the built-in UI, you should add references to the following assemblies:

* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.ImageEditor__
* __Telerik.Windows.Controls.RibbonView__

## Migration from .NET Framework

If you are migrating from .NET Framework, note that there are several changes made to the assemblies. Several DLLs are now merged in a new assembly that is named __Telerik.Windows.Controls.RichTextBox.dll__. These merged DLLs are the following ones:

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

>important MEF is not supported by the {{ site.minimum_net_core_version }} and later versions of the RadRichTextBox control. For more information, check the [MEF]({%slug radrichtextbox-mef%}) article.

## Paths to Resources

Due to the merging of the assemblies, the resources' paths are modified as well. For example, the .NET Framework version uses paths like the following one: `pack://application:,,,/Telerik.Windows.Controls.RichTextBoxUI;component/`. The alternative for using RadRichTextBox in .NET Core environment is:

#### __[XAML]__

{{region xaml-radrichtextbox-getting-started-net-core-support-2}}
    <!-- old path -->
	pack://application:,,,/Telerik.Windows.Controls.RichTextBox;component/*
	
	<!-- new path -->
    pack://application:,,,/Telerik.Windows.Controls.RichTextBox;component/RichTextBoxUI/*
{{endregion}}

## Reorganized Resource Dictionaries 

When using implicit themes, you need to merge the XAML resources so you can have styling for the controls. RadRichTextBox for .NET needs the following resources:

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
