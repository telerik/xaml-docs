---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radpdfviewer-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadPdfViewer__.

## List of all RadPdfViewer SDK examples:

{% if site.site_name == 'WPF' %}

* __[Change scale factor](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/ChangeScaleFactor)__ - The example demonstrates how to change the ScaleFactor of RadPdfViewer. In this case this is done in the DocumentChanged event and the set value will be used for each document shown in the viewer.
* __[Context menu](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/ContextMenu)__ - The example demonstrates how to wire a context menu to RadPdfViewer.
* __[Custom command descriptor](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomCommandDescriptor)__ - The example demonstrates how to add custom command descriptors.
* __[Custom find dialog](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomFindDialog)__ - This example demonstrates how to create a custom find dialog for RadPdfViewer. The dialog can be invoked with the Ctrl+F shortcut.
* __[Custom presenter](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomPresenter)__ - This example demonstrates how to create and register a custom presenter for RadPdfViewer. When the buttons are clicked, the appropriate presenter is set.
* __[Custom printing](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomPrinting)__ - The example demonstrates how to print silently with given printer. When you specify a printer name, the printer with the provided name will print the provided document silently. If the printer with the chosen name is not found, the default printer is being used.
* __[First look](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/FirstLook)__ - The example demonstrates how to bind the commands of RadPdfViewer to a RadToolBar. It also shows how to load a file from Uri or Stream.
* __[Localization](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/Localization)__ - This example shows how you can localize RadPdfViewer's UI.  The PdfViewerResources.resx file contains all localizable strings for the control.
* __[Custom save command](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/PdfViewerCustomSaveCommand)__ -  Custom save command 
This example shows how a custom save command can be created which allows users can save the file they have previewed.
* __[Thumbnails](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/Thumbnails)__ - The example shows how to customize the look of RadPdfViewer by adding thumbnail functionality.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Change scale factor](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/ChangeScaleFactor)__ - The example demonstrates how to change the ScaleFactor of RadPdfViewer. In this case this is done in the DocumentChanged event and the set value will be used for each document shown in the viewer.
* __[Context menu](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/ContextMenu)__ - The example demonstrates how to wire a context menu to RadPdfViewer.
* __[Custom command descriptor](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomCommandDescriptor)__ - The example demonstrates how to add custom command descriptors.
* __[Custom find dialog](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomFindDialog)__ - This example demonstrates how to create a custom find dialog for RadPdfViewer. The dialog can be invoked with the Ctrl+F shortcut.
* __[Custom presenter](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomPresenter)__ - This example demonstrates how to create and register a custom presenter for RadPdfViewer. When the buttons are clicked, the appropriate presenter is set.
* __[First look](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/FirstLook)__ - The example demonstrates how to bind the commands of RadPdfViewer to a RadToolBar. It also shows how to load a file from Uri or Stream.
* __[Localization](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/Localization)__ - This example shows how you can localize RadPdfViewer's UI.  The PdfViewerResources.resx file contains all localizable strings for the control.
* __[Custom save command](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/PdfViewerCustomSaveCommand)__ -  Custom save command 
This example shows how a custom save command can be created which allows users can save the file they have previewed.
* __[Thumbnails](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/Thumbnails)__ - The example shows how to customize the look of RadPdfViewer by adding thumbnail functionality.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).