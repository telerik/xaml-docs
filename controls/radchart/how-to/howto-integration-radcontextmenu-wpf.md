---
title: Integration with RadContextMenu
page_title: Integration with RadContextMenu
description: Check our &quot;Integration with RadContextMenu&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-howto-integration-radcontextmenu-wpf
tags: integration,with,radcontextmenu
published: True
position: 4
site_name: WPF
---

# Integration with RadContextMenu



## 

The purpose of this tutorial is to show you how to integrate __RadChart__ and __RadContextMenu__ so they can nicely work together.

The final result should look like the snapshot below.
![{{ site.framework_name }} RadChart  ](images/RadChart_HowToRadContextMenuIntegration_010_WPF.png)

Basically, the approach that will be demonstrated here combines the [MVVM support of RadChart]({%slug radchart-how-to-mvvm-support%}) with [RadChart data-binding]({%slug radchart-populating-with-data-data-binding-support-overview%}), and the data-binding functionality supported by the __RadMenu__ (__RadContextMenu__) control.

You will need several helper classes that will be used for the __RadChart__ and __RadContextMenu__ population.

* Create a new class named __MenuItem__. This class represents a single item in the __RadContextMenu__. Note that the class has absolutely the same properties as the __RadMenuItem__ used in the context menu. The idea here is to bind the different properties of the __MenuItem__ business object to the corresponding properties of the __RadMenuItem__ using __style binding__.



```C#
	public class MenuItem : INotifyPropertyChanged
	{
	    private bool isChecked;
	    private bool isEnabled = true;
	    private string text;
	    private string groupName;
	    private bool isCheckable;
	    private bool isSeparator;
	    private string imageUrl;
	    private bool staysOpenOnClick;
	    private MenuItemsCollection items;
	    private MenuItem parent;
	    public MenuItem()
	    {
	        this.items = new MenuItemsCollection( this );
	    }
	    public event PropertyChangedEventHandler PropertyChanged;
	    public string Text
	    {
	        get
	        {
	            return this.text;
	        }
	        set
	        {
	            this.text = value;
	        }
	    }
	    public string GroupName
	    {
	        get
	        {
	            return this.groupName;
	        }
	        set
	        {
	            this.groupName = value;
	        }
	    }
	    public bool IsCheckable
	    {
	        get
	        {
	            return this.isCheckable;
	        }
	        set
	        {
	            this.isCheckable = value;
	        }
	    }
	    public bool IsSeparator
	    {
	        get
	        {
	            return this.isSeparator;
	        }
	        set
	        {
	            this.isSeparator = value;
	        }
	    }
	    public string ImageUrl
	    {
	        get
	        {
	            return this.imageUrl;
	        }
	        set
	        {
	            this.imageUrl = value;
	        }
	    }
	    public bool StaysOpenOnClick
	    {
	        get
	        {
	            return this.staysOpenOnClick;
	        }
	        set
	        {
	            this.staysOpenOnClick = value;
	        }
	    }
	    public MenuItemsCollection Items
	    {
	        get
	        {
	            return this.items;
	        }
	    }
	    public MenuItem Parent
	    {
	        get
	        {
	            return this.parent;
	        }
	        set
	        {
	            this.parent = value;
	        }
	    }
	    public bool IsEnabled
	    {
	        get
	        {
	            return this.isEnabled;
	        }
	        set
	        {
	            if ( value != this.isEnabled )
	            {
	                this.isEnabled = value;
	                this.OnPropertyChanged( "IsEnabled" );
	            }
	        }
	    }
	    public bool IsChecked
	    {
	        get
	        {
	            return this.isChecked;
	        }
	        set
	        {
	            if ( value != this.isChecked )
	            {
	                this.isChecked = value;
	                this.OnPropertyChanged( "IsChecked" );
	                if ( !string.IsNullOrEmpty( this.GroupName ) )
	                {
	                    if ( this.IsChecked )
	                    {
	                        this.UncheckOtherItemsInGroup();
	                    }
	                    else
	                    {
	                        this.IsChecked = true;
	                    }
	                }
	            }
	        }
	    }
	    public Image Image
	    {
	        get
	        {
	            if ( string.IsNullOrEmpty( this.ImageUrl ) )
	                return null;
	            return new Image()
	            {
	                Source = new BitmapImage( new Uri( this.ImageUrl, UriKind.RelativeOrAbsolute ) )
	            };
	        }
	    }
	    private void UncheckOtherItemsInGroup()
	    {
	        IEnumerable<MenuItem> groupItems = this.Parent.Items.Where( ( MenuItem item ) => item.GroupName == this.GroupName );
	        foreach ( MenuItem item in groupItems )
	        {
	            if ( item != this )
	            {
	                item.isChecked = false;
	                item.OnPropertyChanged( "IsChecked" );
	            }
	        }
	    }
	    private void OnPropertyChanged( string propertyName )
	    {
	        if ( null != this.PropertyChanged )
	        {
	            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
	        }
	    }
	}
```
```VB.NET
	Public Class MenuItem
	    Implements INotifyPropertyChanged
	
	    Private m_isChecked As Boolean
	    Private m_isEnabled As Boolean = True
	    Private m_text As String
	    Private m_groupName As String
	    Private m_isCheckable As Boolean
	    Private m_isSeparator As Boolean
	    Private m_imageUrl As String
	    Private m_staysOpenOnClick As Boolean
	    Private m_items As MenuItemsCollection
	    Private m_parent As MenuItem
	
	    Public Sub New()
	        Me.m_items = New MenuItemsCollection(Me)
	    End Sub
	
	    Public Property Text() As String
	        Get
	            Return Me.m_text
	        End Get
	        Set(ByVal value As String)
	            Me.m_text = value
	        End Set
	    End Property
	
	    Public Property GroupName() As String
	        Get
	            Return Me.m_groupName
	        End Get
	        Set(ByVal value As String)
	            Me.m_groupName = value
	        End Set
	    End Property
	
	    Public Property IsCheckable() As Boolean
	        Get
	            Return Me.m_isCheckable
	        End Get
	        Set(ByVal value As Boolean)
	            Me.m_isCheckable = value
	        End Set
	    End Property
	
	    Public Property IsSeparator() As Boolean
	        Get
	            Return Me.m_isSeparator
	        End Get
	        Set(ByVal value As Boolean)
	            Me.m_isSeparator = value
	        End Set
	    End Property
	
	    Public Property ImageUrl() As String
	        Get
	            Return Me.m_imageUrl
	        End Get
	        Set(ByVal value As String)
	            Me.m_imageUrl = value
	        End Set
	    End Property
	
	    Public Property StaysOpenOnClick() As Boolean
	        Get
	            Return Me.m_staysOpenOnClick
	        End Get
	        Set(ByVal value As Boolean)
	            Me.m_staysOpenOnClick = value
	        End Set
	    End Property
	
	    Public ReadOnly Property Items() As MenuItemsCollection
	        Get
	            Return Me.m_items
	        End Get
	    End Property
	
	    Public Property Parent() As MenuItem
	        Get
	            Return Me.m_parent
	        End Get
	        Set(ByVal value As MenuItem)
	            Me.m_parent = value
	        End Set
	    End Property
	
	    Public Property IsEnabled() As Boolean
	        Get
	            Return Me.m_isEnabled
	        End Get
	        Set(ByVal value As Boolean)
	            If value <> Me.m_isEnabled Then
	                Me.m_isEnabled = value
	                Me.OnPropertyChanged("IsEnabled")
	            End If
	        End Set
	    End Property
	
	    Public Property IsChecked() As Boolean
	        Get
	            Return Me.m_isChecked
	        End Get
	        Set(ByVal value As Boolean)
	            If value <> Me.m_isChecked Then
	                Me.m_isChecked = value
	                Me.OnPropertyChanged("IsChecked")
	
	                If Not String.IsNullOrEmpty(Me.GroupName) Then
	                    If Me.IsChecked Then
	                        Me.UncheckOtherItemsInGroup()
	                    Else
	                        Me.IsChecked = True
	                    End If
	                End If
	            End If
	        End Set
	    End Property
	
	    Public ReadOnly Property Image() As Image
	        Get
	            If String.IsNullOrEmpty(Me.ImageUrl) Then
	                Return Nothing
	            End If
	
	            Return New Image()
	        End Get
	    End Property
	
	    Private Sub UncheckOtherItemsInGroup()
	        Dim groupItems As IEnumerable(Of MenuItem) = Me.Parent.Items.Where(Function(item As MenuItem) item.GroupName = Me.GroupName)
	        For Each item As MenuItem In groupItems
	            If item IsNot Me Then
	                item.IsChecked = False
	                item.OnPropertyChanged("IsChecked")
	            End If
	        Next
	    End Sub
	
	    Private Sub OnPropertyChanged(ByVal propertyName As String)
	        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	    End Sub
	
	    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
	End Class
```



* Create a new class named __MenuItemCollection__. This class is pretty simple and self-explanatory.



```C#
	public class MenuItemsCollection : ObservableCollection<MenuItem>
	{
	    private MenuItem parent;
	    public MenuItemsCollection()
	        : this( null )
	    {
	    }
	    public MenuItemsCollection( MenuItem parent )
	    {
	        this.parent = parent;
	    }
	    public MenuItem Parent
	    {
	        get
	        {
	            return this.parent;
	        }
	        set
	        {
	            this.parent = value;
	        }
	    }
	    protected override void InsertItem( int index, MenuItem item )
	    {
	        item.Parent = this.Parent;
	        base.InsertItem( index, item );
	    }
	}
```
```VB.NET
	Public Class MenuItemsCollection
	    Inherits ObservableCollection(Of MenuItem)
	    Private m_parent As MenuItem
	
	    Public Sub New()
	        Me.New(Nothing)
	    End Sub
	
	    Public Sub New(ByVal parent As MenuItem)
	        Me.m_parent = parent
	    End Sub
	
	    Public Property Parent() As MenuItem
	        Get
	            Return Me.m_parent
	        End Get
	        Set(ByVal value As MenuItem)
	            Me.m_parent = value
	        End Set
	    End Property
	
	    Protected Overloads Overrides Sub InsertItem(ByVal index As Integer, ByVal item As MenuItem)
	        item.Parent = Me.Parent
	        MyBase.InsertItem(index, item)
	    End Sub
	End Class
```



* Create a new class named __ChartDataItem__. The __ChartDataItem__ is used to populate the __RadChart__ with sample data.



```C#
	public class ChartDataItem : INotifyPropertyChanged
	{
	    private double yValue;
	    private MenuItemsCollection menuItems;
	    public event PropertyChangedEventHandler PropertyChanged;
	    public double YValue
	    {
	        get
	        {
	            return this.yValue;
	        }
	        set
	        {
	            if ( this.yValue != value )
	            {
	                this.yValue = value;
	                this.OnPropertyChanged( "YValue" );
	            }
	        }
	    }
	    public MenuItemsCollection MenuItems
	    {
	        get
	        {
	            if ( this.menuItems == null )
	            {
	                this.menuItems = new MenuItemsCollection();
	            }
	            return this.menuItems;
	        }
	    }
	    private void OnPropertyChanged( string propertyName )
	    {
	        if ( null != this.PropertyChanged )
	        {
	            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
	        }
	    }
	}
```
```VB.NET
	Public Class ChartDataItem
	    Implements INotifyPropertyChanged
	    Private m_yValue As Double
	    Private m_menuItems As MenuItemsCollection
	
	    Public Property YValue() As Double
	        Get
	            Return Me.m_yValue
	        End Get
	        Set(ByVal value As Double)
	            If Me.m_yValue <> value Then
	                Me.m_yValue = value
	                Me.OnPropertyChanged("YValue")
	            End If
	        End Set
	    End Property
	
	    Public ReadOnly Property MenuItems() As MenuItemsCollection
	        Get
	            If Me.m_menuItems Is Nothing Then
	                Me.m_menuItems = New MenuItemsCollection()
	            End If
	
	            Return Me.m_menuItems
	        End Get
	    End Property
	
	    Private Sub OnPropertyChanged(ByVal propertyName As String)
	        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	    End Sub
	
	    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
	End Class
```



* Create a new class named __ChartDataCollection__ - this is an observable collection of __ChartDataItem__ objects.



```C#
	public class ChartDataCollection : ObservableCollection<ChartDataItem>
	{
	}
```
```VB.NET
	Public Class ChartDataCollection
	    Inherits ObservableCollection(Of ChartDataItem)
	End Class
```



* And the final prerequisite is the __ChartViewModel__ - the data source for your __RadChart__.



```C#
	public class ChartViewModel
	{
	    private Random rand = new Random( DateTime.Now.Millisecond );
	    private ChartDataCollection data;
	    public ChartDataCollection Data
	    {
	        get
	        {
	            if ( data == null )
	            {
	                data = new ChartDataCollection();
	                data.Add( CreateChartDataItem( "Test {0}" ) );
	                data.Add( CreateChartDataItem( "Foo {0}" ) );
	                data.Add( CreateChartDataItem( "Bar {0}" ) );
	            }
	            return data;
	        }
	    }
	    private ChartDataItem CreateChartDataItem( string menuItemTextFormat )
	    {
	        ChartDataItem item = new ChartDataItem();
	        item.YValue = rand.Next( 10, 100 );
	        for ( int i = 0; i < rand.Next( 2, 5 ); i++ )
	        {
	            item.MenuItems.Add( new MenuItem()
	            {
	                Text = string.Format( menuItemTextFormat, i )
	            } );
	        }
	        return item;
	    }
	}
```
```VB.NET
	Public Class ChartViewModel
	    Private rand As New Random(DateTime.Now.Millisecond)
	    Private m_data As ChartDataCollection
	
	    Public ReadOnly Property Data() As ChartDataCollection
	        Get
	            If m_data Is Nothing Then
	                m_data = New ChartDataCollection()
	
	                m_data.Add(CreateChartDataItem("Test {0}"))
	                m_data.Add(CreateChartDataItem("Foo {0}"))
	                m_data.Add(CreateChartDataItem("Bar {0}"))
	            End If
	
	            Return m_data
	        End Get
	    End Property
	
	    Private Function CreateChartDataItem(ByVal menuItemTextFormat As String) As ChartDataItem
	        Dim item As New ChartDataItem()
	
	        item.YValue = rand.[Next](10, 100)
	        For i As Integer = 0 To rand.[Next](2, 5) - 1
	            item.MenuItems.Add(New MenuItem())
	        Next
	
	        Return item
	    End Function
	End Class
```



* Now you need to re-template the desired chart series type in order to place a __RadContextMenu__ instance as attached property in its template.



```XAML
	<Style x:Key="CustomStyle"
	       TargetType="telerik:Bar">
	    <Setter Property="Template">
	        <Setter.Value>
	                    <ControlTemplate TargetType="telerik:Bar">
	                <Canvas Opacity="0"
	                        x:Name="PART_MainContainer">
	                            <telerik:RadContextMenu.ContextMenu>
	                                <telerik:RadContextMenu ItemsSource="{Binding DataItem.MenuItems}"
	                                                          ItemTemplate="{StaticResource MenuItemTemplate}"
	                                                          ItemClick="OnContextMenuClick">
	                                    <telerik:RadContextMenu.ItemContainerStyle>
	                                            <Style TargetType="telerik:RadMenuItem">
	                                    <Setter Property="IsCheckable"
	                                            Value="{Binding IsCheckable}" />
	                                    <Setter Property="IsChecked"
	                                            Value="{Binding IsChecked}" />
	                                    <Setter Property="IsSeparator"
	                                            Value="{Binding IsSeparator}" />
	                                    <Setter Property="IsEnabled"
	                                            Value="{Binding IsEnabled}" />
	                                    <Setter Property="StaysOpenOnClick"
	                                            Value="{Binding StaysOpenOnClick}" />
	                                    <Setter Property="Icon"
	                                            Value="{Binding Image}" />
	                                </Style>
	                            </telerik:RadContextMenu.ItemContainerStyle>
	                        </telerik:RadContextMenu>
	                    </telerik:RadContextMenu.ContextMenu>
	                    <Rectangle x:Name="PART_DefiningGeometry"
	                               Height="{TemplateBinding ItemActualHeight}"
	                               Width="{TemplateBinding ItemActualWidth}"
	                               Style="{TemplateBinding ItemStyle}"
	                               RadiusX="{StaticResource BarRadiusX}"
	                               RadiusY="{StaticResource BarRadiusY}" />
	                    <Rectangle Height="{TemplateBinding ItemActualHeight}"
	                               Width="{TemplateBinding ItemActualWidth}"
	                               RadiusX="{StaticResource BarRadiusX}"
	                               RadiusY="{StaticResource BarRadiusY}"
	                               OpacityMask="{StaticResource BarOpacityMaskBrush}"
	                               Fill="{StaticResource BarMaskBrush}" />
	                    <Rectangle Height="{TemplateBinding ItemActualHeight}"
	                               Width="{TemplateBinding ItemActualWidth}"
	                               RadiusX="{StaticResource BarRadiusX}"
	                               RadiusY="{StaticResource BarRadiusY}"
	                               Fill="{StaticResource BarTopMaskBrush}" />
	                    <Canvas.RenderTransform>
	                        <ScaleTransform x:Name="PART_AnimationTransform"
	                                        ScaleY="0" />
	                    </Canvas.RenderTransform>
	                </Canvas>
	            </ControlTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
```



You should note several things in the above code snippet:

* Notice that the __ContextMenu__ is data bound to a property of your chart DatabItem instance. The __ChartDataItem__ object exposes the desired menu items' structure (i.e. the chart control is data bound to a List of __ChartDataItem__ objects, and the __ChartDataItem__ class exposes __MenuItems__ property. __{Binding____DataItem.MenuItems}__ holds a reference to a specific __ChartDataItem__ instance).

* The __RadContextMenu__ can support hierarchical Menu structure as well (as with stand-alone Menu you need to create a __HierarchicalDataTemplate__ that specifies the __ItemsSource__, __ItemTemplate__ and other properties of the item's children).

* For WPF you can use the __style binding__mechanism that allows you to bind properties of an item container ( __RadMenuItem__, __RadTreeViewItem__, etc.) to the properties of the data object. Also you should set the __ItemContainerStyle__ property of the __RadContextMenu__.

The code snippet below shows you the full XAML code:



```XAML
	<Grid>
	    <Grid.Resources>
	        <HierarchicalDataTemplate x:Key="MenuItemTemplate"
	                                  ItemsSource="{Binding Items}">
	            <TextBlock Text="{Binding Text}" />
	        </HierarchicalDataTemplate>
	        <mscorlib:Double x:Key="BarRadiusX">2</mscorlib:Double>
	        <mscorlib:Double x:Key="BarRadiusY">2</mscorlib:Double>
	        <LinearGradientBrush x:Key="BarMaskBrush"
	                             EndPoint="1,0.5"
	                             StartPoint="0,0.5">
	            <GradientStop Color="#00FFFFFF"
	                          Offset="0" />
	            <GradientStop Color="#00FFFFFF"
	                          Offset="1" />
	            <GradientStop Color="#26000000"
	                          Offset="0.2" />
	            <GradientStop Color="#66000000"
	                          Offset="0.2" />
	        </LinearGradientBrush>
	        <SolidColorBrush x:Key="BarOpacityMaskBrush"
	                         Color="#FF000000" />
	        <SolidColorBrush x:Key="BarTopMaskBrush"
	                         Color="Transparent" />
	        <Style x:Key="CustomStyle"
	               TargetType="telerik:Bar">
	            <Setter Property="Template">
	                <Setter.Value>
	                        <ControlTemplate TargetType="telerik:Bar">
	                        <Canvas Opacity="0"
	                                x:Name="PART_MainContainer">
	                                <telerik:RadContextMenu.ContextMenu>
	                                    <telerik:RadContextMenu ItemsSource="{Binding DataItem.MenuItems}"
	                                                                  ItemTemplate="{StaticResource MenuItemTemplate}"
	                                                                  ItemClick="OnContextMenuClick">
	                                        <telerik:RadContextMenu.ItemContainerStyle>
	                                            <Style TargetType="telerik:RadMenuItem">
	                                            <Setter Property="IsCheckable"
	                                                    Value="{Binding IsCheckable}" />
	                                            <Setter Property="IsChecked"
	                                                    Value="{Binding IsChecked}" />
	                                            <Setter Property="IsSeparator"
	                                                    Value="{Binding IsSeparator}" />
	                                            <Setter Property="IsEnabled"
	                                                    Value="{Binding IsEnabled}" />
	                                            <Setter Property="StaysOpenOnClick"
	                                                    Value="{Binding StaysOpenOnClick}" />
	                                            <Setter Property="Icon"
	                                                    Value="{Binding Image}" />
	                                        </Style>
	                                    </telerik:RadContextMenu.ItemContainerStyle>
	                                </telerik:RadContextMenu>
	                            </telerik:RadContextMenu.ContextMenu>
	                            <Rectangle x:Name="PART_DefiningGeometry"
	                                       Height="{TemplateBinding ItemActualHeight}"
	                                       Width="{TemplateBinding ItemActualWidth}"
	                                       Style="{TemplateBinding ItemStyle}"
	                                       RadiusX="{StaticResource BarRadiusX}"
	                                       RadiusY="{StaticResource BarRadiusY}" />
	                            <Rectangle Height="{TemplateBinding ItemActualHeight}"
	                                       Width="{TemplateBinding ItemActualWidth}"
	                                       RadiusX="{StaticResource BarRadiusX}"
	                                       RadiusY="{StaticResource BarRadiusY}"
	                                       OpacityMask="{StaticResource BarOpacityMaskBrush}"
	                                       Fill="{StaticResource BarMaskBrush}" />
	                            <Rectangle Height="{TemplateBinding ItemActualHeight}"
	                                       Width="{TemplateBinding ItemActualWidth}"
	                                       RadiusX="{StaticResource BarRadiusX}"
	                                       RadiusY="{StaticResource BarRadiusY}"
	                                       Fill="{StaticResource BarTopMaskBrush}" />
	                            <Canvas.RenderTransform>
	                                <ScaleTransform x:Name="PART_AnimationTransform"
	                                                ScaleY="0" />
	                            </Canvas.RenderTransform>
	                        </Canvas>
	                    </ControlTemplate>
	                </Setter.Value>
	            </Setter>
	        </Style>
	    </Grid.Resources>
	        <telerik:RadChart x:Name="radChart"
	                           ItemsSource="{Binding Data}">
	            <telerik:RadChart.SeriesMappings>
	                <telerik:SeriesMapping>
	                    <telerik:SeriesMapping.SeriesDefinition>
	                        <telerik:BarSeriesDefinition ItemStyle="{StaticResource CustomStyle}" />
	                </telerik:SeriesMapping.SeriesDefinition>
	                    <telerik:SeriesMapping.ItemMappings>
	                        <telerik:ItemMapping FieldName="YValue"
	                                                 DataPointMember="YValue" />
	                </telerik:SeriesMapping.ItemMappings>
	            </telerik:SeriesMapping>
	        </telerik:RadChart.SeriesMappings>
	    </telerik:RadChart>
	</Grid>
```



* What is left is to add the chart control declaration, bind it to a property of the __ViewModel__ set as a __DataContext__ for the respective user control, and instruct the control to use the custom bar style declared earlier:



```XAML
	<telerik:RadChart x:Name="radChart"
	   ItemsSource="{Binding Data}">
	    <telerik:RadChart.SeriesMappings>
	        <telerik:SeriesMapping>
	            <telerik:SeriesMapping.SeriesDefinition>
	                <telerik:BarSeriesDefinition ItemStyle="{StaticResource CustomStyle}" />
	            </telerik:SeriesMapping.SeriesDefinition>
	            <telerik:SeriesMapping.ItemMappings>
	                <telerik:ItemMapping FieldName="YValue"
	                         DataPointMember="YValue" />
	            </telerik:SeriesMapping.ItemMappings>
	        </telerik:SeriesMapping>
	    </telerik:RadChart.SeriesMappings>
	</telerik:RadChart>
```





```C#
	public void SetDataContex()
	{
	    this.DataContext = new ChartViewModel();
	}
	private void OnContextMenuClick(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
	    // Get the clicked item
	    MenuItem menuItem = (e.OriginalSource as RadMenuItem).Header as MenuItem;
	    if (menuItem.Text == "Foo 0")
	    {
	        //...
	    }
	}
```
```VB.NET
	Dim menu As RadContextMenu = CType(sender, RadContextMenu)
	Dim clickedBar As Bar = menu.GetClickedElement(Of Bar)()
	Dim clickedBarYValue As Double = clickedBar.DataPoint.YValue
```



You could download the complete source code for this tutorial [here](http://blogs.telerik.com/manoldonev/posts/10-02-08/wpf_silverlight_integrating_radchart_and_radcontextmenu_controls.aspx).
