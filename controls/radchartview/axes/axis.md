---
title: Axis
page_title: Axis
description: This article outlines the common functionality for the different types of axes available in the RadChartView suite.
slug: radchartview-axes-axis
tags: axis
published: True
position: 0
---

# {{ site.framework_name }} RadChartView Axis

RadChartView plots data points in a coordinate system defined by its two axes. There are a few different types of axes and they are: __Linear__, __Logarithmic__, __DateTime__ and __Categorical__. This article discusses the common characteristics of all the axes as well as the specifics of the __LinerAxis__. The other types are discussed in their respective help articles.        

The chart axis is represented by the abstract __Axis__ class and is responsible for displaying ticks that simply mark values on the axis at fixed positions. The axis also displays labels that are used to provide a visualization of the values at some or all of the ticks. The default visualization of the labels is text.        

Here are the __common properties__ for all kinds of axes:  

* __PlotMode__ (supported by Categorical and DateTime Axis only): RadChartView allows you to modify the layout of the axis to better fit the different chart types in the chart area. You can read more about the property in the [Plot Mode]({%slug radchartview-axes-plotmode%}) help article.     

* __LabelInterval__: Specifies the value indicating that only one out of n-axis labels should be visible, where n is the value of the property.        

* __LabelFormat__: Format the text in the axis labels by specified [Standard](http://msdn.microsoft.com/en-us/library/az4se3k1.aspx) or [Custom Format Strings](http://msdn.microsoft.com/en-us/library/8kb3ddd4.aspx).  

* __LabelTemplate__: The System.Windows.DataTemplate used to visualize axis labels.

* __LabelStyle__: The System.Windows.Style to be applied to the default System.Windows.Controls.TextBlock instance created when the __LabelTemplate__ property is not set. The __TargetType__ of this style should be __TextBlock__.

* __MajorStep__ (available for LinearAxis): Specify a step for the major ticks that determines at which values will major ticks be displayed. It is most commonly used with __Minimum__ and __Maximum__ properties.        

* __Minimum__ and __Maximum__ (available for LinearAxis): Use to set the minimal and maximal value of the axis.

* __MajorTickOffset__: As its name implies, __MajorTickOffset__ offsets the major ticks with n where n is the value of the property. For example, a LinearAxis with MajorStep="2" and MajorTickOffset="3" will have its values start at 6. (6, 8, 10 ... etc.)        

* __MajorTickInterval__ (available for CategoricalAxis and DateTimeCategoricalAxis): Defines a value indicating that one axis label will be common for n number of Ticks where n is the value of the property.        
* __LabelRotationAngle__: Specifies the value indicating the rotation angle for the axis labels. Use when label texts are long and are overlapping each other. In order for the `LabelRotationAngle` property to take effect, the `LabelFitMode` should be set to `Rotate`.        

* __LastLabelVisibility__: Specifies whether the last label should be Clipped, Visible or Hidden.        

* __LabelFitMode__: The axis labels can be laid out in specific ways in order to improve their readability when they become too long and start to overlap each other. __LabelFitMode__ positions the labels on different lines and the other fit mode rotates the labels some user defined degree so that they appear inclined or orthogonal to the axis, making them easier to read.        

	![{{ site.framework_name }} RadChartView LabelFit Modes](images/radchartview-chart_axes_labelfitmode.png)

* __ElementBrush__: You may colorize all axis elements (line, ticks, labels and title) simultaneously using this property. You must provide Brush as its value. You may see this property in action in the [Multiple Axes]({%slug radchartview-axes-multipleaxes%}) article.

* __SmartLabelsMode__: The property defines the algorithm used by the chart to recalculate the actual step of the axis. You can read more about this feature in the [Axis Smart Labels]({%slug radchartview-features-axis-smart-labels %}) article.

* __IsStepRecalculationOnZoomEnabled__: The property controls whether the chart should recalculate the actual step it uses when the chart gets zoomed. You can read more about this feature in the [Axis Smart Labels]({%slug radchartview-features-axis-smart-labels %}) article.

* __TickOrigin__ (available in LinearAxis and DateTimeContinuousAxis): Gets or sets a value that indicates where the ticks originate. The positions of the ticks are determined based on the combination of the __MajorStep__ and __TickOrigin__ values. The axis will generate the ticks and labels in a way so that a label is positioned at the given TickOrigin.

* __DesiredTickCount__ (available for LinearAxis and LogarithmicAxis): This property specifies the desired number of ticks to be drawn on the axis. Note, that the actual number of ticks may be be slightly higher or lower, since the automatic range calculation takes into account different factors and it tries to display a reasonable step between the ticks. For example, if theDesiredTickCount is 7, then 6 or 8 ticks may be drawn, depending on the range of the axis.

The axis supports arbitrary visualization of the ticks and labels through DataTemplate objects and also supports a dash array and a stroke color for the visualization of the axis line. For increased flexibility, the label templates can be selected dynamically with a template selector, as shown in __Examples 1 and 2__.        

#### __[XAML] Example 1: Setting LabelTemplateSelector of a LinearAxis__
{{region xaml-radchart-axes-axis_0}}
	<Grid.Resources>
	   <DataTemplate x:Key="GrayTemplate">
	       <Border BorderThickness="2"
	               BorderBrush="Gray">
	           <TextBlock Text="{Binding}"/>
	       </Border>
	   </DataTemplate>
	   <DataTemplate x:Key="WhiteTemplate">
	       <Border BorderThickness="2"
	               BorderBrush="White">
	           <TextBlock Text="{Binding}"/>
	       </Border>
	   </DataTemplate>
	
	   <local:BinaryTemplateSelector x:Key="Selector"
	                                 Template1="{StaticResource GrayTemplate}"
	                                 Template2="{StaticResource WhiteTemplate}"/>
	</Grid.Resources>
	
	<telerik:RadCartesianChart x:Name="chart">
	    <telerik:RadCartesianChart.HorizontalAxis>
	         <telerik:LinearAxis Maximum="100"
	                           LineStroke="Gray"
	                           LineDashArray="5, 10, 15"
	                           TickThickness="5"
	                           LabelTemplateSelector="{StaticResource Selector}">
	            <telerik:LinearAxis.MajorTickTemplate>
	                <DataTemplate>
	                    <Ellipse Fill="White"/>
	                </DataTemplate>
	            </telerik:LinearAxis.MajorTickTemplate>
	         </telerik:LinearAxis>
	    </telerik:RadCartesianChart.HorizontalAxis>
	
	    <telerik:RadCartesianChart.VerticalAxis>
	        <telerik:LinearAxis Maximum="100"/>
	    </telerik:RadCartesianChart.VerticalAxis>
	</telerik:RadCartesianChart>
{{endregion}}

#### __[C#] Example 2: BinaryTemplateSelector Definition__
{{region cs-radchart-axes-axis_1}}
	public class BinaryTemplateSelector : DataTemplateSelector
	{
	    public DataTemplate Template1
	    {
	        get;
	        set;
	    }
	    public DataTemplate Template2
	    {
	        get;
	        set;
	    }
	    public override DataTemplate SelectTemplate(object item, DependencyObject container)
	    {
	        DataTemplate tmp = this.Template1;
	        this.Template1 = this.Template2;
	        this.Template2 = tmp;
	        return tmp;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 2: BinaryTemplateSelector Definition__
{{region vb-radchart-axes-axis_2}}
	Public Class BinaryTemplateSelector
	    Inherits DataTemplateSelector
	    Private _template1 As DataTemplate
	    Private _template2 As DataTemplate
	
	    Public Property Template1 As DataTemplate
	        Get
	            Return Me._template1
	        End Get
	        Set(value As DataTemplate)
	            Me._template1 = value
	        End Set
	    End Property
	    Public Property Template2 As DataTemplate
	        Get
	            Return Me._template2
	        End Get
	
	        Set(value As DataTemplate)
	            Me._template2 = value
	        End Set
	    End Property
	    Public Overrides Function SelectTemplate(item As Object, container As System.Windows.DependencyObject) As System.Windows.DataTemplate
	        Dim tmp As DataTemplate
	        tmp = Me.Template1
	        Me.Template1 = Me.Template2
	        Me.Template2 = tmp
	        Return tmp
	    End Function
	End Class
{{endregion}}

#### __Figure 1: Result from Examples 1 and 2__
![RadChartView Horizontal Axis with LabelTemplateSelector](images/radchartview-chart_axes_axisconfig.png)

The linear axis is a plain numerical axis, that is, the LinearAxis class inherits from __NumericalAxis__ and NumericalAxis itself inherits from Axis. NumericalAxis defines only a few features on top of the abstract Axis class.

## Getting the Axis Actual Range

The range of the chart's continuous axes (LinearAxis, LogarithmicAxis and DateTimeContinuousAxis) can be adjusted manually by the Minimum and Maximum properties. If they are not set the axis range is calculated manually. In this case its range can be get from several properties and events exposed by the axis.

* __ActualRange__: The property returns an object of type ValueRange<T> that contains the actual visible range of the axis. This is the range visible in the plot area of the control. The ActualVisibleRange will be different than the ActualRange when you zoom-in the chart. See also the __ActualRangeChanged__ event in the [Common Events](#common-events) section of this article.

* __ActualVisibleRange__: The property returns an object of type ValueRange<T> that contains the the actual range of the axis - minimum and maximum. See also the __ActualVisibleRangeChanged__ event in the [Common Events](#common-events) section of this article.

* __ActualMajorStep__: The property returns a numeric value that determines the actual major step of the axis. Available only for __LinearAxis__. See also the __ActualMajorStepChanged__ event in the [Common Events](#common-events) section of this article.

## Common Events

There are several common events exposed by the different type of axes.

* __ActualRangeChanged__: Occurs when the actual range changes. The event arguments are of type __Telerik.Charting.NumericalRangeChangedEventArgs__ and expose the following properties:
	* __NewRange__: A property of type __Telerik.Charting.ValueRange&lt;double&gt;__ that gets the new range of the axis.
	* __PreviousRange__: A property of type __Telerik.Charting.ValueRange&lt;double&gt;__ that gets the previous range of the axis.
	
* __ActualVisibleRangeChanged__: Occurs when the actual visible range changes. The event arguments are of type __Telerik.Charting.NumericalRangeChangedEventArgs__ and expose the following properties:
	* __NewRange__: A property of type __Telerik.Charting.ValueRange&lt;double&gt;__ that gets the new visible range of the axis.
	* __PreviousRange__: A property of type __Telerik.Charting.ValueRange&lt;double&gt;__ that gets the visible previous range of the axis.

> The __ActualRangeChanged__ and __ActualVisibleRangeChanged__ events are exposed only by the chart's numeric axes: LinearAxis, LogarithmicAxis and DateTimeContinuousAxis.

* __ActualMajorStepChanged__: Occurs when the actual major step of the axis gets changed. The event arguments are of type __EventArgs__.
	
	> This event is exposed only by the LinearAxis class.
	
## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Events]({%slug radchartview-events%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
