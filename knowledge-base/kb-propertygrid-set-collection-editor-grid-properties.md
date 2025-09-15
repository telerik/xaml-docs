---
title: Set Properties on the RadPropertyGrid inside the CollectionEditor
description: How to customize the child RadPropertyGrid of the CollectionEditor.
page_title: Customize the CollectionEditor's Child RadPropertyGrid
type: how-to
slug: kb-propertygrid-set-collection-editor-grid-properties
tags: customize, set, properties, child, radpropertygrid, collectioneditor
ticketid: 1117206
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2018.2.620</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadPropertyGrid for WPF</td>
	</tr>
</table>

## Description

How to set properties on the RadPropertyGrid inside the [CollectionEditor]({%slug radpropertygrid-collectioneditor%}).

## Solution

1. Handle the **Loaded** event of the parent **RadRropertyGrid**.

	
	```C#
		private void RadPropertyGrid_Loaded(object sender, RoutedEventArgs e)
		{
			var editorPicker = rpg.ChildrenOfType<CollectionEditorPicker>().First();
			var collectionEditor = editorPicker.CollectionEditor;
			collectionEditor.Loaded += CollectionEditor_Loaded;
		}
	```
```VB.NET
		Private Sub RadPropertyGrid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim editorPicker = rpg.ChildrenOfType(Of CollectionEditorPicker)().First()
			Dim collectionEditor = editorPicker.CollectionEditor
			collectionEditor.Loaded += CollectionEditor_Loaded
		End Sub
	```
	
2. Handle the **Loaded** event of the **CollectionEditor**.

	
	```C#
		private void CollectionEditor_Loaded(object sender, RoutedEventArgs e)
		{
			var collectionEditor = sender as CollectionEditor;
			var propertyGrid = collectionEditor.ChildrenOfType<RadPropertyGrid>().First();
      			propertyGrid.LabelColumnWidth = new GridLength(50);
      			// set any other properties
		}
	```
```VB.NET
		Private Sub CollectionEditor_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim collectionEditor = TryCast(sender, CollectionEditor)
			Dim propertyGrid = collectionEditor.ChildrenOfType(Of RadPropertyGrid)().First()
	    propertyGrid.LabelColumnWidth = New GridLength(50)
	    ' set any other properties
		End Sub
	```
  
## See Also
* [CollectionEditor]({%slug radpropertygrid-collectioneditor%})
