---
title: Styling RadWindow
page_title: Styling RadWindow
description: Check our &quot;Styling RadWindow&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-styles-and-templates-styling-the-radwindow
tags: styling,the,radwindow
published: True
position: 2
---

# Styling RadWindow

To customize the default look and feel of the RadWindow control you can extract its Style and modify its ControlTemplate. 

You can see how you can extract the styles and templates of a Telerik control in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article. Once you have the template, you can modify it as desired, but it should be noted that heavy modifications may not work properly because the RadWindow control relies on some of the elements inside the template.

To re-apply the customized style, you can set the Style property of RadWindow.

__Example 1: Define a Style with customized ControlTemplate__ 
```XAML
	<UserControl.Resources>
		<!-- If you use NoXaml dlls and implicit styles theming, please set the following property on the Style object: BasedOn="{StaticResource RadWindowStyle}" -->
		<Style x:Key="CustomRadWindowStyle" TargetType="telerik:RadWindow">	
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:RadWindow">
						<!-- customized template here -->
					</ControlTemplate>
				</Setter.Value>
			</Setter>			
		</Style>
	</UserControl.Resources>
```

__Example 2: Setting the Style property of RadWindow__ 
```C#
	RadWindow radWindow = new RadWindow();
	radWindow.Style = (Style)this.Resources["CustomRadWindowStyle"];
```

>tip If you remove the x:Key setting of the style, it will get applied implicitly to all RadWindow controls in the scope where the style is defined. In this case, you don't need to set the Style property explicitly. For RadWindow, it is recommend to define such implicit style in the App.xaml Resources.

You can also use the Template property directly instead of the Style property.

__Example 3: Define a Style with customized ControlTemplate__ 
```XAML
	<UserControl.Resources>	
		<ControlTemplate x:Key="CustomRadWindowTemplate" TargetType="telerik:RadWindow">
			<!-- customized template here -->
		</ControlTemplate>
	</UserControl.Resources>
```

__Example 4: Setting the Style property of RadWindow__ 
```C#
	RadWindow radWindow = new RadWindow();
	radWindow.Template = (ControlTemplate)this.Resources["CustomRadWindowTemplate"];
```

## See Also  

{% if site.site_name == 'WPF' %}
 * [How to Change Header Background]({%slug kb-window-change-header-background%})
{% endif %} 
 * [Styling the Predefined Windows]({%slug radwindow-styles-and-templates-styling-the-predefined-windows%})
 * [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
 * [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})