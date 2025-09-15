---
title: Load on Demand
page_title: Load on Demand
description: This article demonstrates how to load only the appointments in the visible range of the RadScheduleView {{ site.framework_name }} control.
slug: scheduleview-features-loadondemand
tags: load,on,demand,with,radscheduleview
published: True
position: 2
---

# Load on Demand

This article demonstrates how you can load the appointments in RadScheduleView depending on the current visible range of the control. This can be very useful in scenarios where the number of appointments is very large.

There are two possible approaches to accomplish this:

**1.** Using the __VisibleRangeChanged__ event.

**2.** Using the __VisibleRangeChangedCommand__ and __VisibleRangeChangedCommandParameter__ properties. This approach is effective if you wish to load the visible appointments in an MVVM-friendly manner.

## Using the VisibleRangeChanged Event

To accomplish this approach, you only need to handle the VisibleRangeChanged and create a helper method to get the appointments for a particular **DateSpan**. Please note that you need to start with an initial collection of appointments.

__Example 1: Handling the VisibleRangeChanged event__

```C#
	private void ScheduleView_Loaded(object sender, RoutedEventArgs e)
	{
		this.scheduleView.AppointmentsSource = this.GenerateAppointmentsForRange(new DateSpan(DateTime.Now, DateTime.Now.AddDays(2)));
		this.scheduleView.VisibleRangeChanged += ScheduleView_VisibleRangeChanged;
	}

	private void ScheduleView_VisibleRangeChanged(object sender, EventArgs e)
	{
		var scheduleView = sender as RadScheduleView;
		var range = scheduleView.VisibleRange;
		scheduleView.AppointmentsSource = this.GenerateAppointmentsForRange(range);
	}

	private ObservableCollection<Appointment> GenerateAppointmentsForRange(IDateSpan dateSpan)
	{
		ObservableCollection<Appointment> newSource = new ObservableCollection<Appointment>();

		newSource.AddRange(
			from i in Enumerable.Range(0, (dateSpan.End - dateSpan.Start).Days * 24)
			select new Appointment()
			{
				Subject = "Appointment" + i + " " + dateSpan.Start.AddHours(i).ToShortDateString(),
				Start = dateSpan.Start.AddHours(i),
				End = dateSpan.Start.AddHours(i + 1),
			});

		return newSource;
	}
```
```VB.NET
	Private Sub ScheduleView_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Me.scheduleView.AppointmentsSource = Me.GenerateAppointmentsForRange(New DateSpan(DateTime.Now, DateTime.Now.AddDays(2)))
		Me.scheduleView.VisibleRangeChanged += ScheduleView_VisibleRangeChanged
	End Sub

	Private Sub ScheduleView_VisibleRangeChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim scheduleView = TryCast(sender, RadScheduleView)
		Dim range = scheduleView.VisibleRange
		scheduleView.AppointmentsSource = Me.GenerateAppointmentsForRange(range)
	End Sub

	Private Function GenerateAppointmentsForRange(ByVal dateSpan As IDateSpan) As ObservableCollection(Of Appointment)
		Dim newSource As New ObservableCollection(Of Appointment)()

		newSource.AddRange(
			From i In Enumerable.Range(0, (dateSpan.End - dateSpan.Start).Days * 24)
			Select New Appointment() With {
				.Subject = "Appointment" & i & " " & dateSpan.Start.AddHours(i).ToShortDateString(),
				.Start = dateSpan.Start.AddHours(i),
				.End = dateSpan.Start.AddHours(i + 1)
			})

		Return newSource
	End Function
```

## Using the VisibleRangeChangedCommand

Alternatively, if you want to follow the MVVM pattern, you can create an appropriate command in your viewmodel and set it as the **VisibleRangeChangedCommand** of the RadScheduleView control.

For example, you can define your viewmodel as shown in **Example 2**.

__Example 2: The ViewModel class__

```C#
	public class ViewModel : ViewModelBase
	{
		private ICommand visibleRangeChanged;
		private ObservableCollection<Appointment> appointments;

		public ViewModel()
		{
			this.Appointments = this.GenerateAppointmentsForRange(new DateSpan(DateTime.Now, DateTime.Now.AddDays(2)));
			this.VisibleRangeChanged = new DelegateCommand(this.OnVisibleRangeExecuted, this.OnVisibleRangeCanExecute);
		}

		public ObservableCollection<Appointment> Appointments
		{
			get
			{
				return this.appointments;
			}
			private set
			{
				this.appointments = value;
				this.OnPropertyChanged("Appointments");
			}
		}

		public ICommand VisibleRangeChanged
		{
			get
			{
				return this.visibleRangeChanged;
			}
			set
			{
				this.visibleRangeChanged = value;
			}
		}

		private void OnVisibleRangeExecuted(object param)
		{
			// The param is bound to the VisibleRange property in XAML
			this.GenerateAppointments(param as IDateSpan);
		}

		private bool OnVisibleRangeCanExecute(object param)
		{
			return param != null;
		}

		private void GenerateAppointments(IDateSpan dateSpan)
		{
			ObservableCollection<Appointment> newSource = new ObservableCollection<Appointment>();

			newSource.AddRange(
				from i in Enumerable.Range(0, (dateSpan.End - dateSpan.Start).Days * 24)
				select new Appointment()
				{
					Subject = "Appointment" + i + " " + dateSpan.Start.AddHours(i).ToShortDateString(),
					Start = dateSpan.Start.AddHours(i),
					End = dateSpan.Start.AddHours(i + 1),
				});

			this.Appointments = newSource;
		}
	}
```
```VB.NET
	Public Class ViewModel
		Inherits ViewModelBase

		Private _visibleRangeChanged As ICommand
		Private _appointments As ObservableCollection(Of Appointment)

		Public Sub New()
			Me.Appointments = Me.GenerateAppointmentsForRange(New DateSpan(DateTime.Now, DateTime.Now.AddDays(2)))
			Me.VisibleRangeChanged = New DelegateCommand(AddressOf Me.OnVisibleRangeExecuted, AddressOf Me.OnVisibleRangeCanExecute)
		End Sub

		Public Property Appointments() As ObservableCollection(Of Appointment)
			Get
				Return Me._appointments
			End Get
			Private Set(ByVal value As ObservableCollection(Of Appointment))
				Me._appointments = value
				Me.OnPropertyChanged("Appointments")
			End Set
		End Property

		Public Property VisibleRangeChanged() As ICommand
			Get
				Return Me._visibleRangeChanged
			End Get
			Set(ByVal value As ICommand)
				Me._visibleRangeChanged = value
			End Set
		End Property

		Private Sub OnVisibleRangeExecuted(ByVal param As Object)
			' The param is bound to the VisibleRange property in XAML
			Me.GenerateAppointments(TryCast(param, IDateSpan))
		End Sub

		Private Function OnVisibleRangeCanExecute(ByVal param As Object) As Boolean
			Return param IsNot Nothing
		End Function

		Private Sub GenerateAppointments(ByVal dateSpan As IDateSpan)
			Dim newSource As New ObservableCollection(Of Appointment)()

			newSource.AddRange(
				From i In Enumerable.Range(0, (dateSpan.End - dateSpan.Start).Days * 24)
				Select New Appointment() With {
					.Subject = "Appointment" & i & " " & dateSpan.Start.AddHours(i).ToShortDateString(),
					.Start = dateSpan.Start.AddHours(i),
					.End = dateSpan.Start.AddHours(i + 1)
				})

			Me.Appointments = newSource
		End Sub
	End Class
```

You can now bind the __VisibleRangeChangedCommand__ and __VisibleRangeChangedCommandParameter__ properties as demonstrated in **Example 3**.

__Example 3: Binding the VisibleRangeChangedCommand and VisibleRangeChangedCommandParameter properties__

```XAML
	<scheduleView:RadScheduleView x:Name="scheduleView"
								AppointmentsSource="{Binding Appointments}" 
								VisibleRangeChangedCommand="{Binding VisibleRangeChanged}"
								VisibleRangeChangedCommandParameter="{Binding  VisibleRange, RelativeSource={RelativeSource Self}}">
	...
	</scheduleView:RadScheduleView>
```

## See Also

* [Events]({%slug radscheduleview-events-overview%})
* [Implementing View-ViewModel]({%slug radscheduleview-populating-with-data-implementing-view-model%})