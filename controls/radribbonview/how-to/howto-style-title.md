---
title: Style The Title
page_title: Style RadRibbonView Title
description: Check our &quot;Style The Title&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-style-title
tags: hide,the,title
published: True
position: 6
---

# Style The Title

The __RadRibbonView__'s API allows you to customize the __Title__ bar of your ribbon control. First we are going to use the code in __Example 1__ as a starting point.

__Example 1: Sample RadRibbonView__

<snippet id='radribbonview-how-to-howto-style-title-block_1-xaml' />

![Rad Ribbon View How To Style The Title](images/RadRibbonView_HowTo_StyleTheTitle.png)

To customize the foreground of text in the title bar, we can create a custom style targeting WindowTitle and set the Foreground property. 

>You can access the __WindowTitle__ control through an alias pointing to the namespace: __xmlns:ribbonPrimitives="clr-namespace:Telerik.Windows.Controls.RibbonView.Primitives;assembly=Telerik.Windows.Controls.RibbonView"__

__Example 2: Change Title Foreground__
<snippet id='radribbonview-how-to-howto-style-title-block_2-xaml' />

![Rad Ribbon View How To Style The Title 2](images/RadRibbonView_HowTo_StyleTheTitle_2.png)

To change the title bar background, you can set the __TitleBarBackground__ property of the RadRibbonView.

__Example 3: Change Title Foreground__
<snippet id='radribbonview-how-to-howto-style-title-block_3-xaml' />

![Rad Ribbon View How To Style The Title 2](images/RadRibbonView_HowTo_StyleTheTitle_3.png)

## See Also
 * [Handle double click on application button]({%slug radribbonview-how-to-handle-double-click-on-application-button%})
 * [Add Screen Tips in the Code Behind]({%slug radribbonview-howto-add-screentips-code-behind%})
 * [Change the Application Menu's Image]({%slug radribbonview-how-to-change-the-image-of-the-application-button%})