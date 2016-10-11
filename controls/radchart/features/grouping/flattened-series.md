---
title: Flattened Series
page_title: Flattened Series
description: Flattened Series
slug: radchart-features-flattened-series
tags: flattened,series
published: True
position: 1
---

# Flattened Series



Sometimes when the grouping and aggregation get applied you might want to flatten it, in order to make it appear as one. This is done by combining all data points into one series and can be achieved by just setting the __ShouldFlattenSeries__ property of the __GroupingSettings__ class.

Here is a __RadChart__ declaration before setting the __ShouldFlattenSeries__ property to __True__.

>tipTo learn more about __DateTime Grouping__ read [here]({%slug radchart-features-datetime-grouping%}).

#### __XAML__

{{region xaml-radchart-features-flattened-series_0}}
	<telerik:RadChart x:Name="radChart">
	    <telerik:RadChart.SeriesMappings>
	        <telerik:SeriesMapping>
	            <telerik:SeriesMapping.SeriesDefinition>
	                <telerik:LineSeriesDefinition />
	            </telerik:SeriesMapping.SeriesDefinition>
	            <telerik:SeriesMapping.GroupingSettings>
	                <telerik:GroupingSettings>
	                    <telerik:GroupingSettings.GroupDescriptors>
	                        <telerik:ChartYearGroupDescriptor Member="Date" />
	                    </telerik:GroupingSettings.GroupDescriptors>
	                </telerik:GroupingSettings>
	            </telerik:SeriesMapping.GroupingSettings>
	            <telerik:SeriesMapping.ItemMappings>
	                <telerik:ItemMapping DataPointMember="XValue" FieldName="Date" />
	                <telerik:ItemMapping DataPointMember="YValue" FieldName="Value" />
	            </telerik:SeriesMapping.ItemMappings>
	        </telerik:SeriesMapping>
	    </telerik:RadChart.SeriesMappings>
	</telerik:RadChart>
{{endregion}}
![](images/RadChart_Features_FlattenedSeries_01.png)

Here is the same __RadChart__ after setting the property to __True__.

#### __XAML__

{{region xaml-radchart-features-flattened-series_1}}
	<telerik:SeriesMapping.GroupingSettings>
	    <telerik:GroupingSettings ShouldFlattenSeries="True">
	        <telerik:GroupingSettings.GroupDescriptors>
	            <telerik:ChartYearGroupDescriptor Member="Date" />
	        </telerik:GroupingSettings.GroupDescriptors>
	    </telerik:GroupingSettings>
	</telerik:SeriesMapping.GroupingSettings>
{{endregion}}



#### __C#__

{{region cs-radchart-features-flattened-series_2}}
	public Sample()
	{
	    InitializeComponent();
	    this.radChart.SeriesMappings[ 0 ].GroupingSettings.ShouldFlattenSeries = true;
	}
{{endregion}}



#### __VB.NET__

{{region vb-radchart-features-flattened-series_3}}
	Public Sub New()
	    InitializeComponent()
	    Me.radChart.SeriesMappings(0).GroupingSettings.ShouldFlattenSeries = True
	End Sub
{{endregion}}

![](images/RadChart_Features_FlattenedSeries_02.png)

## Dynamic Series Flattening

If you want to allow the series to get flattened through the UI at run time, you have to change the __ShouldFlattenSeries__ property. The change of the property will not cause the UI to update and to display the series according to it though. To apply the change you have to rebind the chart by calling its __Rebind()__ method.

Here is an example of a __CheckBox__ that manages the series flattening of the __RadChart__ used above.

#### __XAML__

{{region xaml-radchart-features-flattened-series_4}}
	<CheckBox Click="CheckBox_Click" Content="Flatten" />
{{endregion}}



#### __C#__

{{region cs-radchart-features-flattened-series_5}}
	private void CheckBox_Click(object sender, RoutedEventArgs e)
	{
	    bool? isChecked = (sender as CheckBox).IsChecked;
	    if (isChecked == null)
	        return;
	    this.radChart.SeriesMappings[0].GroupingSettings.ShouldFlattenSeries = (bool)isChecked;
	    this.radChart.Rebind();
	}
{{endregion}}



#### __VB.NET__

{{region vb-radchart-features-flattened-series_6}}
	Private Sub CheckBox_Click(sender As Object, e As RoutedEventArgs)
	    Dim isChecked As System.Nullable(Of Boolean) = TryCast(sender, CheckBox).IsChecked
	    If isChecked Is Nothing Then
	        Return
	    End If
	    Me.radChart.SeriesMappings(0).GroupingSettings.ShouldFlattenSeries = CBool(isChecked)
	    Me.radChart.Rebind()
	End Sub
{{endregion}}


