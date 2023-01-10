---
title: Hide The Title
page_title: Hide The Title
description: Check our &quot;Hide The Title&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-hide-title
tags: hide,the,title
published: True
position: 6
---

# {{ site.framework_name }} RadRibbonView Hide The Title

The __RadRibbonView__'s API allows you to hide the __Title__ bar of your ribbon control

![Rad Ribbon View How To Change The Title](images/RadRibbonView_HowTo_ChangeTheTitle.png)

In order to do this, you need to set the __RadRibbonView__'s __TitleBarVisibility__ property to __Visibility.Collapsed__.

#### __XAML__

{{region radribbonview-howto-hide-title_0}}
	<telerik:RadRibbonView x:Name="xRibbonView" TitleBarVisibility="Collapsed" />
{{endregion}}

#### __C#__

{{region radribbonview-howto-hide-title_1}}
	xRibbonView.TitleBarVisibility = Visibility.Collapsed;
{{endregion}}

#### __VB.NET__

{{region radribbonview-howto-hide-title_2}}
	xRibbonView.TitleBarVisibility = Visibility.Collapsed;
{{endregion}}

The result is shown on the next image - the title is hidden.
![Rad Ribbon View How To Hide The Title](images/RadRibbonView_HowTo_HideTheTitle.png)

>The __QuckAccessToolBar__ will be also hidden.		  

## See Also
 * [Handle double click on application button]({%slug radribbonview-how-to-handle-double-click-on-application-button%})
 * [Add Screen Tips in the Code Behind]({%slug radribbonview-howto-add-screentips-code-behind%})
 * [Change the Application Menu's Image]({%slug radribbonview-how-to-change-the-image-of-the-application-button%})