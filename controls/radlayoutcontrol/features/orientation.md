---
title: Orientation
page_title: Orientation
description: Check our &quot;Orientation&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
slug: radlayoutcontrol-features-orientation
tags: orientation, vertical, horizontal
published: True
position: 2
---

# {{ site.framework_name }} RadLayoutControl Orientation

__RadLayoutControl__ and _the _layout groups__ are ordering their children with a horizontal orientation by default. You can change this and arrange the child items in a vertical order by setting the control's __Orientation__ property to Vertical. 

The property is an enumeration of type __System.Windows.Controls.Orientation__ and exposes the following values:
* __Horizontal__: The layout will be oriented horizontally.
* __Vertical__: The layout will be oriented vertically.

#### __[XAML] Example 1: Setting the Orientation property of RadLayoutControl__
{{region radlayoutcontrol-features-orientation-0}}
	<telerik:RadLayoutControl Orientation="Vertical"/>
{{endregion}}
	
#### __[XAML] Example 2: Setting the Orientation property of LayoutControlGroup__
{{region radlayoutcontrol-features-orientation-1}}
	<telerik:LayoutControlGroup Orientation="Vertical"/>
{{endregion}}

#### __Figure 1: Horizontal and Vertical orientations__  
![{{ site.framework_name }} RadLayoutControl Horizontal and Vertical orientations](images/layoutcontrol-features-orientation-01.png)
		
> The __Orientation__ property doesn't affect the __LayoutControlTabGroup__.
	
## See Also
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [Edit the Layout]({%slug radlayoutcontrol-edit-the-layout%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
