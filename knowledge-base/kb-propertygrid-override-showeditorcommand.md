---
title: Override the ShowEditorCommand of RadPropertyGrid
page_title: Override the Show Modal Dialog Action of PropertyGrid
description: Replace the show editor action executed when the modal editor of the PropertyGrid is used.
type: how-to
slug: kb-propertygrid-override-showeditorcommand
position: 0
tags: override,command,showeditor
ticketid: 1579254
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadPropertyGrid for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to replace the show editor command, executed when the modal editor of the PropertyGrid is used. The modal editor is used when the [EditorAttribute]({%slug radpropertygrid-editor-attribute%}) is used with `EditorType` set to `Modal`.

## Solution

To replace the default action executed on modal editor button click, override the behavior of the Telerik's `ModalEditor.ShowEditorCommand`.


```C#
	static MainWindow()
	{
		CommandManager.RegisterClassCommandBinding(typeof(RadButton), new CommandBinding(ModalEditor.ShowEditorCommand, ShowEditorExecuted, CanShowEditorExecute));
	}

	private static void CanShowEditorExecute(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = true;
		e.Handled = true;
	}

	private static void ShowEditorExecuted(object sender, ExecutedRoutedEventArgs e)
	{
		var button = (RadButton)sender;
		var modalEditor = button.ParentOfType<ModalEditor>();
		if (modalEditor != null)
		{
			// here you can execute a custom action, like opening of custom dialog
			var window = new Window()
			{
				DataContext = modalEditor.DataContext,
				Content = modalEditor.Editor,
				SizeToContent = SizeToContent.WidthAndHeight,
				Owner = Application.Current.MainWindow,
				WindowStartupLocation = modalEditor.WindowStartupLocation,
				Top = modalEditor.WindowTop,
				Left = modalEditor.WindowLeft
			};
			window.ShowDialog();
		}
	}
```