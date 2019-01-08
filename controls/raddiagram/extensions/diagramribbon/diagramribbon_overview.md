---
title: Overview
page_title: Overview
description: This article will get you familiar with the DiagramRibbon control which is part of Telerik Diagramming Framework.
slug: raddiagram-extensions-diagramribbon-overview
tags: Overview
published: True
position: 0
---

# Overview
 
With the __R1 2019__ version Telerik UI for WPF we have introduce __RadDiagramRibbon__ control. The __DiagramRibbon__ control allows the users to examine and modify the settings of the diagramming items in run-time. __DiagramRibbon__ is a configurer RadRibbonView control which is used as top level navigation control for the RadDiagram. Its main purpose is to provide you with a ready-to-use view that contains the most common features and settings of a __RadDiagram__. The DiagramRibbon is fully customizable and scales its child widgets automatically based on the available area. 

>In order to use the __DiagramRibbon__ control along with the __RadDiagram__ in your projects you have to add references to the following assemblies:
>	- Telerik.Windows.Controls
>	- Telerik.Windows.Controls.Navigation
>	- Telerik.Windows.Controls.Input
>	- Telerik.Windows.Controls.Diagrams
>	- Telerik.Windows.Controls.Diagrams.Ribbon
>	- Telerik.Windows.Controls.RibbonView
>	- Telerik.Windows.Diagrams.Core
>	- Telerik.Windows.Controls.Diagrams.Extensions

## Overview

The __DiagramRibbon__ exposes a __Diagram__ property which is used to associate the ribbon with a particular diagram instance. 

#### __[XAML] Example 1: Specify DiagramRibbon in XAML__
{{region raddiagram-extensions-diagramribbon-overview-0}}
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto"/>
			<RowDefinition Height="*"/>
		</Grid.RowDefinitions>
		<telerik:RadDiagramRibbon Diagram="{Binding ElementName=diagram}"/>
		<telerik:RadDiagram x:Name="diagram" Grid.Row="1">
			<telerik:RadDiagramShape Content="Shape 1"/>
		</telerik:RadDiagram>
	</Grid>
{{endregion}}

#### __Figure 1: DiagramRibbon Overview__ 
![Diagram Ribbon Overview](images/RadDiagram_DiagramRibbon_Overview.png)

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.

## Customize tab and groups

__RadDiagramRibbon__ by design contains three build-in __RibbonTabs__ which holds different type of settings for customizing your __RadDiagram__: __Home, Settings and Design__. To add a new tab or a new group, the __AdditionalTabs__ and __AdditionalGroups__ collection properties can be used for such purposes. 

### Add new RadRibbonTab

To add a new tab we can just call the __Add()__ method of the __AdditionalTabs__ collection or specified dirrectly in __XAML__. The new tab will be placed at the last position.

#### __[XAML] Example 2: Add RadRibbonTab in XAML__
{{region raddiagram-extensions-diagramribbon-overview-1}}
	<telerik:RadDiagramRibbon x:Name="diagramRibbon"
							  Diagram="{Binding ElementName=diagram}" >
		<telerik:RadDiagramRibbon.AdditionalTabs>
			<telerik:RadRibbonTab Header="New Tab"/>
		</telerik:RadDiagramRibbon.AdditionalTabs>		
	</telerik:RadDiagramRibbon>
{{endregion}}

#### __[C#] Example 3: Add RadRibbonTab programmatically__
{{region raddiagram-extensions-diagramribbon-overview-2}}
	public MainWindow()
	{
		InitializeComponent();
		RadRibbonTab newTab = new RadRibbonTab();
		newTab.Header = "New Tab";
		newTab.Items.Add(new RadRibbonGroup() { Header="New Group" });
		diagramRibbon.AdditionalTabs.Add(newTab);
	}
{{endregion}}

#### __Figure 2: Add new tab__ 
![Diagram Ribbon Overview New Tab](images/RadDiagram_DiagramRibbon_Overview_NewTab.png)

### Add new RadRibbonGroup

To add a new group to __Home__ tab for example first we will create new __RadRibbonGroup__ and add a RadRibbonButton to that group. Then we need to specify to which tab we want to add the group. To do that we can set the __DiagramRibbonExtensions.RibbonTabHeader__ attached property. The last step is to add our new group to the __AdditionalGroups__ collection.

#### __[XAML] Example 2: Add RadRibbonGroup in XAML__
{{region raddiagram-extensions-diagramribbon-overview-1}}
	<telerik:RadDiagramRibbon x:Name="diagramRibbon"
							  Diagram="{Binding ElementName=diagram}" >
		<telerik:RadDiagramRibbon.AdditionalTabs>
			<telerik:RadRibbonTab Header="New Tab"/>
		</telerik:RadDiagramRibbon.AdditionalTabs>		
	</telerik:RadDiagramRibbon>
{{endregion}}

#### __[C#] Example 5: Add RadRibbonGroup programmatically__
{{region raddiagram-extensions-diagramribbon-overview-2}}
	public void AddNewGroup()
	{
		RadRibbonButton button = new RadRibbonButton();
		button.Content = "My Button";
		button.Foreground = Brushes.White;
		button.Background = new SolidColorBrush((Color)(ColorConverter.ConvertFromString("#25A0DA")));
		button.VerticalContentAlignment = VerticalAlignment.Center;

		RadRibbonGroup newGroup = new RadRibbonGroup();
		newGroup.Name = "new_group";
		newGroup.Header = "Group Name";
		newGroup.Items.Add(button);
		newGroup.SetValue(DiagramRibbonExtensions.RibbonTabHeaderProperty, "Home");

		this.diagramRibbon.AdditionalGroups.Add(newGroup);
	}
{{endregion}}

#### __Figure 3: Add new group__ 
![Diagram Ribbon Overview New Tab](images/RadDiagram_DiagramRibbon_Overview_NewGroup.png)

## Keyboard Support

__RadDiagramRibbon__ provides a keyboard navigation mechanisms using key tips and the arrow keys. The key tips are enabled by default. This feature can be disabled by setting the __KeyTipService.IsKeyTipsEnabled__ attached property on the __RadDiagramRibbon__ to __False__.

#### __[XAML] Example 3: Disable DiagramRibbon KeyTips__
{{region raddiagram-extensions-diagramribbon-overview-2}}
	<telerik:RadDiagramRibbon telerik:KeyTipService.IsKeyTipsEnabled="False" />
{{endregion}}

## DiagramRibbon Commands

__DiagramRibbon__ provide build-in commands which can be used in MVVM scenario to modify your diagram and its items. The static __DiagramRibbonCommands__ class is located in Telerik.Windows.Controls.Diagrams.Ribbon assembly:

* __SugiyamaLayout__: Rearange the RadDiagram items in Sugiyama Layout. [(Read more)]({%slug raddiagram-features-routing%}#astarrouter)
* __TreeLayout__: Rearange the RadDiagram items in Tree Layout. [(Read more)]({%slug raddiagram-features-routing%}#orgtreerouter)
* __ChangeConnectionType__: Change the connection type. [(Read more)]({%slug raddiagrams-features-connections%}#connection-types)
* __ChangeUseFreeConnectors__: Change UseFreeConnectors property of the RadDiagram.
* __EnableAStarRouter__: Set AStarRouter to the RadDiagram and update all connections.
* __RouteAll__: Update all connections in the RadDiagram.

## Events

* __HtmlExportButtonClicked__: This event is called when the HTML Export button is clicked. There is no build-in logic which will export the RadDiagram in HTML file. This event is expose so that you can subscribe to the click event of the button and called your exporting logic. More information how to export RadDiagram in HTML can be found in the [(Read more)]({%slug raddiagram-features-html-support%})

## See Also

* [Getting Started]({%slug raddiagram-getting-started%})
* [DiagramExtensions ViewModels]({%slug raddiagram-data-extensionsviewmodels%})
* [Extensions Overview]({%slug raddiagram-extensions%})