---
title: Events
page_title: Events
description: Events
slug: radspreadsheet-events
tags: events
published: True
position: 8
---

# Events

This topic describes the events you can use in RadSpreadsheet so you can get a notification about different actions.

* [RadSpreadsheet Events](#radspreadsheet-events)
* [Workbook Events](#workbook-events)
* [Worksheet Events](#worksheet-events)
* [RadWorksheetEditor Events](#radworksheeteditor-events)
* [Cells Events](#cells-events)
* [Row/Column Events](#rowcolumn-events)


## RadSpreadsheet Events

* **ActiveSheetChanged**: Occurs when the active sheet is changed.

* **ActiveSheetEditorChanged**: Occurs when the active sheet editor is changed.

* **MessageShowing**: Occurs when the user is presented with a warning message. The event arguments are of type **MessageShowingEventArgs** and expose the following properties:
	* **IsHandled**: Gets or sets whether the event is handled.
	* **Header**: Gets or sets the header of the message.
	* **Content**: Gets or sets the content of the message.
	* **NotificationType**: Gets or sets the type of the notification. The property is of type [MessageBoxNotificationType](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_spreadsheet_dialogs_messageboxnotificationtype.htm).

	The code from **Example 1** shows how to disable the messages appearing when the user is trying to edit a protected worksheet.

	#### **[C#] Example 1: Disable messages related to protection using the MessageShowing event**
	{{region radspreadsheet-events_0}}

		public void AttachToMessageShowingEvent()
		{
		    this.radSpreadsheet.MessageShowing += radSpreadsheet_MessageShowing;
		}
		
		private void radSpreadsheet_MessageShowing(object sender, Telerik.Windows.Controls.Spreadsheet.MessageShowingEventArgs e)
		{
		    if (e.NotificationType == Telerik.Windows.Controls.Spreadsheet.Dialogs.MessageBoxNotificationType.ProtectedWorksheetError)
		    {
		        e.IsHandled = true;
		    }
		}
	{{endregion}} 

* **WorkbookCommandError**: Notifies that an error occurred while executing a command in RadSpreadsheet. The arguments are of type **CommandErrorEventArgs** and you can use the Exception property to check what exactly the error is.

* **WorkbookChanging**: Occurs when the workbook is changing.

* **WorkbookChanged**: Occurs when the workbook is changed.

* **WorkbookCommandExecuting**: Occurs when workbook command starts executing. The arguments of the event allow you to cancel the execution of the command.  

* **WorkbookCommandExecuted**: Occurs when workbook command is executed.

* **WorkbookContentChanged**: Occurs when the content of the workbook is changed.


## Workbook Events


* **ActiveSheetChanged**: Occurs when the active sheet is changed.

* **WorkbookContentChanged**: Occurs when the workbook content is changed.

* **IsProtectedChanged**: Occurs when the current protection state has changed.

* **NameChanged**: Occurs when the name of the workbook is changed.

* **ThemeChanged**: Occurs when a theme is changed.


## Worksheet Events

* **IsProtectedChanged**: Occurs when the current protection state has changed.

* **LayoutInvalidated**: Occurs when the layout is invalidated.

* **NameChanged**: Occurs when the name of the worksheet is changed.



## RadWorksheetEditor Events


* **PreviewSheetChanging**: Occurs just before the sheet changing begins.

* **SheetChanging**: Occurs when the sheet is changing.

* **PreviewSheetChanged**: Occurs just before the sheet changing ends.

*  **SheetChanged**: Occurs when the sheet is already changed.

* **ScaleFactorChanged**: Occurs when the scale factor is changed.

* **UICommandExecuting**: Occurs when a UI command is executing. Using the event arguments, you can obtain the command that is going to be executed with its parameters.

* **UICommandExecuted**: Occurs when the UI command is executed. Using the event arguments, you can obtain the command that was executed with its parameters.

* **UICommandError**: Occurs on UI command error. The event args expose the Exception property, which can help you get the error that was thrown.

* **ScrollModeChanged**: Occurs when the scroll mode is changed.

* **ActivePresenterChanged**: Occurs when the active presenter is changed.

## Cells Events

* **CellPropertyChanged**: Occurs when a property of a cell is changed. The event arguments are of type **CellPropertyChangedEventArgs** and expose information about the exact property that was changed as well as the affected cell range.

	**Example 2** demonstrates how you can use the event to get a notification when the users change the fill of a cell.

	#### **[C#] Example 2: Using the CellPropertyChangedEvent**
	{{region radspreadsheet-events_1}}
		
		public void AttachToCellPropertyChangedEvent()
		{
		    this.radSpreadsheet.ActiveWorksheet.Cells.CellPropertyChanged += Cells_CellPropertyChanged;
		}
		
		private void Cells_CellPropertyChanged(object sender, CellPropertyChangedEventArgs e)
		{
		    if (e.Property == CellPropertyDefinitions.FillProperty)
		    {
		        MessageBox.Show("The fill of a cell was changed!");
		    }
		}
	{{endregion}}

* **CellRangeInsertedOrRemoved**: Occurs when a cell range is inserted or removed. Through the arguments, you can obtain information about the affected ranges, as well as whether the range is removed or not.

* **MergedCellsChanged**: Occurs when the merged cells collection in a worksheet is changed. The MergedCellRangesChangedEventArgs class represents the event arguments and holds the cell range related to the change.


## Row/Column Events

* **ColumnsWidthChanged**: Occurs when the columns' widths are changed.

* **RowsHeightsChanged**: Occurs when the rows' heights are changed.

The arguments of the two events are of type **RowColumnPropertyChangedEventArgs** and expose the following properties:

* **Property**: Gets the property that was changed.
* **FromIndex**: Gets the first index of the changed range.
* **ToIndex**: Gets the last index of the changed range.


## See Also

* [Model]({%slug radspreadsheet-model%})