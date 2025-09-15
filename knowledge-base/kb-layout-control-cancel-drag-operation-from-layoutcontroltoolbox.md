---
title: How to Cancel Drop Operation from LayoutControlToolBox to LayoutControl
description: This article explains how to disallow the dropping of a particular item from the LayoutControlToolBox to the RadLayoutControl.
type: how-to
page_title: Disallow Dropping of an Item from the LayoutControlToolBox
slug: kb-layout-control-cancel-drag-operation-from-layoutcontroltoolbox
position: 0
tags: layoutcontrol, cancel, drag, operation, from, layoutcontroltoolbox
ticketid: 1459654
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadLayoutControl for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to cancel the drop operation from the [LayoutControlToolBox]({%slug radlayoutcontrol-features-toolbox-layoutcontroltoolbox%}) to the **RadLayoutControl**. 

## Solution

To disallow the drop of a particular item from the toolbox to the RadLayoutControl you need to **handle** the drag and drop events of the [DragDropManager]({%slug dragdropmanager-getting-started%}) and more specifically, the **DragOver** event.

The example below shows how to cancel the drop of a **LayoutControlExpanderGroup** but this can also be modified to work for any element.



```C#
    public MainWindow()
    {
        InitializeComponent();
        DragDropManager.AddDragOverHandler(this.layout, OnLayoutControlDragOver, false);
    }

    private void OnLayoutControlDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
    {
        var proxy = (LayoutControlHierarchicalNodeProxy)DragDropPayloadManager.GetDataFromObject(e.Data, "Telerik.Windows.Controls.LayoutControl.LayoutControlHierarchicalNodeProxy");

        if (proxy.OriginalItem is LayoutControlExpanderGroup)
        {
            e.Effects = DragDropEffects.None;
            e.Handled = true;
        }
    }
```

## See Also
* [DragDropManager]({%slug dragdropmanager-getting-started%})
* [LayoutControlToolBox]({%slug radlayoutcontrol-features-toolbox-layoutcontroltoolbox%})
