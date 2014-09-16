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

#region radslider-ticks-and-tick-frequency_1
RadSlider radSlider1 = new RadSlider();
radSlider1.Maximum = 10;
DoubleCollection tickCollection = new DoubleCollection();
tickCollection.Add(3);
tickCollection.Add(5);
tickCollection.Add(7);
radSlider1.Ticks = tickCollection;
radSlider1.TickPlacement = TickPlacement.TopLeft;
LayoutRoot.Children.Add(radSlider1);
#endregion
}
