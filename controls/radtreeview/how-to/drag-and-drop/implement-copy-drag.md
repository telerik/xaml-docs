---
title: Implement Copy Drag
page_title: Implement Copy Drag
description: Check our &quot;Implement Copy Drag&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-how-to-implement-copy-drag
tags: implement,copy,drag
published: True
position: 5
---

# Implement Copy Drag

The purpose of this tutorial is to show you how to implement "Copy Drag".

## Copy Item When Dragging from One TreeView to Another 

Using the new __DragDrop__ mode, you can control the __DropAction__ of a drop operation. You can do so through the __TreeViewDragDropOptions__ object as described in the [DragDrop]({%slug radtreeview-features-drag-and-drop%}) tutorial.		

In this section you will see how to implement copy drag, when dragging items from one data-bound treeview to another. On the next figure you can see the initial staging. 
![Rad Tree View-DnDCopy Tree To Tree](images/RadTreeView-DnDCopyTreeToTree.png)

There are two treeviews populated with some hierarchical data. On the left side is the source treeview (the one from which the items will be copied). On the right side is the target treeview (the one in which the items will be dropped).

>tip Both __RadTreeViews__ are data bound to a collection of business objects. For more information, read the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) topic.		  

Here is the initial XAML: 

{% if site.site_name == 'Silverlight' %}
#### __XAML__

```XAML
	<Grid>
	    <Grid.Resources>
	        <sampleData:RadTreeViewSampleData x:Key="DataSource" />
	        <sampleData:RadTreeViewSecondSampleData x:Key="SecondDataSource" />
	
	        <DataTemplate x:Key="Team">
	            <TextBlock Text="{Binding Name}" />
	        </DataTemplate>
	        <telerik:HierarchicalDataTemplate x:Key="Division"
	                                    ItemTemplate="{StaticResource Team}"
	                                    ItemsSource="{Binding Teams}">
	            <TextBlock Text="{Binding Name}" />
	        </telerik:HierarchicalDataTemplate>
	        <telerik:HierarchicalDataTemplate x:Key="League"
	                                    ItemTemplate="{StaticResource Division}"
	                                    ItemsSource="{Binding Divisions}">
	            <TextBlock Text="{Binding Name}" />
	        </telerik:HierarchicalDataTemplate>
	    </Grid.Resources>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition />
	        <ColumnDefinition />
	    </Grid.ColumnDefinitions>
	    <telerik:RadTreeView x:Name="xTreeView"
	                            Margin="8"
	                            IsDragDropEnabled="True"
	                            ItemTemplate="{StaticResource League}"
	                            ItemsSource="{Binding Source={StaticResource DataSource},
	                                                Path=LeaguesDataSource}" />
	    <telerik:RadTreeView x:Name="radTreeView2"
	                            Grid.Column="1"
	                            Margin="8"
	                            IsDragDropEnabled="True"
	                            ItemTemplate="{StaticResource League}"
	                            ItemsSource="{Binding Source={StaticResource SecondDataSource},
	                                                Path=DataSource}" />
	</Grid>
```

{% endif %}
{% if site.site_name == 'WPF' %}

#### __XAML__

```XAML
	<Grid>
	    <Grid.Resources>
	        <sampleData:RadTreeViewSampleData x:Key="DataSource" />
	       <sampleData:RadTreeViewSecondSampleData x:Key="SecondDataSource" />
	
	        <DataTemplate x:Key="Team">
	            <TextBlock Text="{Binding Name}" />
	        </DataTemplate>
	        <HierarchicalDataTemplate x:Key="Division"
	                                    ItemTemplate="{StaticResource Team}"
	                                    ItemsSource="{Binding Teams}">
	            <TextBlock Text="{Binding Name}" />
	        </HierarchicalDataTemplate>
	        <HierarchicalDataTemplate x:Key="League"
	                                    ItemTemplate="{StaticResource Division}"
	                                    ItemsSource="{Binding Divisions}">
	            <TextBlock Text="{Binding Name}" />
	        </HierarchicalDataTemplate>
	    </Grid.Resources>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition />
	        <ColumnDefinition />
	    </Grid.ColumnDefinitions>
	    <telerik:RadTreeView x:Name="xTreeView"
	                            Margin="8"
	                            IsDragDropEnabled="True"
	                            ItemTemplate="{StaticResource League}"
	                            ItemsSource="{Binding Source={StaticResource DataSource},
	                                                Path=LeaguesDataSource}" />
	    <telerik:RadTreeView x:Name="radTreeView2"
	                            Grid.Column="1"
	                            Margin="8"
	                            IsDragDropEnabled="True"
	                            ItemTemplate="{StaticResource League}"
	                            ItemsSource="{Binding Source={StaticResource SecondDataSource},
	                                                Path=DataSource}" />
	</Grid>
```

{% endif %}

In the current situation if you try to drag and drop from the left treeview to the right, the items will be moved (not copied). The same is valid if you try to drag and drop from the right treeview to the left. And in order to change that logic and implement a copy drag operation from the left to the right __RadTreeView__ you need to:

* Attach a __DragDropManager DragOver__ event handler for the right __RadTreeView__:

	#### __C#__

	```C#
		DragDropManager.AddDragOverHandler(radTreeView2, OnDragOver, true);
	```

	#### __VB.NET__

	```VB.NET
			DragDropManager.AddDragOverHandler(radTreeView2, OnDragOver, True)
	```

	>tip __RadTreeView__ handles internally the __DragDropManager__ events and in order to invoke a custom handler, you need to explicitly specify that you're adding a handler that should be invoked even for already handled events. This is done through the last - __bool__ argument of the __DragDropManager.AddDragOverHandler__ extension method.			  

* In the event handler you should use the following code:

	#### __C#__

	```C#
		private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
		{
			var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
			if (options != null)
			{
				options.DropAction = DropAction.Copy;
			}
		}
	```
		
	#### __VB.NET__

	```VB.NET
			Private Sub OnDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
				Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
				If options IsNot Nothing AndAlso TypeOf options.DropTargetItem.Items Is League Then
					options.DropAction = DropAction.Copy
				End If
			End Sub
	```

Here is the final result: 
![Rad Tree View-DnDCopy Tree Result](images/RadTreeView-DnDCopyTreeResult.png)

Now if you try to drag an item from the right __RadTreeView__ and drop it in the left tree, the item will be moved. This is due to the fact that we changed the __DropAction__ only while dragging over items of the right __RadTreeView__. If you need to implement a copy operation when dropping into the left __RadTreeView__, you'll have to attach an event handler for its __DragDropManager DragOver__ event as well:

#### __C#__

```C#
	DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, true)
```

#### __VB.NET__

```VB.NET
		DragDropManager.AddDragOverHandler(xTreeView, OnDragOver, True)
```

>tip If you try to implement the above approach on two declaratively defined __RadTreeView__ controls, you'll encounter an exception. This is due to the fact that the copy operation will try to add one object instance in two different __RadTreeView__ controls. And if you're working with visual objects, then this would raise an exception as you can't use the same visual object multiple times in the VisualTree of the application. Therefore in this case, you'll have to implement a custom copy operation that creates a new object copying the settings of the dragged __RadTreeViewItem__.		  

## Copy Item When Dragging Within the Same TreeView 

In this section you will see how to implement copy drag, when dragging items within the same __RadTreeView__. On the next figure you can see the initial staging.
![{{ site.framework_name }} RadTreeView Copy Item When Dragging Within the Same TreeView](images/RadTreeView_HowToImplementCopyDrag_040.png)

Here is a treeview populated with some hierarchical data. This is the initial XAML declaration: 

{% if site.site_name == 'Silverlight' %}
#### __XAML__

```XAML
	<Grid>
		<Grid.Resources>
			<sampleData:RadTreeViewSampleData x:Key="DataSource" />
	
			<DataTemplate x:Key="Team">
				<TextBlock Text="{Binding Name}" />
			</DataTemplate>
			<telerik:HierarchicalDataTemplate x:Key="Division"
									  ItemTemplate="{StaticResource Team}"
									  ItemsSource="{Binding Teams}">
				<TextBlock Text="{Binding Name}" />
			</telerik:HierarchicalDataTemplate>
			<telerik:HierarchicalDataTemplate x:Key="League"
									  ItemTemplate="{StaticResource Division}"
									  ItemsSource="{Binding Divisions}">
				<TextBlock Text="{Binding Name}" />
			</telerik:HierarchicalDataTemplate>
		</Grid.Resources>
		
		<telerik:RadTreeView x:Name="xTreeView"
							 Margin="8"
							 IsDragDropEnabled="True"
							 ItemTemplate="{StaticResource League}"
							 ItemsSource="{Binding Source={StaticResource DataSource},
												   Path=LeaguesDataSource}" />
	</Grid>
```

{% endif %}
{% if site.site_name == 'WPF' %}

#### __XAML__

```XAML
	<Grid>
		<Grid.Resources>
			<sampleData:RadTreeViewSampleData x:Key="DataSource" />
	
			<DataTemplate x:Key="Team">
				<TextBlock Text="{Binding Name}" />
			</DataTemplate>
			<HierarchicalDataTemplate x:Key="Division"
									  ItemTemplate="{StaticResource Team}"
									  ItemsSource="{Binding Teams}">
				<TextBlock Text="{Binding Name}" />
			</HierarchicalDataTemplate>
			<HierarchicalDataTemplate x:Key="League"
									  ItemTemplate="{StaticResource Division}"
									  ItemsSource="{Binding Divisions}">
				<TextBlock Text="{Binding Name}" />
			</HierarchicalDataTemplate>
		</Grid.Resources>
		
		<telerik:RadTreeView x:Name="xTreeView"
							 Margin="8"
							 IsDragDropEnabled="True"
							 ItemTemplate="{StaticResource League}"
							 ItemsSource="{Binding Source={StaticResource DataSource},
												   Path=LeaguesDataSource}" />
	</Grid>
```

{% endif %}

>tip The __RadTreeView__ is data bound to a collection of business objects. For more information, read the [Binding to Object]({%slug radtreeview-populating-with-data-data-binding-to-object%}) topic.

Before setting a copy __DropAction__ within one __RadTreeView__, you need to consider the fact that in the __RadTreeView__ once you add the same instance of an object, all item manipulation operations will be applied on every instance of the object found within the __RadTreeView__ control. This basically means that if you follow the approach described in the previous section of the article, you will get multiple __RadTreeViewItems__ wrapping the same object instance. Once you do so, you'll have to work with all items as one as the __RadTreeView__ can't differentiate them. If this is something you;d like to avoid, then you'll have to reconfigure the default __RadTreeView__ drag/drop operation to make a __real copy__ of the dragged item and drop the copy.

In order to implement a __real copy__ drag operation, you need to perform the following steps:

* Attach __DragDropManager Drop and DragDropCompleted__ handlers on the __RadTreeView__:

	#### __C#__

	```C#
		DragDropManager.AddDropHandler(xTreeView, OnDrop, true);
		DragDropManager.AddDragDropCompletedHandler(xTreeView, OnDragDropCompleted, true);
	```

	#### __VB.NET__

	```VB.NET
			DragDropManager.AddDropHandler(xTreeView, OnDrop, True)
			DragDropManager.AddDragDropCompletedHandler(xTreeView, OnDragDropCompleted, True)
	```

	>tip __RadTreeView__ handles internally the __DragDropManager__ events and in order to invoke a custom handler, you need to explicitly specify that you're adding a handler that should be invoked even for already handled events. This is done through the last - __bool__ argument of the __DragDropManager.AddDragOverHandler__ extension method.
			  

* In the __OnDrop__ event handler you should stop the drop operation. You can do so by setting the __DropAction__ to __None__:			

	#### __C#__

	```C#
		private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
		{
			var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
			if (options != null)
			{
				options.DropAction = DropAction.None;
			}
		}
	```

	#### __VB.NET__

	```VB.NET
		Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
			Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
			If options IsNot Nothing Then
				options.DropAction = DropAction.None
			End If
		End Sub
	```

* In the __OnDragDropCompleted__ event handler you should implement a custom drop operation. However, as this drop operation will have to create a __real copy__ of the dragged item, you will need to create methods to copy your objects. For example, here are sample methods which copy respectively the __Team__, the __Division__ and the __League__ objects:

	#### __C#__

	```C#
		private Team CopyTeam(Team team)
		{
			return new Team(team.Name);
		}
		
		private Division CopyDivision(Division division)
		{
			Division copyDivision = new Division(division.Name);
			foreach (Team team in division.Teams)
			{
				copyDivision.Teams.Add(this.CopyTeam(team));
			}
			return copyDivision;
		}
		
		private League CopyLeague(League league)
		{
			League copyLeague = new League(league.Name);
			foreach (Division division in league.Divisions)
			{
				copyLeague.Divisions.Add(this.CopyDivision(division));
			}
			return copyLeague;
		}
	```

	#### __VB.NET__

	```VB.NET
		Private Function CopyTeam(team As Team) As Team
			Return New Team(team.Name)
		End Function
		
		Private Function CopyDivision(division As Division) As Division
			Dim div As New Division(division.Name)
			For Each team As Team In division.Teams
				div.Teams.Add(Me.CopyTeam(team))
			Next
			Return div
		End Function
		
		Private Function CopyLeague(league As League) As League
			Dim l As New League(league.Name)
			For Each division As Division In league.Divisions
				l.Divisions.Add(Me.CopyDivision(division))
			Next
			Return l
		End Function
	```

* Next, you need to implement a custom drop operation in the __OnDragDropCompleted__ event handler. This means that you need to define a logic that tracks the type of the dragged item as well as the type of the drop destination to make sure that the drop is actually allowed. This logic will also have to track the __DropPosition__ to decide where to insert the __real copy__ of the dragged item.

	#### __C#__

	```C#
		private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
		{
			var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
			if (options != null)
			{
				var item = options.DraggedItems.FirstOrDefault();
				if (options.DropTargetItem != null)
				{
					if (item is Team)
					{
						if (options.DropPosition == Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is Division)
						{
							(options.DropTargetItem.Item as Division).Teams.Add(CopyTeam((Team)item));
						}
						else if (options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is Team)
						{
							Division parentDivision = options.DropTargetItem.ParentItem.Item as Division;
							switch (options.DropPosition)
							{
								case Telerik.Windows.Controls.DropPosition.After:
									parentDivision.Teams.Insert(options.DropTargetItem.Index + 1, CopyTeam((Team)item));
									break;
								case Telerik.Windows.Controls.DropPosition.Before:
									parentDivision.Teams.Insert(options.DropTargetItem.Index, CopyTeam((Team)item));
									break;
							}
						}
					}
					else if (item is Division)
					{
						if (options.DropPosition == Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is League)
						{
							(options.DropTargetItem.Item as League).Divisions.Add(CopyDivision((Division)item));
						}
						else if (options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is Division)
						{
							League parentLeague = options.DropTargetItem.ParentItem.Item as League;
							switch (options.DropPosition)
							{
								case Telerik.Windows.Controls.DropPosition.After:
									parentLeague.Divisions.Insert(options.DropTargetItem.Index + 1, CopyDivision((Division)item));
									break;
								case Telerik.Windows.Controls.DropPosition.Before:
									parentLeague.Divisions.Insert(options.DropTargetItem.Index, CopyDivision((Division)item));
									break;
							}
						}
					}
					else if (item is League)
					{
						if (options.DropTargetItem == null && options.DropTargetTree != null)
						{
							(options.DropTargetTree.ItemsSource as IList).Add(CopyLeague((League)item));
						}
						else if (options.DropPosition != Telerik.Windows.Controls.DropPosition.Inside && options.DropTargetItem.Item is League)
						{
							IList source = options.DropTargetItem.ParentTreeView.ItemsSource as IList;
							switch (options.DropPosition)
							{
								case Telerik.Windows.Controls.DropPosition.After:
									source.Insert(options.DropTargetItem.Index + 1, CopyLeague((League)item));
									break;
								case Telerik.Windows.Controls.DropPosition.Before:
									source.Insert(options.DropTargetItem.Index, CopyLeague((League)item));
									break;
							}
						}
					}
		
				}
			}
		}
	```

	#### __VB.NET__

	```VB.NET
			Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
			Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
			If options IsNot Nothing Then
				Dim item = options.DraggedItems.FirstOrDefault()
				If options.DropTargetItem IsNot Nothing Then
					If TypeOf item Is Team Then
						If options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is Division Then
							TryCast(options.DropTargetItem.Item, Division).Teams.Add(CopyTeam(DirectCast(item, Team)))
						ElseIf options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is Team Then
							Dim parentDivision As Division = TryCast(options.DropTargetItem.ParentItem.Item, Division)
							Select Case options.DropPosition
								Case Telerik.Windows.Controls.DropPosition.After
									parentDivision.Teams.Insert(options.DropTargetItem.Index + 1, CopyTeam(DirectCast(item, Team)))
									Exit Select
								Case Telerik.Windows.Controls.DropPosition.Before
									parentDivision.Teams.Insert(options.DropTargetItem.Index, CopyTeam(DirectCast(item, Team)))
									Exit Select
							End Select
						End If
					ElseIf TypeOf item Is Division Then
						If options.DropPosition = Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is League Then
							TryCast(options.DropTargetItem.Item, League).Divisions.Add(CopyDivision(DirectCast(item, Division)))
						ElseIf options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is Division Then
							Dim parentLeague As League = TryCast(options.DropTargetItem.ParentItem.Item, League)
							Select Case options.DropPosition
								Case Telerik.Windows.Controls.DropPosition.After
									parentLeague.Divisions.Insert(options.DropTargetItem.Index + 1, CopyDivision(DirectCast(item, Division)))
									Exit Select
								Case Telerik.Windows.Controls.DropPosition.Before
									parentLeague.Divisions.Insert(options.DropTargetItem.Index, CopyDivision(DirectCast(item, Division)))
									Exit Select
							End Select
						End If
					ElseIf TypeOf item Is League Then
						If options.DropTargetItem Is Nothing AndAlso options.DropTargetTree IsNot Nothing Then
							TryCast(options.DropTargetTree.ItemsSource, IList).Add(CopyLeague(DirectCast(item, League)))
						ElseIf options.DropPosition <> Telerik.Windows.Controls.DropPosition.Inside AndAlso TypeOf options.DropTargetItem.Item Is League Then
							Dim source As IList = TryCast(options.DropTargetItem.ParentTreeView.ItemsSource, IList)
							Select Case options.DropPosition
								Case Telerik.Windows.Controls.DropPosition.After
									source.Insert(options.DropTargetItem.Index + 1, CopyLeague(DirectCast(item, League)))
									Exit Select
								Case Telerik.Windows.Controls.DropPosition.Before
									source.Insert(options.DropTargetItem.Index, CopyLeague(DirectCast(item, League)))
									Exit Select
							End Select
						End If
		
					End If
				End If
			End If
		End Sub		
	```

With this the __real copy DragDrop__ implementation is ready. The final result can be seen on the next snapshots.		

Copy Team: 
![Rad Tree View-DnDCopy Team](images/RadTreeView-DnDCopyTeam.png)

Copy Division: 
![Rad Tree View-DnDCopy Division](images/RadTreeView-DnDCopyDivision.png)

Copy League: 
![Rad Tree View-DnDCopy League](images/RadTreeView-DnDCopyLeague.png)

You can further customize this solution by applying a logic that determines the __DropAction__ based on the type of the item the drag operation is currently over:		

#### __C#__

```C#
	private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
	    var options = DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key) as TreeViewDragDropOptions;
	    if (options != null)
	    {
	        options.DropAction = DropAction.None;
	    }
	}
```

#### __VB.NET__

```VB.NET
	Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
		Dim options = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
		If options IsNot Nothing Then
			options.DropAction = DropAction.None
		End If
	End Sub
```

## See Also
 * [Drag and Drop]({%slug radtreeview-features-drag-and-drop%})
 * [Implement Drag and Drop Between TreeView and ListBox]({%slug radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox%})
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Auto Expand on Drag Over]({%slug radtreeview-how-to-enable-auto-expand-drag-over%})