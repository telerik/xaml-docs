---
title: In-Memory Data
page_title: In-Memory Data
description: In-Memory Data
slug: consuming-data-in-memory-data
tags: in-memory,data
published: True
position: 8
---

# In-Memory Data



The purpose of this tutorial is to show you how to create in-memory data and use it in the context of your {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application. The following common tasks will be examined:

* Creating in-memory data. 


* Setting it as a data source/data context in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application.

>This tutorial will use objects and data from the __Northwind__ database, which can be downloaded from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

## Creating In-Memory Data

Here is a sample code showing how to create in-memory data: 

#### __C#__

{{region consuming-data-in-memory-data_0}}
	public List<Categories> categories = new List<Categories>();
	public void CreateCategories()
	{
	    Categories c = new Categories();
	    c.CategoryID = 1;
	    c.CategoryName = "Beverages";
	    c.Description = "Soft drinks, coffees, teas, beers, and ales";
	    categories.Add( c );
	    c = new Categories();
	    c.CategoryID = 2;
	    c.CategoryName = "Condiments";
	    c.Description = "Sweet and savory sauces, relishes, spreads, and seasonings";
	    categories.Add( c );
	    c = new Categories();
	    c.CategoryID = 3;
	    c.CategoryName = "Confections";
	    c.Description = "Desserts, candies, and sweet breads";
	    categories.Add( c );
	}
	{{endregion}}



#### __VB.NET__

{{region consuming-data-in-memory-data_1}}
	Public categories As New List(Of Categories)()
	Public Sub CreateCategories()
	    Dim c As New Categories()
	    c.CategoryID = 1
	    c.CategoryName = "Beverages"
	    c.Description = "Soft drinks, coffees, teas, beers, and ales"
	    categories.Add(c)
	    c = New Categories()
	    c.CategoryID = 2
	    c.CategoryName = "Condiments"
	    c.Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
	    categories.Add(c)
	    c = New Categories()
	    c.CategoryID = 3
	    c.CategoryName = "Confections"
	    c.Description = "Desserts, candies, and sweet breads"
	    categories.Add(c)
	End Sub
	{{endregion}}



## Setting In-Memory Data as DataSource In {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} Application

There are numerous ways to set in-memory data as data source:

* Using XAML. Here is a sample XAML code:

#### __XAML__

{{region consuming-data-in-memory-data_2}}
	<UserControl.Resources>
	        <example:categories x:Key="DataSource"/>       
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Background="White">
	        <telerikNavigation:RadTreeView x:Name="radTreeView"
	           ItemsSource="{Binding Source={StaticResource DataSource}"/>
	</Grid>
	{{endregion}}



*  In code-behind:

#### __C#__

{{region consuming-data-in-memory-data_3}}
	radTreeView.ItemsSource = categories;
	// Or
	radTreeView.DataContext = categories;
	{{endregion}}



#### __VB.NET__

{{region consuming-data-in-memory-data_4}}
	radTreeView.ItemsSource = categories
	' Or'
	radTreeView.DataContext = categories
	{{endregion}}



## See Also

{% if site.site_name == 'Silverlight' %}
 * [DomainDataSource Support]({%slug consuming-data-domain-datasource-support%})
{% endif %}

 * [Using XML]({%slug consuming-data-using-xml%})
