---
title: Customizing the CellHighlightTemplate
page_title: Customizing the CellHighlightTemplate
description: Check our &quot;Customizing the CellHighlightTemplate&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-columns-highlight-template
tags: customizing,the,cellhighlighttemplate
published: True
position: 3
---

# Customizing the CellHighlightTemplate

The __CellHighlightTemplate__ is the Template that is displayed when you hover over the cell with the mouse pointer.

The next example will demonstrate how to customize the CellHighlightTemplate of the __Title__, __Start__ and __End__ columns in order to change the FontWeight and Foreground of the text.

The xaml of the GanttView should look like this:



```XAML
	<telerik:RadGanttView TasksSource="{Binding Tasks}"
	VerticalAlignment="Top"
	VisibleRange="{Binding VisibleTime}">
	    <telerik:RadGanttView.Columns>
	        <telerik:TreeColumnDefinition Header="Title" MemberBinding="{Binding Title}" Width="AutoHeaderAndContent">
	            <telerik:ColumnDefinition.CellHighlightTemplate>
	                <DataTemplate>
	                    <TextBlock Text="{Binding FormattedValue}" FontWeight="Bold" Foreground="Red" VerticalAlignment="Center"/>
	                </DataTemplate>
	            </telerik:ColumnDefinition.CellHighlightTemplate>
	        </telerik:TreeColumnDefinition>
	        <telerik:ColumnDefinition MemberBinding="{Binding Start}" Header="Start" Width="AutoHeaderAndContent">
	            <telerik:ColumnDefinition.CellHighlightTemplate>
	                <DataTemplate>
	                    <TextBlock Text="{Binding FormattedValue}" FontWeight="Bold" Foreground="Green" VerticalAlignment="Center"/>
	                </DataTemplate>
	            </telerik:ColumnDefinition.CellHighlightTemplate>
	        </telerik:ColumnDefinition>
	        <telerik:ColumnDefinition MemberBinding="{Binding End}" Header="End" Width="AutoHeaderAndContent">
	            <telerik:ColumnDefinition.CellHighlightTemplate>
	                <DataTemplate>
	                    <TextBlock Text="{Binding FormattedValue}" FontWeight="Bold" Foreground="Blue" VerticalAlignment="Center"/>
	                </DataTemplate>
	            </telerik:ColumnDefinition.CellHighlightTemplate>
	        </telerik:ColumnDefinition>
	    </telerik:RadGanttView.Columns>
	</telerik:RadGanttView>
```

>importantWhen creating a custom CellHighlightTemplate for a ColumnDefinition which __MemberBinding__ is set to a custom property or a property that is not the Start, End or Title properties of the GanttTask you should set the binding in the DataTemplate to the built-in __FormattedValue__ property as the above code snippet shows. This is an optimized string value that comes from the built-in virtualization of the control in order to achieve maximum performance.

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/GanttView/CustomCellTemplates).

The next screenshots show the final result:
![radganttview-features-columns-highlight-template-1](images/radganttview-features-columns-highlight-template-1.png)

![radganttview-features-columns-highlight-template-2](images/radganttview-features-columns-highlight-template-2.png)

## See Also

 * [Overview]({%slug radganttview-features-columns-types%})

 * [Customizing the CellTemplate]({%slug radganttview-features-columns-cell-template%})

 * [Customizing the CellEditTemplate]({%slug radganttview-features-columns-editing-cells%})

 * [Customizing the CellSelectionTemplate]({%slug radganttview-features-columns-selection-template%})
