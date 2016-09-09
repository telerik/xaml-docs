---
title: Binding to Dynamic Data
page_title: Binding to Dynamic Data
description: Binding to Dynamic Data
slug: radmenu-populating-with-data-binding-to-dynamic-data
tags: binding,to,dynamic,data
published: True
position: 3
---

# Binding to Dynamic Data

The data displayed in the __RadMenu__ has a hierarchical structure (similar to the __RadTreeView__). This means that each item may come with a set of items on its own. For that reason you have to use the __HierarchicalDataTemplate__. This tutorial will walk you through the most important steps in creating, configuring and applying a __HierarchicalDataTemplate__ to your __RadMenu__, as follows:      

* [Preparing the data](#preparing-the-data)

* [Creating and Applying ItemContainerStyle](#creating-and-applying-the-itemcontainerstyle)

## Preparing the Data

For this tutorial the following sample class will be used:

#### __C#__

{{region cs-radmenu-populating-with-data-binding-to-dynamic-data_0}}
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
	    public ObservableCollection<MenuItem> SubItems
	    {
	        get;
	        set;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-radmenu-populating-with-data-binding-to-dynamic-data_1}}
	Public Class MenuItem
	 Public Sub New(text As String, iconUrl As Uri, subItems As ObservableCollection(Of MenuItem))
	  Me.Text = text
	  Me.IconUrl = iconUrl
	  Me.SubItems = subItems
	 End Sub
	 Public Property Text() As String
	  Get
	  End Get
	  Set
	  End Set
	 End Property
	 Public Property IconUrl() As Uri
	  Get
	  End Get
	  Set
	  End Set
	 End Property
	 Public Property SubItems() As ObservableCollection(Of MenuItem)
	  Get
	  End Get
	  Set
	  End Set
	 End Property
	End Class
{{endregion}}

The __MenuItem__ class holds the information for the menu items.

* __Text__ - represents the text value for the item.

* __IconUrl__ - represents the url of the image that represents the icon of the menu item.

* __SubItems__ - a collection of the sub menu items of the current menu item.

On the next step a sample method, which creates the sample data, is needed. Here is one:

#### __C#__

{{region cs-radmenu-populating-with-data-binding-to-dynamic-data_2}}
	public ObservableCollection<MenuItem> GetMenuItems()
	{
	    ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
	    ObservableCollection<MenuItem> fileSubItems = new ObservableCollection<MenuItem>();
	    MenuItem newItem = new MenuItem()
	    {
	        IconUrl = new Uri( "/Images/newFile.png", UriKind.Relative ),
	        Text = "New File"
	    };
	    fileSubItems.Add( newItem );
	    MenuItem openItem = new MenuItem()
	    {
	        IconUrl = new Uri( "/Images/open.png", UriKind.Relative ),
	        Text = "Open File"
	    };
	    fileSubItems.Add( openItem );
	    MenuItem saveItem = new MenuItem()
	    {
	        IconUrl = new Uri( "/Images/save.png", UriKind.Relative ),
	        Text = "Save File"
	    };
	    fileSubItems.Add( saveItem );
	    MenuItem fileItem = new MenuItem()
	    {
	        SubItems = fileSubItems,
	        Text="File"
	    };
	    items.Add( fileItem );
	    MenuItem editItem = new MenuItem()
	    {
	        Text = "Edit"
	    };
	    items.Add( editItem );
	    MenuItem viewItem = new MenuItem()
	    {
	        Text = "View"
	    };
	    items.Add( viewItem );
	    return items;
	}
{{endregion}}

#### __VB.NET__

{{region vb-radmenu-populating-with-data-binding-to-dynamic-data_3}}
	Public Function GetMenuItems() As ObservableCollection(Of MenuItem)
	 Dim items As New ObservableCollection(Of MenuItem)()
	 Dim fileSubItems As New ObservableCollection(Of MenuItem)()
	 Dim newItem As New MenuItem("New File", New Uri("/Images/newFile.png", UriKind.Relative), Nothing)
	 fileSubItems.Add(newItem)
	 Dim openItem As New MenuItem("Open File", New Uri("/Images/open.png", UriKind.Relative), Nothing)
	 fileSubItems.Add(openItem)
	 Dim saveItem As New MenuItem("Save", New Uri("/Images/save.png", UriKind.Relative), Nothing)
	 fileSubItems.Add(saveItem)
	 Dim fileItem As New MenuItem("File", Nothing, fileSubItems)
	 items.Add(fileItem)
	 Dim editItem As New MenuItem("Edit", Nothing, Nothing)
	 items.Add(editItem)
	 Dim viewItem As New MenuItem("View", Nothing, Nothing)
	 items.Add(viewItem)
	 Return items
	End Function
{{endregion}}

Finally, pass the generated collection to the __ItemsSource__ of the __RadMenu__.

#### __C#__

{{region cs-radmenu-populating-with-data-binding-to-dynamic-data_4}}
	public Sample()
	{
	    InitializeComponent();
	    this.radMenu.ItemsSource = this.GetMenuItems();
	}
{{endregion}}

#### __VB.NET__

{{region vb-radmenu-populating-with-data-binding-to-dynamic-data_5}}
	Public Sub New()
	 InitializeComponent()
	 Me.radMenu.ItemsSource = Me.GetMenuItems()
	End Sub
{{endregion}}

## Creating and Applying the ItemContainerStyle

In order to visualize the data in __RadMenu__ you can use *ItemContainerStyle* property. When used in combination with *ItemsSource*, the Style is applied on all __RadMenuItems__. The only thing you have to do is set the bindings for the needed properties. For the "Icon" you will have to use "IconTemplate" as shown below. When you bind the "Icon" property to the "IconUrl", its value will be passed to the DataTemplate and used as a Source of an image.        

#### __XAML__

{{region xaml-radmenu-populating-with-data-binding-to-dynamic-data_6}}
	<Style x:Key="MenuItemStyle" TargetType="telerik:RadMenuItem">
	    <Setter Property="Header" Value="{Binding Text}"/>
	    <Setter Property="ItemsSource" Value="{Binding SubItems}"/>
	    <Setter Property="Icon" Value="{Binding IconUrl}" />
	    <Setter Property="IconTemplate" >
	        <Setter.Value>
	            <DataTemplate>
	                <Image Source="{Binding}" Stretch="None"/>
	            </DataTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
{{endregion}}

So its time to define __RadMenu__ and set "ItemContainerStyle" property:
        
#### __XAML__

{{region xaml-radmenu-populating-with-data-binding-to-dynamic-data_8}}
	<telerik:RadMenu x:Name="radMenu" ItemContainerStyle="{StaticResource MenuItemStyle}"/>
{{endregion}}

Here is a snapshot of the final result:

![](images/RadMenu_Populating_with_Data_Binding_to_Dynamic_Data_02.png)

# See Also

 * [Populating with Data - Overview]({%slug radmenu-populating-with-data-overview%})

 * [Data Binding Support Overview]({%slug radmenu-populating-with-data-data-binding-support-overview%})

 * [Using Static Items]({%slug radmenu-populating-with-data-using-static-items%})

 * [Template and Style Selectors]({%slug radmenu-populating-with-data-template-and-style-selectors%})

 * [Group Checkable Menu Items into Radio Group]({%slug radmenu-how-to-group-checkable-menu-items-into-radio-group%})
