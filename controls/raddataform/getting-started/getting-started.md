---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadDataForm {{ site.framework_name }} control.
slug: raddataform-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started with {{ site.framework_name }} DataForm

This article will walk your through the creation of a sample application that contains __RadDataForm__ and will show you how to:

* [Use RadDataForm in your project](#adding-raddataform-to-the-project);

* [Bind RadDataForm to a single item](#binding-raddataform-to-a-single-item);

* [Bind RadDataForm to a collection of custom objects](#binding-raddataform-to-a-collection-of-custom-objects);

## Adding Telerik Assemblies Using NuGet

To use __RadDataForm__ when working with NuGet packages, install the `Telerik.Windows.Controls.Data.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Data__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Adding RadDataForm to the Project

* Create a new WPF project;

* Add the RadDataForm to the Grid:

__Example 1: Adding RadDataForm in XAML__

```XAML
	  <UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot" Background="White">
	      <telerik:RadDataForm x:Name="RadDataForm1" />
	    </Grid>
	  </UserControl>
```

Now if you run the application, you will see the empty RadDataForm:

#### __Figure 1: Empty RadDataForm__

![Empty RadDataForm](images/radDataForm_emptyForm.png)

## Binding RadDataForm to a Single Item

Firstly, for the purpose of this tutorial, we will create a new **Employee** class with a couple of exposed properties:

__Example 2: Creating an Employee Class with Some Exposed Properties__

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
	    Public Property StartingDate() As DateTime
	        Get
	            Return m_StartingDate
	        End Get
	        Set(value As DateTime)
	            m_StartingDate = value
	        End Set
	    End Property
	    Private m_StartingDate As DateTime
	    Public Property IsMarried() As Boolean
	        Get
	            Return m_IsMarried
	        End Get
	        Set(value As Boolean)
	            m_IsMarried = value
	        End Set
	    End Property
	    Private m_IsMarried As Boolean
	    Public Property Salary() As Integer
	        Get
	            Return m_Salary
	        End Get
	        Set(value As Integer)
	            m_Salary = value
	        End Set
	    End Property
	    Private m_Salary As Integer
	    Public Property Gender() As Gender
	        Get
	            Return m_Gender
	        End Get
	        Set(value As Gender)
	            m_Gender = value
	        End Set
	    End Property
	    Private m_Gender As Gender
	End Class
```

In the example above **Gender** is of type enum:

__Example 3: Create Gender Enumeration__

```C#
	public enum Gender
	{
	    Female,
	    Male
	}
```
```VB.NET
	Public Enum Gender
	    Female
	    Male
	End Enum
```

>Note that in case you want to be notified on the changes made on the data item, the class Employee should implement the __INotifyPropertyChanged__ interface and raise the __PropertyChanged__ event every time a property value changes.

Once the class Employee is defined, you may use it for creating an object of this type and bind it to RadDataForm:

__Example 4: Binding a Single Item to RadDataForm__

```C#
	Employee employee = new Employee()
	{
	    FirstName = "Sarah",
	    LastName = "Blake",
	    Occupation = "Supplied Manager",
	    StartingDate = new DateTime(2005, 04, 12),
	    IsMarried = true,
	    Salary = 3500,
	    Gender = Gender.Female
	};
	this.RadDataForm1.CurrentItem = employee;
```
```VB.NET
	Dim employee As New Employee() With {
	 .FirstName = "Sarah",
	 .LastName = "Blake",
	 .Occupation = "Supplied Manager",
	 .StartingDate = New DateTime(2005, 4, 12),
	 .IsMarried = True,
	 .Salary = 3500,
	 .Gender = Gender.Female
	}
	Me.RadDataForm1.CurrentItem = employee
```

After you run the application you should see the following:

#### __Figure 2: RadDataForm bound to a single item__

![RadDataForm bound to a single item](images/RadDataForm_bindToSingleItem.png)

## Binding RadDataForm to a collection of custom objects

We will create a simple **EmployeeService** class with a single static method - **GetEmployees()** that will return an **ObservableCollection&lt;Employee&gt;**, containing several hard-coded employees:

__Example 5: Creating an EmployeeService class with a static GetEmployees() method__

```C#
	public class EmployeeService
	{
	    public static ObservableCollection<Employee> GetEmployees()
	    {
	        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
	        employees.Add(new Employee() 
	        { 
	            FirstName = "Sarah", 
	            LastName = "Blake", 
	            Occupation = "Supplied Manager", 
	            StartingDate = new DateTime(2005, 04, 12), 
	            IsMarried = true, Salary = 3500, 
	            Gender = Gender.Female 
	        });
	        employees.Add(new Employee() 
	        { 
	            FirstName = "Jane", 
	            LastName = "Simpson", 
	            Occupation = "Security", 
	            StartingDate = new DateTime(2008, 12, 03), 
	            IsMarried = true, 
	            Salary = 2000, 
	            Gender = Gender.Female 
	        });
	        employees.Add(new Employee() 
	        { 
	            FirstName = "John", 
	            LastName = "Peterson", 
	            Occupation = "Consultant", 
	            StartingDate = new DateTime(2005, 04, 12), 
	            IsMarried = false, Salary = 2600, 
	            Gender = Gender.Male 
	        });
	        employees.Add(new Employee() 
	        { 
	            FirstName = "Peter", 
	            LastName = "Bush",
	            Occupation = "Cashier", 
	            StartingDate = new DateTime(2005, 04, 12), 
	            IsMarried = true, 
	            Salary = 2300, 
	            Gender = Gender.Male 
	        });
	        return employees;
	    }
	}
```
```VB.NET
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
```

Afterwards, all you need to do is to set the **ItemsSource** of RadDataForm:

__Example 6: Set the ItemsSource of the RadDataForm to the Observable Collection__

```C#
	this.RadDataForm1.ItemsSource = EmployeeService.GetEmployees();
```
```VB.NET
	Me.RadDataForm1.ItemsSource = EmployeeService.GetEmployees()
```

On running the application, you should see the following:

#### __Figure 3: RadDataForm bound to a collection of items__

![RadDataForm bound to a collection of items](images/RadDataForm_bindToCollection.png)

As you may see, in this case the navigation buttons are displayed, thus allowing you to run through all the objects in the collection. Furthermore, you are allowed to add new item, delete and edit the current one.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF DataForm Component](https://www.telerik.com/products/wpf/dataform.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

