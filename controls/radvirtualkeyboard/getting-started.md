---
title: Getting Started
page_title: Getting Started | VirtualKeyboard WPF
description: Check our &quot;Getting Started&quot; documentation article for the RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a VirtualKeyboard control.

## Assembly References

To use `RadVirtualKeyboard`, add references to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Navigation__

## Defining the RadVirtualKeyboard

#### __[XAML] Defining RadVirtualKeyboard in XAML__
{{region radvirtualkeyboard-getting-started-0}}
	 <telerik:RadVirtualKeyboard />
{{endregion}}

![](images/radvirtualkeyboard-overview-1.png)

There is no need to manually subscribe an input element to the keyboard control. When you click a key on the VirtualKeyboard, a key press message is send to the OS. In addition to this, the control is unfocusable which means that if you focus a text input (like `TextBox` for example), the focus will stay there while you press the keys.

## See Also  
* [Visual Structure]({%slug radvirtualkeyboard-visual-structure%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
