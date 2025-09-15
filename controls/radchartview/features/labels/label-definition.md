---
title: Series Labels
page_title: Label Definition
description: Check our &quot;Label Definition&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-label-definition
tags: label,definition
published: True
position: 0
---

# Series Labels

The __RadChartView__ control exposes a mechanism to display and customize series labels.

To display labels for the data points in the chart series, set the series' __ShowLabels__ property to __True__.

__Example 1: Enabling Labels__
```XAML
	<telerik:BarSeries ShowLabels="True" />
```

#### Figure 1: Series labels
![{{ site.framework_name }} RadChartView Series labels](images/radchartview-features-label-definition-0.png)

## Customizing Labels

To customize the labels of the chart series, you can use the __ChartSeriesLabelDefinition__ element. The definition describes the label settings and it is used in the __LabelDefinitions__ collection of the chart series. One series can contain multiple definitions. Each data point will get a label for each label definition in the collection. For example, if the collection contains 2 definitions, 2 labels will be displayed per a data point visual.

The following example shows how to setup the chart in a data binding scenario and use ChartSeriesLabelDefinition to display custom labels.

__Example 2: Defining data point model__
```C#
	public class PlotInfo
	{
		public string Category { get; set; }
		public double Value { get; set; }
		public string Label { get; set; }
	}
```

__Example 3: Populating with data__
```C#
	public MyUserControl()
	{
		InitializeComponent();
		var source = new ObservableCollection<PlotInfo>();
		source.Add(new PlotInfo() { Category = "A", Value = 10, Label = "Second Label A" });
		source.Add(new PlotInfo() { Category = "B", Value = 5, Label = "Second Label B" });
		source.Add(new PlotInfo() { Category = "C", Value = 14, Label = "Second Label C" });
		this.DataContext = source;
	}
```

__Example 4: Defining two label definitions which add two label per data point__
```XAML
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis/>
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:CategoricalAxis/>
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:BarSeries ShowLabels="True" 
						   CategoryBinding="Category" 
						   ValueBinding="Value" 
						   ItemsSource="{Binding}">
			<telerik:BarSeries.LabelDefinitions>
			   
			   <telerik:ChartSeriesLabelDefinition Binding="Label" HorizontalAlignment="Center" VerticalAlignment="Center">
                        <telerik:ChartSeriesLabelDefinition.DefaultVisualStyle>
                            <Style TargetType="TextBlock">
                                <Setter Property="Foreground" Value="White" />
                            </Style>
                        </telerik:ChartSeriesLabelDefinition.DefaultVisualStyle>
                    </telerik:ChartSeriesLabelDefinition>
					
				<telerik:ChartSeriesLabelDefinition HorizontalAlignment="Center" VerticalAlignment="Top">
					<telerik:ChartSeriesLabelDefinition.Template>
						<DataTemplate>
							<TextBlock Foreground="#5AA4D4" FontWeight="Bold" Text="{Binding DataItem.Value}" />
						</DataTemplate>
					</telerik:ChartSeriesLabelDefinition.Template>
				</telerik:ChartSeriesLabelDefinition>
				
			</telerik:BarSeries.LabelDefinitions>
		</telerik:BarSeries>
	</telerik:RadCartesianChart>
```

#### Figure 2: Customized labels
![{{ site.framework_name }} RadChartView Customized labels](images/radchartview-features-label-definition-1.png)

The following list describes the properties available in the __ChartSeriesLabelDefinition__ class.

* __Binding__: `DataPointBinding` instance that points to a property of the data point underlying data item which gets the content of each label.

* __Format__: Format string used to format the label content, using the `String.Format` method.            

* __Margin__: Determines the offset of each label from the four box edges.

* __HorizontalAlignment__: Determines the horizontal alignment of each label relative to the data point it is associated with.            

* __VerticalAlignment__: Determines the vertical alignment of each label relative to the data point it is associated with.            

* __DefaultVisualStyle__: Sets a `Style` instance that defines the appearance of the default visual element representing the labels. The `TargetType` property of the `Style` should use the `TextBlock` type which is the default visual.

* __Template__: Sets a `DataTemplate` instance that will be used to define the visual element of the labels. If the Template property is set, the DefaultVisualStyle doesn't take effect. This is because in this case the default visual element is replaced by a content presenter with the custom `DataTemplate`.

* __TemplateSelector__: Sets a [DataTemplateSelector](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.datatemplateselector?view=netframework-4.5) instance that is used to provide context-specific data templates, depending on the provided data point.

* __Strategy__: Allows you to define and set a custom `ChartSeriesLabelStrategy` instance that determines the labels' appearance, content and layout (size and position). Read more in the [Chart Series Label Strategy]({%slug radchartview-labels-shart-series-labels-strategy%}) article.
	
	The chart also support smart labels strategy which is slightly different than the label definition's strategy. Read more in the [Smart Labels]({%slug radchartview-features-smart-labels%}) article.
	
## Using LabelDefinitions and SeriesProvider

In case the chart's [SeriesProvider]({%slug radchartview-features-chartseriesprovider%}) is used, the __LabelDefinitions__ collection is not accessible in XAML. In this case, there are two approaches that can be implemented. This section shows how to use them with a sample data binding setup.

__Example 5: Defining series model (see Example 2 for the PlotInfo definition)__
```C#
	public class SeriesInfo
    {
        public ObservableCollection<PlotInfo> Items { get; set; }
    }
```

__Example 6: Populating the data__
```C#
	private static Random r = new Random();
	public MyUserControl()
	{
		InitializeComponent();
		var source = new ObservableCollection<SeriesInfo>();
		for (int s = 0; s < 3; s++)
		{
			var seriesInfo = new SeriesInfo() { Items = new ObservableCollection<PlotInfo>() };
			for (int i = 0; i < 5; i++)
			{
				var dpValue = r.Next(100, 300);
				seriesInfo.Items.Add(new PlotInfo() { Category = "C" + i, Value = dpValue });
			}
			source.Add(seriesInfo);
		}
		this.DataContext = source;
	}
```

* __Using an attached property__

	An attached property implementation will allow you to define a ChartSeriesLabelDefinition in XAML and then add it in code, using the PropertyChangedCallback of the property. The next example shows one way to implement this.
	
	__Example 7: Implementing the attached property__
	```C#
		public static class ChartUtilities
		{
			public static readonly DependencyProperty LabelDefinitionProperty =
				DependencyProperty.RegisterAttached(
					"LabelDefinition", 
					typeof(ChartSeriesLabelDefinition),
					typeof(ChartUtilities), 
					new PropertyMetadata(new ChartSeriesLabelDefinition(), OnLabelDefinitionChanged));

			public static ChartSeriesLabelDefinition GetLabelDefinition(DependencyObject obj)
			{
				return (ChartSeriesLabelDefinition)obj.GetValue(LabelDefinitionProperty);
			}

			public static void SetLabelDefinition(DependencyObject obj, ChartSeriesLabelDefinition value)
			{
				obj.SetValue(LabelDefinitionProperty, value);
			}

			private static void OnLabelDefinitionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
			{
				var series = (CartesianSeries)d;
				series.LabelDefinitions.Clear();
				if (e.NewValue != null)
				{
					var labelDefinition = (ChartSeriesLabelDefinition)e.NewValue;
					series.LabelDefinitions.Add(labelDefinition);
				}
			}
		}
	```
	
	__Example 8: Adding label definition with an attached property__
	```XAML
		<telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis/>
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.SeriesProvider>
                <telerik:ChartSeriesProvider Source="{Binding}">
                    <telerik:CategoricalSeriesDescriptor ValuePath="Value" CategoryPath="Category" ItemsSourcePath="Items">
                        <telerik:CategoricalSeriesDescriptor.Style>
                            <Style TargetType="telerik:BarSeries">
                                <Setter Property="ShowLabels" Value="True"/>
								<Setter Property="local:ChartUtilities.LabelDefinition">
                                    <Setter.Value>
                                        <telerik:ChartSeriesLabelDefinition Binding="Value" Margin="0 0 0 10"
                                                                            HorizontalAlignment="Center" VerticalAlignment="Top"/>
                                    </Setter.Value>
                                </Setter>
                            </Style>
                        </telerik:CategoricalSeriesDescriptor.Style>
                    </telerik:CategoricalSeriesDescriptor>
                </telerik:ChartSeriesProvider>
            </telerik:RadCartesianChart.SeriesProvider>
        </telerik:RadCartesianChart>
	```

* __Using the SeriesCreated event__

	The [SeriesCreated]({%slug radchartview-features-chartseriesprovider%}#events) event gives access to the generated series, so the event handler can be used to create ChartSeriesLabelDefinition objects in code.
	
	__Example 9: Adding label definition using the SeriesCreated event__
	```XAML
		  <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis/>
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.SeriesProvider>
                <telerik:ChartSeriesProvider Source="{Binding}" SeriesCreated="ChartSeriesProvider_SeriesCreated">
                    <telerik:CategoricalSeriesDescriptor ValuePath="Value" CategoryPath="Category" ItemsSourcePath="Items">
                        <telerik:CategoricalSeriesDescriptor.Style>
                            <Style TargetType="telerik:BarSeries">
                                <Setter Property="ShowLabels" Value="True"/>
                            </Style>
                        </telerik:CategoricalSeriesDescriptor.Style>
                    </telerik:CategoricalSeriesDescriptor>
                </telerik:ChartSeriesProvider>
            </telerik:RadCartesianChart.SeriesProvider>
        </telerik:RadCartesianChart>
	```
	
	__Example 10: Implement the SeriesCreated event handler__
	```C#
		private void ChartSeriesProvider_SeriesCreated(object sender, Telerik.Windows.Controls.ChartView.ChartSeriesCreatedEventArgs e)
		{
			var labelDefinition = new ChartSeriesLabelDefinition()
			{
				Binding = new PropertyNameDataPointBinding("Value"),
				VerticalAlignment = VerticalAlignment.Top,
				HorizontalAlignment = HorizontalAlignment.Center,
				Margin = new Thickness(0, 0, 0, 10),
			};
			e.Series.LabelDefinitions.Add(labelDefinition);
		}
	```
	
#### Figure 3: Customized labels with SeriesProvider
![{{ site.framework_name }} RadChartView Customized labels with SeriesProvider](images/radchartview-features-label-definition-2.png)

## See Also  
 * [Smart Labels]({%slug radchartview-features-smart-labels%})
