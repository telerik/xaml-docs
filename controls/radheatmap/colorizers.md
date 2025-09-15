---
title: Colorizers
page_title: Colorizers
description: Check our &quot;Colorizers&quot; documentation article for the RadHeatMap {{ site.framework_name }} control.
slug: radheatmap-colorizers
tags: colorizers
published: True
position: 4
---

# Colorizers

## Colorizers in a Horizontal/Vertical Definition

In the scenario of Horizontal/Vertical Definition, the colorizer is defined in the MemberMappings of the corresponding definition.

>The only difference between the two definitions is that for the horizontal definition each item gets a row, while the vertical – a column.

Here is our sample RadHeatMap:

#### __C#__
```C#
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
			radHeatMap.Definition.ItemsSource = CreateData();
		}
	
		public List<Car> CreateData()
		{
			var temp = new List<Car>()
			{
				new Car() {Name = "Car 1", Price = 20590, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
				new Car() {Name = "Car 2", Price = 21990, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
				new Car() {Name = "Car 3", Price = 23200, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
				new Car() {Name = "Car 4", Price = 27500, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
				new Car() {Name = "Car 5", Price = 28200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
				new Car() {Name = "Car 6", Price = 29500, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
				new Car() {Name = "Car 7", Price = 31200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
				new Car() {Name = "Car 8", Price = 32200, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
	            new Car() {Name = "Car 9", Price = 35200, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },
	            new Car() {Name = "Car 10", Price = 36700, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },
	            new Car() {Name = "Car 11", Price = 38200, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
	            new Car() {Name = "Car 12", Price = 39700, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
	            new Car() {Name = "Car 13", Price = 41500, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
	            new Car() {Name = "Car 14", Price = 42200, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
	            new Car() {Name = "Car 15", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
	            new Car() {Name = "Car 16", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
			};
	
			return temp;
		}
	}
	public class Car
	{
		public string Name { get; set; }
		public int MilesPerGallon { get; set; }
		public int TopSpeed { get; set; }
		public int Price { get; set; }
		public int HorsePower { get; set; }
	}
```

#### __VB.NET__
```VB.NET
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			radHeatMap.Definition.ItemsSource = CreateData()
		End Sub
	
		Public Function CreateData() As List(Of Car)
			Dim temp = New List(Of Car)()
			From {New Car() With {.Name = "Car 1", .Price = 20590, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
			New Car() With {.Name = "Car 2", .Price = 21990, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
			New Car() With {.Name = "Car 3", .Price = 23200, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
			New Car() With {.Name = "Car 4", .Price = 27500, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
			New Car() With {.Name = "Car 5", .Price = 28200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
			New Car() With {.Name = "Car 6", .Price = 29500, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
			New Car() With {.Name = "Car 7", .Price = 31200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
			New Car() With {.Name = "Car 8", .Price = 32200, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
			New Car() With {.Name = "Car 9", .Price = 35200, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
			New Car() With {.Name = "Car 10", .Price = 36700, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
			New Car() With {.Name = "Car 11", .Price = 38200, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
			New Car() With {.Name = "Car 12", .Price = 39700, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
			New Car() With {.Name = "Car 13", .Price = 41500, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
			New Car() With {.Name = "Car 14", .Price = 42200, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
			New Car() With {.Name = "Car 15", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162},
			New Car() With {.Name = "Car 16", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162}}
			
			Return temp
		End Function
	End Class
	
	Public Class Car
		Public Property Name() As String
		Public Property MilesPerGallon() As Integer
		Public Property TopSpeed() As Integer
		Public Property Price() As Integer
		Public Property HorsePower() As Integer
	End Class
```

#### __XAML__
```XAML
	<Grid x:Name="LayoutRoot" Background="White" Width="800" Height="600">
	    <Grid.RowDefinitions>
	        <RowDefinition Height="15*"/>
	        <RowDefinition Height="*"/>
	    </Grid.RowDefinitions>
	
	    <telerik:RadHeatMap x:Name="radHeatMap" ShowToolTips="True" CellBorderThickness="1" FontSize="20">
	        <telerik:RadHeatMap.Definition>
	            <telerik:HorizontalDefinition HeaderPath="Name">
	                <telerik:MemberMapping Header="Price" ValuePath="Price"/>
	                <telerik:MemberMapping Header="Horse Power" ValuePath="HorsePower"/>
	                <telerik:MemberMapping Header="MPG" ValuePath="MilesPerGallon"/>
	                <telerik:MemberMapping Header="Top Speed" ValuePath="TopSpeed" />
	            </telerik:HorizontalDefinition>
	        </telerik:RadHeatMap.Definition>
	    </telerik:RadHeatMap>
	
	    <Grid Grid.Row="1" Width="250" HorizontalAlignment="Right">
	        <Grid.ColumnDefinitions>
	            <ColumnDefinition Width="Auto" />
	            <ColumnDefinition />
	            <ColumnDefinition Width="Auto" />
	        </Grid.ColumnDefinitions>
	        <TextBlock Grid.Column="0" Text="low" VerticalAlignment="Center" FontSize="13" />
	        <TextBlock Grid.Column="2" Text="high" VerticalAlignment="Center" FontSize="13" />
	        <Border Grid.Column="1" Margin="4">
	            <Border.Background>
	                <LinearGradientBrush>
	                    <GradientStop Offset="0.0" Color="#D9E7F1"/>
	                    <GradientStop Offset="0.25" Color="#A4C2D8"/>
	                    <GradientStop Offset="0.5" Color="#6E9CBF"/>
	                    <GradientStop Offset="0.75" Color="#3776A5"/>
	                    <GradientStop Offset="1.0" Color="#01518C"/>
	                </LinearGradientBrush>
	            </Border.Background>
	        </Border>
	
	    </Grid>
	</Grid>
```

>The legend below the HeatMap is put for later use in this help topic.         

The result can be seen below:

![RadHeatMap_colorizers_01png](images/RadHeatMap_colorizers_01.png)

As you may have already noticed, there is no colorizer to be seen in the provided code so far. When there is no colorizer specified, RadHeatMap uses a default one. It is a __HeatMapValueGradientColorizer__.        

__HeatMapValueGradientColorizer__

A colorizer, which contains a set of GradientStops. It chooses a color to be applied according to the values of the items in RadHeatMap and the colorizer’s gradient stops. Depending on the IsAbsolute property value,  each GradientStop.Offset value can be absolute or relative. A colorizer is relative when IsAbsolute is false, which is its default value. In this mode, the colorizer scans all values to find the smallest and greatest ones. In the same manner, these two correspond to GradientStop.Offsets 0 and 1. Also, by setting the RangeMinimum and RangeMaximum properties, you are specifying which are the actual minimum and maximum values , i.e. you are defining some values to correspond to offsets 0 and 1. In absolute mode, the offsets are set to the actual values, which are expected for the items in RadHeatMap        

>When the same instance of any relative colorizer is applied to more than one row or column, the colorizer shares the minimum and maximum between all the assigned rows or columns.          

Now, this is how a HeatMapValueGradientColorizer is defined:

#### __C#__
```C#
	HeatMapValueGradientColorizer ValueGradientColorizer1 = new HeatMapValueGradientColorizer();
	ValueGradientColorizer1.GradientStops.Add(new GradientStop() { Color = new Color() {R = 217, G = 231, B = 241, A = 255 }, Offset = 0 });
	ValueGradientColorizer1.GradientStops.Add(new GradientStop() { Color = new Color() { R = 1, G = 81, B = 140, A = 255 }, Offset = 1 });
	memberMapping1.Colorizer = ValueGradientColorizer1;
```

#### __VB.NET__
```VB.NET
	Dim ValueGradientColorizer1 As New HeatMapValueGradientColorizer()
	ValueGradientColorizer1.GradientStops.Add(New GradientStop() With { _
		Key .Color = New Color() With { _
			Key .R = 217, _
			Key .G = 231, _
			Key .B = 241, _
			Key .A = 255 _
		}, _
		Key .Offset = 0 _
	})
	ValueGradientColorizer1.GradientStops.Add(New GradientStop() With { _
		Key .Color = New Color() With { _
			Key .R = 1, _
			Key .G = 81, _
			Key .B = 140, _
			Key .A = 255 _
		}, _
		Key .Offset = 1 _
	})
	memberMapping1.Colorizer = ValueGradientColorizer1
```

The same code in XAML will look like this:

#### __XAML__
```XAML
	<telerik:HeatMapValueGradientColorizer x:Key="ValueGradientColorizer1">
	    <GradientStop Offset="0" Color="#D9E7F1" />
	    <GradientStop Offset="1" Color="#01518C" />
	</telerik:HeatMapValueGradientColorizer>
```

>When a value is smaller than the already set RangeMinimum, it gets that color. The same goes for RangeMaximum. This applies for all the types of colorizers.          

Let’s apply a colorizer to the already defined MemberMappings:

#### __XAML__
```XAML
	<telerik:MemberMapping Header="Horse Power" ValuePath="HorsePower" Colorizer="{StaticResource ValueGradientColorizer1}"/>
```

Here is the result where the value corresponding to offset 0 is 70 , and to offset 1 – 306:

![RadHeatMap_colorizers_02png](images/RadHeatMap_colorizers_02.png)

__HeatMapRangeColorizer__

A colorizer, which uses a set of colors, where each of them corresponds to a range. Similarly to HeatMapValueGradientColorizer, the HeatMapRangeColorizer can work in absolute and relative mode. In absolute mode, the range is specified in actual values, the ones expected for the items to have. In relative mode, the range is always between 0 and 1. The HeatMapRangeColorizer has no property which corresponds to RangeMinimum and RangeMaximum and the colorizer always looks for the smallest and greatest values.


Let’s define an absolute HeatMapRangeColorizer and apply it to Miles per Gallon column.

#### __C#__
```C#
	HeatMapRangeColorizer RangeColorizer1 = new HeatMapRangeColorizer() { IsAbsolute = true };
	RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 217, G = 231, B = 241, A = 255 }, From = 19, To = 22 });
	RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 164, G = 194, B = 216, A = 255 }, From = 23, To = 26 });
	RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 110, G = 156, B = 191, A = 255 }, From = 27, To = 30 });
	RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 55, G = 118, B = 165, A = 255 }, From = 31, To = 34 });
	RangeColorizer1.Colors.Add(new HeatMapRangeColor() { Color = new Color() { R = 1, G = 81, B = 140, A = 255 }, From = 35, To = 40 });
	memberMapping2.Colorizer = RangeColorizer1;
```

#### __VB.NET__
```VB.NET
	Dim RangeColorizer1 As New HeatMapRangeColorizer() With { _
		Key .IsAbsolute = True _
	}
	RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
		Key .Color = New Color() With { _
			Key .R = 217, _
			Key .G = 231, _
			Key .B = 241, _
			Key .A = 255 _
		}, _
		Key .From = 19, _
		Key .[To] = 22 _
	})
	RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
		Key .Color = New Color() With { _
			Key .R = 164, _
			Key .G = 194, _
			Key .B = 216, _
			Key .A = 255 _
		}, _
		Key .From = 23, _
		Key .[To] = 26 _
	})
	RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
		Key .Color = New Color() With { _
			Key .R = 110, _
			Key .G = 156, _
			Key .B = 191, _
			Key .A = 255 _
		}, _
		Key .From = 27, _
		Key .[To] = 30 _
	})
	RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
		Key .Color = New Color() With { _
			Key .R = 55, _
			Key .G = 118, _
			Key .B = 165, _
			Key .A = 255 _
		}, _
		Key .From = 31, _
		Key .[To] = 34 _
	})
	RangeColorizer1.Colors.Add(New HeatMapRangeColor() With { _
		Key .Color = New Color() With { _
			Key .R = 1, _
			Key .G = 81, _
			Key .B = 140, _
			Key .A = 255 _
		}, _
		Key .From = 35, _
		Key .[To] = 40 _
	})
	memberMapping2.Colorizer = RangeColorizer1
```

The same code in XAML would look like this:

#### __XAML__
```XAML
	<telerik:HeatMapRangeColorizer x:Key="RangeColorizer1" IsAbsolute="True">
	    <telerik:HeatMapRangeColor From="19" To="22" Color="#D9E7F1"/>
	    <telerik:HeatMapRangeColor From="23" To="26" Color="#A4C2D8"/>
	    <telerik:HeatMapRangeColor From="27" To="30" Color="#6E9CBF"/>
	    <telerik:HeatMapRangeColor From="31" To="34" Color="#3776A5"/>
	    <telerik:HeatMapRangeColor From="35" To="40" Color="#01518C"/>
	</telerik:HeatMapRangeColorizer>
	<telerik:MemberMapping Header="MPG" ValuePath="MilesPerGallon" Colorizer="{StaticResource RangeColorizer1}"/>
```

And the result

![RadHeatMap_colorizers_03png](images/RadHeatMap_colorizers_03.png)

__HeatMapDesaturationColorizer__

It reduces the level of saturation of a given StartColor depending on the RadHeatMapItem value. The level of desaturation can be controlled using From and To properties. When the From property equals 0 it means that you can get a completely white color for the smallest value. If it is set to a value greater than 0, for example 0.1, the smallest value will have a really faded StartColor but not completely white. On the other hand if To is set to 0.8, you will get a somewhat faded StartColor for the greatest value. Like the other colorizers, the HeatMapDesaturationColorizer has relative and absolute modes which are set again through the IsAbsolute property. In relative, the colorizer looks for the smallest and greatest values from the items, or they can be set through the RangeMinimum and RangeMaximum colors. In absolute mode, these two properties have to be set or, otherwise RadHeatMap will throw an exception.        

This is how HeatMapDesaturationColorizer is defined and applied:

#### __C#__
```C#
	HeatMapDesaturationColorizer DesaturationColorizer1 = new HeatMapDesaturationColorizer()
	{
	    StartColor = new Color() { R = 1, G = 81, B = 140, A = 255 },
	    To = 0.1,
	};
	memberMapping3.Colorizer = DesaturationColorizer1;
```

#### __VB.NET__
```VB.NET
	Dim DesaturationColorizer1 As New HeatMapDesaturationColorizer() With { _
		Key .StartColor = New Color() With { _
			Key .R = 1, _
			Key .G = 81, _
			Key .B = 140, _
			Key .A = 255 _
		}, _
		Key .[To] = 0.1 _
	}
	memberMapping3.Colorizer = DesaturationColorizer1
```

#### __XAML__
```XAML
	<telerik:HeatMapDesaturationColorizer x:Key="DesaturationColorizer1" To="0.1" StartColor="#01518C"/>
	<telerik:MemberMapping Header="Price" ValuePath="Price" Colorizer="{StaticResource DesaturationColorizer1}"/>
```

The result, where there is no complete white, nor green.

![RadHeatMap_colorizers_04png](images/RadHeatMap_colorizers_04.png)

The complete code of the example:        

#### __C#__
```C#
	public partial class MainPage : UserControl
	{
	    public MainPage()
	    {
	        InitializeComponent();            
	        radHeatMap.Definition.ItemsSource = CreateData();
	    }
	
	    public List<Car> CreateData()
	    {
	        var result = new List<Car>()
	        {
	            new Car() {Name = "Car 1", Price = 20590, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
	            new Car() {Name = "Car 2", Price = 21990, HorsePower = 70,  MilesPerGallon = 37, TopSpeed = 60 },
	            new Car() {Name = "Car 3", Price = 23200, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
	            new Car() {Name = "Car 4", Price = 27500, HorsePower = 140, MilesPerGallon = 28, TopSpeed = 110 },
	            new Car() {Name = "Car 5", Price = 28200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
	            new Car() {Name = "Car 6", Price = 29500, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
	            new Car() {Name = "Car 7", Price = 31200, HorsePower = 160, MilesPerGallon = 31, TopSpeed = 120 },
	            new Car() {Name = "Car 8", Price = 32200, HorsePower = 90,  MilesPerGallon = 35, TopSpeed = 80 },
	            new Car() {Name = "Car 9", Price = 35200, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },
	            new Car() {Name = "Car 10", Price = 36700, HorsePower = 115, MilesPerGallon = 29, TopSpeed = 90 },                
	            new Car() {Name = "Car 11", Price = 38200, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
	            new Car() {Name = "Car 12", Price = 39700, HorsePower = 130, MilesPerGallon = 24, TopSpeed = 140 },
	            new Car() {Name = "Car 13", Price = 41500, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
	            new Car() {Name = "Car 14", Price = 42200, HorsePower = 326, MilesPerGallon = 16, TopSpeed = 150 },
	            new Car() {Name = "Car 15", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
	            new Car() {Name = "Car 16", Price = 43500, HorsePower = 276, MilesPerGallon = 25, TopSpeed = 162 },
	        };
	
	        return result;
	    }
	}
	
	public class Car
	{
	    public string Name { get; set; }
	    public int MilesPerGallon { get; set; }
	    public int TopSpeed { get; set; }
	    public int Price { get; set; }
	    public int HorsePower { get; set; }
	}
```

#### __VB.NET__
```VB.NET
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			radHeatMap.Definition.ItemsSource = CreateData()
		End Sub
	
		Public Function CreateData() As List(Of Car)
			Dim temp = New List(Of Car)()
			From {New Car() With {.Name = "Car 1", .Price = 20590, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
			New Car() With {.Name = "Car 2", .Price = 21990, .HorsePower = 70, .MilesPerGallon = 37, .TopSpeed = 60},
			New Car() With {.Name = "Car 3", .Price = 23200, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
			New Car() With {.Name = "Car 4", .Price = 27500, .HorsePower = 140, .MilesPerGallon = 28, .TopSpeed = 110},
			New Car() With {.Name = "Car 5", .Price = 28200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
			New Car() With {.Name = "Car 6", .Price = 29500, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
			New Car() With {.Name = "Car 7", .Price = 31200, .HorsePower = 160, .MilesPerGallon = 31, .TopSpeed = 120},
			New Car() With {.Name = "Car 8", .Price = 32200, .HorsePower = 90, .MilesPerGallon = 35, .TopSpeed = 80},
			New Car() With {.Name = "Car 9", .Price = 35200, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
			New Car() With {.Name = "Car 10", .Price = 36700, .HorsePower = 115, .MilesPerGallon = 29, .TopSpeed = 90},
			New Car() With {.Name = "Car 11", .Price = 38200, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
			New Car() With {.Name = "Car 12", .Price = 39700, .HorsePower = 130, .MilesPerGallon = 24, .TopSpeed = 140},
			New Car() With {.Name = "Car 13", .Price = 41500, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
			New Car() With {.Name = "Car 14", .Price = 42200, .HorsePower = 326, .MilesPerGallon = 16, .TopSpeed = 150},
			New Car() With {.Name = "Car 15", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162},
			New Car() With {.Name = "Car 16", .Price = 43500, .HorsePower = 276, .MilesPerGallon = 25, .TopSpeed = 162}}
			
			Return temp
		End Function
	End Class
	
	Public Class Car
		Public Property Name() As String
		Public Property MilesPerGallon() As Integer
		Public Property TopSpeed() As Integer
		Public Property Price() As Integer
		Public Property HorsePower() As Integer
	End Class
```

#### __XAML__
```XAML
	<UserControl.Resources>
	    <telerik:HeatMapValueGradientColorizer x:Key="ValueGradientColorizer1">
	        <GradientStop Offset="0" Color="#D9E7F1" />
	        <GradientStop Offset="1" Color="#01518C" />
	    </telerik:HeatMapValueGradientColorizer>
	    <telerik:HeatMapValueGradientColorizer x:Key="ValueGradientColorizer2">
	        <GradientStop Offset="0" Color="#D9E7F1" />
	        <GradientStop Offset="1" Color="#01518C" />
	    </telerik:HeatMapValueGradientColorizer>
	    <telerik:HeatMapRangeColorizer x:Key="RangeColorizer1" IsAbsolute="True">
	        <telerik:HeatMapRangeColor From="19" To="22" Color="#D9E7F1"/>
	        <telerik:HeatMapRangeColor From="23" To="26" Color="#A4C2D8"/>
	        <telerik:HeatMapRangeColor From="27" To="30" Color="#6E9CBF"/>
	        <telerik:HeatMapRangeColor From="31" To="34" Color="#3776A5"/>
	        <telerik:HeatMapRangeColor From="35" To="40" Color="#01518C"/>
	    </telerik:HeatMapRangeColorizer>
	    <telerik:HeatMapDesaturationColorizer x:Key="DesaturationColorizer1" To="0.1" StartColor="#01518C"/>
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot" Background="White" Width="800" Height="600">
	    <Grid.RowDefinitions>
	        <RowDefinition Height="15*"/>
	        <RowDefinition Height="*"/>
	    </Grid.RowDefinitions>
	
	    <telerik:RadHeatMap x:Name="radHeatMap" ShowToolTips="True" CellBorderThickness="1" FontSize="20">
	        <telerik:RadHeatMap.Definition>
	            <telerik:HorizontalDefinition HeaderPath="Name">
	                <telerik:MemberMapping x:Name="memberMapping1" Header="Price" ValuePath="Price" Colorizer="{StaticResource DesaturationColorizer1}"/>
	                <telerik:MemberMapping x:Name="memberMapping2" Header="Horse Power" ValuePath="HorsePower" Colorizer="{StaticResource ValueGradientColorizer1}"/>
	                <telerik:MemberMapping x:Name="memberMapping3" Header="MPG" ValuePath="MilesPerGallon" Colorizer="{StaticResource RangeColorizer1}"/>
	                <telerik:MemberMapping x:Name="memberMapping4" Header="Top Speed" ValuePath="TopSpeed" Colorizer="{StaticResource ValueGradientColorizer2}"/>
	            </telerik:HorizontalDefinition>
	        </telerik:RadHeatMap.Definition>
	    </telerik:RadHeatMap>
	
	    <Grid Grid.Row="1" Width="250" HorizontalAlignment="Right">
	        <Grid.ColumnDefinitions>
	            <ColumnDefinition Width="Auto" />
	            <ColumnDefinition />
	            <ColumnDefinition Width="Auto" />
	        </Grid.ColumnDefinitions>
	        <TextBlock Grid.Column="0" Text="low" VerticalAlignment="Center" FontSize="13" />
	        <TextBlock Grid.Column="2" Text="high" VerticalAlignment="Center" FontSize="13" />
	        <Border Grid.Column="1" Margin="4">
	            <Border.Background>
	                <LinearGradientBrush>
	                    <GradientStop Offset="0.0" Color="#D9E7F1"/>
	                    <GradientStop Offset="0.25" Color="#A4C2D8"/>
	                    <GradientStop Offset="0.5" Color="#6E9CBF"/>
	                    <GradientStop Offset="0.75" Color="#3776A5"/>
	                    <GradientStop Offset="1.0" Color="#01518C"/>
	                </LinearGradientBrush>
	            </Border.Background>
	        </Border>
	
	    </Grid>
	</Grid>
```

![RadHeatMap_colorizers_05jpg](images/RadHeatMap_colorizers_05.jpg)

## Colorizers in Categorical Definition

The only difference between the Categorical and the Horizontal/Vertical definition is that in the Categorical only one colorizer at a time can be applied. Besides this, the colorizers behave in the same way. 
Here is a little demonstration:        

#### __C#__
```C#
	public MainPage()
	{
	    InitializeComponent();            
	    radHeatMap.Definition.ItemsSource = CreateWeatherData();
	}
	
	public List<MonthlyTemp> CreateWeatherData()
	{
	    var time = new DateTime(2004, 1, 1);
	    var result = new List<MonthlyTemp>();
	    Random r = new Random();
	
	    for (int i = 0; i < 5; i++)
	    {
	        for (int a = 0; a < 3; a++)
	        {
	            result.Add(new MonthlyTemp(time, r.Next(0, 10)));
	            time = time.AddMonths(1);
	        }
	        for (int a = 0; a < 3; a++)
	        {
	            result.Add(new MonthlyTemp(time, r.Next(10, 20)));
	            time = time.AddMonths(1);
	        }
	        for (int a = 0; a < 3; a++)
	        {
	            result.Add(new MonthlyTemp(time, r.Next(20, 30)));
	            time = time.AddMonths(1);
	        }
	        for (int a = 0; a < 3; a++)
	        {
	            result.Add(new MonthlyTemp(time, r.Next(10, 20)));
	            time = time.AddMonths(1);
	        }
	    }            
	    return result;
	}
	
	public class MonthlyTemp
	{
	    public DateTime Time { get; set; }
	    public double Temp { get; set; }
	    public MonthlyTemp(DateTime time, double temp)
	    {
	        this.Time = time;
	        this.Temp = temp;
	    }
	}
```

#### __VB.NET__
```VB.NET
	Public Function CreateWeatherData() As List(Of MonthlyTemp)
		Dim time = New Date(2004, 1, 1)
		Dim data = New List(Of MonthlyTemp)()
		Dim r As New Random()
	
		For i As Integer = 0 To 4
			For a As Integer = 0 To 2
				data.Add(New MonthlyTemp(time, r.Next(0, 10)))
				time = time.AddMonths(1)
			Next a
			For a As Integer = 0 To 2
				data.Add(New MonthlyTemp(time, r.Next(10, 20)))
				time = time.AddMonths(1)
			Next a
			For a As Integer = 0 To 2
				data.Add(New MonthlyTemp(time, r.Next(20, 30)))
				time = time.AddMonths(1)
			Next a
			For a As Integer = 0 To 2
				data.Add(New MonthlyTemp(time, r.Next(10, 20)))
				time = time.AddMonths(1)
			Next a
		Next i
		Return data
	End Function
```

#### __XAML__
```XAML
	<UserControl.Resources>
	    <telerik:HeatMapValueGradientColorizer x:Key="ValueGradientColorizer3">
	        <GradientStop Offset="0" Color="Blue" />
	        <GradientStop Offset="1" Color="Red" />
	    </telerik:HeatMapValueGradientColorizer>
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot" Background="White" Width="800" Height="600">
	    <Grid.RowDefinitions>
	        <RowDefinition Height="15*"/>
	        <RowDefinition Height="*"/>
	    </Grid.RowDefinitions>
	
	    <telerik:RadHeatMap x:Name="radHeatMap" ShowToolTips="True" CellBorderThickness="0" FontSize="20">
	        <telerik:RadHeatMap.Definition>
	            <telerik:CategoricalDefinition Colorizer="{StaticResource ValueGradientColorizer3}"
	                                    ColumnGroupMemberPath="Time.Month"
	                                    RowGroupMemberPath="Time.Year"
	                                    ValuePath="Temp"/>
	        </telerik:RadHeatMap.Definition>
	    </telerik:RadHeatMap>
	
	    <Grid Grid.Row="1" Width="250" HorizontalAlignment="Right">
	        <Grid.ColumnDefinitions>
	            <ColumnDefinition Width="Auto" />
	            <ColumnDefinition />
	            <ColumnDefinition Width="Auto" />
	        </Grid.ColumnDefinitions>
	        <TextBlock Grid.Column="0" Text="Cold" VerticalAlignment="Center" FontSize="13" />
	        <TextBlock Grid.Column="2" Text="Hot" VerticalAlignment="Center" FontSize="13" />
	        <Border Grid.Column="1" Margin="4">
	            <Border.Background>
	                <LinearGradientBrush>
	                    <GradientStop Offset="0.0" Color="Blue"/>
	                    <GradientStop Offset="1.0" Color="Red"/>
	                </LinearGradientBrush>
	            </Border.Background>
	        </Border>
	
	    </Grid>
	</Grid>
```

And the result:

![RadHeatMap_colorizers_06jpg](images/RadHeatMap_colorizers_06.jpg)