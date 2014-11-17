---
title: In Code Behind
page_title: In Code Behind
description: In Code Behind
slug: radlistbox-populating-with-data-in-code-behind
tags: in,code,behind
published: True
position: 2
---

# In Code Behind

This tutorial will walk you through the common tasks of adding and removing __RadListBoxItems__ programmatically.		

Here is a regular __RadListBox__ declaration without items:

#### __XAML__

{{region radlistbox-populating-with-data-in-code-behind_0}}
	<telerik:RadListBox x:Name="radListBox" Width="200">			
	</telerik:RadListBox>
{{endregion}}

## Adding RadListBoxItems

In order to add new listbox items to a __RadListBox__ control, you have to perform several simple steps:		

* Create an instance of the RadListBoxItem class.

* Set its properties such as Content, Foreground, etc.

* Add it to the RadListBox's Items collection.

#### __C#__

{{region radlistbox-populating-with-data-in-code-behind_1}}
	var item1 = new RadListBoxItem() { Content = "Australia" };
	radListBox.Items.Add(item1);
	
	var item2 = new RadListBoxItem() { Content = "Brazil" };
	radListBox.Items.Add(item2);
{{endregion}}

The result is shown on the image below:

![radlistbox populatingwithdata incodebehind](images/radlistbox_populatingwithdata_incodebehind.png)

## Removing RadListBoxItems

In order to remove a specific __RadListBoxItem__, you should remove it from the __RadListBox__'s __Items__ collection.

#### __C#__

{{region radlistbox-populating-with-data-in-code-behind_2}}
	private void RemoveListBoxItem(RadListBoxItem itemToRemove)
	{
		this.radListBox.Items.Remove(itemToRemove);
	}
{{endregion}}