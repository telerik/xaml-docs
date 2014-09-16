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

#region radchart-howto-create-location-crosshair-for-radchart_0
private void OnChartLoaded(object sender, RoutedEventArgs e)
{
	var plotAreaPanel = this.chart.DefaultView.ChartArea.ChildrenOfType<ClipPanel>().FirstOrDefault();
	plotAreaPanel.MouseEnter += this.OnPlotAreaPanelMouseEnter;
	plotAreaPanel.MouseMove += this.OnPlotAreaPanelMouseMove;
	plotAreaPanel.MouseLeave += this.OnPlotAreaPanelMouseLeave;
}
#endregion

#region radchart-howto-create-location-crosshair-for-radchart_2
private void OnPlotAreaPanelMouseEnter(object sender, MouseEventArgs e)
{
	this.chart.DefaultView.ChartArea.Annotations.Add(xGridLine);
	this.chart.DefaultView.ChartArea.Annotations.Add(yGridLine);
}

private void OnPlotAreaPanelMouseMove(object sender, MouseEventArgs e)
{
	var plotAreaPanel = sender as ClipPanel;
	var position = e.GetPosition(plotAreaPanel);

	var x = this.chart.DefaultView.ChartArea.AxisX.ConvertPhysicalUnitsToData(position.X);
	var y = this.chart.DefaultView.ChartArea.AxisY.ConvertPhysicalUnitsToData(position.Y);

	xGridLine.XIntercept = x;
	yGridLine.YIntercept = y;

	this.textX.Text = string.Format("X: {0:N2}", x);
	this.textY.Text = string.Format("Y: {0:N2}", y);
}

private void OnPlotAreaPanelMouseLeave(object sender, MouseEventArgs e)
{
	this.chart.DefaultView.ChartArea.Annotations.Remove(xGridLine);
	this.chart.DefaultView.ChartArea.Annotations.Remove(yGridLine);
}
#endregion
}
