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

#region radwindow-features-predefined-dialogs_0
RadWindow.Alert( new DialogParameters()
{
    Content = "Hello"
} );
#endregion

#region radwindow-features-predefined-dialogs_2
RadWindow.Alert( "Hello" );
#endregion

#region radwindow-features-predefined-dialogs_4
public void ShowAlert()
{
    RadWindow.Alert( "Hello", this.OnClosed );
}
private void OnClosed( object sender, WindowClosedEventArgs e )
{
}
#endregion

#region radwindow-features-predefined-dialogs_6
DialogParameters parameters = new DialogParameters();
parameters.Content = "Enter your name:";
RadWindow.Prompt( parameters );
#endregion

#region radwindow-features-predefined-dialogs_8
public void ShowPrompt()
{
    RadWindow.Prompt( "Enter your name:", this.OnClosed );
}
private void OnClosed( object sender, WindowClosedEventArgs e )
{
}
#endregion

#region radwindow-features-predefined-dialogs_10
public void SHowPrompt()
{
    RadWindow.Prompt( "Enter your name:", this.OnClosed, "John Doe" );
}
private void OnClosed( object sender, WindowClosedEventArgs e )
{
}
#endregion

#region radwindow-features-predefined-dialogs_12
DialogParameters parameters = new DialogParameters();
parameters.Content = "Are you sure?";
RadWindow.Confirm( parameters );
#endregion

#region radwindow-features-predefined-dialogs_14
public void ShowConfirm()
{
    RadWindow.Confirm( "Are you sure?", this.OnClosed );
}
private void OnClosed( object sender, WindowClosedEventArgs e )
{
}
#endregion

#region radwindow-features-predefined-dialogs_16
public MainWindow()
{
    InitializeComponent();

    var window = new RadWindow();
    window.PreviewClosed += window_PreviewClosed;
    window.Show();            
}

void window_PreviewClosed(object sender, WindowPreviewClosedEventArgs e)
{
    bool? dialogResult = null;
    RadWindow.Confirm(new DialogParameters()
    {
        Content = "Are you sure",
        Closed = (confirmDialog, eventArgs) =>
        {
            dialogResult = eventArgs.DialogResult;
        }
    });

    e.Cancel = !dialogResult;
}
#endregion
}
