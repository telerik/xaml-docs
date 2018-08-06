---
title: RadCalculatorPicker
page_title: RadCalculatorPicker
description: RadCalculatorPicker
slug: radcalculatorpicker-gettingstarted
tags: radcalculatorpicker
published: True
position: 1
---

# RadCalculatorPicker Getting Started

This tutorial will walk your through the creation of a sample application that contains __RadCalculatorPicker__ and will show you how:
		  

* Use RadCalculatorPicker in your project;

* User RadCalculatorPicker as editing element;

For the purpose of this example, you will need to create an empty {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF {% endif %}Application project and open it in Visual Studio.

* [Assembly References](#assembly-references)		
* [Adding RadCalculatorPicker to the Project](#adding-radcalculatorpicker-to-the-project)
* [Use RadCalculatorPicker as Editing Element](#using-radcalculatorpicker-as-editing-element)
  

## Assembly References

In order to use __RadCalculator__ in your projects, you have to add reference to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

## Adding RadCalculatorPicker to the Project

* Create a new {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} project;
				  

* Add references to the assemblies __Telerik.Windows.Controls__ and __Telerik.Windows.Controls.Input__;
				  

* Add the RadCalculatorPicker as demonstrated below

#### __[XAML] Example 1: Defining RadCalculator Picker__

{{region radcalculatorpicker-getting-started_0}}
	<UserControl x:Class="RadCalculatorPicker.MainPage"
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
	             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:my="clr-namespace:RadCalculatorPicker"
	             mc:Ignorable="d" d:DesignHeight="700" d:DesignWidth="700">   
	  
		<Grid x:Name="LayoutRoot" Background="White" >
			<telerik:RadCalculatorPicker Height="30" Width="200" />		
	    </Grid>
	</UserControl>
{{endregion}}

Now if you run the application, you have RadCalculatorPicker:

#### __Figure 1: Defining RadCalculatorPicker__
![Rad Calculator Picker-Basic](images/RadCalculatorPicker-Basic.png)


## Use RadCalculatorPicker as Editing Element

RadCalculatorPicker can be embeded as an editing element. In this case we will define it in a CellEditTemplate for a column in RadGridView. For this example we will create as simple grid  and customize one of its columns:

#### __[XAML] Example 2: Using RadCalculatorPicker as a cell editor of RadGridView__

{{region radcalculatorpicker-getting-started_4}}

	<telerik:RadGridView Name="clubsGrid" CanUserFreezeColumns="False" 
						 ShowGroupPanel="False" RowIndicatorVisibility="Collapsed"
						 ItemsSource="{Binding Clubs}"
						 ColumnWidth="*"
						 AutoGenerateColumns="False">
		<telerik:RadGridView.Columns>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/>				
			<telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}" 
										Header="Stadium" 
										DataFormatString="{}{0:N0}">
				<telerik:GridViewDataColumn.CellEditTemplate>
					<DataTemplate>
						<telerik:RadCalculatorPicker Value="{Binding StadiumCapacity,Mode=TwoWay}" />
					</DataTemplate>
				</telerik:GridViewDataColumn.CellEditTemplate>
			</telerik:GridViewDataColumn>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Established}"
										Header="Est." 
										DataFormatString="{}{0:yyyy}"/>
		</telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}


Once we start editing the column we have customized, we will get the following editor

#### __Figure 2: Using RadCalculatorPicker as a cell editor of RadGridView__
![Rad Calculator Picker-Integration With Rad Grid View](images/RadCalculatorPicker-IntegrationWithRadGridView.png)

## See Also

* [RadCalculatorPicker Getting Started]({%slug radcalculator-gettingstarted%})
