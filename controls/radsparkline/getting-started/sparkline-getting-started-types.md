---
title: Sparkline Types
page_title: Sparkline Types
description: Check our &quot;Sparkline Types&quot; documentation article for the RadSparkLine {{ site.framework_name }} control.
slug: radsparkline-getting-started-types
tags: visualization,types
published: True
position: 1
---

# Sparkline Types

The sparkline suite contains several controls that provide different visualization for the plotted data. See how to set up those in the [Getting Started]({%slug radsparkline-getting-started%}) article.

* __Line__: You can display the data as a set of points connected by a line via the __RadLinearSparkline__ control.

	![RadLinearSparkline](images/radsparkline-getting-started-types-0.png)

* __Scatter point__: You can display the data as a set of points via the __RadScatterSparkline__ control.

	![RadScatterSparkline](images/radsparkline-getting-started-types-1.png)
	
* __Area__: You can display the data as a set of points connected by a line forming a colored area via the __RadAreaSparkline__ control.

	![RadAreaSparkline](images/radsparkline-getting-started-types-2.png)
	
* __Column__: You can display the data as a set of columns (bars) via the __RadColumnSparkline__ control.

	![RadColumnSparkline](images/radsparkline-getting-started-types-3.png)
	
* __Win/Loss__: You can display the data as a set of equally sized columns (bars) that indicate positive/negative values, via the __RadColumnSparkline__ control.
	
	![RadColumnSparkline](images/radsparkline-getting-started-types-4.png)

## Type-Specific Properties

This section will go over the properties that are specific for each type of sparkline. For the purposes of the next examples, we will setup the model and viewmodel shown in __Example 1__.

__Example 1: Setting up the model and viewmodel__
```C#	
	public class MyCost
	{
		public double Cost { get; set; }
		public double UnitCost { get; set; }
	}

	public class ViewModel
    {
        private ObservableCollection<MyCost> costs;

        public ObservableCollection<MyCost> Costs
        {
            get
            {
                if (this.costs == null)
                {
                    this.costs = new ObservableCollection<MyCost>()
                                {
                                    new MyCost() { Cost = 1, UnitCost = 2},
                                    new MyCost() { Cost = 2, UnitCost = 4},
                                    new MyCost() { Cost = 3, UnitCost = 6 },
                                    new MyCost() { Cost = 4, UnitCost = 4},
                                    new MyCost() { Cost = 5, UnitCost = -1},
                                };
                }

                return this.costs;
            }
        }
    }
```
```VB.NET	
	Public Class MyCost
		Public Property Cost() As Double
		Public Property UnitCost() As Double
	End Class

	Public Class ViewModel
		Private _costs As ObservableCollection(Of MyCost)

		Public ReadOnly Property Costs() As ObservableCollection(Of MyCost)
			Get
				If Me._costs Is Nothing Then
					Me._costs = New ObservableCollection(Of MyCost)() From {
						New MyCost() With {
							.Cost = 1,
							.UnitCost = 2
						},
						New MyCost() With {
							.Cost = 2,
							.UnitCost = 4
						},
						New MyCost() With {
							.Cost = 3,
							.UnitCost = 6
						},
						New MyCost() With {
							.Cost = 4,
							.UnitCost = 4
						},
						New MyCost() With {
							.Cost = 5,
							.UnitCost = -1
						}
					}
				End If

				Return Me._costs
			End Get
		End Property
	End Class
```


#### RadLinearSparkline

* __ShowNormalRange__: A boolean property indicating whether or not to display a rectangle indicating what is the normal range for the displayed values. In order for the normal range to be displayed, you have to set the __NormalRangeTop__ and __NormalRangeBottom__ properties as well. 
* __NormalRangeTop__: The value used as the top of the normal range.
* __NormalRangeBottom__: The value used as the bottom of the normal range.
* __NormalRangeFill__: The brush used as the fill of the normal range. 
* __LineStroke__: The brush used for the line representing the data. 
* __LineShapeStyle__: The style, which will be applied to the line. The __TargetType__ of the Style should be __Polyline__. 

>important If the Stroke property is set through the LineShapeStyle along with the LineStroke property, the value of the LineStroke property will be respected. 

__Example 2: Setting up the RadLinearSparkline__
```XAML	
	<Grid>
		<Grid.DataContext>
			<local:ViewModel />
		</Grid.DataContext>
		<Grid.Resources>
			<Style x:Key="LineShapeStyle" TargetType="Polyline">
				<Setter Property="StrokeThickness" Value="5" />
			</Style>
		</Grid.Resources>

		<telerik:RadLinearSparkline Width="400"
									Height="200"
									ItemsSource="{Binding Costs}"
									ShowNormalRange="True"
									NormalRangeTop="5"
									NormalRangeBottom="2"
									NormalRangeFill="Yellow"
									LineStroke="Red"
									LineShapeStyle="{StaticResource LineShapeStyle}"
									XValuePath="Cost"
									YValuePath="UnitCost" />
	</Grid>
```

#### __Figure 1: Result from Example 2__
![RadLinearSparkline](images/radlinearsparkline-type-specific.png)

#### RadScatterSparkline
* __ShowNormalRange__: A boolean property indicating whether or not to display a rectangle indicating what is the normal range for the displayed values. In order for the normal range to be displayed, you have to set the __NormalRangeTop__ and __NormalRangeBottom__ properties as well. 
* __NormalRangeTop__: The value used as the top of the normal range.
* __NormalRangeBottom__: The value used as the bottom of the normal range.
* __NormalRangeFill__: The brush used as the fill of the normal range. 
* __ItemFill__: The brush that will be used for the fill of the ellipses representing the data. 
* __ItemStyle__: This property allows you to apply a style for the items representing the data. The __TargetType__ of the Style should be __telerik:ScatterItem__. Use this property, if you want to change the shape with which the data points are visualized. 

__Example 3: Setting up the RadScatterSparkline__
```XAML	
	<Grid>
		<Grid.DataContext>
			<local:ViewModel />
		</Grid.DataContext>
		<Grid.Resources>
			<Style x:Key="ItemStyle" TargetType="telerik:ScatterItem">
				<Setter Property="Template">
					<Setter.Value>
						<ControlTemplate TargetType="telerik:ScatterItem">
							<Rectangle Fill="{TemplateBinding Fill}"
							Height="15" Width="15"  />
						</ControlTemplate>
					</Setter.Value>
				</Setter>
			</Style>
		</Grid.Resources>

		<!-- Set the ItemStyle property, if you want to change how the data points are represented-->
		<!-- ItemStyle="{StaticResource ItemStyle}" -->
		<telerik:RadScatterSparkline Width="400"
									 Height="100"
									 ItemsSource="{Binding Costs}"
									 ShowNormalRange="True"
									 NormalRangeTop="5"
									 NormalRangeBottom="2"
									 NormalRangeFill="Yellow"
									 ItemFill="Red"
									 XValuePath="Cost"
									 YValuePath="UnitCost" />
	</Grid>
```

#### __Figure 2: Result from Example 3__
![RadScatterSparkline](images/radscattersparkline-type-specific.png)

#### RadAreaSparkline
* __PositiveAreaFill__: The brush that will be used for the fill of the positive part of the data. 
* __PositiveAreaStroke__: The brush that will be used for the line surrounding the positive part of the data. 
* __PositiveLineShapeStyle__: The style that will be applied to the polyline surrounding the positive part of the data. The __TargetType__ of this style should be __Polyline__.
* __PositiveAreaShapeStyle__: The style that will be applied to the shape representing the positive part of the data. The __TargetType__ of this style should be __Polyline__.
* __NegativeAreaFill__: The brush that will be used for the fill of the negative part of the data. 
* __NegativeAreaStroke__: The brush that will be used for the line surrounding the negative part of the data. 
* __NegativeLineShapeStyle__: The style that will be applied to the polyline surrounding the negative part of the data. The __TargetType__ of this style should be __Polyline__.
* __NegativeAreaShapeStyle__: The style that will be applied to the shape representing the negative part of the data. The __TargetType__ of this style should be __Polyline__.

__Example 4: Setting up the RadAreaSparkline__
```XAML	
	<Grid>
		<Grid.DataContext>
			<local:ViewModel />
		</Grid.DataContext>
		<Grid.Resources>
			<Style x:Key="PositiveLineShapeStyle" TargetType="Polyline">
				<Setter Property="StrokeDashArray" Value="5" />
			</Style>
			<Style x:Key="NegativeLineShapeStyle" TargetType="Polyline">
				<Setter Property="StrokeDashArray" Value="5" />
			</Style>
		</Grid.Resources>
		
		<telerik:RadAreaSparkline Width="400"
								  Height="100"
								  ItemsSource="{Binding Costs}"
								  PositiveAreaFill="Green"
								  PositiveAreaStroke="Black"
								  PositiveLineShapeStyle="{StaticResource PositiveLineShapeStyle}"
								  NegativeAreaFill="Red"
								  NegativeAreaStroke="Blue"
								  NegativeLineShapeStyle="{StaticResource NegativeLineShapeStyle}"
								  XValuePath="Cost"
								  YValuePath="UnitCost" />
	</Grid>
```

#### __Figure 3: Result from Example 4__
![RadAreaSparkline](images/radareasparkline-type-specific.png)

#### RadColumnSparkline
* __ColumnLayoutMode__: Determines how the column representing the data points will be positioned. Takes a [ColumnLayoutMode](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.sparklines.columnlayoutmode) as a value. 
* __ColumnWidthPercent__: Specifies how much of the allocated space will the columns take. The space available for one column is calculated by dividing the entire space by the number of items. 

__Example 5: Setting up the RadColumnSparkline__
```XAML	
	<Grid>
		<Grid.DataContext>
			<local:ViewModel />
		</Grid.DataContext>

		<telerik:RadColumnSparkline Width="400"
									Height="100"
									ItemsSource="{Binding Costs}"
									ColumnLayoutMode="Normal"
									ColumnWidthPercent="0.2"
									XValuePath="Cost"
									YValuePath="UnitCost" />
	</Grid>
```

#### __Figure 4: Result from Example 5__
![RadColumnSparkline](images/radcolumnsparkline-type-specific.png)
	

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Sparklines Component](https://www.telerik.com/products/wpf/sparklines.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [Indicators]({%slug radsparkline-features-indicators%})
* [Data Binding]({%slug radsparkline_databinding%})