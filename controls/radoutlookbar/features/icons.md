---
title: Icons
page_title: Icons
description: Icons
slug: radoutlookbar-features-icons
tags: icons
published: True
position: 5
---

# Icons



## 

The __RadOutlookBarItems__ expose the __Icon__ and __SmallIcon__ properties. They are of type __BitmapSource__ and they define the source of the picture placed infront of the content of the __RadOutlookBarItem__.
        

The __Icon__ property gets or sets the icon of the __RadOutlookBarItem__ when it is in normal state – not minimized
        ![outlookbar icons 01](images/outlookbar_features_icons_01.png)

The __SmallIcon__ property gets or sets the icon of the __RadOutlookBarItem__ when it is in the  [minimized area]({%slug radoutlookbar-visual-structure%}) or when it is in the __ItemDropDownContent__. The __ItemDropDownContent__ is the content of the pop up which is opened after you click the [overflow button]({%slug radoutlookbar-visual-structure%}) located in the lower right corner of the __RadOutlookBar__.
        ![outlookbar icons 02](images/outlookbar_features_icons_02.png)

>tip
            You can see how to bind the icon properties to e property of a business object in the Data Binding example in our online
            [SDK repository](https://github.com/telerik/xaml-sdk)
            , after navigating to OutlookBar/DataBinding
          

# See Also

 * [Visual Structure]({%slug radoutlookbar-visual-structure%})

 * [Templates]({%slug radoutlookbar-templates%})

 * [Data Binding]({%slug radoutlookbar-databinding%})
