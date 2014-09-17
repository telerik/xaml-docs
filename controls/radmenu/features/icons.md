---
title: Icons
page_title: Icons
description: Icons
slug: radmenu-features-icons
tags: icons
published: True
position: 5
---

# Icons



The __RadMenu__ allows you to display an icon for each of the menu items. It can be done by setting the __Icon__ property of the __RadMenuItem__. This property is of type __Image__, so you have to provide an element of type __Image__ for it.

As there are two ways to populate the __RadMenu__ with data, this topic will explain you how to set this property in both of them.

* [Setting the Icon of a Static Item](#Setting_the_Icon_of_a_Static_Item)

* [Setting the Icon of a Dynamic Item](#Setting_the_Icon_of_a_Dynamic_Item)

## Setting the Icon of a Static Item

>tipTo learn more about this way of populating the __RadMenu__ with static data take a look at the [Using Static Items]({%slug radmenu-populating-with-data-using-static-items%}) topic.

By using static items you can directly access the __Icon__ property of each item. Respectively you can set it directly:

#### __XAML__

{{region radmenu-features-icons_0}}
	<telerik:RadMenuItem Header="New File">
	    <telerik:RadMenuItem.Icon>
	        <Image Source="/Images/newFile.png"
	               Stretch="None" />
	    </telerik:RadMenuItem.Icon>
	</telerik:RadMenuItem>
	{{endregion}}



Here is a snapshot of the result.

![](images/RadMenu_Features_Icons_01.png)

## Setting the Icon of a Dynamic Item

>tipTo learn more about this way of populating the __RadMenu__ with dynamic data take a look at the [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%}) topic.

When using dynamic items, you have to bind the __Icon__ property to a property of the data item. To see how to do this read [here](#Using_ContainerBindings).

The specific here is that your data item should expose a property of type __Image__, so the __Icon__ property can be bound properly. In most of the cases you will use this property with the __RadMenuItem__, so you can make it read-only property, that wraps another property of your data item. For example, here is an __ImageUrl__ property of type __Uri__, that is wrapped inside an __Icon__ property of type __Image__.

#### __C#__

{{region radmenu-features-icons_1}}
	public class MenuItem
	{
	    ...
	
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
	                Source = new BitmapImage( this.IconUrl )
	            };
	        }
	    }
	
	    ...
	}
	{{endregion}}



#### __VB.NET__

{{region radmenu-features-icons_2}}
	Public Class MenuItem
	 ...
	 Public Property IconUrl() As Uri
	  Get
	  End Get
	  Set
	  End Set
	 End Property
	 Public ReadOnly Property Icon() As Image
	  Get
	   Dim img As New Image()
	   img.Source = New BitmapImage(Me.IconUrl)
	   Return img
	  End Get
	 End Property
	 ...
	End Class
	{{endregion}}



The result is the same.

![](images/RadMenu_Features_Icons_01.png)

# See Also

 * [Checkable Items]({%slug radmenu-features-checkable-items%})

 * [Binding to Dynamic Data]({%slug radmenu-populating-with-data-binding-to-dynamic-data%})

 * [Commands]({%slug radmenu-features-commands%})
