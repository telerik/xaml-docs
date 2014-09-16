using System;
using Telerik.Windows.Controls.ScheduleView;

namespace AppointmentSelectionBehaviorWithResources
{

#region radscheduleview-features-slot-selection-behavior_0
public class CustomSlotSelectionBehavior : SlotSelectionBehavior
{
}
#endregion

#region radscheduleview-features-slot-selection-behavior_1
public class CustomSlotSelectionBehavior : SlotSelectionBehavior
{
	protected override Slot GetSelectionOverride(SlotSelectionState state, Slot currentSlot)
	{
		Slot newSlotSelection = new Slot(currentSlot.Start, currentSlot.End.AddMinutes(30));
		return base.GetSelectionOverride(state, newSlotSelection);
	}
}
#endregion

}
