---
title: Ribbon Gallery
page_title: Ribbon Gallery
description: Check our &quot;Ribbon Gallery&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-ribbon-gallery
tags: ribbon,gallery
published: True
position: 6
---

# Ribbon Gallery

Telerik __RadRibbonView__ provides a simple and consistent way for building interfaces similar to the ribbon control used in Microsoft Office. The __RadRibbonView__ may consist of various elements, one of which is the __Ribbon Gallery__. This topic discusses concepts fundamental to the __Ribbon Gallery__ at first and then goes into the usage of the __RadRibbonGallery__ class and its features.	  

>tip Before proceeding with this tutorial, it is recommended to get familiar with the [Visual Structure]({%slug radribbonview-visual-structure%}) of the __RadRibbonView__ control.		

## Ribbon Gallery - Fundamentals 

__Galleries__ are simple, but a very powerful and flexible user interface concept. They are basically a scrollable list of items and the idea behind them is that each item shows the result of clicking it visually, rather than a static icon which points its purpose.		

The gallery is always rendered in two ways:

* As a popup inside a __RadRibbonDropDownButton__ or in __RadRibbonSplitButton__.
![{{ site.framework_name }} RadRibbonView Ribbon Gallery Popup](images/RibbonView_Gallery_popup.png)

* Directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}).
![{{ site.framework_name }} RadRibbonView Ribbon Gallery in Group](images/RibbonView_Gallery_group.png)

>tip The classes that represent the ribbon gallery are __Telerik.Windows.Controls.RadRibbonGallery__ and __Telerik.Windows.Controls.RadGallery__.		  

The __RadGallery__ is a special type of __ListBox__ (it derives from __ListBox__). The __RadGallery__ class is used when you want to add a ribbon gallery as a popup. One important feature of the __RadGallery__ is that it is __scrollable__. That's why you should always specify the [ViewportWidth](http://msdn.microsoft.com/en-us/library/system.windows.controls.scrollviewer.viewportwidth.aspx) property. This controls the horizontal size of the content's viewport. On the other hand, the size of the items themselves is controlled by the __ItemWidth__ and __ItemHeight__ properties.		

>tip When you want to declare a ribbon gallery inside a [RadRibbonDropDownButton]({%slug radribbonview-dropdown-button%})/[RadRibbonSplitButton]({%slug radribbonview-split-button%}) use the __RadGallery__ class.		  

>tip When you use the __RadGallery__ class, you __should always specify__ the __ViewportWidht__ property.

The __RadRibbonGallery__ is a special type of gallery (it derives from __RadGallery__ class), that is designed to be hosted directly in a __RadRibbonControl__. Like the normal __RadGallery__, it has __Viewport Width\Height__ and __Item Width\Height__. However, the viewport is constrained to the size of the ribbon itself.		

>tip When you use the __RadRibbonGallery__ class, __do not specify__ the __ViewportWidth__ property.

The __RadRibbonGallery__ always should have a popup associated with it, otherwise the user won't be able to drop down the ribbon gallery. In the popup you may want to include a __RadMenu__ that has other additional options regarding the gallery. However, when you drop down a __RadRibbonGallery__ the items are automatically moved into the popup. So even if you specify a menu, the first item in the popup will be a gallery. On the other hand, while the items are hosted in the ribbon you can page up/down smoothly using the buttons inside the gallery.
![{{ site.framework_name }} RadRibbonView Gallery Buttons](images/RibbonView_Gallery_elements.png)

>tip When you want to declare a ribbon gallery directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}) use the __RadRibbonGallery__ class.		  

## Adding Ribbon Galleries to a RadRibbonView Control

Ribbon gallery can be always rendered in two ways - inside a [RadRibbonDropDownButton]({%slug radribbonview-dropdown-button%})/[RadRibbonSplitButton]({%slug radribbonview-split-button%}) or directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}).		

### Adding Ribbon Gallery Inside a RadRibbonDropDownButton/RadRibbonSplitButton

When you want to declare a __Ribbon Gallery__ as popup inside a [RadRibbonDropDownButton]({%slug radribbonview-dropdown-button%})/[RadRibbonSplitButton]({%slug radribbonview-split-button%}), you should use the __RadGallery__ class. The next example demonstrates how to do that.			


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_1-xaml' />

Note that when you use the __RadGallery__, you should specify the __ViewportWidth__ property. It controls the horizontal size of the content's viewport. On the other hand, the size of the items themselves is controlled by the __ItemWidth__ and __ItemHeight__ properties. The result from the example is shown on the next two snapshots.

![{{ site.framework_name }} RadRibbonView Gallery Split Button](images/RibbonView_Gallery_splitBtn.png)

When you press the popup launch button, the gallery is shown.

![{{ site.framework_name }} RadRibbonView Gallery Split Button Popup](images/RibbonView_Gallery_SplitBtn_Popup.png)

### Adding Ribbon Gallery Directly Into a Ribbon Group

When you want to declare a __Ribbon Gallery__ directly into a [Ribbon Group]({%slug radribbonview-ribbon-group%}), you should use the __RadRibbonGallery__ class. Consider again the previous example, add an additional __RadRibbonGroup__ and declare a __RadRibbonGallery__ like in the example below.			


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_2-xaml' />

The result is shown on the image below.
![{{ site.framework_name }} RadRibbonView Ribbon Gallery](images/RibbonView_Gallery_ribbongallery.png)

When you press the popup launch button, the gallery is shown. 
![{{ site.framework_name }} RadRibbonView Ribbon Gallery Popup](images/RibbonView_Gallery_ribbongallery_popup.png)

>tip While the items are hosted in the ribbon, you could __page up/down__ smoothly using the buttons beside the gallery.			  

## Adding Additional Menu Items to a RadGallery 

The __RadGallery__ allows you to place in the popup additional menu options regarding the gallery. For that purpose you should use the __RadContextMenu__ control.		

The next code snippet demonstrates how to add additional menu items.


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_3-xaml' />

And the result is shown on the next image.
![{{ site.framework_name }} RadRibbonView Gallery Group Context Menu](images/RibbonView_Gallery_group_contextMenu.png)

## Adding Additional Menu Items to a RadRibbonGallery

You could also associate additional menu options with the __RadRibbonGallery__ popup. In contrast to the __RadGallery__ class, here the __RadRibbonGallery__ exposes a special property for that purpose - __PopupMenuItems__.		

In the next example several __RadMenuItem__ objects are added to the __RadRibbonGallery__'s __PopupMenuItems__ collection.		


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_4-xaml' />

![{{ site.framework_name }} RadRibbonView Ribbon Gallery Context Menu](images/RibbonView_Gallery_ribbongallery_contextMenu.png)

## Adding Header RadRibbonGalleryItems

You can visually group the __RadRibbonGallery__ items when the gallery is in open state. You can do that by defining some of the __RadRibbonGalleryItems__ as headers through the __IsHeader__ bool property.		

However, in order to properly display header items in the __RadRibbonGallery__, you need to change its default __ItemsPanel__ to a __RibbonGalleryPanel__:		


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_5-xaml' />

![Rad Ribbon View Ribbon Gallery Headers](images/RadRibbonView_RibbonGallery_Headers.png)

>The __telerikRibbonViewPrimitives__ alias points to the __Telerik.Windows.Controls.RibbonView.Primitives__
>`namespace:xmlns:telerikRibbonViewPrimitives="clr-namespace:Telerik.Windows.Controls.RibbonView.Primitives;assembly=Telerik.Windows.Controls.RibbonView"`

## Setting RadRibbonGallery's PopupLaunchButtonVisibility

The __RadRibbonGallery__ class allows you to set the visibility of the launch popup button. The next example shows you how to set the __RadRibbonGallery__'s __PopupLaunchButtonVisibility__ property to __Visibility.Collapsed__.		


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_6-xaml' />

![{{ site.framework_name }} RadRibbonView Ribbon Gallery Disabled Popup Button](images/RibbonView_Gallery_disable_popup.png)

{% if site.site_name == 'WPF' %}

## Setting RadRibbonGallery's LayoutMode

Since the __R2 2019__ version, the RadRibbonGallery exposes a __LayoutMode__ property, which is of type __RibbonLayout__. When this property is set to __Simplified__, the scroll buttons are collapsed and the RadRibbonGroup has a more streamlined look. This property is useful when the RadRibbonGroup is in the __SimplifiedItems__ of a RadRibbonTab. For more information about it, check out the [Simplified Ribbon]({%slug radribbonview-simplified-ribbon%}) article.

{% endif %}

## Working with Selection

The __RadGallery__ derives directly from __ListBox__. So working with it is no different than using a standard __ListBox__ control. Here are the related properties regarding the selection:		

* __RadGallery.SelectedItem__ - specifies the selected gallery item.		

* __RadGallery.SelectedIndex__ - specifies the selected index.			

* __RadGalleryItem.IsSelected__ - specifies whether the item is selected or not.			

Also, to get notified about the change in the selection you can handle the __SelectionChanged__ event.		

## Events

The __RadGallery__ class exposes two events - __ActivatePreview__ and __DeactivatePreview__.		

The __ActivatePreview__ event is raised when the mouse cursor is over the gallery item. The __ActivatePreview__ event handler receives two arguments:		
* The sender argument contains the __RadGallery__. This argument is of type __object__, but can be cast to the __RadGallery__ type.
* The second argument is a __RadRoutedEventArgs__ object.			

The __DeactivatePreview__ event is raised when the mouse cursor leaves the gallery item. The __DeactivatePreview__ event handler receives two arguments:
* The sender argument contains the __RadGallery__. This argument is of type __object__, but can be cast to the __RadGallery__ type.
* The second argument is a __RadRoutedEventArgs__ object.			

>tip Since the __RadRibbonGallery__ inherits the __RadGallery__ class, you can handle the __ActivatePreview__ and __DeactivatePreview__ events in the __RadRibbonGallery__ control as well.		  


<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_7-xaml' />



<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_8-cs' />
<snippet id='radribbonview-features-ribbon-controls-ribbon-gallery-block_9-vb' />

For a full list of the exposed by the __RadRibbonView__ events, take a look at the [Events - Overview]({%slug radribbonview-events-overview%}) topic.		

The __RadRibbonView__ is a complex control and the __ribbon galleries__ are only a small part of it. The __RadRibbonView__ consists of various elements such as:
* [Application Menu]({%slug radribbonview-applicationmenu%})
* [Backstage Menu]({%slug radribbonview-ribbon-backstage%})
* [Quick Access ToolBar]({%slug radribbonview-qat%})
* [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
* [Ribbon Group]({%slug radribbonview-ribbon-group%})
* [RibbonButtons Overview]({%slug radribbonview-buttons-overview%})
* [Ribbon ComboBox]({%slug radribbonview-ribbon-combobox%})
* [Screen Tips]({%slug radribbonview-screentips%})

## See Also
 * [Selection]({%slug radribbonview-selection%})
 * [Resizing]({%slug radribbonview-resizing%})
 * [Minimization]({%slug radribbonview-minimization%})
 * [Localization]({%slug radribbonview-localization%})
 * [Styling the RadRibbonGallery]({%slug radribbonview-styling-ribbongallery%})