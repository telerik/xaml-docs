---
title: Show Help Button and Change its Image
page_title: Show Help Button and Change its Image
description: This article demonstrates how to show the help button and change its image.
slug: radribbonview-howto-show-help-icon-and-change-its-image
tags: show,help,button,and,change,its,image
published: True
position: 7
---

# Show Help Button and Change its Image

The purpose of this tutorial is to demonstrate how to show the help button and change its image. 

## Show the Help Button

In order to manage the visibility of the help button, you should use RadRibbonView's __HelpButtonVisibility__ property as demonstrated in __Examples 1 and 2__.

#### __[XAML] Example 1: Setting the HelpButtonVisibility in xaml__
{{region xaml-radribbonview-howto-show-and-change-help-button_0}}
	<telerik:RadRibbonView x:Name="xRibbonView" HelpButtonVisibility="Visible"/>
{{endregion}}

#### __[C#] Example 2: Setting the HelpButtonVisibility in code__
{{region cs-radribbonview-howto-show-and-change-help-button_1}}
	xRibbonView.HelpButtonVisibility = Visibility.Visible;
{{endregion}}

#### __[VB.NET] Example 2: Setting the HelpButtonVisibility in code__
{{region vb-radribbonview-howto-show-and-change-help-button_2}}
	xRibbonView.HelpButtonVisibility = Visibility.Visible;
{{endregion}}

>The default value of the __HelpButtonVisibility__ property is __Visibility.Collapsed__.		  

#### __Figure 1: RadRibbonView with shown help button in the Office2016 theme__
![RadRibbonView with shown help button](images/RadRibbonView_HowTo_ShowAndChange_Help_Button.png)

## Change the Help Button Image

To set a different icon from the default one, you should use the __HelpButtonImageSource__ property.

#### __[XAML] Example 3: Setting the HelpButtonImageSource__

{{region xaml-radribbonview-howto-show-and-change-help-button_3}}
	<telerik:RadRibbonView x:Name="xRibbonView" HelpButtonImageSource="myHelpButton.png"/>
{{endregion}}

> In order to learn how to execute a command when the help button is clicked, check out the [Bind Command to the HelpCommand property]({%slug radribbonview-howto-bind-command-to-helpcommand%}) article.