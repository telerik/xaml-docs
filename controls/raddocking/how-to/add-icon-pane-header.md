---
title: How to Add Icon to the RadPane's Header
page_title: How to Add Icon to the RadPane's Header
description: Check our &quot;How to Add Icon to the RadPane's Header&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-add-icon-pane-header
tags: how,to,add,icon,to,the,radpane's,header
published: True
position: 5
---

# How to Add Icon to the RadPane's Header

The purpose of this tutorial is to show you how to add an icon to the __RadPane's__ __Header__.

For the purpose of this tutorial the following __RadDocking__ declaration will be used:



<snippet id='raddocking-how-to-add-icon-pane-header-block_1-xaml' />


![{{ site.framework_name }} RadDocking Sample Declaration](images/RadDocking_HowTo_AddPaneHeaderIcon_010.png)

In order to add an icon to the __RadPane's__ header, you should create a custom data template and set it to the __HeaderTemplate__ property of the __RadPane__. Consider the following example.



<snippet id='raddocking-how-to-add-icon-pane-header-block_2-xaml' />


Set the created data template to the __HeaderTemplate__ property of the __RadPane__.



<snippet id='raddocking-how-to-add-icon-pane-header-block_3-xaml' />


Here is the final result:

![{{ site.framework_name }} RadDocking with Pane Header Icons](images/RadDocking_HowTo_AddPaneHeaderIcon_020.png)

## See Also

 * [How to Freeze the Layout]({%slug raddocking-how-to-freeze-the-layout%})

 * [RadPane]({%slug raddocking-panes-radpane%})

 * [Save/Load Layout]({%slug raddocking-features-save-load-layout-overview%})
