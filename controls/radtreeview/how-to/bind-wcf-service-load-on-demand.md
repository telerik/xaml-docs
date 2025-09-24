---
title: Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand
page_title: Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand
description: Check our &quot;Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-bind-wcf-service-load-on-demand
tags: bind,radtreeview,to,hierarchical,data,from,wcf,service,and,use,load,on,demand
published: True
position: 15
---

# Bind RadTreeView to Hierarchical Data from WCF Service and Use Load on Demand

The purpose of this tutorial is to show you how to populate __RadTreeView__ with hierarchical data loaded from WCF service.

Here is a simple treeview declaration: 

{% if site.site_name == 'Silverlight' %}



```XAML
	<UserControl.Resources>
	
	    <example:HierarchicalDataSource x:Key="Source" />
	
	    <telerik:HierarchicalDataTemplate x:Key="NodeTemplate"
	        ItemsSource="{Binding Children}">
	        <TextBlock Text="{Binding Text}"/>
	    </telerik:HierarchicalDataTemplate>
	
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot" Background="White">
	
	    <telerik:RadTreeView x:Name="radTreeView" Margin="8"
	        ItemsSource="{Binding Source={StaticResource Source}}"
	        ItemTemplate="{StaticResource NodeTemplate}"/>
	
	</Grid>
```

{% endif %}
{% if site.site_name == 'WPF' %}



```XAML
	<UserControl.Resources>
	
	    <example:HierarchicalDataSource x:Key="Source" />
	
	    <HierarchicalDataTemplate x:Key="NodeTemplate"
	        ItemsSource="{Binding Children}">
	        <TextBlock Text="{Binding Text}"/>
	    </HierarchicalDataTemplate>
	
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot" Background="White">
	
	    <telerik:RadTreeView x:Name="radTreeView" Margin="8"
	        ItemsSource="{Binding Source={StaticResource Source}}"
	        ItemTemplate="{StaticResource NodeTemplate}"/>
	
	</Grid>
```

{% endif %}

The web service will return an observable collection with objects of type __TableItem__. Here is the __TableItem__ structure: 



```C#
	public class TableItem
	{
	    public TableItem()
	    {
	        this.Children = new List<TableItem>();
	    }
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
	    public List<TableItem> Children
	    {
	        get;
	        set;
	    }
	}
```



```VB.NET
	Public Class TableItem
	    Public Sub New()
	        Me.Children = New List(Of TableItem)()
	    End Sub
	
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
	
	Private _Children As List(Of TableItem)
	    Public Property Children() As List(Of TableItem)
	        Get
	            Return _Children
	        End Get
	        Set(ByVal value As List(Of TableItem))
	            _Children = value
	        End Set
	    End Property
	End Class
```

Now that you have the basis set up, it's time to go on. First you should create your data source object. Add a new class named __HierarchicalDataSource__ which derives from __ObservableCollection__ of __TableItem__. 



```C#
	public class HierarchicalDataSource : ObservableCollection<TableItem>
	{
	    public HierarchicalDataSource()
	    {
	    }
	}
```



```VB.NET
	Public Class HierarchicalDataSource
	    Inherits ObservableCollection(Of TableItem)
	    Public Sub New()
	    End Sub
	End Class
```

Next, you need to add a reference to the WCF service and load the data{% if site.site_name == 'Silverlight' %} asynchronously{% endif %}. You also need a list that holds all items that come from the web service result. 



```C#
	public class HierarchicalDataSource : ObservableCollection<TableItem>
	{
	    // This list holds all the items that come from the web service result
	    private List<TableItem> unsortedList = new List<TableItem>();
	    public HierarchicalDataSource()
	    {
	        SampleWcfServiceClient serviceClient = new SampleWcfServiceClient();
	        serviceClient.LoadHierarchicalDataCompleted += new EventHandler<LoadHierarchicalDataCompletedEventArgs>( serviceClient_LoadHierarchicalDataCompleted );
	        serviceClient.LoadHierarchicalDataAsync();
	    }
	    private void serviceClient_LoadHierarchicalDataCompleted( object sender, LoadHierarchicalDataCompletedEventArgs e )
	    {
	        // transfer all the items from the result to the unsorted list
	        foreach ( TableItem item in e.Result )
	        {
	            TableItem genericItem = new TableItem()
	            {
	                Text = item.Text,
	                Id = item.Id,
	                ParentId = item.ParentId
	            };
	            this.unsortedList.Add( genericItem );
	        }
	        // Get all the first level nodes.
	        var rootNodes = this.unsortedList.Where( x => x.ParentId == 0 );
	        // Foreach root node, get all its children and add the node to the HierarchicalDataSource.
	        // see below how the FindChildren method works
	        foreach ( TableItem node in rootNodes )
	        {
	            this.FindChildren( node );
	            this.Add( node );
	        }
	    }
	}
```



```VB.NET
	Public Class HierarchicalDataSource
	    Inherits ObservableCollection(Of TableItem)
	    ' This list holds all the items that come from the web service result'
	    Private unsortedList As New List(Of TableItem)()
	
	    Public Sub New()
	        Dim serviceClient As New SampleWcfServiceClient()
	        AddHandler serviceClient.LoadHierarchicalDataCompleted, AddressOf serviceClient_LoadHierarchicalDataCompleted
	        serviceClient.LoadHierarchicalDataAsync()
	    End Sub
	
	    Private Sub serviceClient_LoadHierarchicalDataCompleted(ByVal sender As Object, ByVal e As LoadHierarchicalDataCompletedEventArgs)
	        ' transfer all the items from the result to the unsorted list'
	        For Each item As TableItem In e.Result
	            Dim genericItem As New TableItem()
	            Me.unsortedList.Add(genericItem)
	        Next
	
	        ' Get all the first level nodes.'
	        Dim rootNodes = Me.unsortedList.Where(Function(x) x.ParentId = 0)
	
	        ' Foreach root node, get all its children and add the node to the HierarchicalDataSource.'
	        ' see below how the FindChildren method works'
	        For Each node As TableItem In rootNodes
	            Me.FindChildren(node)
	            Me.Add(node)
	        Next
	    End Sub
	End Class
```

Add the __FindChildren()__ method to the __HierarchicalDataSource__ file. It will find all child nodes by a given item. 



```C#
	private void FindChildren( TableItem item )
	{
	    // find all the children of the item
	    var children = unsortedList.Where( x => x.ParentId == item.Id && x.Id != item.Id );
	    // add the child to the item's children collection and call the FindChildren recursively, in case the child has children
	    foreach ( TableItem child in children )
	    {
	        // By not calling iteratively FindChildren() here we prevent
	        // the automatic loading of all items in the data
	        // source and load only the next level in the hierarchy
	        item.Children.Add( child );
	    }
	}
```



```VB.NET
	Private Sub FindChildren(ByVal item As TableItem)
	    ' find all the children of the item'
	    Dim children = unsortedList.Where(Function(x) x.ParentId = item.Id AndAlso x.Id <> item.Id)
	
	    ' add the child to the items children collection and call the FindChildren recursively, in case the child has children'
	    For Each child As TableItem In children
	        ' By not calling iteratively FindChildren() here we prevent'
	        ' the automatic loading of all items in the data'
	        ' source and load only the next level in the hierarchy'
	        item.Children.Add(child)
	    Next
	End Sub
```

Add a public method named __LoadItemChildren()__. This method visits all current items and adds their direct children to the data source, if there are any. 



```C#
	public void LoadItemChildren( TableItem item )
	{
	    foreach ( TableItem i in item.Children )
	    {
	        FindChildren( i );
	    }
	}
```



```VB.NET
	Public Sub LoadItemChildren(ByVal item As TableItem)
	    For Each i As TableItem In item.Children
	        FindChildren(i)
	    Next
	End Sub
```

Finally add an event handler in your treeview declaration for the __Expanded__ event. 



```XAML
	<telerik:RadTreeView x:Name="radTreeView" Margin="8"
	    Expanded="radTreeView_Expanded"
	    ItemsSource="{Binding Source={StaticResource Source}}"
	    ItemTemplate="{StaticResource NodeTemplate}"/>
```

Switch to the code-behind and the following code to handle the event. 



```C#
	private void radTreeView_Expanded( object sender, Telerik.Windows.RadRoutedEventArgs e )
	{
	    Telerik.Windows.Controls.RadTreeView tree = sender as Telerik.Windows.Controls.RadTreeView;
	    RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
	    if ( ( tree != null ) && ( item != null ) )
	    {
	        // Load the next level from the data hierarchy
	        HierarchicalDataSource source = this.Resources[ "Source" ] as HierarchicalDataSource;
	        TableItem ti = item.DataContext as TableItem;
	        if ( ( ti != null ) && ( source != null ) )
	        {
	            source.LoadItemChildren( ti );
	        }
	    }
	}
```



```VB.NET
	Private Sub radTreeView_Expanded(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
	    Dim tree As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
	    Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
	    If (tree IsNot Nothing) AndAlso (item IsNot Nothing) Then
	        ' Load the next level from the data hierarchy'
	        Dim source As HierarchicalDataSource = TryCast(Me.Resources("Source"), HierarchicalDataSource)
	        Dim ti As TableItem = TryCast(item.DataContext, TableItem)
	        If (ti IsNot Nothing) AndAlso (source IsNot Nothing) Then
	            source.LoadItemChildren(ti)
	        End If
	    End If
	End Sub
```

Here, you first get references to the treeview and the item that was expanded. Then, you get a reference to the hierarchical data source and call its __LoadItemChildren()__ method and pass the value of the expanded item. What the method does is fetching the children of that data item via the web service and adding them as children of the treeview.

## See Also
 * [Get Item by Path]({%slug radtreeview-how-to-get-item-by-path%})
 * [Binding to WCF Service]({%slug radtreeview-populating-with-data-databinding-to-wcf-service%})
 * [Binding to XML]({%slug radtreeview-populating-with-data-data-binding-to-xml%})