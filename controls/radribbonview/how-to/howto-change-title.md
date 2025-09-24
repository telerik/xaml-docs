---
title: Change Title
page_title: Change Title
description: Check our &quot;Change Title&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-change-title
tags: change,title
published: True
position: 5
---

# Change Title

The purpose of this topic is to show you how to change the __RadRibbonView__'s __Title__
![Rad Ribbon View How To Change The Title](images/RadRibbonView_HowTo_ChangeTheTitle.png)

The RadRibbonView exposes a string property named __Title__, which should be used in such cases.		



```XAML
	<telerik:RadRibbonView x:Name="xRibbonView" Title="RadRibbonView Demo" />
```



```C#
	xRibbonView.Title = "RadRibbonView Demo";
```



```VB.NET
	xRibbonView.Title = "RadRibbonView Demo";
```

![Rad Ribbon View How To Change The Title 2](images/RadRibbonView_HowTo_ChangeTheTitle_2.png)

>The __RadRibbonView__'s __Title__ is not entirely changed. Instead, your custom title string is combined with the default "My Application" string. To change the string "My Application" you have to set the __RadRibbonView.ApplciationName__ property to the value you want.

## See Also
 * [Handle double click on application button]({%slug radribbonview-how-to-handle-double-click-on-application-button%})
 * [Add Screen Tips in the Code Behind]({%slug radribbonview-howto-add-screentips-code-behind%})
 * [Change the Application Menu's Image]({%slug radribbonview-how-to-change-the-image-of-the-application-button%})