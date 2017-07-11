---
title: MEF
page_title: MEF
description: MEF
slug: radrichtextbox-mef
tags: mef
published: True
position: 16
---

# MEF

__RadRichTextBox__ uses the [Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/en-us/library/dd460648(v=vs.110).aspx) in order to provide customization options, such as creating and utilizing custom dialogs and pop-ups, format providers and dictionaries for spellchecking. It finds and loads the types from the assemblies and they can be used without being explicitly initialized.

* [Customization](#customization)

* [Initial Load Performance of RadRichTextBox](#initial-load-performance-of-radrichtextbox)

## Customization

MEF allows you to easily customize or even replace the extensible parts. 

### Dialogs, Selection Mini Toolbar and Context Menu

To plug a custom dialog and replace the default one you need to implement the corresponding interface and mark the class that implements it with an attribute. __Example 1__ shows how to replace the default __InsertDateTimeDialog__ with a custom one. This will skip the default type and load the custom one. The same approach could be used to override the rest of the dialogs, the selection mini toolbar and the context menu.


#### __[C#] Example 1: Create Custom Dialog__
{{region radrichtextbox-mef_0}}

	[CustomInsertDateTimeDialog]
	public partial class CustomInsertDateTimeDialog: RadRichTextBoxWindow, IInsertDateTimeDialog 
{{endregion}}

>tip You could find a complete example showing how to implement a custom InsertDateTimeDialog as well as other implementations of custom dialogs in the [XAML SDK repository on GitHub](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox).
 

### Format Providers

New format providers can be easily plugged-in by deriving from the __DocumentFormatProviderBase__ class or directly from a concrete existing provider and marking the class with the __CustomDocumentFormatProviderAttribute__ 

#### __[C#] Example 2: Create Custom Format Provider__
{{region radrichtextbox-mef_1}}

	[CustomDocumentFormatProvider]
	public class DocFormatProvider : DocumentFormatProviderBase
{{region}}

>tip An example showing how to create a custom format provider could be downloaded [here](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/DocFormatProviderDemo).



>Thanks to MEF you could replace the __UILayersBuilder__ class as well, which is responsible for loading all the UI layers. More details about how to change this builder and what are UI layers can be found [here]({%slug radrichtextbox-features-custom-ui-layers%}).


### Dictionaries

You can create and plug your custom dictionary by implementing the __IWordDictionary__ interface. __Example 3__ demonstrates how to create a dictionary for Danish.


#### __[C#] Example 3: Create Custom Dictionary__

{{region radrichtextbox-mef_2}}

    [WordDictionaryMetadata("da-DK")]
    public class CustomDanishDictionary : IWordDictionary
{{region}}


## Initial Load Performance of RadRichTextBox

When __RadRichTextBox__ is loaded, the MEF checks all the assemblies, which the control has dependencies to and loads the necessary parts using reflection. However, traversing all the assemblies and searching if there is something to load in them is a slow operation and may decrease the initial load performance of the control. Below are listed the possible approaches to speed up the loading of all necessary for the application types or just load them without using MEF.

### Explicitly set the necessary types

You can define a new __TypeCatalog__ with the necessary types and pass it to the Catalog property of __RadCompositionInitializer__ on application start-up before the __RadRichTextBox__ is instantiated. In this scenario, the MEF will know exactly which types to load and won’t search for other ones. __Example 4__ shows the full __TypeCatalog__ for the control.


#### __[C#] Example 4: Create TypeCatalog__

{{region radrichtextbox-mef_3}}

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
    typeof(ContextMenu),
                
    // the default English spellchecking dictionary
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

You could remove all the types you won’t need in your application.

>important The type catalog you set is going to be used from all instances of __RadRichTextBox__ in the application.


### Format Providers Loading

By default, __RadRichTextBox__ loads all the format providers in the referenced assemblies. If you don’t need them all, you could turn off the MEF and register only the used providers. __Example 5__ demonstrates how to load only DocxFormatProvider, even if other format providers assemblies are added to the project .


#### __[C#] Example 5: Load Format Provider__
{{region radrichtextbox-mef_4}}

	DocumentFormatProvidersManager.AutomaticallyLoadFormatProviders = false;
	DocumentFormatProvidersManager.RegisterFormatProvider(new DocxFormatProvider());
{{endregion}}


### UILayersBuilder Loading

The __UILayersBuilder__ class is responsive for loading all the UI layers in the __RadRichTextBox__. The initialization of this type will load the layers without using MEF.


#### __[C#] Example 6: Initialize UILayersBuilder__
{{region radrichtextbox-mef_5}}
	this.radRichTextBox.UILayersBuilder = new UILayersBuilder();
{{endregion}}


### Spell Checking

All the dictionaries for the spell checking functionality are loaded with MEF. You could prevent this in two ways.

* If the spell checking is not among the requirements for the application, you could turn it off.


	#### __[C#] Example 7: Disable Spell Checking__
		{{region radrichtextbox-mef_6}}
	
			this.radRichTextBox.IsSpellCheckingEnabled = false;
		{{endregion}}

* In case you plan to use the built-in spell checker, you could tell the MEF to not search and load for all the default dictionaries and load manually only the ones which will be used in your application.


	#### __[C#] Example 8: Use Spell Checking Without MEF__
		{{region radrichtextbox-mef_7}}
	
			this.radRichTextBox.IsSpellCheckingEnabled = true;
			DocumentSpellChecker documentSpellChecker = this.radRichTextBox.SpellChecker as DocumentSpellChecker;
			documentSpellChecker.AutomaticallyLoadDefaultDictionaries = false;
		{{endregion}}


# See also 

* [Performance]({%slug radrichtextbox-performance%})
