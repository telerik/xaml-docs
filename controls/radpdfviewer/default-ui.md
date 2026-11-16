---
title: Default UI
page_title: Default UI
description: Learn how to add the default UI to the WPF RadPdfViewer, choose dialogs and navigation panels, and customize the toolbar and context menu.
components: ["pdfviewer"]
slug: radpdfviewer-default-ui
tags: default, ui, radpdfviewertoolbar
published: True
position: 2
---

# Default UI

Use the predefined user interface (UI) of `RadPdfViewer` to add PDF viewing commands to your application. `RadPdfViewerToolBar` provides page navigation, [zoom]({%slug radpdfviewer-zoom-in-or-out-a-radfixeddocument%}), and buttons to open, save, and print documents.

`RadPdfViewerNavigationPane` displays navigation panels, including the document's [bookmarks]({%slug radpdfviewer-features-bookmarks%}). Add the components you need with the Visual Studio designer, then customize the toolbar and context menu.

>caption RadPdfViewer with default UI, RadPdfViewerNavigationPane, and context menu

![PDF document with a toolbar, navigation pane, and context menu](images/RadPdfViewer_defaultUI_00.png)

## Adding RadPdfViewer with Predefined UI to Your Application

Before you begin, configure your Windows Presentation Foundation (WPF) project with the references described in [Getting Started with RadPdfViewer]({%slug radpdfviewer-getting-started%}). Include the dialogs and additional UI references, not only the minimal viewer references. For NuGet applications that use Xaml binaries, install `Telerik.Windows.Controls.FixedDocumentViewersUI.for.Wpf.Xaml`. For NoXaml applications, follow the package and theme guidance in the getting-started article.

>note The designer's component-selection dialog is available starting with R1 2018.

To add the viewer and choose its UI components:

1. Drag `RadPdfViewer` from the Visual Studio **Toolbox** to the XAML (Extensible Application Markup Language) designer.
2. Select the components you need in the component-selection dialog and select **OK** to generate the XAML.

The dialog provides the following options:

* **Add ToolBar**&mdash;Adds `RadPdfViewerToolBar` with PDF viewing commands. Clear this option to omit the toolbar.

* **Add Signature Panel**&mdash;Adds a panel that shows validation results for documents with [digital signatures]({%slug radpdfviewer-features-digital-signature%}).

* **Add Context Menu**&mdash;Adds the viewer's [context menu]({%slug radpdfviewer-context-menu%}).

* **Add Find Dialog**&mdash;Adds the **[Find Dialog]({%slug radpdfviewer-find-dialog%})** for document searches.

* **Add Signature Properties Dialog**&mdash;Adds the **[Signature Properties Dialog]({%slug radpdfviewer-features-digital-signature%}#using-signaturepropertiesdialog)**.

* **Add Sign Signature Dialog**&mdash;Adds the **[Sign Signature Dialog]({%slug radpdfviewer-features-digital-signature%}#signing)**.

* **Add Navigation Pane**&mdash;Adds `RadPdfViewerNavigationPane` to display the document's bookmarks.

>caption Choose the components you would like to use

![Component-selection dialog with checkboxes for the toolbar, panels, context menu, and dialogs](images/RadPdfViewer_defaultUI_01.png)

**Example 1** shows the XAML generated when you select all options.

**[XAML] Example 1: Default UI**

<snippet id='radpdfviewer-default-ui-block_1-xaml' />
 
## Customizing the Default UI

Use the toolbar properties to show or hide existing buttons and sections. For custom buttons or layout changes, replace the toolbar with editable XAML.

For project prerequisites, see [Getting Started with RadPdfViewer]({%slug radpdfviewer-getting-started%}).

### Adding and Removing Buttons and Sections from RadPdfViewerToolBar

`RadPdfViewerToolBar` exposes properties that show or hide parts of its UI. Select the toolbar in the Visual Studio designer and open the **Properties** window to find the available options.

>caption Toolbar customization options in the Visual Studio Properties window

![Checkboxes for showing or hiding RadPdfViewerToolBar buttons and sections](images/RadPdfViewer_defaultUI_02.png)

The default value for all of the **ToolBar Customization** options is `true`. Clear an option to set the corresponding property in XAML to `false`. **Example 2** shows these properties in XAML.

**[XAML] Example 2: Using the properties of RadPdfViewerToolBar**

<snippet id='radpdfviewer-default-ui-block_2-xaml' />


### Customizing the Template of RadPdfViewerToolBar

To add a custom button or change the toolbar layout, replace `RadPdfViewerToolBar` with editable XAML:

1. Right-click `RadPdfViewerToolBar` in the Visual Studio designer.
2. Select **Replace RadPdfViewerToolBar with Editable XAML** from the context menu.

>caption Replace RadPdfViewerToolBar with editable XAML option of the Visual Studio designer's context menu

![Designer context menu command for replacing the PDF viewer toolbar with editable markup](images/RadPdfViewer_defaultUI_03.png)

>important This operation replaces the `RadPdfViewerToolBar` instance with its generated XAML. The extracted markup no longer receives the toolbar control's automatic UI updates or styling support. Use the toolbar properties instead when you only need to show or hide existing buttons.



### Customizing the Template of the Default Context Menu

To edit the default context menu's XAML:

1. Right-click `RadPdfViewer` in the Visual Studio designer.
2. Select **Replace Default Context Menu with Editable XAML** from the context menu.

For context-menu configuration details, see the [context menu documentation]({%slug radpdfviewer-context-menu%}).

## See Also

* [Getting Started with RadPdfViewer]({%slug radpdfviewer-getting-started%})
* [Showing a File]({%slug radpdfviewer-showing-a-file%})
* [Bookmarks]({%slug radpdfviewer-features-bookmarks%})
* [Interactive Forms]({%slug radpdfviewer-features-interactive-forms%})