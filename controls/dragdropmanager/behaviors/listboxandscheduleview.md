---
title: Drag-drop between ListBox and ScheduleView
page_title: Drag-drop between ListBox and ScheduleView
description: Drag-drop between ListBox and ScheduleView
slug: dragdropmanager-behaviors-listboxandscheduleview
tags: drag-drop,between,listbox,and,scheduleview
publish: True
position: 2
---

# Drag-drop between ListBox and ScheduleView



## 

To enable drag-drop between a ListBox and a RadScheduleView, on the ListBox should be attached a ListBoxDragDropBehavior and a DataConverter. 
          The DataConverter should convert the dragged items from the ListBox into a ScheduleViewDragDropPayload and vice versa. 
          

Following is an example demonstrating how to convert appointments between a ListBox and a ScheduleView:

* Create the DataConverter:

#### __C#__

{{region dragdropmanager-behaviors-listboxandscheduleview_0}}
	public class ScheduleViewToAppointmentConverter : DataConverter
	{		
		public override string[] GetConvertToFormats()
		{
			return new string[] { typeof(ScheduleViewDragDropPayload).FullName};
		}
	
		public override object ConvertTo(object data, string format)
		{
				
			if (format == typeof(ScheduleViewDragDropPayload).FullName && DataObjectHelper.GetDataPresent(data, typeof(Appointment), false))
			{
				var appointments = (IEnumerable)DataObjectHelper.GetData(data, typeof(Appointment), false);
				if (appointments != null)
				{
					return new ScheduleViewDragDropPayload(null, appointments.OfType<IOccurrence>().ToList());
				}
			}			
			return null;
		}
	}
	{{endregion}}



* Add CustomScheduleViewDragDropBehavior class which inherits ScheduleViewDragDropBehavior:
      	

#### __C#__

{{region dragdropmanager-behaviors-listboxandscheduleview_1}}
	public class CustomScheduleViewDragDropBehavior : ScheduleViewDragDropBehavior
	{
		public override IEnumerable<IOccurrence> ConvertDraggedData(object data)
		{
			if (DataObjectHelper.GetDataPresent(data, typeof(Appointment), false))
			{
				var appointments = DataObjectHelper.GetData(data, typeof(Appointment), true) as IEnumerable;
				if (appointments != null)
				{
					return appointments.OfType<IOccurrence>();
				}
			}
	
			return base.ConvertDraggedData(data);
		}
	}
	{{endregion}}



* The final configuration of the two controls in XAML should look like:

#### __XAML__

{{region dragdropmanager-behaviors-listboxandscheduleview_2}}
	
	<telerik:RadScheduleView ...>
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:WeekViewDefinition />
		</telerik:RadScheduleView.ViewDefinitions>
		<telerik:RadScheduleView.DragDropBehavior>
			<local:CustomScheduleViewDragDropBehavior />
		</telerik:RadScheduleView.DragDropBehavior>
	</telerik:RadScheduleView>
	
	<ListBox ...>
		<drag:ListBoxDragDrop.DataConverter>
			<local:ScheduleViewToAppointmentConverter />
		</drag:ListBoxDragDrop.DataConverter>
		<drag:ListBoxDragDrop.Behavior>
			<drag:ListBoxDragDropBehavior />
		</drag:ListBoxDragDrop.Behavior>	
	</ListBox>
	{{endregion}}



Here is the result:![dragdropmanager listboxandscheduleview](images/dragdropmanager_listboxandscheduleview.png)
