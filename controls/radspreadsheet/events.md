---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadSpreadsheet {{ site.framework_name }} control.
slug: radspreadsheet-events
tags: events
published: True
position: 4
---

# Events

This topic describes the events you can use in RadSpreadsheet so you can get a notification about different actions.

## RadSpreadsheet Events

* `ActiveSheetChanged`&mdash;Occurs when the active sheet is changed.

* `ActiveSheetEditorChanged`&mdash;Occurs when the active sheet editor is changed.

* `MessageShowing`&mdash;Occurs when the user is presented with a warning message. The event arguments are of type `MessageShowingEventArgs` and expose the following properties:
	* `IsHandled`&mdash;Gets or sets whether the event is handled.
	* `Header`&mdash;Gets or sets the header of the message.
	* `Content`&mdash;Gets or sets the content of the message.
	* `NotificationType`&mdash;Gets or sets the type of the notification. The property is of type [MessageBoxNotificationType](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.spreadsheet.dialogs.messageboxnotificationtype).

	**Disable messages related to protection using the MessageShowing event**
	
	<snippet id='radspreadsheet-events-block_1-cs' />
	<snippet id='radspreadsheet-events-block_2-vb' />

* `WorkbookCommandError`&mdash;Notifies that an error occurred while executing a command in RadSpreadsheet. The arguments are of type `CommandErrorEventArgs` and you can use the `Exception` property to check what exactly the error is.

* `WorkbookChanging`&mdash;Occurs when the workbook starts changing.

* `WorkbookChanged`&mdash;Occurs when the workbook is changed.

* `WorkbookCommandExecuting`&mdash;Occurs when workbook command starts executing. The arguments are of type [CommandExecutingEventArgs](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.spreadsheet.commands.commandexecutingeventargs) and allow you to cancel the execution of the command.  

	**Cancel a command through WorkbookCommandExecuting**  	
	
	<snippet id='radspreadsheet-events-block_3-cs' />
	<snippet id='radspreadsheet-events-block_4-vb' />
	
* `WorkbookCommandExecuted`&mdash;Occurs when workbook command is executed.

* `WorkbookContentChanged`&mdash;Occurs when the content of the workbook is changed.

## Workbook Events

* `ActiveSheetChanged`&mdash;Occurs when the active sheet is changed.

* `WorkbookContentChanged`&mdash;Occurs when the workbook content is changed.

* `IsProtectedChanged`&mdash;Occurs when the current protection state has changed.

* `NameChanged`&mdash;Occurs when the name of the workbook is changed.

* `ThemeChanged`&mdash;Occurs when a theme is changed.

## Worksheet Events

* `IsProtectedChanged`&mdash;Occurs when the current protection state has changed.

* `LayoutInvalidated`&mdash;Occurs when the layout is invalidated.

* `NameChanged`&mdash;Occurs when the name of the worksheet is changed.

## RadWorksheetEditor Events

* `PreviewSheetChanging`&mdash;Occurs just before the sheet changing begins.

* `SheetChanging`&mdash;Occurs when the sheet is changing.

* `PreviewSheetChanged`&mdash;Occurs just before the sheet changing ends.

* `SheetChanged`&mdash;Occurs when the sheet is already changed.

* `ScaleFactorChanged`&mdash;Occurs when the scale factor is changed.

* `UICommandExecuting`&mdash;Occurs when a UI command is executing. Using the event arguments, you can obtain the command that is going to be executed with its parameters.

* `UICommandExecuted`&mdash;Occurs when the UI command is executed. Using the event arguments, you can obtain the command that was executed with its parameters.

* `UICommandError`&mdash;Occurs on UI command error. The event args expose the Exception property, which can help you get the error that was thrown.

* `ScrollModeChanged`&mdash;Occurs when the scroll mode is changed.

* `ActivePresenterChanged`&mdash;Occurs when the active presenter is changed.

* `HyperlinkClicked`&mdash;Occurs when a hyperlink in the document gets clicked. The event allows you to cancel or replace the navigation logic. 

	__Using the HyperlinkClicked to implement extra confirmation for the links in the document__
	
	<snippet id='radspreadsheet-events-block_5-cs' />

 	The `HyperlinkClickedEventArgs` exposes also the `IsTrustedUrl` property, which can be set to `false` to prevent the url from openning.
	
	The cell clicked to open the hyperlink can be accessed with the `CellIndex` property of `HyperlinkClickedEventArgs`.
	
	__Accessing the CellIndex of the clicked cell__
	<snippet id='radspreadsheet-events-block_6-cs' />
	<snippet id='radspreadsheet-events-block_7-vb' />

* `CellRangeInsertedOrRemoved`&mdash;Occurs when a cell range is inserted or removed. Through the arguments, you can obtain information about the affected ranges, as well as whether the range is removed or not.

* `MergedCellsChanged`&mdash;Occurs when the merged cells collection in a worksheet is changed. The MergedCellRangesChangedEventArgs class represents the event arguments and holds the cell range related to the change.

## Row/Column Events

* `ColumnsWidthChanged`&mdash;Occurs when the columns' widths are changed.

* `RowsHeightsChanged`&mdash;Occurs when the rows' heights are changed.

The arguments of the two events are of type `RowColumnPropertyChangedEventArgs` and expose the following properties:

* `Property`&mdash;Gets the property that was changed.
* `FromIndex`&mdash;Gets the first index of the changed range.
* `ToIndex`&mdash;Gets the last index of the changed range.

## See Also  
* [Model]({%slug radspreadsheet-model%})