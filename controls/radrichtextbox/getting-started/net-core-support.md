---
title: .NET Core Support
page_title: .NET Core Support
description: .NET Core Support
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
* **System.ComponentModel.Composition** 

In order to use the built-in UI, you should add references to the following assemblies:

* **Telerik.Windows.Controls.Input**
* **Telerik.Windows.Controls.Navigation**
* **Telerik.Windows.Controls.RibbonView**

The default en-US dictionary for SpellChecking is located in:
* **Telerik.Windows.Documents.Proofing.Dictionaries.En-US**.

## MEF Usage

If you have used RadRichTextBox in .NET Framework, you most probably know that it uses [MEF]({%slug radrichtextbox-mef%}) to load some of its component. This, however, is **no more supported in .NET Core** and all parts are integrated in the control itself.

For versions **prior R3 2019**, __RadRichTextBox__ still uses MEF to load additional UI components (like dialogs and document format providers dependencies). This implementation uses the `Assembly.ReflectionOnlyLoadFrom()` method to inspect the assemblies for suitable parts. This method is not available in .NET Core. To work this around, provide a predefined type catalog at the startup of the application.
	
#### __[C#] Example 1: Creating type catalog manually__
{{region radrichtextbox-net-core-support}}

	RadCompositionInitializer.Catalog = new TypeCatalog(
		// format providers
		typeof(XamlFormatProvider),
		typeof(RtfFormatProvider),
		typeof(DocxFormatProvider),
		typeof(PdfFormatProvider),
		typeof(HtmlFormatProvider),
		typeof(TxtFormatProvider),

		// mini toolbars
		typeof(SelectionMiniToolBar),
		typeof(ImageMiniToolBar),

		// context menu
		typeof(Telerik.Windows.Controls.RichTextBoxUI.ContextMenu),

		// the default English spell checking dictionary
		typeof(RadEn_USDictionary),

		// dialogs
		typeof(AddNewBibliographicSourceDialog),
		typeof(ChangeEditingPermissionsDialog),
		typeof(EditCustomDictionaryDialog),
		typeof(FindReplaceDialog),
		typeof(FloatingBlockPropertiesDialog),
		typeof(FontPropertiesDialog),
		typeof(ImageEditorDialog),
		typeof(InsertCaptionDialog),
		typeof(InsertCrossReferenceWindow),
		typeof(InsertDateTimeDialog),
		typeof(InsertTableDialog),
		typeof(InsertTableOfContentsDialog),
		typeof(ManageBibliographicSourcesDialog),
		typeof(ManageBookmarksDialog),
		typeof(ManageStylesDialog),
		typeof(NotesDialog),
		typeof(ProtectDocumentDialog),
		typeof(RadInsertHyperlinkDialog),
		typeof(RadInsertSymbolDialog),
		typeof(RadParagraphPropertiesDialog),
		typeof(SetNumberingValueDialog),
		typeof(SpellCheckingDialog),
		typeof(StyleFormattingPropertiesDialog),
		typeof(TableBordersDialog),
		typeof(TablePropertiesDialog),
		typeof(TabStopsPropertiesDialog),
		typeof(UnprotectDocumentDialog),
		typeof(WatermarkSettingsDialog));
{{endregion}}
	

## Paths to Resources

Due to the merging of the assemblies, the resources' paths are modified as well. For example, the .NET Framework version uses paths like the following one: *pack://application:,,,/Telerik.Windows.Controls.RichTextBoxUI;component/**. The alternative for using RadRichTextBox in .NET Core environment is:

#### [XAML]

{{region}}

    pack://application:,,,/Telerik.Windows.Controls.RichTextBox;component/RichTextBoxUI/*
{{endregion}}

## Reorganized Resource Dictionaries 

When using implicit themes, you need to merge the XAML resources so you can have styling for the controls. RadRichTextBox for .NET Core needs the following resources:

#### [XAML]
{{region}}
    
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/System.Windows.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.Input.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.Navigation.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.RibbonView.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.RichTextBox.xaml" />
    <ResourceDictionary Source="/Telerik.Windows.Themes.VisualStudio2019;component/Themes/Telerik.Windows.Controls.ImageEditor.xaml" />
{{endregion}}