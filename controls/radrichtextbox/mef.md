---
title: MEF
page_title: MEF
description: Check our &quot;MEF&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-mef
tags: mef
published: True
position: 16
---

# MEF

`RadRichTextBox` uses the [Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/en-us/library/dd460648(v=vs.110).aspx) in order to provide customization options, such as creating and utilizing custom dialogs and pop-ups, format providers and dictionaries for spellchecking. It finds and loads the types from the assemblies and they can be used without being explicitly initialized.

## .NET Core and Later Versions Specifics

The content of this article is applicable only to the __RadRichTextBox for .NET Framework__ and later versions. The __.NET Core__ and later versions as they do not support MEF.

Replacing the RadRichTextBox tools, such as the `SelectionMiniToolBar` using custom attributes is not supported when using the control in a {{ site.minimum_net_core_version }} and above project. Instead, you can use the corresponding properties of the control to apply the customization options.

__Replacing RadRichTextBox tools with custom ones__
```C#
    this.richTextBox.SelectionMiniToolBar = new MyCustomSelectionMiniToolBar();
```
```VB.NET
    Me.richTextBox.SelectionMiniToolBar = New MyCustomSelectionMiniToolBar()
```

## Customization

MEF allows you to easily customize or even replace the extensible parts. 

### Dialogs, Selection Mini Toolbar and Context Menu

To plug a custom dialog and replace the default one you need to implement the corresponding interface and mark the class that implements it with an attribute. The following example shows how to replace the default `InsertDateTimeDialog` with a custom one. This will skip the default type and load the custom one. The same approach could be used to override the rest of the dialogs, the selection mini toolbar and the context menu.

__Create Custom Dialog__
```C#
	[CustomInsertDateTimeDialog]
	public partial class CustomInsertDateTimeDialog: RadRichTextBoxWindow, IInsertDateTimeDialog 
```

>tip You could find a complete example showing how to implement a custom InsertDateTimeDialog as well as other implementations of custom dialogs in the [XAML SDK repository on GitHub](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox).

### Format Providers

New format providers can be easily plugged-in by deriving from the `DocumentFormatProviderBase` class or directly from a concrete existing provider and marking the class with the `CustomDocumentFormatProviderAttribute` 

__Create Custom Format Provider__
```C#
	[CustomDocumentFormatProvider]
	public class DocFormatProvider : DocumentFormatProviderBase
```

>tip An example showing how to create a custom format provider could be downloaded [here](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/DocFormatProviderDemo).

>Thanks to MEF you could replace the `UILayersBuilder` class as well, which is responsible for loading all the UI layers. More details about how to change this builder and what are UI layers can be found [here]({%slug radrichtextbox-features-custom-ui-layers%}).

### Dictionaries

You can create and plug your custom dictionary by implementing the `IWordDictionary` interface. The next example demonstrates how to create a dictionary for Danish.

__Create Custom Dictionary__
```C#
    [WordDictionaryMetadata("da-DK")]
    public class CustomDanishDictionary : IWordDictionary
```

## Initial Load Performance of RadRichTextBox

When RadRichTextBox is loaded, the MEF checks all the assemblies, which the control has dependencies to and loads the necessary parts using reflection. However, traversing all the assemblies and searching if there is something to load in them is a slow operation and may decrease the initial load performance of the control. The possible approaches to speed up the loading of the necessary application types or load them without using MEF are listed below.

### Explicitly set the necessary types

You can define a new `TypeCatalog` with the necessary types and pass it to the `Catalog` property of `RadCompositionInitializer` on application start-up before the RadRichTextBox is instantiated. In this scenario, the MEF will know exactly which types to load and won’t search for other ones. The following example shows the full `TypeCatalog` for the control.

>The code in the next snippet requires a reference to System.ComponentModel.Composition.dll.

__Create TypeCatalog__
```C#
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
                
    // the default English spellchecking dictionary
    typeof(RadEn_USDictionary),
                
    // dialogs 
    typeof(AddNewBibliographicSourceDialog), 
    typeof(ChangeEditingPermissionsDialog), 
    typeof(CodeFormattingDialog), 
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
    typeof(SectionColumnsDialog), 
    typeof(SetNumberingValueDialog), 
    typeof(SpellCheckingDialog), 
    typeof(StyleFormattingPropertiesDialog), 
    typeof(TableBordersDialog), 
    typeof(TablePropertiesDialog), 
    typeof(TabStopsPropertiesDialog), 
    typeof(UnprotectDocumentDialog), 
    typeof(WatermarkSettingsDialog),
    typeof(PasteOptionsPopup),
    typeof(CheckBoxPropertiesDialog),
    typeof(DatePickerPropertiesDialog),
    typeof(DropDownListPropertiesDialog),
    typeof(PlainTextPropertiesDialog),
    typeof(RichTextPropertiesDialog),
    typeof(RepeatingSectionPropertiesDialog),
    typeof(PicturePropertiesDialog));
```
```VB.NET
       UI.Extensibility.RadCompositionInitializer.Catalog = New ComponentModel.Composition.Hosting.TypeCatalog(
            GetType(XamlFormatProvider),
            GetType(RtfFormatProvider),
            GetType(DocxFormatProvider),
            GetType(PdfFormatProvider),
            GetType(HtmlFormatProvider),
            GetType(TxtFormatProvider),
            GetType(SelectionMiniToolBar),
            GetType(ImageMiniToolBar),
            GetType(Telerik.Windows.Controls.RichTextBoxUI.ContextMenu),
            GetType(RadEn_USDictionary),
            GetType(AddNewBibliographicSourceDialog),
            GetType(ChangeEditingPermissionsDialog),
            GetType(CodeFormattingDialog),
            GetType(EditCustomDictionaryDialog),
            GetType(FindReplaceDialog),
            GetType(FloatingBlockPropertiesDialog),
            GetType(FontPropertiesDialog),
            GetType(ImageEditorDialog),
            GetType(InsertCaptionDialog),
            GetType(InsertCrossReferenceWindow),
            GetType(InsertDateTimeDialog),
            GetType(InsertTableDialog),
            GetType(InsertTableOfContentsDialog),
            GetType(ManageBibliographicSourcesDialog),
            GetType(ManageBookmarksDialog),
            GetType(ManageStylesDialog),
            GetType(NotesDialog),
            GetType(ProtectDocumentDialog),
            GetType(RadInsertHyperlinkDialog),
            GetType(RadInsertSymbolDialog),
            GetType(RadParagraphPropertiesDialog),
            GetType(SectionColumnsDialog),
            GetType(SetNumberingValueDialog),
            GetType(SpellCheckingDialog),
            GetType(StyleFormattingPropertiesDialog),
            GetType(TableBordersDialog),
            GetType(TablePropertiesDialog),
            GetType(TabStopsPropertiesDialog),
            GetType(UnprotectDocumentDialog),
            GetType(WatermarkSettingsDialog),
            GetType(PasteOptionsPopup),
            GetType(CheckBoxPropertiesDialog),
            GetType(DatePickerPropertiesDialog),
            GetType(DropDownListPropertiesDialog),
            GetType(PlainTextPropertiesDialog),
            GetType(RichTextPropertiesDialog),
            GetType(RepeatingSectionPropertiesDialog),
            GetType(PicturePropertiesDialog))
```
You could remove all the types you won’t need in your application.

>important The type catalog you set is going to be used from all instances of RadRichTextBox in the application.

### Format Providers Loading

By default, RadRichTextBox loads all the format providers in the referenced assemblies. If you don’t need them all, you could turn off the MEF and register only the used providers. The next example demonstrates how to load only DocxFormatProvider, even if other format providers assemblies are added to the project .

__Load Format Provider__
```C#
	DocumentFormatProvidersManager.AutomaticallyLoadFormatProviders = false;
	DocumentFormatProvidersManager.RegisterFormatProvider(new DocxFormatProvider());
```


### UILayersBuilder Loading

The `UILayersBuilder` class is responsive for loading all the UI layers in RadRichTextBox. The initialization of this type will load the layers without using MEF.

__Initialize UILayersBuilder__
```C#
	this.radRichTextBox.UILayersBuilder = new UILayersBuilder();
```

### Spell Checking

All the dictionaries for the spell checking functionality are loaded with MEF. You could prevent this in two ways.

* If the spell checking is not among the requirements for the application, you could turn it off.

	__Disable Spell Checking__
		```C#
	
			this.radRichTextBox.IsSpellCheckingEnabled = false;
		```

* In case you plan to use the built-in spell checker, you could tell the MEF to not search and load for all the default dictionaries and load manually only the ones which will be used in your application.

	__Use Spell Checking Without MEF__
		```C#
	
			this.radRichTextBox.IsSpellCheckingEnabled = true;
			DocumentSpellChecker documentSpellChecker = this.radRichTextBox.SpellChecker as DocumentSpellChecker;
			documentSpellChecker.AutomaticallyLoadDefaultDictionaries = false;
		```

## See also  
*[Performance]({%slug radrichtextbox-performance%})