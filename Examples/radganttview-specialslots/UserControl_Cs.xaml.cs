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

#region radganttview-specialslots_2
public class CustomRangeGenerator : ViewModelBase, IRangeGenerator
{
	public System.Collections.Generic.IEnumerable<IDateRange> GetRanges(IDateRange visibleRange)
	{
		for (DateTime current = visibleRange.Start; current < visibleRange.End; current += TimeSpan.FromDays(1))
		{
			int addDays = (int)current.DayOfWeek;
			if (addDays < 7 && (int)current.DayOfWeek % 2 != 0)
			{						
				yield return new DateRange(current, current.AddDays(1));
				addDays = addDays + 1;
			}
		}
	}
}

#endregion

}
