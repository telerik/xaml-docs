using System;
using System.Linq;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Scheduling;

namespace ArticleGanttViewTimeRulerFiltering
{

#region radganttview-filteringtimeruleritems_1
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
