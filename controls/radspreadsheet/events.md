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

* [RadSpreadsheet Events](#radspreadsheet-events)
* [Workbook Events](#workbook-events)
* [Worksheet Events](#worksheet-events)
* [RadWorksheetEditor Events](#radworksheeteditor-events)
* [Cells Events](#cells-events)
* [Row/Column Events](#rowcolumn-events)

## RadSpreadsheet Events

* `ActiveSheetChanged`&mdash;Occurs when the active sheet is changed.

* `ActiveSheetEditorChanged`&mdash;Occurs when the active sheet editor is changed.

* `MessageShowing`&mdash;Occurs when the user is presented with a warning message. The event arguments are of type `MessageShowingEventArgs` and expose the following properties:
	* `IsHandled`&mdash;Gets or sets whether the event is handled.
	* `Header`&mdash;Gets or sets the header of the message.
	* `Content`&mdash;Gets or sets the content of the message.
	* `NotificationType`&mdash;Gets or sets the type of the notification. The property is of type [MessageBoxNotificationType](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.spreadsheet.dialogs.messageboxnotificationtype).

	#### **[C#] Disable messages related to protection using the MessageShowing event**
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

	#### **[VB.NET] Disable messages related to protection using the MessageShowing event**
	{{region radspreadsheet-events_1}}
	    Public Sub AttachToMessageShowingEvent()
	        AddHandler Me.radSpreadsheet.MessageShowing, AddressOf radSpreadsheet_MessageShowing
	    End Sub
	
	    Private Sub radSpreadsheet_MessageShowing(sender As Object, e As Telerik.Windows.Controls.Spreadsheet.MessageShowingEventArgs)
	        If e.NotificationType = Telerik.Windows.Controls.Spreadsheet.Dialogs.MessageBoxNotificationType.ProtectedWorksheetError Then
	            e.IsHandled = True
	        End If
	    End Sub
	{{endregion}} 

* `WorkbookCommandError`&mdash;Notifies that an error occurred while executing a command in RadSpreadsheet. The arguments are of type `CommandErrorEventArgs` and you can use the `Exception` property to check what exactly the error is.

* `WorkbookChanging`&mdash;Occurs when the workbook starts changing.

* `WorkbookChanged`&mdash;Occurs when the workbook is changed.

* `WorkbookCommandExecuting`&mdash;Occurs when workbook command starts executing. The arguments are of type [CommandExecutingEventArgs](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.spreadsheet.commands.commandexecutingeventargs) and allow you to cancel the execution of the command.  

	#### **[C#] Cancel a command through WorkbookCommandExecuting**  	
	{{region radspreadsheet-events_2}}	
		private void radSpreadsheet_WorkbookCommandExecuting(object sender, Telerik.Windows.Documents.Spreadsheet.Commands.CommandExecutingEventArgs e)
		{
		    if (e.CommandName == "AddShapeCommand")
		    {
		        e.Cancel();
		    }
		}
	{{endregion}}

	#### **[VB.NET] Cancel a command through WorkbookCommandExecuting**  	
	{{region radspreadsheet-events_3}}	
	    Public Sub AttachToWorkbookCommandExecutingEvent()
	        AddHandler Me.radSpreadsheet.WorkbookCommandExecuting, AddressOf radSpreadsheet_WorkbookCommandExecuting
	    End Sub
	
	    Private Sub radSpreadsheet_WorkbookCommandExecuting(sender As Object, e As Telerik.Windows.Documents.Spreadsheet.Commands.CommandExecutingEventArgs)
	        If e.CommandName = "AddShapeCommand" Then
	            e.Cancel()
	        End If
	    End Sub
	{{endregion}}
	
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

	#### **[C#] Using the HyperlinkClicked to implement extra confirmation for the links in the document**
	{{region radspreadsheet-events_4}}
		private void RadSpreadsheet_ActiveSheetEditorChanged(object sender, EventArgs e)
		{ 
			RadWorksheetEditor editor = (RadWorksheetEditor)this.radSpreadsheet.ActiveSheetEditor; 
			editor.HyperlinkClicked += this.Editor_HyperlinkClicked;		 
		} 
		
		private void Editor_HyperlinkClicked(object sender, Telerik.Windows.Controls.Spreadsheet.Worksheets.MouseHandlers.HyperlinkClickedEventArgs e)
		{
			if (e.Url.EndsWith("exe"))
			{
				e.Handled = true;
				MessageBoxResult Result = MessageBox.Show("You are about to open an executable file. Do you want to proceed?", "Possible unsafe link", MessageBoxButton.YesNo, MessageBoxImage.Question);

				if (Result == MessageBoxResult.Yes)
				{
					Process.Start(new ProcessStartInfo()
					{
						FileName = e.Url,
						UseShellExecute = true
					});
				}
			}
		}
	{{endregion}}

 	The `HyperlinkClickedEventArgs` exposes also the `IsTrustedUrl` property, which can be set to `false` to prevent the url from openning.

>The events related to selection in RadSpreadsheet are described in the [Working with UI Selection]({%slug radspreadsheet-ui-working-with-selection%}) topic.

## Cells Events

* `CellPropertyChanged`&mdash;Occurs when a property of a cell is changed. The event arguments are of type **CellPropertyChangedEventArgs** and expose information about the exact property that was changed as well as the affected cell range.

	#### **[C#] Using the CellPropertyChangedEvent to show a notification when the users change the fill of a cell**
	{{region radspreadsheet-events_5}}		
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

	#### **[VB.NET] Using the CellPropertyChangedEvent**
	{{region radspreadsheet-events_6}}		
	    Public Sub AttachToCellPropertyChangedEvent()
	        AddHandler Me.radSpreadsheet.ActiveWorksheet.Cells.CellPropertyChanged, AddressOf Cells_CellPropertyChanged
	    End Sub
	
	    Private Sub Cells_CellPropertyChanged(sender As Object, e As CellPropertyChangedEventArgs)
	        If e.Property = CellPropertyDefinitions.FillProperty Then
	            MessageBox.Show("The fill of a cell was changed!")
	        End If
	    End Sub
	{{endregion}}

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
