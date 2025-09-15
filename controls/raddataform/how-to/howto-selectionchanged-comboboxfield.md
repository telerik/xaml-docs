---
title: Handling SelectionChanged event for DataFormComboBoxField
page_title: Handling SelectionChanged event for DataFormComboBoxField
description: Check our &quot;Handling SelectionChanged event for DataFormComboBoxField&quot; documentation article for the RadDataForm {{ site.framework_name }} control.
slug: raddataform-howto-selectionchanged-comboboxfield
tags: handling,selectionchanged,event,for,the,dataformcomboboxfield
published: True
position: 2
---

# Handling SelectionChanged event for DataFormComboBoxField

DataFormComboBoxField does not have a SelectionChanged event itself. In case you need such an event to implement your additional logic, you can handle the SelectionChanged event of its editing element (RadComboBox). To do that you need to:

1) Register an event handler for the SelectionChanged event:

{% if site.site_name == 'WPF' %}

__Example 1: Adding event handler for the SelectionChanged event__
```C#
	this.AddHandler(RadComboBox.SelectionChangedEvent, new System.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
```
```VB.NET
	Me.[AddHandler](RadComboBox.SelectionChangedEvent, New SelectionChangedEventHandler(AddressOf OnSelectionChanged))
```

{% endif %}

{% if site.site_name == 'Silverlight' %}

__Example 1: Adding event handler for the SelectionChanged event__
```C#
	this.AddHandler(RadComboBox.SelectionChangedEvent, 
	    new Telerik.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged), true);
```
```VB.NET
	Me.[AddHandler](RadComboBox.SelectionChangedEvent, New Telerik.Windows.Controls.SelectionChangedEventHandler(onSelectionChanged), True)
```

{% endif %}

>You should add a using statement to __Telerik.Windows__ namespace in order to be able to add the handler.

2) Check if any items were unselected throught __RemovedItems.Count__

{% if site.site_name == 'WPF' %}

__Example 2: Check if any items were unselected__
```C#
	private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	    if (e.RemovedItems.Count > 0)
	    {
	        //your code here
	    }
	}
```
```VB.NET
	Private Sub OnSelectionChanged(sender As Object, e As SelectionChangedEventArgs)
	    'your code here
	    If e.RemovedItems.Count > 0 Then
	    End If
	End Sub
```

{% endif %}


{% if site.site_name == 'Silverlight' %}

__Example 2: Check if any items were unselected__
```C#	
	private void OnSelectionChanged(object sender,
            Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                //your code here
            }
        }
```
```VB.NET

	Private Sub onSelectionChanged(sender As Object, e As Telerik.Windows.Controls.SelectionChangedEventArgs)
            If e.RemovedItems.Count > 0 Then
            End If
        End Sub
```

{% endif %}

Checking if there are any items being unselected through the RemovedItems.Count ensures that the event will not be handled on the initial loading when a default item has been selected. 

## See Also

 * [Edit Lookup Values with RadComboBox]({%slug raddatafor-edit-lookup-values-with-radcombobox%})
