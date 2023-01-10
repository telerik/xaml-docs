---
title: In Code Behind
page_title: In Code Behind
description: This article demonstrates how to populate the RadListBox with items in code. 
slug: radlistbox-populating-with-data-in-code-behind
tags: in,code,behind
published: True
position: 2
---

# {{ site.framework_name }} RadListBox In Code Behind

This tutorial will walk you through the common tasks of adding and removing __RadListBoxItems__ programmatically.	

#### __[XAML] Example 1: RadListBox without Items__

{{region xaml-radlistbox-populating-with-data-in-code-behind_0}}
	<telerik:RadListBox x:Name="radListBox" Width="200">			
	</telerik:RadListBox>
{{endregion}}

## Adding RadListBoxItems

In order to add items to a __RadListBox__, you can create new __RadListBoxItems__ and add them to the __Items__ collection of the control.

#### __[C#] Example 2: Populating RadListBox with items from code-behind__

{{region cs-radlistbox-populating-with-data-in-code-behind_1}}
	public MainWindow()
	{
		InitializeComponent();

		var item1 = new RadListBoxItem() { Content = "Australia" };
		radListBox.Items.Add(item1);
		var item2 = new RadListBoxItem() { Content = "Brazil" };
		radListBox.Items.Add(item2);
	}
{{endregion}}

#### __Figure 1: RadListBox populated in code__
![radlistbox populatingwithdata incodebehind](images/radlistbox_populatingwithdata_incodebehind.png)

## Removing RadListBoxItems

In order to remove a specific __RadListBoxItem__, you should remove it from the __RadListBox__'s __Items__ collection.

#### __[C#] Example 3: Removing RadListBoxItems__
{{region cs-radlistbox-populating-with-data-in-code-behind_2}}
	private void RemoveFirstItem()
	{
	    this.radListBox.Items.Remove(this.radListBox.Items[0]);
	}
{{endregion}}

## See Also

* [Getting Started]({%slug radlistbox-getting-started%})