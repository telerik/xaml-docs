---
title: Save Executed Event in RadSpreadsheet
description: How to subscribe to command executed of the save file command in RadSpreadsheet for WPF using the UICommandExecuted event.
type: how-to
page_title: Listen to SaveFile Command Executed in RadSpreadsheet
slug: kb-spreadsheet-savefile-command-executed-event
tags: radspreadsheet, wpf, events, workbook, beforeclose, aftersave
res_type: kb
ticketid: 1672122
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadSpreadsheet for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.3.924</td>
</tr>
</tbody>
</table>

## Description

How to listen for the save file command of RadSpreadsheet for WPF.

## Solution

To do this, you can subscribe to the `UICommandExecuted` event of the `RadWorksheetEditor` object.

#### __[C#]__
{{region kb-spreadsheet-savefile-command-executed-event-0}}
	RadWorksheetEditor editorCache = null;

	private void RadSpreadsheet_ActiveSheetEditorChanged(object? sender, EventArgs e)
	{
		var spreadsheet = (RadSpreadsheet)sender;
		if (editorCache != null)
		{
			editorCache.UICommandExecuted -= ActiveSheetEditor_UICommandExecuted;
		}
		if (spreadsheet.ActiveWorksheetEditor != null)
		{
			spreadsheet.ActiveWorksheetEditor.UICommandExecuted += ActiveSheetEditor_UICommandExecuted;
		}
		editorCache = spreadsheet.ActiveWorksheetEditor;
	}

	private void ActiveSheetEditor_UICommandExecuted(object? sender, Telerik.Windows.Controls.Spreadsheet.Commands.UICommandExecutedEventArgs e)
	{
		var editor = (RadWorksheetEditor)sender;
		if (editor.Commands.SaveFile == e.Command)
		{
		  // execute your code here
		}
	}
{{endregion}}
