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



## Object instantiation

#### __XAML__

{{region radtoolbartray-programming_1}}
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
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
	#End Region
	
	#Region "radtoolbartray-programming_2"
		Imports Telerik.Windows.Controls
	
		Dim toolBarTray As New RadToolBarTray()
		Dim toolBar As New RadToolBar()
		Me.LayoutRoot.Children.Add(toolBarTray)
		toolBarTray.Items.Add(toolBar)
	#End Region
	
	#Region "radtoolbartray-programming_4"
		Imports Telerik.Windows.Controls
	
		Dim toolBarTray As New RadToolBarTray()
		Dim toolBar1 As New RadToolBar()
		Me.LayoutRoot.Children.Add(toolBarTray)
		toolBarTray.Items.Add(toolBar1)
		toolBarTray.IsLocked = False
		RadToolBarTray.SetIsLocked(toolBarTray, True)
		If RadToolBarTray.GetIsLocked(toolBar1) Then
		End If
	#End Region
	
	End Class



## Add Items

#### __XAML__

{{region radtoolbartray-programming_3}}
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
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
	#End Region
	
	#Region "radtoolbartray-programming_4"
		Imports Telerik.Windows.Controls
	
		Dim toolBarTray As New RadToolBarTray()
		Dim toolBar1 As New RadToolBar()
		Me.LayoutRoot.Children.Add(toolBarTray)
		toolBarTray.Items.Add(toolBar1)
		toolBarTray.IsLocked = False
		RadToolBarTray.SetIsLocked(toolBarTray, True)
		If RadToolBarTray.GetIsLocked(toolBar1) Then
		End If
	#End Region
	
	End Class



## 
				The IsLocked Attached Property
			

The default value of the __IsLocked__ attached property is __False__. It gets or sets a value that indicates whether the __RadToolBars__ can be moved inside a __RadToolBarTray__.
				

>There are corresponding methods __GetIsLocked__ and __SetIsLocked__ to access the __IsLocked__ property for the specified element.
					

#### __XAML__

{{region radtoolbartray-programming_5}}
		xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	    <telerik:RadToolBarTray IsLocked="False">
	        <telerik:RadToolBar telerik:RadToolBarTray.IsLocked="True" />
	    </telerik:RadToolBarTray>
	{{endregion}}



#### __C#__

{{region radtoolbartray-programming_4}}
	using Telerik.Windows.Controls;
	
	RadToolBarTray toolBarTray = new RadToolBarTray();
	RadToolBar toolBar1 = new RadToolBar();
	this.LayoutRoot.Children.Add(toolBarTray);
	toolBarTray.Items.Add(toolBar1);
	toolBarTray.IsLocked = false;
	RadToolBarTray.SetIsLocked(toolBarTray, true);
	if (RadToolBarTray.GetIsLocked(toolBar1))
	{
	}
	{{endregion}}



#### __VB.NET__

{{region radtoolbartray-programming_4}}
		Imports Telerik.Windows.Controls
	
		Dim toolBarTray As New RadToolBarTray()
		Dim toolBar1 As New RadToolBar()
		Me.LayoutRoot.Children.Add(toolBarTray)
		toolBarTray.Items.Add(toolBar1)
		toolBarTray.IsLocked = False
		RadToolBarTray.SetIsLocked(toolBarTray, True)
		If RadToolBarTray.GetIsLocked(toolBar1) Then
		End If
	#End Region
	
	End Class


