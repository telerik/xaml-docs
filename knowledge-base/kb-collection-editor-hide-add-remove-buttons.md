---
title: Hiding Add and Remove Buttons in CollectionEditor for WPF
description: Learn how to hide the Add and Remove buttons in the CollectionEditor part of RadPropertyGrid.
type: how-to
page_title: How to Hide CollectionEditor Add New and Delete Buttons in WPF
slug: kb-collection-editor-hide-add-remove-buttons
tags: collectioneditor, wpf, collectioneditor, visibility, buttons
res_type: kb
ticketid: 1682419
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>CollectionEditor for WPF</td>
</tr>
</tbody>
</table>

## Description

How to hide the Add and Remove buttons in the CollectionEditor control (part of RadPropertyGrid).

## Solution

On `Loaded` of CollectionEditor, set use the [ChildrenOfType<T> extension method]({%slug common-visual-tree-helpers%}) to get the buttons and set their `Visibility` to `Collapsed`.

```csharp
	private void CollectionEditor_Loaded(object sender, RoutedEventArgs e)
	{
		var editor = (CollectionEditor)sender;
		var addButton = editor.ChildrenOfType<RadButton>().FirstOrDefault(x => x.Command == CollectionEditorCommands.AddNew);
		if (addButton != null)
		{
			addButton.Visibility = Visibility.Collapsed;
		}
		var removeButton = editor.ChildrenOfType<RadButton>().FirstOrDefault(x => x.Command == CollectionEditorCommands.Delete);
		if (removeButton != null)
		{
			removeButton.Visibility = Visibility.Collapsed;
		}        
	}
```
