---
title: Data Binding
page_title: Data Binding
description: Data Binding
slug: carousel-data-binding
tags: data,binding
publish: True
position: 1
---

# Data Binding



## Programmatic Data Binding

__RadCarousel__ tries to provide an API similar to that of standard WPF __ItemsControl__ control objects. The entry point to all data binding-related operations is the __RadCarousel____ItemsSource__ property. Providing a collection will trigger a data binding operation.
        

#### __C#__

{{region carousel-data-binding_0}}
	this.RadCarousel1.ItemsSource = GetDataTable();
	{{endregion}}



#### __VB.NET__

{{region carousel-data-binding_1}}
	Me.RadCarousel1.ItemsSource = GetDataTable()
	{{endregion}}



Unlike a standard items control, the __RadCarousel____ItemsSource__ property is declared to be of type __System.Object__. This lets you provide objects that are not .NET collections like the ADO.NET __DataTable__ and __DataSet__. Binding to a __DataSet__ requires that you provide additional information, the name of the contained table, by using the __DataMember__ property:

#### __C#__

{{region carousel-data-binding_2}}
	radCarousel1.DataMember = "Orders";
	radCarousel1.ItemsSource = dataSet;
	{{endregion}}



#### __VB.NET__

{{region carousel-data-binding_3}}
	radCarousel1.DataMember = "Orders"
	radCarousel1.ItemsSource = dataSet
	{{endregion}}



Of course standard .NET collections that implement the __IEnumerable__ interface are fully supported as well.

Introduced to the __System.ComponentModel__ namespace with WPF, collection views are fully supported as well.

## Declarative Databinding

The __ItemsSource__ property is visible and modifiable through XAML. Typical usage scenarios include binding to a data provider such as instances of the __ObjectDataProvider__ or the __XmlDataProvider__ classes.
          
          
        

#### __XAML__

{{region carousel-data-binding_4}}
	<Grid>
	    <Grid.Resources>
	        <ObjectDataProvider x:Key="objectDataProvider" ObjectType="{x:Type e:ExamplesDB}" MethodName="GetCustomersView" />
	    </Grid.Resources>
	    <telerik:RadCarousel Name="RadCarousel1"
	        ItemsSource="{Binding Source={StaticResource objectDataProvider}}">
	    </telerik:RadCarousel>
	</Grid>
	{{endregion}}





>

Note that you have to always pass data provider objects through a binding for the WPF bindings infrastructure to extract the data. This code will __not__ work:

#### __XAML__

{{region carousel-data-binding_5}}
	<Grid>
	    <Grid.Resources>
	        <ObjectDataProvider x:Key="objectDataProvider" ObjectType="{x:Type e:ExamplesDB}" MethodName="GetCustomersView" />
	    </Grid.Resources>
	    <telerik:RadCarousel Name="RadCarousel1"
	        ItemsSource="{StaticResource objectDataProvider}">
	    </telerik:RadCarousel>
	</Grid>
	{{endregion}}



As you can see, using __{StaticResource objectDataProvider}__ directly fails to get the real data source from the data provider.



## Item Source Update Notifications

To achieve better testability and loose coupling in your code it may be more convenient to manipulate data in the original data source instead of using the RadCarousel data API. RadCarousel supports that scenario by listening to data source collection change events and reflecting those changes in its visual representation. This feature is only supported for observable data sources like the WPF-native collections implementing the __INotifyCollectionChanged__ interface or the WinForms-specific ones implementing IBindingList.

* __INotifyCollectionChanged__implementors are collections that typically derive from the WPF ObservableCollection class.

* __IBindingList__implementors typically inherit from the .NET BindingList generic class. Another widely-used binding list is the ADO.NET __DataView__. 

>tipIf you need data source update notifications in your code that uses an ADO.NET __DataSet__ or a __DataTable__, just change the code to bind the grid to a __DataView__ referring the original table. The easiest way to do that is through the table's __DefaultView__ property.


