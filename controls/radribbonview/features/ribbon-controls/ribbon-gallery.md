---
title: Ribbon Gallery
page_title: Ribbon Gallery
description: Ribbon Gallery
slug: radribbonview-ribbon-gallery
tags: ribbon,gallery
published: True
position: 6
---

# Ribbon Gallery



Telerik __RadRibbonView__ provides a simple and consistent way for building interfaces similar to the ribbon control used in Microsoft Office. The __RadRibbonView__ may consist of various elements, one of which is the __Ribbon Gallery__. This topic discusses concepts fundamental to the __Ribbon Gallery__ at first and then goes into the usage of the __RadRibbonGallery__ class and its features.
	  

>tipBefore proceeding with this tutorial, it is recommended to get familiar with the [Visual Structure]({%slug radribbonview-visual-structure%}) of the __RadRibbonView__ control.
		

## Ribbon Gallery - Fundamentals 

__Galleries__ are simple, but a very powerful and flexible user interface concept. They are basically a scrollable list of items and the idea behind them is that each item shows the result of clicking it visually, rather than a static icon which points its purpose.
		

The gallery is always rendered in two ways:

* As a popup inside a __RadRibbonDropDownButton__ or in __RadRibbonSplitButton__.
			![](images/RibbonView_Gallery_popup.png)

* Directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}).
			![](images/RibbonView_Gallery_group.png)

>tipThe classes that represent the ribbon gallery are __Telerik.Windows.Controls.RadRibbonGallery__and __Telerik.Windows.Controls.RadGallery__.
		  

The __RadGallery__ is a special type of __ListBox__ (it derives from __ListBox__). The __RadGallery__class is used when you want to add a ribbon gallery as a popup. One important feature of the __RadGallery__ is that it is __scrollable__. That's why you should always specify the [ViewportWidth](http://msdn.microsoft.com/en-us/library/system.windows.controls.scrollviewer.viewportwidth.aspx) and [ViewportHeight](http://msdn.microsoft.com/en-us/library/system.windows.controls.scrollviewer.viewportheight.aspx) properties. These two properties control the horizontal and vertical size of the content's viewport. On the other hand, the size of the items themselves is controlled by the __ItemWidth__and __ItemHeight__properties.
		

>tipWhen you want to declare a ribbon gallery inside a [RadRibbonDropDownButton]({%slug radribbonview-dropdown-button%})/[RadRibbonSplitButton]({%slug radribbonview-split-button%}) use the __RadGallery__ class.
		  

>tipWhen you use the __RadGallery__ class, you __should always specify__ the __ViewportWidht__ and __ViewportHeight__ properties.
		  

The __RadRibbonGallery__ is a special type of gallery (it derives from __RadGallery__ class), that is designed to be hosted directly in a __RadRibbonControl__. Like the normal __RadGallery__, it has __Viewport Width\Height__ and __Item Width\Height__. However, the viewport is constrained to the size of the ribbon itself.
		

>tipWhen you use the __RadRibbonGallery__ class, __do not specify__ the __ViewportWidth__ and __ViewportHeight__ properties.
		  

The __RadRibbonGallery__ always should have a popup associated with it, otherwise the user won't be able to drop down the ribbon gallery. In the popup you may want to include a __RadMenu__that has other additional options regarding the gallery. However, when you drop down a __RadRibbonGallery__the items are automatically moved into the popup. So even if you specify a menu, the first item in the popup will be a gallery. On the other hand, while the items are hosted in the ribbon you can page up/down smoothly using the buttons inside the gallery.
		![](images/RibbonView_Gallery_elements.png)

>tipWhen you want to declare a ribbon gallery directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}) use the __RadRibbonGallery__ class.
		  

## Adding Ribbon Galleries to a RadRibbonView Control

Ribbon gallery can be always rendered in two ways - inside a [RadRibbonDropDownButton]({%slug radribbonview-dropdown-button%})/[RadRibbonSplitButton]({%slug radribbonview-split-button%}) or directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}).
		

### Adding Ribbon Gallery Inside a RadRibbonDropDownButton/RadRibbonSplitButton

When you want to declare a __Ribbon Gallery__as popup inside a [RadRibbonDropDownButton]({%slug radribbonview-dropdown-button%})/[RadRibbonSplitButton]({%slug radribbonview-split-button%}), you should use the __RadGallery__ class. The next example demonstrates how to do that.
			

#### __XAML__

{{region radribbonview-ribbon-gallery-0}}
	<telerik:RadRibbonView x:Name="radRibbonView">
	    <telerik:RadRibbonTab Header="Home">
	        <telerik:RadRibbonGroup Header="Font" DialogLauncherVisibility="Visible">
	            <StackPanel>
	                <telerik:RadRibbonSplitButton x:Name="UnderlineButton"
	                        SmallImage="Images/IconMSOffice/16/underline.png">
	                    <telerik:RadRibbonSplitButton.DropDownContent>
	                        <StackPanel>
	                            <telerik:RadGallery ViewportWidth="157" ViewportHeight="84" ItemWidth="156"
	                                    ItemHeight="26">
	                                <telerik:RadGalleryItem Image="Images/IconMSOffice/underline1.png"
	                                        ToolTipService.ToolTip="Underline" />
	                                <telerik:RadGalleryItem Image="Images/IconMSOffice/underline2.png"
	                                        ToolTipService.ToolTip="Double underline" />
	                                <telerik:RadGalleryItem Image="Images/IconMSOffice/underline3.png"
	                                        ToolTipService.ToolTip="Thick underline" />
	                            </telerik:RadGallery>
	                        </StackPanel>
	                    </telerik:RadRibbonSplitButton.DropDownContent>
	                </telerik:RadRibbonSplitButton>
	            </StackPanel>
	        </telerik:RadRibbonGroup>
	    </telerik:RadRibbonTab>
	</telerik:RadRibbonView>
	{{endregion}}



Note that when you use the __RadGallery__, you should specify the __ViewportWidth__ and __ViewportHeight__ properties. These two properties control the horizontal and vertical size of the content's viewport. On the other hand, the size of the items themselves is controlled by the __ItemWidth__and __ItemHeight__properties. The result from the example is shown on the next two snapshots.
			![](images/RibbonView_Gallery_splitBtn.png)

When you press the popup launch button, the gallery is shown.![](images/RibbonView_Gallery_SplitBtn_Popup.png)

### Adding Ribbon Gallery Directly Into a Ribbon Group

When you want to declare a __Ribbon Gallery__directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}), you should use the __RadRibbonGallery__ class. Consider again the previous example, add an additional __RadRibbonGroup__ and declare a __RadRibbonGallery__ like in the example below.
			

#### __XAML__

{{region radribbonview-ribbon-gallery-1}}
	<telerik:RadRibbonView x:Name="radRibbonView">
	    <telerik:RadRibbonTab Header="Home">
	        <telerik:RadRibbonGroup Header="Font" DialogLauncherVisibility="Visible">
	            <StackPanel>
	                <telerik:RadRibbonSplitButton x:Name="UnderlineButton"
	                        SmallImage="Images/IconMSOffice/16/underline.png">
	                    <telerik:RadRibbonSplitButton.DropDownContent>
	                        <StackPanel>
	                            <telerik:RadGallery ViewportWidth="157" ViewportHeight="84" ItemWidth="156"
	                                    ItemHeight="26">
	                                <telerik:RadGalleryItem
	                                        Image="Images/IconMSOffice/underline1.png"
	                                        ToolTipService.ToolTip="Underline" />
	                                <telerik:RadGalleryItem
	                                        Image="Images/IconMSOffice/underline2.png"
	                                        ToolTipService.ToolTip="Double underline" />
	                                <telerik:RadGalleryItem
	                                        Image="Images/IconMSOffice/underline3.png"
	                                        ToolTipService.ToolTip="Thick underline" />
	                            </telerik:RadGallery>
	                        </StackPanel>
	                    </telerik:RadRibbonSplitButton.DropDownContent>
	                </telerik:RadRibbonSplitButton>
	            </StackPanel>
	        </telerik:RadRibbonGroup>
	        <telerik:RadRibbonGroup Header="Styles" DialogLauncherVisibility="Visible">
	            <telerik:RadRibbonGallery Title="Quick Styles" x:Name="QuickStyles" ItemWidth="72" ItemHeight="56">
	                <telerik:RadGalleryItem IsSelected="True" Name="Normal"
	                        Image="Images/IconMSOffice/paragraph.png"
	                        ToolTipService.ToolTip="Normal" />
	                <telerik:RadGalleryItem Name="No_Spacing"
	                        Image="Images/IconMSOffice/paragraph9.png"
	                        ToolTipService.ToolTip="No Spacing" />
	                <telerik:RadGalleryItem Name="Heading1"
	                        Image="Images/IconMSOffice/paragraph8.png"
	                        ToolTipService.ToolTip="Heading 1" />
	                <telerik:RadGalleryItem Name="Heading2"
	                        Image="Images/IconMSOffice/paragraph7.png"
	                        ToolTipService.ToolTip="Heading 2" />
	                <telerik:RadGalleryItem Name="Title"
	                        Image="Images/IconMSOffice/paragraph6.png"
	                        ToolTipService.ToolTip="Title" />
	                <telerik:RadGalleryItem Name="Subtitle"
	                        Image="Images/IconMSOffice/paragraph5.png"
	                        ToolTipService.ToolTip="Subtitle" />
	                <telerik:RadGalleryItem Name="Subtitle_Emphasis"
	                        Image="Images/IconMSOffice/paragraph4.png"
	                        ToolTipService.ToolTip="Subtitle Emphasis" />
	                <telerik:RadGalleryItem Name="Emphasis"
	                        Image="Images/IconMSOffice/paragraph3.png"
	                        ToolTipService.ToolTip="Emphasis" />
	                <telerik:RadGalleryItem Name="Intense_Emphasis"
	                        Image="Images/IconMSOffice/paragraph2.png"
	                        ToolTipService.ToolTip="Intense Emphasis" />
	                <telerik:RadGalleryItem Name="Strong"
	                        Image="Images/IconMSOffice/paragraph1.png"
	                        ToolTipService.ToolTip="Strong" />
	            </telerik:RadRibbonGallery>
	        </telerik:RadRibbonGroup>
	    </telerik:RadRibbonTab>
	</telerik:RadRibbonView>
	{{endregion}}



The result is shown on the image below.![](images/RibbonView_Gallery_ribbongallery.png)

When you press the popup launch button, the gallery is shown. ![](images/RibbonView_Gallery_ribbongallery_popup.png)

>tipWhile the items are hosted in the ribbon, you could __page up/down__ smoothly using the buttons beside the gallery.
			  

## Adding Additional Menu Items to a RadGallery 

The __RadGallery__ allows you to place in the popup additional menu options regarding the gallery. For that purpose you should use the __RadContextMenu__ control.
		

The next code snippet demonstrates how to add additional menu items.

#### __XAML__

{{region radribbonview-ribbon-gallery-2}}
	<telerik:RadRibbonView x:Name="radRibbonView">
	    <telerik:RadRibbonTab Header="Home">
	        <telerik:RadRibbonGroup Header="Font" DialogLauncherVisibility="Visible">
	            <StackPanel>
	                <telerik:RadRibbonSplitButton x:Name="UnderlineButton"
	                        SmallImage="Images/IconMSOffice/16/underline.png">
	                    <telerik:RadRibbonSplitButton.DropDownContent>
	                        <StackPanel>
	                            <telerik:RadGallery ViewportWidth="157" ViewportHeight="84" ItemWidth="156"
	                                    ItemHeight="26">
	                                <telerik:RadGalleryItem Image="Images/IconMSOffice/underline1.png"
	                                        ToolTipService.ToolTip="Underline" />
	                                <telerik:RadGalleryItem Image="Images/IconMSOffice/underline2.png"
	                                        ToolTipService.ToolTip="Double underline" />
	                                <telerik:RadGalleryItem Image="Images/IconMSOffice/underline3.png"
	                                        ToolTipService.ToolTip="Thick underline" />
	                            </telerik:RadGallery>
	                            <telerik:RadContextMenu BorderThickness="0">
	                                <telerik:RadMenuItem Header="More underlines ..." />
	                                <telerik:RadMenuItem Header="Underline color">
	                                    <telerik:RadMenuItem.Icon>
	                                        <Image Source="Images/IconMSOffice/colorpicker.png" />
	                                    </telerik:RadMenuItem.Icon>
	                                </telerik:RadMenuItem>
	                            </telerik:RadContextMenu>
	                        </StackPanel>
	                    </telerik:RadRibbonSplitButton.DropDownContent>
	                </telerik:RadRibbonSplitButton>
	            </StackPanel>
	        </telerik:RadRibbonGroup>
	    </telerik:RadRibbonTab>
	</telerik:RadRibbonView>
	{{endregion}}



And the result is shown on the next image.![](images/RibbonView_Gallery_group_contextMenu.png)

## Adding Additional Menu Items to a RadRibbonGallery

You could also associate additional menu options with the __RadRibbonGallery__ popup. In contrast to the __RadGallery__ class, here the __RadRibbonGallery__ exposes a special property for that purpose - __PopupMenuItems__.
		

In the next example several __RadMenuItem__ objects are added to the __RadRibbonGallery__'s __PopupMenuItems__ collection.
		

#### __XAML__

{{region radribbonview-ribbon-gallery-3}}
	<telerik:RadRibbonView x:Name="radRibbonView">
	    <telerik:RadRibbonTab Header="Home">
	        <telerik:RadRibbonGroup Header="Styles" DialogLauncherVisibility="Visible">
	            <telerik:RadRibbonGallery Title="Quick Styles" x:Name="QuickStyles" ItemWidth="72" ItemHeight="56">
	                <telerik:RadRibbonGallery.PopupMenuItems>
	                    <telerik:RadMenuItem Header="Save Selection as a Quick Style..." />
	                    <telerik:RadMenuItem Header="Clear Formatting" />
	                    <telerik:RadMenuItem Header="Apply Styles..." />
	                </telerik:RadRibbonGallery.PopupMenuItems>
	                <telerik:RadGalleryItem IsSelected="True" Name="Normal"
	                        Image="Images/IconMSOffice/paragraph.png" ToolTipService.ToolTip="Normal" />
	                <telerik:RadGalleryItem Name="No_Spacing" Image="Images/IconMSOffice/paragraph9.png"
	                        ToolTipService.ToolTip="No Spacing" />
	                <telerik:RadGalleryItem Name="Heading1" Image="Images/IconMSOffice/paragraph8.png"
	                        ToolTipService.ToolTip="Heading 1" />
	                <telerik:RadGalleryItem Name="Heading2" Image="Images/IconMSOffice/paragraph7.png"
	                        ToolTipService.ToolTip="Heading 2" />
	                <telerik:RadGalleryItem Name="Title" Image="Images/IconMSOffice/paragraph6.png"
	                        ToolTipService.ToolTip="Title" />
	                <telerik:RadGalleryItem Name="Subtitle" Image="Images/IconMSOffice/paragraph5.png"
	                        ToolTipService.ToolTip="Subtitle" />
	                <telerik:RadGalleryItem Name="Subtitle_Emphasis" Image="Images/IconMSOffice/paragraph4.png"
	                        ToolTipService.ToolTip="Subtitle Emphasis" />
	                <telerik:RadGalleryItem Name="Emphasis" Image="Images/IconMSOffice/paragraph3.png"
	                        ToolTipService.ToolTip="Emphasis" />
	                <telerik:RadGalleryItem Name="Intense_Emphasis" Image="Images/IconMSOffice/paragraph2.png"
	                        ToolTipService.ToolTip="Intense Emphasis" />
	                <telerik:RadGalleryItem Name="Strong" Image="Images/IconMSOffice/paragraph1.png"
	                        ToolTipService.ToolTip="Strong" />
	            </telerik:RadRibbonGallery>
	        </telerik:RadRibbonGroup>
	    </telerik:RadRibbonTab>
	</telerik:RadRibbonView>
	{{endregion}}

![](images/RibbonView_Gallery_ribbongallery_contextMenu.png)

## Adding Header RadRibbonGalleryItems

You can visually group the __RadRibbonGallery__ items when the gallery is in open state. You can do that by defining some of the __RadRibbonGalleryItems__ as headers through the __IsHeader__ bool property.
		

However, in order to properly display header items in the __RadRibbonGallery__, you need to change its default __ItemsPanel__ to a __RibbonGalleryPanel__:
		

#### __XAML__

{{region radribbonview-ribbon-gallery-6}}
	<telerik:RadRibbonGallery>
	    <telerik:RadRibbonGallery.ItemsPanel>
	        <ItemsPanelTemplate>
	            <telerikRibbonViewPrimitives:RibbonGalleryPanel />
	        </ItemsPanelTemplate>
	    </telerik:RadRibbonGallery.ItemsPanel>
	    <telerik:RadGalleryItem Content="Header1" IsHeader="True" />
	    <telerik:RadGalleryItem Content="Item 1.1" />
		<telerik:RadGalleryItem Content="Item 1.2" />
		<telerik:RadGalleryItem Content="Item 1.3" />
	    <telerik:RadGalleryItem Content="Header2" IsHeader="True" />
	    <telerik:RadGalleryItem Content="Item 2.1" />
		<telerik:RadGalleryItem Content="Item 2.2" />
		<telerik:RadGalleryItem Content="Item 2.3" />
	    <telerik:RadGalleryItem Content="Header3" IsHeader="True" />
	    <telerik:RadGalleryItem Content="Item 3.1" />
		<telerik:RadGalleryItem Content="Item 3.2" />
	</telerik:RadRibbonGallery>
	{{endregion}}

![Rad Ribbon View Ribbon Gallery Headers](images/RadRibbonView_RibbonGallery_Headers.png)

>The 
			__telerikRibbonViewPrimitives__ alias points to the __Telerik.Windows.Controls.RibbonView.Primitives__ namespace:xmlns:telerikRibbonViewPrimitives="clr-namespace:Telerik.Windows.Controls.RibbonView.Primitives;assembly=Telerik.Windows.Controls.RibbonView"

## Setting RadRibbonGallery's PopupLaunchButtonVisibility

The __RadRibbonGallery__ class allows you to set the visibility of the launch popup button. The next example shows you how to set the __RadRibbonGallery__'s __PopupLaunchButtonVisibility__ property to __Visibility.Collapsed__.
		

#### __XAML__

{{region radribbonview-ribbon-gallery-4}}
	<telerik:RadRibbonGallery Title="Quick Styles" x:Name="QuickStyles" ItemWidth="72" ItemHeight="56" PopupLaunchButtonVisibility="Collapsed">
	 ...
	</telerik:RadRibbonGallery>
	{{endregion}}

![](images/RibbonView_Gallery_disable_popup.png)

## Working with Selection

The __RadGallery__ derives directly from __ListBox__. So working with it is no different than using a standard __ListBox__ control. Here are the related properties regarding the selection:
		

* __RadGallery.SelectedItem__ - specifies the selected gallery item.
			

* __RadGallery.SelectedIndex__ - specifies the selected index.
			

* __RadGalleryItem.IsSelected__ - specifies whether the item is selected or not.
			

Also, to get notified about the change in the selection you can handle the __SelectionChanged__ event.
		

## Events

The __RadGallery__ class exposes two events - __ActivatePreview__ and __DeactivatePreview__.
		

The __ActivatePreview__ event is raised when the mouse cursor is over the gallery item. The __ActivatePreview__ event handler receives two arguments:
		

* The sender argument contains the __RadGallery__. This argument is of type __object__, but can be cast to the __RadGallery__type.
			

* The second argument is a __RadRoutedEventArgs__ object.
			

The __DeactivatePreview__ event is raised when the mouse cursor leaves the gallery item. The __DeactivatePreview__ event handler receives two arguments:
		

* The sender argument contains the __RadGallery__. This argument is of type __object__, but can be cast to the __RadGallery__type.
			

* The second argument is a __RadRoutedEventArgs__ object.
			

>tipSince the __RadRibbonGallery__ inherits the __RadGallery__ class, you can handle the __ActivatePreview__ and __DeactivatePreview__ events in the__RadRibbonGallery__ control as well.
		  

#### __XAML__

{{region radribbonview-ribbon-gallery-5}}
	<telerik:RadRibbonGallery Title="Quick Styles" x:Name="QuickStyles" ItemWidth="72" ItemHeight="56" 
	                          ActivatePreview="QuickStyles_ActivatePreview" 
	                          DeactivatePreview="QuickStyles_DeactivatePreview">
	 ...
	</telerik:RadRibbonGallery>
	{{endregion}}



#### __C#__

{{region radribbonview-ribbon-gallery_6}}
	private void QuickStyles_ActivatePreview(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
	 // Grab the RadRibbonGallery object
	 RadRibbonGallery gallery = sender as RadRibbonGallery;
	 // Get the selected item
	 RadGalleryItem selectedItem = gallery.SelectedItem as RadGalleryItem;
	}
	private void QuickStyles_DeactivatePreview(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
	 // Grab the RadRibbonGallery object
	 RadRibbonGallery gallery = sender as RadRibbonGallery;
	 // Get the selected item
	 RadGalleryItem selectedItem = gallery.SelectedItem as RadGalleryItem;
	}
	{{endregion}}



#### __VB.NET__

{{region radribbonview-ribbon-gallery_7}}
	Private Sub QuickStyles_ActivatePreview(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
		' Grab the RadRibbonGallery object
		Dim gallery As RadRibbonGallery = TryCast(sender, RadRibbonGallery)
		' Get the selected item
		Dim selectedItem As RadGalleryItem = TryCast(gallery.SelectedItem, RadGalleryItem)
	
	End Sub
	
	Private Sub QuickStyles_DeactivatePreview(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
		' Grab the RadRibbonGallery object
		Dim gallery As RadRibbonGallery = TryCast(sender, RadRibbonGallery)
		' Get the selected item
		Dim selectedItem As RadGalleryItem = TryCast(gallery.SelectedItem, RadGalleryItem)
	End Sub
	{{endregion}}



For a full list of the exposed by the __RadRibbonView__ events, take a look at the [Events - Overview]({%slug radribbonview-events-overview%}) topic.
		

The __RadRibbonView__ is a complex control and the __ribbon galleries__are only a small part of it. The __RadRibbonView__ consists of various elements such as:
		

* [Application Menu]({%slug radribbonview-applicationmenu%})

* [Backstage Menu]({%slug radribbonview-ribbon-backstage%})

* [Quick Access ToolBar]({%slug radribbonview-qat%})

* [Ribbon Tab]({%slug radribbonview-ribbon-tab%})

* [Ribbon Group]({%slug radribbonview-ribbon-group%})

* [RibbonButtons Overview]({%slug radribbonview-buttons-overview%})

* [Ribbon ComboBox]({%slug radribbonview-ribbon-combobox%})

* [Screen Tips]({%slug radribbonview-screentips%})

# See Also

 * [Selection]({%slug radribbonview-selection%})

 * [Resizing]({%slug radribbonview-resizing%})

 * [Minimization]({%slug radribbonview-minimization%})

 * [Localization]({%slug radribbonview-localization%})

 * [Styling the RadRibbonGallery]({%slug radribbonview-styling-ribbongallery%})
