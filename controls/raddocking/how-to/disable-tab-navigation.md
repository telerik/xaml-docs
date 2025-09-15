---
title: How to Disable the Tab Navigation of RadDocking Elements
page_title: How to Disable the Tab Navigation of RadDocking Elements
description: Check our &quot;How to Disable the Tab Navigation of RadDocking Elements&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-disable-tab-navigation
tags: tab, navigation, disable
published: True
position: 9
---

# How to Disable the Tab Navigation of RadDocking Elements

By default, when tab navigation is used, it is possible to focus __RadDocking__ itself as well as some of its elements such as GridResizer and AutoHideArea.

With R2 2016 of UI for WPF, we introduced a way to easily disable the tab navigation of __RadDocking__ elements. This allows the user to directly navigate to the elements inside the active pane content when the Tab key is pressed.

>important You can use the approach explained here when using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to set a theme to the Docking control.

Let’s, for example, have a simple RadDocking definition as shown in __Example 1__.

__Example 1: Simple RadDocking definition__

```XAML
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
```

In the example, when RadDocking receives the focus, a user needs to push the Tab key several times in order to navigate to the TextBox inside the pane as shown in __Figure 1__.   

#### __Figure 1: RadDocking behavior when Tab key is pressed multiple times__
![{{ site.framework_name }} RadDocking RadDocking behavior when Tab key is pressed multiple times](images/docking_tabnavigation_01.png)

In order to change this behavior, you will need to set the __IsTabStop__ property to __False__ for some elements inside __RadDocking__. You can use Styles targeting these elements added inside App.xaml.

__Example 2: Applying IsTabStop through the Styles of RadDocking elements__

```XAML
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
```

>__Example 2__ uses the Office_Black theme, however, the approach is applicable for all themes.

After applying the Styles declared in __Example 2__, the focus goes directly to the TextBox when the user presses the Tab key as shown in __Figure 2__.

#### __Figure 2: RadDocking behavior after disabling Tab navigation of its elements__
![{{ site.framework_name }} RadDocking RadDocking behavior after disabling Tab navigation of its elements](images/docking_tabnavigation_02.png)
