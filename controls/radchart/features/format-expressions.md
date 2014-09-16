---
title: Format Expressions
page_title: Format Expressions
description: Format Expressions
slug: radchart-features-format-expressions
tags: format,expressions
publish: True
position: 9
---

# Format Expressions



__RadChart__ supports format expressions, which you can use to format the series items labels, axes labels and tooltip texts. Besides the [standard](http://msdn.microsoft.com/en-us/library/dwhawy9k.aspx), the [custom](http://msdn.microsoft.com/en-us/library/0c899ak8.aspx) numeric and the [date/time](http://msdn.microsoft.com/en-us/library/97x6twsz.aspx) format strings, __RadChart__ supports chart specific format mechanism that allows you to insert context-specific data. To do that, use one of the following tokens:
<table> <tr><td><b>Token</b></td><td><b>Use for</b></td><td><b>Value</b></td></tr><tr><td>#Y</td><td>Series Items Label, Tooltip</td><td>DataPoint.YValue</td></tr><tr><td>#X</td><td>Series Items Label, Tooltip</td><td>DataPoint.XValue</td></tr><tr><td>#XCAT</td><td>Series Items Label, Tooltip</td><td>DataPoint.XCategory</td></tr><tr><td>#HIGH</td><td>Series Items Label, Tooltip</td><td>DataPoint.High</td></tr><tr><td>#LOW</td><td>Series Items Label, Tooltip</td><td>DataPoint.Low</td></tr><tr><td>#OPEN</td><td>Series Items Label, Tooltip</td><td>DataPoint.Open</td></tr><tr><td>#CLOSE</td><td>Series Items Label, Tooltip</td><td>DataPoint.Close</td></tr><tr><td>#BUBBLESIZE</td><td>Series Items Label, Tooltip</td><td>DataPoint.BubbleSize</td></tr><tr><td>#LABEL</td><td>Series Items Label, Tooltip</td><td>DataPoint.Label</td></tr><tr><td>#LEGENDLABEL</td><td>Series Items Label, Tooltip</td><td>DataPoint.LegendLabel</td></tr><tr><td>#TOOLTIP</td><td>Series Items Label, Tooltip</td><td>DataPoint.Tooltip</td></tr><tr><td>#SERIESLABEL</td><td>Series Items Label, Tooltip</td><td>DataSeries.LegendLabel</td></tr><tr><td>#%</td><td>Series Items Label, Tooltip</td><td>DataPoint.YValue / (The sum of all YValues in the current data series)</td></tr><tr><td>#STSUM</td><td>Series Items Label, Tooltip</td><td>Represents the sum of all stacked items for a given index.</td></tr><tr><td>#STPERCENT</td><td>Series Items Label, Tooltip</td><td>The percent representation of the value of a given item with respect to all stacked items for the respective index.</td></tr><tr><td>#DATAITEM.<PropertyName></td><td>Series Items Label, Tooltip</td><td>Use it to access the DataPoint.DataItem and read the value from a property of the underlying business object.</td></tr><tr><td>#VAL</td><td>X-Axis, Y-Axis</td><td>TickPoint.Value. This will work only when formatting axis labels.</td></tr></table>

As you can see, each token consists of two parts: __number sign "#"__ and __name__. Additionally, in a curly braces, you can specify the format of the value if needed.

The __#DATAITEM__ token is a special one. It allows you to specify a property name from the underlying object and when the format expression is applied, the __#DATAITEM__ token will be replaced with the value from the corresponding property. The format is: __#DATAITEM.<PropertyName>__. For example, the format expression "__#DATAITEM.Description__" means, that the value from the property __Description__ will be used.

Besides the format expressions, you can specify how the labels to be formatted by using __ChartArea.LabelFormatBehavior__. You can select one of the three options: __HumanReadable__(default), __Scientific__ and __None__.  However, the format expressions override the selected __LabelFormatBehavior__. More about the label format behavior you can find [here]({%slug radchart-features-chart-area%}).

## Specifying Label Formats

The following example demonstrates how to specify a label format expression to customize the axes, the series item labels and the tooltips. 

The created chart is bound to a collection of __TradeData__ objects via [SeriesMapping/ItemMapping]({%slug radchart-populating-with-data-data-binding-with-manual-series-mapping%}), where the __TradeData__ object has the following structure:

#### __C#__

{{region radchart-features-format-expressions_0}}
	public class TradeData
	{
	    public string Emission
	    {
	        get;
	        set;
	    }
	    public DateTime FromDate
	    {
	        get;
	        set;
	    }
	    public DateTime ToDate
	    {
	        get;
	        set;
	    }
	    public double Open
	    {
	        get;
	        set;
	    }
	    public double High
	    {
	        get;
	        set;
	    }
	    public double Low
	    {
	        get;
	        set;
	    }
	    public double Close
	    {
	        get;
	        set;
	    }
	    public double Volume
	    {
	        get;
	        set;
	    }
	    public string Comment
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radchart-features-format-expressions_1}}
	Public Class TradeData
	    Private _Emission As String
	    Public Property Emission() As String
	        Get
	            Return _Emission
	        End Get
	        Set(ByVal value As String)
	            _Emission = value
	        End Set
	    End Property
	
	    Private _FromDate As DateTime
	    Public Property FromDate() As DateTime
	        Get
	            Return _FromDate
	        End Get
	        Set(ByVal value As DateTime)
	            _FromDate = value
	        End Set
	    End Property
	
	    Private _ToDate As DateTime
	    Public Property ToDate() As DateTime
	        Get
	            Return _ToDate
	        End Get
	        Set(ByVal value As DateTime)
	            _ToDate = value
	        End Set
	    End Property
	
	    Private _Open As Double
	    Public Property Open() As Double
	        Get
	            Return _Open
	        End Get
	        Set(ByVal value As Double)
	            _Open = value
	        End Set
	    End Property
	
	    Private _High As Double
	    Public Property High() As Double
	        Get
	            Return _High
	        End Get
	        Set(ByVal value As Double)
	            _High = value
	        End Set
	    End Property
	
	    Private _Low As Double
	    Public Property Low() As Double
	        Get
	            Return _Low
	        End Get
	        Set(ByVal value As Double)
	            _Low = value
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
	
	    Private _Volume As Double
	    Public Property Volume() As Double
	        Get
	            Return _Volume
	        End Get
	        Set(ByVal value As Double)
	            _Volume = value
	        End Set
	    End Property
	
	    Private _Comment As String
	    Public Property Comment() As String
	        Get
	            Return _Comment
	        End Get
	        Set(ByVal value As String)
	            _Comment = value
	        End Set
	    End Property
	End Class
	{{endregion}}



Take a look at the code snippet below and see how to define custom label format strings for your __RadChart__.

#### __XAML__

{{region radchart-features-format-expressions_2}}
	<telerikChart:RadChart x:Name="radChart">
	    <telerikChart:RadChart.DefaultView>
	        <telerikCharting:ChartDefaultView>
	            <telerikCharting:ChartDefaultView.ChartArea>
	                <telerikCharting:ChartArea>
	                    <telerikCharting:ChartArea.AxisX>
	                        <telerikCharting:AxisX DefaultLabelFormat="dd-MMM" LayoutMode="Inside">
	                        </telerikCharting:AxisX>
	                    </telerikCharting:ChartArea.AxisX>
	                    <telerikCharting:ChartArea.AxisY>
	                        <telerikCharting:AxisY DefaultLabelFormat="#VAL{C2}">
	                        </telerikCharting:AxisY>
	                    </telerikCharting:ChartArea.AxisY>
	
	                </telerikCharting:ChartArea>
	            </telerikCharting:ChartDefaultView.ChartArea>
	            ....
	        </telerikCharting:ChartDefaultView>
	    </telerikChart:RadChart.DefaultView>
	    <telerikChart:RadChart.SeriesMappings>
	        <telerikCharting:SeriesMapping LegendLabel="MSFT">
	            <telerikCharting:SeriesMapping.SeriesDefinition>
	                <telerikCharting:LineSeriesDefinition
	                    ShowItemLabels="True" ShowItemToolTips="True" 
	                    ItemLabelFormat="#Y{C2}"
	                    ItemToolTipFormat="High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}&#x0a;Volume: #DATAITEM.Volume{#,###,###,##0}"/>
	            </telerikCharting:SeriesMapping.SeriesDefinition>
	            <telerikCharting:SeriesMapping.ItemMappings>
	                <telerikCharting:ItemMapping DataPointMember="YValue" FieldName="Close" />
	                <telerikCharting:ItemMapping DataPointMember="XValue" FieldName="FromDate" />
	            </telerikCharting:SeriesMapping.ItemMappings>
	        </telerikCharting:SeriesMapping>
	    </telerikChart:RadChart.SeriesMappings>
	</telerikChart:RadChart>
	{{endregion}}



#### __C#__

{{region radchart-features-format-expressions_3}}
	Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
	....
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM";
	radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside;
	radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "#VAL{C2}";
	SeriesMapping seriesMapping = new SeriesMapping();
	seriesMapping.SeriesDefinition = new LineSeriesDefinition();
	seriesMapping.SeriesDefinition.ShowItemToolTips = true;
	seriesMapping.SeriesDefinition.ItemLabelFormat = "#Y{C2}";
	seriesMapping.SeriesDefinition.ItemToolTipFormat = 
	    "High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}\nVolume: #DATAITEM.Volume{#,###,###,##0}";
	seriesMapping.ItemMappings.Add( new ItemMapping( "Close", DataPointMember.YValue ) );
	seriesMapping.ItemMappings.Add( new ItemMapping( "FromDate", DataPointMember.XValue ) );
	radChart.SeriesMappings.Add( seriesMapping );
	{{endregion}}



#### __VB.NET__

{{region radchart-features-format-expressions_4}}
	Dim radChart As New Telerik.Windows.Controls.RadChart()
	....
	radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
	radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
	radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "#VAL{C2}"
	Dim seriesMapping As New SeriesMapping()
	seriesMapping.SeriesDefinition = New LineSeriesDefinition()
	seriesMapping.SeriesDefinition.ShowItemToolTips = True
	seriesMapping.SeriesDefinition.ItemLabelFormat = "#Y{C2}"
	seriesMapping.SeriesDefinition.ItemToolTipFormat = 
	    "High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}" & vbLf & "Volume: #DATAITEM.Volume{#,###,###,##0}"
	seriesMapping.ItemMappings.Add(New ItemMapping("Close", DataPointMember.YValue))
	seriesMapping.ItemMappings.Add(New ItemMapping("FromDate", DataPointMember.XValue))
	radChart.SeriesMappings.Add(seriesMapping)
	{{endregion}}



The specified label formats are:

* The __X-Axis__ format is set to "__dd-MMM__". It does not use any tokens, just the standard __DateTime__ formatting to show the day and the three letter abbreviation of the month.

* The __Y-Axis__ uses __#VAL__ token with currency format: "__#VAL{C2}__". As a result, the label shows the tick's value formatted as currency with two digits after the decimal point.

* The series item labels are showing the value from the __DataPoint.Close__ property formatted as currency: "__#Y{C2}__".

* The tooltip is formatted to show two rows. On the first row, the __High__and the __Low__values are shown, while on the second - the volume. When the format string is set declaratively, you have to use "&#x0a;" for new line. When it is set in the code behind - "\n":

* "__High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}&#x0a;Volume: #DATAITEM.Volume{#,###,###,##0}"__

* "__High/Low: #DATAITEM.High{C4}/#DATAITEM.Low{C4}\nVolume: #DATAITEM.Volume{#,###,###,##0}"__

The result is shown on the image below. Note that the __YValue__is bound to the __Close__ property of the underlying business object, while the tooltip using the __#DATAITEM__ token extracts the values from from the __High__, __Low__and __Volume__ properties and then applies the specified format:




         
      ![](images/RadChart_Features_FormatExpressions_010.png)

>

The __#TOOLTIP__ token is intended to be used when formatting items labels via __ItemLabelFormat__. This token returns the value from the __DataPoint.Tooltip__ property. More about tooltip formatting see [here]({%slug radchart-features-tooltips%}).

On the table below you can see some more examples of format expressions:


<table> <tr><td><b>Expression</b></td><td><b>Result</b></td></tr><tr><td>C4</td><td>1234.2110</td></tr><tr><td>#,##0.00</td><td>1,234.21</td></tr><tr><td>#VAL{C2}</td><td>$1234.21</td></tr><tr><td>Open: #OPEN{C2}</td><td>Open: $1234.21</td></tr><tr><td>#%{p}</td><td>12.34 %</td></tr><tr><td>Volume: #DATAITEM.Volume{#,###,##0}</td><td>Volume: 1,234,567</td></tr></table>



# See Also

 * [Chart Area]({%slug radchart-features-chart-area%})

 * [Axes Overview]({%slug radchart-features-axes-overview%})

 * [Chart Point-marks]({%slug radchart-features-chart-point-marks%})

 * [ToolTips]({%slug radchart-features-tooltips%})

 * [Data Binding Support Overview]({%slug radchart-populating-with-data-data-binding-support-overview%})
