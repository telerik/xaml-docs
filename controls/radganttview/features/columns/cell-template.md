---
title: Customizing the CellTemplate
page_title: Customizing the CellTemplate
description: Check our &quot;Customizing the CellTemplate&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-columns-cell-template
tags: customizing,the,celltemplate
published: True
position: 1
---

# Customizing the CellTemplate

The __CellTemplate__ is the Template that is displayed in the cell of each roll. It could easily be customized by setting it to any valid DataTemplate.

>It is important to note that when customizing the CellTemplate of a ColumnDefinition there could be some performance loses if the new CellTemplate contains heavy controls. This is because the Template is rendered for each cell when the control is loading. Also note that the CellTemplate influences the size of the row.

The next example demonstrates how to customize the CellTemplate of the Title columns in order to change the __FontWeight__ and __Foreground__ of the text. All that you need to do is set the Template to the wanted DataTemplate in the xaml of the control. The next code snippet shows how the GanttView control should look like:



<snippet id='radganttview-features-columns-cell-template-block_1-xaml' />


>important When creating a custom CellTemplate for a ColumnDefinition which __MemberBinding__ is set to a custom property or a property that is not the Start, End or Title properties of the GanttTask you should set the binding in the DataTemplate to the built-in __FormattedValue__ property as the above code snippet shows. This is an optimized string value that comes from the built-in virtualization of the control in order to achieve maximum performance.

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomCellTemplates).

The next screenshot shows the final result:

![radganttview-features-columns-customizing-cell-template](images/radganttview-features-columns-customizing-cell-template.png)

## See Also

 * [Overview]({%slug radganttview-features-columns-types%})

 * [Customizing the CellEditTemplate]({%slug radganttview-features-columns-editing-cells%})

 * [Customizing the CellHighlightTemplate]({%slug radganttview-features-columns-highlight-template%})

 * [Customizing the CellSelectionTemplate]({%slug radganttview-features-columns-selection-template%})
