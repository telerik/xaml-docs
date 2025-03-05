---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started with {{ site.framework_name }} VirtualKeyboard

This tutorial will walk you through the creation of a sample application that contains a VirtualKeyboard control.

## Adding Telerik Assemblies Using NuGet

To use `RadVirtualKeyboard` when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

## Defining the RadVirtualKeyboard

#### __[XAML] Defining RadVirtualKeyboard in XAML__
{{region radvirtualkeyboard-getting-started-0}}
	 <telerik:RadVirtualKeyboard />
{{endregion}}

![{{ site.framework_name }} RadVirtualKeyboard Default Layout](images/radvirtualkeyboard-overview-1.png)

There is no need to manually subscribe an input element to the keyboard control. When you click a key on the VirtualKeyboard, a key press message is send to the OS. In addition to this, the control is unfocusable which means that if you focus a text input (like `TextBox` for example), the focus will stay there while you press the keys.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF VirtualKeyboard Component](https://www.telerik.com/products/wpf/virtual-keyboard.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Visual Structure]({%slug radvirtualkeyboard-visual-structure%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
