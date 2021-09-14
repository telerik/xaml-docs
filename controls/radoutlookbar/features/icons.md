---
title: Icons
page_title: Icons
description: Check our &quot;Icons&quot; documentation article for the RadOutlookBar {{ site.framework_name }} control.
slug: radoutlookbar-features-icons
tags: icons
published: True
position: 5
---

# Icons

The __RadOutlookBarItems__ expose the __Icon__ and __SmallIcon__ properties. They are of type __BitmapSource__ and they define the source of the picture placed infront of the content of the __RadOutlookBarItem__.      

>tip As of __R3 2021__, the __RadOutlookBarItems__ expose an additional __IconMargin__ property. It is used to get or set the margin of the __Icon__ element inside of the item. 

The __Icon__ property gets or sets the icon of the __RadOutlookBarItem__ when it is in normal state – not minimized.

#### __Figure 1 : Setting Icon property__
![outlookbar icons 01](images/outlookbar_features_icons_01.png)

The __SmallIcon__ property gets or sets the icon of the __RadOutlookBarItem__ when it is in the  [minimized area]({%slug radoutlookbar-visual-structure%}) or when it is in the __ItemDropDownContent__. The __ItemDropDownContent__ is the content of the pop up which is opened after you click the [overflow button]({%slug radoutlookbar-visual-structure%}) located in the lower right corner of the __RadOutlookBar__.

#### __Figure 2 : Setting SmallIcon property__
![outlookbar icons 02](images/outlookbar_features_icons_02.png)

#### __Figure 3: Setting IconMargin property__
![outlookbar icons 03](images/outlookbar_features_icons_03.png)

>tip You can see how to bind the icon properties to e property of a business object in the [Data Binding example in the online SDK repository](https://github.com/telerik/xaml-sdk/tree/master/OutlookBar/DataBinding).

## See Also
 * [Visual Structure]({%slug radoutlookbar-visual-structure%})
 * [Templates]({%slug radoutlookbar-templates%})
 * [Data Binding]({%slug radoutlookbar-databinding%})