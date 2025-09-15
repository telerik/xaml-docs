---
title: Enable touch events for custom elements
page_title:  Enable Touch Events for Custom Elements
description: Check out our example of enabling touch event for a button within a column cell template within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-enable-touch-events-celltemplate
tags: touch, event, cell-templates
published: True
position: 18
---

# How To Enable Touch Events for Custom Elements

In a scenario where you have explicitly set the cell template of a column within **RadGridView** and you would like that element to handle a touch event separately, you should set the **TouchManager.TouchMode** attached property to **None**. Otherwise, all touch events would be handled by the **RadGridView** control. 

**Example 1** shows how to achieve the requirement for a Button element within a column's CellTemplate.

#### **[XAML] Example 1: Enable touch event for a button within a column cell template**
```XAML
		<telerik:GridViewColumn>
                    <telerik:GridViewColumn.CellTemplate>
                        <DataTemplate>
                            <Button Name="Button1"
                                    Content="Do Some Action" 
                                    Command="{Binding CustomCommand}"
                                    Margin="5"
                                    telerik:TouchManager.TouchMode="None"
                                    HorizontalAlignment="Left"/>
                        </DataTemplate>
                    </telerik:GridViewColumn.CellTemplate>
                </telerik:GridViewColumn>
```

The attached property should be set in case of explicitly defining the element through a **custom column** as well. **Example 2** shows how to set the attached property programmatically:
	
#### **[C#] Example 2: Programmatically set TouchManager.TouchMode attached property**
```C#
	var someButton = new Button();
	TouchManager.SetTouchMode(someButton, TouchMode.None);
```

## See Also
* [RadGridView - CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})
* [TouchManager - Overview]({%slug touchmanager-overview%})
* [TouchManager - Touch Modes]({%slug touchmanager-touch-modes%})
