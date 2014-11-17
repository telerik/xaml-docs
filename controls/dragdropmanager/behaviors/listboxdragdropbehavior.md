---
title: ListBoxDragDropBehavior
page_title: ListBoxDragDropBehavior
description: ListBoxDragDropBehavior
slug: dragdropmanager-behaviors-listboxdragdropbehavior
tags: listboxdragdropbehavior
published: True
position: 1
---

# ListBoxDragDropBehavior

In this article you can find information about the ListBoxDragDropBehavior class.

## Attaching the behavior

* Add a reference to Telerik.Windows.Controls.dll and add the following XML namespaces to your XAML:

#### __XAML__
{{region dragdropmanager-behaviors-listboxdragdropbehavior_0}}
	xmlns:telerik=http://schemas.telerik.com/2008/xaml/presentation
	xmlns:drag="clr-namespace:Telerik.Windows.DragDrop.Behaviors;assembly=Telerik.Windows.Controls"
{{endregion}}

* Create a ListBoxItem Style that will enable the drag of the ListBoxItem controls:

#### __XAML__
{{region dragdropmanager-behaviors-listboxdragdropbehavior_1}}
	<Style x:Key="DraggableListBoxItem" TargetType="ListBoxItem">
		<Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True" />
	</Style>
{{endregion}}

* Attach the ListBoxDragDropBehavior behavior:

#### __XAML__
{{region dragdropmanager-behaviors-listboxdragdropbehavior_2}}
	<ListBox ItemContainerStyle="{StaticResource DraggableListBoxItem}">
		<drag:ListBoxDragDrop.Behavior>
			<drag:ListBoxDragDropBehavior />
		</drag:ListBoxDragDrop.Behavior>
	</ListBox>
{{endregion}}

## Features

The __ListBoxDragDropBehavior__ provides drag-drop capabilities for standard ListBox controls. It automatically recognizes its host control item Type and automatically adds the dragged items that are of this type. In some cases the __ListBoxDragDropBehavior__ will be unable to correctly recognize its host’s item Type. The ItemType property is provided for such cases {% if site.site_name == 'Silverlight' %}(Silverlight 5 example){% endif %}:

#### __XAML__

{{region dragdropmanager-behaviors-listboxdragdropbehavior_3}}
	<drag:ListBoxDragDropBehavior ItemType="{x:Type local:IBaseClass}" />
{{endregion}}

{% if site.site_name == 'Silverlight' %}
>In Silverlight 4 you will have to either inherit from ListBoxDragDropBehavior and set the ItemType property in the class constructor, or bind it to a property in your view model that contains the correct Type.
{% endif %}

By default the __ListBoxDragDropBehavior__ will allow reordering/inserting items in the ListBox. To disable this feature, set AllowReorder=false on the behavior:

#### __XAML__

{{region dragdropmanager-behaviors-listboxdragdropbehavior_4}}
	<drag:ListBoxDragDropBehavior AllowReorder="false" />
{{endregion}}

The __ListBoxDragDropBehavior__ supports copying the dragged items if the Control key is pressed. For that purpose the CopyDraggedItems method should be overridden:    	

#### __C#__

{{region dragdropmanager-behaviors-listboxdragdropbehavior_5}}
	protected override IEnumerable<object> CopyDraggedItems(ListBoxDragDropState state)
	{
		return state.DraggedItems.OfType<Customer>().Select(c => c.Copy()).Cast<object>();
	} 
{{endregion}}

## Converting data

In scenarios with drag-drop between controls containing different item types the drag data should be converted using a DataConverter.

* Create a new class, deriving from DataConverter:

#### __C#__

{{region dragdropmanager-behaviors-listboxdragdropbehavior_6}}
	public class CustomerToAppointmentConverter : DataConverter
	{
	}
{{endregion}}

* Override the GetConvertToFormats() and ConvertTo(). The following method can convert from Customer to Appointment and vice versa:

#### __C#__

{{region dragdropmanager-behaviors-listboxdragdropbehavior_7}}
	public override string[] GetConvertToFormats()
	{
		return new string[] { typeof(Appointment).FullName, typeof(Customer).FullName };
	}
	public override object ConvertTo(object data, string format)
	{
		var customers = (IEnumerable)DataObjectHelper.GetData(data, typeof(Customer), false);
		if (customers != null && format == typeof(Appointment).FullName)
		{
			return customers.OfType<Customer>().Select(c => new Appointment { Subject = c.Name });
		}
		var appointments = (IEnumerable)DataObjectHelper.GetData(data, typeof(Appointment), false);
		if (appointments != null && format == typeof(Customer).FullName)
		{
			return appointments.OfType<Appointment>().Select(a => new Customer { Name = a.Subject });	
		}
		return null;
	}	
{{endregion}}

* Attach the newly created DataConverter:

#### __XAML__

{{region dragdropmanager-behaviors-listboxdragdropbehavior_8}}
	<ListBox ...>
		<drag:ListBoxDragDrop.DataConverter>
			<local:CustomerToAppointmentConverter />
		</drag:ListBoxDragDrop.DataConverter>
		<drag:ListBoxDragDrop.Behavior>
			<drag:ListBoxDragDropBehavior />
		</drag:ListBoxDragDrop.Behavior>
	</ListBox>
{{endregion}}