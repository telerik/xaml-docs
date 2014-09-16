using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}


#region radscheduleview-features-customslots_1
public class BreakSlot : Slot
{
	public string ImageSource { get; set; }
	public string Description { get; set; }

	public BreakSlot(DateTime start, DateTime end) : base(start, end)
	{
		this.Resources.Add(new Resource("My Calendar", "Calendar"));			
	}

	public override Slot Copy()
	{
		Slot slot = new BreakSlot(this.Start, this.End);
		slot.CopyFrom(this);
		return slot;
	}

	public override void CopyFrom(Slot other)
	{
		var otherSlot = other as BreakSlot;
		if (otherSlot != null)
		{
			this.ImageSource = otherSlot.ImageSource;
			this.Description = otherSlot.Description;
			base.CopyFrom(otherSlot);
		}
	}
}
#endregion

#region radscheduleview-features-customslots_2
this.SpecialSlots = new ObservableCollection<Slot>()
{
	new BreakSlot( new DateTime(2012, 1, 23, 12, 0, 0), new DateTime(2012, 1, 23, 13, 0, 0)) {
		RecurrencePattern = new RecurrencePattern(null, RecurrenceDays.WeekDays, RecurrenceFrequency.Weekly, 1, null, null),
		ImageSource = "meal_icon.png",
		Description =  "lunch time"
	}, 
	new BreakSlot(new DateTime(2012, 1, 23, 16, 0, 0), new DateTime(2012, 1, 23, 16, 30, 0)) {
		RecurrencePattern = new RecurrencePattern(null, RecurrenceDays.WeekDays, RecurrenceFrequency.Weekly, 1, null, null),
		ImageSource = "coffee_icon.png",
		Description = "coffee break"
	}
};
#endregion


#region radscheduleview-features-customslots_3
public class SpecialSlotStyleSelector : ScheduleViewStyleSelector
{
	private Style breakSlotStyle;

	public Style BreakSlotStyle
	{
		get
		{
			return this.breakSlotStyle;
		}
		set
		{
			this.breakSlotStyle = value;
		}
	}

	public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDefinition)
	{
		Slot slot = item as Slot;

		if (item is BreakSlot)
			return this.BreakSlotStyle;

		return base.SelectStyle(item, container, activeViewDefinition);
	}
}
#endregion


}
