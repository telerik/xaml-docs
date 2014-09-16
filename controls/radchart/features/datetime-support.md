---
title: DateTime Support
page_title: DateTime Support
description: DateTime Support
slug: radchart-features-datetime-support
tags: datetime,support
publish: True
position: 7
---

# DateTime Support



Often charts are used to display information for certain period in time. __RadChart__ provides full support of __DateTime__ values and allows you to show dates on the [X-Axis]({%slug radchart-features-axes-x-axis%}).

You can populate your chart with __DateTime__ values by using __SeriesMapping__or __DataPoints__. Take a look at the [Populating with Data]({%slug radchart-populating-with-data-overview%}) topic for more details.

## Using data binding (SeriesMapping/ItemMapping)

On the example below, __RadChart.ItemSource__ is set to a collection of __TradeData__ object. __TradeData__ has the following definition:

#### __C#__

{{region radchart-features-datetime-support_0}}
	public class TradeData
	{
	    ...
	    public DateTime FromDate { get; set; }
	    public double Close { get; set; }
	    ...
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-features-datetime-support_1}}
	Public Class TradeData
	
	    ....
	    Private _FromDate As DateTime
	    Public Property FromDate() As DateTime
	        Get
	            Return _FromDate
	        End Get
	        Set(ByVal value As DateTime)
	            _FromDate = value
	        End Set
	    End Property
	
	    Private _Close As Double
	    Public Property Close() As Double
	        Get
	            Return _Close
	        End Get
	        Set(ByVal value As Double)
	            _Close = value
	        End Set
	    End Property
	    ....
	End Class
	{{endregion}}



Now, you have to [bind]({%slug radchart-populating-with-data-data-binding-support-overview%}) the __TradeData.FromDate__ to __DataPointMember.XValue__ and __TradeDate.Close__ to __DataPointMember.YValue__ using [SeriesMapping/ItemMapping]({%slug radchart-populating-with-data-data-binding-support-overview%}) mechanism. Additionally, the [X-Axis]({%slug radchart-features-axes-x-axis%}) is customized: the values are formatted (__radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat__ = "dd-MMM") and rotated on 45 degree (__radChart.DefaultView.ChartArea.AxisX.LabelRotatingAngle__ = 45):

#### __XAML__

{{region radchart-features-datetime-support_2}}
	<telerikChart:RadChart x:Name="radChart" Height="362" Width="511" VerticalAlignment="Top">
	    <telerikChart:RadChart.SeriesMappings>
	        <telerikCharting:SeriesMapping LegendLabel="MSFT">
	            <telerikCharting:SeriesMapping.SeriesDefinition>
	                <telerikCharting:LineSeriesDefinition ShowItemLabels="False" />
	            </telerikCharting:SeriesMapping.SeriesDefinition>
	
	            <telerikCharting:SeriesMapping.ItemMappings>
	                <telerikCharting:ItemMapping FieldName="FromDate" DataPointMember="XValue"/>
	                <telerikCharting:ItemMapping FieldName="Close" DataPointMember="YValue"/>
	            </telerikCharting:SeriesMapping.ItemMappings>
	        </telerikCharting:SeriesMapping>
	    </telerikChart:RadChart.SeriesMappings>
	    <telerikChart:RadChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            ....
	            <telerikCharting:ChartDefaultView.ChartArea>
	                <telerikCharting:ChartArea LegendName="chartLegend">
	                    <telerikCharting:ChartArea.AxisX>
	                        <telerikCharting:AxisX  DefaultLabelFormat="dd-MMM" LabelRotationAngle="45">
	                        </telerikCharting:AxisX>
	                    </telerikCharting:ChartArea.AxisX>                          
	                </telerikCharting:ChartArea>
	            </telerikCharting:ChartDefaultView.ChartArea>
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:RadChart.DefaultView>
	</telerikChart:RadChart>
	{{endregion}}



#### __C#__

{{region radchart-features-datetime-support_3}}
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	SeriesMapping seriesMapping = new SeriesMapping();
	seriesMapping.LegendLabel = "MSFT";
	seriesMapping.SeriesDefinition = new LineSeriesDefinition();
	seriesMapping.ItemMappings.Add( new ItemMapping( "FromDate", DataPointMember.XValue ) );
	seriesMapping.ItemMappings.Add( new ItemMapping( "Close", DataPointMember.YValue ) );
	radChart.SeriesMappings.Add( seriesMapping );
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
	radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
	{{endregion}}



#### __VB.NET__

{{region radchart-features-datetime-support_4}}
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	Dim seriesMapping As New SeriesMapping()
	seriesMapping.LegendLabel = "MSFT"
	seriesMapping.SeriesDefinition = New LineSeriesDefinition()
	seriesMapping.ItemMappings.Add( New ItemMapping( "FromDate", DataPointMember.XValue ) )
	seriesMapping.ItemMappings.Add( New ItemMapping( "Close", DataPointMember.YValue ) )
	radChart.SeriesMappings.Add( seriesMapping )
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
	radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
	{{endregion}}



As a result, the chart will look like the one on the snapshot:




         
      ![](images/RadChart_Features_DateTime_Support_01.png)

## Using DataPoint

This example uses data binding mechanism via [SeriesMapping/ItemMapping]({%slug radchart-populating-with-data-data-binding-support-overview%}). However, using [DataPoints]({%slug radchart-populating-with-data-overview%}) is also possible, but you have to be aware of the following specifics:

* __DataPoint.XValue__ is of type __double__. Therefore, the __DateTime__ values have to be converted to OLE Automation dates first: see [DateTime.ToOADate()](http://msdn.microsoft.com/en-us/library/system.datetime.tooadate(VS.95).aspx). 


* The __AxisX.IsDateTime__ should be set to __True__.

#### __XAML__

{{region radchart-features-datetime-support_5}}
	<telerikChart:RadChart Height="362" Width="511" VerticalAlignment="Top" HorizontalAlignment="Right">
	    <telerikChart:RadChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            ...
	            <telerikCharting:ChartDefaultView.ChartArea>
	                <telerikCharting:ChartArea Margin="0, 0, 5, 0">
	                    <telerikCharting:ChartArea.AxisX>
	                        <telerikCharting:AxisX IsDateTime="True" 
	                                               DefaultLabelFormat="dd-MMM" 
	                                               LabelRotationAngle="45"
	                                               LayoutMode="Inside">
	                        </telerikCharting:AxisX>
	                    </telerikCharting:ChartArea.AxisX>
	                        ....
	                    <telerikCharting:ChartArea.DataSeries>
	                        <!-- Line Chart -->
	                        <telerikCharting:DataSeries>
	                            <telerikCharting:DataSeries.Definition>
	                                <telerikCharting:LineSeriesDefinition >
	                                </telerikCharting:LineSeriesDefinition>
	                            </telerikCharting:DataSeries.Definition>
	                            <telerikCharting:DataPoint YValue="154" XValue="39844.0"/>
	                            <telerikCharting:DataPoint YValue="138" XValue="39872.0"/>
	                            <telerikCharting:DataPoint YValue="143" XValue="39903.0"/>
	                            <telerikCharting:DataPoint YValue="120" XValue="39933.0"/>
	                            <telerikCharting:DataPoint YValue="135" XValue="39964.0"/>
	                            <telerikCharting:DataPoint YValue="125" XValue="39994.0"/>
	                            <telerikCharting:DataPoint YValue="179" XValue="40025.0"/>
	                            <telerikCharting:DataPoint YValue="170" XValue="40056.0"/>
	                            <telerikCharting:DataPoint YValue="198" XValue="40086.0"/>
	                            <telerikCharting:DataPoint YValue="187" XValue="40117.0"/>
	                            <telerikCharting:DataPoint YValue="193" XValue="40147.0"/>
	                            <telerikCharting:DataPoint YValue="176" XValue="40178.0"/>
	                        </telerikCharting:DataSeries>
	                    </telerikCharting:ChartArea.DataSeries>
	                </telerikCharting:ChartArea>
	            </telerikCharting:ChartDefaultView.ChartArea>
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:RadChart.DefaultView>
	</telerikChart:RadChart>
	{{endregion}}



#### __C#__

{{region radchart-features-datetime-support_6}}
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	....
	radChart.DefaultView.ChartArea.AxisX.IsDateTime = true;
	radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
	radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45;
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
	....
	DataSeries lineSeries = new DataSeries();
	lineSeries.Definition = new LineSeriesDefinition();
	lineSeries.Add( new DataPoint() { YValue = 154, XValue = new DateTime( 2009, 1, 31 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 138, XValue = new DateTime( 2009, 2, 28 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 143, XValue = new DateTime( 2009, 3, 31 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 120, XValue = new DateTime( 2009, 4, 30 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 135, XValue = new DateTime( 2009, 5, 31 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 125, XValue = new DateTime( 2009, 6, 30 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 179, XValue = new DateTime( 2009, 7, 31 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 170, XValue = new DateTime( 2009, 8, 31 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 198, XValue = new DateTime( 2009, 9, 30 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 187, XValue = new DateTime( 2009, 10, 31 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 193, XValue = new DateTime( 2009, 11, 30 ).ToOADate() } );
	lineSeries.Add( new DataPoint() { YValue = 176, XValue = new DateTime( 2009, 12, 31 ).ToOADate() } );
	radChart.DefaultView.ChartArea.DataSeries.Add( lineSeries );
	{{endregion}}



#### __VB.NET__

{{region radchart-features-datetime-support_7}}
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	....
	radChart.DefaultView.ChartArea.AxisX.IsDateTime = True
	radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
	radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
	....
	Dim lineSeries As New DataSeries()
	lineSeries.Definition = New LineSeriesDefinition()
	lineSeries.Add( New DataPoint( New DateTime( 2009, 1, 31 ).ToOADate(), 154 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 2, 28 ).ToOADate(), 138 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 3, 31 ).ToOADate(), 143 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 4, 30 ).ToOADate(), 120 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 5, 31 ).ToOADate(), 135 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 6, 30 ).ToOADate(), 125 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 7, 31 ).ToOADate(), 179 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 8, 31 ).ToOADate(), 170 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 9, 30 ).ToOADate(), 198 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 10, 31 ).ToOADate(), 187 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 11, 30 ).ToOADate(), 193 ) )
	lineSeries.Add( New DataPoint( New DateTime( 2009, 12, 31 ).ToOADate(), 176 ) )
	radChart.DefaultView.ChartArea.DataSeries.Add( lineSeries )
	{{endregion}}



The image below shows the chart with defined using __DataPoints__:




         
      ![](images/RadChart_Features_DateTime_Support_10.png)

Note how the values are defined in the XAML - this is the OLE Automation equivalent of the dates. In the code behind, __ToOADate()__ method is used to convert the dates and then the value is set to the __XValue__ property of the __DataPoint__ class.

The same logic is used when specifying the __AxisX.MinValue__ and __AxisX.MaxValue__. This example also demonstrates how to customize the __X-axis__ by disabling __AutoRange__ and how to configure the axis manually.



# See Also

 * [Axes Overview]({%slug radchart-features-axes-overview%})

 * [Format Expressions]({%slug radchart-features-format-expressions%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})
