---
title: UpdateSourceTrigger Property is Ignored
page_title: UpdateSourceTrigger Property is Ignored
description: Read this article about Telerik's {{ site.framework_name }} DataGrid to learn what to do when the UpdateSourceTrigger property of the column's DataMemberBinding is ignored.
slug: gridview-troubleshooting-updatesourcetrigger-ignored
tags: the,updatesourcetrigger,property,is,ignored
published: True
position: 17
---

# UpdateSourceTrigger Property is Ignored

__PROBLEM__

The __UpdateSourceTrigger__ property of the column's DataMemberBinding is ignored.
        
__CAUSE__

The reason for this behaviour is that the RadGridView overrides and changes the __"Binding.UpdateSourceTrigger"__ property to be __"Explicit"__. This is a design choice to improve performance, since otherwise validation and commit operations would happen on every key stroke.
        
__SOLUTION__

You can overcome that by using the __CellEditTemplate__ property of the column and setting the __UpdateSourceTrigger__ of the binding applied to the element in edit mode (for example the editing element for GridViewDataColumn is a TextBox). This approach is demonstrated in __Example 1__.

__Example 1: Setting the UpdateSourceTrigger of a binding to a Property of the element in the CellEditTemplate__

```XAML
	<!-- In this example we have a column bound to the Name property of our model-->
    <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}">
        <telerik:GridViewDataColumn.CellEditTemplate>
            <DataTemplate>
                <TextBox Text="{Binding Name, UpdateSourceTrigger=PropertyChanged}" />
            </DataTemplate>
        </telerik:GridViewDataColumn.CellEditTemplate>
    </telerik:GridViewDataColumn>
```
     
## See Also

* [Setting CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})

* [Create Custom Column Editor]({%slug gridview-how-to-create-custom-column-editor%})
