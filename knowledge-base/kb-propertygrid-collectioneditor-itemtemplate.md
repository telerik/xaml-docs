---
title: Set Generic ItemTemplate Property of CollectionEditorPicker 
description: Set in generic way the ItemTemplate property for all CollectionEditorPicker editors.
type: how-to
page_title: How to Make a Generic Template to Display the Items in a CollectionEditorPicker
slug: kb-propertygrid-collectioneditor-itemtemplate
position: 0
tags: collectioneditor, propertygrid, itemtemplate
ticketid: 1532791
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadPropertyGrid for WPF</td>
	</tr>
</table>


## Description

How to set a generic ItemTemplate property for all CollectionEditorPicker controls inside your RadPropertyGrid.

## Solution

First, we can create a custom attached property which will be set to the __CollectionEditorPicker__ control. Inside the property changed method, we can subscribe to the Loaded event of the control and sets its ItemTemplate property.

__Example 1: Create Models__
```C#
	public class MyCollectionEditorPickerBehavior
	{
		public static bool GetIsEnabled(DependencyObject obj)
		{
			return (bool)obj.GetValue(IsEnabledProperty);
		}

		public static void SetIsEnabled(DependencyObject obj, bool value)
		{
			obj.SetValue(IsEnabledProperty, value);
		}

		public static readonly DependencyProperty IsEnabledProperty =
			DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(MyCollectionEditorPickerBehavior), new PropertyMetadata(false, OnIsEnabledChanged));

		private static void OnIsEnabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var collectionEditor = d as CollectionEditorPicker;
			collectionEditor.Loaded += (s, a) =>
			{
				var window = collectionEditor.ParentOfType<Window>();
				collectionEditor.CollectionEditor.ItemTemplate = window.Resources["ItemTemplate"] as DataTemplate;
			};
			}
	}
``` 

The next step is to set the attached property to the CollectionEditorPicker. To do that we can subscribe to the __AutoGeneratingPropertyDefinition__ event of the RadPropertyGrid. In its event handler, we can [create DataTemplate]({%slug using-datatemplate-in-code%}) in code and assign it to the __e.PropertyDefinition.EditorTemplate__ from the event arguments. The DataTemplate will include CollectionEditorPicker with the mentioned above custom attached property.


__Example 2:__
```C#		
	private void RadPropertyGrid_AutoGeneratingPropertyDefinition(object sender, Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs e)
	{
			// Your custom collection properties
		if (e.PropertyDefinition.DisplayName == "Players" && e.PropertyDefinition.DisplayName == "Coaches")
		{
			e.PropertyDefinition.Binding = new Binding("Name");
				
			var dataTemplateString = @"<DataTemplate>" +
			@"<telerik:CollectionEditorPicker local:MyCollectionEditorPickerBehavior.IsEnabled=""True"" Source=""{Binding " + e.PropertyDefinition.DisplayName + @"}"" Header=""" + e.PropertyDefinition.DisplayName + @""" Grid.Row=""1"" />" +
			@"</DataTemplate>";

			ParserContext parserContext = new ParserContext();

			parserContext.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
			parserContext.XmlnsDictionary.Add("telerik", "http://schemas.telerik.com/2008/xaml/presentation");
			parserContext.XmlnsDictionary.Add("local", "clr-namespace:StringListEditor;assembly=StringListEditor");

			DataTemplate template = (DataTemplate)XamlReader.Parse(dataTemplateString, parserContext)

			e.PropertyDefinition.EditorTemplate = template;
		}
	}
``` 
 

## See Also

* [CollectionEditors]({%slug radpropertygrid-collectioneditor%})
