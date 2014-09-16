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

#region radchart-features-annotations-custom-line_1
CustomLine customLine = new CustomLine();
customLine.Slope = 2.66;
customLine.YIntercept = -3.32;
customLine.MinX = 2;
customLine.MinY = 2;
customLine.MaxX = 5;
customLine.MaxY = 10;
customLine.Stroke = new SolidColorBrush( Colors.Red );
customLine.StrokeThickness = 2;
this.radChart.DefaultView.ChartArea.Annotations.Add( customLine );
#endregion
}
