---
title: Close RadPane Instances
page_title: Close RadPane Instances
description: Close RadPane Instances
slug: raddocking-how-to-close-panes
tags: how,to,close,panes
published: True
position: 6
---

## Close RadPane Instances

Each __RadPane__ is closable by default via the **Close** button or the **Hide** menu item shown on the snapshots above.
        
You can also hide/show your __RadPane__ instances programmatically using the boolean __RadPane__'s property __IsHidden.__ When a __RadPane__ is closed it is actually hidden and you can always make it visible again when needed.

>When you set the **IsHidden** property of a **RadPane** to **True** or close it, it is actually removed from the visual tree.
        
#### __[XAML] Example 1: Set IsHidden__

{{region xaml-raddocking-panes-radpane_3}}
	<telerik:RadPane x:Name="radPane" IsHidden="True"/>
{{endregion}}

#### __[C#] Example 1: Set IsHidden__

{{region cs-raddocking-panes-radpane_4}}
	radPane.IsHidden = true;
{{endregion}}

#### __[VB.NET] Example 1: Set IsHidden__

{{region vb-raddocking-panes-radpane_5}}
	radPane1.IsHidden = True
{{endregion}}

To learn how to disable the close button or how to handle the __RadDocking__'s __PreviewClose__ event take a look at the [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%}) topic.

## See Also

 * [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%})
 * [How to Implement Conditional Docking]({%slug raddocking-how-to-implement-conditional-docking%})