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

#region raddatetimepicker-features-clock-items_1
public ClockItemsSample()
{
    InitializeComponent();
    this.radDateTimePicker.ClockItemsSource = this.LoadDataObjects();
}
public ObservableCollection<TimeSpan> LoadDataObjects()
{
    ObservableCollection<TimeSpan> times = new ObservableCollection<TimeSpan>()
    {
        new TimeSpan(9,0,0),
        new TimeSpan(10,0,0),
        new TimeSpan(10,5,0),
        new TimeSpan(10,22,0),
        new TimeSpan(13,15,0)
    };
    return times;
}
#endregion
}
