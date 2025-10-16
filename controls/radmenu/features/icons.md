---
title: Icons
page_title: Icons
description: Check our &quot;Icons&quot; documentation article for the RadMenu WPF control.
slug: radmenu-features-icons
tags: icons
published: True
position: 5
---

# Icons

The `RadMenu` allows you to display an icon for each of the menu items. This can be done by setting the `Icon` property of the `RadMenuItem`. For the icon to be displayed as expected, you have to either provide an element of type `Image` for it or also set the `IconTemplate` property of the item.

## Setting the Icon of a Static Item

>tipTo learn more about this way of populating the RadMenu with static data take a look at the [Using Static Items]({%slug radmenu-populating-with-data-using-static-items%}) topic.

When using static items you can directly access the Icon property of each item. Respectively you can set it directly:

__Setting the Icon property declaratively__
```XAML
	<telerik:RadMenuItem Header="New File">
	    <telerik:RadMenuItem.Icon>
	        <Image Source="/Images/newFile.png" 
	               Stretch="UniformToFill" />
	    </telerik:RadMenuItem.Icon>
	</telerik:RadMenuItem>
```

__RadMenuItems with their Icon property set__

![RadMenuItems with their Icon property set](images/RadMenu_Features_Icons_01.png)

## Setting the Icon of a Dynamic Item

>tipTo learn more about this way of populating the RadMenu with dynamic data take a look at the [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%}) topic.

When using dynamic items, you have to bind the Icon property to a property of the data item. The specific here is that your data item needs to either expose a property of type Image, so the Icon property can be bound properly or you need to define the IconTemplate property of the menu items if you wish to bind it to a `string` or `Uri`, for example.

Let's assume you've defined the following class which exposes the icon Uri as well as a read-only property which returns an image from this Uri.

__MenuItem class with Uri and Image properties__
```C#
	public class MenuItem
	{
	    //...
	
	    public Uri IconUrl
	    {
	        get;
	        set;
	    }
	
	    public Image Icon
	    {
	        get
	        {
	            return new Image()
	            {
	                Source = new BitmapImage(this.IconUrl)
	            };
	        }
	    }
	
	    //...
	}
```
```VB.NET
	Public Class MenuItem
	    '...
	    Public Property IconUrl() As Uri
	        Get
	        End Get
	        Set(value As Uri)
	        End Set
	    End Property
	    Public ReadOnly Property Icon() As Image
	        Get
	            Dim img As New Image()
	            img.Source = New BitmapImage(Me.IconUrl)
	            Return img
	        End Get
	    End Property
	    '...
	End Class
```

You can then bind the Icon using any of the two properties. Following the example from the [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%}) article, you can add the following setters to `ItemContainerStyle`.

* If you wish to bind directly to a property of type Image:

	__Setting the Icon property to an Image__
	```XAML
		<!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
		<Style TargetType="telerik:RadMenuItem" BasedOn="{StaticResource RadMenuItemStyle}">--> 
		
		<Style x:Key="MenuItemStyle" TargetType="telerik:RadMenuItem">
			<!-- ... -->
			<Setter Property="Icon" Value="{Binding Icon}" />
		</Style>
	```

* If you wish to bind directly to a property of type Uri/string:

	__Setting the Icon property to an Uri/string__
	```XAML
		<!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
		<Style TargetType="telerik:RadMenuItem" BasedOn="{StaticResource RadMenuItemStyle}">--> 

        <Style x:Key="MenuItemStyle" TargetType="telerik:RadMenuItem">
			<!-- ... -->
            <Setter Property="Icon" Value="{Binding IconUrl}" />
            <Setter Property="IconTemplate" >
                <Setter.Value>
                    <DataTemplate>
                        <Image Source="{Binding}" Stretch="UniformToFill"/>
                    </DataTemplate>
                </Setter.Value>
            </Setter>
        </Style>
	```

<!-- -->

Both approaches will lead to the same results as when you set the icon declaratively.

__Dynamic RadMenuItems with their icons__

![Dynamic RadMenuItems with their icons](images/RadMenu_Features_Icons_01.png)

## Setting the Icon Position

The `RadMenuItem` element exposes the `ItemIconPosition` property that allows for specifying the location of the icon. It is of the type of `ItemIconPosition`, which exposes the following two options:

* `Left`&mdash;The icon will be displayed on the left side of the RadMenuItem's content. This is the default value.
* `Right`&mdash;The icon will be displayed on the right side of the RadMenuItem's content.

__Setting the ItemIconPosition property to Right__
```XAML
	<telerik:RadMenu>
	    <telerik:RadMenuItem Header="Options">
	        <telerik:RadMenuItem Header="Save" ItemIconPosition="Right">
	            <telerik:RadMenuItem.Icon>
	                <Image Source="/Images/save.png" 
	           	       	   Stretch="UniformToFill"/>
	            </telerik:RadMenuItem.Icon>
	        </telerik:RadMenuItem>
	    </telerik:RadMenuItem>
	</telerik:RadMenu>
```

__RadMenuItem with its icon positioned on the right__

![RadMenuItem with its icon positioned on the right](images/menu-features-icon-2.png)

## See Also

* [Checkable Items]({%slug radmenu-features-checkable-items%})
* [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%})
* [Commands]({%slug radmenu-features-commands%})