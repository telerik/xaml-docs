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

#region chart-customize-axis-appearance-through-style_2
Style customAxisYStyle = this.Resources["CustomAxisYStyle"] as Style;
Style customTickStyle = this.Resources["CustomTickStyle"] as Style;
Style customGridlineStyle = this.Resources["CustomGridlineStyle"] as Style;
Style customStriplineStyle = this.Resources["CustomStriplineStyle"] as Style;
Style customItemLabelStyle = this.Resources["CustomItemLabelStyle"] as Style;
Style customAxisTitleStyle = this.Resources["CustomAxisTitleStyle"] as Style;
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.AxisLineStyle = customAxisYStyle;
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.AxisLineStyle = customAxisYStyle;
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.TickLineStyle = customTickStyle;
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.TickLineStyle = customTickStyle;
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.GridLineStyle = customGridlineStyle;
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.GridLineStyle = customGridlineStyle;
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.StripLineStyle = customStriplineStyle;
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.StripLineStyle = customStriplineStyle;
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.ItemLabelStyle = customItemLabelStyle;
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.ItemLabelStyle = customItemLabelStyle;
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.TitleStyle = customAxisTitleStyle;
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.TitleStyle = customAxisTitleStyle;
RadChart1.ItemsSource = new int[] { 1, 5, 6, 9, 5, 7 };
#endregion
}
