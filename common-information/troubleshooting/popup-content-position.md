---
title: Popup Content Position
page_title: Popup Content Position
description: This article describes how to resolve the wrong position of a popup's content when it is not aligned as expected.
slug: troubleshooting-popup-content-position
tags: popup, ribbonview, content, position, troubleshooting
published: True
position: 1
---

# Popup Content Position

This article describes how to resolve the wrong position of a popup's content when it is not aligned as expected.

The Popup control in WPF is affected by the Windows OS menu settings. This can be noticed in controls that display its content in a popup. For example, the minimized content of RadRibbonView or the items of the RadComboBox control. You can see the popup element aligned to its placement target differently on different machines.

![{{ site.framework_name }} Popup Content Position](images/troubleshooting-popup-content-position-0.png)

You can get the same behavior also with a native WPF Border and a Popup attached to it.

![{{ site.framework_name }} Popup Content Position Handed Settings](images/troubleshooting-popup-content-position-1.png)

The alignment of the popup is controlled via the Handedness setting of the Windows OS. To resolve the issue you can change the setting via the Windows settings or in code.

## Changing the Handedness via the Windows Tablet PC Settings

To change the Handedness via the Windows menu use the following steps:

1. Open the Windows Start menu and start the Run prompt.	
2. Enter the following command in the Open input - *explorer shell:::{80F3F1D5-FECA-45F3-BC32-752C152E456E}*. This will open the Tablet PC Settings  

	![{{ site.framework_name }} Popup Content Position Run Shell Command](images/troubleshooting-popup-content-position-2.png)
	
3. Click in the Other tab of the settings window and select the __Left-handed__ option. Then click okay.
	
	![{{ site.framework_name }} Popup Content Position Set handedness](images/troubleshooting-popup-content-position-3.png)

## Changing the Handedness in code

To change the handedness in code you can use the SystemParameters static class and its _menuDropAlignment field. Keep in mind that the filed is private so you can set it only via reflection.

__Example 1: Setting the _menuDropAlignment field__
```C#
	public static void SetAlignment()
	{
		var ifLeft = SystemParameters.MenuDropAlignment;
		if (ifLeft)
		{
			var t = typeof(SystemParameters);
			var field = t.GetField("_menuDropAlignment", BindingFlags.NonPublic | BindingFlags.Static);
			field.SetValue(null, false);
		}
	}
```
