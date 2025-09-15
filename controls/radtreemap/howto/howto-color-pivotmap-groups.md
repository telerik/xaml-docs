---
title: How to Change the Color of PivotMap Groups
page_title: How to Change the Color of PivotMap Groups
description: Check our &quot;How to change the color of PivotMap groups&quot; documentation article for the RadTreeMap {{ site.framework_name }} control.
slug: radpivotmap-howto-change-color-group
tags: bind,color,pivotmap,background,itemstyle
published: True
position: 2
---

# How to Change the Color of PivotMap Groups

This topic will show you how to change the colors of the PivotMap groups. 

For the purpose of this example, we will create the following model.

__Example 1: Create MovieInfo Model__
```C#
	public class MovieInfo
	{
		public string Genre { get; set; }
		public string Title { get; set; }
		public double GrossSales { get; set; }
	}
```

Next, we can go ahead and create sample data.

__Example 2: Create Sample Data__
```C#
	public class MainViewModel
	{
		public ObservableCollection<MovieInfo> Data { get; set; }
		public MainViewModel()
		{
			Data = GetData();
		}

		public ObservableCollection<MovieInfo> GetData()
		{
			ObservableCollection<MovieInfo> movies = new ObservableCollection<MovieInfo>()
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
	}
```

Now, we can declare our RadPivotMap control in XAML. To change the color of the groups, we can use the __ItemStyle__ of the TypeDefinition. This property is of type Style, which targets RadTreeMapItem. In the custom style, we can bind the Background property to the __DataItem__ object. The __DataItem__ is a wrapper for our business object. When we are using RadPivotMap control, the DataItem will hold the group and its items. The groups are represented by a __GroupingImpl<TGroupKey, TItem>()__ collection. Now to apply different colors, we can use __IValueConverter__. The converter will be applied to the binding of Background property. Inside the IValueConverter, we can check the Name of the collection and return different colors.

__Example 3: Declare our RadTreeMap in XAML__
```XAML
	<Window.Resources>
		<local:MyConverter x:Key="MyConverter"/>        
	</Window.Resources>
	<Grid>
		<telerik:RadPivotMap x:Name="radPivotMap"  
						ValuePath="GrossSales" 
						LabelPath="GrossSales"  
						ItemsSource="{Binding Data}"
						LabelFormat="{}{0:C0}">
			<telerik:RadPivotMap.GroupDefinitions>
				<telerik:GroupDefinition Member="Genre" >
					<telerik:GroupDefinition.ItemStyle>
						<Style TargetType="telerik:RadTreeMapItem">
							<Setter Property="Background" Value="{Binding DataItem,Converter={StaticResource MyConverter}}" />
						</Style>
					</telerik:GroupDefinition.ItemStyle>
				</telerik:GroupDefinition>
			</telerik:RadPivotMap.GroupDefinitions>
		</telerik:RadPivotMap>
	</Grid>
```

__Example 4: Create custom IValueConverter__
```C#
	public class MyConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var group = value as GroupingImpl<string,MovieInfo>;
			if(group != null)
			{
				if (group.Name.ToString() == "Adventure")
				{
					return Brushes.Bisque;
				}
				else if (group.Name.ToString() == "Action")
				{
					return Brushes.SkyBlue;
				}
				else if (group.Name.ToString() == "Comedy")
				{
					return Brushes.MediumTurquoise;
				}
				else if (group.Name.ToString() == "Horror")
				{
					return Brushes.IndianRed;
				}
			}
			   
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
```

And finally, we need to set our DataContext to the MainViewModel.

__Example 4: Setting our DataContext__
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();            
			this.DataContext = new MainViewModel();
		}
	}
```

If you run the application now, the RadPivotMap should display the following structure:

#### Figure 1: RadPivotMap with groups in different colors
![PivotMap Color Groups](images/radpivotmap-howto-change-color-group-1.png)

## See Also
* [Overview]({%slug radtreemap-overview %})
* [SDK Examples]({%slug radtreemap-sdk-examples %})
* [Populating With Data RadTreeMap]({%slug radtreemap-populating-with-data-radtreemap %})
* [Populating With Data RadPivotMap]({%slug radtreemap-populating-with-data-radpivotmap %})
