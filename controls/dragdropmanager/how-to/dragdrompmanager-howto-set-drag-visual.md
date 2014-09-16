---
title: Set Drag Visual
page_title: Set Drag Visual
description: Set Drag Visual
slug: dragdrompmanager-howto-set-drag-visual
tags: set,drag,visual
publish: True
position: 0
---

# Set Drag Visual



## 

DragDropManager enables you to define your own custom drag cue. This can be easily done by handling the [DragInitialize]({%slug dragdropmanager-events%}) event and defining the DragVisual. 

We will demonstrate this functionality implemented within a simple ListBox. For the purpose we need to execute the following steps:

1. Create a ListBox with ItemTemplate and implicit Style for the ListBox Items:

#### __XAML__

{{region dragdrompmanager-howto-set-drag-visual_0}}
	<Grid x:Name="LayoutRoot" Background="White">
	     <Grid.Resources>
	          <DataTemplate x:Name="ItemTemplate">
	              <Border Background="Orange">
	                  <TextBlock Text="{Binding}" />
	              </Border>
	          </DataTemplate>
	          <Style TargetType="ListBoxItem">
	              <Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True" />
	          </Style>
	      </Grid.Resources>
	      <ListBox x:Name="SampleListBox" ItemsSource="{Binding}" AllowDrop="True" 
	               ItemTemplate="{StaticResource ItemTemplate}" />
	</Grid>
	{{endregion}}





2. Bind ListBox to simple data and subscribe to DragInitialize event:

#### __C#__

{{region dragdrompmanager-howto-set-drag-visual_1}}
	public MainPage()
	{
	      InitializeComponent();
	      this.DataContext = new ObservableCollection<string>(from c in Enumerable.Range(0, 10) select "Item" + c);
	      DragDropManager.AddDragInitializeHandler(SampleListBox, OnDragInitialize);
	}
	{{endregion}}



#### __VB.NET__

{{region dragdrompmanager-howto-set-drag-visual_2}}
	Public Sub New()
	 InitializeComponent()
	 Me.DataContext = New ObservableCollection(Of String)(From c In Enumerable.Range(0, 10)"Item" & c)
	 DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized)) 
	End Sub
	{{endregion}}



3. Set suitable drag visual that will be displayed while dragging is performed:

#### __C#__

{{region dragdrompmanager-howto-set-drag-visual_3}}
	private void OnDragInitialize(object sender, DragInitializeEventArgs args)
	{
	    args.Data = ((FrameworkElement)args.OriginalSource).DataContext;
	    args.DragVisual = new ContentControl { ContentTemplate = this.LayoutRoot.Resources["ItemTemplate"] as DataTemplate, Content = args.Data };
	    args.AllowedEffects = DragDropEffects.All;
	    args.Handled = true;
	}
	{{endregion}}



#### __VB.NET__

{{region dragdrompmanager-howto-set-drag-visual_4}}
	    Private Sub OnDragInitialize(ByVal sender As Object, ByVal args As DragInitializeEventArgs)
	        args.Data = DirectCast(args.OriginalSource, FrameworkElement).DataContext
	        args.DragVisual = New ContentControl With {.ContentTemplate = TryCast(Me.LayoutRoot.Resources("ItemTemplate"), DataTemplate), .Content = args.Data}
	        args.AllowedEffects = DragDropEffects.All
	        args.Handled = True
	    End Sub
	{{endregion}}



On running the application, the following will be visualized:

![](images/DragDropManger_SetVisualCue.png)
