---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtreeliestview-getting-started
tags: getting,started
publish: True
position: 3
---

# Getting Started



The __RadTreeListView__ is a control used to display hierarchical data in a tabular format. In order to achieve this, the __RadTreeListView__ combines the functionality of the __RadGridView__ control with the ability to display data in a tree view manner. This is implemented by directly inheriting the __RadGridView__ and implementing the tree view behavior.

The __RadTreeListView__ displays the data in the same way as the __RadGridView__. The difference is that each row plays the role of a tree node, which can be expanded and collapsed.

>Please note that the __RadTreeListView__ and the [Hierarchical RadGridView]({%slug gridview-hierachy-overview%}) are two different things. The first displays the data in a tree view manner in one and the same table. The second one displays the hierarchical data in nested __RadGridViews__. 

>Consider using the __RadTreeListView__ for displaying only a homogeneous data. For heterogeneous data use the
          [Hierarchical RadGridView]({%slug gridview-hierachy-overview%}).

The thing that you should use in order to display your data in the __RadTreeListView__ is the __ChildTableDefinitions__ property. In the context of the __RadTreeListView__ control, you shouldn't use the __GridViewTabelDefinition__class, but the __TreeListViewTableDefinition__ one. It exposes an __ItemSource__ property which should be bound to the property that represents the next level of hierarchy. 

>This property should have the same name at each level of the hierarchy. 

>As the hierarchical data in the __RadTreeListView__ is displayed in one and the same table, each level of the hierarchy will share one and the same set of columns. This means that your data should provide the needed members at each level of the hierarchy.

>tipYou can also check out the __RadGridView__'s [Getting Started section]({%slug gridview-getting-started2%}).
        

This topic will explain you how to:

* [Add RadTreeListView to your application](#Add_RadTreeListView_to_your_application)

* [Prepare a Sample Data](#Prepare_a_Sample_Data)

* [Display the Data in the RadTreeListView](#Display_the_Data_in_the_RadTreeListView)

## Add RadTreeListView to your application

In order to use the __RadTreeListView__ in your application you should add reference to the following assemblies:

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.GridView__

* __Telerik.Windows.Data__

* __Telerik.Windows.Controls.Input__

>The current version of __RadTreeListView__ (the one that inherits GridViewDataControl) is built on top of __Silverlight 4__. 

Here is an example of how to instantiate a __RadTreeListView__in both XAML and code.

>

In order to use the __RadTreeListView__ in XAML, you have to declare the following namespace:

#### __XAML__

{{region radtreeliestview-getting-started_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



#### __XAML__

{{region radtreeliestview-getting-started_1}}
	<telerik:RadTreeListView x:Name="radTreeListView">
	</telerik:RadTreeListView>
	{{endregion}}



#### __C#__

{{region radtreeliestview-getting-started_2}}
	RadTreeListView radTreeListView = new RadTreeListView();
	{{endregion}}



#### __VB.NET__

{{region radtreeliestview-getting-started_3}}
	Dim radTreeListView As New RadTreeListView()
	{{endregion}}



## Prepare a Sample Data

For this example we will use a collection that represents the contents of a warehouse. It will contain __WarehouseItem__ objects. Each WarehouseItem will have a __Name__, a __Count__ and a collection of WarehouseItem objects. Here is the class definition.

#### __C#__

{{region radtreeliestview-getting-started_4}}
	public class WarehouseItem
	{
	    public WarehouseItem( string name, int count )
	    {
	        this.Name = name;
	        this.Count = count;
	        this.Items = new ObservableCollection<WarehouseItem>();
	    }
	    public string Name
	    {
	        get;
	        set;
	    }
	    public ObservableCollection<WarehouseItem> Items
	    {
	        get;
	        set;
	    }
	    public int Count
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeliestview-getting-started_5}}
	Public Class WarehouseItem
	 Public Sub New(name As String, count As Integer)
	  Me.Name = name
	  Me.Count = count
	  Me.Items = New ObservableCollection(Of WarehouseItem)()
	 End Sub
	 Public Property Name() As String
	  Get
	   Return m_Name
	  End Get
	  Set
	   m_Name = Value
	  End Set
	 End Property
	 Private m_Name As String
	 Public Property Items() As ObservableCollection(Of WarehouseItem)
	  Get
	   Return m_Items
	  End Get
	  Set
	   m_Items = Value
	  End Set
	 End Property
	 Private m_Items As ObservableCollection(Of WarehouseItem)
	 Public Property Count() As Integer
	  Get
	   Return m_Count
	  End Get
	  Set
	   m_Count = Value
	  End Set
	 End Property
	 Private m_Count As Integer
	End Class
	{{endregion}}



Here is also an example class that dynamically creates the sample data.

#### __C#__

{{region radtreeliestview-getting-started_6}}
	public class WarehouseService
	{
	    public static ObservableCollection<WarehouseItem> GetWarehouseData()
	    {
	        ObservableCollection<WarehouseItem> data = new ObservableCollection<WarehouseItem>();
	        WarehouseItem drinks = new WarehouseItem( "Drinks", 35 );
	        drinks.Items.Add( new WarehouseItem( "Water", 10 ) );
	        WarehouseItem tea = new WarehouseItem( "Tea", 20 );
	        tea.Items.Add( new WarehouseItem( "Black", 10 ) );
	        tea.Items.Add( new WarehouseItem( "Green", 10 ) );
	        drinks.Items.Add( tea );
	        drinks.Items.Add( new WarehouseItem( "Coffee", 5 ) );
	        data.Add( drinks );
	        WarehouseItem vegetables = new WarehouseItem( "Vegeatbles", 75 );
	        vegetables.Items.Add( new WarehouseItem( "Tomato", 40 ) );
	        vegetables.Items.Add( new WarehouseItem( "Carrot", 25 ) );
	        vegetables.Items.Add( new WarehouseItem( "Onion", 10 ) );
	        data.Add( vegetables );
	        WarehouseItem fruits = new WarehouseItem( "Fruits", 55 );
	        fruits.Items.Add( new WarehouseItem( "Cherry", 30 ) );
	        fruits.Items.Add( new WarehouseItem( "Apple", 20 ) );
	        fruits.Items.Add( new WarehouseItem( "Melon", 5 ) );
	        data.Add( fruits );
	        return data;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeliestview-getting-started_7}}
	Public Class WarehouseService
	 Public Shared Function GetWarehouseData() As ObservableCollection(Of WarehouseItem)
	  Dim data As New ObservableCollection(Of WarehouseItem)()
	  Dim drinks As New WarehouseItem("Drinks", 35)
	  drinks.Items.Add(New WarehouseItem("Water", 10))
	  Dim tea As New WarehouseItem("Tea", 20)
	  tea.Items.Add(New WarehouseItem("Black", 10))
	  tea.Items.Add(New WarehouseItem("Green", 10))
	  drinks.Items.Add(tea)
	  drinks.Items.Add(New WarehouseItem("Coffee", 5))
	  data.Add(drinks)
	  Dim vegetables As New WarehouseItem("Vegeatbles", 75)
	  vegetables.Items.Add(New WarehouseItem("Tomato", 40))
	  vegetables.Items.Add(New WarehouseItem("Carrot", 25))
	  vegetables.Items.Add(New WarehouseItem("Onion", 10))
	  data.Add(vegetables)
	  Dim fruits As New WarehouseItem("Fruits", 55)
	  fruits.Items.Add(New WarehouseItem("Cherry", 30))
	  fruits.Items.Add(New WarehouseItem("Apple", 20))
	  fruits.Items.Add(New WarehouseItem("Melon", 5))
	  data.Add(fruits)
	  Return data
	 End Function
	End Class
	{{endregion}}



## Display the Data in the RadTreeListView

In order to display your data, you have to set it to the __ItemsSource__ property of the __RadTreeListView__.

#### __C#__

{{region radtreeliestview-getting-started_8}}
	this.radTreeListView.ItemsSource = WarehouseService.GetWarehouseData();
	{{endregion}}



#### __VB.NET__

{{region radtreeliestview-getting-started_9}}
	Me.radTreeListView.ItemsSource = WarehouseService.GetWarehouseData()
	{{endregion}}



At this point, only the first level of the hierarchical data will get displayed and the __RadTreeListView__ will look just like a __RadGridView__. In order to display the other levels of the hierarchy, you have to define a __TreeListViewTableDefinition__, to set its __ItemsSource__ property to the respective member of the business object and to set the table definition to the __ChildTableDefinition__ property of the __RadTreeListView__.

#### __XAML__

{{region radtreeliestview-getting-started_10}}
	<telerik:RadTreeListView x:Name="radTreeListView">
	    <telerik:RadTreeListView.ChildTableDefinitions>
	        <telerik:TreeListViewTableDefinition ItemsSource="{Binding Items}" />
	    </telerik:RadTreeListView.ChildTableDefinitions>
	</telerik:RadTreeListView>
	{{endregion}}



By default the __RadTreeListView__ will auto-generate the columns for your data, by creating a column for each property. In order to prevent this you have to set the __AutogenerateColumns__ property to __False__ and to manually add the desired columns to the __Columns__ collection of the control.

#### __XAML__

{{region radtreeliestview-getting-started_11}}
	<telerik:RadTreeListView x:Name="radTreeListView"
	                            AutoGenerateColumns="False">
	    <telerik:RadTreeListView.ChildTableDefinitions>
	        <telerik:TreeListViewTableDefinition ItemsSource="{Binding Items}" />
	    </telerik:RadTreeListView.ChildTableDefinitions>
	    <telerik:RadTreeListView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                    Header="Name" />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Count}"
	                                    Header="Count" />
	    </telerik:RadTreeListView.Columns>
	</telerik:RadTreeListView>
	{{endregion}}



>tip

The __RadTreeListView__ can use the same columns as the __RadGridView__. To learn more about the different types of columns read here.
        

>tip

To change the column, which holds the tree view UI, use the __HierarchyColumnIndex__ property.

Here is a snapshot of the result.![](images/RadTreeListView_GettingStarted_01.png)

# See Also

 * [Data Binding]({%slug radtreelistview-features-data-binding%})

 * [Columns]({%slug radtreelistview-features-columns%})

 * [Hierarchy Column]({%slug radtreelistview-features-hierarchy-column%})
