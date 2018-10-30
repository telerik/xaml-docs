---
title: Getting Start with RadPivotMap
page_title: Getting Start with RadPivotMap
description: Getting Start with RadPivotMap
slug: radtreemap-getting-started-pivotmap
tags: getting-started, pivotmap
published: True
position: 1
---

# Getting Start with RadPivotMap

This tutorial will walk you through the creation of a sample application that contains __RadPivotMap__ control.
			
## Assembly References

In order to use RadPivotMap, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Setting up the Data Source

To populate the control with tiles you will need to provide a collection of items that will be assigned to its __ItemsSource__ property. 

For this example we will use a simple flat structure consisting of movies gross sales information.

#### __[C#] Example 1: Defining the models__
{{region radtreemap-getting-started-pivotmap-0}}
	public class MovieInfo
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public double GrossSales { get; set; }
    }
{{endregion}}

#### __[C#] Example 2: Populating a collection with the data__
{{region radtreemap-getting-started-pivotmap-1}}
	public ObservableCollection<MovieInfo> GetData()
	{
		var movies = new ObservableCollection<MovieInfo>()
		{
			new MovieInfo() { Genre = "Adventure", Title = "Toy Story 3", GrossSales = 415004880 },
			new MovieInfo() { Genre = "Adventure", Title = "Iron Man 3", GrossSales = 409013994 },
			new MovieInfo() { Genre = "Adventure", Title = "Tangled", GrossSales = 200821936 },
			new MovieInfo() { Genre = "Adventure", Title = "The Karate Kid", GrossSales = 176591618 },
			new MovieInfo() { Genre = "Action", Title = "Avatar", GrossSales = 760507625 },
			new MovieInfo() { Genre = "Action", Title = "Sherlock Holmes", GrossSales = 186848418 },
			new MovieInfo() { Genre = "Action", Title = "Red", GrossSales = 130380162 },
			new MovieInfo() { Genre = "Comedy", Title = "Despicable Me 3", GrossSales = 264624300 },
			new MovieInfo() { Genre = "Comedy", Title = "Easy A", GrossSales = 158401464 },
			new MovieInfo() { Genre = "Comedy", Title = "Superbad", GrossSales = 61979680 },
			new MovieInfo() { Genre = "Comedy", Title = "Date Night", GrossSales = 121463226 },
			new MovieInfo() { Genre = "Horror", Title = "The Ring", GrossSales = 129128133 },
			new MovieInfo() { Genre = "Horror", Title = "The Grudge", GrossSales = 110359362 },
		};
		return movies;
	}
{{endregion}}

## Setting up the RadPivotMap

To set up the control you can set few esential properties - __ItemsSource__, __ValuePath__ and __GroupDefinitions__. The GroupDefinitions is a collection of GroupDefinition objects which contain information that tells the pivot map how to fetch the groups from the  objects in the ItemsSource. 

The __ValuePath__ determines the size of the tile.

The __Member__ determines the name of the corresponding group.

The __LabelPath__ determines the label that will be displayed over the tile.

#### __[XAML] Example 3: Defining RadPivotMap__
{{region radtreemap-getting-started-pivotmap-2}}
	<telerik:RadPivotMap x:Name="radPivotMap" 
						 ValuePath="GrossSales"
						 LabelPath="GrossSales" 
						 LabelFormat="{}{0:C0}">            
            <telerik:RadPivotMap.GroupDefinitions>
                <telerik:GroupDefinition Member="Genre" />
                <telerik:GroupDefinition Member="Title" />
            </telerik:RadPivotMap.GroupDefinitions>            
        </telerik:RadPivotMap>
{{endregion}}

#### __[XAML] Example 4: Setting the ItemsSource in XAML__
{{region radtreemap-getting-started-pivotmap-3}}
	<telerik:RadPivotMap ItemsSource="{Binding MyDataSourceProperty}" />
{{endregion}}

#### __[XAML] Example 4: Setting the ItemsSource in code (see Example 2)__
{{region radtreemap-getting-started-pivotmap-4}}
	this.radPivotMap.ItemsSource = GetData();
{{endregion}}

#### Figure 1: RadPivotMap
![](images/radtreemap-getting-started-pivotmap-0.png)

## See Also  
* [Mappings]({%slug radtreemap-mappings%})
* [Colorizers]({%slug radtreemap-colorizers%})