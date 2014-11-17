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

#region radchart-features-annotations-custom-gridline_1
CustomGridLine gridline = new CustomGridLine();
gridline.YIntercept = 150;
gridline.Stroke = new SolidColorBrush( Colors.Red );
gridline.StrokeThickness = 2;
this.radChart.DefaultView.ChartArea.Annotations.Add( gridline );
#endregion
}
