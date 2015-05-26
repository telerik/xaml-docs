---
title: Unbound Mode
page_title: Unbound Mode
description: Unbound Mode
slug: radpropertygrid-unbound-mode
tags: unbound,mode
published: True
position: 4
---

# Unbound Mode



With this feature RadPropertyGrid enables its users to create their own nested property hierarchies, without the need to respect any of the actual parent/child or siblings relations. 

## AutogenerateBindingPaths

When non-auto-generated PropertyDefinitions are used, RadPropertyGrid relies on an internal “binding path generation” mechanism, as it is described in this article. This behavior can be modified by setting the __AutogenerateBindingPaths__ property to __"False"__. In this mode, it is mandatory to write the whole binding path, from the root (Item) level, to the respective nested property. 

The following examples illustrate two possible hierarchies based on the following class definitions:


#### [C#]Example 1: Prepare sample objects

	{{region radpropertygrid-unbound-mode_2}}
	    public class Employee
	    {
	        public string Name { get; set; }
	        public DateTime HireDate { get; set; }
	        public Department Department { get; set; }
	    }
	 
	    public class Department
	    {
	        public string Name { get; set; }
	        public int ID { get; set; }
	    }
	{{endregion}}



#### [VB.NET]Example 1: Prepare sample objects

	{{region radpropertygrid-unbound-mode_3}}
	    Public Class Employee
	        Public Property Name() As String
	            Get
	                Return m_Name
	            End Get
	            Set(value As String)
	                m_Name = Value
	            End Set
	        End Property
	        Private m_Name As String
	        Public Property HireDate() As DateTime
	            Get
	                Return m_HireDate
	            End Get
	            Set(value As DateTime)
	                m_HireDate = Value
	            End Set
	        End Property
	        Private m_HireDate As DateTime
	        Public Property Department() As Department
	            Get
	                Return m_Department
	            End Get
	            Set(value As Department)
	                m_Department = Value
	            End Set
	        End Property
	        Private m_Department As Department
	    End Class
	
	    Public Class Department
	        Public Property Name() As String
	            Get
	                Return m_Name
	            End Get
	            Set(value As String)
	                m_Name = Value
	            End Set
	        End Property
	        Private m_Name As String
	        Public Property ID() As Integer
	            Get
	                Return m_ID
	            End Get
	            Set(value As Integer)
	                m_ID = Value
	            End Set
	        End Property
	        Private m_ID As Integer
	    End Class
	{{endregion}}



And the sample data:
          

#### [C#]Example 2: Prepare sample data

	{{region radpropertygrid-unbound-mode_4}}
	    public MainPage()
	        {
	            InitializeComponent();
	            this.rpg.Item = new Employee()
	            {
	                Name = "Nancy Davolio",
	                HireDate = DateTime.Now,
	                Department = new Department()
	                {
	                    ID = 1,
	                    Name = "US Department"                    
	                }
	            };
	        }
	{{endregion}}



#### [VB.NET]Example 2: Prepare sample data

	{{region radpropertygrid-unbound-mode_5}}
	   Public Sub New()
	        InitializeComponent()
	        Me.rpg.Item = New Employee()
	        With {
	               .Name = "Nancy Davolio",
	               .HireDate = Date.Now,
	               .Department = New Department() 
	            With {
	                 .ID = 1,
	                 .Name = "US Department"
	                 }
	
	            End With
	            }
	    End Sub
	{{endregion}}


#### [XAML]Example 3: RadPropertyGrid UnboundMode first example

	{{region radpropertygrid-unbound-mode_0}}
	<telerik:RadPropertyGrid x:Name="rpg" 
                             AutoGenerateBindingPaths="False" 
                             AutoGeneratePropertyDefinitions="False" 
                             NestedPropertiesVisibility="Visible">
	            <telerik:RadPropertyGrid.PropertyDefinitions>
	                <telerik:PropertyDefinition DisplayName="Employee Info">
	                    <telerik:PropertyDefinition.NestedProperties>
	                        <telerik:PropertyDefinition DisplayName="Name" Binding="{Binding Name}" />
	                        <telerik:PropertyDefinition DisplayName="HireDate" Binding="{Binding HireDate}" />
	                    </telerik:PropertyDefinition.NestedProperties>
	                </telerik:PropertyDefinition>
	                <telerik:PropertyDefinition DisplayName="Department Info">
	                    <telerik:PropertyDefinition.NestedProperties>
	                        <telerik:PropertyDefinition DisplayName="Department Name" Binding="{Binding Department.Name}" />
	                        <telerik:PropertyDefinition DisplayName="Department ID" Binding="{Binding Department.ID}" />
	                    </telerik:PropertyDefinition.NestedProperties>
	                </telerik:PropertyDefinition>
	            </telerik:RadPropertyGrid.PropertyDefinitions>
	        </telerik:RadPropertyGrid>
	
	{{endregion}}





![Rad Property Grid Unboud Mode 1](images/RadPropertyGrid_UnboudMode1.png)


#### [XAML]Example 4: RadPropertyGrid UnboundMode second example

	{{region radpropertygrid-unbound-mode_1}}
	<telerik:RadPropertyGrid x:Name="rpg" 
                             AutoGenerateBindingPaths="False" 
                             AutoGeneratePropertyDefinitions="False" 
                             NestedPropertiesVisibility="Visible">
	            <telerik:RadPropertyGrid.PropertyDefinitions>
	                <telerik:PropertyDefinition DisplayName="Name" Binding="{Binding Name}" >
	                    <telerik:PropertyDefinition.NestedProperties>
	                        <telerik:PropertyDefinition DisplayName="Department Name" Binding="{Binding Department.Name}">
	                            <telerik:PropertyDefinition.NestedProperties>
	                                <telerik:PropertyDefinition DisplayName="Department ID" Binding="{Binding Department.ID}" />
	                            </telerik:PropertyDefinition.NestedProperties>
	                        </telerik:PropertyDefinition>
	                    </telerik:PropertyDefinition.NestedProperties>
	                </telerik:PropertyDefinition>
	                <telerik:PropertyDefinition DisplayName="HireDate" Binding="{Binding HireDate}" />
	            </telerik:RadPropertyGrid.PropertyDefinitions>
	        </telerik:RadPropertyGrid>
	
	{{endregion}}


![Rad Property Grid Unboud Mode 2](images/RadPropertyGrid_UnboudMode2.png)
