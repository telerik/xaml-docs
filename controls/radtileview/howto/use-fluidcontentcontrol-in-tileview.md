---
title: Use RadFluidContentControl in RadTileView
page_title: Use RadFluidContentControl in RadTileView
description: Use RadFluidContentControl in RadTileView
slug: radtileview-howto-use-fluidcontentcontrol-in-tileview
tags: use,radfluidcontentcontrol,in,radtileview
published: True
position: 0
---

# Use RadFluidContentControl in RadTileView



## 

This article will show you a step-by-step tutorial on how to use __RadFluidContentControl__ in __RadTileView__ to change the content of the __RadTileViewItems__ depending on their state.
				

For the purpose of this example you will need a __RadTileView__ populated with a collection of business objects. The structure of the business object is shown in the next code snippet:
				

#### __C#__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_0}}
	public class MyViewModel : INotifyPropertyChanged
	{
	 public MyViewModel()
	 {
	  this.SmallImage = new Uri("Images/SmallImage.png", UriKind.Relative);
	  this.Image = new Uri("Images/Image.png", UriKind.Relative);
	  this.LargeImage = new Uri("Images/LargeImage.png", UriKind.Relative);
	 }
	 public string Header { get; set; }
	 public Uri SmallImage { get; set; }
	 public Uri Image { get; set; }
	 public Uri LargeImage { get; set; }
	 private ContentState _contentState;
	 /// <summary>
	 ///     Gets or sets the name.
	 /// </summary>
	 public ContentState ContentState
	 {
	  get
	  {
	   return this._contentState;
	  }
	  set
	  {
	   if (this._contentState != value)
	   {
	    this._contentState= value;
	    OnPropertyChanged("ContentState");
	   }
	  }
	 }   
	
	 /// <summary>
	 ///     Event for INotifyPropertyChanged.
	 /// </summary>
	 public event PropertyChangedEventHandler PropertyChanged;
	 /// <summary>
	 ///     Raises the INotifyPropertyChanged event.
	 /// </summary>
	 /// <param name="propertyName">The property to be included in the INotifyPropertyChanged EventArgs.</param>
	 protected virtual void OnPropertyChanged(String propertyName)
	 {
	  if (PropertyChanged != null)
	  {
	   PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
	  }
	 }
	
	}
	public enum ContentState
	{
	 SmallContent = 1,
	 NormalContent = 0,
	 LargeContent = 2
	}
	{{endregion}}



#### __VB.NET__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_1}}
	Public Class MyViewModel
	Implements INotifyPropertyChanged
	 Public Sub New()
	  Me.SmallImage = New Uri("Images/SmallImage.png", UriKind.Relative)
	  Me.Image = New Uri("Images/Image.png", UriKind.Relative)
	  Me.LargeImage = New Uri("Images/LargeImage.png", UriKind.Relative)
	 End Sub
	 Public Property Header() As String
	 Public Property SmallImage() As Uri
	 Public Property Image() As Uri
	 Public Property LargeImage() As Uri
	 Private _contentState As ContentState
	 ''' <summary>
	 '''     Gets or sets the name.
	 ''' </summary>
	 Public Property ContentState() As ContentState
	  Get
	   Return Me._contentState
	  End Get
	  Set(ByVal value As ContentState)
	   If Me._contentState <> value Then
	    Me._contentState = value
	    OnPropertyChanged("ContentState")
	   End If
	  End Set
	 End Property
	 ''' <summary>
	 '''     Event for INotifyPropertyChanged.
	 ''' </summary>
	 Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
	 ''' <summary>
	 '''     Raises the INotifyPropertyChanged event.
	 ''' </summary>
	 ''' <param name="propertyName">The property to be included in the INotifyPropertyChanged EventArgs.</param>
	 Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
	  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	 End Sub
	End Class
	Public Enum ContentState
	 SmallContent = 1
	 NormalContent = 0
	 LargeContent = 2
	End Enum
	{{endregion}}



The class has five properties:

* 
						Property __Header__which is of type __string__.
					

* 
						Properties __SmallImage__, __Image__and __LargeImage__ - of type __Uri__.
					

* 
						Property __ContentState__ which is of type __ContentState__.
					

Add a static method to the class which aims to create some mock-up data:

#### __C#__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_2}}
	public static IList<object> GenerateItems()
	{
	 var result = new ObservableCollection<object>();
	 foreach (var num in Enumerable.Range(1, 12))
	 {
	  result.Add(new MyViewModel() { Header = String.Format("Item {0}", num) });
	 }
	 return result;
	}
	{{endregion}}



#### __VB.NET__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_3}}
	Public Shared Function GenerateItems() As IList(Of Object)
	 Dim result = New ObservableCollection(Of Object)()
	 For Each num In Enumerable.Range(1, 12)
	  result.Add(New MyViewModel() With {.Header = String.Format("Item {0}", num)})
	 Next num
	 Return result
	End Function
	{{endregion}}



Declare an __ItemTemplate__:
				

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_4}}
	    <DataTemplate x:Key="ItemTemplate">
	        <TextBlock Text="{Binding Header}" />
	    </DataTemplate>
	{{endregion}}



Declare a __ContentTemplate__:
				

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_5}}
	    <DataTemplate x:Key="ContentTemplate">
	        <telerik:RadFluidContentControl ContentChangeMode="Manual"
	                State="{Binding ContentState, Converter={StaticResource fluidContentStateConverter}}">
	            <telerik:RadFluidContentControl.SmallContent>
	                <Image Source="{Binding SmallImage}" />
	            </telerik:RadFluidContentControl.SmallContent>
	            <telerik:RadFluidContentControl.Content>
	                <Image Source="{Binding Image}" />
	            </telerik:RadFluidContentControl.Content>
	            <telerik:RadFluidContentControl.LargeContent>
	                <Image Source="{Binding LargeImage}" />
	            </telerik:RadFluidContentControl.LargeContent>
	        </telerik:RadFluidContentControl>
	    </DataTemplate>
	{{endregion}}



The __State__property of the __RadFluidContentControl__is databound to the __ContentState__business property, therefore a converter must be used:
				

#### __C#__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_6}}
	public class FluidContentStateConverter : IValueConverter
	{
	 public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	 {
	  var contentState = (ContentState)value;
	  switch (contentState)
	  {
	   case ContentState.SmallContent:
	    return FluidContentControlState.Small;
	   case ContentState.NormalContent:
	    return FluidContentControlState.Normal;
	   case ContentState.LargeContent:
	    return FluidContentControlState.Large;
	   default:
	    return FluidContentControlState.Normal;
	  }
	 }
	 public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	 {
	  var fluidState = (FluidContentControlState)value;
	  switch (fluidState)
	  {
	   case FluidContentControlState.Small:
	    return ContentState.SmallContent;
	   case FluidContentControlState.Normal:
	    return ContentState.NormalContent;
	   case FluidContentControlState.Large:
	    return ContentState.LargeContent;
	   default:
	    return ContentState.NormalContent;
	  }
	 }
	}
	{{endregion}}



#### __VB.NET__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_7}}
	Public Class FluidContentStateConverter
	Implements IValueConverter
	 Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
	  Dim contentState = CType(value, ContentState)
	  Select Case contentState
	   Case contentState.SmallContent
	    Return FluidContentControlState.Small
	   Case contentState.NormalContent
	    Return FluidContentControlState.Normal
	   Case contentState.LargeContent
	    Return FluidContentControlState.Large
	   Case Else
	    Return FluidContentControlState.Normal
	  End Select
	 End Function
	 Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
	  Dim fluidState = CType(value, FluidContentControlState)
	  Select Case fluidState
	   Case FluidContentControlState.Small
	    Return ContentState.SmallContent
	   Case FluidContentControlState.Normal
	    Return ContentState.NormalContent
	   Case FluidContentControlState.Large
	    Return ContentState.LargeContent
	   Case Else
	    Return ContentState.NormalContent
	  End Select
	 End Function
	End Class
	{{endregion}}



In order to change the content of each __RadTileViewItem__accordingly to its state, the __RadTileViewItem's TileState__property should be databound to the __ContentState__business property:
				{% if site.site_name == 'Silverlight' %}

Using
							[ContainerBindingCollection](http://www.telerik.com/help/silverlight/radtreeview-how-to-bind-hierarchical-data-use-containerbindingcollection.html)
							to databind the __TileState__property is a pretty simple action. For example, see the code snippet below. The only thing you should do is to define the __ContainerBinding__ and to attach the binding collection to the __ItemTemplate__:

							

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_8}}
	    <telerik:ContainerBindingCollection x:Key="ContainerBindingCollection">
	        <telerik:ContainerBinding PropertyName="TileState"
	                Binding="{Binding ContentState, Mode=TwoWay, Converter={StaticResource tileStateConverter}}" />
	    </telerik:ContainerBindingCollection>
	    <DataTemplate x:Key="ItemTemplate"
	            telerik:ContainerBinding.ContainerBindings="{StaticResource ContainerBindingCollection}">
	        <TextBlock Text="{Binding Header}" />
	    </DataTemplate>
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

Using  __Style__to databind the __TileState__ property is a pretty simple action. For example, see the code snippet below. The only thing you should do is define a __RadTileViewItem Style__and apply it to the __RadTileView__:

					

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_9}}
	    <Style TargetType="telerik:RadTileViewItem" x:Key="ItemContainerStyle">
	        <Setter Property="TileState"
	                Value="{Binding ContentState, Mode=TwoWay, Converter={StaticResource tileStateConverter}}" />
	    </Style>
	    <telerik:RadTileView x:Name="radTileView" ItemContainerStyle="{StaticResource ItemContainerStyle}">
	    </telerik:RadTileView>
	{{endregion}}

{% endif %}

The definition of the __TileStateConverter__ class is:
				

#### __C#__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_10}}
	public class TileStateConverter : IValueConverter
	{
	 #region IValueConverter Members
	 public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	 {
	  var contentState = (ContentState)value;
	  switch (contentState)
	  {
	   case ContentState.SmallContent:
	    return TileViewItemState.Minimized;
	   case ContentState.NormalContent:
	    return TileViewItemState.Restored;
	   case ContentState.LargeContent:
	    return TileViewItemState.Maximized;
	   default:
	    return TileViewItemState.Restored;
	  }
	 }
	
	 public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	 {
	  var tileState = (TileViewItemState)value;
	  switch (tileState)
	  {
	   case TileViewItemState.Minimized:
	    return ContentState.SmallContent;
	   case TileViewItemState.Restored:
	    return ContentState.NormalContent;
	   case TileViewItemState.Maximized:
	    return ContentState.LargeContent;
	   default:
	    return ContentState.NormalContent;
	  }
	 }
	{{endregion}}



#### __VB.NET__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_11}}
	Public Class TileStateConverter
	Implements IValueConverter
	 #Region "IValueConverter Members"
	 Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
	  Dim contentState = CType(value, ContentState)
	  Select Case contentState
	   Case contentState.SmallContent
	    Return TileViewItemState.Minimized
	   Case contentState.NormalContent
	    Return TileViewItemState.Restored
	   Case contentState.LargeContent
	    Return TileViewItemState.Maximized
	   Case Else
	    Return TileViewItemState.Restored
	  End Select
	 End Function
	 Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
	  Dim tileState = CType(value, TileViewItemState)
	  Select Case tileState
	   Case TileViewItemState.Minimized
	    Return ContentState.SmallContent
	   Case TileViewItemState.Restored
	    Return ContentState.NormalContent
	   Case TileViewItemState.Maximized
	    Return ContentState.LargeContent
	   Case Else
	    Return ContentState.NormalContent
	  End Select
	 End Function
	 #End Region
	End Class
	{{endregion}}



Define the __RadTileView__:
				{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_12}}
	    <telerik:RadTileView x:Name="radTileView" ContentTemplate="{StaticResource ContentTemplate}"
	            ItemTemplate="{StaticResource ItemTemplate}" MinimizedColumnWidth="200" MinimizedItemsPosition="Right"
	            MinimizedRowHeight="200" />
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_13}}
	    <telerik:RadTileView x:Name="radTileView" ContentTemplate="{StaticResource ContentTemplate}"
	            ItemContainerStyle="{StaticResource ItemContainerStyle}" ItemTemplate="{StaticResource ItemTemplate}"
	            MinimizedColumnWidth="200" MinimizedItemsPosition="Right" MinimizedRowHeight="200" />
	{{endregion}}

{% endif %}

Populate the __RadTileView____ItemsSource__ collection using the __MyViewModel.GenerateItems()__ method:
				{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_14}}
	public partial class MainPage : UserControl
	{
	 public MainPage()
	 {
	  InitializeComponent();
	  this.radTileView.ItemsSource = MyViewModel.GenerateItems();
	 }
	}
	{{endregion}}



#### __VB.NET__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_15}}
	Public Partial Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
	
			Me.radTileView.ItemsSource = MyViewModel.GenerateItems()
		End Sub
	End Class
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __C#__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_16}}
	public partial class MainWindow : Window
	{
	 public MainWindow()
	 {
	  InitializeComponent();
	  this.radTileView.ItemsSource = MyViewModel.GenerateItems();
	 }
	}
	{{endregion}}



#### __VB.NET__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_17}}
	Public Partial Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
	
			Me.radTileView.ItemsSource = MyViewModel.GenerateItems()
		End Sub
	End Class
	{{endregion}}

{% endif %}

Here is the final __XAML__:
				{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_18}}
	    <UserControl.Resources>
	        <local:FluidContentStateConverter x:Key="fluidContentStateConverter" />
	        <local:TileStateConverter x:Key="tileStateConverter" />
	        <telerik:ContainerBindingCollection x:Key="ContainerBindingCollection">
	            <telerik:ContainerBinding PropertyName="TileState"
	                    Binding="{Binding ContentState, Mode=TwoWay, Converter={StaticResource tileStateConverter}}" />
	        </telerik:ContainerBindingCollection>
	        <DataTemplate x:Key="ItemTemplate"
	                telerik:ContainerBinding.ContainerBindings="{StaticResource ContainerBindingCollection}">
	            <TextBlock Text="{Binding Header}" />
	        </DataTemplate>
	        <DataTemplate x:Key="ContentTemplate">
	            <telerik:RadFluidContentControl ContentChangeMode="Manual"
	                    State="{Binding ContentState, Converter={StaticResource fluidContentStateConverter}}">
	                <telerik:RadFluidContentControl.SmallContent>
	                    <Image Source="{Binding SmallImage}" />
	                </telerik:RadFluidContentControl.SmallContent>
	                <telerik:RadFluidContentControl.Content>
	                    <Image Source="{Binding Image}" />
	                </telerik:RadFluidContentControl.Content>
	                <telerik:RadFluidContentControl.LargeContent>
	                    <Image Source="{Binding LargeImage}" />
	                </telerik:RadFluidContentControl.LargeContent>
	            </telerik:RadFluidContentControl>
	        </DataTemplate>
	    </UserControl.Resources>
	    <Grid x:Name="LayoutRoot" Background="White">
	        <telerik:RadTileView x:Name="radTileView" ContentTemplate="{StaticResource ContentTemplate}"
	                ItemTemplate="{StaticResource ItemTemplate}" MinimizedColumnWidth="200" MinimizedItemsPosition="Right"
	                MinimizedRowHeight="200" />
	    </Grid>
	</UserControl>
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radtileview-howto-use-fluidcontentcontrol-in-tileview_19}}
	<Window.Resources>
	    <local:FluidContentStateConverter x:Key="fluidContentStateConverter" />
	    <local:TileStateConverter x:Key="tileStateConverter" />
	    <DataTemplate x:Key="ItemTemplate">
	        <TextBlock Text="{Binding Header}" />
	    </DataTemplate>
	    <DataTemplate x:Key="ContentTemplate">
	        <telerik:RadFluidContentControl ContentChangeMode="Manual"
	                State="{Binding ContentState, Converter={StaticResource fluidContentStateConverter}}">
	            <telerik:RadFluidContentControl.SmallContent>
	                <Image Source="{Binding SmallImage}" />
	            </telerik:RadFluidContentControl.SmallContent>
	            <telerik:RadFluidContentControl.Content>
	                <Image Source="{Binding Image}" />
	            </telerik:RadFluidContentControl.Content>
	            <telerik:RadFluidContentControl.LargeContent>
	                <Image Source="{Binding LargeImage}" />
	            </telerik:RadFluidContentControl.LargeContent>
	        </telerik:RadFluidContentControl>
	    </DataTemplate>
	    <Style TargetType="telerik:RadTileViewItem" x:Key="ItemContainerStyle">
	        <Setter Property="TileState"
	                Value="{Binding ContentState, Mode=TwoWay, Converter={StaticResource tileStateConverter}}" />
	    </Style>
	</Window.Resources>
	<Grid>
	    <telerik:RadTileView x:Name="radTileView" ContentTemplate="{StaticResource ContentTemplate}"
	            ItemContainerStyle="{StaticResource ItemContainerStyle}" ItemTemplate="{StaticResource ItemTemplate}"
	            MinimizedColumnWidth="200" MinimizedItemsPosition="Right" MinimizedRowHeight="200" />
	</Grid>
	</Window>
	{{endregion}}

{% endif %}

You can find a project demonstrating the described approach {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/community/code-library/silverlight/general/how-to-use-radfluidcontentcontrol-inside-the-radtileview-control.aspx){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/community/code-library/wpf/general/how-to-use-the-radfluidcontentcontrol-in-radtileview.aspx){% endif %}.
				
