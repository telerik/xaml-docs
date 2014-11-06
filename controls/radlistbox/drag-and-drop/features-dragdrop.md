---
title: Overview
page_title: Overview
description: Overview
slug: radlistbox-features-dragdrop
tags: overview
published: True
position: 0
---

# Overview

Telerik __RadListBox__ control enhances further your application's capabilities through its rich drag-and-drop functionality. You can easily perform various drag-and-drop operations.      

This help topic will explain in details the drag-drop functionality in __RadListBox__ control. We will go through the following topics:      

* [Attaching the behavior](#attaching-the-behavior)

* [Features](#features)

* [Converting data](#converting-data)

We will go through each of them separately.

>The drag and drop functionality between ListBox controls with statically declared items is not supported but the reorder functionality is supported.        

## Attaching the behavior

The drag-drop functionality of __RadListBox__ can be enabled by setting its DragDropBehavior property. You should use the ListBoxDragDropBehavior class placed in Telerik.Windows.Controls.dll which is prepared to handle the drag and drop of the ListBox items.        

* Add a reference to Telerik.Windows.Controls.dll and add the following XML namespaces to your XAML:

#### __XAML__

{{region radlistbox-features-dragdrop_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}

* Create a RadListBoxItem Style that will enable the drag of the RadListBoxItem controls:

#### __XAML__

{{region radlistbox-features-dragdrop_1}}
	<Style x:Key="DraggableListBoxItem" TargetType="telerik:RadListBoxItem">
		<Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True" />
	</Style>
{{endregion}}

* Attach the ListBoxDragDropBehavior behavior:

#### __XAML__

{{region radlistbox-features-dragdrop_2}}
	<telerik:RadListBox ItemContainerStyle="{StaticResource DraggableListBoxItem}">
		<telerik:RadListBox.DragDropBehavior>
			<telerik:ListBoxDragDropBehavior />
		</telerik:RadListBox.DragDropBehavior>
	</telerik:RadListBox>
{{endregion}}

## Features

The DragVisualProvider enriches the drag-drop functionality of RadListBox control by providing a different visual DragCue to the dragged item.

In order to enable the visual DragCue the provider needs to be attached to the ListBox control:        

#### __XAML__

{{region radlistbox-features-dragdrop_3}}
	<telerik:RadListBox.DragVisualProvider>
		<telerik:ScreenshotDragVisualProvider />
	</telerik:RadListBox.DragVisualProvider>
{{endregion}}

The DragVisualProvider can be set to:

* __EmptyDragVisualProvider__ - this is default DragVisualProvider. It doesn't provide any visual representation of the dragged item.

![radlistbox features dragdrop 0](images/radlistbox_features_dragdrop_0.png)

* __ListBoxDragVisualProvider__ - with the Q1 2014 release of UI for {% if site.site_name == 'WPF' %}WPF {% endif %}{% if site.site_name == 'Silverlight' %}Silverlight {% endif %}__ListBoxDragVisualProvider__ has been improved in order to provide additional information. Now its DragCue also indicates the drop position of the dragged item - whether it would be *before* or *after* the item below.

When the cursor is pointing the upper part of an item below, the DragCue indicates that the dragged item will be dropped *before* that item:

![radlistbox features dragdrop 9](images/radlistbox_features_dragdrop_9.png)

And when pointing the bottom part of an item, the DragCue indicates that the dragged item will be dropped *after* the same item:

![radlistbox features dragdrop 10](images/radlistbox_features_dragdrop_10.png)

>tipThe __ListBoxDragVisualProvider__ DragCue can be modified in order to have the old appearance. You can find a runnable project which demonstrates the exact approach to achieve that in our online SDK repository [here](https://github.com/telerik/xaml-sdk), the example is listed as __ListBox / ModifyListBoxDragVisualStyle__.              

* __ScreenshotDragVisualProvider__ - provides the exact visual representation of the dragged item.

![radlistbox features dragdrop 1](images/radlistbox_features_dragdrop_1.png)

* __DefaultDragVisualProvider__ - provides the string representation of the dragged item.

![radlistbox features dragdrop 2](images/radlistbox_features_dragdrop_2.png)

* __Custom DragVisualProvider__ - more detailed information on how to create a custom DragVisualProvider can be found [here]({%slug radlistbox-styles-and-templates-customize-the-dragvisualprovider%}).            

## Converting data

In scenarios with drag-drop between controls containing different item types the dragged data should be converted using a DataConverter. The following example shows how to create a custom DataConverter when converting data between two RadListBox controls, one of them containing items of type Product and the other - of type Order.

* Create a new class, deriving from DataConverter:

#### __C#__

{{region radlistbox-features-dragdrop_0}}
	public class ProductToOrderConverter: DataConverter
	{
	}
{{endregion}}

* Override the GetConvertToFormats() and ConvertTo(). The following method can convert data from Product to Order:

#### __C#__

{{region radlistbox-features-dragdrop_1}}
	public class ProductToOrderConverter : DataConverter
	{
		public override string[] GetConvertToFormats()
		{
			return new string[] { typeof(Product).FullName, typeof(Order).FullName };
		}
	
		public override object ConvertTo(object data, string format)
		{
			var payload = (IEnumerable)DataObjectHelper.GetData(data, typeof(Product), false);
			if (payload != null)
			{
				return payload.OfType<Product>().Select(a => new Order {
					Name = a.Name,
					Quantity = 1
				});
			}
			return null;
		}
	}
{{endregion}}

The final configuration of the RadListBox control in XAML should look like:

#### __XAML__

{{region radlistbox-features-dragdrop_6}}
	<telerik:RadListBox ItemsSource="{Binding Products}" ItemContainerStyle="{StaticResource DraggableListBoxItem}">
		<telerik:RadListBox.DragVisualProvider>
			<telerik:ScreenshotDragVisualProvider />
		</telerik:RadListBox.DragVisualProvider>
		<telerik:RadListBox.DragDropBehavior>
			<telerik:ListBoxDragDropBehavior />
		</telerik:RadListBox.DragDropBehavior>
		<telerik:RadListBox.DataConverter>
			<local:ManagerToCustomerConverter />
		</telerik:RadListBox.DataConverter>
	</telerik:RadListBox>
	
	<telerik:RadListBox ItemsSource="{Binding Orders}" />
{{endregion}}

The end result:

![radlistbox features dragdrop 6](images/radlistbox_features_dragdrop_6.png)

![radlistbox features dragdrop 7](images/radlistbox_features_dragdrop_7.png)

![radlistbox features dragdrop 8](images/radlistbox_features_dragdrop_8.png)

# See Also

 * [Drag-Drop between RadListBox and RadScheduleView]({%slug radlistbox-features-dragdrop-scheduleview%})
