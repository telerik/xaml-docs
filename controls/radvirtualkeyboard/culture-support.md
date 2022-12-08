---
title: Language Culture Support
page_title: Language Culture Support
description: Check our &quot;Language Culture Support&quot; documentation article for the on-screen RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-culture-support
tags: culture,localization,language
published: True
position: 4
---

# Language Culture Support

A specific language culture can be applied to the buttons of the VirtualKeyboard in addition to the automatic language synchronization feature.

The language of the letter buttons in `RadVirtualKeyboard` is determined by the currently selected input language of the OS. Changing the input language at runtime won't affect the text in the letter buttons, until you set the `SynchronizeCultureWithSystem` property of `RadVirtualKeyboard` to `True`. This will enable the current input language tracking and it will update the text when the language changes at runtime.

#### __[XAML] Enabling current language changed tracking at runtime__
{{region radvirtualkeyboard-culture-support-0}}	
	<telerik:RadVirtualKeyboard SynchronizeCultureWithSystem="True" />
{{endregion}}

The current language of the letters can be changed manually by setting the `Culture` property of `RadVirtualKeyboard`.

#### __[XAML] Setting Bulgarian culture in order to change the language of the letters__
{{region radvirtualkeyboard-culture-support-1}}	
	virtualKeyboard.Culture = new System.Globalization.CultureInfo("bg-BG");
{{endregion}}

![WPF RadVirtualKeyboard Bulgarian Culture](images/radvirtualkeyboard-culture-support-0.png)

## See Also
* [Getting Started]({%slug radvirtualkeyboard-getting-started%})
* [Keys Layout]({%slug radvirtualkeyboard-keys-layout%})
* [Sound]({%slug radvirtualkeyboard-sound%})
