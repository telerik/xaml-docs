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

#region radmaskedinput-features-selection_4
private void radMaskedTextInput_GotFocus( object sender, RoutedEventArgs e )
{
   radMaskedTextInput.SelectionStart = 2;
   radMaskedTextInput.SelectionLength = 2;
}
#endregion
}
