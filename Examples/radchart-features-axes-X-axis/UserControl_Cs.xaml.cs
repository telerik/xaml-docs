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

#region radchart-features-axes-X-axis_1
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
radChart.DefaultView.ChartArea.AxisX.IsDateTime = true;
radChart.DefaultView.ChartArea.AxisX.Step = 5;
radChart.DefaultView.ChartArea.AxisX.LabelStep = 2;
radChart.DefaultView.ChartArea.AxisX.StepLabelLevelCount = 3;
radChart.DefaultView.ChartArea.AxisX.StepLabelLevelHeight = 10;
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
....
SeriesMapping sm = new SeriesMapping();
sm.SeriesDefinition = new SplineSeriesDefinition();
....
sm.ItemMappings.Add( new ItemMapping( "Date", DataPointMember.XValue ) );
sm.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
radChart.SeriesMappings.Add( sm );
#endregion

#region radchart-features-axes-X-axis_4
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
radChart.DefaultView.ChartArea.AxisX.AutoRange = true;
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
....
SeriesMapping sm = new SeriesMapping();
sm.SeriesDefinition = new SplineSeriesDefinition();
....
sm.ItemMappings.Add( new ItemMapping( "Date", DataPointMember.XValue ) );
sm.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
radChart.SeriesMappings.Add( sm );
#endregion

#region radchart-features-axes-X-axis_7
....
radChart.DefaultView.ChartArea.AxisX.TicksDistance = 15;
....
#endregion

#region radchart-features-axes-X-axis_10
....
radChart.DefaultView.ChartArea.AxisX.AutoRange = false;
radChart.DefaultView.ChartArea.AxisX.MinValue = new DateTime( 2009, 1, 1 ).ToOADate();
radChart.DefaultView.ChartArea.AxisX.MaxValue = new DateTime( 2009, 3, 31 ).ToOADate();
radChart.DefaultView.ChartArea.AxisX.Step = 5;
radChart.DefaultView.ChartArea.AxisX.LabelStep = 2;
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
....
#endregion
}
