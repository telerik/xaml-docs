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

#region radbuttons-features-commands_0
public class SampleViewModel
{
   public SampleViewModel()
   {
   }
   public ICommand MyCommand
   {
       get;
       set;
   }
}
#endregion

#region radbuttons-features-commands_2
public Example()
{
   InitializeComponent();
   this.DataContext = new SampleViewModel();
}
#endregion
}
