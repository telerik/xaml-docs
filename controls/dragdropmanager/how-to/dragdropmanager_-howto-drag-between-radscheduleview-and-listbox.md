---
title: Drag between RadScheduleView and ListBox
page_title: Drag between RadScheduleView and ListBox
description: Check our &quot;Drag between RadScheduleView and ListBox&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager_-howto-drag-between-radscheduleview-and-listbox
tags: drag,between,radscheduleview,and,listbox
published: False
position: 3
---

# Drag between RadScheduleView and ListBox

In this article we will describe how to enable dragging between ScheduleView and ListBox using DragDropManager infrastructure.
Since RadScheduleView uses DragDropManager for its dragging operations, it enables dragging within the control and to external controls without additional code.
We need to add the logic that will allow drag and drop from ListBox. 

Firstly, we define ListBox and bind it to sample data. We also allow dropping to it and dragging to its ListBoxItems:



```XAML
	<ListBox Grid.Column="1" x:Name="SampleListBox" AllowDrop="True" Background="WhiteSmoke">
	   <ListBox.Resources>
	        <Style TargetType="ListBoxItem">
	            <Setter Property="telerik:DragDropManager.AllowDrag" Value="True"></Setter>
	        </Style>
	   </ListBox.Resources>
	</ListBox>
```



```C#
	SampleListBox.ItemsSource = new ObservableCollection<Appointment>();
```



```VB.NET
	SampleListBox.ItemsSource = New ObservableCollection(Of Appointment)()
```

Then we attach the DragInitialize, Drop and DragDropCompleted and DragOver handlers to initialize and perform the drag and drop process in the ListBox. We need DragDropCompleted to handle removing the items when item is dragged from ListBox. Also we use DragOver handler to disable drop over the ListBox when drag has started from the same LisBox:



```C#
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
```



```VB.NET
	DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized))           
	DragDropManager.AddDragOverHandler(Me, New Telerik.Windows.DragDrop.DragEventHandler(AddressOf OnListDragOver))
	DragDropManager.AddDragDropCompletedHandler(Me, New DragDropCompletedEventHandler(AddressOf(DragDropComplete))
	
	Private Sub OnDrop(sender As Object, args As Telerik.Windows.DragDrop.DragEventArgs)
	 Dim listBoxItems = DirectCast(SampleListBox.ItemsSource, IList)
	 Dim draggedItems = DirectCast(args.Data, ScheduleViewDragDropPayload).DraggedAppointments
	 For Each item As Object In draggedItems
	  If Not listBoxItems.Contains(item) Then
	   listBoxItems.Add(item)
	  End If
	 Next
	End Sub
	Private Sub OnDragInitialize(sender As Object, args As DragInitializeEventArgs)
	 Dim listBoxItem = DirectCast(args.Source, System.Windows.Controls.ListBoxItem)
	 Dim listbox = listBoxItem.ParentOfType(Of System.Windows.Controls.ListBox)()
	 Dim appointments As IList(Of IOccurrence) = listbox.SelectedItems.OfType(Of IOccurrence)().ToList()
	 If appointments.Count = 0 Then
	  Return
	 End If
	 args.Data = New ScheduleViewDragDropPayload(listbox.ItemsSource, appointments)
	 Dim dragVisual = New TextBlock()
	 dragVisual.SetBinding(TextBlock.TextProperty, New System.Windows.Data.Binding("DraggedAppointment") With { _
	  Key .Source = args.Data _
	 })
	 args.DragVisual = dragVisual
	 args.AllowedEffects = DragDropEffects.All
	End Sub
	Private Sub OnDragDropComplete(sender As Object, args As DragDropCompletedEventArgs)
	 Dim payload = DirectCast(args.Data, ScheduleViewDragDropPayload)
	 Dim sourceItems = DirectCast(payload.SourceAppointmentsSource, IList)
	 For Each item As Object In payload.DraggedAppointments
	  sourceItems.Remove(item)
	 Next
	End Sub
	Private Sub OnListDragOver(sender As Object, args As Telerik.Windows.DragDrop.DragEventArgs)
	 If DirectCast(sender, System.Windows.Controls.ListBox).ItemsSource = DirectCast(args.Data, ScheduleViewDragDropPayload).SourceAppointmentsSource Then
	  args.Effects = DragDropEffects.None
	 End If
	 args.Handled = True
	End Sub
```

Finally, we add a ScheduleView and bind it to a sample data:



```XAML
	<telerik:RadScheduleView x:Name="ScheduleView">
	    <telerik:RadScheduleView.ViewDefinitions>
	         <telerik:MonthViewDefinition />
	    </telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
```



```C#
	ScheduleView.AppointmentsSource = new ObservableCollection<Appointment>(
	                from c in Enumerable.Range(0, 10)
	                select new Appointment { Start = DateTime.Now.AddDays(c % 5), End = DateTime.Now.AddDays(c % 5).AddHours(2), Subject = "Event " + c });
```



```VB.NET
	ScheduleView.AppointmentsSource = New ObservableCollection(Of Appointment)(From c In Enumerable.Range(0, 10)New Appointment() With { _
	 Key .Start = DateTime.Now.AddDays(c Mod 5), _
	 Key .[End] = DateTime.Now.AddDays(c Mod 5).AddHours(2), _
	 Key .Subject = "Event " & Convert.ToString(c) _
	})
```

The resultant application should look as follows:

![{{ site.framework_name }} Drag Drop ScheduleView to ListBox](images/DragDropManager_ScheduleViewToListBox.png)
