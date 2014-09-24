using System;
using System.Collections.ObjectModel;

namespace BlackoutDatesExample
{
	public class MyViewModel
	{
#region radcalendar-features-blackoutdates_0
public ObservableCollection<DateTime> BlackoutDates { get; set; }
#endregion

#region radcalendar-features-blackoutdates_1
public MyViewModel()
{
	this.BlackoutDates = new ObservableCollection<DateTime>()
    {
		new DateTime(2012, 8, 6),
		new DateTime(2012, 8, 7),
		new DateTime(2012, 8, 8),
		new DateTime(2012, 8, 9),
		new DateTime(2012, 8, 10),
		new DateTime(2012, 8, 11),
		new DateTime(2012, 8, 12),
		new DateTime(2012, 8, 20),
		new DateTime(2012, 8, 21),
		new DateTime(2012, 8, 22),
		new DateTime(2012, 8, 23),
		new DateTime(2012, 8, 24),
		new DateTime(2012, 8, 25),
		new DateTime(2012, 8, 26),
    };
}
#endregion
	}
}

