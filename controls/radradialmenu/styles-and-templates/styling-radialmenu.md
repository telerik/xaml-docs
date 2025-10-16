---
title: Styling the RadialMenu
page_title: Styling the RadialMenu
description: Check our &quot;Styling the RadialMenu&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-styles-and-templates-styling-radialmenu
tags: styling,the,radialmenu
published: True
position: 1
---

# Styling the RadialMenu

This help topic will explain how you can customize the look of some of the elements of the __RadialMenu__ control.    

>Before proceeding, please check [Setting a Theme]({%slug radradialmenu-styles-and-templates-setting-theme%}) topic.        

We will go through the following topics:

* [RadialMenu Style Properties](#radialmenu-style-properties)

* [Customize the NavigationItemButtons Style](#customize-the-navigationitembuttons-style)

* [Customize the VisualStatesItemPresenter Style](#customize-the-visualstatesitempresenter-style)

## RadialMenu Style Properties

__RadRadialMenu__ provides __ContentMenuBackgroundStyle__ and __NavigationMenuBackgroundStyle__ properties used to define the Background of the ContentMenu and NavigationMenu parts of the control. Their default values are respectively ContentMenuStyle and NavigationMenuStyle and receive as a TargetType a Rectangle element.

The following code snippets show how these properties can be customized.        

__Example 1: Define the Style properties__

```XAML
	<UserControl.Resources>
	    <Style x:Key="CustomContentMenuStyle" TargetType="Rectangle" BasedOn="{StaticResource ContentMenuStyle}">
	        <Setter Property="Fill" Value="Yellow" />
	    </Style>
	
	    <Style x:Key="CustomNavigationMenuStyle" TargetType="Rectangle" BasedOn="{StaticResource NavigationMenuStyle}">
	        <Setter Property="Fill" Value="Blue"/>
	    </Style>
	</UserControl.Resources>
```

__Example 2: Set the Style properties to the RadialMenu__

```XAML
	<telerik:RadRadialMenu ContentMenuBackgroundStyle="{StaticResource CustomContentMenuStyle}"
	               NavigationMenuBackgroundStyle="{StaticResource CustomNavigationMenuStyle}">
	    <!--...-->
	</telerik:RadRadialMenu>
```

Figure 1: Customized RadialMenu
![Rad Radial Menu Styling Radial Menu 01](images/RadRadialMenu_Styling_RadialMenu_01.png)

## Customize the NavigationItemButtons Style

In order to change the way the navigation buttons look, you will need to create a Style with TargetType set to __NavigationItemButton__ based on the default __NavigationItemButtonStyle__ and modify the needed properties. __Example 3__ shows how you could change the Background, Foreground ( actually used for the arrow element) and Border colors.        

__Example 3: Customize the NavigationButtons__

```XAML
	<UserControl.Resources>
	    <Style TargetType="telerik:NavigationItemButton" BasedOn="{StaticResource NavigationItemButtonStyle}">
	        <Setter Property="Background" Value="Yellow"/>
	        <Setter Property="BorderBrush" Value="Orange"/>
	        <Setter Property="Foreground" Value="Orange"/>
	        <Setter Property="BorderThickness" Value="4"/>
	    </Style>
	</UserControl.Resources>
```

Figure 2: Customized NavigationButtons
![Rad Radial Menu Styling Radial Menu 02](images/RadRadialMenu_Styling_RadialMenu_02.png)

## Customize the VisualStatesItemPresenter Style

__VisualStatesItemPresenter__ is the element used to mark the selected and highlighted RadialMenuItems. Again, to change its Style, you will need to add a new Style to your Resources with TargetType set to __VisualStatesItemPresenter__ and based on the default __VisualStatesItemPresenterStyle__ as shown in __Example 4__.        

__Example 4: Customize the VisualStatesItemPresenter__

```XAML
	<UserControl.Resources>
	    <Style TargetType="telerik:VisualStatesItemPresenter" BasedOn="{StaticResource VisualStatesItemPresenterStyle}">
	        <Setter Property="Background" Value="Blue"/>
	    </Style>
	</UserControl.Resources>
```

Figure 3: Customized VisualStatesItemPresenter
![Rad Radial Menu Styling Radial Menu 03](images/RadRadialMenu_Styling_RadialMenu_03.png)

Additionally, there are two more properties that you could set through the __VisualStatesItemPresenterStyle__:      

* __ThicknessFactor__ - sets factor defining the thickness of the __VisualStatesItemPresenter__ as a fraction of the size of the __NavigationItemButton__. The value should be between 0 and 1. If the passed value lies outside this range, it is automatically set to the nearest boundary value.            

* __ArrowThicknessFactor__ - sets the factor defining the thickness of the arrow part of the __VisualStatesItemPresenter__ as a fraction of the size of the __NavigationItemButton__. The value should be between 0 and 1. If the passed value lies outside this range, it is automatically set to the nearest boundary value.             

__Example 5__ will show how these properties could be set:        

__Example 5: VisualStatesItemPresenter with customize Thickness and ArrowThickness__

```XAML
	<UserControl.Resources>
	    <Style TargetType="telerik:VisualStatesItemPresenter" BasedOn="{StaticResource VisualStatesItemPresenterStyle}">
	        <Setter Property="Background" Value="Blue"/>
	        <Setter Property="ThicknessFactor" Value="0.4" />
	        <Setter Property="ArrowThicknessFactor" Value="0.5" />
	    </Style>
	</UserControl.Resources>
```

Figure 3: Custom Thickness properties
![Rad Radial Menu Styling Radial Menu 04](images/RadRadialMenu_Styling_RadialMenu_04.png)

## See Also

 * [Visual Structure]({%slug radradialmenu-visual-structure%})
