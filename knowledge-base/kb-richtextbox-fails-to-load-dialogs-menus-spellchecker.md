---
title: RadRichTextBox Fails to Load Dialogs, Menus, and the Spell Checker
description: Learn why MEF discovery failures prevent RadRichTextBox dialogs, menus, import/export, and spell checking from loading, and how to fix them.
components: ["richtextbox"]
type: troubleshooting
page_title: RadRichTextBox Missing Dialogs and Menus, Failed Save/Load, and Spell Checker Not Working
slug: kb-richtextbox-fails-to-load-dialogs-menus-spellchecker
tags: radrichtextbox, troubleshooting, mef, dialogs, menus, spellchecker, prism, typecatalog
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadRichTextBox for WPF</td>
		</tr>
	</tbody>
</table>

## Description

RadRichTextBox requires several prerequisites to use its default UI, such as `InsertHyperlinkDialog`, `ContextMenu`, and `SelectionMiniToolbar`. This is also the case with the import/export functionality and spell checking.

The first prerequisite is to reference the assembly that contains the implementation of the feature:

* For .NET Framework, reference `Telerik.Windows.Controls.RichTextBoxUI` and its dependencies. For .NET, install the `Telerik.Windows.Controls.RichTextBox.for.Wpf` NuGet package, which includes the UI dependencies.

* __Telerik.Windows.Documents.FormatProviders.[Xaml/Html/OpenXml/Rtf/Pdf]__ for the respective format and __Telerik.Windows.Zip__ for docx and PDF.

* __Telerik.Windows.Documents.Proofing.Dictionary.En-US__ for the En-US spell checking dictionary.

More information on this can be found in the [Getting Started]({%slug radrichtextbox-getting-started%}) article.

More often than not, this is sufficient to get everything working. RadRichTextBox uses [MEF]({%slug radrichtextbox-mef%}) to provide customization options, such as creating and utilizing custom dialogs and pop-ups, format providers, and dictionaries for spell checking. It finds and loads the types from the assemblies, and they can be used without being explicitly initialized.

However, there are some cases when MEF cannot find the assemblies and load the types. One example is when you have enabled library caching or you are using Prism. When this happens, the dialogs and menus do not load, saving or loading a file fails, and the spell checker underlines correctly spelled words.

## Solution

In the cases when MEF cannot find the assemblies, pass the types that RadRichTextBox uses in a `TypeCatalog` to `RadCompositionInitializer` as shown below.

__Defining the Catalog of Types Used by RadRichTextBox__

<snippet id='radrichtextbox-troubleshooting-common-problems-block_1-cs' />

You can do this on application start-up or in the constructor of your page, just before `InitializeComponent()`.

>As RadRichTextBox does not have a dependency on RichTextBoxUI, Prism does not normally copy those assemblies to the Shell project when the view containing RadRichTextBox is in another project. To resolve the problem, use one of the following approaches:

* Add references to the required assemblies in the Shell project, too. You can do this manually from Visual Studio or as part of a prebuild command on the Shell project or a postbuild command on the Module project in which you added the references.

* Do not rely on MEF to load the RichTextBoxUI format provider assemblies. Instead, register the providers and create instances of all default menus and dialogs, and assign them to the respective properties of RadRichTextBox in the constructor of the view with the RadRichTextBox, like in the snippet above.

## See Also

* [MEF]({%slug radrichtextbox-mef%})
* [Getting Started]({%slug radrichtextbox-getting-started%})
* [Data Providers Troubleshooting]({%slug radrichtextbox-features-data-providers%}#troubleshooting)
