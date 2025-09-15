---
title: Hide Zero Values Labels in PieChart
page_title: Remove Zero Values Labels in PieChart
description: This article described how to hide zero segments labels in PieChart.
slug: radchartview-troubleshooting-hide-zero-segments-labels
tags: troubleshooting,howto,zero,piechart,label,pieseries,slice,hide,remove,segments
published: True
position: 0
---

# Hide Zero Segments Labels in PieChart 

There are different ways to hide/remove the labels of the zero segments inside __PieChart__. This article will describe how to hide them by setting the __Opacity__ property of the TextBlock which holds the label. __Example 1__ demonstrate a basic scenario where the label of the zero segments will appear. 

__Example 1: Declaring PieSeries in XAML__
```XAML	
	<telerik:RadPieChart Palette="Windows8">
		<telerik:PieSeries ValueBinding="Value" >
			<telerik:PieSeries.DataPoints>
				<telerik:PieDataPoint  Value="43.46"/>
				<telerik:PieDataPoint  Value="27.53"/>
				<telerik:PieDataPoint  Value="15.11"/>
				<telerik:PieDataPoint  Value="10.35"/>
				<telerik:PieDataPoint  Value="0"/>
			</telerik:PieSeries.DataPoints>                
			<telerik:PieSeries.LabelConnectorsSettings>
				<telerik:ChartSeriesLabelConnectorsSettings/>
			</telerik:PieSeries.LabelConnectorsSettings>                
			<telerik:PieSeries.LabelDefinitions>
				<telerik:ChartSeriesLabelDefinition Margin="-20">
					<telerik:ChartSeriesLabelDefinition.Template>
						<DataTemplate>
							<TextBlock Text="{Binding Value}" />
						</DataTemplate>
					</telerik:ChartSeriesLabelDefinition.Template>
				</telerik:ChartSeriesLabelDefinition>
			</telerik:PieSeries.LabelDefinitions>
		</telerik:PieSeries>
	</telerik:RadPieChart>
```

![{{ site.framework_name }} RadChartView Pie Chart Default Zero Label](images/chartview-howto-pieseries-hide-zero-labels.png)

The next step is to bind the __Opacity__ property to the slice value and apply custom __IValueConverter__ class. In the __Convert()__ method you can get the current value. If the value is zero you can return 0 to hide the label.

__Example 2: Custom IValueConverter__
```XAML	
	public class OpacityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double slicesValue = double.Parse(value.ToString());
			if( slicesValue == 0 )
			{
				return 0;
			}
			return 1;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
```

__Example 3: Apply the IValueConverter to the Opacity property binding__
```C#	
	<Window.Resources>
		<local:OpacityConverter x:Key="OpacityConverter"/>
	</Window.Resources>
	<Grid>
		<telerik:RadPieChart Palette="Windows8">
			<telerik:PieSeries ValueBinding="Value" >
				<telerik:PieSeries.DataPoints>
					<telerik:PieDataPoint  Value="43.46"/>
					<telerik:PieDataPoint  Value="27.53"/>
					<telerik:PieDataPoint  Value="15.11"/>
					<telerik:PieDataPoint  Value="10.35"/>
					<telerik:PieDataPoint  Value="0"/>
				</telerik:PieSeries.DataPoints>
				<telerik:PieSeries.LabelConnectorsSettings>
					<telerik:ChartSeriesLabelConnectorsSettings/>
				</telerik:PieSeries.LabelConnectorsSettings>
				<telerik:PieSeries.LabelDefinitions>
					<telerik:ChartSeriesLabelDefinition Margin="-20">
						<telerik:ChartSeriesLabelDefinition.Template>
							<DataTemplate>
								<TextBlock Text="{Binding Value}" Opacity="{Binding Value,Converter={StaticResource OpacityConverter}}"/>
							</DataTemplate>
						</telerik:ChartSeriesLabelDefinition.Template>
					</telerik:ChartSeriesLabelDefinition>
				</telerik:PieSeries.LabelDefinitions>
			</telerik:PieSeries>
		</telerik:RadPieChart>
	</Grid>
```

![{{ site.framework_name }} RadChartView Pie Chart No Zero Label](images/chartview-howto-pieseries-hide-zero-no-labels.png)

The label is now hidden but the label connector is still visible. To remove the connector you can create a custom class which derives from PieSeries and override the GetLabelConnector() method (as demonstrated in [this article]({%slug radchartview-features-label-connectors%}))

__Example 4: Override the GetLabelConnector method of PieSeries__
```C#	
	public class CustomPieSeries : PieSeries
	{
		protected override List<Point> GetLabelConnector(ChartSeriesLabelPositionInfo info)
		{
			var label = info.DataPoint.Label.ToString();
			if(label == "0%")
			{
				return new List<Point>() { new Point(), new Point() };
			}           
			return base.GetLabelConnector(info);
		}
	}
```

Now you can just replace the PieSeries in __Example 3__  with your custom class.

__Example 5: Replace the PieSeries with the custom class__
```XAML	
	<Window.Resources>
		<local:OpacityConverter x:Key="OpacityConverter"/>
	</Window.Resources>
	<Grid>
		<telerik:RadPieChart Palette="Windows8">
			<local:CustomPieSeries ValueBinding="Value" >
					<local:CustomPieSeries.DataPoints>
					<telerik:PieDataPoint  Value="43.46"/>
					<telerik:PieDataPoint  Value="27.53"/>
					<telerik:PieDataPoint  Value="15.11"/>
					<telerik:PieDataPoint  Value="10.35"/>
					<telerik:PieDataPoint  Value="0"/>
				</local:CustomPieSeries.DataPoints>
					<local:CustomPieSeries.LabelConnectorsSettings>
					<telerik:ChartSeriesLabelConnectorsSettings/>
				</local:CustomPieSeries.LabelConnectorsSettings>
					<local:CustomPieSeries.LabelDefinitions>
					<telerik:ChartSeriesLabelDefinition Margin="-20">
						<telerik:ChartSeriesLabelDefinition.Template>
							<DataTemplate>
								<TextBlock Text="{Binding Value}" Opacity="{Binding Value,Converter={StaticResource OpacityConverter}}"/>
							</DataTemplate>
						</telerik:ChartSeriesLabelDefinition.Template>
					</telerik:ChartSeriesLabelDefinition>
				</local:CustomPieSeries.LabelDefinitions>
			</local:CustomPieSeries>
		</telerik:RadPieChart>
	</Grid>
```

![{{ site.framework_name }} RadChartView Pie Chart No Zero Label or Connector](images/chartview-howto-pieseries-hide-zero-no-labels-no-connectors.png)

### See Also

* [Label Connectors]({%slug radchartview-features-label-connectors%})
* [PieSeries]({%slug radchartview-series-pieseries%})
* [DoughnutSeries]({%slug radchartview-series-doughnutseries%})