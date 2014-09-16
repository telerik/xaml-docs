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

#region radchart-features-chart-extensions_0
public interface IExtension<T>
where T : IExtensibleObject<T>
{
   void Attach(T owner);
   void Detach(T owner);
}
#endregion

#region radchart-features-chart-extensions_2
private void UserControl_Loaded(object sender, RoutedEventArgs e)
{
   CameraExtension cameraExtension = new CameraExtension();
   radChart.DefaultView.ChartArea.Extensions.Add(cameraExtension);
}
private void UserControl_Unloaded(object sender, RoutedEventArgs e)
{
   radChart.DefaultView.ChartArea.Extensions.Clear();
}
#endregion
}
