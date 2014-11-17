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

#region radwindow-using-prompt_0
1. RadWindow.Prompt(DialogParameters dialogParameters);
2. RadWindow.Prompt(object content, EventHandler<WindowClosedEventArgs> closed)
3. RadWindow.Prompt(object content, EventHandler<WindowClosedEventArgs> closed, string defaultPromptResult);
#endregion

#region radwindow-using-prompt_2
public void Prompt()
        {
            RadWindow.Prompt(new DialogParameters
            {
                Header = "Prompt message",
                Closed = new EventHandler<WindowClosedEventArgs>(OnDialogClosed),
                Opened = new EventHandler(OnDialogOpened),
                Content = "How many items do you need?",
                DefaultPromptResultValue = "5",
                IconContent = "",
                OkButtonContent = "Accept",
                CancelButtonContent = "Reject",
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
