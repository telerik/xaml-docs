---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radlistbox-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial will walk you through the required steps for using __RadListBox__. 



## Assembly References

In order to use __RadListBox__ in your project you have to add reference to the __Telerik.Windows.Controls__ assembly.

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadListBox__ control in code behind and XAML code:

## Adding RadListBox to the Project

#### __[XAML] Example 1: Adding RadListBox__

{{region xaml-radlistbox-getting-started_0}}
	<telerik:RadListBox x:Name="radListBox" Width="200" />
{{endregion}}

## Populating with Items

The control can either be populated by adding __RadListBoxItems__ to its __Items__ collection, or by its data binding support.

#### __[XAML] Example 2: Adding RadListBoxItems__
{{region xaml-radlistbox-getting-started_1}}
	<telerik:RadListBox  Width="200" x:Name="radListBox">
	    <telerik:RadListBoxItem Content="Australia" />
	    <telerik:RadListBoxItem Content="Brazil" />
	    <telerik:RadListBoxItem Content="Canada" />
	    <telerik:RadListBoxItem Content="China" />
	    <telerik:RadListBoxItem Content="England" />
	    <telerik:RadListBoxItem Content="Germany" />
	</telerik:RadListBox>
{{endregion}}

#### __[XAML] Example 3: Binding RadListBox

{{region xaml-radlistbox-getting-started_2}}
	<telerik:RadListBox x:Name="radListBox" Width="200" 
						ItemsSource="{Binding Items}"/>
{{endregion}}

>More detailed information on how to populate __RadListBox__ with some data you could found [here]({%slug radlistbox-populating-with-data-overview%}).

## See Also

 * [Overview]({%slug radlistbox-overview%})
 * [Populating with Data]({%slug radlistbox-populating-with-data-overview%})