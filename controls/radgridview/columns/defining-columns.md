---
title: Defining Columns
page_title: Defining Columns
description: Defining Columns
slug: gridview-columns-defining-columns
tags: defining,columns
published: True
position: 8
---

# Defining Columns

You can define columns for __RadGridView__ in two ways: 

* let __RadGridView__ automatically generate the columns based on the underlying data source. 
* manually specify columns in XAML or code-behind. 

This help article explains how to do both with code examples.

## Automatic Columns Generation

By default, __RadGridView__ will generate its columns automatically based on the underlying data source. When, for example, you set the __ItemsSource__ of the __RadGridView__ control to a collection of employees (see code in __Example 1__ and the result in __Figure 1__), __RadGridView__ will create a separate column for each public propertiy of the __Employee__ object.

However, if you wish to explicitly specify the column name for certain property of your data class or to prevent the creation of a column for it, use the __System.ComponentModel.DataAnnotations.DisplayAttribute__, as it is shown in the sample below.

__Example 1: RadGridView__ generates columns automatically.

#### __C#__

{{region gridview-columns-defining-columns_0}}

	public class Employee
	{
	    [DisplayAttribute( AutoGenerateField = false )]
	    public int EmployeeId
	    {
	        get;
	        set;
	    }
	    [DisplayAttribute( Name = "First Name" )]
	    public string FirstName
	    {
	        get;
	        set;
	    }
		[DisplayAttribute( Name = "Last Name" )]
	    public string LastName
	    {
	        get;
	        set;
	    }
	}
{{endregion}}

#### __VB__

{{region gridview-columns-defining-columns_1}}

	Public Class Employee
		<DisplayAttribute(AutoGenerateField:=False)> _
		Public Property EmployeeId() As Integer
			Get
				Return m_EmployeeId
			End Get
			Set(value As Integer)
				m_EmployeeId = Value
			End Set
		End Property
		Private m_EmployeeId As Integer
		<DisplayAttribute(Name:="First Name")> _
		Public Property FirstName() As String
			Get
				Return m_FirstName
			End Get
			Set(value As String)
				m_FirstName = Value
			End Set
		End Property
		Private m_FirstName As String
		<DisplayAttribute(Name:="Last Name")> _
		Public Property LastName() As String
			Get
				Return m_LastName
			End Get
			Set(value As String)
				m_LastName = Value
			End Set
		End Property
		Private m_LastName As String
	End Class
{{endregion}}

__Figure 1:__ The result of letting __RadGridView__ automatically generate two columns. 

![Rad Grid View definingcolumns 1](images/RadGridView_definingcolumns_1.png)

## Manual Columns Definition

Using the built-in auto generation of columns does not fit all scenarios. In such cases you can manually define columns you want to be displayed. When defining a column you can choose between several column types:

*  [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) 
*  [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%})
*  [GridViewDataColumn]({%slug radgridview-columns-column-types-data-column%})
*  [GridViewHyperlinkColumn]({%slug radgridview-columns-column-types-hyperlink-column%}) 
*  [GridViewDynamicHyperlinkColumn]({%slug radgridview-columns-column-types-dynamic-hyperlink-column%})
*  [GridViewImageColumn]({%slug radgridview-columns-columntypes-image-column%})
*  [GridViewSelectColumn]({%slug radgridview-columns-column-types-select-column%})
*  [GridViewComboBoxColumn]({%slug radgridview-columns-column-types-combobox-column%})
*  [Masked Input Column]({%slug radgridview-columns-column-types-masked-input-column%})
*  [Toggle RowDetails Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%}).

You must add the columns to __Columns__ collection of __RadGridView__. Later on in the application lifecycle, you can easily access them via the __UniqueName__ property or by column index. To see this sequence unfold, look at the following step-by-step example.

* Define a column of type __GridViewDataColumn__.

#### __XAML__

{{region gridview-columns-defining-columns_2}}

	<telerik:GridViewDataColumn/>
{{endregion}}

>You will find the column types in the same namespace (__Telerik.Windows.Controls__) and assembly (__Telerik.Windows.Controls.GridView.dll__) as __RadGridView__.

#### __C#__

{{region gridview-columns-defining-columns_3}}

	GridViewDataColumn column = new GridViewDataColumn();
{{endregion}}

#### __VB__

{{region gridview-columns-defining-columns_4}}

	Dim column As New GridViewDataColumn()
{{endregion}}

* Set __Header__ property and add the column to the __Columns__ collection. The default Header will be the property specified as DataMemberBinding. 
		  

>importantYou can set and work with the __UniqueName__ of a column only when you have also set the __DataMemberBinding__. Otherwise, please use the __Header__ instead of __UniqueName__.
			  

#### __XAML__

{{region gridview-columns-defining-columns_5}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
		<telerik:RadGridView.Columns>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}" 
              Header="First Name" />
		</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### __C#__

{{region gridview-columns-defining-columns_6}}

	GridViewDataColumn column = new GridViewDataColumn();
	column.DataMemberBinding = new Binding( "FirstName" );
	column.Header = "My Column";
	column.UniqueName = "MyColumn";
	this.radGridView.AutoGenerateColumns = false;
	this.radGridView.Columns.Add( column );
{{endregion}}

#### __VB__

{{region gridview-columns-defining-columns_7}}

	Dim column As New GridViewDataColumn()
	column.DataMemberBinding = New Binding("FirstName")
	column.Header = "My Column"
	column.UniqueName = "MyColumn"
	Me.radGridView.AutoGenerateColumns = False
	Me.radGridView.Columns.Add(column)
{{endregion}}

* To access the column later, use the __UniqueName__ value or its __column index__ as a key for the __Columns__ collection.
		  

#### __C#__

{{region gridview-columns-defining-columns_8}}

	GridViewDataColumn myColumn = this.radGridView.Columns[ "FirstColumn" ];
	myColumn = this.radGridView.Columns[ 0 ];
{{endregion}}


#### __VB__

{{region gridview-columns-defining-columns_9}}

	Dim myColumn As GridViewDataColumn = Me.radGridView.Columns("MyColumn")
	myColumn = Me.radGridView.Columns(0)
{{endregion}}

* In order to set a __CellTemplate__ of __GridViewDataColumn__ in code-behind you can store a defined __DataTemplate__ within __Resources collection__ as follows:
	   {% if site.site_name == 'WPF' %}

#### __XAML__

{{region gridview-columns-defining-columns_11}}

	<Window.Resources>
	    <DataTemplate x:Key="dataTemplate1">
	        <TextBlock Text="Text"/>
	     </DataTemplate>
	</Window.Resources>
{{endregion}}

{% endif %}
{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region gridview-columns-defining-columns_10}}

	<UserControl.Resources>
	    <DataTemplate x:Key="dataTemplate1">
	        <TextBlock Text="Text"/>
	     </DataTemplate>
	</UserControl.Resources>
{{endregion}}

{% endif %}
Then reference it in code-behind as demonstrated below:
        
#### __C#__

{{region gridview-columns-defining-columns_12}}

	GridViewDataColumn column = new GridViewDataColumn();
	column.CellTemplate = (DataTemplate)this.Resources["dataTemplate1"];
	radGridView.Columns.Add(column );
{{endregion}}

#### __VB__

{{region gridview-columns-defining-columns_13}}

	Dim column As New GridViewDataColumn()
	column.CellTemplate = DirectCast(Me.Resources("dataTemplate1"), DataTemplate)
	Me.radGridView.Columns.Add(column)
{{endregion}}


# See Also

 * [Basic Column]({%slug radgridview-columns-column-types-basic-column%})
 
 * [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})
 
 * [Column Groups]({%slug gridview-column-groups%})

 * [Data Formatting]({%slug gridview-columns-data-formatting%})
