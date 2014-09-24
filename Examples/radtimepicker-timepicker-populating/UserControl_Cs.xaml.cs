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

#region radtimepicker-timepicker-populating_0
timePicker.SelectedTime = new TimeSpan(3,0,0);
#endregion

#region radtimepicker-timepicker-populating_2
public DataBinding()
        {
            this.radTimePicker.ClockItemSource = this.LoadDataObjects(); 
        }
public ObservableCollection<TimeSpan> LoadDataObjects()
        {
            ObservableCollection<TimeSpan> times = new ObservableCollection<TimeSpan>()
            { 
               new TimeSpan(9,0,0),
               new TimeSpan(10,0,0),
               new TimeSpan(10,5,0),
               new TimeSpan(10,22,0),
            };
            return times;
        }
#endregion
}
