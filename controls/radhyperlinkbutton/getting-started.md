---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: hyperlinkbutton-getting-started
tags: getting,started
published: True
position: 1
---


# Getting Started

This tutorial will walk you through the required steps for using __RadHyperlinkButton__.

* [Assembly References](#assembly-references)
* [Setting the Content and Uri](#adding-radhyperlinkbutton-to-the-project)
* [Setting the Uri](#setting-the-uri)

## Assembly References

In order to use __RadHyperlinkButton__ in your application, you need to add reference to the __Telerik.Windows.Controls__ assembly.

## Setting the Content, Uri and the Target

The most common properties for utilizing the control are its __NavigateUri__ and __Content__ properties. The former one is intended to be used for navigating to the needed Uri when __RadHyperlinkButton__ is clicked. The latter one sets the content that will be visualized by the control. Also, the location at which the link to be opened can be set through the __TargetName__ string property.

#### __[XAML] Example 1: Setting the NavigateUri and Content__
{{region radhyperlinkbutton-gettingstarted_0}}
	<telerik:RadHyperlinkButton NavigateUri="http://www.progress.com" Content="Hyperlink Button" TargetName="_blank"/>
{{endregion}}

#### __Figure 1: RadHyperlinkButton in Normal State__
![RadHyperlinkButton in Normal State](images/RadHyperlinkButton_GettingStarted_01.png)

This example shows how a string can be set as a Content of RadHyperlinkButton. The Content can also be set to be an Image, for example. In such setup the link will be opened when the user clicks on the Image.

## Visited and Hovered States

> The default __Foreground__ for the control when the link is visited can be altered via the __VisitedForeground__ property. Also, __RadHyperlinkButton__ provides information whether the link is visited or not through its __IsVisited__ boolean property.

The figure above shows __RadHyperlink__ in its __Normal__ state. When hovered or clicked, the control will be underlined.

#### __Figure 2: RadHyperlinkButton when Hovered or Clicked__
![RadHyperlinkButton in Normal State](images/RadHyperlinkButton_GettingStarted_02.png)

The control will indicate when the link is visited by modifying the text Foreground.

#### __Figure 3: RadHyperlinkButton when the Link is Visited__
![RadHyperlinkButton in Normal State](images/RadHyperlinkButton_GettingStarted_03.png)

## See Also 

* [Overview]({%slug hyperlinkbutton-overview%})