---
title: Populating RadTileList with Tiles 
page_title: Populating RadTileList with Tiles 
description: Check our &quot;Populating RadTileList with Tiles&quot; documentation article for the RadTileList {{ site.framework_name }} control.
slug: radtilelist-getting-started-populating-with-tiles
tags: populating,radtilelist,with,tiles,
published: True
position: 1
---

# Populating RadTileList With Tiles 



This tutorial will walk your through the population of __RadTileList__ and will show you how:

* Populate __RadTileList__ with a collection of custom objects
        

* Populate __RadTileList__ with custom Tiles
        

## Populating RadTileList With a Collection of Custom Objects

Firstly, for the purpose of this tutorial, we will create a new class __Employee__ with a couple of properties:

__Example 1: Defining the Employee class__

```C#
	public class Employee
	{
	    public string FirstName
	    {
	        get;
	        set;
	    }
	    public string LastName
	    {
	        get;
	        set;
	    }
	    public string Occupation
	    {
	        get;
	        set;
	    }
	    public int Salary
	    {
	        get;
	        set;
	    }
	}
```
```VB.NET
	Public Class Employee
	    Public Property FirstName() As String
	        Get
	            Return m_FirstName
	        End Get
	        Set(value As String)
	            m_FirstName = value
	        End Set
	    End Property
	    Private m_FirstName As String
	    Public Property LastName() As String
	        Get
	            Return m_LastName
	        End Get
	        Set(value As String)
	            m_LastName = value
	        End Set
	    End Property
	    Private m_LastName As String
	    Public Property Occupation() As String
	        Get
	            Return m_Occupation
	        End Get
	        Set(value As String)
	            m_Occupation = value
	        End Set
	    End Property
	    Private m_Occupation As String
	    Public Property Salary() As Integer
	        Get
	            Return m_Salary
	        End Get
	        Set(value As Integer)
	            m_Salary = value
	        End Set
	    End Property
	    Private m_Salary As Integer
	End Class
```



>Note that in case you want to be notified on the changes made on the data item, the class Employee should implement __INotifyPropertyChanged__ Interface and raise the __PropertyChanged__ event every time a property value changes.
        

Once the class __Employee__ is defined, we will define an __EmployeeService__ class that will return an ObservableCollection, containing several hard-coded employees:
        

__Example 2: Defining the EmployeeService class__

```C#
	public class EmployeeService
	{
	    public EmployeeService()
	    { }
	    
	    public static ObservableCollection<Employee> GetEmployees()
	    {
	        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
	        employees.Add(new Employee() { FirstName = "Sarah", LastName = "Blake", Occupation = "Suppliess Manager", Salary = 3500 });
	        employees.Add(new Employee() { FirstName = "Jane", LastName = "Simpson", Occupation = "Security", Salary = 2000 });
	        employees.Add(new Employee() { FirstName = "John", LastName = "Peterson", Occupation = "Consultant", Salary = 2600 });
	        employees.Add(new Employee() { FirstName = "Peter", LastName = "Bush", Occupation = "Cashier", Salary = 2300 });
	        return employees;
	    }
	}
```
```VB.NET
	Public Class EmployeeService

	    Public Sub New()
	    End Sub
	    Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
	        Dim employees As New ObservableCollection(Of Employee)()
	        employees.Add(New Employee() With { _
	         .FirstName = "Sarah", _
	         .LastName = "Blake", _
	         .Occupation = "Supplies Manager", _
	         .Salary = 3500 _
	        })
	        employees.Add(New Employee() With { _
	         .FirstName = "Jane", _
	         .LastName = "Simpson", _
	         .Occupation = "Security", _
	         .Salary = 2000 _
	        })
	        employees.Add(New Employee() With { _
	         .FirstName = "John", _
	         .LastName = "Peterson", _
	         .Occupation = "Consultant", _
	         .Salary = 2600 _
	        })
	        employees.Add(New Employee() With { _
	         .FirstName = "Peter", _
	         .LastName = "Bush", _
	         .Occupation = "Cashier", _
	         .Salary = 2300 _
	        })
	        Return employees
	    End Function

	End Class
```



Secondly, you must define __RadTileList's ItemTemplate__, like so:

__Example 3: Defining the ItemTemplate__

```XAML
	<telerik:RadTileList x:Name="RadTileList">
	  <telerik:RadTileList.ItemTemplate>
	    <DataTemplate>
	      <Grid Background="#FF006AC1">
	        <Grid.RowDefinitions>
	          <RowDefinition />
	          <RowDefinition />
	          <RowDefinition />
	          <RowDefinition />
	        </Grid.RowDefinitions>
	        <Grid.ColumnDefinitions>
	          <ColumnDefinition/>
	          <ColumnDefinition/>
	        </Grid.ColumnDefinitions>
	        <TextBlock Grid.Row="0" Grid.Column="0" Text="First Name"/>
	        <TextBlock Grid.Row="0" Grid.Column="1" Text="{Binding FirstName}" />
	        <TextBlock Grid.Row="1" Grid.Column="0" Text="Last Name"/>
	        <TextBlock Grid.Row="1" Grid.Column="1" Text="{Binding LastName}" />
	        <TextBlock Grid.Row="2" Grid.Column="0" Text="Occupation"/>
	        <TextBlock Grid.Row="2" Grid.Column="1" Text="{Binding Occupation}" />
	        <TextBlock Grid.Row="3" Grid.Column="0" Text="Salary"/>
	        <TextBlock Grid.Row="3" Grid.Column="1" Text="{Binding Salary}" />
	      </Grid>
	    </DataTemplate>
	  </telerik:RadTileList.ItemTemplate>
	</telerik:RadTileList>
```



> Please note that you can show/hide the horizontal scrollbar by setting the __ScrollViewer.HorizontalScrollBarVisibility__ attached property.
        

Afterwards, all you need to do is to set the __ItemsSource of__ the RadTileList:

__Example 4: Setting the ItemsSource of RadTileList__

```C#
	public MainPage()
	{
	    InitializeComponent();
	    this.RadTileList.ItemsSource = EmployeeService.GetEmployees();
	}
```
```VB.NET
	Public Sub New()
	    InitializeComponent()
	    Me.RadTileList.ItemsSource = EmployeeService.GetEmployees()
	End Sub
```



## Populating RadTileList With Custom Tiles

A typical usage of __Custom RadTileList's Tiles__ is available on {% if site.site_name == 'Silverlight' %}[ this online demo](https://demos.telerik.com/silverlight/#TileList/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[ our WPF demos](https://demos.telerik.com/wpf/){% endif %}.
        
