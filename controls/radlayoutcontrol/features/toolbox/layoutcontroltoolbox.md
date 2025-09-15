---
title: LayoutControlToolBox
page_title: LayoutControlToolBox
description: Check our &quot;LayoutControlToolBox&quot; documentation article for the RadLayoutControl {{ site.framework_name }} control.
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

__Example 1: Setting up the toolbox in XAML__  
```XAML
	<telerik:RadLayoutControl x:Name="layout">
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox LayoutControl="{Binding ElementName=layout}" />
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>
```

__Example 2: Setting up the toolbox in code__  
```C#
	RadLayoutControl layoutControl = new RadLayoutControl();
	var toolbox = new LayoutControlToolBox();
	toolbox.LayoutControl = layoutControl;
	layoutControl.AdditionalCanvasItems.Add(toolbox);
```
```VB.NET
	Dim layoutControl As New RadLayoutControl()
	Dim toolbox = New LayoutControlToolBox()
	toolbox.LayoutControl = layoutControl
	layoutControl.AdditionalCanvasItems.Add(toolbox)
```

The toolbox can be associated with RadLayoutControl through its __LayoutControl__ property (see __Example 1__).

Initially, the __LayoutControlToolBox__ displays a single toggle button (see __Figure 1__).
	
#### __Figure 1: Closed toolbox__  
![{{ site.framework_name }} RadLayoutControl Closed toolbox](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-01.png)

>important The toggle button will be displayed only if the layout control is in [edit mode]({%slug radlayoutcontrol-edit-the-layout%}).

When the button is clicked the toolbox view will be opened in a popup.

#### __Figure 2: Toolbox view__  
![{{ site.framework_name }} RadLayoutControl Toolbox view](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-02.png)

## Manually control the toolbox view visibility

You can manually control the state of the toolbox through the __IsOpen__ property of __LayoutControlToolBox__.

__Example 3: Setting the IsOpen property in XAML__  
```XAML
	<telerik:LayoutControlToolBox IsOpen="True" />
```

__Example 4: Setting the IsOpen property in code__  
```C#
	layoutControlToolBox.IsOpen = true;
```
```VB.NET
	layoutControlToolBox.IsOpen = True;
```

## Customize the toolbox view
	
The popup of the LayoutControlToolBox component contains a __LayoutControlToolBoxView__ element. You can use the __ToolBoxView__ property to get this element and modify it. Or to define a new toolbox view and assign it to the LayoutControlToolBox.

__Example 5: Replacing the default toolbox view__  
```XAML
	<telerik:RadLayoutControl x:Name="layout">
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox LayoutControl="{Binding ElementName=layout}">
				<telerik:LayoutControlToolBox.ToolBoxView>
					<telerik:LayoutControlToolBoxView Opacity="0.5" Width="300" Height="300" />
				</telerik:LayoutControlToolBox.ToolBoxView>
			</telerik:LayoutControlToolBox>
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>
```
	
#### __Figure 3: Modified toolbox view__
![{{ site.framework_name }} RadLayoutControl Modified toolbox view](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-03.png)
	
## Style the toolbox view host window

The toolbox view is displayed in a __RadWindow__ element which can be customized through the __WindowStyle__ property of __LayoutControlToolBox__.

__Example 6: Setting custom window style__
```XAML
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
```
	
> The __BasedOn__ setting is applicable only in a scenario with [implicit styles]({%slug styling-apperance-implicit-styles-overview%}). This attribute is set so that the custom style inherits the default toolbox window style. The __LayoutControlToolBoxWindowStyle__ is located in the __Telerik.Windows.Controls.Navigation.xaml__ ResourceDictionary.
	
#### __Figure 4: Custom window style__
![{{ site.framework_name }} RadLayoutControl Custom window style](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-04.png)

## Position the toolbox button

The button that opens the toolbox can be re-positioned in the additional items canvas of RadLayoutControl. This can be done via the __Canvas.Left__, __Canvas.Top__, __Canvas.Right__ and __Canvas.Bottom__ properties.

__Example 7: Positioning the toggle button at the bottom-left side of the layout control__   
```XAML
	<telerik:RadLayoutControl>
		<telerik:RadLayoutControl.AdditionalCanvasItems>
			<telerik:LayoutControlToolBox Canvas.Left="0" Canvas.Bottom="0" 
										  LayoutControl="{Binding ElementName=layout}" />
		</telerik:RadLayoutControl.AdditionalCanvasItems>
	</telerik:RadLayoutControl>
```

#### __Figure 5: Bottom-right positioned button__
![{{ site.framework_name }} RadLayoutControl Bottom-right positioned button](images/radlayoutcontrol-features-toolbox-layoutcontroltoolbox-05.png)

## See Also  
* [Getting Started]({%slug radlayoutcontrol-getting-started%})
* [LayoutControlToolBoxView]({%slug radlayoutcontrol-features-toolbox-toolboxview%})
* [Layout Groups Overview]({%slug radlayoutcontrol-features-layoutgroups-overview%})
* [Layout Panel]({%slug radlayoutcontrol-getting-started-layoutpanel%})
