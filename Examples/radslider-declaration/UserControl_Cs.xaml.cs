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

#region radslider-declaration_1
RadSlider slider = new RadSlider();
slider.Maximum = 100;
slider.Minimum = 0;
slider.Value = 5;
slider.SmallChange = 1;
#endregion
}
