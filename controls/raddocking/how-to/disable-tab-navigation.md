---
title: How to Disable the Tab Navigation of RadDocking Elements
page_title: How to Disable the Tab Navigation of RadDocking Elements
description: How to Disable the Tab Navigation of RadDocking Elements
slug: raddocking-how-to-disable-tab-navigation
tags: tab, navigation, disable
published: True
position: 9
---

# How to Disable the Tab Navigation of RadDocking Elements

By default when Tab navigation is used it is possible to focus __RadDocking__ itself as well as some of its elements such as GridResizer and AutoHideArea.

With R2 2016 of UI for WPF we introduced a way to easily disable the Tab navigation of RadDocking elements.  This allows the user to directly navigate to the elements inside the active Pane Content when Tab key is pressed.

>important The explained approach is applicable when using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to set a theme to the Docking control.

Let’s, for example, have a simple RadDocking definition as shown in __Example 1__.

#### __[XAML] Example 1: Simple RadDocking definition__

{{region raddocking-how-to-disable-tab-navigation_0}}
	<telerik:RadDocking Width="240" Height="200">
		<telerik:RadDocking.DocumentHost>
			<telerik:RadSplitContainer>
				<telerik:RadPaneGroup>
					<telerik:RadPane Header="Description">                   
						<TextBox Text="Some text here"  Width="100" Margin="10" />                             
					</telerik:RadPane>                 
				</telerik:RadPaneGroup>
			</telerik:RadSplitContainer>
		</telerik:RadDocking.DocumentHost>
	</telerik:RadDocking> 
{{endregion}}

Currently, when RadDocking receives the focus, a few Tabs are needed in order to navigate to the TextBox inside the Pane as shown in __Figure 1__.   

#### __Figure 1: RadDocking behavior when Tab key is pressed multiple times__

![](images/docking_tabnavigation_01.png)

In order to change this behavior, you will need to set __IsTabStop__ property to __False__ for some elements inside RadDocking. This could be achieved through the Styles targeting these elements added inside App.xaml.

#### __[XAML] Example 2: Applying IsTabStop through the Styles of RadDocking elements__

{{region raddocking-how-to-disable-tab-navigation_1}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Docking.xaml"/>              
			</ResourceDictionary.MergedDictionaries>

			<Style TargetType="telerik:AutoHideArea" BasedOn="{StaticResource AutoHideAreaStyle}">
				<Setter Property="IsTabStop" Value="False" />
			</Style>
			<Style TargetType="telerik:RadDocking" BasedOn="{StaticResource RadDockingStyle}">
				<Setter Property="IsTabStop" Value="False"/>
			</Style>
			<Style TargetType="telerik:RadGridResizer" BasedOn="{StaticResource RadGridResizerStyle}">
				<Setter Property="IsTabStop" Value="False"/>
			</Style>
			<Style TargetType="telerik:PaneHeader" BasedOn="{StaticResource PaneHeaderStyle}">
				<Setter Property="IsTabStop" Value="False"/>
			</Style>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>The example is with Office_Black theme, however, the approach is applicable for all themes.

After applying the Styles declared in __Example 2__, the focus goes directly to the TextBox when Tab key is pressed as shown in __Figure 2__.

#### __Figure 2: RadDocking behavior after disabling Tab navigation of its elements__

![](images/docking_tabnavigation_02.png)
