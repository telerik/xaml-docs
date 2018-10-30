---
title: DataBinding
page_title: DataBinding
description: DataBinding
slug: raddatabar-databinding
tags: databinding
published: True
position: 2
---

# DataBinding

Databinding for the RadDataBar control involves the correlation between the business logic/data, and the visualization of the control.
        

The DataBinding involves the following three properties:
* __ItemsSource (a property of RadStackedDataBar and RadStacked100Databar)__: Gets or sets the data source used to generate the content of the databar control. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow.

* __Value (a property of RadDataBar)__: Expects a value which will be used to determine the size of the bar.

* __ValuePath (a property of RadStackedDataBar and RadStacked100DataBar)__: Expects the name of the property from the underlying datasource, which will determine the value of each bar in the stack.            

You can bind the ItemsSource of __RadStackedDataBar__ and __RadStacked100DataBar__ to any class that implements the [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) interface.        

__RadDataBar__ will automatically update its size if the value it is bound to changes. For this to happen the underlying data context must implement the [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20) interface.

__RadStackedDataBar__ and __RadStacked100DataBar__ also provide full support for change notifications - data sources that implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx), and underlying data items that implement [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20) are properly tracked and automatically reflected by the UI.

You'll see the binding in action below.        

Let's create a sample class with four properties - two integers, a collection of integers and a collection of another class.        

#### __[C#] Example 1: The Product class__

{{region raddatabar-databinding_0}}
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
{{endregion}}

#### __[VB.NET] Example 1: The Product class__

{{region raddatabar-databinding_0}}
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
{{endregion}}

The next step is to set values for the properties in our class.

#### __[C#] Example 2: Sample data__

{{region raddatabar-databinding_1}}
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
{{endregion}}

#### __[VB.NET] Example 2: Sample data__

{{region raddatabar-databinding_1}}
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
{{endregion}}

The only thing left to do is to create our databar(s) and bind them using the properties exposed for the purpose (as mentioned in the beginning of the article).

#### __[XAML] Example 3: Define RadDataBars__

{{region raddatabar-databinding_0}}
	<telerik:RadDataBar Height="20" Value="{Binding Value1}" BorderBrush="Gray" BorderThickness="1" Margin="2" />
	<telerik:RadDataBar Height="20" Value="{Binding Value2}" BorderBrush="Gray" BorderThickness="1" Margin="2" />
	
	<telerik:RadStackedDataBar Height="20" BorderBrush="Gray" BorderThickness="1" Margin="2" ItemsSource="{Binding Ints}" ShowToolTips="True" />
	<telerik:RadStackedDataBar Height="20" BorderBrush="Gray" BorderThickness="1" Margin="2" AxisVisibility="Visible"
								ItemsSource="{Binding Items}" ValuePath="Val" ToolTipPath="Name" ShowToolTips="True" Minimum="-100" Maximum="100"/>
{{endregion}}

Note that RadDataBar doesn't have an ItemsSource property since it is a single bar and needs a single value to work.

On the other hand RadStackedDataBar requires a collection of values - the number of items in the collection determines the number of bars that will be visualized in stack.

When bound to a list of business objects, you should set the name of the property from the business object that will provide the value for the bars. For the purpose *RadStackedDataBar* and *RadStacked100Databar* expose the __ValuePath__ property.        

When run this code will produce the following result.

#### __Figure 1: The different data bars__
![The different data bars](images/raddatabar-databinding.PNG)

## See Also

* [Getting Started]({%slug databar-getting-started2%})
* [Properties]({%slug raddatabar-main_properties%})
