---
title: ToolBarTray HowTo
page_title: ToolBarTray HowTo
description: ToolBarTray HowTo
slug: radtoolbartray-programming
tags: toolbartray,howto
published: True
position: 3
---

# ToolBarTray HowTo

This article demonstrates how to define and populate the __RadToolBarTray__ component.

## Object instantiation

 The __RadToolBarTray__ component is located in the Telerik.Windows.Controls namespace and can be created with the following code:

#### __XAML__
{{region radtoolbartray-programming_1}}	
	<telerik:RadToolBarTray />
{{endregion}}

#### __C#__
{{region radtoolbartray-programming_0}}
	using Telerik.Windows.Controls;	
	RadToolBarTray toolBarTray = new RadToolBarTray();
{{endregion}}

#### __VB.NET__
{{region radtoolbartray-programming_0}}
	Imports Telerik.Windows.Controls	
	Dim toolBarTray As New RadToolBarTray()
{{endregion}}	

## Add Items

In order to add items in the toolbar tray you can use its __Items__ collection.

#### __XAML__
{{region radtoolbartray-programming_3}}
	    <telerik:RadToolBarTray>
	        <telerik:RadToolBar Band="0" BandIndex="0">
	            <TextBlock Margin="0,0,9,0" Text="Open:" />
	            <Button>
	                <Image Source="/Images/ToolBar/Open.png" />
	            </Button>
	        </telerik:RadToolBar>
	    </telerik:RadToolBarTray>
{{endregion}}

#### __C#__
{{region radtoolbartray-programming_2}}
	using Telerik.Windows.Controls;
	
	RadToolBarTray toolBarTray = new RadToolBarTray();
	RadToolBar toolBar = new RadToolBar();
	this.LayoutRoot.Children.Add(toolBarTray);
	toolBarTray.Items.Add(toolBar);
{{endregion}}

#### __VB.NET__
{{region radtoolbartray-programming_2}}
	Imports Telerik.Windows.Controls

	Dim toolBarTray As New RadToolBarTray()
	Dim toolBar As New RadToolBar()
	Me.LayoutRoot.Children.Add(toolBarTray)
	toolBarTray.Items.Add(toolBar)
{{endregion}}