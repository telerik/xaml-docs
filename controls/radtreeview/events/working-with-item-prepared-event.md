---
title: Working with ItemPrepared Event
page_title: Working with ItemPrepared Event
description: Check our &quot;Working with ItemPrepared Event&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-events-working-with-item-prepared-event
tags: working,with,itemprepared,event
published: True
position: 1
---

# Working with ItemPrepared Event

The purpose of this tutorial is to show you how to work with the __RadTreeView__'s __ItemPrepared__ event. This event occurs when a child __RadTreeViewItem__ has been prepared and is now ready for use. The main goal of this event is to perform binding of __RadTreeViewItem__ properties to the data objects.

The example shown in this tutorial will demonstrate you how to bind the check state of individual treeview items to a __ToggleState__ property of a class.

In few words, the approaches that you should follow are:

* Create a sample data source

	For the purpose of this example the following business objects will be used:

	#### __C#__

	```C#
		public class DataItem
		{
			public DataItem()
			{
				this.Items = new List<DataItem>();
			}
		
			public string Name
			{
				get;
				set;
			}
		
			public System.Windows.Automation.ToggleState CheckState
			{
				get;
				set;
			}
		
			public List<DataItem> Items
			{
				get;
				set;
			}
		}
		```

	#### __VB.NET__

	```VB.NET
		Public Class DataItem
			Public Sub New()
				Me.Items = New List(Of DataItem)()
			End Sub
		
		Private _Name As String
			Public Property Name() As String
				Get
					Return _Name
				End Get
				Set(ByVal value As String)
					_Name = value
				End Set
			End Property
		
		Private _CheckState As System.Windows.Automation.ToggleState
			Public Property CheckState() As System.Windows.Automation.ToggleState
				Get
					Return _CheckState
				End Get
				Set(ByVal value As System.Windows.Automation.ToggleState)
					_CheckState = value
				End Set
			End Property
		
		Private _Items As List(Of DataItem)
			Public Property Items() As List(Of DataItem)
				Get
					Return _Items
				End Get
				Set(ByVal value As List(Of DataItem))
					_Items = value
				End Set
			End Property
		End Class
		```

	The __CheckState__ property of the __DataItem__ class will be bound to the __CheckState__ property of the __RadTreeViewItem__.

	#### __C#__

	```C#
		public class RawDataSource : List<DataItem>
		{
			public RawDataSource()
			{
				Random rand = new Random( ( int )DateTime.Now.Ticks );
				for ( int i = 1; i < 11; i++ )
				{
					DataItem item = new DataItem()
					{
						Name = String.Format( "Item {0}", i.ToString() ),
						CheckState = GetToggleState( rand.Next( 0, 3 ) )
					};
					for ( int j = 1; j < 11; j++ )
					{
						DataItem subItem = new DataItem()
						{
							Name = String.Format( "Item {0}.{1}", i.ToString(), j.ToString() ),
							CheckState = GetToggleState( rand.Next( 0, 3 ) )
						};
						item.Items.Add( subItem );
					}
					this.Add( item );
				}
			}
		
			private System.Windows.Automation.ToggleState GetToggleState( int code )
			{
				switch ( code )
				{
					case 0:
						return System.Windows.Automation.ToggleState.Off;
					case 1:
						return System.Windows.Automation.ToggleState.On;
					case 2:
						return System.Windows.Automation.ToggleState.Indeterminate;
					default:
						return System.Windows.Automation.ToggleState.Off;
				}
			}
		}
		```

	#### __VB.NET__

	```VB.NET
		Public Class RawDataSource
			Inherits List(Of DataItem)
			Public Sub New()
				Dim rand As New Random(CInt(DateTime.Now.Ticks))
				For i As Integer = 1 To 10
					Dim item As New DataItem()
		
					For j As Integer = 1 To 10
						Dim subItem As New DataItem()
						item.Items.Add(subItem)
					Next
		
					Me.Add(item)
				Next
			End Sub
		
			Private Function GetToggleState(ByVal code As Integer) As System.Windows.Automation.ToggleState
				Select Case code
					Case 0
						Return System.Windows.Automation.ToggleState.Off
					Case 1
						Return System.Windows.Automation.ToggleState.[On]
					Case 2
						Return System.Windows.Automation.ToggleState.Indeterminate
					Case Else
						Return System.Windows.Automation.ToggleState.Off
				End Select
			End Function
		End Class
		```

	The __RawDataSource__ does nothing special, except for initializing the sample data for the __RadTreeView__. This is the data source for the treeview.

* Add a new __RadTreeView__ declaration. Enable the following properties:
	* __IsOptionElementsEnabled__
	* __IsTriStateMode__

	#### __XAML__

	```XAML
		<telerik:RadTreeView x:Name="radTreeView" IsOptionElementsEnabled="True" IsTriStateMode="True"/>
		```



* Declare a __RawDataSource__ object as a resource in your XAML and set the __RadTreeView__'s __ItemsSource__ property.

	#### __XAML__

	```XAML
		<UserControl.Resources>
			<example:RawDataSource x:Key="DataSource"/>
		</UserControl.Resources>
		....
		<telerik:RadTreeView x:Name="radTreeView" 
							 IsOptionElementsEnabled="True" 
							 IsTriStateMode="True" 
							 ItemsSource="{StaticResource DataSource}"/>
		```

* Declare a new [HierarchicalDataTemplate]({%slug radtreeview-populating-with-data-hierarchical-data-templates%}) in your XAML resources and set the __RadTreeView__'s __ItemTemplate__ property.{% if site.site_name == 'Silverlight' %}

	#### __XAML__

	```XAML
		<UserControl.Resources>
			<example:RawDataSource x:Key="DataSource"/>
			<telerik:HierarchicalDataTemplate x:Key="ItemTemplate" ItemsSource="{Binding Items}">
				<StackPanel Orientation="Horizontal">
					<TextBlock Text="{Binding Name}" />
				</StackPanel>
			</telerik:HierarchicalDataTemplate>
		</UserControl.Resources>
		....
		<telerik:RadTreeView x:Name="radTreeView" 
							 IsOptionElementsEnabled="True"
							 IsTriStateMode="True"
							 ItemsSource="{StaticResource DataSource}" 
							 ItemTemplate="{StaticResource ItemTemplate}"/>
		```

	{% endif %}{% if site.site_name == 'WPF' %}

	#### __XAML__

	```XAML
		<Window.Resources>
			<example:RawDataSource x:Key="DataSource"/>
			<HierarchicalDataTemplate x:Key="ItemTemplate" ItemsSource="{Binding Items}">
				<StackPanel Orientation="Horizontal">
					<TextBlock Text="{Binding Name}" />
				</StackPanel>
			</HierarchicalDataTemplate>
		</Window.Resources>
		....
		<telerik:RadTreeView x:Name="radTreeView" 
							 IsOptionElementsEnabled="True"
							 IsTriStateMode="True"
							 ItemsSource="{StaticResource DataSource}" 
							 ItemTemplate="{StaticResource ItemTemplate}"/>
		```

	{% endif %}

* The final and most important step is to attach to the __ItemPrepared__ event of the __RadTreeView__.

	#### __XAML__

	```XAML
		<telerik:RadTreeView x:Name="radTreeView"
								   IsOptionElementsEnabled="True"
								   IsTriStateMode="True"
								   ItemsSource="{StaticResource DataSource}"
								   ItemTemplate="{StaticResource ItemTemplate}"
								   ItemPrepared="radTreeView_ItemPrepared"/>
		```

	Switch to the code-behind and in the event handler add a code, synchronizing the __CheckState__ property of the __RadTreeViewItem__ object with the __CheckState__ property of the __DataItem__ object.

	#### __C#__

	```C#
		private void radTreeView_ItemPrepared( object sender, Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs e )
		{
			e.PreparedItem.CheckState = ( e.PreparedItem.Item as DataItem ).CheckState;
		}
		```



	#### __VB.NET__

	```VB.NET
		Private Sub radTreeView_ItemPrepared(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs)
			e.PreparedItem.CheckState = TryCast(e.PreparedItem.Item, DataItem).CheckState
		End Sub
		```
		
* The example so far is almost complete. However, there are some drawbacks. The __RadTreeViewItem__'s __CheckState__ property is synchronized just once. If the user checks\unchecks a specific treeview item, the source object will not be updated. In order to solve this problem you should attach to the __RadTreeViewItem__'s __Checked__ and __Unchecked__ events.

	#### __C#__

	```C#
		private void radTreeView_ItemPrepared( object sender, Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs e )
		{
			e.PreparedItem.CheckState = ( e.PreparedItem.Item as DataItem ).CheckState;
			e.PreparedItem.Checked += new EventHandler<Telerik.Windows.RadRoutedEventArgs>( PreparedItem_Checked );
			e.PreparedItem.Unchecked += new EventHandler<Telerik.Windows.RadRoutedEventArgs>( PreparedItem_Unchecked );
		}
		
		void PreparedItem_Unchecked( object sender, Telerik.Windows.RadRoutedEventArgs e )
		{
			RadTreeViewItem item = sender as RadTreeViewItem;
			if ( item != null )
			{
				( item.Item as DataItem ).CheckState = System.Windows.Automation.ToggleState.Off;
			}
		}
		
		void PreparedItem_Checked( object sender, Telerik.Windows.RadRoutedEventArgs e )
		{
			RadTreeViewItem item = sender as RadTreeViewItem;
			if ( item != null )
			{
				( item.Item as DataItem ).CheckState = System.Windows.Automation.ToggleState.On;
			}
		}
		```

	#### __VB.NET__

	```VB.NET
		Private Sub radTreeView_ItemPrepared(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs)
			e.PreparedItem.CheckState = TryCast(e.PreparedItem.Item, DataItem).CheckState
			AddHandler e.PreparedItem.Checked, AddressOf PreparedItem_Checked
			AddHandler e.PreparedItem.Unchecked, AddressOf PreparedItem_Unchecked
		End Sub
		
		Private Sub PreparedItem_Unchecked(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			Dim item As RadTreeViewItem = TryCast(sender, RadTreeViewItem)
			If item IsNot Nothing Then
				TryCast(item.Item, DataItem).CheckState = System.Windows.Automation.ToggleState.Off
			End If
		End Sub
		
		Private Sub PreparedItem_Checked(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
			Dim item As RadTreeViewItem = TryCast(sender, RadTreeViewItem)
			If item IsNot Nothing Then
				TryCast(item.Item, DataItem).CheckState = System.Windows.Automation.ToggleState.[On]
			End If
		End Sub
		```

## See Also
 * [Events-Overview]({%slug radtreeview-events-overview%})