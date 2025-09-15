---
title: MVVM Support
page_title: MVVM Support
description: Check our &quot;MVVM Support&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-mvvm
tags: mvvm,support
published: True
position: 4
---

# MVVM Support

The assembly in which __RadDataServiceDataSource__ is located contains a class named __QueryableDataServiceCollectionView&lt;T&gt;.__ This is the collection view that the control uses internally. The only functionality that the control adds over this collection view is XAML-friendly API.

In case you are strictly following the __MVVM pattern__ and you cannot embed an UI control inside your view model, you can use the __QueryableDataServiceCollectionView&lt;T&gt;__ class. Like __RadDataServiceDataSource__, the __QueryableDataServiceCollectionView&lt;T&gt;__ needs a __DataServiceContext__ and a __DataServiceQuery&lt;T&gt;__ to be constructed.

>The examples in this article are based on the setup from the [Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%}) and [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%}) article.

The __QueryableDataServiceCollectionView&lt;T&gt;__ class has the same API as the __RadDataServiceDataSource__ control so all operations are performed in the same way as with RadDataServiceDataSource. In fact, the public API of the control simply exposes the public API of its inner collection view, which is the one that really does the job.

**Example 1** demonstrates how to set up your viewmodel to use the QueryableDataServiceCollectionView class.

__Example 1: Creating the viewmodel class__

```C#

	public class MainViewModel : ViewModelBase
    {
        private MyNorthwindContext ordersContext;
        private DataServiceQuery<Order> ordersQuery;
		private QueryableDataServiceCollectionView<Order> ordersView;

		public MainViewModel()
		{
			this.ordersContext = new MyNorthwindContext();
			this.ordersQuery = ordersContext.Orders;
			this.ordersView = new QueryableDataServiceCollectionView<Order>(this.ordersContext, this.ordersQuery);
			this.ordersView.AutoLoad = true;
		}

        public QueryableDataServiceCollectionView<Order> OrdersView
		{
            get { return this.ordersView; }
            set 
			{
				if (this.ordersView != value)
				{
					this.ordersView = value;
					this.OnPropertyChanged("OrdersView");
				}
			}
        }
    }
```
```VB.NET

	Public Class MainViewModel
		Inherits ViewModelBase

		Private northwindContext As MyNorthwindContext
		Private ordersQuery As DataServiceQuery(Of Order)
		Private _ordersView As QueryableDataServiceCollectionView(Of Order)

		Public Sub New()
			Me.northwindContext = New MyNorthwindContext()
			Me.ordersQuery = northwindContext.Orders
			Me._ordersView = New QueryableDataServiceCollectionView(Of Order)(Me.northwindContext, Me.ordersQuery)
			Me._ordersView.AutoLoad = True
		End Sub

		Public Property OrdersView() As QueryableDataServiceCollectionView(Of Order)
			Get
				Return Me._ordersView
			End Get
			Set(ByVal value As QueryableDataServiceCollectionView(Of Order))
				If Me._ordersView <> value Then
					Me._ordersView = value
					Me.OnPropertyChanged("OrdersView")
				End If
			End Set
		End Property
	End Class
```

You can then set up your data controls in the same way you would if you were using the RadDataServiceDataSource control.

__Example 2: Binding the data controls__

```XAML
	
	<UserControl>
		<UserControl.DataContext>
			<local:MainViewModel />
		</UserControl.DataContext>
		<Grid>
			<Grid.RowDefinitions>
				<RowDefinition Height="*"/>
				<RowDefinition Height="Auto"/>
			</Grid.RowDefinitions>
			<telerik:RadGridView Grid.Row="0" ItemsSource="{Binding OrdersView}" IsReadOnly="True" IsBusy="{Binding OrdersView.IsBusy}" ShowGroupPanel="False"/>
			<telerik:RadDataPager Grid.Row="1" Source="{Binding OrdersView}" PageSize="20" />
		</Grid>
	</UserControl>
```

## See Also
* [ViewModelBase class]({%slug common-viewmodelbase-class%})
* [Creating the Client Application]({%slug raddataservicedatasource-getting-started-creating-the-client-application%})
* [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
