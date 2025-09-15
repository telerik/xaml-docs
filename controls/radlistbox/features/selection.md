---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadListBox {{ site.framework_name }} control.
slug: radlistbox-features-selection
tags: selection
published: True
position: 0
---

# Selection

The purpose of this tutorial is to show you the basic properties exposed by the __RadListBox__ for working with selection. This topic includes the following sections: 

* [Setting SelectionMode](#setting-selectionmode)

* [Using the SelectedItem](#using-the-selecteditem)

* [Using SelectedValue and SelectedValuePath/SelectedValueBinding](#using-selectedvalue-and-selectedvaluepathselectedvaluebinding)

* [Using the SelectedIndex](#using-the-selectedindex)

* [Using the Text and TextPath/TextBinding](#using-the-text-and-textpath--textbinding)

* [Disabling Caching of Selected Items](#disabling-caching-of-selected-items)

## Setting SelectionMode

The __RadListBox__ provides three selection modes, which allow you to manipulate the type of selection. This is controlled by the __SelectionMode__ enumeration property which has the following entries:

* __Single__ - only one item can be selected at a time. (__default value__)

* __Multiple__ - items are added to the selection when they get clicked and get removed when they get clicked again.

* __Extended__ - items are added to the selection only by combining the mouse clicks with the __Ctrl__ or __Shift__ key. 

## Using the SelectedItem

The purpose of the SelectedItem property is to get or set the currently selected item of the RadListBox. There are two common cases when accessing the SelectedItem property run-time. 

* When your __RadListBox__ is with static data (declared in XAML), the SelectedItem property is of type RadListBoxItem.

__Getting the SelectedItem of type RadListBoxItem__

```C#
	var selectedItem = radListBox.SelectedItem as RadListBoxItem;
```

* When your __RadListBox__ is [data bound to a collection of custom objects]({%slug radlistbox-populating-with-data-binding-to-object%}), the SelectedItem is of the type of the custom object.     			

__Getting the SelectedItem of type custom object__

```C#
	var customer = radListBox.SelectedItem as Customer;
```

## Using SelectedValue and SelectedValuePath/SelectedValueBinding

The __SelectedValue__ property is used when you have linked the __RadListBox__ to a data source, and you want to return a value other than the one which is displayed. The __SelectedValuePath__ / __SelectedValueBinding__ properties provide a way to specify a __SelectedValue__ for the __SelectedItem__ in a __RadListBox__. There are two essential things that you should remember here:     	

* The __SelectedItem__ property represents an object in the Items collection and the listbox displays the value of a single property of the selected item.

* The __SelectedValuePath__ / __SelecteValueBinding__ properties specify the path to the property that is used to determine the value of the __SelectedValue__ property.

>If SelectedValuePath / SelecteValueBinding are not specified, SelectedValue should be equal to SelectedItem.

The following example demonstrates the usage of the __SelectedItem__, __SelectedValue__ and __SelectedValuePath__ properties.		

Imagine that you have a business object named Customer with two members(properties): Name and City. And a __RadListBox__ control which is [data bound]({%slug radlistbox-populating-with-data-binding-to-object%}) to a list of Customer objects. 

__Business object named Customer__

```C#
	public class Customer
	{
		public string Name { get; set; }
		public string City { get; set; }
	}
```

__Initializing of RadListBox__

```XAML
	<telerik:RadListBox  Width="300" x:Name="radListBox1" 
			ItemsSource="{Binding Customers, Source={StaticResource CustomerViewModel}}"
			SelectedValuePath="City"				
			DisplayMemberPath="Name"/>
```

![radlistbox populatingwithdata bindingtoobject 020](images/radlistbox_populatingwithdata_bindingtoobject_020.png)

When you select a Customer name from the listbox, the SelectedItem property returns the Customer data item that corresponds to the selected Name. However, because the __SelectedValuePath__ of this __RadListBox__ is set to City, the SelectedValue is set to the City property of the Customer business object.        

## Using the SelectedIndex

Use the __SelectedIndex__ property to get or set the index of the selected item. For example, by using the __SelectedIndex__ property, you could specify which the default selected item is. 

__Setting SelectedIndex__

```XAML
	<telerik:RadListBox x:Name="radListBox" Width="200" SelectedIndex="3" />
```

## Using the Text and TextPath / TextBinding

Use the __RadListBox__'s __Text__ property whenever you want to get the string representation of the currently selected item.     	

The __TextPath__ / __TextBinding__ properties specify the path to the property that is used to determine the value of the __Text__ property.

## Disabling Caching of Selected Items

By default, when its **ItemsSource** is reset, RadListBox will try to restore any previously selected items through its **built-in caching mechanism**. As of **R1 2017**, RadListBox allows you to disable this functionality by setting its new **EnableSelectionCaching** property to **False**.

## See Also

 * [Getting Started]({%slug radlistbox-getting-started%})
 
 * [Populating with Data]({%slug radlistbox-populating-with-data-overview%})