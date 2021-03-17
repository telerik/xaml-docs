---
title: In-Memory Data
page_title: In-Memory Data
description: This article will demonstrate how you can create in-memory data and use it in your {{ site.framework_name }} application.
slug: consuming-data-in-memory-data
tags: in-memory,data
published: True
position: 8
---

# In-Memory Data

The purpose of this tutorial is to show you how to create in-memory data and use it in the context of your {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application. The following common tasks will be examined:

* Creating in-memory data. 

* Setting it as a data source/data context in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application.

## Creating In-Memory Data

__Example 1__ shows how you can create some in-memory data.

#### __[C#] Example 1: Creating in-memory data__

{{region consuming-data-in-memory-data_0}}
	public class Category
    {
        public string CategoryName { get; internal set; }
        public int CategoryID { get; internal set; }
        public string Description { get; internal set; }
    }

	public class ViewModel
    {
        private ObservableCollection<Category> categories;

        public ObservableCollection<Category> Categories
        {
            get
            {
                if(this.categories == null)
                {
                    this.categories = this.CreateCategories();
                }

                return this.categories;
            }
        }

        private ObservableCollection<Category> CreateCategories()
        {
            var categories = new ObservableCollection<Category>();
            var c = new Category();
            c.CategoryID = 1;
            c.CategoryName = "Beverages";
            c.Description = "Soft drinks, coffees, teas, beers, and ales";
            categories.Add(c);
            c = new Category();
            c.CategoryID = 2;
            c.CategoryName = "Condiments";
            c.Description = "Sweet and savory sauces, relishes, spreads, and seasonings";
            categories.Add(c);
            c = new Category();
            c.CategoryID = 3;
            c.CategoryName = "Confections";
            c.Description = "Desserts, candies, and sweet breads";
            categories.Add(c);

            return categories;
        }
    }
{{endregion}}



#### __[VB.NET] Example 1: Creating in-memory data__

{{region consuming-data-in-memory-data_1}}
	Public Class Category
		Private privateCategoryName As String
		Public Property CategoryName() As String
			Get
				Return privateCategoryName
			End Get
			Friend Set(ByVal value As String)
				privateCategoryName = value
			End Set
		End Property
		Private privateCategoryID As Integer
		Public Property CategoryID() As Integer
			Get
				Return privateCategoryID
			End Get
			Friend Set(ByVal value As Integer)
				privateCategoryID = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Friend Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
	End Class

	Public Class ViewModel

		Private _categories As ObservableCollection(Of Category)

		Public ReadOnly Property Categories() As ObservableCollection(Of Category)
			Get
				If Me._categories Is Nothing Then
					Me._categories = Me.CreateCategories()
				End If

				Return Me._categories
			End Get
		End Property

		Private Function CreateCategories() As ObservableCollection(Of Category)

			Dim _categories = New ObservableCollection(Of Category)()
			Dim c = New Category()
			c.CategoryID = 1
			c.CategoryName = "Beverages"
			c.Description = "Soft drinks, coffees, teas, beers, and ales"
			_categories.Add(c)
			c = New Category()
			c.CategoryID = 2
			c.CategoryName = "Condiments"
			c.Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
			_categories.Add(c)
			c = New Category()
			c.CategoryID = 3
			c.CategoryName = "Confections"
			c.Description = "Desserts, candies, and sweet breads"
			_categories.Add(c)

			Return _categories
		End Function
	End Class

{{endregion}}

## Setting In-Memory Data as DataSource In {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} Application

You can set the in-memory data as a data source in xaml or in code.

* Using XAML. __Example 2__ shows some sample XAML.

#### __[XAML] Example 2: Setting the data source in xaml__

{{region consuming-data-in-memory-data_2}}

    <Grid>
	  	<Grid.DataContext>
            <local:ViewModel />
        </Grid.DataContext>
        <telerik:RadTreeView x:Name="radTreeView" 
                             ItemsSource="{Binding Categories}" 
                             DisplayMemberPath="CategoryName"/>
    </Grid>
{{endregion}}

*  In code-behind as shown in __Example 3__.

#### __[C#] Example 3: Setting the data source in code__

{{region consuming-data-in-memory-data_3}}
	public MainWindow()
	{
		InitializeComponent();
		this.radTreeView.ItemsSource = new ViewModel().Categories;
	}
{{endregion}}

#### __[VB.NET] Example 3: Setting the data source in code__

{{region consuming-data-in-memory-data_4}}
	Public Sub New()
		InitializeComponent()
		Me.radTreeView.ItemsSource = (New ViewModel()).Categories
	End Sub
{{endregion}}

## See Also

{% if site.site_name == 'Silverlight' %}
 * [DomainDataSource Support]({%slug consuming-data-domain-datasource-support%})
{% endif %}

 * [Using XML]({%slug consuming-data-using-xml%})