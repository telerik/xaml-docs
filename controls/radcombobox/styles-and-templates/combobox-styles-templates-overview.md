---
title: Customizing Appearance
page_title: Customizing Appearance
description: This article points to the RadComboBox API that can be used to customize its appearance using styles and templates.
slug: combobox-styles-templates-overview
tags: textboxstyle,selectionboxtemplate
published: True
position: 0
---

# Customizing Appearance

This article points to the RadComboBox API that can be used to customize its appearance using styles and templates.

## ItemTemplate

To customize the appearance of the items when RadComboBox's ItemsSource is set, use the __ItemTemplate__ property. An example can be found in the [Binding to Collection]({%slug radcombobox-populating-with-data-binding-to-object%}) article.

Additionally, you can use the __ItemTemplateSelector__ property to implement a [DataTemplateSelector](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.datatemplateselector?view=netframework-4.8) for the items.

## Styling the TextBox Input

RadComboBox shows a text [input area]({%slug radcombobox-general-information-visual-structure%}) when in edit mode (IsEditable=True) represented by a TextBox control. The control can be customized via the __TextBoxStyle__ property of RadComboBox. Read more, in the [TextBoxStyle]({%slug radcombobox-features-textboxstyle%}) article.

## Styling the Selection Box

The [Selection Box]({%slug radcombobox-general-information-visual-structure%}) part of RadComboBox is customized via the __SelectionBoxTemplate__, __MultipleSelectionBoxTemplate__ and __EmptySelectionBoxTemplate__ properties. Read more, in the [Selection Box Template]({%slug radcombobox-populating-with-data-selectionbox%}) article.

## Customize Empty Text

When the RadComboBox control has no selected item, a text will appear. The empty text string can be changed through the __EmptyText__ and __EmptySelectionBoxTemplate__ properties of the __RadComboBox__ control. The __EmptyText__ property is of type string, and you can set a custom string. If you want to customize the empty text style further, you can use the __EmptySelectionBoxTemplate__ property by applying a custom __DataTemplate__.

__Example 1: Customize Empty Text__  
```XAML
    <Grid>
		<Grid.Resources>
			<DataTemplate x:Key="EmptyTemplate">
				<TextBlock FontWeight="Bold" FontFamily="Comic Sans" FontStyle="Italic" Text="{Binding}" />
			</DataTemplate>
		</Grid.Resources>
		<telerik:RadComboBox ItemsSource="{Binding Agency}" DisplayMemberPath="Name" 
								IsEditable="True" VerticalAlignment="Center" HorizontalAlignment="Center"
								EmptyText="Some empty text"                            
								EmptySelectionBoxTemplate="{StaticResource EmptyTemplate}">
		</telerik:RadComboBox>
	</Grid>
```

## Editing the Control Template

You can edit the control template of RadComboBox in order to achieve visualization and functionality that is not provided out of the box or via the built-in API. To do this, extract the ControlTemplate of the control and modify the elements in it. Read more about extracting templates in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.

To apply the customized ControlTemplate, use the __NonEditableTemplate__ and __EditableTemplate__ properties of RadComboBox. NonEditableTemplate is applied when the __IsEditable__ property of the control is set to False (default). EditableTemplate is applied when IsEditable is True.

>All elements in the ControlTemplate that contains "PART_" in their Name should be present in the template. Those are required elements used in code by the control. Removing the required elements will lead to missing functionality or runtime errors.

## See Also
* [Edit Modes]({%slug radcombobox-features-edit-modes%})
* [Selection]({%slug radcombobox-features-selection%})
