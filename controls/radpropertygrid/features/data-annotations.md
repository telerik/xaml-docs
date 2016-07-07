---
title: Data Annotations
page_title: Data Annotations
description: Data Annotations
slug: radpropertygrid-data-annotations
tags: data,annotations
published: True
position: 8
---

# Data Annotations

This article will show you how to use **Data Annotations** with **RadPropertyGrid**.

We will discuss the following attributes:

* [Display](#display)

* [ReadOnly](#readonly)

* [Browsable](#browsable)

They allow you to categorize different properties into separate groups, set some of them as read-only or define description for each one of them.

## Creating RadPropertyGrid Application

First, for the purpose of this article, we will create a new **Employee** class with a couple of properties:

#### __[C#] Example 1: Creating the Employee class__

	{{region radpropertygrid-data-annotations_1}}
	     public class Employee
	    {       
	        public string FirstName { get; set; }
	        public string LastName { get; set; }
	        public string PhoneNum { get; set; } 
	        public int Salary { get; set; }
	        public string Occupation { get; set; }                          
	        public DateTime StartingDate { get; set; }              
	    }
	{{endregion}}

#### __[VB.NET] Example 1: Creating the Employee class__

	{{region radpropertygrid-data-annotations_1}}
	    Public Class Employee
	        Public Property FirstName() As String
	            Get
	                Return m_FirstName
	            End Get
	            Set(value As String)
	                m_FirstName = Value
	            End Set
	        End Property
	        Private m_FirstName As String
	        Public Property LastName() As String
	            Get
	                Return m_LastName
	            End Get
	            Set(value As String)
	                m_LastName = Value
	            End Set
	        End Property
	        Private m_LastName As String
	        Public Property PhoneNum() As String
	            Get
	                Return m_PhoneNum
	            End Get
	            Set(value As String)
	                m_PhoneNum = Value
	            End Set
	        End Property
	        Private m_PhoneNum As String
	        Public Property Salary() As Integer
	            Get
	                Return m_Salary
	            End Get
	            Set(value As Integer)
	                m_Salary = Value
	            End Set
	        End Property
	        Private m_Salary As Integer
	        Public Property Occupation() As String
	            Get
	                Return m_Occupation
	            End Get
	            Set(value As String)
	                m_Occupation = Value
	            End Set
	        End Property
	        Private m_Occupation As String
	        Public Property StartingDate() As DateTime
	            Get
	                Return m_StartingDate
	            End Get
	            Set(value As DateTime)
	                m_StartingDate = Value
	            End Set
	        End Property
	        Private m_StartingDate As DateTime
	    End Class
	{{endregion}}

The declaration of RadPropertyGrid control inside the Grid:        

#### __[XAML] Example 2: Declaring RadPropertyGrid__

	{{region radpropertygrid-data-annotations_0}}
	<telerik:RadPropertyGrid x:Name="propertyGrid1" />
	{{endregion}}

Once the class Employee is defined, you may use it for creating an object of this type and bind it to RadPropertyGrid:

#### __[C#] Example 3: Binding Employee instance to RadPropertyGrid__

	{{region radpropertygrid-data-annotations_2}}
	this.propertyGrid1.Item = new Employee()
	            {
	                FirstName = "Sarah",
	                LastName = "Blake",
	                PhoneNum = "(555) 943-231",
	                Occupation = "Supplies Manager",              
	                Salary = 3500,
	                StartingDate = new DateTime(2005, 12, 4)
	            };
	{{endregion}}

#### __[VB.NET] Example 3: Binding Employee instance to RadPropertyGrid__

	{{region radpropertygrid-data-annotations_2}}
	    Me.PropertyGrid1.Item = New Employee() With { _
	  .FirstName = "Sarah", _
	  .LastName = "Blake", _
	  .Occupation = "Supplied Manager", _
	  .StartingDate = New DateTime(2005, 4, 12), _
	  .Salary = 3500 _
	}
	{{endregion}}

After you run the application you should see the following:

#### __Figure 1: RadPropertyGrid bound to an Employee instance__

![RadPropertyGrid bound to an Employee instance](images/RadPropertyGrid_Data_Annotations_1.PNG)

>importantIf you want to use Data Annotations in your application, you have to add a reference to the **System.ComponentModel.DataAnnotations** assembly.

## Display

The **Display** attribute specifies localizable strings for data types and members that are used in the user interface. You can use its following properties:

* __Name__: The value to be displayed instead of the property name.

* __Description__: A description of the property. This will be shown in RadPropertyGrid's [DescriptionPanel]({%slug radpropertygrid-visualstructure%}).

* __GroupName__: Used when you want to categorize different properties into separate groups.

* __Order__: Used when you want to set a property's display order.
              
**Example 4** demonstrates how you can specify a Display attribute for a property:

#### __[C#] Example 4: Setting Display attribute__

	{{region radpropertygrid-data-annotations_3}}
     //Rename the StartingDate property to Year in the UI
     [Display(Name = "Year")]
     public DateTime StartingDate { get; set; }

     //Set a description to the FirstName property and categorize it to be from the group "Personal Information"
     [Display(Description = "Employee's first name.", GroupName = "Personal Information")]
     public string FirstName { get; set; }

     //Set a description to the LastName property and categorize it to be from the group "Personal Information"
     [Display(Description = "Employee's last name.", GroupName = "Personal Information")]
     public string LastName { get; set; }
	{{endregion}}

#### __[VB.NET] Example 4: Setting Display attribute__

	{{region radpropertygrid-data-annotations_3}}
	'Rename the StartingDate property to Year in the UI
	<Display(Name := "Year")> _
	Public Property StartingDate() As DateTime
		Get
			Return m_StartingDate
		End Get
		Set
			m_StartingDate = Value
		End Set
	End Property
	Private m_StartingDate As DateTime
	
	'Set a description to the FirstName property and categorize it to be from the group "Personal Information"
	<Display(Description := "Employee's first name.", GroupName := "Personal Information")> _
	Public Property FirstName() As String
		Get
			Return m_FirstName
		End Get
		Set
			m_FirstName = Value
		End Set
	End Property
	Private m_FirstName As String
	
	'Set a description to the LastName property and categorize it to be from the group "Personal Information"
	<Display(Description := "Employee's last name.", GroupName := "Personal Information")> _
	Public Property LastName() As String
		Get
			Return m_LastName
		End Get
		Set
			m_LastName = Value
		End Set
	End Property
	Private m_LastName As String
	{{endregion}}

## Browsable

The **Browsable** attribute specifies whether a property should be displayed or not.

#### __[C#] Example 5: Setting Browsable attribute__

	{{region radpropertygrid-data-annotations_4}}
     //Hide StartingDate from the UI
    [Browsable(false)]
    public DateTime StartingDate { get; set; }
	{{endregion}}

#### __[VB.NET] Example 5: Setting Browsable attribute__

	{{region radpropertygrid-data-annotations_4}}
	'Hide StartingDate from the UI
	<Browsable(False)> _
	Public Property StartingDate() As DateTime
		Get
			Return m_StartingDate
		End Get
		Set
			m_StartingDate = Value
		End Set
	End Property
	Private m_StartingDate As DateTime
	{{endregion}}

## ReadOnly

The **ReadOnly** attribute specifies whether the property this attribute is bound to is read-only or read/write.

#### __[C#] Example 6: Setting ReadOnly attribute__

	{{region radpropertygrid-data-annotations_5}}
     //Set StartingDate as Read-Only
    [ReadOnly(true)]
    public DateTime StartingDate { get; set; }
	{{endregion}}

#### __[VB.NET] Example 6: Setting ReadOnly attribute__

	{{region radpropertygrid-data-annotations_5}}
	'Set StartingDate as Read-Only
	<[ReadOnly](True)> _
	Public Property StartingDate() As DateTime
		Get
			Return m_StartingDate
		End Get
		Set
			m_StartingDate = Value
		End Set
	End Property
	Private m_StartingDate As DateTime
	{{endregion}}

To see these attributes in action, let's modify the Employee class and see the result in RadPropertGrid.

#### __[C#] Example 7: Modifying sample data__

	{{region radpropertygrid-data-annotations_6}}
    [Display(Description = "Employee's first name.", GroupName="Personal Information")]
    public string FirstName { get; set; }     

    [Display(Description = "Employee's last name.", GroupName="Personal Information")]
    public string LastName { get; set; }

    [Display(Name = "Occupation", GroupName = "Job Description")]
    public string Occupation { get; set; }    
   
    [Browsable(false)]
    public int Salary { get; set; }

    [Display(Name = "Number", GroupName = "Job Description")]
    public string PhoneNum { get; set; }     

    [ReadOnly(true)]
    public DateTime StartingDate { get; set; } 
	{{endregion}}

#### __[VB.NET] Example 7: Modifying sample data__

	{{region radpropertygrid-data-annotations_6}}
	<Display(Description := "Employee's first name.", GroupName := "Personal Information")> _
	Public Property FirstName() As String
		Get
			Return m_FirstName
		End Get
		Set
			m_FirstName = Value
		End Set
	End Property
	Private m_FirstName As String
	
	<Display(Description := "Employee's last name.", GroupName := "Personal Information")> _
	Public Property LastName() As String
		Get
			Return m_LastName
		End Get
		Set
			m_LastName = Value
		End Set
	End Property
	Private m_LastName As String
	
	<Display(Name := "Occupation", GroupName := "Job Description")> _
	Public Property Occupation() As String
		Get
			Return m_Occupation
		End Get
		Set
			m_Occupation = Value
		End Set
	End Property
	Private m_Occupation As String
	
	<Browsable(False)> _
	Public Property Salary() As Integer
		Get
			Return m_Salary
		End Get
		Set
			m_Salary = Value
		End Set
	End Property
	Private m_Salary As Integer
	
	<Display(Name := "Number", GroupName := "Job Description")> _
	Public Property PhoneNum() As String
		Get
			Return m_PhoneNum
		End Get
		Set
			m_PhoneNum = Value
		End Set
	End Property
	Private m_PhoneNum As String
	
	<[ReadOnly](True)> _
	Public Property StartingDate() As DateTime
		Get
			Return m_StartingDate
		End Get
		Set
			m_StartingDate = Value
		End Set
	End Property
	Private m_StartingDate As DateTime
	{{endregion}}

Here's the resulting RadPropertyGrid sorted alphabetically and in grouped mode:

#### __Figure 2: RadPropertyGrid with data annotations sorted alphabetically__

![RadPropertyGrid with data annotations sorted alphabetically](images/RadPropertyGrid_Data_Annotations_5.PNG)

#### __Figure 3: RadPropertyGrid with data annotations in grouped mode__

![Rad Property Grid Data Annotations 5](images/RadPropertyGrid_Data_Annotations_4.PNG)

## See also

* [Editor Attribute]({%slug radpropertygrid-editor-attribute%})

* [Grouping Support]({%slug radpropertygrid-grouping%})