---
title: Styling the GridViewEditorPresenter
page_title: Styling the GridViewEditorPresenter
description: Styling the GridViewEditorPresenter
slug: gridview-styling-editorpresenter
tags: styling,the,gridvieweditorpresenter
published: True
position: 6
---

# Styling the GridViewEditorPresenter

>tipBefore reading this topic, you might find useful to get familiar with the [basic overview]({%slug gridview-stylines-and-templates-overview%}) on styling the visual appearance of the __RadGridView__and its elements.
        
If you want to change the appearance of a cell when it enters edit mode you should predefine the template of __GridViewEditorPresenter__. This element is a plain presenter used to display the editors for the cells.
        

Here is an example of how the template of the GridViewEditorPresent looks like:
        

#### __XAML__

{{region gridview-styling-editorpresenter_1}}

	<Grid> 
		<ContentPresenter Margin="{TemplateBinding Padding}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}" />
	  <Border x:Name="ValidationErrorElement" Visibility="Collapsed" CornerRadius="1" BorderBrush="{StaticResource ControlOuterBorder_Invalid}" BorderThickness="1" Margin="1 1 1 2">
	</Grid>
{{endregion}}

>The __GridViewEditorPresenter__ element is located in the __Telerik.Windows.Controls.GridView__ namespace of the __Telerik.Windows.Controls.GridView__ assembly.
            
When working in Expression Blend, the namespaces that are needed will be added automatically.

If you would like to change the appearance of the editor itself, then you can create a simple style targeted at the corresponding editor.

For example for GridViewDataColumn bound to a text property, the default editor will be a TextBox. To change the appearance in edit mode, you should define styles for the standard TextBox control as its default editor and this presenter. Then you can set the editor style (for ex. targeting the TextBox element) through setting the EditorStyle property of a column.
        
# See Also

 * [Overview]({%slug gridview-stylines-and-templates-overview%})

 * [Styling a Cell]({%slug gridview-styling-cell%})
