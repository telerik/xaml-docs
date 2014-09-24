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

#region scheduleview-features-loadondemand_1
private void scheduleView_VisibleRangeChanged(object sender, System.EventArgs e)
{
 var range = (sender as RadScheduleView).VisibleRange;
 }
#endregion

#region scheduleview-features-loadondemand_3
private void scheduleView_VisibleRangeChanged(object sender, System.EventArgs e)
{
   var range = (sender as RadScheduleView).VisibleRange;
   this.LoadAppointmentsByRange(range);
}
#endregion

#region scheduleview-features-loadondemand_5
private ICommand visibleRangeChanged;
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
#endregion

#region scheduleview-features-loadondemand_6
private ICommand visibleRangeChanged;
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
public RadScheduleViewViewModel ()
  {
   this.VisibleRangeChanged = new DelegateCommand(this.VisibleRangeExecuted, this.CanVisibleRangeCanExecuted);
  }
private void VisibleRangeExecuted(object param)
  {
   // param is the value of the VisibleRange property. It is used to get the appointments only for the visual range.
   this.LoadAppointmentsByRange(param as DateSpan);
  }
private bool CanVisibleRangeCanExecuted(object param)
  {
   return param != null;
  }
#endregion
}
