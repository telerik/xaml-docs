---
title: Propertygrid's collection editor name property not updating
description: RadCollectionEditor name doesn't change at runtime when used in RadPropertyGrid.
page_title: Data binding collection editor name field to a property from view model
type: troubleshooting
slug: kb-propertygrid-editor-name-not-updating
position: 0
tags: 
ticketid: 1398060
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

How to data bind a property from the model of the collection shown in the collection editor to the left side names of the editor opened when a collection property is selected.

## Solution

1. Define a DataTemplate containing a TextBlock bound to a property from the model of the items in the collection.
	
	```XAML
		<Window.Resources>
			<DataTemplate x:Key="CollectionEditorTemplate">
				<TextBlock Text="{Binding Name}" />
			</DataTemplate>
		</Window.Resources>
	```
	
2. Subscribe to the FieldLoaded event of RadPropertyGrid and set the ItemTemplate of the loaded editor. Do this only if the editor is an element of type CollectionEditorPicker.
	
	```C#
		private void radPropertyGrid_FieldLoaded(object sender, FieldEventArgs e)
		{
			var collectionEditorPicker = e.Field.Content as CollectionEditorPicker;
			if (collectionEditorPicker != null)
			{
				Dispatcher.BeginInvoke(new Action(() => {
					var editor = collectionEditorPicker.CollectionEditor;
					editor.ItemTemplate = (DataTemplate)this.Resources["CollectionEditorTemplate"];
				}));
			}           
		}
	```