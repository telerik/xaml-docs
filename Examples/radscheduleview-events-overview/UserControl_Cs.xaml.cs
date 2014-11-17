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

#region radscheduleview-events-overview_0
private void ScheduleView_DialogClosing(object sender, CancelRoutedEventArgs e)
{
    // cast to CloseDialogEventArgs
    var eventArgs = e as CloseDialogEventArgs;

    // you can get the DialogViewModel
    var currentDialogViewModel = eventArgs.DialogViewModel;

    // you can also cancel the event
    eventArgs.Cancel = true;
}
#endregion
}
