---
title: Black Screen When Showing RadWindow or RadRibbonWindow With NoXaml dlls
description: Black screen displaying when Window or Ribbon is used in Telerik WPF NoXaml scenario.
type: troubleshooting
page_title: Blank black screen displayed instead of RadWindow or RadRibbonWindow when NoXaml assemblies are used
slug: kb-window-black-screen
position: 0
tags: performance,export,excel,speed
ticketid: 1568347
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadWindow/RadRibbonWindow for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Black screen is displayed when you open a WPF `RadWindow` or `RadRibbonWindow` and the [NoXaml]({%slug xaml-vs-noxaml%}) Telerik dlls are used.

## Solution

This happens when you create a custom control that derives from `RadWindow` or `RadRibbonWindow`. For example, if you use the [window as a UserControl]({%slug radwindow-how-to-use-radwindow-as-user-control%}). In this case, you should also define a style for the custom control and base it on the default window style. This is required for all custom controls that derive from Telerik controls. Read more in the [Styling the Controls]({%slug implicit-styles-styling-the-controls%}#styling-custom-controls) article.

__RadWindow style__
```XAML
	<ResourceDictionary>
		<ResourceDictionary.MergedDictionaries>
			<ResourceDictionary Source="Themes/System.Windows.xaml" />
			<ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
			<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
		</ResourceDictionary.MergedDictionaries>

		<!-- style for a custom window -->	
		<Style TargetType="local:MainWindow" BasedOn="{StaticResource RadWindowStyle}" />
	</ResourceDictionary> 
```

__RadRibbonWindow style__
```XAML
	<ResourceDictionary>
		<ResourceDictionary.MergedDictionaries>
			<ResourceDictionary Source="Themes/System.Windows.xaml" />
			<ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
			<ResourceDictionary Source="Themes/Telerik.Windows.Controls.Navigation.xaml" />
			<ResourceDictionary Source="Themes/Telerik.Windows.Controls.RibbonView.xaml" />
		</ResourceDictionary.MergedDictionaries>

		<!-- style for a custom ribbon window -->	
		<Style TargetType="local:MainWindow" BasedOn="{StaticResource RadRibbonWindowStyle}" />
	</ResourceDictionary> 
```