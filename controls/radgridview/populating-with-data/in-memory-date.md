---
title: Using in-memory Data
page_title: Using in-memory Data
description: Using in-memory Data
slug: gridview-in-memory-date
tags: using,in-memory,data
published: True
position: 2
---

# Using in-memory Data

The purpose of this tutorial is to show you how to populate a __RadGridView__ with in-memory data.

The control will be bound to an __ObservableCollection__ of __Car__ objects. Each __Car__ has a __Name__ and __Description__.

* Create a new class named __Car__ and add two properties - __Name__ and __Description__. Both of the properties are of type string. Here is the source code: 

#### __C#__

{{region cs-gridview-in-memory-date_1}}
	public class Car
	{
	    public Car()
	    {
	    }
	
	    public Car(string name, string description)
	    {
	        this.Name = name;
	        this.Description = description;
	    }
	
	    public string Name
	    {
	        get;
	        set;
	    }
	
	    public string Description
	    {
	        get;
	        set;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-in-memory-date_2}}
	Public Class Car
	
	    Public Sub New()
	    End Sub
	
	    Public Sub New(ByVal name As String, ByVal description As String)
	        Me.Name = name
	        Me.Description = description
	    End Sub
	
	    Private _Name As String
	    Public Property Name() As String
	        Get
	            Return _Name
	        End Get
	        Set(ByVal value As String)
	            _Name = value
	        End Set
	    End Property
	
	    Private _Description As String
	    Public Property Description() As String
	        Get
	            Return _Description
	        End Get
	        Set(ByVal value As String)
	            _Description = value
	        End Set
	    End Property
	End Class
{{endregion}}

* Create a new class named __RadGridViewSampleData__. 

#### __C#__

{{region cs-gridview-in-memory-date_5}}
	public class RadGridViewSampleData
	{
	    public RadGridViewSampleData()
	    {
	        Cars = new ObservableCollection<Car>();
	        Cars.Add(new Car("BMW", "A german luxury car."));
	        Cars.Add(new Car("Porsche", "A german sports car."));
	        Cars.Add(new Car("Citroen", "A french luxury car."));
	        Cars.Add(new Car("Renault", "A french family car."));
	    }
	
	    public ObservableCollection<Car> Cars
	    {
	        get;
	        set;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-in-memory-date_6}}
	Public Class RadGridViewSampleData
	    Public Sub New()
	        Cars = New ObservableCollection(Of Car)()
	        Cars.Add(New Car("BMW", "A german luxury car."))
	        Cars.Add(New Car("Porsche", "A german sports car."))
	        Cars.Add(New Car("Citroen", "A french luxury car."))
	        Cars.Add(New Car("Renault", "A french family car."))
	    End Sub
	
	    Private _Cars As ObservableCollection(Of Car)
	    Public Property Cars() As ObservableCollection(Of Car)
	        Get
	            Return _Cars
	        End Get
	        Set(ByVal value As ObservableCollection(Of Car))
	            _Cars = value
	        End Set
	    End Property
	End Class
{{endregion}}

* Declare the __RadGridViewSampleData__ object as a resource in your application. 

#### __XAML__

{{region xaml-gridview-in-memory-date_9}}
	<Grid.Resources>
	    <my:RadGridViewSampleData x:Key="DataSource"/>
	</Grid.Resources>
{{endregion}}

* Update your __RadGridView__ declaration - set the __ItemsSource__ property. 

#### __XAML__

{{region xaml-gridview-in-memory-date_10}}
	<telerik:RadGridView x:Name="radGridView" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Cars}"/>
{{endregion}}

Run your demo, the result can be seen on the next picture:

![](images/RadGridView_PopulatingWithDataLoadFromInMemoryData_010.PNG)

>tipIf you need to define the columns manually read the topic [Defining Columns]({%slug gridview-columns-defining-columns%}).

## See Also

 * [Loading Data from XML]({%slug gridview-loading-data-from-xml%}) 
{% if site.site_name == 'Silverlight' %}

 * [Loading Data from RIA Services]({%slug gridview-loading-data-from-ria-services%})

 * [DomainDataSource Support]({%slug gridview-domaindatasource-support%})

 * [Loading Data from Web Services]({%slug gridview-loading-data-from-web-services%})
{% endif %}

 * [Loading Data from WCF Services]({%slug gridview-loading-data-from-wcf-services%})

 * [Loading Data from ADO.NET Services]({%slug gridview-loading-data-from-adonet-services%})

