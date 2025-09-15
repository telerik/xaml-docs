---
title: Subscribe to SelectionChanged of RadComboBox in RadGridView Column FilteringControl
description: How to attach to the SelectionChanged event of the RadComboBox elements hosted in the FilteringControl of RadGridView's GridViewColumn.
type: how-to
page_title: Add SelectionChanged Handler to the RadComboBoxes of RadGridView's FilteringControl
slug: kb-gridview-filter-combo-selectionchanged
position: 0
tags: subscribe,selectionchanged,event,combobox,filteringcontrol
ticketid: 838443
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2022.3.1109</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to attach to the SelectionChanged event of the RadComboBox elements hosted in the FilteringControl of RadGridView's GridViewColumn.

## Solution

To subscribe to the SelectionChanged event, you can use the `EventManager` class in order to subscribe all RadComboBox instances to the event. Then, in the event handler, you can check if the current `RadComboBox` is hosted in `FilteringControl`. In that case, execute the code in the handler.


```C#
	public partial class MainWindow : Window
	{
        	static MainWindow()
        	{
            		EventManager.RegisterClassHandler(typeof(RadComboBox), RadComboBox.SelectionChangedEvent, new SelectionChangedEventHandler(OnFilteringControlComboBoxSelectionChanged));         
        	}


		private static void OnFilteringControlComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var comboBox = (RadComboBox)sender;
			var filteringControl = comboBox.ParentOfType<FilteringControl>();
			if (filteringControl != null)
			{
				// execute the custom selection changed code here
			}
		}

		public MainWindow()
		{
			InitializeComponent();            
		}
    }
```
