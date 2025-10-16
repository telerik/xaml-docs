---
title: Tab Expand Animation in RadTabControl
description: This article shows how to implement size expanding animation when you mouse over a RadTabItem
type: how-to
page_title: Implement Tab Size Change Animation on RadTabControl Hover
slug: kb-tabcontrol-expand-size-animation-on-tab-hover
tags: animation,size,expand,tab
res_type: kb
---

## Environment

| Property | Value |
|---|---|
| Product | RadTabControl for WPF |
| Version | 2024.1.312 |

## Description

How to implement size expand animation for the `RadTabItem` triggered on mouse over.

## Solution

One way to create this is to use `Storyboard` objects with `DoubleAnimation` that targets the `Width` or `Height` of the element in the `Header` of the `RadTabItem`.


```XAML
	<Window.Resources>
		<Storyboard x:Key="AnimateUp">
			<DoubleAnimation Storyboard.Target="{Binding ElementName=pnl}"
							 BeginTime="00:00:00.20"
							 Duration="00:00:00.250000"
							 Storyboard.TargetProperty="Width"
							 To="200"
							 FillBehavior="HoldEnd" />
		</Storyboard>

		<Storyboard x:Key="AnimateDown">
			<DoubleAnimation Storyboard.Target="{Binding ElementName=pnl}"
							 BeginTime="00:00:00.5"
							 Duration="00:00:00.250000"
							 Storyboard.TargetProperty="Width"
							 To="37"
							 FillBehavior="HoldEnd" />
		</Storyboard>
		
		<Style x:Key="SPMouseOver" TargetType="{x:Type FrameworkElement}">            
			<Style.Triggers>
				<EventTrigger RoutedEvent="MouseEnter">
					<EventTrigger.Actions>
						<BeginStoryboard Storyboard="{StaticResource AnimateUp}" />
					</EventTrigger.Actions>
				</EventTrigger>
				<EventTrigger RoutedEvent="MouseLeave">
					<EventTrigger.Actions>
						<BeginStoryboard Storyboard="{StaticResource AnimateDown}" />
					</EventTrigger.Actions>
				</EventTrigger>
			</Style.Triggers>
		</Style>	
	</Window.Resources>

	<Grid>
		<!-- this is hidden proxy object to be a common bind to all tabs.  This is used so all tabs expand and not just the tab hovered over -->
		<FrameworkElement Name="pnl" Width="37" Visibility="Collapsed" />

		<telerik:RadTabControl TabStripPlacement="Left"
							   TabOrientation="Vertical"
							   Align="Right">
			<telerik:RadTabControl.Items>
				<telerik:RadTabItem Height="{Binding ElementName=pnl, Path=Width}" 
									HorizontalContentAlignment="Left">				  
					<telerik:RadTabItem.Header>
						<StackPanel Style="{StaticResource SPMouseOver}" Orientation="Horizontal" HorizontalAlignment="Left" Name="tab1Header">
							<Image Source="/WpfApp1;component/Images/24_button_green.png" Width="24" Height="24" />
							<TextBlock Text="Other descriptive content" Margin="5,0,0,0" VerticalAlignment="Center" />
						</StackPanel>
					</telerik:RadTabItem.Header>				               
					<telerik:RadTabItem.Content>					
						<TextBlock TextWrapping="Wrap" Background="Beige" Text="Text Content 1"/>
					</telerik:RadTabItem.Content>
				</telerik:RadTabItem>
				<telerik:RadTabItem Height="{Binding ElementName=pnl, Path=Width}"
									HorizontalContentAlignment="Left">
					<telerik:RadTabItem.Header>
						<StackPanel Style="{StaticResource SPMouseOver}" Orientation="Horizontal" HorizontalAlignment="Left" Name="tab2Header">
							<Image Source="/WpfApp1;component/Images/24_button_purple.png" Width="24" Height="24" />
							<TextBlock Text="Other descriptive content" Margin="5,0,0,0" VerticalAlignment="Center" />
						</StackPanel>
					</telerik:RadTabItem.Header>
					<telerik:RadTabItem.Content>
						<TextBlock TextWrapping="Wrap" Background="Beige" Text="Text Content 2"/>
					</telerik:RadTabItem.Content>
				</telerik:RadTabItem>
			</telerik:RadTabControl.Items>
		</telerik:RadTabControl>
	</Grid>
```

