---
title: DataBinding
page_title: DataBinding
description: Check our &quot;DataBinding&quot; documentation article for the RadDataBar {{ site.framework_name }} control.
slug: raddatabar-databinding
tags: databinding
published: True
position: 2
---

# DataBinding

Databinding for the RadDataBar control involves the correlation between the business logic/data, and the visualization of the control.

This article describes how to data bind the different RadDataBar controls.

## RadDataBar

The RadDataBar control allows you to data bind its __Value__ property, which can be used to connect the UI with the model. The Value determines that size of the bar according to the Minimum and Maximum values of the RadDataBar control. 

The bar size will automatically update if the data bound property in the model changes. To ensure that this works properly, the underlying data context must implement the [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20) interface.

Find a runnable sample in the [Code Example](#code-example) section of this article.

## RadStackedDataBar and RadStacked100DataBar

RadStackedDataBar and RadStacked100DataBar allow you to data bind their __ItemsSource__ property to any [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx). For each item in the ItemsSource a bar in the stack will be generated. 

In case the ItemsSource is bound to a collection of numbers (like the `double` or `int` primitives), the data bars will be generated automatically. If the ItemsSource is bound to a collection of any other custom object type, you will need to provide the name of the property that should be used to access the data bar values. To do so, set the __ValuePath__ property of the data bar control. For example, if the collection contains items of type `MyItemInfo` which have a property named `MyValue`, the ValuePath property should hold the "MyValue" string.  

The stacked data bar controls also provide full support for change notifications - data sources that implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx), and underlying data items that implement [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20) are properly tracked and automatically reflected by the UI.

Find a runnable sample in the [Code Example](#code-example) section of this article.

## Code Example

This example shows how to data bind the RadDataBar controls to a view model.

__Example 1: Creating a sample model containing information about the data bars__  
```C#
	public class Product
	{
		public int Value1 { get; set; }
		public int Value2 { get; set; }
	
		public IEnumerable<int> Ints { get; set; }
		public IEnumerable<Item> Items { get; set; }
	}
	
	public class Item
	{
		public double Val { get; set; }
		public string Name { get; set; }
	}
```
```VB.NET
	Public Class Product
			Public Property Value1() As Integer
			Public Property Value2() As Integer
	
			Public Property Ints() As IEnumerable(Of Integer)
			Public Property Items() As IEnumerable(Of Item)
		End Class
	
		Public Class Item
			Public Property Val() As Double
			Public Property Name() As String
		End Class
```

__Example 2: Setting up the model__  
```C#
	var items = new List<Item>() 
	{
		new Item{ Val = 9, Name = "nine", },
		new Item{ Val = 10, Name = "ten", },
		new Item{ Val = 11, Name = "eleven", },
		new Item{ Val = 20, Name = "twenty", }, 
		new Item{ Val = 22, Name = "twenty two", }, 
		new Item{ Val = 90, Name = "ninety", }, 

		new Item{ Val = -9, Name = "-nine", },
		new Item{ Val = -10, Name = "-ten", },
		new Item{ Val = -11, Name = "-eleven", },
		new Item{ Val = -20, Name = "-twenty", }, 
		new Item{ Val = -100, Name = "-hundred", }, 
	};
	
	this.DataContext = new Product() { Value1 = 20, Value2 = 30, Ints = new List<int>() {5, 6, 7, 8, 9, }, Items = items };
```
```VB.NET
	Dim items = New List(Of Item)() From {
		 New Item With {.Val = 9, .Name = "nine"},
		 New Item With {.Val = 10, .Name = "ten"},
		 New Item With {.Val = 11, .Name = "eleven"},
		 New Item With {.Val = 20, .Name = "twenty"},
		 New Item With {.Val = 22, .Name = "twenty two"},
		 New Item With {.Val = 90, .Name = "ninety"},
		 New Item With {.Val = -9, .Name = "-nine"},
		 New Item With {.Val = -10, .Name = "-ten"},
		 New Item With {.Val = -11, .Name = "-eleven"},
		 New Item With {.Val = -20, .Name = "-twenty"},
		 New Item With {.Val = -100, .Name = "-hundred"}}
	
	Dim TempProduct As Product = New Product() With {.Value1 = 20, .Value2 = 30, .Ints = New List(Of Integer)() From {5, 6, 7, 8, 9}, .Items = items}
	Me.DataContext = New Product() With {.Value1 = 20, .Value2 = 30, .Ints = New List(Of Integer)() From {5, 6, 7, 8, 9}, .Items			
```

__Example 3: Define the RadDataBars components__  
```XAML
	<telerik:RadDataBar Height="20" Value="{Binding Value1}" BorderBrush="Gray" BorderThickness="1" Margin="2" />
	<telerik:RadDataBar Height="20" Value="{Binding Value2}" BorderBrush="Gray" BorderThickness="1" Margin="2" />
	
	<telerik:RadStackedDataBar Height="20" BorderBrush="Gray" BorderThickness="1" Margin="2" ItemsSource="{Binding Ints}" ShowToolTips="True" />
	<telerik:RadStackedDataBar Height="20" BorderBrush="Gray" BorderThickness="1" Margin="2" AxisVisibility="Visible"
								ItemsSource="{Binding Items}" ValuePath="Val" ToolTipPath="Name" ShowToolTips="True" Minimum="-100" Maximum="100"/>
```

#### __Figure 1: The different data bars__
![The different data bars](images/raddatabar-databinding.PNG)

## See Also  
* [Getting Started]({%slug databar-getting-started2%})
* [Properties]({%slug raddatabar-main_properties%})
