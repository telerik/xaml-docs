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

#region radscheduleview-features-speacialslots_0
var NonWorkingHours = new ObservableCollection<Slot>();
DateTime start = new DateTime(2010, 1, 1, 8, 0, 0);
DateTime end = new DateTime(2010, 1, 1, 18, 0, 0);
NonWorkingHours.Add(new Slot(end, start.AddDays(1))
{
    RecurrencePattern = new RecurrencePattern(
                null, RecurrenceDays.Monday | RecurrenceDays.Tuesday | RecurrenceDays.Wednesday | RecurrenceDays.Thursday, RecurrenceFrequency.Weekly, 1, null, null)
});
NonWorkingHours.Add(
    new Slot(end, start.AddDays(3))
    {
        RecurrencePattern = new RecurrencePattern(
                    null, RecurrenceDays.Friday, RecurrenceFrequency.Weekly, 1, null, null)
    });
#endregion

#region radscheduleview-features-speacialslots_1
public class SpecialSlotStyleSelector : ScheduleViewStyleSelector
{
    private Style nonworkingHourStyle;
    public Style NonworkingHourStyle
    {
        get
        {
            return this.nonworkingHourStyle;
        }
        set
        {
            this.nonworkingHourStyle = value;
        }
    }
    public override Style SelectStyle(object item, DependencyObject container, ViewDefinitionBase activeViewDefinition)
    {
        return this.NonworkingHourStyle;
    }
}
#endregion

#region radscheduleview-features-speacialslots_5
var ReadOnlySlots = new ObservableCollection<Slot>();
Slot readOnlyslot = new Slot() { 
		Start = DateTime.MinValue, 
		End = DateTime.MaxValue, 
		IsReadOnly = true 
		};
readOnlyslot.Resources.Add(new Resource("Team", "Calendar"));
ReadOnlySlots.Add(readOnlyslot);
#endregion

#region radscheduleview-features-speacialslots_8
private void scheduleView_ShowDialog(object sender, ShowDialogEventArgs e)
{
    var appointmentDialog = e.DialogViewModel as AppointmentDialogViewModel;
    if (appointmentDialog != null && appointmentDialog.IsReadOnly)
    {
        e.Cancel = true;
    }
}
#endregion
}
