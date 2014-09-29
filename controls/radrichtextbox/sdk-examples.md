---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radrichtextbox-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadRichTextBox__.

## List of all RadRichTextBox SDK examples:{% if site.site_name == 'WPF' %}

* __Change ribbons data context__ -  Change ribbons data context  The example shows how the DataContext of RadRichTextBoxRIbbonUI can be changed run-time.

* __Custom code formatting language__ - The demo demonstrates how you can plug a custom formatting language which to be used in the Code dialog. Additional information about the Code Block feature can be found in the following article: http://www.telerik.com/help/silverlight/radrichtextbox-features-code-block.html/ http://www.telerik.com/help/wpf/radrichtextbox-features-code-block.html

* __Custom field__ - This example illustrates how to create custom field which calculates the total pages of the document and the current page number of a section. Regardless of the place where you have inserted the field at your document(Header, Footer, Body, FootNote, EndNote and etc.), you can obtain an information for the main document through its EvaluationContext property.

* __Custom find replace dialog__ - This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomFindReplaceDialog].

* __Custom floating block properties dialog__ -  Custom floating block properties dialog  This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. The FloatingBlockProperties dialog is invoked from the context menu when clicking on an image and selecting the Text Wrapping -> More Layout Options option. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomFloatingBlockPropertiesDialog].

* __Custom image editor dialog__ - This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomImageEditorDialog].

* __Custom insert hyperlink dialog__ - This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the respective attribute as [CustomInsertHyperlink].

* __Customize paste__ - This example demonstrates how pasting can be customized in order to disbale and enable rich text paste. In addition to reordering the format providers, it is also possible to attach to different events of the format providers and their settings.

* __Customize printing__ - The example demonstrates how to print silently with given printer. When you specify a printer name, the printer with the provided name will print the provided document silently. If the printer with the chosen name is not found, the default printer is being used.

* __Custom spell checking dialog__ - This example illustrates how the default SpellCheckingDialog can be replaced by a custom one.

* __Data binding__ - The current example demonstrates how you can bind the contents of RadRichTextBox to a property of your data source using the XamlDataProvider. More on format providers you can find here: http://www.telerik.com/help/wpf/radrichtextbox-features-data-providers.html.

* __Drag and drop in editor__ -  Drag and drop in editor  This example demonstrates the way DragAndDropManager can be used with RadRichTextBox. In the example, when you drag items from the TreeView into the editor, they get inserted at the appropriate position in the current editor.

* __Getting started__ - The sample demonstrates the basic scenario where you create a document from code and edit its formatting. It also complies with the Getting Started article.

* __Localization__ - The example shows how RadRichTextBox along with the predefined UI of the control can be localized. The RadRichTextBoxResources file contains all localizable strings. More about the approaches for localization you can find here: http://www.telerik.com/help/silverlight/radrichtextbox-localization.html. 

* __Mail merge__ - This example illustrates Mail Merge functionality. You could select different authors from the ribbon and different job positions. You can also save the merged document to any of the supported formats.

* __Merge documents__ - This example demonstrates how multiple documents can be merged into one. After inserting each fragment in the merged document, the properties of the last section of the inserted piece are copied. This is done due to the fact that InsertFragment() does not copy the properties of the last section, but works as would copy/pasting do - places the caret after the inserted piece and takes the properties from the "large" document.

* __Plain text editor__ - The example demonstrates how to disable all rich-text editing capabilities and use RadRichTextBox as plain text editor.

* __RadToolBar UI__ -  RadToolBar UI  This example shows how RadToolBar can be used instead of the default RadRichTextBoxRibbonUI in order to achieve a simpler overall look. 

* __Search and highlight__ - This example demonstrates how the search and position functionality can be used to create a custom UI layer that highlights all occurrences of the searched text.

* __Simulate watermark__ - This example demonstrates how you can strip the rich-text formatting options of RadRichTextBox and place text in it when the control is empty (similar to RadWatermarkTextBox).

* __Telerik editor__ - This example demonstrates how the commands can be wired with RadRichTextBoxRibbonUI in order to be able to utilize all of the functionality of the control through a well-known user interface.

* __Thread safe document conversion__ - This example demonstrates how DocxFormatProvider, HtmlFormatProvider, RtfFormatProvider and XamlFormatProvider can be used in a thread safe scenario for document conversion.

* __Watermark__ - The example demonstrates how to create and apply a watermark from code.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Change ribbons data context__ -  Change ribbons data context  The example shows how the DataContext of RadRichTextBoxRIbbonUI can be changed run-time.

* __Custom code formatting language__ - The demo demonstrates how you can plug a custom formatting language which to be used in the Code dialog. Additional information about the Code Block feature can be found in the following article: http://www.telerik.com/help/silverlight/radrichtextbox-features-code-block.html/ http://www.telerik.com/help/wpf/radrichtextbox-features-code-block.html

* __Custom field__ - This example illustrates how to create custom field which calculates the total pages of the document and the current page number of a section. Regardless of the place where you have inserted the field at your document(Header, Footer, Body, FootNote, EndNote and etc.), you can obtain an information for the main document through its EvaluationContext property.

* __Custom find replace dialog__ - This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomFindReplaceDialog].

* __Custom floating block properties dialog__ -  Custom floating block properties dialog  This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. The FloatingBlockProperties dialog is invoked from the context menu when clicking on an image and selecting the Text Wrapping -> More Layout Options option. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomFloatingBlockPropertiesDialog].

* __Custom image editor dialog__ - This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the attribute [CustomImageEditorDialog].

* __Custom insert hyperlink dialog__ - This example demonstrates how custom dialogs can be created and wired to work with the commands of the editor using MEF. Note that all that is needed to have the commands of the editor use the custom dialog is to implement the respective interface and mark the class with the respective attribute as [CustomInsertHyperlink].

* __Custom spell checking dialog__ - This example illustrates how the default SpellCheckingDialog can be replaced by a custom one.

* __Data binding__ - The current example demonstrates how you can bind the contents of RadRichTextBox to a property of your data source using the XamlDataProvider. More on format providers you can find here: http://www.telerik.com/help/wpf/radrichtextbox-features-data-providers.html.

* __Drag and drop in editor__ -  Drag and drop in editor  This example demonstrates the way DragAndDropManager can be used with RadRichTextBox. In the example, when you drag items from the TreeView into the editor, they get inserted at the appropriate position in the current editor.

* __Getting started__ - The sample demonstrates the basic scenario where you create a document from code and edit its formatting. It also complies with the Getting Started article.

* __Localization__ - The example shows how RadRichTextBox along with the predefined UI of the control can be localized. The RadRichTextBoxResources file contains all localizable strings. More about the approaches for localization you can find here: http://www.telerik.com/help/silverlight/radrichtextbox-localization.html. 

* __Mail merge__ - This example illustrates Mail Merge functionality. You could select different authors from the ribbon and different job positions. You can also save the merged document to any of the supported formats.

* __Merge documents__ - This example demonstrates how multiple documents can be merged into one. After inserting each fragment in the merged document, the properties of the last section of the inserted piece are copied. This is done due to the fact that InsertFragment() does not copy the properties of the last section, but works as would copy/pasting do - places the caret after the inserted piece and takes the properties from the "large" document.

* __Plain text editor__ - The example demonstrates how to disable all rich-text editing capabilities and use RadRichTextBox as plain text editor.

* __RadToolBar UI__ -  RadToolBar UI  This example shows how RadToolBar can be used instead of the default RadRichTextBoxRibbonUI in order to achieve a simpler overall look. 

* __Search and highlight__ - This example demonstrates how the search and position functionality can be used to create a custom UI layer that highlights all occurrences of the searched text.

* __Simulate watermark__ - This example demonstrates how you can strip the rich-text formatting options of RadRichTextBox and place text in it when the control is empty (similar to RadWatermarkTextBox).

* __Telerik editor__ - This example demonstrates how the commands can be wired with RadRichTextBoxRibbonUI in order to be able to utilize all of the functionality of the control through a well-known user interface.

* __Watermark__ - The example demonstrates how to create and apply a watermark from code.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
