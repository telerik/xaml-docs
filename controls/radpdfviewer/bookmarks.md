---
title: Bookmarks (Outlines)
page_title: Bookmarks (Outlines)
description: Check our &quot;Bookmarks (Outlines)&quot; documentation article for the RadPdfViewer WPF control.
slug: radpdfviewer-features-bookmarks
tags: bookmarks, outlines
published: True
position: 4
---

# Bookmarks (Outlines)

`RadPdfViewer` enables you to open documents and show the bookmarks they contain in a bookmarks panel. Bookmarks or Outlines are a tree-structured hierarchy that the reader presents as a visual table of contents separated from the actual content as a side panel. The Bookmark items allow users, by interacting with them, to navigate through parts of the document and/or invoke different actions.  

__Bookmarks in RadPdfViewer__

![RadPdfViewer Bookmarks in RadPdfViewer](images/RadPdfViewer_Bookmarks_01.png)

## Visualizing Bookmarks

In RadPdfViewer, you can show bookmarks using the `RadPdfViewerNavigationPane` element. This is a control that represents an area that can display different navigation panels. This includes the Bookmarks of the PDF document, which serve as a table of contents. RadPdfViewerNavigationPane exposes the `PaneWidth` property, which you can use to specify the width of the panel.

#### [XAML] Define RadPdfViewerNavigationPane
```XAML
	<Grid>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="Auto" />
	        <ColumnDefinition />
	    </Grid.ColumnDefinitions>
	    <telerik:RadPdfViewerNavigationPane RadPdfViewer="{Binding ElementName=pdfViewer, Mode=OneTime}" PaneWidth="300" />
	    <telerik:RadPdfViewer Grid.Column="1" x:Name="pdfViewer" DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}" />
	</Grid>
```

The items inside the panel are represented by the [BookmarkItem](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/bookmarks#bookmarkitem-class) class, which can be used to obtain information about the style, text, appearance, action and destination of the bookmark.

## Setting the Visibility of the Bookmarks in the RadFixedDocument

The PDF format allows you to specify how the document should be displayed when opened. In RadPdfViewer, you can obtain the information about the document visualization using the `PageMode` property of the `RadFixedDocument`. It is of type `PageMode` and supports two values. The enum controls if any of the tabs in the havigation pane should be selected (opened) by default when the document contains bookmarks.

The two available options for the PageMode property are as follows:

* `UseNone`&mdash;Nothing additional except the document is visible. 
* `UseBookmarks`&mdash;Document bookmarks are visible.

## Obtaining Bookmarks

You have access to the bookmarks in the document through the `Bookmarks` collection exposed by the `Document` property of RadPdfViewer. It is of the type of `BookmarksCollection` and you can use it to iterate the bookmarks and find a specific one.

__Retrieving a bookmark from the Bookmarks collection__
```C#
	BookmarkItem lastBookmarkItem = this.pdfViewer.Document.Bookmarks.LastOrDefault();
```

The Bookmarks collection contains BookmarkItem instances. Each bookmark item has information about its children via its `Children` collection, which is of the type of `BookmarksCollection`. If an inner bookmark is needed, you can traverse the `Children` collection of the parent BookmarkItem instance.

>tip If you need to modify the collection of bookmarks or a particular bookmark, you can use the [API exposed by PdfProcessing](https://docs.telerik.com/devtools/document-processing/libraries/radpdfprocessing/features/bookmarks).

## Bookmarks-Specific Commands

The commands related to bookmarks are exposed in the `CommandDescriptors` property of RadPdfViewer. You can invoke them to execute a functionality of the bookmarks.

The following commands exposed by the CommandsDescriptors collection are intended for the bookmarks:

* `ActivateBookmarkItemCommand`&mdash;This command represents the bookmark activated action (usually a user click event). When executed, RadPdfViewer displays the related Bookmark destination or executes the provided action. The command accepts a parameter of type `BookmarkItem`.
* `SyncCurrentBookmarkItemCommand`&mdash;This command synchronizes the current location in the document with the related bookmark item. It can be invoked through the UI using the __Find Current Bookmark__ button.

__Invoking the ActivateBookmarkItemCommand command in code__
```C#
	this.pdfViewer.CommandDescriptors.ActivateBookmarkItemCommandDescriptor.Command.Execute(lastBookmarkItem);
```

__Invoking the SyncCurrentBookmarkItemCommand command in code__
```C#
	this.pdfViewer.CommandDescriptors.SyncCurrentBookmarkItemCommandDescriptor.Command.Execute(null);
```

## See Also
* [Showing a File]({%slug radpdfviewer-showing-a-file%})
* [Wiring UI]({%slug radpdfviewer-wiring-ui%})
* [Digital Signature]({%slug radpdfviewer-features-digital-signature%})