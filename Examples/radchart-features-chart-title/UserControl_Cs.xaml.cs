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

#region radchart-features-chart-title_1
radChart.DefaultView.ChartTitle.Content = "Monthly Sales for 2009";
#endregion

#region radchart-features-chart-title_4
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
....
Border border = new Border();
border.BorderThickness = new Thickness( 2 );
border.CornerRadius = new CornerRadius( 5 );
border.BorderBrush = new SolidColorBrush( Color.FromArgb( 255, 173, 216, 230 ) );
border.Child = new TextBlock(){ Text = "Monthly Sales for 2009" };
radChart.DefaultView.ChartTitle.Content = border;
#endregion
}
