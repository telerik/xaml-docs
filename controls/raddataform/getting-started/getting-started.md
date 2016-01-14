---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: raddataform-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started



This tutorial will walk your through the creation of a sample application that contains __RadDataForm__ and will show you how:
      

* [Use RadDataForm in your project](#adding-raddataform-to-the-project);

* [Bind RadDataForm to a single item](#binding-raddataform-to-a-single-item);

* [Bind RadDataForm to a collection of custom objects](#binding-raddataform-to-a-collection-of-custom-objects);

For the purpose of this example, you will need to create an empty {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF {% endif %}Application project and open it in Visual Studio.
      

## Adding RadDataForm to the Project

* Create a new {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} project;
          

* Add references to the assemblies __Telerik.Windows.Controls__, __Telerik.Windows.Controls.Data__, __Telerik.Windows.Controls.Input__ and __Telerik.Windows.Data__;
          

* Import the Telerik schema:

#### __[XAML] Example 1: Importing the Telerik Schema__

{{region raddataform-getting-started_2}}

	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



* Add the RadDataForm to the Grid:

#### __[XAML] Example 2: Adding RadDataForm in XAML__

{{region raddataform-getting-started_3}}

	<Grid x:Name="LayoutRoot" Background="White">
	  <telerik:RadDataForm x:Name="DataForm1" />
	 </Grid>
	{{endregion}}



Now if you run the application, you have the empty RadDataForm:

 ![](images/radDataForm_emptyForm.png)



## Binding RadDataForm to a single item

Firstly, for the purpose of this tutorial, we will create a new class Employee with a couple of exposed properties

#### __C#__

{{region raddataform-getting-started_4}}

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
	  public DateTime StartingDate
	  {
	   get;
	   set;
	  }
	  public bool IsMarried
	  {
	   get;
	   set;
	  }
	
	  public int Salary
	  {
	   get;
	   set;
	  }
	  public Gender Gender
	  {
	   get;
	   set;
	  }
	 }
	{{endregion}}



#### __VB.NET__

{{region raddataform-getting-started_5}}

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
	        Private m_Occupation As String
	 Public Property StartingDate() As DateTime
	  Get
	   Return m_StartingDate
	  End Get
	  Set
	   m_StartingDate = Value
	  End Set
	 End Property
	 Private m_StartingDate As DateTime
	 Public Property IsMarried() As Boolean
	  Get
	   Return m_IsMarried
	  End Get
	  Set
	   m_IsMarried = Value
	  End Set
	 End Property
	 Private m_IsMarried As Boolean
	 Public Property Salary() As Integer
	  Get
	   Return m_Salary
	  End Get
	  Set
	   m_Salary = Value
	  End Set
	 End Property
	 Private m_Salary As Integer
	 Public Property Gender() As Gender
	  Get
	   Return m_Gender
	  End Get
	  Set
	   m_Gender = Value
	  End Set
	 End Property
	 Private m_Gender As Gender
	End Class
	{{endregion}}



In the example above Gender is of type enum:

#### __C#__

{{region raddataform-getting-started_6}}

	public enum Gender
	 {
	  Female,
	  Male
	 }
	{{endregion}}



#### __VB.NET__

{{region raddataform-getting-started_7}}

	Public Enum Gender
	 Female
	 Male
	End Enum
	{{endregion}}





>Note that in case you want to be notified on the changes made on the data item, the class Employee should implement __INotifyPropertyChanged__ Interface and raise the __PropertyChanged__ event every time a property value changes.
          

Once the class Employee is defined, you may use it for creating an object of this type and bind it to the RadDataForm:

#### __C#__

{{region raddataform-getting-started_8}}

	   Employee employee = new Employee() { 
			FirstName = "Sarah", 
			LastName = "Blake", 
			Occupation = "Supplied Manager", 
			StartingDate = new DateTime(2005, 04, 12), 
			IsMarried = true, Salary = 3500,   
			Gender = Gender.Female 
	   }; 
	   this.RadDataForm1.CurrentItem = employee;
	{{endregion}}



#### __VB.NET__

{{region raddataform-getting-started_9}}

        Dim employee As New Employee() With { _
         .FirstName = "Sarah", _
         .LastName = "Blake", _
         .Occupation = "Supplied Manager", _
         .StartingDate = New DateTime(2005, 4, 12), _
         .IsMarried = True, _
         .Salary = 3500, _
         .Gender = Gender.Female _
        }
        Me.DataForm1.CurrentItem = employee
	{{endregion}}



After you run the application you should see the following:

 ![](images/RadDataForm_bindToSingleItem.png)

## Binding RadDataForm to a collection of custom objects

We will create a simple **EmployeeService** class with a single static method - **GetEmployees()** that will return an **ObservableCollection&lt;Employee&gt;**, containing several hard-coded employees:

#### __C#__

{{region raddataform-getting-started_10}}

	public class EmployeeService
	{
	  public static ObservableCollection<Employee> GetEmployees()
	  {
	   ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
	   employees.Add(new Employee() { FirstName = "Sarah", LastName = "Blake", Occupation = "Supplied Manager", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 3500, Gender = Gender.Female });
	   employees.Add(new Employee() { FirstName = "Jane", LastName = "Simpson", Occupation = "Security", StartingDate = new DateTime(2008, 12, 03), IsMarried = true, Salary = 2000, Gender = Gender.Female });
	   employees.Add(new Employee() { FirstName = "John", LastName = "Peterson", Occupation = "Consultant", StartingDate = new DateTime(2005, 04, 12), IsMarried = false, Salary = 2600, Gender = Gender.Male });
	   employees.Add(new Employee() { FirstName = "Peter", LastName = "Bush", Occupation = "Cashier", StartingDate = new DateTime(2005, 04, 12), IsMarried = true, Salary = 2300, Gender = Gender.Male });
	   return employees;
	  }
	}
	{{endregion}}



#### __VB.NET__

{{region raddataform-getting-started_11}}

	Public Class EmployeeService
	 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
	  Dim employees As New ObservableCollection(Of Employee)()
	            employees.Add(New Employee() With { _
	              .FirstName = "Sarah", _
	              .LastName = "Blake", _
	              .Occupation = "Supplied Manager", _
	              .StartingDate = New DateTime(2005, 4, 12), _
	              .IsMarried = True, _
	              .Salary = 3500, _
	              .Gender = Gender.Female _
	            })
	            employees.Add(New Employee() With { _
	              .FirstName = "Jane", _
	              .LastName = "Simpson", _
	              .Occupation = "Security", _
	              .StartingDate = New DateTime(2008, 12, 3), _
	              .IsMarried = True, _
	              .Salary = 2000, _
	              .Gender = Gender.Female _
	            })
	            employees.Add(New Employee() With { _
	              .FirstName = "John", _
	              .LastName = "Peterson", _
	              .Occupation = "Consultant", _
	              .StartingDate = New DateTime(2005, 4, 12), _
	              .IsMarried = False, _
	              .Salary = 2600, _
	              .Gender = Gender.Male _
	            })
	            employees.Add(New Employee() With { _
	              .FirstName = "Peter", _
	              .LastName = "Bush", _
	              .Occupation = "Cashier", _
	              .StartingDate = New DateTime(2005, 4, 12), _
	              .IsMarried = True, _
	              .Salary = 2300, _
	              .Gender = Gender.Male _
	            })
	  Return employees
	 End Function
	End Class
	{{endregion}}



Afterwards, all you need to do is to set the ItemsSource of the RadDataForm:

#### __C#__

{{region raddataform-getting-started_12}}

	this.RadDataForm1.ItemsSource = EmployeeService.GetEmployees();
	{{endregion}}



#### __VB.NET__

{{region raddataform-getting-started_13}}

	Me.DataForm1.ItemsSource = Employee.GetEmployees()
	{{endregion}}



On running the application, you should see the following:

![](images/RadDataForm_bindToCollection.png)



As you may see, in this case the navigation buttons are displayed, thus allowing you to run through all the objects in the collection. Furthermore, you are allowed to add new item, delete and edit the current one.