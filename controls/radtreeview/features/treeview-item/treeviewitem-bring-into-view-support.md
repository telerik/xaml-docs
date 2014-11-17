---
title: BringIntoView Support
page_title: BringIntoView Support
description: BringIntoView Support
slug: radtreeview-features-treeviewitem-bring-into-view-support
tags: bringintoview,support
published: True
position: 5
---

# BringIntoView Support

The __RadTreeView__ API offers __BringIntoView__ support through the following methods:	  

When you invoke any of these methods, the __RadTreeView__ will attempt to bring the provided item into view.	  

## BringIndexIntoView()

>importantThe __BringIndexIntoView()__ method can only work for __immediate items__. However, please note that the method won't be able to bring a __RadTreeViewItem__ into view before the __item containers have been generated__.		  

Consider the following example. A __RadTreeView__ is data bound to a collection of business objects.		

#### __XAML__

{{region radtreeview-features-treeviewitem-bring-into-view-support_0}}
	<Grid x:Name="LayoutRoot"
	        Background="White">
	    <Grid.Resources>
	        <DataTemplate x:Key="treeViewTemplate">
	            <TextBlock Text="{Binding Title}" />
	        </DataTemplate>
	    </Grid.Resources>
	    <telerik:RadTreeView x:Name="RadTreeView">
	        <telerik:RadTreeViewItem x:Name="RadTreeViewItem"
	                                            Header="MyItems"
	                                            ItemTemplate="{StaticResource treeViewTemplate}">
	        </telerik:RadTreeViewItem>
	    </telerik:RadTreeView>
	</Grid>
	{{endregion}}

#### __C#__

{{region radtreeview-features-treeviewitem-bring-into-view-support_1}}
	public class MyViewModel 
	{
	    private static int idCounter;
	    private string title;
	    public MyViewModel()
	    {
	        this.Id = idCounter++;
	    }
	    public int Id
	    {
	        get;
	        protected set;
	    }
	    public String Title
	    {
	        get
	        {
	            return this.title;
	        }
	        set
	        {
	            if ( this.title != value )
	            {
	                this.title = value;
	            }
	        }
	    }
	}
	//.....
	RadTreeViewItem.ItemsSource = Enumerable.Range( 1, 40 ).Select( i => new MyViewModel()
	{
	    Title = "Item " + i
	} ).ToList();
	{{endregion}}



#### __VB.NET__

{{region radtreeview-features-treeviewitem-bring-into-view-support_2}}
	Public Class MyViewModel
	 Private Shared idCounter As Integer
	 Private m_title As String
	 Public Sub New()
	  Me.Id = System.Math.Max(System.Threading.Interlocked.Increment(idCounter),idCounter - 1)
	 End Sub
	 Public Property Id() As Integer
	  Get
	   Return m_Id
	  End Get
	  Protected Set
	   m_Id = Value
	  End Set
	 End Property
	 Private m_Id As Integer
	 Public Property Title() As [String]
	  Get
	   Return Me.m_title
	  End Get
	  Set
	   If Me.m_title <> value Then
	    Me.m_title = value
	   End If
	  End Set
	 End Property
	End Class
	{{endregion}}

![](images/RadTreeView_TreeViewBringIntoViewSupport_010.png)

If you want to programmatically scroll to the "Item 20" (thus bringing this item into view), you could try the following scenario:

#### __C#__

{{region radtreeview-features-treeviewitem-bring-into-view-support_3}}
	private void BringItemIntoView()
	{
	    this.RadTreeViewItem.BringIndexIntoView( 20 );
	}
	{{endregion}}

#### __VB.NET__

{{region radtreeview-features-treeviewitem-bring-into-view-support_4}}
	Private Sub BringItemIntoView()
	    Me.RadTreeViewItem.BringIndexIntoView(20)
	End Sub
	{{endregion}}

And the result will be:
![](images/RadTreeView_TreeViewBringIntoViewSupport_020.png)

## BringItemIntoView()

__RadTreeView__ offers a second method which does exactly the same thing as the __BringIndexIntoView()__ method. That's the __BringItemIntoView()__ method.
	
#### __C#__
	private void BringItemIntoView()
	{
		MyViewModel viewModel = dataSource.First( v => v.Title == "Item 20" );
		this.RadTreeViewItem.BringItemIntoView( viewModel );
	}

#### __VB.NET__	
	Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
		Dim viewModel As MyViewModel = dataSource.First(Function(v) v.Title = "Item 20")
		Me.RadTreeViewItem.BringItemIntoView(viewModel)
	End Sub		

>important Please keep in mind that the __BringItemIntoView()__ method can only work for __immediate items__ and only as long as all __RadTreeViewItem__ containers __have been generated__.

The __BringItemIntoView()__ method makes an internal call to the __BringIntexIntoView()__ method and this is why it is better to consider using the __BringIndexIntoView()__ method instead whenever possible.

## BringPathIntoView()

>importantThe __BringPathIntoView()__ method can be used even in scenarios where not all __RadTreeViewItem__ containers are generated. This is possible due to its implementation which makes sure that the __RadTreeView__ has loaded its containers, before starting a recursive search through its items. This makes it the best choice for bringing virtualized items into view.

As the main purpose of this method is to allow you to bring virtualized items into view, you need to make sure that your view models can build a path to each __RadTreeViewItem__. This is important as the __BringPathIntoView()__ method recursively traverses the hierarchy of data items displayed inside the __RadTreeView__ to search for an item based on its path.

Another important note about the implementation of the method is that it uses the __TextSearch.TextPath__ attached property to match the path to the __RadTreeViewItem__ containers.

>The __TextSearch.TextPath__ attached property is part of the __Telerik.Windows.Controls__ namespace and this is why you can reach it through the following alias:
xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" like this: `<telerik:RadTreeView telerik:TextSearch.TextPath="Name"/>`

Consider the following __RadTreeView__ definition:

#### __XAML__	
	<telerik:RadTreeView x:Name="myTreeView" Width="300" IsVirtualizing="True" telerik:TextSearch.TextPath="Name">
		<telerik:RadTreeView.ItemTemplate>
			<HierarchicalDataTemplate ItemsSource="{Binding Children}">
				<TextBlock Text="{Binding Name}" />
			</HierarchicalDataTemplate>
		</telerik:RadTreeView.ItemTemplate>
	</telerik:RadTreeView>		  

If the business items displayed in the __RadTreeView__ are described with the following classes:

#### __C#__	
	public class MainViewModel : ObservableCollection<DataItem>
	{
		public MainViewModel()
		{
			for (int i = 0; i < 25; i++)
			{
				DataItem item = new DataItem() { Name = String.Format("Item {0}", i) };
				for (int j = 0; j < 3; j++)
				{
					item.Children.Add(new DataItem { Name = String.Format("Item {0}.{1}", i, j) });
				}
				this.Add(item);
			}
		}
	}

	public class DataItem
	{
		public string Name { get; set; }
		public ObservableCollection<DataItem> Children { get; set; }

		public DataItem()
		{
			this.Children = new ObservableCollection<DataItem>();
		}
	}		  


#### __VB.NET__	
	Public Class MainViewModel
		Inherits ObservableCollection(Of DataItem)
		Public Sub New()
			For i As Integer = 0 To 24
				Dim item As New DataItem() With {.Name = [String].Format("Item {0}", i)}
				For j As Integer = 0 To 2
					item.Children.Add(New DataItem() With {.Name = [String].Format("Item {0}.{1}", i, j)})
				Next
				Me.Add(item)
			Next
		End Sub
	End Class

	Public Class DataItem
		Public Property Name() As String
			Get
				Return itemName
			End Get
			Set
				itemName = Value
			End Set
		End Property
		Private itemName As String
		Public Property Children() As ObservableCollection(Of DataItem)
			Get
				Return itemChildren
			End Get
			Set
				itemChildren = Value
			End Set
		End Property
		Private itemChildren As ObservableCollection(Of DataItem)

		Public Sub New()
			Me.Children = New ObservableCollection(Of DataItem)()
		End Sub
	End Class		  

![Rad Tree View-Bring Path Into View-Tree View Def](images/RadTreeView-BringPathIntoView-TreeViewDef.png)

You can bring an item into view like this:
	
#### __C#__
	public partial class Example : UserControl
	{
		public Example()
		{
			InitializeComponent();
			myTreeView.ItemsSource = new MainViewModel();
			string path = "Item 20\\Item 20.1";
			myTreeView.BringPathIntoView(path);
		}
	}  
	
#### __VB.NET__	
	Public Partial Class Example
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			myTreeView.ItemsSource = New MainViewModel()
			Dim path As String = "Item 20\Item 20.1"
			myTreeView.BringPathIntoView(path)
		End Sub
	End Class

>tip You can find a complete solution demonstrating the __BringPathIntoView()__ method implementation in [this tutorial]({%slug radtreeview-how-to-bring-path-into-view%}).
		

# See Also
 * [How to Use BringPathIntoView Method]({%slug radtreeview-how-to-bring-path-into-view%})
 * [How to Edit An Item]({%slug radtreeview-feautres-treeviewitem-item-editing%})
 * [Item Images]({%slug radtreeview-feautres-treeviewitem-item-images%})
 * [Enable and Disable Items]({%slug radtreeview-feautres-treeviewitem-enable-disable-items%})
 * [Selection]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})