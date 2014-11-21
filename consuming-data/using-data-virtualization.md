---
title: Using Data Virtualization
page_title: Using Data Virtualization
description: Using Data Virtualization
slug: using-data-virtualization
tags: using,data,virtualization
published: True
position: 11
---

# Using Data Virtualization



## 

As the case of handling a lot of data is quite common, the requirement for fast data processing becomes more and more indispensable.  The result of this necessity is the __Data Virtualization__ technique that ensures much better performance as well as user experience improvements.
When working with the UI components that enable UI virtualization, you may take advantage of the above mentioned technique by using __VirtualQueryableCollectionView__ class. It enables you to benefit from the on-demand data loading to smooth scrolling with UI virtual components.
The __VirtualQueryableCollectionView__ provides you with the following important members:

* __LoadSize__ property - defines the maximum number of items requested at once;
            

* __VirtualItemCount__ property – defines the total number of items available on the server-side;
            

* __ItemsLoading__ event – will be raised when the collection is requesting item at some index and this item is not already loaded. The arguments in this event are as follows:
             

* __StartIndex__ – requested item index;
                

* __ItemCount__ - number of requested items (can be less than or equal to the LoadSize).
                {% if site.site_name == 'WPF' %}

When using __VirtualQueryableCollectionView__ for WPF, you may easily benefit from the built-in sorting, grouping, filtering, etc. functionality if you provide IQueryable as source and just set LoadSize property to desired value. For example:

#### __C#__

{{region using-data-virtualization_0}}
	public MainWindow()
    {
        InitializeComponent();
        var context = new NorthwindEntities();
        var query = context.Order_Details.OrderBy(o => o.OrderID);
        var view = new VirtualQueryableCollectionView(query) { LoadSize = 10 };
        DataContext = view;
    }
	{{endregion}}



#### __VB.NET__

{{region using-data-virtualization_1}}
	Public Sub New()
	 InitializeComponent()
	 Dim context = New NorthwindEntities()
	 Dim query = context.Order_Details.OrderBy(Function(o) o.OrderID)
	 Dim view = New VirtualQueryableCollectionView(query) With { _
	  Key .LoadSize = 10 _
	 }
	 DataContext = view
	End Sub
	{{endregion}}



In the example above Entity Framework is used. However, you may use Linq to SQL, OpenAccess or any other Linq provider in the same manner.{% endif %}{% if site.site_name == 'Silverlight' %}

In order to utilize the VirtualQueryableCollectionView class, you may take the following approach (the example below demonstrates the case when utilizing WCF RIA Services):

#### __C#__

{{region using-data-virtualization_3}}
	public MainPage()
    {
        InitializeComponent();
        var context = new NorthwindDomainContext();
        var query = context.GetOrder_DetailsQuery().OrderBy(o => o.OrderID);
        query.IncludeTotalCount = true;
        var view = new VirtualQueryableCollectionView() { LoadSize = 10, VirtualItemCount = 100 };
        view.ItemsLoading += (s, e) =>
        {
            context.Load<Order_Detail>(query.Skip(e.StartIndex).Take(e.ItemCount)).Completed += (sender, args) =>
           {
               var lo = (LoadOperation)sender;
               if (lo.TotalEntityCount != -1 && lo.TotalEntityCount != view.VirtualItemCount)
               {
                   view.VirtualItemCount = lo.TotalEntityCount;
               }
               view.Load(e.StartIndex, lo.Entities);
           };
        };
        DataContext = view;
    }
	{{endregion}}



#### __VB.NET__

{{region using-data-virtualization_4}}
	Public Sub New()
	 InitializeComponent()
	 Dim context = New NorthwindDomainContext()
	 Dim query = context.GetOrder_DetailsQuery().OrderBy(Function(o) o.OrderID)
	 query.IncludeTotalCount = True
	 Dim view = New VirtualQueryableCollectionView() With { _
	  Key .LoadSize = 10, _
	  Key .VirtualItemCount = 100 _
	 }
	 view.ItemsLoading += Function(s, e)
	 context.Load(Of Order_Detail)(query.Skip(e.StartIndex).Take(e.ItemCount)).Completed += Function(sender, args)
	 Dim lo = DirectCast(sender, LoadOperation)
	 If lo.TotalEntityCount <> -1 AndAlso lo.TotalEntityCount <> view.VirtualItemCount Then
	  view.VirtualItemCount = lo.TotalEntityCount
	 End If
	 view.Load(e.StartIndex, lo.Entities)
	End Function
	End Function
	 DataContext = view
	End Sub
	{{endregion}}

{% endif %}

#### __XAML__

{{region using-data-virtualization_5}}
	<telerik:RadGridView ItemsSource="{Binding}" />
	{{endregion}}



__ItemsLoading__ event will be raised if you try to access some item by index and this item is not yet loaded. When you scroll down the ItemsLoading event will be called and empty (null) items in the collection will be replaced with the new items. When an item is already loaded the collection will not call ItemsLoading event for this item.
        

>When you provide IQueryable in the VirtualQueryableCollectionView you do not need to handle the ItemsLoading event.

>__Filtering__ on Distinct Values is not fully supported when using the VirtualQueryableCollectionView. We suggest configuring GridViewDataColumn with __ShowDistinctFilters="False"__. That way only filtering through the Field Filters will be enabled. You can check the [basic filtering]({%slug gridview-filtering-basic%}) section as a reference on the filtering support. There you can also find more information on how to filter through the __Field Filters__.
          

>When the ScrollMode is Deferred, then a __ScrollPositionIndicator__ will be shown as the user scrolls vertically. Its content will be an empty value until the user releases the scrollbar to a particular position so that the items to be displayed into view are actually loaded. In order to avoid this, you could permanently __hide the indicator__ defining a Style for this visual element setting its Opacity to 0.
          

>__Add/insert scenario__ cannot be supported with VirtualQueryableCollectionView. The reason is that it cannot maintain cache of already loaded items.
          

>Currently supported Telerik controls are __RadGridView__, __RadComboBox__, __RadTreeView__, __RadBook__ and __RadCoverFlow__.

# See Also

 * [Using Data Virtualization with RadGridView]({%slug gridview-populating-datavirtualization%})
