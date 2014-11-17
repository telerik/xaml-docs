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

#region create-ICommand_1
public interface ICommand
{
	event EventHandler CanExecuteChanged;

	bool CanExecute(object parameter);
	void Execute(object parameter);
}
#endregion

#region creating-RoutedCommand_2
public static RoutedUICommand MyCommand = new RoutedUICommand ("My Command Text", "MyCommand", typeof(MainPage));

#endregion

#region handle-commands_3
		public MainPage()
		{
			InitializeComponent();

			CommandManager.AddCanExecuteHandler(this, OnCommandCanExecute);
			CommandManager.AddExecutedHandler(this, OnCommandExecuted);
		}

		private void OnCommandExecuted(object sender, ExecutedRoutedEventArgs e)
		{
			//TODO: Add code that will act when the command is executed.
			e.Handled = true;
		}

		private void OnCommandCanExecute(object sender, ExecutedRoutedEventArgs e)
		{
			//Whether a command can currently execute will depend on the application logic:
			e.CanExecute = true;
			e.Handled = true;
		}
#endregion

#region update-CanExecute_4
		CommandManager.InvalidateRequerySuggested();
#endregion
}
