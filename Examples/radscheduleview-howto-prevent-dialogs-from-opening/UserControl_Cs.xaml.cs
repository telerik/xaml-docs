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

#region radscheduleview-howto-prevent-dialogs-from-opening_1
private void RadScheduleView_ShowDialog(object sender, ShowDialogEventArgs e)
{
    if (e.DialogViewModel is AppointmentDialogViewModel)
        e.Cancel = true;
}
#endregion

#region radscheduleview-howto-prevent-dialogs-from-opening_3
private void RadScheduleView_ShowDialog(object sender, ShowDialogEventArgs e)
{
    if (e.DialogViewModel is ConfirmDialogViewModel)
    {
        e.DefaultDialogResult = true;
        e.Cancel = true;
    }
}
#endregion

#region radscheduleview-howto-prevent-dialogs-from-opening_5
private void RadScheduleView_ShowDialog(object sender, ShowDialogEventArgs e)
{
    var dialogViewModel = e.DialogViewModel as RecurrenceChoiceDialogViewModel;
    if (dialogViewModel != null)
    {
        dialogViewModel.IsSeriesModeSelected = true;
    }
}
#endregion
}
