---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radheatmap-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadHeatMap__ with a categorical definition.

* [Assembly references](#assembly-references)
* [Setting up the Data](#setting-up-the-data)
* [Setting up the Control](#setting-up-the-control)
* [Colorization](#colorization)
			
## Assembly References

In order to use __RadHeatMap__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Setting up the Data

To use the RadHeatMap control you will need to define a model that will describe the data that will be shown.

#### __[C#] Example 1: Defining the model__
{{region radheatmap-getting-started-0}}
	public class TempInfo
	{
		public int Year { get; set; }
		public string Month { get; set; }
		public double Temperature { get; set; }
	}
{{endregion}}

## Setting up the Control

The control works with few different definitions that describe how to data will be shown. In this example we will use the CategoricalDefinition. The definition provides few properties to define what data should be used.

The __RowGroupMemberPath__ property contains the name of the property in the custom model that will be used to generate the rows.

The __ColumnGroupMemberPath__ property contains the name of the property in the custom model that will be used to generate the columns.

The __ValuePath__ property contains the name of the property in the custom model that will be used to generate the cells. Based on that value the cell will be colored differently.

To populate the control with data use its __ItemsSource__ property.

#### __[XAML] Example 2: Defining the heatmap__
{{region radheatmap-getting-started-1}}
	<telerik:RadHeatMap>
		<telerik:RadHeatMap.Definition>
			<telerik:CategoricalDefinition x:Name="categoricalDefinition"
										   RowGroupMemberPath="Year"
										   ColumnGroupMemberPath="Month"
										   ValuePath="Temperature" />
		</telerik:RadHeatMap.Definition>
	</telerik:RadHeatMap>
{{endregion}}

#### __[C#] Example 3: Creating the data and setting the ItemsSource__
{{region radheatmap-getting-started-2}}
	private void PrepareData()
	{
		int year = 2018;
		string[] months = new string[6] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
		var randomNumberGenerator = new Random();

		var source = new ObservableCollection<TempInfo>();
		for (int i = 0; i < months.Length; i++)
		{
			for (int k = 0; k < 6; k++)
			{
				var info = new TempInfo() { Year = year + k, Month = months[i], Temperature = randomNumberGenerator.Next(10, 300) };
				source.Add(info);
			}
		}

		this.categoricalDefinition.ItemsSource = source;
	}	
{{endregion}}

#### __Figure 1: RadHeatMap__
![](images/radheatmap-getting-started-0.png)

## Colorization

The heatmap control has a built-in colorizer that sets the color of each cell based on the plotted value. You can change the colors as you like by defining a new colorizer. You can read more about this in the [Colorizers]({%slug radheatmap-colorizers%}) article.

## See Also
* [Labels]({%slug radheatmap-labels%})
* [Populating With Data]({%slug radheatmap-populating-with-data%})
