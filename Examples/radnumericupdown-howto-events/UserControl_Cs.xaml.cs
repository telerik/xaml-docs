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

#region radnumericupdown-howto-events_0
public void Events()
        {
            RadNumericUpDown numeric = new RadNumericUpDown();
            numeric.ValueChanged += new RoutedPropertyChangedEventHandler<double>(OnNumericValueChanged);
            numeric.Value = 10;
        }
        private void OnNumericValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
             RadWindow.Alert(String.Format("New value: {0}, Old value: {1}", e.NewValue, e.OldValue));
        }
#endregion
}
