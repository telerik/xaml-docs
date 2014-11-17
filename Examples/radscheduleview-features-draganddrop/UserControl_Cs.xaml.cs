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

#region radscheduleview-features-draganddrop_0
public override bool CanDrop(DragDropState state)
{
    if (state.IsControlPressed)
    {
        return false;
    }

    return base.CanDrop(state);
}
#endregion

#region radscheduleview-features-draganddrop_1
public override bool CanStartDrag(DragDropState state)
{
    if (state.DraggedAppointments.Count() > 2)
    {
        return false;
    }

    return base.CanStartDrag(state);
} 
#endregion

#region radscheduleview-features-draganddrop_2
public override bool CanResize(DragDropState state)
{
    var destinationSlot = state.DestinationSlots.First() as Slot;
    var duration = destinationSlot.End - destinationSlot.Start;

    if (duration <= new TimeSpan(0, 30, 0) || duration > new TimeSpan(2, 0, 0))
    {
        return false;
    }

    return base.CanResize(state);
}
#endregion

#region radscheduleview-features-draganddrop_3
public override IEnumerable<IOccurrence> ConvertDraggedData(object data)
{
    if (Telerik.Windows.DragDrop.Behaviors.DataObjectHelper.GetDataPresent(data, typeof(Meeting), false))
    {
        var customers = Telerik.Windows.DragDrop.Behaviors.DataObjectHelper.GetData(data, typeof(Customer), true) as IEnumerable;
        if (customers != null)
        {
            var newApp = customers.OfType<Customer>().Select(c => new Appointment { Subject = c.Name });

            return newApp;
        }
    }

    return base.ConvertDraggedData(data);
}
#endregion

#region radscheduleview-features-draganddrop_4
public override IEnumerable<IOccurrence> CoerceDraggedItems(DragDropState state)
{
    var resource = (state.Appointment as Appointment).Resources.First();
    var allAppointments = state.SourceAppointmentsSource.Cast<IOccurrence>();
    var desiredAppointments = allAppointments.Where(a => (a as Appointment).Resources.Any(r => r == resource));

    return desiredAppointments;
}
#endregion

#region radscheduleview-features-draganddrop_5
public override bool CanStartResize(DragDropState state)
{
    var appointment = state.Appointment as Appointment;

    if (appointment.TimeMarker != null && appointment.TimeMarker.Equals(TimeMarker.Busy))
    {
        return false;
    }

    return base.CanStartResize(state);
}
#endregion

#region radscheduleview-features-draganddrop_6
public override void Drop(DragDropState state)
{
    var appointment = state.Appointment as Appointment;

    if (appointment.Category == null)
    {
        appointment.Category = new Category("Green Category", Brushes.Green);
    }

    base.Drop(state);
}
#endregion

#region radscheduleview-features-draganddrop_7
public override void Resize(DragDropState state)
{
    var appointment = state.Appointment as Appointment;
    var destinationSlot = state.DestinationSlots.First() as Slot;
    var duration = destinationSlot.End - destinationSlot.Start;
    appointment.Subject = "New duration: " + duration.ToString("h\\:mm\\:ss");
    base.Resize(state);
}
#endregion
}
