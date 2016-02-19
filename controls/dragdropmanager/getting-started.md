---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: dragdropmanager-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This article will demonstrate a basic implementation of the DragDropManager by dragging between two ListBoxes. 

>tipIn order to use DragDropManager you have to add reference to __Telerik.Windows.Controls__ assembly.          

Firstly, for the purpose of this tutorial we will create a business object ApplicationInfo, which will expose a couple of properties as well as a sample collection for populating the ListBoxes. The structure of the class used in this example is shown on the next code snippets:

#### __C#__

{{region dragdropmanager-getting-started_0}}
	public class ApplicationInfo
	{
		public Double Price
		{
			get;
			set;
		}
		public String IconPath
		{
			get;
			set;
		}
		public String Name
		{
			get;
			set;
		}
		public String Author
		{
			get;
			set;
		}
		public static ObservableCollection<ApplicationInfo> GenerateApplicationInfos()
		{
			ObservableCollection<ApplicationInfo> result = new ObservableCollection<ApplicationInfo>();
			ApplicationInfo info1 = new ApplicationInfo();
			info1.Name = "Large Collider";
			info1.Author = "C.E.R.N.";
			info1.IconPath = @"img/Atom.png";
			result.Add(info1);
			ApplicationInfo info2 = new ApplicationInfo();
			info2.Name = "Paintbrush";
			info2.Author = "Imagine Inc.";
			info2.IconPath = @"img/Brush.png";
			result.Add(info2);
			ApplicationInfo info3 = new ApplicationInfo();
			info3.Name = "Lively Calendar";
			info3.Author = "Control AG";
			info3.IconPath = @"img/CalendarEvents.png";
			result.Add(info3);
			ApplicationInfo info4 = new ApplicationInfo();
			info4.Name = "Fire Burning ROM";
			info4.Author = "The CD Factory";
			info4.IconPath = @"img/CDBurn.png";
			result.Add(info4);
			ApplicationInfo info5 = new ApplicationInfo();
			info5.Name = "Fav Explorer";
			info5.Author = "Star Factory";
			info5.IconPath = @"img/favorites.png";
			result.Add(info5);
			ApplicationInfo info6 = new ApplicationInfo();
			info6.Name = "IE Fox";
			info6.Author = "Open Org";
			info6.IconPath = @"img/Connected.png";
			result.Add(info6);
			ApplicationInfo info7 = new ApplicationInfo();
			info7.Name = "Charting";
			info7.Author = "AA-AZ inc";
			info7.IconPath = @"img/ChartDot.png";
			result.Add(info7);
			ApplicationInfo info8 = new ApplicationInfo();
			info8.Name = "SuperPlay";
			info8.Author = "EB Games";
			info8.IconPath = @"img/Games.png";
			result.Add(info8);
			return result;
		}
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-getting-started_1}}
	Public Class ApplicationInfo
	 Public Property Price() As [Double]
	  Get
	   Return m_Price
	  End Get
	  Set
	   m_Price = Value
	  End Set
	 End Property
	 Private m_Price As [Double]
	 Public Property IconPath() As [String]
	  Get
	   Return m_IconPath
	  End Get
	  Set
	   m_IconPath = Value
	  End Set
	 End Property
	 Private m_IconPath As [String]
	 Public Property Name() As [String]
	  Get
	   Return m_Name
	  End Get
	  Set
	   m_Name = Value
	  End Set
	 End Property
	 Private m_Name As [String]
	 Public Property Author() As [String]
	  Get
	   Return m_Author
	  End Get
	  Set
	   m_Author = Value
	  End Set
	 End Property
	 Private m_Author As [String]
	 Public Shared Function GenerateApplicationInfos() As ObservableCollection(Of ApplicationInfo)
	  Dim result As New ObservableCollection(Of ApplicationInfo)()
	  Dim info1 As New ApplicationInfo()
	  info1.Name = "Large Collider"
	  info1.Author = "C.E.R.N."
	  info1.IconPath = "img/Atom.png"
	  result.Add(info1)
	  Dim info2 As New ApplicationInfo()
	  info2.Name = "Paintbrush"
	  info2.Author = "Imagine Inc."
	  info2.IconPath = "img/Brush.png"
	  result.Add(info2)
	  Dim info3 As New ApplicationInfo()
	  info3.Name = "Lively Calendar"
	  info3.Author = "Control AG"
	  info3.IconPath = "img/CalendarEvents.png"
	  result.Add(info3)
	  Dim info4 As New ApplicationInfo()
	  info4.Name = "Fire Burning ROM"
	  info4.Author = "The CD Factory"
	  info4.IconPath = "img/CDBurn.png"
	  result.Add(info4)
	  Dim info5 As New ApplicationInfo()
	  info5.Name = "Fav Explorer"
	  info5.Author = "Star Factory"
	  info5.IconPath = "img/favorites.png"
	  result.Add(info5)
	  Dim info6 As New ApplicationInfo()
	  info6.Name = "IE Fox"
	  info6.Author = "Open Org"
	  info6.IconPath = "img/Connected.png"
	  result.Add(info6)
	  Dim info7 As New ApplicationInfo()
	  info7.Name = "Charting"
	  info7.Author = "AA-AZ inc"
	  info7.IconPath = "img/ChartDot.png"
	  result.Add(info7)
	  Dim info8 As New ApplicationInfo()
	  info8.Name = "SuperPlay"
	  info8.Author = "EB Games"
	  info8.IconPath = "img/Games.png"
	  result.Add(info8)
	  Return result
	 End Function
	End Class
{{endregion}}

Then we need to define our ListBoxes with suitable ItemTemplates. We also enable dragging the ListBoxItems (through style) and allow drop to each of the ListBoxes (through setting AllowDrop property):

{% if site.site_name == 'Silverlight' %}

#### __XAML__
{{region dragdropmanager-getting-started_2}}
	<Grid x:Name="LayoutRoot" Background="White">
	      <Grid.Resources>
	          <Style TargetType="ListBoxItem">
	              <Setter Property="telerik:DragDropManager.AllowDrag" Value="True"></Setter>
	          </Style>
	          <DataTemplate x:Key="ApplicationTemplate">
	              <StackPanel Orientation="Horizontal">
	                  <Image Source="{Binding IconPath}"/>
	                  <TextBlock Margin="5" Text="{Binding Name}" VerticalAlignment="Center"></TextBlock>
	              </StackPanel>
	          </DataTemplate>
	       </Grid.Resources>
	       <Grid.ColumnDefinitions>
	           <ColumnDefinition></ColumnDefinition>
	           <ColumnDefinition></ColumnDefinition>
	       </Grid.ColumnDefinitions>
	       <ListBox x:Name="ApplicationList" ItemTemplate="{StaticResource ApplicationTemplate}" AllowDrop="True"/>
	       <ListBox x:Name="MyAppList" Background="Gray" Grid.Column="1"  
	                ItemTemplate="{StaticResource ApplicationTemplate}" AllowDrop="True"/>
	</Grid>
{{endregion}}

{% endif %}
{% if site.site_name == 'WPF' %}

#### __XAML__

{{region dragdropmanager-getting-started_13}}
	<Grid x:Name="LayoutRoot" Background="White">
	      <Grid.Resources>
	          <Style TargetType="ListBoxItem">
	              <Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True"></Setter>
	          </Style>
	          <DataTemplate x:Key="ApplicationTemplate">
	              <StackPanel Orientation="Horizontal">
	                  <Image Source="{Binding IconPath}"/>
	                  <TextBlock Margin="5" Text="{Binding Name}" VerticalAlignment="Center"></TextBlock>
	              </StackPanel>
	          </DataTemplate>
	       </Grid.Resources>
	       <Grid.ColumnDefinitions>
	           <ColumnDefinition></ColumnDefinition>
	           <ColumnDefinition></ColumnDefinition>
	       </Grid.ColumnDefinitions>
	       <ListBox x:Name="ApplicationList" ItemTemplate="{StaticResource ApplicationTemplate}" AllowDrop="True"/>
	       <ListBox x:Name="MyAppList" Background="Gray" Grid.Column="1"  
	                ItemTemplate="{StaticResource ApplicationTemplate}" AllowDrop="True"/>
	</Grid>
{{endregion}}

{% endif %}

>To use the DragDropManager and its components in XAML you have to declare the following namespace:
>	*xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"*

Afterwards we need to set the ItemsSource of the controls:

#### __C#__

{{region dragdropmanager-getting-started_3}}
	ApplicationList.ItemsSource = ApplicationInfo.GenerateApplicationInfos();
	MyAppList.ItemsSource = new ObservableCollection<ApplicationInfo>();
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-getting-started_4}}
	ApplicationList.ItemsSource = ApplicationInfo.GenerateApplicationInfos()
	MyAppList.ItemsSource = New ObservableCollection(Of ApplicationInfo)()
{{endregion}}

Now, we need to attach Drag-Drop event handlers:

#### __C#__

{{region dragdropmanager-getting-started_5}}
	DragDropManager.AddDragInitializeHandler(ApplicationList, OnDragInitialize);
	DragDropManager.AddDragInitializeHandler(MyAppList, OnDragInitialize);
	
	DragDropManager.AddGiveFeedbackHandler(ApplicationList, OnGiveFeedback);
	DragDropManager.AddGiveFeedbackHandler(MyAppList, OnGiveFeedback);
	
	DragDropManager.AddDragDropCompletedHandler(ApplicationList, OnDragCompleted);
	DragDropManager.AddDragDropCompletedHandler(MyAppList, OnDragCompleted);
	
	DragDropManager.AddDropHandler(ApplicationList, OnDrop);
	DragDropManager.AddDropHandler(MyAppList, OnDrop);	
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-getting-started_6}}
	DragDropManager.AddDragInitializeHandler(ApplicationList, New DragInitializeEventHandler(AddressOf OnDragInitialize))
	DragDropManager.AddDragInitializeHandler(MyAppList, New DragInitializeEventHandler(AddressOf OnDragInitialize))
	
	DragDropManager.AddGiveFeedbackHandler(ApplicationList, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
	DragDropManager.AddGiveFeedbackHandler(MyAppList, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
	
	DragDropManager.AddDragDropCompletedHandler(ApplicationList, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
	DragDropManager.AddDragDropCompletedHandler(MyAppList, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
	
	DragDropManager.AddDropHandler(ApplicationList, New DragEventHandler(AddressOf OnDrop))
	DragDropManager.AddDropHandler(MyAppList, New DragEventHandler(AddressOf OnDrop))	
{{endregion}}

Then on DragInitialize we define the data that will be dragged as well as the visual representation. We also set DragDropEffects to all to allow drop on all scenarios.

#### __C#__

{{region dragdropmanager-getting-started_7}}
	private void OnDragInitialize(object sender, DragInitializeEventArgs args)
	{
	    args.AllowedEffects = DragDropEffects.All;
	    var payload = DragDropPayloadManager.GeneratePayload(null);
	    var data = ((FrameworkElement)args.OriginalSource).DataContext;
	    payload.SetData("DragData", data);
	    args.Data = payload;
	    args.DragVisual = new ContentControl { Content = data, ContentTemplate = LayoutRoot.Resources["ApplicationTemplate"] as DataTemplate };
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-getting-started_8}}
	Private Sub OnDragInitialize(ByVal sender As Object, ByVal args As DragInitializeEventArgs)
		args.AllowedEffects = DragDropEffects.All
		Dim payload = DragDropPayloadManager.GeneratePayload(Nothing)
		Dim data = CType(args.OriginalSource, FrameworkElement).DataContext
		payload.SetData("DragData", data)
		args.Data = payload
		args.DragVisual = New ContentControl With {.Content = data, .ContentTemplate = TryCast(LayoutRoot.Resources("ApplicationTemplate"), DataTemplate)}
	End Sub
{{endregion}}

We also set mouse cursor to be arrow:

#### __C#__

{{region dragdropmanager-getting-started_9}}
	private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
	{
	    args.SetCursor(Cursors.Arrow);
	    args.Handled = true;
	}
{{endregion}}


#### __VB.NET__

{{region dragdropmanager-getting-started_10}}
	Private Sub OnGiveFeedback(sender As Object, args As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
	 args.SetCursor(Cursors.Arrow)
	 args.Handled = True
	End Sub
{{endregion}}

Finally, we add logic, that will be executed when drag and drop operations finish:

{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region dragdropmanager-getting-started_11}}
	private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
	{
	    var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
	    ((IList)(sender as ListBox).ItemsSource).Add(data);
	}
	
	public void OnDragCompleted(object sender, Telerik.Windows.DragDrop.DragDropCompletedEventArgs args)
	{
	    var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
	    ((IList)(sender as ListBox).ItemsSource).Remove(data);
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-getting-started_12}}
	Private Sub OnDrop(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragEventArgs)
		Dim data = CType(args.Data, DataObject).GetData("DragData")
		CType((TryCast(sender, ListBox)).ItemsSource, IList).Add(data)
	End Sub
	
	Public Sub OnDragDropCompleted(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragDropCompletedEventArgs)
		Dim data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData")
		CType((TryCast(sender, ListBox)).ItemsSource, IList).Remove(data)
	End Sub
{{endregion}}

{% endif %}
{% if site.site_name == 'WPF' %}

#### __C#__

{{region dragdropmanager-getting-started_13}}
	private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
	{
	    var data = ((DataObject)args.Data).GetData("DragData");
	    ((IList)(sender as ListBox).ItemsSource).Add(data);
	}
	
	public void OnDragCompleted(object sender, Telerik.Windows.DragDrop.DragDropCompletedEventArgs args)
	{
	    var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
	    ((IList)(sender as ListBox).ItemsSource).Remove(data);
	}
{{endregion}}

#### __VB.NET__

{{region dragdropmanager-getting-started_14}}
	Private Sub OnDrop(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragEventArgs)
		Dim data = CType(args.Data, DataObject).GetData("DragData")
		CType((TryCast(sender, ListBox)).ItemsSource, IList).Add(data)
	End Sub
	
	Public Sub OnDragCompleted(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragDropCompletedEventArgs)
		Dim data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData")
		CType((TryCast(sender, ListBox)).ItemsSource, IList).Remove(data)
	End Sub
{{endregion}}

{% endif %}

![](images/DragDropManager_DragBetweenListBoxes.png)
