---
title: Customize the Application Menu Button
page_title: Customize the Application Menu Button
description: This article demonstrates how the application button of a RadRibbonView can be customized. 
slug: radribbonview-howto-style-app-button
tags: style,the,application,button
published: True
position: 11
---

# {{ site.framework_name }} RadRibbonView Customize the Application Menu Button

The default look of the [application menu]({%slug radribbonview-applicationmenu%}) button is an empty rectangle as shown in __Figure 1__.

#### __Figure 1: RadRibbonView Application Button in the Office2016 theme__
![RadRibbonView Application Button in the Office2016 theme](images/RadRibbonView_HowTo_StyleTheApplicationButton_02.png)

## Set the ApplicationButtonImageSource

In order to add an image as the application button's content, you can use the __ApplicationButtonImageSource__ property. 

#### __[XAML] Example 1: Setting the ApplicationButtonImageSource__

{{region xaml-radribbonview-howto-style-app-button_0}}
	<telerik:RadRibbonView ApplicationButtonImageSource="Images/test.png">
		<telerik:RadRibbonView.Items>
            <telerik:RadRibbonTab Header="Home" />
        </telerik:RadRibbonView.Items>
	</telerik:RadRibbonView>
{{endregion}}

#### __Figure 2: RadRibbonView Application Button with an image in the Office2016 theme__
![Rad Ribbon View How To Style The Application Button](images/RadRibbonView_HowTo_StyleTheApplicationButton.png)

## Add custom Content to the Application Button

You can add custom Content to the Application Button via the __ApplicationButtonContent__ property.

#### __[XAML] Example 2: Setting the ApplicationButtonContent__
{{region xaml-radribbonview-howto-style-app-button_1}}
	<Grid>
        <Grid.Resources>
            <TextBlock x:Key="clickTextBlock" Text="Click" />
        </Grid.Resources>
        <telerik:RadRibbonView ApplicationButtonContent="{StaticResource clickTextBlock}">
            <telerik:RadRibbonView.Items>
                <telerik:RadRibbonTab Header="Home" />
            </telerik:RadRibbonView.Items>
        </telerik:RadRibbonView>
    </Grid>
{{endregion}}

#### __Figure 3: RadRibbonView Application Button with custom content__
![RadRibbonView Application Button with custom content](images/RadRibbonView_HowTo_StyleTheApplicationButton_ApplicationButtonContent.png)

## Disabling the ApplicationButton

In order to disable the application button, you can set the __IsApplicationButtonEnabled__ property to False. 

#### __[XAML] Example 3: Disabling the Application Button__
{{region xaml-radribbonview-howto-style-app-button_2}}
	<telerik:RadRibbonView IsApplicationButtonEnabled="False" />
{{endregion}}

## Hide the Application Button

In order to hide the application button, you can set the __ApplicationButtonVisibility__ property to __Collapsed__.

#### __[XAML] Example 4: Setting the ApplicationButtonVisibility__
{{region xaml-radribbonview-howto-style-app-button_3}}
	<telerik:RadRibbonView ApplicationButtonVisibility="Collapsed" />
{{endregion}}