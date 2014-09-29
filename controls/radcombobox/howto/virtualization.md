---
title: RadComboBox Virtualization
page_title: RadComboBox Virtualization
description: RadComboBox Virtualization
slug: radcombobox-howto-virtualization
tags: radcombobox,virtualization
published: True
position: 3
---

# RadComboBox Virtualization



## 

The Telerik RadControls' API gives you the ability to configure the __RadComboBox__to support __virtualization__, which reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance. The purpose of this tutorial is to show you how to create a virtualized __RadComboBox__. 

>

The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

In some scenarios it is required to load thousands of items in a __RadComboBox__. By default the control creates __RadComboBoxItem__ containers for each data item, so it might take some time to open the drop-down. To resolve the problem you just have to change the __RadComboBox__'s __ItemsPanel__ with __VirtualizingStackPanel__:

#### __XAML__

{{region radcombobox-howto-virtualization_0}}
	<telerik:RadComboBox x:Name="radComboBox">
	    <telerik:RadComboBox.ItemsPanel>
	        <ItemsPanelTemplate>
	            <VirtualizingStackPanel />
	        </ItemsPanelTemplate>
	    </telerik:RadComboBox.ItemsPanel>
	</telerik:RadComboBox>
	{{endregion}}



# See Also

 * [Creating ItemTemplate and SelectionBoxTemplate]({%slug radcombobox-creating-itemtemplate%})
