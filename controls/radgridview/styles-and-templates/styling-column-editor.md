---
title: Styling Column Editor
page_title: Styling Column Editor
description: Styling Column Editor
slug: radgridview-styling-column-editor
tags: styling,column,editor
published: True
position: 16
---

# Styling Column Editor

Each of the columns that derive from __GridViewBoundColumnBase__ have an __EditorStyle__ property that is used to apply an appropriate __Style__ to the column's editor. While creating this style, keep in mind the type of the editor and its properties. Here is a list of some column types and the types of their editors.

| Column Type 						| Editor Type 	|
|-----------------------------------|---------------|
| GridViewDataColumn 				| TextBox 		|
| GridViewComboBoxColumn 			| RadComboBox 	|
| GridViewImageColumn 				| Not Editable 	|
| GridViewSelectColumn 				| Not Editable 	|
| GridViewHyperlinkColumn 			| Not Editable 	|
| GridViewDynamicHyperlinkColumn 	| Not Editable 	|
| GridViewToggleRowDetailsColumn 	| Not Editable 	|

For example, if you want to set the style for the __GridViewDataColumn__'s editor, you have to create a __Style__ that targets the __TextBox__ control.

>To learn how to modify the default styles of a control, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

#### __[XAML] Example 1: Styling all text boxes of an application__

	{{region radgridview-styling-column-editor_0}}
	<Style x:Key="TextBoxStyle" TargetType="TextBox">
	    <Setter Property="Background" Value="Red"/>
		<Setter Property="Foreground" Value="Yellow"/>
		<Setter Property="Padding" Value="2"/>
	</Style>
	{{endregion}}

>If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you need to base the style on __TextBoxStyle__.

#### __[XAML] Example 2: Setting a column's EditorStyle__

	{{region radgridview-styling-column-editor_1}}
	<telerik:GridViewDataColumn EditorStyle="{StaticResource TextBoxStyle}" />
	{{endregion}}

#### __Figure 1: RadGridView with styled column edtior__

![RadGridView with styled footer cells](images/gridview-styled-column-edtior.png)

## See Also

 * [Styling GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})
