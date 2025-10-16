---
title: Scroll Item into View
page_title: Scroll Item into View
description: Check our &quot;Scroll Item into View&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelistview-how-to-scrollintoview
tags: scroll,item,into,view
published: True
position: 3
---

# Scroll Item into View



The __RadTreeListView API__ offers __ScrollIntoView__ support through the following methods:
	  

* [ScrollIntoViewAsync()](#scrollintoviewasync)

* [ScrollIntoView()](#scrollintoview)

The goal of this tutorial is to demonstrate how you can bring a particular, deeply nested __TreeListViewRow__ into view. This might be helpful if you need a fast hierarchy control with many nested levels and __RadTreeView__ is slow in your particular scenario with bring into view. This example is configured in such way that __RadTreeListView__ behaves and feels much like __RadTreeView__.
	  

## Initial setting up of the project

For the purpose of this example, you will need to create an empty application project and open it in Visual Studio.	The first step is to add references to the following assemblies:
		

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.GridView__

* __Telerik.Windows.Controls.Input__

* __Telerik.Windows.Data__

Then you can define the controls in your view. As the purpose of this tutorial is to demonstrate how to implement the __ScrollIntoView__ methods, we won't focus on the definitions of the controls in xaml.
		



```XAML

	<Grid x:Name="LayoutRoot" Background="White">
		<Grid.RowDefinitions>
			<RowDefinition Height="40" />
			<RowDefinition Height="*" />
		</Grid.RowDefinitions>
	
		<Grid.Resources>
			<Style TargetType="telerik:RadTreeListView">
				<Setter Property="VerticalGridLinesBrush" Value="{x:Null}" />
				<Setter Property="RowIndicatorVisibility" Value="Collapsed" />
				<Setter Property="IsFilteringAllowed" Value="False" />
				<Setter Property="CanUserFreezeColumns" Value="False" />
				<Setter Property="CanUserDeleteRows" Value="False" />
				<Setter Property="AutoGenerateColumns" Value="False" />
				<Setter Property="ShowGroupPanel" Value="False" />
				<Setter Property="ShowColumnHeaders" Value="False" />
				<Setter Property="AutoExpandGroups" Value="True" />
				<Setter Property="GridLinesVisibility" Value="None" />
				<Setter Property="RowHeight" Value="24" />
				<Setter Property="BorderThickness" Value="0" />
				<Setter Property="BorderBrush" Value="{x:Null}" />
			</Style>
		</Grid.Resources>
	
		<telerik:RadTreeListView x:Name="treeList"
								 Grid.Row="1"
								 Width="500"		                         
								 IsExpandableBinding="{Binding IsExpandable}"
								 TreeLinesVisibility="Visible">
			<telerik:RadTreeListView.ChildTableDefinitions>
				<telerik:TreeListViewTableDefinition ItemsSource="{Binding Children}" />
			</telerik:RadTreeListView.ChildTableDefinitions>
	
			<telerik:RadTreeListView.Columns>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Header="Name" />
			</telerik:RadTreeListView.Columns>
		</telerik:RadTreeListView>
	
		<StackPanel HorizontalAlignment="Center" Orientation="Horizontal">
			<telerik:RadButton Width="350"
							   Click="RadButton_Click_1"
							   Content="ScrollIntoViewAsync Recursively" />
			<telerik:RadButton Width="350"
							   Click="RadButton_Click_2"
							   Content="Expand in a Loop and Then Scroll" />
		</StackPanel>
	</Grid>
```



The next step is to define the business object.
		



```C#

	public class DataItem : ViewModelBase
	    {
	        private string name;
	        public string Name
	        {
	            get { return this.name; }
	            set
	            {
	                if (this.name != value)
	                {
	                    this.name = value;
	                    this.OnPropertyChanged("Name");
	                }
	            }
	        }
	
	        private ObservableCollection<DataItem> children;
	        public ObservableCollection<DataItem> Children
	        {
	            get
	            {
	                if (children == null)
	                {
	                    children = new ObservableCollection<DataItem>();
	                    for (int i = 0; i < 100; i++)
	                    {
	                        DataItem item = new DataItem() { Name = this.Name + "." + i};
	                        children.Add(item);
	                    }
	                }
	                return children;
	            }
	        }
	
	        public bool IsExpandable
	        {
	            get
	            {
	                return true;
	            }
	        }
	    }
```
```VB.NET

	Public Class DataItem
		Inherits ViewModelBase
	
			Private name_Renamed As String
			Public Property Name() As String
				Get
					Return Me.name_Renamed
				End Get
				Set(ByVal value As String)
					If Me.name_Renamed <> value Then
						Me.name_Renamed = value
						Me.OnPropertyChanged("Name")
					End If
				End Set
			End Property
	
			Private children_Renamed As ObservableCollection(Of DataItem)
			Public ReadOnly Property Children() As ObservableCollection(Of DataItem)
				Get
					If children_Renamed Is Nothing Then
						children_Renamed = New ObservableCollection(Of DataItem)()
						For i As Integer = 0 To 99
							Dim item As New DataItem() With {.Name = Me.Name & "." & i}
							children_Renamed.Add(item)
						Next i
					End If
					Return children_Renamed
				End Get
			End Property
	
			Public ReadOnly Property IsExpandable() As Boolean
				Get
					Return True
				End Get
			End Property
	End Class
```



What comes next, is to populate with data.
		



```C#

	public partial class Example : UserControl
	{
		DateTime listBringStart;
		private ObservableCollection<DataItem> list;
	
		public Example()
		{
			InitializeComponent();
			this.LoadData();
		}
	
		private void LoadData()
		{
			list = new ObservableCollection<DataItem>();
			for (int i = 0; i < 100; i++)
			{
				DataItem root = new DataItem() { Name = "Item " + i };
				list.Add(root);
			}
			this.treeList.ItemsSource = list;
		}
	}
```
```VB.NET

	Partial Public Class Example
		Inherits UserControl
	
		Private listBringStart As Date
		Private list As ObservableCollection(Of DataItem)
	
		Public Sub New()
			InitializeComponent()
			Me.LoadData()
		End Sub
	
		Private Sub LoadData()
			list = New ObservableCollection(Of DataItem)()
			For i As Integer = 0 To 99
				Dim root As New DataItem() With {.Name = "Item " & i}
				list.Add(root)
			Next i
			Me.treeList.ItemsSource = list
		End Sub
	End Class
```



## ScrollIntoViewAsync()

Clicking the first button will bring an item which is 20 levels deep with updating the UI on every level expansion. For this purpose we will use the {% if site.site_name == 'Silverlight' %}[ScrollIntoViewAsync (Object dataItem, Action(FrameworkElement) scrollFinishedCallback, bool expandItem)](http://www.telerik.com/help/silverlight/m_telerik_windows_controls_radtreelistview_scrollintoviewasync_1.html){% endif %}{% if site.site_name == 'WPF' %}[ScrollIntoViewAsync (Object dataItem, Action(FrameworkElement) scrollFinishedCallback, bool expandItem)](http://www.telerik.com/help/wpf/m_telerik_windows_controls_radtreelistview_scrollintoviewasync_1.html){% endif %} method, which scrolls the row containing the data item into view in an asynchronous manner.
		



```C#

	private void RadButton_Click_1(object sender, RoutedEventArgs e)
	{
		this.listBringStart = DateTime.Now;
		this.ScrollIntoViewRecursive(0, list[85]);
	}
	
	private void ScrollIntoViewRecursive(int level, DataItem item)
	{
		if (level >= 20)
		{
			MessageBox.Show(DateTime.Now.Subtract(this.listBringStart).TotalSeconds.ToString() + " sec.");
			return;
		}
		var newItem = item.Children[85];
		this.treeList.ScrollIntoViewAsync(item, (f) => { ScrollIntoViewRecursive(++level, newItem); }, true);
	}
```
```VB.NET

	Private Sub RadButton_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Me.listBringStart = Date.Now
		Me.ScrollIntoViewRecursive(0, list(85))
	End Sub
	
	Private Sub ScrollIntoViewRecursive(ByVal level As Integer, ByVal item As DataItem)
		If level >= 20 Then
			MessageBox.Show(Date.Now.Subtract(Me.listBringStart).TotalSeconds.ToString() & " sec.")
			Return
		End If
		Dim newItem = item.Children(85)
		Me.treeList.ScrollIntoViewAsync(item, Sub(f)
			level += 1
			ScrollIntoViewRecursive(level, newItem)
		End Sub, True)
	End Sub
```



## ScrollIntoView()

Clicking the second button will update the UI only when the bring operation is finished. Here we are using the {% if site.site_name == 'Silverlight' %}[ScrollIntoView(Object dataItem, bool expandItem)](http://www.telerik.com/help/silverlight/m_telerik_windows_controls_radtreelistview_scrollintoview.html){% endif %}{% if site.site_name == 'WPF' %}[ScrollIntoView(Object dataItem, bool expandItem)](http://www.telerik.com/help/wpf/m_telerik_windows_controls_radtreelistview_scrollintoview.html){% endif %} method, which scrolls the row containing the data item into view.
		



```C#

	private void RadButton_Click_2(object sender, RoutedEventArgs e)
	{
		DateTime startTime = DateTime.Now;
	
		DataItem start = this.list[85];
		for (int i = 0; i < 20; i++)
		{
			this.treeList.ExpandHierarchyItem(start);
			start = start.Children[85];
		}
		this.treeList.ScrollIntoView(start, false);
		this.treeList.SelectedItems.Add(start);
		DateTime end = DateTime.Now;
		MessageBox.Show(end.Subtract(startTime).TotalSeconds.ToString() + " sec.");
	}
```
```VB.NET

	Private Sub RadButton_Click_2(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim startTime As Date = Date.Now
	
		Dim start As DataItem = Me.list(85)
		For i As Integer = 0 To 19
			Me.treeList.ExpandHierarchyItem(start)
			start = start.Children(85)
		Next i
		Me.treeList.ScrollIntoView(start, False)
		Me.treeList.SelectedItems.Add(start)
		Dim [end] As Date = Date.Now
		MessageBox.Show([end].Subtract(startTime).TotalSeconds.ToString() & " sec.")
	End Sub
```

>tipPlease have in mind that running the application without debugger (__Ctrl + F5__ when in VS) will result in faster user experience.		  

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/TreeView/TreeListViewBringItemIntoView).		  

## See Also  
 * [RadGridView: Scroll to a particular row or column]({%slug gridview-scroll-item%})
 * [RadTreeView: How to Use BringPathIntoView Method]({%slug radtreeview-how-to-bring-path-into-view%})