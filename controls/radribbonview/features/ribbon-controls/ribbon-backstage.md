---
title: Ribbon Backstage
page_title: Ribbon Backstage
description: Check our &quot;Ribbon Backstage&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-ribbon-backstage
tags: ribbon,backstage
published: True
position: 2
---

# Ribbon Backstage

Telerik __RadRibbonView__ provides a simple and consistent way for building interfaces similar to the ribbon control used in Microsoft Office. The __Ribbon Backstage__ control allows you to achieve a more native MS Office look and feel of your application.

## RibbonBackstage Fundamentals

The __RibbonBackstage__ appears when a user __clicks__ the __Application Button__. It can be used to display controls, used to perform actions on the entire document, like __Save__, __Print__ and __Send__. The __RibbonBackstage__ can also provide a list of recent documents, access to application options for changing user settings and preferences, and application exit.

By default the __Backstage__ isn't opened. In order to control its state you can set the __RadRibbonView__'s __IsBackstageOpen__ property.

__Example 1: Set the IsBackstageOpen property__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_1-xaml' />

## Adding Backstage to the RadRibbonView

In order to add a backstage to your __RadRibbonView__ control you need to set the __RadRibbonView__'s __Backstage__ property. The next several code-snippets show you how to do that in XAML, as well as in the code-behind.

__Example 2: Declaring RadRibbonBackstage in XAML__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_2-xaml' />

__Example 3: Declaring RadRibbonBackstage in code-behind__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_3-cs' />
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_4-vb' />

#### __Figure 1: RadRibbonBackstage default appearance__
![{{ site.framework_name }} RadRibbonView RadRibbonBackstage default appearance](images/RadRibbonView_Backstage_Empty.png)

## Adding Backstage Items

The __Backstage__ control derives from the __RadTabControl__. That fact allows you to easily customize it by adding/removing __BackstageItems__ (the __BackstageItem__ derives from a __RadTabItem__).

__Example 4: Adding RadRibbonBackstageItem in XAML__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_5-xaml' />

## Backstage Properties

* __WindowMinHeight__: Specifies the minimum __Height__ of the window when the backstage is open.

* __WindowMinWidth__: Specifies the minimum __Width__ of the window when the backstage is open.

* __CloseButtonVisibility__: Specifies the visibility of the backstage's close button. The default value is `Visible`.

* __BackstagePosition__: Specifies where the backstage will be positioned when opened. The backstage position is an enumeration of type Telerik.Windows.Controls.RibbonView.BackstagePosition and it accepts the following values:
	* __Office2010__: The backstage will be positioned under the tab strip area
	
		#### __Figure 2: BackstagePosition property set to Office2010__
	![{{ site.framework_name }} RadRibbonView BackstagePosition property set to Office2010](images/RadRibbonView_Backstage_BackstagePosition_Office2010.PNG)	

	* __Office2013__: The backstage will be positioned on top of the tab strip area
	
		#### __Figure 3: BackstagePosition property set to Office2013__
	![{{ site.framework_name }} RadRibbonView BackstagePosition property set to Office2013](images/RadRibbonView_Backstage_BackstagePosition_Office2013.PNG)

	>The recommended __BackstagePosition__ for the themes from OfficeBlack to Windows8Touch including from the [Available Themes]({%slug common-styling-appearance-available-themes%}) list is the __Office2010__.  If the property is set to __Office2013__ for any of the themes before Office2013, the close button of the backstage will __not__ be displayed.
 
## BackstageItem Properties

The __BackstageItem__ exposes the following properties that allow you to further customize it:

* __IsSelectable__: Specifies whether an item can be selected. If you set this property to __False__, the item will behave like a __Button__. 

	>If the __BackstageItem__ __IsSelectable__ property is set to __False__, you will be able to take advantage of the __Click()__ event of the item, as well as its __Command__ property.

* __IsDefault__: Specifies whether the item should be selected when the __Backstage__ is opened. 

	>Please note that if you set the __IsDefault__ property of multiple __BackstageItems__ to __True__, the last one marked as default will be selected.

* __IsGroupSeparator__: Specifies whether an item is a group separator. Such items are used as a heading in order to differentiate a logical group of __BackstageItems__.

* __Icon__  gets or sets __BackstageItem__ icon 
	
* __CloseOnClick__: Specifies whether the __Backstage__ will be closed when the item is clicked. 

	>If the __BackstageItem__ is not selectable the __CloseOnClick__ property is set to __True__ by default. However, if the item is selectable, then the __CloseOnClick__ property won't affect its behavior.

__Example 5: RadRibbonView with RadRibbonBackstage code example__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_6-xaml' />

#### __Figure 4: Customized RadRibbonBackstage__
![{{ site.framework_name }} RadRibbonView Customized RadRibbonBackstage](images/RadRibbonView_Backstage_Sample.png)

The __RadRibbonView__ exposes the __BackstageClippingElement__ property, that allows you to define the area over which the __Backstage__ will be displayed:

__Example 6: Specify BackstageClippingElement property__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_7-xaml' />

#### __Figure 5: RadRibbonView with BackstageClippingElement property set__
![{{ site.framework_name }} RadRibbonView RadRibbonView with BackstageClippingElement property set](images/RadRibbonView_BackstageClippingElement_Sample.PNG)
	
## Hide Backstage Close Button

The close button of the ribbon backstage control is displayed in the themes after Windows8Touch. See the [Available Themes]({%slug common-styling-appearance-available-themes%}) article.

To hide the close button, set the __CloseButtonVisibility__ property of __RadRibbonBackstage__ to `Collapsed` or `Hidden`.

__Example 7: Setting CloseButtonVisibility__
<snippet id='radribbonview-features-ribbon-controls-ribbon-backstage-block_8-xaml' />

#### __Figure 5: Hidden backstage close button in Fluent theme__
![{{ site.framework_name }} RadRibbonView Hidden backstage close button in Fluent theme](images/RadRibbonView_Backstage_Hidden_Close_Button.PNG)
	
The __RadRibbonView__ is a complex control and the __backstage menu__ is only a small part of it. The __RadRibbonView__ consists of various elements such as:
* [Application Menu]({%slug radribbonview-applicationmenu%})
* [Quick Access ToolBar]({%slug radribbonview-qat%})
* [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
* [Ribbon Group]({%slug radribbonview-ribbon-group%})
* [Ribbon Gallery]({%slug radribbonview-ribbon-gallery%})
* [RibbonButtons Overview]({%slug radribbonview-buttons-overview%})
* [Ribbon ComboBox]({%slug radribbonview-ribbon-combobox%})
* [Screen Tips]({%slug radribbonview-screentips%})

## See Also
* [Selection]({%slug radribbonview-selection%})
* [Resizing]({%slug radribbonview-resizing%})
* [Minimization]({%slug radribbonview-minimization%})
* [Localization]({%slug radribbonview-localization%})