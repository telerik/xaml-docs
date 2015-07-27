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

Getting started with the __RadListBox__ control is pretty straightforward.

>In order to use __RadListBox__ in your project you have to add reference to the following assembly:
>__Telerik.Windows.Controls__

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the __RadListBox__ control in code behind and XAML code:

#### __XAML__

{{region radlistbox-getting-started_0}}
	<UserControl
	    ... 
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot" Background="White">
	        <StackPanel>
	            <telerik:RadListBox x:Name="radListBox" Width="200" />
	        </StackPanel>
	    </Grid>
	</UserControl>
{{endregion}}

#### __C#__

{{region radlistbox-getting-started_1}}
	RadListBox listBox = new RadListBox();
{{endregion}}

>tipMore detailed information how to populate __RadListBox__ with some data you could found [here]({%slug radlistbox-populating-with-data-overview%}).