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

#region radspellchecker-spellchecking-gridcell_1
private void spellcheckBButton_Click(object sender, RoutedEventArgs e)
{
    RadGridViewSpellCheckHelper.CheckChildControl(this.radGridView, "textBox1");
}
#endregion
}
