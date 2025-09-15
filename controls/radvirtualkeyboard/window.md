---
title: Keyboard Window
page_title: Keyboard Window
description: Check our &quot;Keyboard Window; documentation article for the RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-window
tags: window,dialog
published: True
position: 6
---

# Keyboard Window

VirtualKeyboard provides a special window element that is styled according to the keyboard design.

To open the keyboard window, use the `RadVirtualKeyboardWindow` control and its `Show` method. 

__Showing RadVirtualKeyboardWindow__
```C#
	var keyboardWindow = new RadVirtualKeyboardWindow(new RadVirtualKeyboard());
	keyboardWindow.Show();
```

![{{ site.framework_name }} RadVirtualKeyboard Keyboard Window](images/radvirtualkeyboard-window-0.png)

## See Also  
* [Visual Structure]({%slug radvirtualkeyboard-visual-structure%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
