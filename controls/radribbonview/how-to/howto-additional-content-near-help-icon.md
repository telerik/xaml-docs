---
title: Add Additional Content near the Help button
page_title: Add Additional Content near the Help button
description: Check our &quot;Add Additional Content near the Help button&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-additional-content-near-help-icon
tags: add,additional,content,near,the,help,button
published: True
position: 8
---

# {{ site.framework_name }} RadRibbonView Add Additional Content near the Help button

The purpose of this tutorial is to show you how to add additional content near the help button.

>By default the help button is collapsed (not visible). If you want to learn how to enable it, read [here]({%slug radribbonview-howto-show-help-icon-and-change-its-image%}).		  

To add additional content near the help button, you should use the __RadRibbonView__'s __TabStripAdditionalContent__ property. It is of type object and you can insert any content.

#### __XAML__
{{region radribbonview-howto-additional-content-near-help-buton_0}}
	<telerik:RadRibbonView x:Name="xRibbonView" HelpButtonVisibility="Visible">
	    <telerik:RadRibbonView.TabStripAdditionalContent>
	        <StackPanel Orientation="Horizontal">
	            <Button Content="1"/>
	            <Button Content="2"/>
	            <Button Content="3"/>
	        </StackPanel>
	    </telerik:RadRibbonView.TabStripAdditionalContent>
	</telerik:RadRibbonView>
{{endregion}}

![Rad Ribbon View How To Additional Content](images/RadRibbonView_HowTo_Additional_Content.png)