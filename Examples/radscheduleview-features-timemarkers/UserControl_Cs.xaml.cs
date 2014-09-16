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

#region radscheduleview-features-timemarkers_1
public class MyViewModel : ViewModelBase
{
	public ObservableCollection<Appointment> Appointments { get; set; }
	public ObservableCollection<TimeMarker> TimeMarkers { get; set; }

	public MyViewModel()
	{
		this.Appointments = new ObservableCollection<Appointment>();
		this.TimeMarkers = new ObservableCollection<TimeMarker>() {
			new TimeMarker("Busy", new SolidColorBrush( Colors.Red ) ),
			new TimeMarker("Free", new SolidColorBrush( Colors.Green ) )
		};
	}
}
#endregion


#region radscheduleview-features-timemarkers_2
newApp.TimeMarker = (scheduleView.TimeMarkersSource as TimeMarkerCollection).Where(p => p.TimeMarkerName == "Busy").First();
#endregion

#region radscheduleview-features-timemarkers_4
this.DataContext = new MyViewModel();
#endregion
	}
}
