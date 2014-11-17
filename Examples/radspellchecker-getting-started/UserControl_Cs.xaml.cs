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

#region radspellchecker-getting-started_0
private void Button_Click(object sender, RoutedEventArgs e)
{
   RadSpellChecker.Check(this.textBox1, SpellCheckingMode.WordByWord);
}
#endregion
}
