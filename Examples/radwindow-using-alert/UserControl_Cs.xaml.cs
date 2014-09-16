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

#region radwindow-using-alert_0
1. RadWindow.Alert(DialogParameters dialogParameters);
2. RadWindow.Alert(object content);
3. RadWindow.Alert(object content, EventHandler<WindowClosedEventArgs> closed)
#endregion

#region radwindow-using-alert_2
public void Alert()
        {
            RadWindow.Alert(new DialogParameters
            {
                Header = "Alert Message",
                Closed = new EventHandler<WindowClosedEventArgs>(OnDialogClosed),
                Opened = new EventHandler(OnDialogOpened),
                Content = "Are you sure you want to do this?",
                IconContent = "",
                OkButtonContent = "Yes",
                CancelButtonContent = "No",
            });
        }
        private void OnDialogClosed(object sender, WindowClosedEventArgs e)
        {
            RadWindow.Alert(String.Format("DialogResult: {0}", e.DialogResult));
        }
        private void OnDialogOpened(Object sender, EventArgs e)
        {
            RadWindow alert = sender as RadWindow;
            alert.DialogResult = true;
            alert.Close();
        }
#endregion
}
