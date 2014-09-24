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

#region dragdropmanager_-howto-drag-between-RadScheduleView-and-ListBox_1
SampleListBox.ItemsSource = new ObservableCollection<Appointment>();
#endregion

#region dragdropmanager_-howto-drag-between-RadScheduleView-and-ListBox_3
DragDropManager.AddDragInitializeHandler(SampleListBox, OnDragInitialize);
DragDropManager.AddDragOverHandler(SampleListBox, OnListDragOver);
DragDropManager.AddDragDropCompletedHandler(SampleListBox, OnDragDropComplete);
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
{
    var listBoxItems = ((IList)SampleListBox.ItemsSource);
    var draggedItems = ((ScheduleViewDragDropPayload)args.Data).DraggedAppointments;
    foreach (var item in draggedItems)
    {
        if (!listBoxItems.Contains(item))
        {
             listBoxItems.Add(item);
        }
    }
}
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    var listBoxItem = (System.Windows.Controls.ListBoxItem)args.Source;
    var listbox = listBoxItem.ParentOfType<System.Windows.Controls.ListBox>();
    IList<IOccurrence> appointments = listbox.SelectedItems.OfType<IOccurrence>().ToList();
    if (appointments.Count == 0)
    {
           return;
    }
    args.Data = new ScheduleViewDragDropPayload(listbox.ItemsSource, appointments);
    var dragVisual = new TextBlock();
    dragVisual.SetBinding(TextBlock.TextProperty, new System.Windows.Data.Binding("DraggedAppointment") { Source = args.Data });
    args.DragVisual = dragVisual;
    args.AllowedEffects = DragDropEffects.All;
}
private void OnDragDropComplete(object sender, DragDropCompletedEventArgs args)
{
    var payload = ((ScheduleViewDragDropPayload)args.Data);
    var sourceItems = (IList)payload.SourceAppointmentsSource;
    foreach (var item in payload.DraggedAppointments)
    {
        sourceItems.Remove(item);
    }
}
private void OnListDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
{
    if (((System.Windows.Controls.ListBox)sender).ItemsSource == ((ScheduleViewDragDropPayload)args.Data).SourceAppointmentsSource)
    {
        args.Effects = DragDropEffects.None;
    }
    args.Handled = true;
}
#endregion

#region dragdropmanager_-howto-drag-between-RadScheduleView-and-ListBox_6
ScheduleView.AppointmentsSource = new ObservableCollection<Appointment>(
                from c in Enumerable.Range(0, 10)
                select new Appointment { Start = DateTime.Now.AddDays(c % 5), End = DateTime.Now.AddDays(c % 5).AddHours(2), Subject = "Event " + c });
#endregion
}
