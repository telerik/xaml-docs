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

#region radribbonview-howto-use-commands-with-radribbonview-buttons_1
public class ButtonViewModel
	{
		public ButtonViewModel()
		{
			this.MyCommand = new DelegateCommand(p => Execute(p), p => CanExecute(p));
		}

		public DelegateCommand MyCommand { get; set; }

		private bool CanExecute(object p)
		{
			if (p != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void Execute(object p)
		{
			MessageBox.Show("Executed: \n" + p.ToString());
		}
	}
#endregion

#region radribbonview-howto-use-commands-with-radribbonview-buttons_3
public Example()
{
    InitializeComponent();
    this.DataContext = new ButtonViewModel();
}
#endregion
s
}
