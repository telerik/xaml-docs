using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls.Calendar;

namespace CalendarDayButtonStyle
{
#region radcalendar-styling-and-appearance-daybuttonstyleselector-1
public class DayButtonStyleSelector : StyleSelector
{ 
}
#endregion

#region radcalendar-styling-and-appearance-daybuttonstyleselector-2
public class DayButtonStyleSelector : StyleSelector
{
    public Style SpecialStyleMonday { get; set; }
}
#endregion

#region radcalendar-styling-and-appearance-daybuttonstyleselector-3
public class DayButtonStyleSelector : StyleSelector
{
    public Style SpecialStyleMonday { get; set; }

    public override Style SelectStyle(object item, DependencyObject container)
    {
        CalendarButtonContent content = item as CalendarButtonContent;
        if (content != null)
        {
            if (content.Date.DayOfWeek == DayOfWeek.Monday && content.ButtonType == CalendarButtonType.Date)
            {
                return SpecialStyleMonday;
            }
        }
        return base.SelectStyle(item, container);
    }
}
#endregion

}

