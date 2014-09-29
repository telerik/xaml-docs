---
title: Use RadContextMenu with a RadGridView
page_title: Use RadContextMenu with a RadGridView
description: Use RadContextMenu with a RadGridView
slug: radcontextmenu-how-to-use-radcontextmenu-with-radgridview
tags: use,radcontextmenu,with,a,radgridview
published: True
position: 0
---

# Use RadContextMenu with a RadGridView



## Attach a RadContextMenu to a RadGridView

In this tutorial a __RadGridView__ will be used, which displays a list of __Employee__ objects and has the following declaration:

#### __XAML__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_0}}
	<telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}" Header="First Name"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}" Header="Last Name"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Age}" Header="Age"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding IsMarried}" Header="Married"/>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}



In order to add a __RadContextMenu__ to it, you have to just set the __RadContextMenu.ContextMenu__ attached property.

#### __XAML__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_1}}
	<telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="GridContextMenu" />
	    </telerik:RadContextMenu.ContextMenu>
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}" Header="First Name"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}" Header="Last Name"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Age}" Header="Age"/>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding IsMarried}" Header="Married"/>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}



## Configure the ItemContainerStyle for RadContextMenu

The __RadContextMenu__ will be populated with dynamic data, so you have to prepare an __ItemContainerStyle__ that will display this data. The business object that will represent the data looks like this:

#### __C#__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_2}}
	public class MenuItem : INotifyPropertyChanged
	{
	    private bool isEnabled = true;
	    private string text;
	    private ObservableCollection<MenuItem> subItems;
	    public event PropertyChangedEventHandler PropertyChanged;
	    public bool IsEnabled
	    {
	        get
	        {
	            return this.isEnabled;
	        }
	        set
	        {
	            if ( this.isEnabled != value )
	            {
	                this.isEnabled = value;
	                this.OnNotifyPropertyChanged( "IsEnabled" );
	            }
	        }
	    }
	    public string Text
	    {
	        get
	        {
	            return this.text;
	        }
	        set
	        {
	            if ( this.text != value )
	            {
	                this.text = value;
	                this.OnNotifyPropertyChanged( "Text" );
	            }
	        }
	    }
	    public ObservableCollection<MenuItem> SubItems
	    {
	        get
	        {
	            if ( this.subItems == null )
	            {
	                this.subItems = new ObservableCollection<MenuItem>();
	            }
	            return this.subItems;
	        }
	        set
	        {
	            if ( this.subItems != value )
	            {
	                this.subItems = value;
	                this.OnNotifyPropertyChanged( "SubItems" );
	            }
	        }
	    }
	    private void OnNotifyPropertyChanged( string ptopertyName )
	    {
	        if ( this.PropertyChanged != null )
	        {
	            this.PropertyChanged( this, new PropertyChangedEventArgs( ptopertyName ) );
	        }
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_3}}
	Public Class MenuItem
	    Implements INotifyPropertyChanged
	
	    Private _isEnabled As Boolean = True
	    Private _text As String
	    Private _subItems As ObservableCollection(Of MenuItem)
	
	    Public Property IsEnabled() As Boolean
	        Get
	            Return Me._isEnabled
	        End Get
	        Set(value As Boolean)
	            If Me._isEnabled <> value Then
	                Me._isEnabled = value
	                Me.OnNotifyPropertyChanged("IsEnabled")
	            End If
	        End Set
	    End Property
	    Public Property Text() As String
	        Get
	            Return Me._text
	        End Get
	        Set(value As String)
	            If Me._text <> value Then
	                Me._text = value
	                Me.OnNotifyPropertyChanged("Text")
	            End If
	        End Set
	    End Property
	    Public Property SubItems() As ObservableCollection(Of MenuItem)
	        Get
	            If Me._subItems Is Nothing Then
	                Me._subItems = New ObservableCollection(Of MenuItem)()
	            End If
	            Return Me._subItems
	        End Get
	        Set(value As ObservableCollection(Of MenuItem))
	            If Me._subItems IsNot value Then
	                Me._subItems = value
	                Me.OnNotifyPropertyChanged("SubItems")
	            End If
	        End Set
	    End Property
	
	    Private Sub OnNotifyPropertyChanged(ByVal propertyName As String)
	        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	    End Sub
	
	    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
	End Class
	{{endregion}}



Here is the __ItemContainerStyle__:

#### __XAML__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_4}}
	<Style x:Key="MenuItemContainerStyle" TargetType="telerik:RadMenuItem">
	    <Setter Property="Header" Value="{Binding Text}"/>
	    <Setter Property="ItemsSource" Value="{Binding SubItems}"/>
	    <Setter Property="IsEnabled" Value="{Binding IsEnabled}"/>
	</Style>
	{{endregion}}



## Display different menu items depending on which part of the RadGridView is clicked

Tha __RadContextMenu__ should display different items, depending on which part of it is clicked. Here are the possibilities:

* __GridView Header__

* Sort

* Ascending

* Descending

* None

* Move Left

* Move Right

* __GridView Row__

* Add

* Edit

* Delete

* __Anything Else__

* Add

* Edit (__Disabled__)

* Delete (__Disabled__)

As you can see, two data sources have to be provided for the __RadContextMenu__ - one when a header is clicked and one when a row is clicked. For that purpose, create two properties in your __UserControl__ as follows:

#### __C#__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_7}}
	private ObservableCollection<MenuItem> headerContextMenuItems;
	private ObservableCollection<MenuItem> rowContextMenuItems;
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_8}}
	Private headerContextMenuItems As ObservableCollection(Of MenuItem)
	Private rowContextMenuItems As ObservableCollection(Of MenuItem)
	{{endregion}}



And initialize their data by using methods like these one.

#### __C#__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_9}}
	public RadGridViewIntegration()
	{
	    InitializeComponent();
	    this.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees();
	
	    this.InitializeHeaderContextMenuItems();
	    this.InitializeRowContextMenuItems();
	}
	private void InitializeRowContextMenuItems()
	{
	    ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
	    MenuItem addItem = new MenuItem();
	    addItem.Text = "Add";
	    items.Add( addItem );
	    MenuItem editItem = new MenuItem();
	    editItem.Text = "Edit";
	    items.Add( editItem );
	    MenuItem deleteItem = new MenuItem();
	    deleteItem.Text = "Delete";
	    items.Add( deleteItem );
	    this.rowContextMenuItems = items;
	}
	private void InitializeHeaderContextMenuItems()
	{
	    ObservableCollection<MenuItem> headerItems = new ObservableCollection<MenuItem>();
	    ObservableCollection<MenuItem> sortItems = new ObservableCollection<MenuItem>();
	    MenuItem sortAscItem = new MenuItem();
	    sortAscItem.Text = "Ascending";
	    sortItems.Add( sortAscItem );
	    MenuItem sortDescItem = new MenuItem();
	    sortDescItem.Text = "Descending";
	    sortItems.Add( sortDescItem );
	    MenuItem sortNoneItem = new MenuItem();
	    sortNoneItem.Text = "None";
	    sortItems.Add( sortNoneItem );
	    MenuItem sortItem = new MenuItem();
	    sortItem.Text = "Sort";
	    sortItem.SubItems = sortItems;
	    headerItems.Add( sortItem );
	    MenuItem moveLeftItem = new MenuItem();
	    moveLeftItem.Text = "Move Left";
	    headerItems.Add( moveLeftItem );
	    MenuItem moveRightItem = new MenuItem();
	    moveRightItem.Text = "Move Right";
	    headerItems.Add( moveRightItem );
	    this.headerContextMenuItems = headerItems;
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_10}}
	Public Sub New()
	    InitializeComponent()
	    Me.radGridView.ItemsSource = EmployeeService.GetEmployees()
	    Me.InitializeHeaderContextMenuItems()
	    Me.InitializeRowContextMenuItems()
	End Sub
	Private Sub InitializeRowContextMenuItems()
	    Dim items As New ObservableCollection(Of MenuItem)()
	    Dim addItem As New MenuItem()
	    addItem.Text = "Add"
	    items.Add(addItem)
	    Dim editItem As New MenuItem()
	    editItem.Text = "Edit"
	    items.Add(editItem)
	    Dim deleteItem As New MenuItem()
	    deleteItem.Text = "Delete"
	    items.Add(deleteItem)
	    Me.rowContextMenuItems = items
	End Sub
	Private Sub InitializeHeaderContextMenuItems()
	    Dim headerItems As New ObservableCollection(Of MenuItem)()
	    Dim sortItems As New ObservableCollection(Of MenuItem)()
	    Dim sortAscItem As New MenuItem()
	    sortAscItem.Text = "Ascending"
	    sortItems.Add(sortAscItem)
	    Dim sortDescItem As New MenuItem()
	    sortDescItem.Text = "Descending"
	    sortItems.Add(sortDescItem)
	    Dim sortNoneItem As New MenuItem()
	    sortNoneItem.Text = "None"
	    sortItems.Add(sortNoneItem)
	    Dim sortItem As New MenuItem()
	    sortItem.Text = "Sort"
	    sortItem.SubItems = sortItems
	    headerItems.Add(sortItem)
	    Dim moveLeftItem As New MenuItem()
	    moveLeftItem.Text = "Move Left"
	    headerItems.Add(moveLeftItem)
	    Dim moveRightItem As New MenuItem()
	    moveRightItem.Text = "Move Right"
	    headerItems.Add(moveRightItem)
	    Me.headerContextMenuItems = headerItems
	End Sub
	{{endregion}}



Next you will need two properties that will return the clicked row and the clicked header. Define them in your __UserControl__ as follows.

#### __C#__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_11}}
	private GridViewHeaderCell ClickedHeader
	{
	    get
	    {
	        return this.GridContextMenu.GetClickedElement<GridViewHeaderCell>();
	    }
	}
	private GridViewRow ClickedRow
	{
	    get
	    {
	        return this.GridContextMenu.GetClickedElement<GridViewRow>();
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_12}}
	Private ReadOnly Property ClickedHeader() As GridViewHeaderCell
	    Get
	        Return Me.GridContextMenu.GetClickedElement(Of GridViewHeaderCell)()
	    End Get
	End Property
	Private ReadOnly Property ClickedRow() As GridViewRow
	    Get
	        Return Me.GridContextMenu.GetClickedElement(Of GridViewRow)()
	    End Get
	End Property
	{{endregion}}



The last thing to do is to attach an event handler to the __Opened__ event of the __RadContextMenu__. There you can implement the logic around changing the __ItemsSource__ of the __RadContextMenu__ depending on the clicked element.

#### __XAML__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_13}}
	<telerik:RadContextMenu x:Name="GridContextMenu"
	                                  ItemContainerStyle="{StaticResource MenuItemContainerStyle}"
	                                  Opened="GridContextMenu_Opened" />
	{{endregion}}



#### __C#__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_14}}
	private void GridContextMenu_Opened( object sender, RoutedEventArgs e )
	{
	    if ( this.ClickedHeader != null )
	    {
	        this.GridContextMenu.ItemsSource = this.headerContextMenuItems;
	    }
	    else if ( this.ClickedRow != null )
	    {
	        this.radGridView.SelectedItem = this.ClickedRow.DataContext;
	        foreach ( var item in this.rowContextMenuItems )
	        {
	            item.IsEnabled = true;
	        }
	        this.GridContextMenu.ItemsSource = this.rowContextMenuItems;
	    }
	    else
	    {
	        foreach ( var item in this.rowContextMenuItems )
	        {
	            if ( !item.Text.Equals( "Add" ) )
	            {
	                item.IsEnabled = false;
	            }
	        }
	        this.GridContextMenu.ItemsSource = this.rowContextMenuItems;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_15}}
	Private Sub GridContextMenu_Opened(sender As Object, e As RoutedEventArgs)
	    If Me.ClickedHeader IsNot Nothing Then
	        Me.GridContextMenu.ItemsSource = Me.headerContextMenuItems
	    ElseIf Me.ClickedRow IsNot Nothing Then
	        Me.radGridView.SelectedItem = Me.ClickedRow.DataContext
	        For Each item As Object In Me.rowContextMenuItems
	            item.IsEnabled = True
	        Next
	        Me.GridContextMenu.ItemsSource = Me.rowContextMenuItems
	    Else
	        For Each item As Object In Me.rowContextMenuItems
	            If Not item.Text.Equals("Add") Then
	                item.IsEnabled = False
	            End If
	        Next
	        Me.GridContextMenu.ItemsSource = Me.rowContextMenuItems
	    End If
	End Sub
	{{endregion}}



This will be the result when you click on a row or header:![Rad Context Menu How To Use With Rad Grid View 01](images/RadContextMenu_How_To_Use_With_RadGridView_01.png)

## Handle the menu items' clicks

The last thing to do in this tutorial is to handle the menu items actions. For this purpose attach an event handler to the __ItemClick__ event of the __RadContextMenu__. In it get the clicked item and, depending on its value, execute the appropriate code.

#### __XAML__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_16}}
	<telerik:RadContextMenu x:Name="GridContextMenu"
	                                  ItemContainerStyle="{StaticResource MenuItemContainerStyle}"
	                                  Opened="GridContextMenu_Opened"
	                                  ItemClick="GridContextMenu_ItemClick" />
	{{endregion}}



#### __C#__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_17}}
	private void GridContextMenu_ItemClick( object sender, Telerik.Windows.RadRoutedEventArgs e )
	{
	    MenuItem item = ( e.OriginalSource as RadMenuItem ).DataContext as MenuItem;
	    switch ( item.Text )
	    {
	        case "Add":
	            this.radGridView.BeginInsert();
	            break;
	        case "Edit":
	            this.radGridView.BeginEdit();
	            break;
	        case "Delete":
	            this.radGridView.Items.Remove( this.radGridView.SelectedItem );
	            break;
	        case "Ascending":
	            this.radGridView.SortDescriptors.Clear();
	            this.radGridView.SortDescriptors.Add( new SortDescriptor()
	            {
	                Member = this.ClickedHeader.Column.UniqueName,
	                SortDirection = ListSortDirection.Ascending
	            } );
	            break;
	        case "Descending":
	            this.radGridView.SortDescriptors.Clear();
	            this.radGridView.SortDescriptors.Add( new SortDescriptor()
	            {
	                Member = this.ClickedHeader.Column.UniqueName,
	                SortDirection = ListSortDirection.Descending
	            } );
	            break;
	        case "None":
	            this.radGridView.SortDescriptors.Clear();
	            break;
	        case "Move Left":
	            if ( this.ClickedHeader.Column.DisplayIndex > 0 )
	                this.ClickedHeader.Column.DisplayIndex -= 1;
	            break;
	        case "Move Right":
	            if ( this.ClickedHeader.Column.DisplayIndex < this.radGridView.Columns.Count - 1 )
	                this.ClickedHeader.Column.DisplayIndex += 1;
	            break;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_18}}
	Private Sub GridContextMenu_ItemClick(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
	    Dim item As MenuItem = TryCast((TryCast(e.OriginalSource, RadMenuItem)).DataContext, MenuItem)
	    Select Case item.Text
	        Case "Add"
	            Me.radGridView.BeginInsert()
	            Exit Select
	        Case "Edit"
	            Me.radGridView.BeginEdit()
	            Exit Select
	        Case "Delete"
	            Me.radGridView.Items.Remove(Me.radGridView.SelectedItem)
	            Exit Select
	        Case "Ascending"
	            Me.radGridView.SortDescriptors.Clear()
	            Me.radGridView.SortDescriptors.Add(New SortDescriptor With {
	                                               .Member = Me.ClickedHeader.Column.UniqueName,
	                                               .SortDirection = ListSortDirection.Ascending})
	            Exit Select
	        Case "Descending"
	            Me.radGridView.SortDescriptors.Clear()
	            Me.radGridView.SortDescriptors.Add(New SortDescriptor With {
	                                               .Member = Me.ClickedHeader.Column.UniqueName,
	                                               .SortDirection = ListSortDirection.Descending})
	            Exit Select
	        Case "None"
	            Me.radGridView.SortDescriptors.Clear()
	            Exit Select
	        Case "Move Left"
	            If Me.ClickedHeader.Column.DisplayIndex > 0 Then
	                Me.ClickedHeader.Column.DisplayIndex -= 1
	            End If
	            Exit Select
	        Case "Move Right"
	            If Me.ClickedHeader.Column.DisplayIndex < Me.radGridView.Columns.Count - 1 Then
	                Me.ClickedHeader.Column.DisplayIndex += 1
	            End If
	            Exit Select
	    End Select
	End Sub
	{{endregion}}



# See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})
