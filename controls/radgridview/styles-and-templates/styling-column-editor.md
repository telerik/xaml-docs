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

Each of the columns that derive from the __GridViewBoundColumnBase__ have an __EditorStyle__ property. It is used to apply an appropriate __Style__ to the column editor. While creating this __Style__ keep in mind what is the type of the editor and what properties does it have. Here is a list of the column types and the types of their editors.


<table> <tr><td><b>Column Type</b></td><td><b>Editor Type</b></td></tr><tr><td>GridViewDataColumn</td><td>TextBox</td></tr><tr><td>GridViewComboBoxColumn</td><td>RadComboBox</td></tr><tr><td>GridViewImageColumn</td><td>Not Editable</td></tr><tr><td>GridViewSelectColumn</td><td>Not Editable</td></tr><tr><td>GridViewHyperlinkColumn</td><td>Not Editable</td></tr><tr><td>GridViewDynamicHyperlinkColumn</td><td>Not Editable</td></tr><tr><td>GridViewToggleRowDetailsColumn</td><td>Not Editable</td></tr></table>

For example, if you want to set the style for the __GridViewDataColumn's__ editor, you have to create a __Style__ that targets the __TextBox__ control.

#### __[XAML] Change the style of the GridViewDataColumn editor__

{{region radgridview-styling-column-editor_0}}

	<Style x:Key="TextBoxStyle"
	       TargetType="TextBox">
	    ...
	</Style>
{{endregion}}

> If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you need to base the style on TextBoxStyle in order to keep the default view of the editor.

#### __[XAML] Change the style of the GridViewDataColumn editor - Using Implicit Styles__

	<Style x:Key="TextBoxStyle"
           BasedOn={StaticResource TextBoxStyle} 
	       TargetType="TextBox">
	    ...
	</Style>



