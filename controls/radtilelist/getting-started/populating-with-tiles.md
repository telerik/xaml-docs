---
title: Populating RadTileList with Tiles 
page_title: Populating RadTileList with Tiles 
description: Populating RadTileList with Tiles 
slug: radtilelist-getting-started-populating-with-tiles
tags: populating,radtilelist,with,tiles,
publish: True
position: 1
---

# Populating RadTileList with Tiles 



This tutorial will walk your through the population of __RadTileList__ and will show you how:

* 
          Populate __RadTileList__ with a collection of custom objects
        

* 
          Populate __RadTileList__ with custom Tiles
        

## Populating RadTileList with a collection of custom objects

Firstly, for the purpose of this tutorial, we will create a new class Employee with a couple of properties:

#### __C#__

{{region radtilelist-getting-started_4}}
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
	{{endregion}}



#### __VB.NET__

{{region radtilelist-getting-started_5}}
	Public Class Employee
	 Public Property FirstName() As String
	  Get
	   Return m_FirstName
	  End Get
	  Set
	   m_FirstName = Value
	  End Set
	 End Property
	 Private m_FirstName As String
	 Public Property LastName() As String
	  Get
	   Return m_LastName
	  End Get
	  Set
	   m_LastName = Value
	  End Set
	 End Property
	 Private m_LastName As String
	 Public Property Occupation() As String
	  Get
	   Return m_Occupation
	  End Get
	  Set
	   m_Occupation = Value
	  End Set
	 End Property
	 Private m_Ocupation As String
	 Public Property Salary() As Integer
	  Get
	   Return m_Salary
	  End Get
	  Set
	   m_Salary = Value
	  End Set
	 End Property
	 Private m_Salary As Integer
	End Class
	{{endregion}}



>
          Note that in case you want to be notified on the changes made on the data item, the class Employee should implement __INotifyPropertyChanged__ Interface and raise the __PropertyChanged__ event every time a property value changes.
        

Once the class Employee is defined, we will extend it by a single static method - GetEmployees() that will return an ObservableCollection, containing several hard-coded employees:
        

#### __C#__

{{region radtilelist-getting-started_6}}
	public class Employee
	{
	
	  public Employee()
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
	{{endregion}}



#### __VB.NET__

{{region radtilelist-getting-started_7}}
	Public Class Employee
	
	 Public Sub New()
	 End Sub
	 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
	  Dim employees As New ObservableCollection(Of Employee)()
	  employees.Add(New Employee() With { _
	   Key .FirstName = "Sarah", _
	   Key .LastName = "Blake", _
	   Key .Occupation = "Supplies Manager", _
	   Key .Salary = 3500 _
	  })
	  employees.Add(New Employee() With { _
	   Key .FirstName = "Jane", _
	   Key .LastName = "Simpson", _
	   Key .Occupation = "Security", _
	   Key .Salary = 2000 _
	  })
	  employees.Add(New Employee() With { _
	   Key .FirstName = "John", _
	   Key .LastName = "Peterson", _
	   Key .Occupation = "Consultant", _
	   Key .Salary = 2600 _
	  })
	  employees.Add(New Employee() With { _
	   Key .FirstName = "Peter", _
	   Key .LastName = "Bush", _
	   Key .Occupation = "Cashier", _
	   Key .Salary = 2300 _
	  })
	  Return employees
	 End Function
	
	End Class
	{{endregion}}



Secondly, you must define RadTileList's ItemTemplate, like so:

#### __XAML__

{{region radtilelist-getting-started_10}}
	 <telerik:RadTileList x:Name="RadTileList" ScrollViewer.HorizontalScrollBarVisibility="Visible">
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
	{{endregion}}



>
         Please note that you can show/hide the horizontal scrollbar by setting the ScrollViewer.HorizontalScrollBarVisibility attached property.
        

Afterwards, all you need to do is to set the ItemsSource of the RadTileList:

#### __C#__

{{region radtilelist-getting-started_8}}
	public MainPage()
	  {
	   InitializeComponent();   
	   this.RadTileList.ItemsSource = Employee.GetEmployees();
	  }
	{{endregion}}



#### __VB.NET__

{{region radtilelist-getting-started_9}}
	Public Sub New()
	 InitializeComponent()
	        Me.RadTileList.ItemsSource = Employee.GetEmployees()
	End Sub
	{{endregion}}



## Populating RadTileList with custom Tiles

A typical usage of __Custom RadTileList's Tiles__ is available on
          {% if site.site_name == 'Silverlight' %}[ this online demo](http://demos.telerik.com/silverlight/#TileList/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[ our WPF demos](http://demos.telerik.com/wpf/){% endif %}.
        
