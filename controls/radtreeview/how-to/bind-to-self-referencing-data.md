---
title: Bind RadTreeView to Self-Referencing Data
page_title: Bind RadTreeView to Self-Referencing Data
description: Bind RadTreeView to Self-Referencing Data
slug: radtreeview-how-to-bind-to-self-referencing-data
tags: bind,radtreeview,to,self-referencing,data
published: True
position: 16
---

# Bind RadTreeView to Self-Referencing Data



## 

This tutorial will show you how to display in a __RadTreeView__ flat, self-referencing data, loaded from a database, that has properties __ID__and __ParentID__(or similar) which define the hierarchy. 

Consider the following very simple data object:

#### __C#__

{{region radtreeview-how-to-bind-to-self-referencing-data_0}}
	public class DataItem
	{
	    public int Id
	    {
	        get;
	        set;
	    }
	    public int ParentId
	    {
	        get;
	        set;
	    }
	    public string Text
	    {
	        get;
	        set;
	    }
	    public DataItemCollection Owner
	    {
	        get;
	        protected set;
	    }
	    internal void SetOwner( DataItemCollection collection )
	    {
	        this.Owner = collection;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeview-how-to-bind-to-self-referencing-data_1}}
	Public Class DataItem
	Private _Id As Integer
	    Public Property Id() As Integer
	        Get
	            Return _Id
	        End Get
	        Set(ByVal value As Integer)
	            _Id = value
	        End Set
			End Property
	
			Private _ParentId As Integer
			Public Property ParentId() As Integer
				Get
					Return _ParentId
				End Get
				Set(ByVal value As Integer)
					_ParentId = value
				End Set
			End Property
	
			Private _Text As String
			Public Property Text() As String
				Get
					Return _Text
				End Get
				Set(ByVal value As String)
					_Text = value
				End Set
			End Property
	
			Private _Owner As DataItemCollection
			Public Property Owner() As DataItemCollection
				Get
					Return _Owner
				End Get
				Protected Set(ByVal value As DataItemCollection)
					_Owner = value
				End Set
			End Property
	
			Friend Sub SetOwner(ByVal collection As DataItemCollection)
				Me.Owner = collection
			End Sub
		End Class
	{{endregion}}



Those data objects are added into a special __DataItemCollection__ class, that inherits __ObservableCollection<T>__ and overrides __SetItem(), InsertItem(), RemoveItem()__ and __ClearItems()__ methods. In each override we call __AdoptItem()__ and __DiscardItem()__, respectively, which set the __Owner__ property of the __DataItem__ class: 

#### __C#__

{{region radtreeview-how-to-bind-to-self-referencing-data_2}}
	public class DataItemCollection : ObservableCollection<DataItem>
	{
	    protected override void InsertItem( int index, DataItem item )
	    {
	        this.AdoptItem( item );
	        base.InsertItem( index, item );
	    }
	    protected override void RemoveItem( int index )
	    {
	        this.DiscardItem( this[ index ] );
	        base.RemoveItem( index );
	    }
	    protected override void SetItem( int index, DataItem item )
	    {
	        this.AdoptItem( item );
	        base.SetItem( index, item );
	    }
	    protected override void ClearItems()
	    {
	        foreach ( DataItem item in this )
	        {
	            this.DiscardItem( item );
	        }
	        base.ClearItems();
	    }
	    private void AdoptItem( DataItem item )
	    {
	        item.SetOwner( this );
	    }
	    private void DiscardItem( DataItem item )
	    {
	        item.SetOwner( null );
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeview-how-to-bind-to-self-referencing-data_3}}
		Public Class DataItemCollection
			Inherits ObservableCollection(Of DataItem)
			Protected Overloads Overrides Sub InsertItem(ByVal index As Integer, ByVal item As DataItem)
				Me.AdoptItem(item)
				MyBase.InsertItem(index, item)
			End Sub
	
			Protected Overloads Overrides Sub RemoveItem(ByVal index As Integer)
				Me.DiscardItem(Me(index))
				MyBase.RemoveItem(index)
			End Sub
	
			Protected Overloads Overrides Sub SetItem(ByVal index As Integer, ByVal item As DataItem)
				Me.AdoptItem(item)
				MyBase.SetItem(index, item)
			End Sub
	
			Protected Overloads Overrides Sub ClearItems()
				For Each item As DataItem In Me
					Me.DiscardItem(item)
				Next
				MyBase.ClearItems()
			End Sub
	
			Private Sub AdoptItem(ByVal item As DataItem)
				item.SetOwner(Me)
			End Sub
	
			Private Sub DiscardItem(ByVal item As DataItem)
				item.SetOwner(Nothing)
			End Sub
		End Class
	{{endregion}}



Normally when you load your data objects from a service in your application, you will have auto-generated partial classes, that are relatively easy to extend. 

Now we are ready to data-bind our __RadTreeView__:
{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radtreeview-how-to-bind-to-self-referencing-data_4}}
	<example:HierarchyConverter x:Key="HierarchyConverter" />
	
	<telerik:HierarchicalDataTemplate x:Key="ItemTemplate"
	  ItemsSource="{Binding Converter={StaticResource HierarchyConverter}}">
	    <TextBlock Text="{Binding Text}" />
	</telerik:HierarchicalDataTemplate>
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radtreeview-how-to-bind-to-self-referencing-data_466}}
	<example:HierarchyConverter x:Key="HierarchyConverter" />
	
	<HierarchicalDataTemplate x:Key="ItemTemplate"
	  ItemsSource="{Binding Converter={StaticResource HierarchyConverter}}">
	    <TextBlock Text="{Binding Text}" />
	</HierarchicalDataTemplate>
	{{endregion}}

{% endif %}

#### __XAML__

{{region radtreeview-how-to-bind-to-self-referencing-data_5}}
	<telerik:RadTreeView x:Name="radTreeView"
	 ItemTemplate="{StaticResource ItemTemplate}"
	 ItemsSource="{Binding Converter={StaticResource HierarchyConverter}}"/>
	{{endregion}}



There is one non-standard thing: all __ItemsSource__bindings are made through a
        __ValueConverter__. This __ValueConverter__will create the "real" hierarchy for us: 

#### __C#__

{{region radtreeview-how-to-bind-to-self-referencing-data_6}}
	public class HierarchyConverter : IValueConverter
	{
	    public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
	    {
	        // We are binding an item
	        DataItem item = value as DataItem;
	        if ( item != null )
	        {
	            return item.Owner.Where( i => i.ParentId == item.Id );
	        }
	        // We are binding the treeview
	        DataItemCollection items = value as DataItemCollection;
	        if ( items != null )
	        {
	            return items.Where( i => i.ParentId == 0 );
	        }
	        return null;
	    }
	    public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
	    {
	        throw new NotImplementedException();
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeview-how-to-bind-to-self-referencing-data_7}}
		Public Class HierarchyConverter
			Implements IValueConverter
	
			Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
				' We are binding an item
				Dim item As DataItem = TryCast(value, DataItem)
				If item IsNot Nothing Then
					Return item.Owner.Where(Function(i) i.ParentId = item.Id)
				End If
	
				' We are binding the treeview
				Dim items As DataItemCollection = TryCast(value, DataItemCollection)
				If items IsNot Nothing Then
					Return items.Where(Function(i) i.ParentId = 0)
				End If
	
				Return Nothing
			End Function
	
			Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
				Throw New NotImplementedException()
			End Function
	
		End Class
	{{endregion}}



When a __DataItem__object is passed as value, we are binding a __TreeViewItem__, so the __Convert()__method will return all __DataItem__objects from the __Owner__collection that have __ParentID__equal to the __ID__of the passed __DataItem__. When a __DataItemCollection__is passed, we are binding the __RadTreeView__, so the __Convert()__method will return the root-level __DataItem__objects, that have __ParentID=0__. Of course, it is up to you to decide whether you want a single, or separate converters for both of the cases. I did it in this way for simplicity, but if you want, you could split the code into two classes.

Finally, let's populate the treeview with some data: 

#### __C#__

{{region radtreeview-how-to-bind-to-self-referencing-data_8}}
	this.DataContext = new DataItemCollection()
	{
	 new DataItem () { Text = "Item 1", Id = 1, ParentId = 0 },
	 new DataItem () { Text = "Item 2", Id = 2, ParentId = 0 },
	 new DataItem () { Text = "Item 3", Id = 3, ParentId = 0 },
	 new DataItem () { Text = "Item 1.1", Id = 5, ParentId = 1 },
	 new DataItem () { Text = "Item 1.2", Id = 6, ParentId = 1 },
	 new DataItem () { Text = "Item 1.3", Id = 7, ParentId = 1 },
	 new DataItem () { Text = "Item 2.1", Id = 8, ParentId = 2 },
	 new DataItem () { Text = "Item 2.2", Id = 9, ParentId = 2 },
	 new DataItem () { Text = "Item 2.3", Id = 10, ParentId = 2 },
	 new DataItem () { Text = "Item 3.1", Id = 11, ParentId = 3 },
	 new DataItem () { Text = "Item 3.2", Id = 12, ParentId = 3 },
	 new DataItem () { Text = "Item 3.3", Id = 13, ParentId = 3 }
	};
	{{endregion}}



#### __VB.NET__

{{region radtreeview-how-to-bind-to-self-referencing-data_9}}
	Me.DataContext = New DataItemCollection() From { 
		New DataItem () With {.Text = "Item 1", .Id = 1, .ParentId = 0}, 
		New DataItem () With {.Text = "Item 2", .Id = 2, .ParentId = 0}, 
		New DataItem () With {.Text = "Item 3", .Id = 3, .ParentId = 0}, 
		New DataItem () With {.Text = "Item 1.1", .Id = 5, .ParentId = 1}, 
		New DataItem () With {.Text = "Item 1.2", .Id = 6, .ParentId = 1}, 
		New DataItem () With {.Text = "Item 1.3", .Id = 7, .ParentId = 1}, 
		New DataItem () With {.Text = "Item 2.1", .Id = 8, .ParentId = 2}, 
		New DataItem () With {.Text = "Item 2.2", .Id = 9, .ParentId = 2}, 
		New DataItem () With {.Text = "Item 2.3", .Id = 10, .ParentId = 2}, 
		New DataItem () With {.Text = "Item 3.1", .Id = 11, .ParentId = 3}, 
		New DataItem () With {.Text = "Item 3.2", .Id = 12, .ParentId = 3}, 
		New DataItem () With {.Text = "Item 3.3", .Id = 13, .ParentId = 3} 
													}
	{{endregion}}



Here is the result: 

![](images/RadTreeView_HowToBindToSelfReferencingData_010.PNG)

# See Also

 * [Bind RadTreeView to Hierarchical Data and Use ContainerBindingCollection]({%slug radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection%})

 * [Enable the Horizontal and Vertical Scrollbars]({%slug radtreeview-how-to-enable-horizontal-vertical-scrollbar%})

 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
