---
title: Controlling Appearance
page_title: Controlling Appearance
description: Check our &quot;Controlling Appearance&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-styling-controlling-appearance
tags: controlling,appearance
published: True
position: 1
---

# Controlling Appearance

There are many ways to customize the look and feel of your __RadRibbonView__ control. This topic covers some of the most useful of these properties.
			

## RadRibbonView

* If you want to hide the __Application Button__, located at the top left part of the __RadRibbonView__ control just set the __ApplicationButtonVisibility__ property to __Visibility.Collapsed__. The __Application Button__ is visible by default.
	![{{ site.framework_name }} RadRibbonView Hidden Application Button](images/RadRibbonView_Appearance_ApplicationButton.png)

* If you want to show the __Help Button__, located at the right part of the __RadRibbonView__'s title bar just set the __HelpButtonVisibility__ property to __Visibility.Visible__. The __Help Button__ is hidden (collapsed) by default. The next snapshot shows you a RibbonView with visible help button.
	![{{ site.framework_name }} RadRibbonView Visible Help Button](images/RadRibbonView_Appearance_MinimizeButton.png)

* If you want to minimize the __RadRibbonView__, set the __IsMinimized__ property to __True__. The __RadRibbonView__ is not minimized by default. The next snapshot shows you a minimized RibbonView:
	![{{ site.framework_name }} RadRibbonView Minimized State](images/RibbonView_Minimized.png)

* If you want to hide the __Title Bar__, set the __TitleBarVisibility__ property to __Visibility.Collapsed__. The __RadRibbonView__'s title bar is visible by default.
	![{{ site.framework_name }} RadRibbonView Hidden Title Bar](images/RibbonView_Styling_HidingTitleBar.png)

	>Note how the __Quick Access Toolbar__ and the __Application Title__ are collapsed.							

* If you want to hide the __Quick Access Toolbar__, set the __QuickAccessToolBarPosition__ property to __QuickAccessToolBarPosition.NotHosted__.
	![{{ site.framework_name }} RadRibbonView Hidden Quick Access Toolbar](images/RibbonView_Styling_HidingQAT.png)

By default the __Quick Access Toolbar__ is always visible and its position is __QuickAccessToolBarPosition.AboveRibbon.__
	![{{ site.framework_name }} RadRibbonView Default Quick Access Toolbar](images/RibbonView_Styling_DefaultQAT.png)

If you want to change the default position of the __Quick Access Toolbar__, set the __QuickAccessToolBarPostion__ property to __QuickAccessToolBarPosition.BelowRibbon__. This will move the toolbar at the bottom part of the ribbon bar.
	![{{ site.framework_name }} RadRibbonView Quick Access Toolbar Below Ribbon](images/RibbonView_Styling_BellowRibbonQAT.png)

* If you want to change the default __Height__ of the __RadRibbonView__, you can set the __ContentHeight__ property.				  

	```XAML
		<telerik:RadRibbonView ContentHeight="120"
						   Title="Document1"
						   ApplicationName="Telerik Word">

		</telerik:RadRibbonView>					  
	```

	![Rad Ribbon View Styling Appearance Content Height](images/RadRibbonView_Styling_Appearance_ContentHeight.png)

## RadRibbonGroup

* If you want to show the dialog launcher button, you need to set the __RadRibbonGroup__'s __DialogLauncherVisibility__ property to __Visibility.Visible__. By default, the dialog launcher button is not visible (it is collapsed).
	![{{ site.framework_name }} RadRibbonView Dialog Launchers](images/RibbonView_Group_DialogLauncher.png)

## RadRibbonButton

* If you want to change the initial size of the __RibbonButtons__, you need to set their __Size__ property. The possible values are predefined in the __ButtonSize__ enumeration, which exposes the following fields:				  

* __Small__
	![{{ site.framework_name }} RadRibbonView RadRibbonButton Large](images/RibbonView_Buttons_Overview_Small.png)

* __Medium__
	![{{ site.framework_name }} RadRibbonView RadRibbonButton Medium](images/RibbonView_Buttons_Overview_Medium.png)

* __Large__
	![{{ site.framework_name }} RadRibbonView RadRibbonButton Small](images/RibbonView_Buttons_Overview_Large.png)

## See Also
 * [RadRibbonView Template Structure]({%slug radribbonview-styling-templatestructure%})
 * [Styling the RadRibbonView]({%slug radribbonview-styling-ribbonview%})
 * [Styling the QuickAccessToolbar]({%slug radribbonview-styling-quickaccesstoolbar%})
 * [Styling the ApplicationButton]({%slug radribbonview-styling-applicationbutton%})
 * [Styling the RadRibbonView TitleBar]({%slug radribbonview-styling-titlebar%})
 * [Styling the RadRibbonTab]({%slug radribbonview-styling-ribbontab%})
 * [Styling the RadRibbonGroup]({%slug radribbonview-styling-ribbongroup%})
 * [Styling the RadRibbonButton]({%slug radribbonview-styling-ribbonbutton%})
 * [Styling the RadRibbonGallery]({%slug radribbonview-styling-ribbongallery%})
 * [Styling the RadRibbonComboBox]({%slug radribbonview-styling-ribboncombobox%})