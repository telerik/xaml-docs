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

#region radrichtextbox-features-commands_1
public CommandsSample()
{
    InitializeComponent();
    this.radRichTextBox.Commands.ToggleBoldCommand.ToggleStateChanged += this.ToggleBoldCommand_ToggleStateChanged;
}
public void ToggleBoldCommand_ToggleStateChanged( object sender, StylePropertyChangedEventArgs<bool> e )
{
    this.BoldButton.IsChecked = e.NewValue;
}
#endregion

#region radrichtextbox-features-commands_4
    this.radRichTextBox.RegisteredApplicationCommands.Remove(ApplicationCommands.Save);
#endregion

#region radrichtextbox-features-commands_5
    this.radRichTextBox.RegisteredApplicationCommands.Add(ApplicationCommands.Save);
#endregion

#region radrichtextbox-features-commands_6
    this.radRichTextBox.PreviewEditorKeyDown += (sender, e) =>
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && e.Key == Key.S)
            {
                e.SuppressDefaultAction = true;
            }
        };
#endregion
}
