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

#region radwindow-using-confirm_0
1. RadWindow.Confirm(DialogParameters dialogParameters);
2. RadWindow.Confirm(object content, EventHandler<WindowClosedEventArgs> closed)
#endregion

#region radwindow-using-confirm_2
public void Confirm()
        {
            RadWindow.Confirm(new DialogParameters
            {
                Header = "Confirm",
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
