---
title: Hierarchical Data Templates
page_title: Hierarchical Data Templates
description: Hierarchical Data Templates
slug: radtreeview-populating-with-data-hierarchical-data-templates
tags: hierarchical,data,templates
publish: True
position: 13
---

# Hierarchical Data Templates



## 

__RadTreeViewItem__inherits from __HeaderedItemsControl__and they can display hierarchical data, e.g. collections that contain other collections.

The __HierarchicalDataTemplate__ class is designed to be used with __HeaderedItemsControl__ types to display such data. There should be virtually no differences between the usage of __HierarchicalDataTemplate__ in __RadTreeView__ and other controls.

The following example demonstrates how to create a hierarchical data source and bind a __RadTreeView__to it, using a __HierarchicalDataTemplate__. The __ItemsSource__property of the __HierarchicalDataTemplate__specifies the __binding__that has to be applied to the __ItemsSource__property of each item. The __DataTemplate__property specifies the template that has to be applied on each item, while the __ItemTemplate__is the template applied on its child items. You can nest several __HierarchicalDataTemplate__declarations if you need a deeper level of hierarchy. 

>tipIf you have a __databound control__, then you must consider the following rules.The __ItemsControl__prepares its children in a very different way, depending on the type of the __child__:

* If it is a __ContentControl__, the __ItemTemplate__ will be set as a __ContentTemplate__ and the non-visual element as content. 


* If it is a __HeaderedControl__, the __ItemTemplate__ will be set as a __HeaderTemplate__ and the data item as a Header. 


* If it is a __HeaderedContentControl__(i.e. the two above combined), the item will go as __Content__, but the __ContentTemplate__ won't be set. Instead, the item will be set as a __Header__ and the __ItemTemplate__ will be used as a __HeaderTemplate__.If the item is an __ItemsControl__, these properties are set to the child items as well, what is called "inherited": __ItemTemplate__, __ItemTemplateSelector__, __ItemContainerStyle__, __ItemContainerStyleSelector__{% if site.site_name == 'WPF' %}, __DisplayMemberPath__{% endif %}{% if site.site_name == 'Silverlight' %}, __ItemStringFormat__, __AnimationManager__.__IsAnimationEnabled__{% endif %}.In the case of the __RadTreeView__, the tree items are __HeaderedItemsControl__, which means that the above properties will be passed along to all the items, and there is no need to set the __ItemTemplate__ property of the __HierarchicalDataTemplate__, especially if there is a selector.The __ItemContainerStyle__ will be set as a style for the containers, if there is none and an __ItemContainerStyleSelector__ is present, a style will be selected. Then the __ItemContainerStyle__(Selector) properties will be passed along ig the container is an __ItemsControl__.The above rules can "mix" with the properties set in the __HierarchicalDataTemplate__ to create even more combinations of ways to set the templates of items. The __HeaderTemplate__ displayed for an item can be a result of one of the following:

* Directly (locally) set __HeaderTemplate__. 


* Directly (locally) set __HeaderTemplateSelector__. 


* __ItemTemplate__ of the parent __ItemsControl__. 


* __ItemTemplateSelector__ of the parent __ItemsControl__. 


* __ItemContainerStyle__ with a __HeaderTemplate__ of the parent __ItemsControl__. 


* __ItemContainerStyleSelector__ which selects a style with a __HeaderTemplate__. 


* __ItemContainerStyle__ with a __HeaderTemplateSelector__ of the parent __ItemsControl__. 


* __ItemContainerStyleSelector__ which selects a style with a __HeaderTemplateSelector__. 


* An __ItemTemplate__ set in the __HierarchicalDataTemplate__ of the parent. 


* An __ItemTemplateSelector__ set in the __HierarchicalDataTemplate__ of the parent. 


* An __ItemContainerStyle__ set in the __HierarchicalDataTemplate__ of the parent, which sets a __HeaderTemplate__. 


* An __ItemContainerStyleSelector__ set in the __HierarchicalDataTemplate__ of the parent, which selects a style that sets a __HeaderTemplate__. 


* In WPF you have the DataType property of the __DataTemplate__ which will be a last fallback if a template is not set at all.

>tipThe {% if site.site_name == 'Silverlight' %}Telerik {% endif %}__HierarchicalDataTemplate__ offers two properties - __ItemContainerStyle__and __ItemContainerStyleSelector__, which allows you to make your hierarchy quite flexible.An interesting point here is the precedence over what should be set. As always, local values are stronger than styles. But what happens when you have both an __ItemContainerStyle__ set in the __ItemsControl__ and the __HierarchicalDataTemplate__. Also what happens when you have an __ItemContainerStyle__ set in the two above __and__in the __ItemContainerStyle__ as well. The rule is that the __ItemContainerStyle__ from the __HierarchicalDataTemplate__ is applied to the first level of containers that has a style which is the same as the parent's. The last __ItemContainerStyle__ to be actively set is inherited from them on. The same rule applies for selectors.For more information see the example below.

* Create a new class and name it __MyViewModel__, which implements the __INotifyPropertyChanged__interface.

#### __C#__

{{region radtreeview-populating-with-data-hierarchical-data-templates_0}}
	public class MyViewModel : INotifyPropertyChanged
	{
	    private String title;
	    private DateTime dateCreated;
	    private double price;
	    public MyViewModel()
	    {
	        RelatedItems = new ObservableCollection<object>();
	    }
	    public double Price
	    {
	        get
	        {
	            return this.price;
	        }
	        set
	        {
	            if ( this.Price == value )
	                return;
	            this.price = value;
	            OnPropertyChanged( "Price" );
	        }
	    }
	    public DateTime DateCreated
	    {
	        get
	        {
	            return this.dateCreated;
	        }
	        set
	        {
	            if ( this.DateCreated == value )
	                return;
	            this.dateCreated = value;
	            OnPropertyChanged( "DateCreated" );
	        }
	    }
	    public String Title
	    {
	        get
	        {
	            return this.title;
	        }
	        set
	        {
	            if ( this.Title == value )
	                return;
	            this.title = value;
	            OnPropertyChanged( "Title" );
	        }
	    }
	    public IList<object> RelatedItems
	    {
	        get;
	        set;
	    }
	    public event PropertyChangedEventHandler PropertyChanged;
	    protected virtual void OnPropertyChanged( string info )
	    {
	        PropertyChangedEventHandler temp = this.PropertyChanged;
	        if ( temp != null )
	            temp( this, new PropertyChangedEventArgs( info ) );
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeview-populating-with-data-hierarchical-data-templates_1}}
	Public Class MyViewModel
	    Implements INotifyPropertyChanged
	    Private m_title As [String]
	    Private m_dateCreated As DateTime
	    Private m_price As Double
	
	    Public Sub New()
	        RelatedItems = New ObservableCollection(Of Object)()
	    End Sub
	
	    Public Property Price() As Double
	        Get
	            Return Me.m_price
	        End Get
	        Set(ByVal value As Double)
	            If Me.Price = value Then
	                Return
	            End If
	
	            Me.m_price = value
	            OnPropertyChanged("Price")
	        End Set
	    End Property
	
	    Public Property DateCreated() As DateTime
	        Get
	            Return Me.m_dateCreated
	        End Get
	        Set(ByVal value As DateTime)
	            If Me.DateCreated = value Then
	                Return
	            End If
	
	            Me.m_dateCreated = value
	            OnPropertyChanged("DateCreated")
	        End Set
	    End Property
	
	    Public Property Title() As [String]
	        Get
	            Return Me.m_title
	        End Get
	        Set(ByVal value As [String])
	            If Me.Title = value Then
	                Return
	            End If
	
	            Me.m_title = value
	            OnPropertyChanged("Title")
	        End Set
	    End Property
	
	Private _RelatedItems As IList(Of Object)
	    Public Property RelatedItems() As IList(Of Object)
	        Get
	            Return _RelatedItems
	        End Get
	        Set(ByVal value As IList(Of Object))
	            _RelatedItems = value
	        End Set
	    End Property
	
	    Public Event PropertyChanged As PropertyChangedEventHandler
	
	    Protected Overridable Sub OnPropertyChanged(ByVal info As String)
	        Dim temp As PropertyChangedEventHandler = Me.PropertyChanged
	        RaiseEvent temp(Me, New PropertyChangedEventArgs(info))
	    End Sub
	End Class
	{{endregion}}



The class has four properties:

* Property __Price__ which is of type double. 


* Property __CreatedOn__ which is of type DateTime. 


* Property __Title__ which is of type string. 


* Property __RelatedItems__ which is a collection of objects. These are the child items.

Add a static method to the class which aims to create some mock-up data:

#### __C#__

{{region radtreeview-populating-with-data-hierarchical-data-templates_2}}
	public static IList<object> GetItems( string name )
	{
	    var result = new ObservableCollection<object>();
	    foreach ( var num in Enumerable.Range( 1, 5 ) )
	    {
	        var item = new MyViewModel();
	        item.DateCreated = DateTime.Today.AddDays( -num % 15 );
	        item.Price = num * 100 + Convert.ToDouble( num ) / 100;
	        item.Title = String.Format( "{0} {1}", name, num );
	        for ( int i = 0; i < 5; i++ )
	        {
	            var child = new MyViewModel();
	            child.DateCreated = DateTime.Today.AddDays( -num % 5 - i );
	            child.Price = num * 100 + Convert.ToDouble( num + i ) / 100;
	            child.Title = String.Format( "{0} {1}'s {2}", name, num, i );
	            item.RelatedItems.Add( child );
	            for ( int j = 0; j < 3; j++ )
	            {
	                var grandChild = new MyViewModel();
	                grandChild.DateCreated = DateTime.Today.AddDays( -num % 5 - i + 2 );
	                grandChild.Price = num * 100 + Convert.ToDouble( num + i ) / 100;
	                grandChild.Title = String.Format( "{0} {1} : {2}'s {3}", name, num, i, j );
	                child.RelatedItems.Add( grandChild );
	            }
	        }
	        result.Add( item );
	    }
	    return result;
	}
	{{endregion}}



#### __VB.NET__

{{region radtreeview-populating-with-data-hierarchical-data-templates_3}}
	Public Shared Function GetItems(ByVal name As String) As IList(Of Object)
	    Dim result = New ObservableCollection(Of Object)()
	    For Each num In Enumerable.Range(1, 5)
	        Dim item = New MyViewModel()
	        item.DateCreated = DateTime.Today.AddDays(-num Mod 15)
	        item.Price = num * 100 + Convert.ToDouble(num) / 100
	        item.Title = [String].Format("{0} {1}", name, num)
	
	        For i As Integer = 0 To 4
	            Dim child = New MyViewModel()
	            child.DateCreated = DateTime.Today.AddDays(-num Mod 5 - i)
	            child.Price = num * 100 + Convert.ToDouble(num + i) / 100
	            child.Title = [String].Format("{0} {1}'s {2}", name, num, i)
	
	            item.RelatedItems.Add(child)
	
	            For j As Integer = 0 To 2
	                Dim grandChild = New MyViewModel()
	                grandChild.DateCreated = DateTime.Today.AddDays(-num Mod 5 - i + 2)
	                grandChild.Price = num * 100 + Convert.ToDouble(num + i) / 100
	                grandChild.Title = [String].Format("{0} {1} : {2}'s {3}", name, num, i, j)
	
	                child.RelatedItems.Add(grandChild)
	            Next
	        Next
	
	        result.Add(item)
	    Next
	    Return result
	End Function
	{{endregion}}



Now consider both of the background notes at the beginning of the topic and take a look at the following code snippet. It declares a __HierarchicalDataTemplate__ and uses the __ItemContainerStyle__ property of both the __RadTreeView__ and the __HierarchicalDataTemplate__.{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radtreeview-populating-with-data-hierarchical-data-templates_4}}
	<UserControl.Resources>
	
	    <Style TargetType="telerik:RadTreeViewItem" x:Key="redStyle">
	        <Setter Property="Background" Value="Red" />
	        <Setter Property="ItemContainerStyle">
	            <Setter.Value>
	                <Style TargetType="telerik:RadTreeViewItem">
	                    <Setter Property="Background" Value="Orange" />
	                </Style>
	            </Setter.Value>
	        </Setter>
	    </Style>
	
	    <Style TargetType="telerik:RadTreeViewItem" x:Key="greenStyle">
	        <Setter Property="Background" Value="Green" />
	    </Style>
	
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Background="White">
	
	    <telerik:RadTreeView x:Name="radTreeView" Margin="8"
	        ItemContainerStyle="{StaticResource redStyle}">
	        <telerik:RadTreeView.ItemTemplate>
	
	            <telerik:HierarchicalDataTemplate ItemsSource="{Binding RelatedItems}"
	     ItemContainerStyle="{StaticResource greenStyle}">
	                <TextBlock Text="{Binding Title}" />
	            </telerik:HierarchicalDataTemplate>
	
	        </telerik:RadTreeView.ItemTemplate>
	    </telerik:RadTreeView>
	
	</Grid>
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radtreeview-populating-with-data-hierarchical-data-templates_7}}
	<UserControl.Resources>
	
	    <Style TargetType="telerik:RadTreeViewItem" x:Key="redStyle">
	        <Setter Property="Background" Value="Red" />
	        <Setter Property="ItemContainerStyle">
	            <Setter.Value>
	                <Style TargetType="telerik:RadTreeViewItem">
	                    <Setter Property="Background" Value="Orange" />
	                </Style>
	            </Setter.Value>
	        </Setter>
	    </Style>
	
	    <Style TargetType="telerik:RadTreeViewItem" x:Key="greenStyle">
	        <Setter Property="Background" Value="Green" />
	    </Style>
	
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Background="White">
	
	    <telerik:RadTreeView x:Name="radTreeView" Margin="8"
	        ItemContainerStyle="{StaticResource redStyle}">
	        <telerik:RadTreeView.ItemTemplate>
	
	            <HierarchicalDataTemplate ItemsSource="{Binding RelatedItems}"
	     ItemContainerStyle="{StaticResource greenStyle}">
	                <TextBlock Text="{Binding Title}" />
	            </HierarchicalDataTemplate>
	
	        </telerik:RadTreeView.ItemTemplate>
	    </telerik:RadTreeView>
	
	</Grid>
	{{endregion}}

{% endif %}

Set the __ItemsSource__ property of the __RadTreeView__.

#### __C#__

{{region radtreeview-populating-with-data-hierarchical-data-templates_5}}
	this.radTreeView.ItemsSource = MyViewModel.GetItems( "Item" );
	{{endregion}}



#### __VB.NET__

{{region radtreeview-populating-with-data-hierarchical-data-templates_6}}
	Me.radTreeView.ItemsSource = MyViewModel.GetItems("Item")
	{{endregion}}



Here is the final result: 

![](images/RadTreeView_TemplatingHierarchicalDataTemplate_010.PNG)

# See Also[Templating - Overview](F06A3B44-35DB-4A81-A779-E31690DF9B71)[Templating - Templated Parts](29670722-F6CA-4827-9358-965B276DD358)

 * [Styling and Appearance - Overview]({%slug radtreeview-styling-and-appearance-overview2%})

 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})
