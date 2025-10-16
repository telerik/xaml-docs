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

The purpose of this tutorial is to show you how to create in-memory data and use it in the context of your {{ site.framework_name }} application. The following common tasks will be examined:

* Creating in-memory data. 

* Setting it as a data source/data context in {{ site.framework_name }} application.

## Creating In-Memory Data

The following example shows how to setup a basic data model along with a view model.

__Creating in-memory data__  
```C#
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
```
```VB.NET
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

```

## Setting In-Memory Data as DataSource In {{ site.framework_name }} Application

You can set the in-memory data as a data source in xaml or in code.

__Setting the data source in xaml__  
```XAML
    <Grid>
	  	<Grid.DataContext>
            <local:ViewModel />
        </Grid.DataContext>
        <telerik:RadTreeView x:Name="radTreeView" 
                             ItemsSource="{Binding Categories}" 
                             DisplayMemberPath="CategoryName"/>
    </Grid>
```

__Setting the data source in code__  
```C#
	public MainWindow()
	{
		InitializeComponent();
		this.radTreeView.ItemsSource = new ViewModel().Categories;
	}
```
```VB.NET
	Public Sub New()
		InitializeComponent()
		Me.radTreeView.ItemsSource = (New ViewModel()).Categories
	End Sub
```

## See Also  

* [Using XML]({%slug consuming-data-using-xml%})