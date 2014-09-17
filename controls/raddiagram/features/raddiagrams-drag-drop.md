---
title: Drag and Drop Support
page_title: Drag and Drop Support
description: Drag and Drop Support
slug: raddiagrams-features-drag-drop
tags: drag,and,drop,support
published: True
position: 4
---

# Drag and Drop Support



This article will get you familiar with the __RadDiagram__ drag/drop support.
            

The __RadDiagram__ framework supports drag/drop operations out-of-the-box for a list of scenarios. For every scenario outside that list, it allows you to easily define your custom drop logic.
            

## Enable Drag/Drop

To allow drag and drop functionality in the __RadDiagram__, set the __AllowDrop__ attribute to __True__.
                

#### __XAML__

{{region raddiagrams-features-drag-drop-0}}
	<telerik:RadDiagram x:Name="xDiagram" AllowDrop="True">
	    
	</telerik:RadDiagram>	
	{{endregion}}



The drag and drop behavior can be enabled in the code-behind as well. In order to do that you need to set the __AllowDrop__ property of an instance of the __RadDiagram__ class to __True__.
                

#### __C#__

{{region raddiagrams-features-drag-drop-0}}
	xDiagram.AllowDrop = true;
	{{endregion}}



#### __VB.NET__





>tipPlease note that the __RadDiagram AllowDrop__ property is set to __True__ by default.
                    

## Automatically Supported Drop Operations

The __RadDiagram__ framework allows you to drop:
                

* __Image Files__ - You can just drag and drop onto the Diagramming surface any image file from the following list of supported formats:
                        

* JPEG(*.jpg)

* PNG(*.png){% if site.site_name == 'WPF' %}

* BMP(*.bmp)

* TIFF(*.tiff)

* GIF(*.gif){% endif %}

* __Text Files__ - You can drag __.TXT__ files directly onto the diagramming surface to create text shapes. The operation will take the content of the __.TXT__ file and will place it as a content of a text shape.
                        

* __Text__ - You can drag chunks of text from your documents onto the diagramming surface directly.
                        

* __Serialization XML string__ - You can drag the serialization xml string of a __RadDiagram__ native element. You can find more information on how to serialize the __RadDiagram__ native elements in an XML string, please have a look at the [Serialization]({%slug raddiagrams-features-serialization%}) topic.
                        

## Custom Drop Operations

By default, the __RadDiagram__ can handle drop operations out-of-the-box as long as the dropped data represents a serialized __RadDiagramItem__. This is why if you create an __ItemsControl__ containing a list of __RadDiagramItems__, you will only have to set the dragged data to represent a serialized __RadDiagramItem__. However, if you have an __ItemsControl__ displaying custom business data, then you will have to manually configure how to drag and drop the business items.
                

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the
                        {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}
                        article you can find more information on how to set an application-wide theme.
                    

### Dragging RadDiagramShapes from an ItemsControl

Let's examine a scenario where you create a __ListBox__ populated with __RadDiagramShapes__ and a __RadDiagram__ component next to it:
                        

#### __XAML__

{{region raddiagrams-features-drag-drop-1}}
	<Grid>
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="Auto" />
	        <ColumnDefinition Width="*" />
	    </Grid.ColumnDefinitions>
	    <ListBox x:Name="xListBox">
	        <telerik:RadDiagramShape Width="120" 
	                                    Height="50"
	                                    Content="Shape 1" />
	        <telerik:RadDiagramShape Width="120"
	                                    Height="50"
	                                    Content="Shape 2"
	                                    Geometry="{telerik:CommonShape ShapeType=CloudShape}" />
	        <telerik:RadDiagramShape Width="120"
	                                    Height="50" 
	                                    Content="Shape 3"
	                                    Geometry="{telerik:CommonShape ShapeType=EllipseShape}" />
	        <telerik:RadDiagramShape Width="120"
	                                    Height="50" 
	                                    Content="Shape 4"
	                                    Geometry="{telerik:CommonShape ShapeType=PentagonShape}" />
	    </ListBox>
	    <telerik:RadDiagram x:Name="xDiagram" Grid.Column="1" />
	</Grid>	 
	{{endregion}}



In order to allow a drag of a __ListBoxItem__, you need to apply a style that makes the __ListBoxItems__ draggable:
                        

#### __XAML__

{{region raddiagrams-features-drag-drop-2}}
	<Style TargetType="ListBoxItem">
	    <Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True"/>
	</Style>
	{{endregion}}

![Rad Diagram Features DnD Shapes](images/RadDiagram_Features_DnD_Shapes.png)

In this scenario, the __RadDiagram__ instance can automatically handle the drop of the __RadDiagramShapes__ as long as they are serialized. In order to serialize them you need to create a handler for the __ListBox DragDropManager.DragInitialized__ event:
                        

#### __C#__

{{region raddiagrams-features-drag-drop-1}}
	
	public DragDropExample()
	{
	    InitializeComponent();
	    DragDropManager.AddDragInitializeHandler(xListBox, OnDragInitialize);
	}
	
	//ListBox OnDragInitialize method implementation
	private void OnDragInitialize(object sender, DragInitializeEventArgs args)
	{
	    args.AllowedEffects = DragDropEffects.All;
	    RadDiagramShape draggedShape = (args.OriginalSource as ListBoxItem).Content as RadDiagramShape;
	    List<RadDiagramShape> shapes = new List<RadDiagramShape>();
	    shapes.Add(draggedShape);
	    SerializationInfo serializaedInfo = SerializationService.Default.SerializeItems(shapes);
	    args.Data = serializaedInfo;
	}
	{{endregion}}



#### __VB.NET__



![Rad Diagram Features DnD Shapes Drag](images/RadDiagram_Features_DnD_Shapes_Drag.png)

In the above example you can drag an entire __ListBoxItem__ but you may need to only drag the __RadDiagramShape__ contained within the item. In that case, you will have to create a custom style targeting the __RadDiagramShapes__ within the __ListBox__ control. Please note that you have to apply this style only on those shapes defined within the __ListBox__ control.
                        

#### __XAML__

{{region raddiagrams-features-drag-drop-3}}
	<ListBox x:Name="xListBox">
	    <ListBox.Resources>
	        <Style TargetType="telerik:RadDiagramShape" x:Key="DraggableShapeStyle">
	            <Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True"/>
	        </Style>
	    </ListBox.Resources>
	    <telerik:RadDiagramShape Width="120"
	                    Height="50"
	                    Content="Shape 1"
	                    Style="{StaticResource DraggableShapeStyle}" />
	    <telerik:RadDiagramShape Width="120"
	                    Height="50"
	                    Content="Shape 2"
	                    Geometry="{telerik:CommonShape ShapeType=CloudShape}"
	                    Style="{StaticResource DraggableShapeStyle}" />
	    <telerik:RadDiagramShape Width="120"
	                    Height="50"
	                    Content="Shape 3"
	                    Geometry="{telerik:CommonShape ShapeType=EllipseShape}"
	                    Style="{StaticResource DraggableShapeStyle}" />
	    <telerik:RadDiagramShape Width="120"
	                    Height="50"
	                    Content="Shape 4"
	                    Geometry="{telerik:CommonShape ShapeType=PentagonShape}"
	                    Style="{StaticResource DraggableShapeStyle}" />
	</ListBox>
	{{endregion}}



And you will also have to slightly modify the __OnDragInitialize()__ implementation as it now looks for a __ListBoxItem__ as its __OriginalSource__. Once the __ListBoxItems__ aren't marked as draggable and only the shapes are defined as such, the __OriginalSource__ of the event will be a shape instance.
                        

#### __C#__

{{region raddiagrams-features-drag-drop-2}}
	public DragDropExample()
	{
	    InitializeComponent();
	    DragDropManager.AddDragInitializeHandler(xListBox, OnDragInitialize);
	}
	
	//ListBox OnDragInitialize method implementation
	private void OnDragInitialize(object sender, DragInitializeEventArgs args)
	{
	    args.AllowedEffects = DragDropEffects.All;
	   RadDiagramShape draggedShape = args.OriginalSource as RadDiagramShape;
	    List<RadDiagramShape> shapes = new List<RadDiagramShape>();
	    shapes.Add(draggedShape);
	    SerializationInfo serializaedInfo = SerializationService.Default.SerializeItems(shapes);
	    args.Data = serializaedInfo;
	}
	{{endregion}}



#### __VB.NET__





### Dragging business data from an ItemsControl

In MVVM scenarios, the business data is usually displayed within __ItemsControls__. And if you need to drag the items of these controls and drop them on a diagramming surface, you need to customize the drag/drop operations on both sides - in the source of the drag and in the targeted __RadDiagram__.
                        

For the purpose of this tutorial, we will examine a sample scenario describing how to implement a drag operation from a __ListBox__ control to a __RadDiagram__. Our goal would be to create a __RadDiagramShape__ to wrap the dragged data.
                        

* First, let's create a sample data source for the __ListBox__:
                                

#### __C#__

{{region raddiagrams-features-drag-drop-3}}
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
	}
	public class MainViewModel
	{
	    private ObservableCollection<ApplicationInfo> allApplications = GenerateApplicationInfos();
	
	    public ObservableCollection<ApplicationInfo> AllApplications
	    {
	        get
	        {
	            return this.allApplications;
	        }
	        set
	        {
	            this.allApplications = value;
	        }
	    }
	
	    public static ObservableCollection<ApplicationInfo> GenerateApplicationInfos()
	    {
	        ObservableCollection<ApplicationInfo> result = new ObservableCollection<ApplicationInfo>();
	
	        ApplicationInfo info1 = new ApplicationInfo();
	        info1.Name = "Large Collider";
	        info1.Author = "C.E.R.N.";
	        info1.IconPath = @"Images/Atom.png";
	        result.Add(info1);
	
	        ApplicationInfo info2 = new ApplicationInfo();
	        info2.Name = "Paintbrush";
	        info2.Author = "Imagine Inc.";
	        info2.IconPath = @"Images/Brush.png";
	        result.Add(info2);
	
	        ApplicationInfo info3 = new ApplicationInfo();
	        info3.Name = "Lively Calendar";
	        info3.Author = "Control AG";
	        info3.IconPath = @"Images/CalendarEvents.png";
	        result.Add(info3);
	
	        ApplicationInfo info4 = new ApplicationInfo();
	        info4.Name = "Fire Burning ROM";
	        info4.Author = "The CD Factory";
	        info4.IconPath = @"Images/CDBurn.png";
	        result.Add(info4);
	
	        ApplicationInfo info5 = new ApplicationInfo();
	        info5.Name = "Fav Explorer";
	        info5.Author = "Star Factory";
	        info5.IconPath = @"Images/favorites.png";
	        result.Add(info5);
	
	        return result;
	    }
	}
	{{endregion}}



#### __VB.NET__





* Now that we have defined our __MainViewModel__class, we can use it as a __DataContext__ of our main view:
                                {% if site.site_name == 'WPF' %}

	
<Window.DataContext>
    <local:MainViewModel />
</Window.DataContext>			  
			  

{% endif %}{% if site.site_name == 'Silverlight' %}

	
<UserControl.DataContext>
    <local:MainViewModel />
</UserControl.DataContext>			  
			  

{% endif %}

>The *local* alias points to the namespace where the __MainViewModel__ class is defined.
                                    

* Next we can set up our layout. We will need a __ListBox__ definition and a __RadDiagram__ definition. Also, as we have to allow drag/drop operations between them, we need to apply the __DragDropManager.AllowCapturedDrag__ attached property on the __ListBoxItems__ and we can set the __AllowDrop__ property to __True__ in the __RadDiagram__ definition.
                                

#### __XAML__

{{region raddiagrams-features-drag-drop-4}}
	 <Grid>
	        <Grid.ColumnDefinitions>
	            <ColumnDefinition Width="200" />
	            <ColumnDefinition Width="*" />
	        </Grid.ColumnDefinitions>
	        <ListBox x:Name="xListBox"
	                 Margin="0,0,3,0"
	                 Background="Transparent"
	                 BorderBrush="Transparent"
	                 BorderThickness="0"
	                 ItemsSource="{Binding AllApplications}"
	                 telerik:StyleManager.Theme="Windows8">
	            <ListBox.ItemContainerStyle>
	                <Style TargetType="ListBoxItem">
	                    <Setter Property="telerik:DragDropManager.AllowCapturedDrag" Value="True" />
	                </Style>
	            </ListBox.ItemContainerStyle>
	            <ListBox.ItemTemplate>
	                <DataTemplate>
	                    <Grid Width="150">
	                        <Grid.RowDefinitions>
	                            <RowDefinition />
	                            <RowDefinition />
	                            <RowDefinition />
	                        </Grid.RowDefinitions>
	                        <Image Grid.Row="0"
	                               Width="32"
	                               Height="32"
	                               Margin="0 0 5 0"
	                               HorizontalAlignment="Center"
	                               Source="{Binding IconPath}" />
	                        <TextBlock Grid.Row="1"
	                                   HorizontalAlignment="Center"
	                                   FontWeight="Bold"
	                                   Text="{Binding Name}" />
	                        <TextBlock Grid.Row="2"
	                                   HorizontalAlignment="Center"
	                                   Text="{Binding Author}" />
	                    </Grid>
	                </DataTemplate>
	            </ListBox.ItemTemplate>
	        </ListBox>
	
	        <telerik:RadDiagram x:Name="xDiagram"
	                            Grid.Column="2"
	                            AllowDrop="True" />
	</Grid>
	{{endregion}}



* As the layout is all in place, we can go ahead and start implementing our dragging logic. For that purpose, we need to decide how to interpret the dragged items and what to pass as the __Data__ of the drag operation. We can implement this logic in the __DragInitialize__ event handler:
                                

#### __C#__

{{region raddiagrams-features-drag-drop-4}}
	public DragDropExample()
	{
	    InitializeComponent();
	    DragDropManager.AddDragInitializeHandler(xListBox, OnDragInitialize);
	}
	
	//ListBox OnDragInitialize method implementation
	private void OnDragInitialize(object sender, DragInitializeEventArgs args)
	{
	    args.AllowedEffects = DragDropEffects.All;
	    args.Data = ((FrameworkElement)args.OriginalSource).DataContext;
	    args.DragVisual = new ContentControl { Content = args.Data, ContentTemplate = this.Resources["ApplicationTemplate"] as DataTemplate };
	}
	{{endregion}}



#### __VB.NET__



And the __ApplicationTemplate__ definition should be in the __Resources__ section of our view:
                                {% if site.site_name == 'WPF' %}

#### __XAML__

{{region raddiagrams-features-drag-drop-5}}
	    <Window.Resources>
	        <DataTemplate x:Key="ApplicationTemplate">
	            <StackPanel Orientation="Horizontal">
	                <Image Source="{Binding IconPath}" Stretch="None" />
	                <TextBlock Margin="5"
	                           VerticalAlignment="Center"
	                           Text="{Binding Name}" />
	            </StackPanel>
	        </DataTemplate>
	    </Window.Resources>	
	{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region raddiagrams-features-drag-drop-6}}
	    <UserControl.Resources>
	        <DataTemplate x:Key="ApplicationTemplate">
	            <StackPanel Orientation="Horizontal">
	                <Image Source="{Binding IconPath}" Stretch="None" />
	                <TextBlock Margin="5"
	                           VerticalAlignment="Center"
	                           Text="{Binding Name}" />
	            </StackPanel>
	        </DataTemplate>
	    </UserControl.Resources>
	{{endregion}}

{% endif %}

>tipYou can find more information about the features and events of the __DragDropManager__ in
                                        {% if site.site_name == 'WPF' %}[its documentation](http://www.telerik.com/help/wpf/dragdropmanager-getting-started.html){% endif %}{% if site.site_name == 'Silverlight' %}[its documentation](http://www.telerik.com/help/silverlight/dragdropmanager-getting-started.html){% endif %}.
                                    

* Finally, we need to customize the __RadDiagram__ drop logic to create a __RadDiagramShape__ to wrap the dragged data. We can also apply a __Position__ property on the __RadDiagramShape__ to reflect the exact position of the mouse during the drop.
                                

>tipThe easiest way to get the position of the mouse in the __Drop__ event handler is through the __DragEventsArgs GetPosition()__ method. However, as __RadDiagram__ supports different scaling operations (pan, zoom), you need to get the coordinates of the drop target point in the context of the __RadDiagram__. For that purpose you can use the __RadDiagram GetTransformedPoint__ extension method. It takes a point, applies any pan and/or zoom settings defined by the __RadDiagram__ current state and returns a point, transformed in the context of the diagram. This allows you to correctly position a __RadDiagramItem__ in a panned or zoomed diagramming surface.
                                    Please note that the __GetTransformedPoint()__ extension method is defined in the __Telerik.Windows.Controls.Diagrams__ namespace so you need to include this namespace in your class definition before getting advantage of the method.
                                    {% if site.site_name == 'Silverlight' %}

#### __C#__

{{region raddiagrams-features-drag-drop-5}}
	public DragDropExample()
	{
	    InitializeComponent();
	    DragDropManager.AddDropHandler(this.xDiagram, OnDiagramDrop);
	}
	
	private void OnDiagramDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
	    e.Handled = true;
	    RadDiagramShape shape = new RadDiagramShape();
	    shape.Content = e.Data is ApplicationInfo ? (e.Data as ApplicationInfo).Name : e.Data.ToString();
	    var currentPosition = xDiagram.GetTransformedPoint(e.GetPosition(xDiagram));
	    shape.Position = new Point(currentPosition.X, currentPosition.Y);
	
	    this.xDiagram.AddShape(shape);
	}
	{{endregion}}



#### __VB.NET__



{% endif %}{% if site.site_name == 'WPF' %}

#### __C#__

{{region raddiagrams-features-drag-drop-6}}
	public DragDropExample()
	{
	    InitializeComponent();
	    DragDropManager.AddDropHandler(this.xDiagram, OnDiagramDrop);
	}
	
	private void OnDiagramDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
	{
	    e.Handled = true;
	    RadDiagramShape shape = new RadDiagramShape();
	    ApplicationInfo draggedData = (e.Data as DataObject).GetData(typeof(ApplicationInfo)) as ApplicationInfo;
	    shape.Content = draggedData != null ? draggedData.Name : e.Data.ToString();
	    var currentPosition = xDiagram.GetTransformedPoint(e.GetPosition(xDiagram));
	    shape.Position = new Point(currentPosition.X, currentPosition.Y);
	
	    this.xDiagram.AddShape(shape);
	}
	{{endregion}}



#### __VB.NET__



{% endif %}Please note that we've set the __Position__ property of the __RadDiagramShape__

>Please note that you have to handle the __Drop__ event in order to stop its default logic and implement your own instead.
                                    ![Rad Diagram Features DnD Shapes Dropping](images/RadDiagram_Features_DnD_Shapes_Dropping.png)

# See Also
