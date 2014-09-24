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

#region radbook-navigating_0
	private void NextButton_Click(object sender, System.Windows.RoutedEventArgs e)
	{
		RadBook1.RightPageIndex += 2;
	}
#endregion
}
