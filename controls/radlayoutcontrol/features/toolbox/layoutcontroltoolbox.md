---
title: LayoutControlToolBox
page_title: LayoutControlToolBox
description: LayoutControlToolBox
slug: radlayoutcontrol-features-toolbox-layoutcontroltoolbox
tags: layout, toolbox, layoutcontroltoolbox, layoutcontroltoolboxview
published: True
position: 2
---

# LayoutControlToolBox

__LayoutControlToolBox__ can be used to embed the toolbox into the layout control. This article demonstrates how to set it up and associate it with RadLayoutControl.

* [Setting up the toolbox](#setting-up-the-toolbox)
* [Manually control the toolbox view visibility](#manually-control-the-toolbox-view-visibility)
* [Customize the toolbox view](#customize-the-toolbox-view)
* [Style the toolbox view host window](#style-the-toolbox-view-host-window)
* [Position the toolbox button](#position-the-toolbox-button)

## Setting up the toolbox 

This section shows a sample toolbox definition.

#### __[XAML] Example 1: Setting up the toolbox in XAML__  
	<telerik:RadLayoutControl x:Name="layout">
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox LayoutControl="{Binding ElementName=layout}" />
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>

#### __[C#] Example 2: Setting up the toolbox in code__  
	RadLayoutControl layoutControl = new RadLayoutControl();
	var toolbox = new LayoutControlToolBox();
	toolbox.LayoutControl = layoutControl;
	layoutControl.AdditionalCanvasItems.Add(toolbox);

#### __[VB.NET] Example 2: Setting up the toolbox in code__  	
	Dim layoutControl As New RadLayoutControl()
	Dim toolbox = New LayoutControlToolBox()
	toolbox.LayoutControl = layoutControl
	layoutControl.AdditionalCanvasItems.Add(toolbox)

The toolbox can be associated with RadLayoutControl through its __LayoutControl__ property (see __Example 1__).

Initially, the __LayoutControlToolBox__ displays a single toggle button (see __Figure 1__).
	
#### __Figure 1: Closed toolbox__  
![](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-01.png)

>important The toggle button will be displayed only if the layout control is in [edit mode]({%slug radlayoutcontrol-edit-the-layout%}).

When the button is clicked the toolbox view will be opened in a popup.

#### __Figure 2: Toolbox view__  
![](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-02.png)

## Manually control the toolbox view visibility

You can manually control the state of the toolbox through the __IsOpen__ property of __LayoutControlToolBox__.

#### __[XAML] Example 3: Setting the IsOpen property in XAML__  
	<telerik:LayoutControlToolBox IsOpen="True" />

#### __[C#] Example 4: Setting the IsOpen property in code__  
	layoutControlToolBox.IsOpen = true;
	
#### __[VB.NET] Example 4: Setting the IsOpen property in code__  
	layoutControlToolBox.IsOpen = True;

## Customize the toolbox view
	
The popup of the LayoutControlToolBox component contains a __LayoutControlToolBoxView__ element. You can use the __ToolBoxView__ property to get this element and modify it. Or to define a new toolbox view and assign it to the LayoutControlToolBox.

#### __[XAML] Example 5: Replacing the default toolbox view__  
	<telerik:RadLayoutControl x:Name="layout">
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox LayoutControl="{Binding ElementName=layout}">
				<telerik:LayoutControlToolBox.ToolBoxView>
					<telerik:LayoutControlToolBoxView Opacity="0.5" Width="300" Height="300" />
				</telerik:LayoutControlToolBox.ToolBoxView>
			</telerik:LayoutControlToolBox>
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>
	
#### __Figure 3: Modified toolbox view__
![](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-03.png)
	
## Style the toolbox view host window

The toolbox view is displayed in a __RadWindow__ element which can be customized through the __WindowStyle__ property of __LayoutControlToolBox__.

#### __[XAML] Example 6: Setting custom window style__
	<telerik:RadLayoutControl x:Name="layout">
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox LayoutControl="{Binding ElementName=layout}">	
				<telerik:LayoutControlToolBox.WindowStyle>
					<Style TargetType="telerik:RadWindow" BasedOn="{StaticResource LayoutControlToolBoxWindowStyle}">
						<Setter Property="Width" Value="300" />
						<Setter Property="Height" Value="300" />
						<Setter Property="Header" Value="My Layout Control ToolBox" />
					</Style>
				</telerik:LayoutControlToolBox.WindowStyle>
			</telerik:LayoutControlToolBox>
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>
	
> The __BasedOn__ setting is applicable only in a scenario with [implicit styles]({%slug styling-apperance-implicit-styles-overview%}). This attribute is set so that the custom style inherits the default toolbox window style. The __LayoutControlToolBoxWindowStyle__ is located in the __Telerik.Windows.Controls.Navigation.xaml__ ResourceDictionary.
	
#### __Figure 4: Custom window style__
![](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-04.png)

## Position the toolbox button

The button that opens the toolbox can be re-positioned in the additional items canvas of RadLayoutControl. This can be done via the __Canvas.Left__, __Canvas.Top__, __Canvas.Right__ and __Canvas.Bottom__ properties.

#### __[XAML] Example 7: Positioning the toggle button at the bottom-left side of the layout control__   
	<telerik:RadLayoutControl>
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox Canvas.Left="0" Canvas.Bottom="0" 
										  LayoutControl="{Binding ElementName=layout}" />
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>

#### __Figure 5: Bottom-right positioned button__
![](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-05.png)

## See Also  
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [LayoutControlToolBoxView]({%slug radlayoutcontrol-features-toolbox-toolboxview%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
* [Layout Panel]({%slug radlayoutcontrol-getting-started-layoutpanel%})
