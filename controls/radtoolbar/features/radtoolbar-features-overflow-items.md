---
title: Overflow Items
page_title: Overflow Items
description: Overflow Items
slug: radtoolbar-features-overflow-items
tags: 
published: True
position: 1
---

# Overflow Items


//AutoHideOverflowButton
//OverflowButtonVisibility
//OverflowItems
//IsOverflowOpen
//HasOverflowItems
//RadToolBar.OverflowMode attached property

//GripVisibility

OverflowAreaClosed
OverflowAreaOpened

===============================
The toolbars suite provides you with the `RadToolBarTray` control that allows you to host several `RadToolBar` elements in the same tray. The tray handles the position, size and order of toolbars inside of it. It is divided by bands (rows) and each band can contain multiple toolbars.

![](images/radtoolbartray-overview-0.png)

## Defining ToolBarTray

The following example shows a very basic definition of the `RadToolBarTray` control with two RadToolBars.

#### __[XAML] Example 1: Define the tray in XAML__
{{region radtoolbartray-overview-0}}
	<telerik:RadToolBarTray VerticalAlignment="Center" Width="460">
		<telerik:RadToolBar>
			<telerik:RadButton Content="Button 1" />
			<telerik:RadButton Content="Button 2 " />
			<telerik:RadButton Content="Button 3" />
		</telerik:RadToolBar>
		<telerik:RadToolBar>
			<telerik:RadButton Content="Button 1" />
			<telerik:RadButton Content="Button 2 " />
		</telerik:RadToolBar>          
	</telerik:RadToolBarTray>
{{endregion}}

![](images/radtoolbartray-overview-1.png)

## Setting Band and Band Position

The `RadToolBar` control exposes `Band` property that can be used to define the row of the toolbar in the tray. The position (the order) in the current band is controlled via the `BandIndex` property of the toolbar.

The following picture shows how the band and band index affect the positions of the toolbars in the tray.

![](images/radtoolbartray-overview-2.png)

> By default all `RadToolBar` elements hosted in the tray are positioned in the first band (Band=0). The default band index is the based on the collection index of the toolbar plus the current band position.

#### __[XAML] Example 2: Setting Band and BandIndex manually__
{{region radtoolbartray-overview-1}}
	<telerik:RadToolBarTray>
		<telerik:RadToolBar BandIndex="1">
			<telerik:RadButton Content="Button 1" />
			<telerik:RadButton Content="Button 2 " />
			<telerik:RadButton Content="Button 3" />
		</telerik:RadToolBar>
		<telerik:RadToolBar>
			<telerik:RadButton Content="Button 4" />
			<telerik:RadButton Content="Button 5 " />
			<telerik:RadButton Content="Button 6" />
		</telerik:RadToolBar>
		<telerik:RadToolBar Band="1">
			<telerik:RadButton Content="Button 7" />
			<telerik:RadButton Content="Button 8 " />
		</telerik:RadToolBar>
		<telerik:RadToolBar Band="2">
			<telerik:RadButton Content="Button 9" />
			<telerik:RadButton Content="Button 10 " />
		</telerik:RadToolBar>
	</telerik:RadToolBarTray>
{{endregion}}

![](images/radtoolbartray-overview-3.png)

## Setting Orientation

By default the `RadToolBarTray` will order the toolbars horizontally. Also, the RadToolBar controls will order its items horizontally. To switch the orientation of the tray and the toolbars set the `Orientation` property of `RadToolBarTray` to `Vertical`

#### __[XAML] Example 3: Setting Orientation__
{{region radtoolbartray-overview-2}}
	<telerik:RadToolBarTray Orientation="Vertical" VerticalAlignment="Center" Width="460">
		<telerik:RadToolBar>
			<telerik:RadButton Content="B1" />
			<telerik:RadButton Content="B2 " />
			<telerik:RadButton Content="B3" />
		</telerik:RadToolBar>
		<telerik:RadToolBar>
			<telerik:RadButton Content="B4" />
			<telerik:RadButton Content="B5 " />
			<telerik:RadButton Content="B6" />
		</telerik:RadToolBar>           
	</telerik:RadToolBarTray>
{{endregion}}

![](images/radtoolbartray-overview-4.png)