---
title: Binding to Object
page_title: Binding to Object
description: Binding to Object
slug: radradialmenu-populating-with-data-binding-to-object
tags: binding,to,object
published: True
position: 1
---

# Binding to Object

With the __Q1 2015__ release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}, __RadRadialMenu__ provides a new way to easily populate its items in a MVVM manner. The control now supports data binding to a collection of business objects through the new __ItemsSource__ property. 

The following example will demonstrate how to bind __RadRadialMenu__ with a collection of custom objects from the ViewModel.

## Implementing a Custom Object

In order to be able to successfully use the binding feature of the control, the used custom objects need to implement the __IRadialMenuItem__ interface. The interface provides all the required properties for __RadRadialMenuItem__:

#### __C#__
{{region cs-radradialmenu-populating-with-data-binding-to-object_1}}
	public class CustomMenuItem : IRadialMenuItem
	{
	    public bool CanUserSelect { get; set; }
	    public System.Windows.Input.ICommand Command { get; set; }
	    public object CommandParameter { get; set; }
	    public System.Windows.UIElement CommandTarget { get; set; }
	    public Brush ContentSectorBackground { get; set; }
	    public string GroupName { get; set; }
	    public object Header { get; set; }
	    public object IconContent { get; set; }
	    public bool IsSelected { get; set; }
	    public IEnumerable<IRadialMenuItem> ItemsSource { get; set; }
	    public object ToolTipContent { get; set; }
	}
{{endregion}}

#### __VB.NET__
{{region vb-radradialmenu-populating-with-data-binding-to-object_1}}
	Public Class CustomMenuItem
	    Implements IRadialMenuItem
	    Public Property CanUserSelect As Boolean Implements IRadialMenuItem.CanUserSelect
	    Public Property Command As ICommand Implements IRadialMenuItem.Command
	    Public Property CommandParameter As Object Implements IRadialMenuItem.CommandParameter
	    Public Property CommandTarget As UIElement Implements IRadialMenuItem.CommandTarget
	    Public Property ContentSectorBackground As Brush Implements IRadialMenuItem.ContentSectorBackground
	    Public Property GroupName As String Implements IRadialMenuItem.GroupName
	    Public Property Header As Object Implements IRadialMenuItem.Header
	    Public Property IconContent As Object Implements IRadialMenuItem.IconContent
	    Public Property IsSelected As Boolean Implements IRadialMenuItem.IsSelected
	    Public Property ItemsSource As IEnumerable(Of IRadialMenuItem) Implements IRadialMenuItem.ItemsSource
	    Public Property ToolTipContent As Object Implements IRadialMenuItem.ToolTipContent
	End Class
{{endregion}}

>Note that if you need to change any of those properties at run time you would need implement also the [INotifyPropertyChanged](https://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged%28v=vs.110%29.aspx), interface or inherit from the built in [ViewModelBase](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_viewmodelbase.htm) class in order to raise PropertyChanged of required properties.

## Implementing a ViewModel

The next thing is to simply define the needed source collection of CustomMenuItems in the ViewModel. Once this is done we will be able to bind it to the __ItemsSource__ property. 

#### __C#__
{{region cs-radradialmenu-populating-with-data-binding-to-object_2}}
	public class ViewModel : ViewModelBase
	{
	    public ObservableCollection<CustomMenuItem> MenuItems { get; set; }
	
	    public ViewModel()
	    {
	        this.MenuItems = this.GetMenuItems();
	    }
	
	    private ObservableCollection<CustomMenuItem> GetMenuItems()
	    {
	        var collection = new ObservableCollection<CustomMenuItem>();
	
	        var fileItem = new CustomMenuItem { Header = "File" };
	        collection.Add(fileItem);
	
	        var uploadItem = new CustomMenuItem { Header = "Upload" };
	        collection.Add(uploadItem);
	
	        var mailItem = new CustomMenuItem { Header = "Mail" };
	        mailItem.ItemsSource = new ObservableCollection<CustomMenuItem>
				{
					new CustomMenuItem { Header = "Inbox" },
					new CustomMenuItem { Header = "Drafts" },
					new CustomMenuItem { Header = "Sent" },
					new CustomMenuItem { Header = "Deleted" }
				};
	        collection.Add(mailItem);
	
	        var favoritesItem = new CustomMenuItem { Header = "Favorites" };
	        collection.Add(favoritesItem);
	
	        return collection;
	    }
	}
{{endregion}}

#### __VB.NET__
{{region vb-radradialmenu-populating-with-data-binding-to-object_2}}
	Public Class ViewModel
	        Inherits ViewModelBase
	
	        Public Property MenuItems() As ObservableCollection(Of CustomMenuItem)
	
	        Public Sub New()
	            Me.MenuItems = Me.GetMenuItems()
	        End Sub
	
	        Private Function GetMenuItems() As ObservableCollection(Of CustomMenuItem)
	            Dim collection = New ObservableCollection(Of CustomMenuItem)()
	
	            Dim fileItem = New CustomMenuItem With {.Header = "File"}
	            collection.Add(fileItem)
	
	            Dim uploadItem = New CustomMenuItem With {.Header = "Upload"}
	            collection.Add(uploadItem)
	
	            Dim mailItem = New CustomMenuItem With {.Header = "Mail"}
	            mailItem.ItemsSource = New ObservableCollection(Of CustomMenuItem) From { _
	                New CustomMenuItem With {.Header = "Inbox"}, _
	                New CustomMenuItem With {.Header = "Drafts"}, _
	                New CustomMenuItem With {.Header = "Sent"}, _
	                New CustomMenuItem With {.Header = "Deleted"} _
	            }
	            collection.Add(mailItem)
	
	            Dim favoritesItem = New CustomMenuItem With {.Header = "Favorites"}
	            collection.Add(favoritesItem)
	
	            Return collection
	        End Function
	    End Class
{{endregion}}

## Binding the Collection in XAML

The final step would be to set the ViewModel as DataContext and bind the already created collection to the __ItemsSource__ property of __RadRadialMenu__ as shown below:

#### __XAML__
{{region xaml-radradialmenu-populating-with-data-binding-to-object_1}}
	<telerik:RadRadialMenu ItemsSource="{Binding MenuItems}" />
{{endregion}}

You can see the final result on __Figure 1__.

__Figure 1__: __RadRadialMenu__ populated from the bound collection of CustomMenuItem objects
![Rad Radial Menu Populating with data 02](images/RadRadialMenu_Populating_with_data_02.png)

>tipYou can download a runnable project that demonstrates a more complex example of binding a collection of custom objects as __ItemsSource__ from our online SDK repository [here](https://github.com/telerik/xaml-sdk), the example is listed as __RadialMenu / BindingItemsSource__.        

## See Also

 * [Populating With Data]({%slug radradialmenu-populating-with-data-overview%})
 
 * [RadialMenuItems]({%slug radradialmenu-features-radialmenuitems%})
