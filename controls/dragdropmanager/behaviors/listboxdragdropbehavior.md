---
title: ListBox DragDropBehavior
page_title: ListBoxDragDropBehavior - DragDropManager - ListBox
description: Check our &quot;ListBoxDragDropBehavior&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-behaviors-listboxdragdropbehavior
tags: listboxdragdropbehavior
published: True
position: 1
---

# ListBox DragDropBehavior

The `ListBoxDragDropBehavior` class enables customizeable drag/drop functionality in `RadListBox` and the {{ site.framework_name }} native `ListBox`.

This article shows how to use the behavior in the `ListBox` control. For `RadListBox`, see its [Drag and Drop]({%slug radlistbox-features-dragdrop%}) documentation.

To use the behavior with `ListBox`, set the `ListBoxDragDrop.Behavior` [attached property](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/properties/attached-properties-overview?view=netdesktop-6.0). Additional to this, the `DragDropManager.AllowDrag` or `DragDropManager.AllowCapturedDrag` attached property should be set to the `ListBoxItems` elements. This can be done via the `ItemContainerStyle` property of the control.

__Setting up the ListBox and the drag/drop behavior__
```XAML
	<ListBox ItemsSource="{Binding MyItemsCollection}" DisplayMemberPath="Name">
		<ListBox.ItemContainerStyle>
			<Style TargetType="ListBoxItem"> 
				<Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True" /> 
			</Style> 
		</ListBox.ItemContainerStyle>
		<telerik:ListBoxDragDrop.Behavior>
			<telerik:ListBoxDragDropBehavior />
		</telerik:ListBoxDragDrop.Behavior>
	</ListBox>
```

The default drag/drop behavior is to reorder the items if the drag/drop happens in the same `ListBox` instance. Dropping an item to another `ListBox` instance will remove it from the source control and add it to the target. If you hold the `Ctrl` key while dropping an item in another `ListBox`, the item will get copied.

## Copy Item in the Same ListBox

By default, dragging with the `Ctrl` key pressed makes a copy of the dragged item on drop. This doesn't happen if the item is dropped in the same `ListBox` instance. To allow this behavior, create a class that derives from `ListBoxDragDropBehavior` and override its `CopyDraggedItems` method.

__Creating custom drag drop behavior that allows copy items in the same ListBox instance__
```C#
	public class CustomListBoxDragDropBehavior : ListBoxDragDropBehavior
    {
        protected override IEnumerable<object> CopyDraggedItems(DragDropState state)
        {
            var copiedItems = new List<object>();
            foreach (object item in state.DraggedItems)
            {
                object copy = CreateItemCopy(item);
                copiedItems.Add(copy);
            }
            return copiedItems;
        }
		
		private object CreateItemCopy(object originaItem)
		{
			// create and return a copy of the item
		}
    }
```

__Using the custom behavior__
```C#
	<ListBox>		
		<telerik:ListBoxDragDrop.Behavior>
			<local:CustomListBoxDragDropBehavior />
		</telerik:ListBoxDragDrop.Behavior>
	</ListBox>
```

## Disable Item Reorder

The default drag/drop behavior within the same `ListBox` instance is to reorder the items. To disable this, set the `AllowReorder` property of `ListBoxDragDropBehavior` to `false`.

__Disabling reordering__
```XAML
	<telerik:ListBoxDragDropBehavior AllowReorder="False" />
```

## Setting Item Type

The `ListBoxDragDropBehavior` automatically recognizes the item `Type` based on the `ItemsSource` of its host control and then automatically adds the dragged items that are of this type. In some cases the behavior my not recognize the item type correctly. In that situation, use the `ItemType` property of the `ListBoxDragDropBehavior` in order to manually assign the type.

__Setting the ItemType__
```XAML
	<drag:ListBoxDragDropBehavior ItemType="{x:Type local:MyItemClass}" />
```

## Customizing the Drag and Drop Operation

The `ListBoxDragDropBehavior` class derives from the `DragDropBehavior`, which provides several methods that can be overridden in order to modify the actions that happen on drag and drop. Read more about the available methods in the [DragDropBehavior]({%slug dragdropmanager-behaviors-dragdropbehavior%}) article.

## Converting Data

In scenarios with drag/drop between controls containing different item types the drag data should be converted using a `DataConverter`. The following example shows how to implement a converter and assign it to the host control. The converter example uses sample class names (Appointment and Customer) that can vary on your exact implementation and naming.

__Creating the DataConverter class__
```C#
	public class CustomerToAppointmentConverter : DataConverter
	{
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
	}
```

__Using the custom DataConverter__
```C#	
	<ListBox>
		<telerik:ListBoxDragDrop.DataConverter>
			<local:CustomerToAppointmentConverter />
		</telerik:ListBoxDragDrop.DataConverter>
		<telerik:ListBoxDragDrop.Behavior>
			<telerik:ListBoxDragDropBehavior />
		</telerik:ListBoxDragDrop.Behavior>
	</ListBox>
```
