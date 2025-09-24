---
title: RadComboBox Virtualization
page_title: RadComboBox Virtualization
description: Check our &quot;RadComboBox Virtualization&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-howto-virtualization
tags: radcombobox,virtualization
published: True
position: 3
---

# RadComboBox Virtualization


The Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}s' API gives you the ability to configure the __RadComboBox__ to support __virtualization__, which reduces the memory footprint of the application and speeds up the loading time thus enhancing additionally the UI performance. The purpose of this tutorial is to show you how to create a virtualized __RadComboBox__. 

>The standard layout system creates item containers and computes layout for each item associated with a list control. The word "virtualize" refers to a technique by which a subset of user interface (UI) elements are generated from a larger number of data items based on which items are visible on-screen. Generating many UI elements when only a few elements might be on the screen can adversely affect the performance of your application.

In some scenarios it is required to load thousands of items in a __RadComboBox__. By default the control creates __RadComboBoxItem__ containers for each data item, so it might take some time to open the drop-down. To resolve the problem you just have to change the __RadComboBox__'s __ItemsPanel__ with __VirtualizingStackPanel__:



```XAML
	<telerik:RadComboBox x:Name="radComboBox">
	    <telerik:RadComboBox.ItemsPanel>
	        <ItemsPanelTemplate>
	            <VirtualizingStackPanel />
	        </ItemsPanelTemplate>
	    </telerik:RadComboBox.ItemsPanel>
	</telerik:RadComboBox>
```

>importantWhen RadComboBox is virtualized the filtering is not supported.

## See Also

 * [Creating ItemTemplate and SelectionBoxTemplate]({%slug radcombobox-creating-itemtemplate%})