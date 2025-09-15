---
title: Troubleshooting Common Problems
page_title: Troubleshooting Common Problems
description: Check our &quot;Troubleshooting Common Problems&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-troubleshooting-common-problems
tags: troubleshooting,common,problems
published: True
position: 0
---

# Troubleshooting Common Problems



This article describes common problems that can be encountered when using __RadRichTextBox__ and their solutions.
      

It contains the following topics:{% if site.site_name == 'Silverlight' %}

* [Missing Dialogs, Menus, Unable to Save/Load a File, SpellChecker Underlines Correct Words;](#missing-dialogs-and-menus,-unable-to-save/load-a-file,-spellchecker-underlines-correct-words)

* [Missing Images in Lightswitch;](#missing-images-in-lightswitch)

* [Exception when inserting or manipulating images.](#Exception_when_inserting_or_manipulating_images){% endif %}{% if site.site_name == 'WPF' %}

* [Missing Dialogs, Menus, Unable to Save/Load a File, SpellChecker Underlines Correct Words;](#missing-dialogs-and-menus,-unable-to-save/load-a-file,-spellchecker-underlines-correct-words)

* [Exception when inserting or manipulating images.](#Exception_when_inserting_or_manipulating_images){% endif %}

## Missing Dialogs and Menus, Unable to Save/Load a File, SpellChecker Underlines Correct Words

There are several prerequisites to using the default UI that RadRichTextBox uses, such as InsertHyperlinkDialog, ContextMenu and SelectionMiniToolbar. This is also the case with the import/export functionality and spellchecking.
        

The first one is to have referenced the assembly that contains the implementation of the feature:

* __Telerik.Windows.Controls.RichTextBoxUI__ and the assemblies it depends on for the UI;
          

* __Telerik.Windows.Documents.FormatProviders.[Xaml/Html/OpenXml/Rtf/Pdf]__ for the respective format and __Telerik.Windows.Zip__ for docx and PDF;
          

* __Telerik.Windows.Documents.Proofing.Dictionary.En-US__ for the En-US spellchecking dictionary.
          

More information on this can be found [here]({%slug radrichtextbox-getting-started%}).
        

More often than not, this is sufficient to get everything working. RadRichTextBox uses [MEF](http://mef.codeplex.com/) in order to provide customization options, such as creating and utilizing custom dialogs and pop-ups, format providers and dictionaries for spellchecking. It finds and loads the types from the assemblies and they can be used without being explicitly initialized.
        

However, there are some cases when MEF cannot find the assemblies and load the types. One example is if you have enabled Library Caching or you are using Prism. In these cases, you can pass the types that RadRichTextBox uses in a TypeCatalog to RadCompositionInitializer as shown below:
        

__Example 1: Defining the catalog of types used by RadRichTextBox__

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
	    typeof(WatermarkSettingsDialog)
	    );
```



This can be done on application start-up or in the constructor of your page, just before InitializeComponent().

>As RadRichTextBox does not have a dependency on RichTextBoxUI, the assemblies are not normally copied to the Shell project by Prism and are not included in the XAP, if the view containing the RichTextBox is in another project. In order to resolve the problem, you can adopt one of the following approaches:
          

* Add references to the required assemblies in the Shell project, too. This can be done manually from Visual Studio or as part of a prebuild command on the Shell project or a postbuild command on the Module project in which you have added the references;

* Do not rely on MEF to load the RichTextBoxUI format provider assemblies. Instead, register the providers and create instances of all default menus and dialogs and assign them to the respective properties of RadRichTextBox in the constructor of the View with the RadRichTextBox like in the snippets above.

## Exception when inserting or manipulating images

{% if site.site_name == 'Silverlight' %}
RadRichTextBox uses the RadBitmap class to visualize images. RadBitmap, on the other hand, internally uses [WritableBitmap](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.writeablebitmap(v=vs.95).aspx). {% endif %}

{% if site.site_name == 'WPF' %}
RadRichTextBox uses the RadBitmap class to visualize images. RadBitmap, on the other hand, internally uses [WritableBitmap](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.writeablebitmap(v=vs.100).aspx).{% endif %}

Unfortunately, WritableBitmap is not always very efficient when populated with an extremely large image and on some occasions inserting or manipulating (for example, applying an effect to) such image might cause performance diminishment as well as an OutOfMemoryЕxception. At this point there is no workaround for the issue.
    
## "Win32Exception (0x80004005): Not enough storage is available to process this command" is thrown when multiple RadDocument instances are created in background threads

The exception occurs due to a leak of Dispatcher instances and their related infrastructure objects. When any DispatcherObject type is instantiated on a thread, a Dispatcher instance is associated with this thread. Even after the thread finishes successfully, its Dispatcher is not disposed. The described behavior is also reproducible with RadDocument, as it uses core WPF logic for some of its operations. For instance, using a Brush element on a thread automatically instantiates a Dispatcher object.

The exception is reproducible only in scenarios with heavy usage of new threads. If you plan on incorporating such solutions, we suggest that you use the workaround shown in **Example 2**, also recommended by Microsoft.

#### **[C#] Example 2: Shut down Dispatcher of a thread**

```C#

    Thread thread = new Thread(() =>
    {
        // Thread logic
        System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvokeShutdown(System.Windows.Threading.DispatcherPriority.Normal);
    });
```

## See Also

* [Data Providers Troubleshooting]({%slug radrichtextbox-features-data-providers%}#troubleshooting)
