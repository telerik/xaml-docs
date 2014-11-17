---
title: Styling a Merged Cell
page_title: Styling a Merged Cell
description: Styling a Merged Cell
slug: gridview-styling-mergedcell
tags: styling,a,merged,cell
published: True
position: 5
site_name: WPF
---

# Styling a Merged Cell


>tipTo learn more on how to style the UI elements read the common topic on [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}). You can also check the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) topic.
        

>tipBefore reading this topic, you might find useful to get familiar with the [Template Structure of the GridViewMergedCell]({%slug radgridview-styles-and-templates-templates-structure%}).
        
Merged Cells can be styled by creating an appropriate style targeting the __GridViewMergedCell__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>The __GridViewMergedCell__ is located in the __Telerik.Windows.Controls.GridView__ namespace of the __Telerik.Windows.Controls.GridView__ assembly.
          

>__GridViewMergedCell uses Triggers__, not VisualStateManager's states to apply property values based on specified conditions.
          

>tipIf you choose to define the style in the resources of the application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.
          

You can apply a style to the merged cells, similar to:

#### __XAML__

{{region gridview-merged-cells_1}}

	<Style TargetType="telerik:GridViewMergedCell" BasedOn="{StaticResource GridViewMergedCellStyle}">
		<Setter Property="VerticalContentAlignment" Value="Top"/>
		<Setter Property="HorizontalContentAlignment" Value="Center"/>
		<Setter Property="Background" Value="#ffcc00"/>
	</Style>
{{endregion}}

Figure 1: Styled merged cells

![gridview merged cells 5](images/gridview_merged_cells_5.png)

# See Also

 * [Styling a Cell]({%slug gridview-styling-cell%})

 * [Styling the GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})
