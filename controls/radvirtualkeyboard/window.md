---
title: Keyboard Window
page_title: Keyboard Window
description: Check our &quot;Keyboard Window; documentation article for the RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-window
tags: window,dialog
published: True
position: 6
---

# {{ site.framework_name }} RadVirtualKeyboard Keyboard Window

VirtualKeyboard provides a special window element that is styled according to the keyboard design.

To open the keyboard window, use the `RadVirtualKeyboardWindow` control and its `Show` method. 

#### __[C#] Showing RadVirtualKeyboardWindow__
{{region radvirtualkeyboard-window-0}}
	var keyboardWindow = new RadVirtualKeyboardWindow(new RadVirtualKeyboard());
	keyboardWindow.Show();
{{endregion}}

![{{ site.framework_name }} RadVirtualKeyboard Keyboard Window](images/radvirtualkeyboard-window-0.png)

## See Also  
* [Visual Structure]({%slug radvirtualkeyboard-visual-structure%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
