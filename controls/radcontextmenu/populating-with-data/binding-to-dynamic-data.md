---
title: Binding to Dynamic Data
page_title: Binding to Dynamic Data
description: Binding to Dynamic Data
slug: radcontextmenu-populating-with-data-binding-to-dynamic-data
tags: binding,to,dynamic,data
published: True
position: 3
---

# Binding to Dynamic Data



The data displayed in the __RadContextMenu__ has a hierarchical structure (similar to the __RadTreeView__). This means that each item may come with a set of items on its own. For that reason you have to use the __ItemContainerStyle__. This tutorial will walk you through the most important steps in creating, configuring and applying __ItemContainerStyle__ to your __RadContextMenu__.

## Preparing the Data

For this tutorial the following sample class will be used:

#### __C#__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_0}}
	public class MenuItem
	{
	    public MenuItem()
	    {
	        this.SubItems = new ObservableCollection<MenuItem>();
	    }
	    public string Text
	    {
	        get;
	        set;
	    }
	    public Uri IconUrl
	    {
	        get;
	        set;
	    }
	    public bool IsSeparator
	    {
	        get;
	        set;
	    }
	    public ICommand Command
	    {
	        get;
	        set;
	    }
	    public ObservableCollection<MenuItem> SubItems
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_1}}
	Public Class MenuItem
		Public Sub New()
			Me.SubItems = New ObservableCollection(Of MenuItem)()
		End Sub
		Public Property Text() As String
		Public Property IconUrl() As Uri
		Public Property IsSeparator() As Boolean
		Public Property Command() As ICommand
		Public Property SubItems() As ObservableCollection(Of MenuItem)
	End Class
	{{endregion}}



The __MenuItem__ class holds the information for the menu items.

* __Text__ - represents the text value for the item.

* __IconUrl__ - represents the url of the image that represents the icon of the menu item.

* __SubItems__ - a collection of the sub menu items of the current menu item.

* __IsSeparator__ - indicates whether the item is a separator.{% if site.site_name == 'Silverlight' %}

>tipTo learn more about the separator items and the __RadMenuItems__, please take a look at the [RadMenu help content](http://www.telerik.com/help/silverlight/radmenu-overview).{% endif %}{% if site.site_name == 'WPF' %}

>tipTo learn more about the separator items and the __RadMenuItems__, please take a look at the [RadMenu help content](http://www.telerik.com/help/wpf/radmenu-overview).{% endif %}

Next, a sample method is needed, which creates the sample data. Here is one:

#### __C#__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_2}}
	public ObservableCollection<MenuItem> GetMenuItems()
	{
	    ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
	    MenuItem copyItem = new MenuItem()
	    {
	        IconUrl = new Uri("Images/copy.png", UriKind.Relative),
	        Text = "Copy",
	    };
	    items.Add(copyItem);
	    MenuItem pasteItem = new MenuItem()
	    {
	        IconUrl = new Uri("Images/paste.png", UriKind.Relative),
	        Text = "Paste",
	    };
	    items.Add(pasteItem);
	    MenuItem cutItem = new MenuItem()
	    {
	        IconUrl = new Uri("Images/cut.png", UriKind.Relative),
	        Text = "Cut",
	    };
	    items.Add(cutItem);
	    MenuItem separatorItem = new MenuItem()
	    {
	        IsSeparator = true
	    };
	    items.Add(separatorItem);
	    MenuItem selectAllItem = new MenuItem()
	    {
	        Text = "Select All"
	    };
	    items.Add(selectAllItem);
	
	    return items;
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_3}}
	Public Function GetMenuItems() As ObservableCollection(Of MenuItem)
		Dim items As New ObservableCollection(Of MenuItem)()
		Dim copyItem As New MenuItem() With {.IconUrl = New Uri("Images/copy.png", UriKind.Relative), .Text = "Copy"}
		items.Add(copyItem)
		Dim pasteItem As New MenuItem() With {.IconUrl = New Uri("Images/paste.png", UriKind.Relative), .Text = "Paste"}
		items.Add(pasteItem)
		Dim cutItem As New MenuItem() With {.IconUrl = New Uri("Images/cut.png", UriKind.Relative), .Text = "Cut"}
		items.Add(cutItem)
		Dim separatorItem As New MenuItem() With {.IsSeparator = True}
		items.Add(separatorItem)
		Dim selectAllItem As New MenuItem() With {.Text = "Select All"}
		items.Add(selectAllItem)
	
		Return items
	End Function
	{{endregion}}



Finally, pass the generated collection to the __DataContext__.

#### __C#__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_4}}
	public Sample()
	{
	    InitializeComponent();
	    this.radContextMenu.ItemsSource = this.GetMenuItems();
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_5}}
	Public Sub New()
	 InitializeComponent()
	 Me.radContextMenu.ItemsSource = Me.GetMenuItems()
	End Sub
	{{endregion}}



## Creating and Applying the ItemContainerStyle

In order to visualize the data in the __RadContextMenu__ control you have to use a __ItemContainerStyle__. Here is a sample __Style__ that will be used to visualize the data in the __RadContextMenu__ control.

#### __XAML__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_6}}
	<Style x:Key="MenuItemContainer" TargetType="telerik:RadMenuItem">
	    <Setter Property="Icon" Value="{Binding IconUrl}"/>
	    <Setter Property="IconTemplate">
	        <Setter.Value>
	            <DataTemplate>
	                <Image Source="{Binding}" Stretch="None"/>
	            </DataTemplate>
	        </Setter.Value>
	    </Setter>
	    <Setter Property="IsSeparator" Value="{Binding IsSeparator}"/>
	    <Setter Property="Header" Value="{Binding Text}"/>
	    <Setter Property="ItemsSource" Value="{Binding SubItems}"/>
	    <Setter Property="Command" Value="{Binding Command}"/>
	</Style>
	{{endregion}}



>When setting the __ItemTemplate__ or __ItemContainerStyle__ properties of the __RadContextMenu__, they will get inherited in the hierarchy, unless they are not explicitly set.

In order to use the created style with __RadContextMenu__ control, you have to set its __ItemContainerStyle__ property.

#### __XAML__

{{region radcontextmenu-populating-with-data-binding-to-dynamic-data_8}}
	<TextBox Width="200" VerticalAlignment="Center" ContextMenu="{x:Null}" >
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu"
	                                ItemsSource="{Binding}"
	                                ItemContainerStyle="{StaticResource MenuItemContainer}" />
	    </telerik:RadContextMenu.ContextMenu>
	</TextBox>
	{{endregion}}



Here is a snapshot of the result.![](images/RadContextMenu_Populating_with_Data_Dynamic_Items_02.png)

# See Also

 * [Populating with Data - Overview]({%slug radcontextmenu-populating-with-data-overview%})

 * [Data Binding Support Overview]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%})

 * [Using Static Items]({%slug radcontextmenu-populating-with-data-using-static-items%})

 * [Template and Style Selectors]({%slug radcontextmenu-populating-with-data-template-and-style-selectors%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})
