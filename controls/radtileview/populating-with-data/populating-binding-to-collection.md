---
title: DataBinding
page_title: DataBinding
description: DataBinding
slug: radtileview-populating-with-data-databinding
tags: databinding,binding,data,radtileview
published: True
position: 0
---

# Data Binding

__RadTileView__ can be bound to a collection of objects through its __ItemsSource__ property.

>Note that for the every business object from the data bound collection, __RadTileView__ will generate a __RadTileViewItem__ container representing this object.

This article describes how to data bind business object to __RadTileView__. 

* Create a new class named __CustomerAccount__. The structure of the class is shown in the next code-snippet.

	#### __[C#] Example 1: The business class which will be used as a model of the tileview items__
	{{region radtileview-populating-binding-to-collection_0}}
		public class CustomerAccount
		{
			public string Name { get; set; }
			public string City { get; set; }
			public string Description { get; set; }
		}
	{{endregion}}

	#### __[VB.NET] Example 1: The business class which will be used as a model of the tileview items__
	{{region radtileview-populating-binding-to-collection_1}}
		Public Class CustomerAccount
			Private _Name As String
				Public Property Name() As String
					Get
						Return _Name
					End Get
					Set(ByVal value As String)
						_Name = value
					End Set
				End Property

			Private _City As String
				Public Property City() As Integer
					Get
						Return _City
					End Get
					Set(ByVal value As Integer)
						_City = value
					End Set
				End Property
				
			Private _Description As String
				Public Property Balance() As String
					Get
						Return _Description
					End Get
					Set(ByVal value As String)
						_Description = value
					End Set
				End Property	
		End Class
	{{endregion}}	

* Create a class which defines a collection of business objects:

	#### __[C#] Example 2: The class which holds a collection of the business objects.__
	{{region radtileview-populating-binding-to-collection_2}}
		public class BankViewModel
		{
			public ObservableCollection<CustomerAccount> Customers { get; set; }

			public BankViewModel()
			{
				this.Customers = new ObservableCollection<CustomerAccount>();
				this.AddCustomers();
			}        

			public void AddCustomers()
			{
				this.Customers.Add(new CustomerAccount()
				{
					Name = "Michael Johnson",
					City = "New York",
					Description = "Lorem ipsum dolor sit amet ..."
				});
				this.Customers.Add(new CustomerAccount()
				{
					Name = "Alan Rickman",
					City = "Boston",
					Description = "Lorem ipsum dolor sit amet ..."
				});            
			}
		}
	{{endregion}}
		
	#### __[VB.NET] Example 2: The class which holds a collection of the business objects.__
	{{region radtileview-populating-binding-to-collection_3}}
		Public Class BankViewModel
			Public Property Customers() As ObservableCollection(Of CustomerAccount)
				Get
					Return m_Customers
				End Get
				Set
					m_Customers = Value
				End Set
			End Property
			Private m_Customers As ObservableCollection(Of CustomerAccount)

			Public Sub New()
				Me.Customers = New ObservableCollection(Of CustomerAccount)()
				Me.AddCustomers()
			End Sub

			Public Sub AddCustomers()
				Me.Customers.Add(New CustomerAccount() With { 
					.Name = "Michael Johnson", 
					.City = "New York", 
					.Description = "Lorem ipsum dolor sit amet ..." 
				})
				Me.Customers.Add(New CustomerAccount() With { 
					.Name = "Alan Rickman", 
					.City = "Boston",
					.Description = "Lorem ipsum dolor sit amet ..." 
				})
			End Sub
		End Class
	{{endregion}}

	As you can see the __BankViewModel__ class has a reference to an ObservableCollection of __CustomerAccount__ objects. This collection is populated in the AddCustomers() method and it will be bound to the __ItemsSource__ property of __RadTileView__.

* Set the DataContext of your application to a new instance of the created view model:

	#### __[C#] Example 3: Setting the DataContext of the application.__
	{{region radtileview-populating-binding-to-collection_4}}
		public UserControl()
		{
			InitializeComponent();
			this.DataContext = new BankViewModel();
		}
	{{endregion}}

	#### __[VB.NET] Example 3: Setting the DataContext of the application.__
	{{region radtileview-populating-binding-to-collection_5}}
		Public Sub New()
			InitializeComponent()
			Me.DataContext = New BankViewModel()
		End Sub
	{{endregion}}

* Then bind the __ItemsSource__ property to the collection of the view model:

	#### __[XAML] Example 4: Setting the ItemsSource of the RadTileView control.__
	{{region radtileview-populating-binding-to-collection_6}}
		<telerik:RadTileView x:Name="xTileView" 
						   ItemsSource="{Binding Customers}" />
	{{endregion}}

* The result should be similar to the next image.
			
	#### __Figure 1: RadTileView after binding its ItemSource property__	
	![](images/RadTileView_Populating_BindingToCollection_010.PNG)

You will notice that the __RadTileViewitems__ display the name of the view model. This is because by default the RadTileView will display the result returned from the ToString() method of the model. To change the appearance of the items you can define explicitly what to be displayed in the header and the content of the items. You can see how to do that in the next section.

## Using custom templates
 
This section describes how to define the appearance of the RadTileViewItems' header and content.

The visual appearance of the item's header can be modified using two approaches:
	
* Using the __ItemTemplate__ property

	Create a __DataTemplate__ and set it to the __RadTileView__'s __ItemTemplate__ property. 
 
	#### __[XAML] Example 5: Declaring the DataTemplate__
	{{region radtileview-populating-binding-to-collection_7}}
		<DataTemplate x:Key="ItemTemplate">
				<TextBlock Text="{Binding Name}" />
		</DataTemplate>
	{{endregion}}

	Update the __RadTileView__'s declaration and set its __ItemTemplate__ property like in the example below:
 
	#### __[XAML] Example 6: Declaring the DataTemplate__
	{{region radtileview-populating-binding-to-collection_8}}
		<telerik:RadTileView x:Name="xTileView" 
						   ItemsSource="{Binding Customers}"
						   ItemTemplate="{Binding ItemTemplate}"/>
	{{endregion}}
	  
* Using the __DisplayMemberPath__ property	
	
	Instead of creating a custom __ItemTemplate__, you can use the __DisplayMemberPath__ property. Its purpose is to get or set a path to a value on the source object to serve as the visual representation of the object.

	__Example 7__ demonstrates how to set the __DisplayMemberPath__ property.		
	  
	#### __[XAML] Example 7: Setting the DisplayMemberPath__
	{{region radtileview-populating-binding-to-collection_9}}
		<telerik:RadTileView x:Name="xTileView" 
							 DisplayMemberPath="Name"
							 ItemsSource="{Binding Customers}"/>
	{{endregion}}	
  
The end result is demonstrated in Figure 2.

#### __Figure 2: RadTileView after using DisplayMemberPath property.__
![](images/RadTileView_Populating_BindingToCollection_020.png)

The visual appearance of the item's content can be modified using the __ContentTemplate__ property of RadTileView.

#### __[XAML] Example 8: Declaring the content DataTemplate__
{{region radtileview-populating-binding-to-collection_10}}
	<DataTemplate x:Key="ContentTemplate">
		<StackPanel>
			<TextBlock Text="{Binding City,StringFormat='City: {0}'}"/>
			<TextBlock Text="{Binding Description,StringFormat='Decription: {0}'}" TextWrapping="Wrap"/>
		</StackPanel>
	</DataTemplate>
{{endregion}}

Update your __RadTileView__'s declaration and set its __ContentTemplate__ property like in the example below:

#### __[XAML] Example 9: Declaring the content DataTemplate__
{{region radtileview-populating-binding-to-collection_11}}
	<telerik:RadTileView ItemsSource="{Binding Customers}"
                         DisplayMemberPath="Name"
                         ContentTemplate="{StaticResource ContentTemplate}"/>
{{endregion}}

The final result is shown on the next image:

#### __Figure 3: Final result__
![](images/RadTileView_Populating_BindingToCollection_030.png)

>tip You can download a runnable project of the demonstrated example from our online [SDK repository](https://github.com/telerik/xaml-sdk), after navigating to __TileView/DataBinding__.

## See Also
 * [Getting Started]({%slug radtileview-getting-started%})
 * [Visual Structure]({%slug radtileview-visual-structure%})