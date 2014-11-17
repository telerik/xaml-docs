---
title: Styling the Column Editor
page_title: Styling the Column Editor
description: Styling the Column Editor
slug: radgridview-styling-column-editor
tags: styling,the,column,editor
published: True
position: 16
---

# Styling the Column Editor

Each of the columns that derive from the __GridViewBoundColumnBase__ have an __EditorStyle__ property. It is used to apply an appropriate __Style__ to the column editor. While creating this __Style__ keep in mind what is the type of the editor and what properties does it have. Here is a list of the column types and the types of their editors.


<table> <tr><td><b>Column Type</b></td><td><b>Editor Type</b></td></tr><tr><td>GridViewDataColumn</td><td>TextBox</td></tr><tr><td>GridViewComboBoxColumn</td><td>RadComboBox</td></tr><tr><td>GridViewImageColumn</td><td>Not Editable</td></tr><tr><td>GridViewSelectColumn</td><td>Not Editable</td></tr><tr><td>GridViewHyperlinkColumn</td><td>Not Editable</td></tr><tr><td>GridViewDynamicHyperlinkColumn</td><td>Not Editable</td></tr><tr><td>GridViewToggleRowDetailsColumn</td><td>Not Editable</td></tr></table>

For example, if you want to set the style for the __GridViewDataColumn's__ editor, you have to create a __Style__ that targets the __TextBox__ control.

#### __XAML__

{{region radgridview-styling-column-editor_0}}

	<Style x:Key="TextBoxStyle"
	       TargetType="TextBox">
	    ...
	</Style>
{{endregion}}


