---
title: InputGestureText
page_title: InputGestureText
description: Check our &quot;InputGestureText&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-features-inputgesturetext
tags: inputgesturetext
published: True
position: 7
site_name: WPF
---

# InputGestureText

The __InputGestureText__ property of __RadMenuItem__ is used to display an input gesture that will execute the command tied to the specified item. It is placed right after the Header text of menu item. When using the predefined ApplicationCommands the __InputGestureText__ is displayed automatically. If you are using a custom Command the __InputGestureText__ property should be set to the required shortcut manually.   

The following example demonstrates the use of the __InputGestureText__ property:



```XAML
	<telerik:RadMenu>
	    <telerik:RadMenuItem Header="File" />
	    <telerik:RadMenuItem Header="Edit">
	        <telerik:RadMenuItem Header="Cut" Command="ApplicationCommands.Cut">
	            <telerik:RadMenuItem.Icon>
	                <Image Source="Images/cut.png" />
	            </telerik:RadMenuItem.Icon>
	        </telerik:RadMenuItem>
	        <telerik:RadMenuItem Header="Copy" Command="ApplicationCommands.Copy">
	            <telerik:RadMenuItem.Icon>
	                <Image Source="Images/copy.png" />
	            </telerik:RadMenuItem.Icon>
	        </telerik:RadMenuItem>
	        <telerik:RadMenuItem Header="Paste" Command="ApplicationCommands.Paste">
	            <telerik:RadMenuItem.Icon>
	                <Image Source="Images/paste.png" />
	            </telerik:RadMenuItem.Icon>
	        </telerik:RadMenuItem>
	        <telerik:RadMenuSeparatorItem />
	        <telerik:RadMenuItem Header="Select All" Command="ApplicationCommands.SelectAll" />
	        <telerik:RadMenuSeparatorItem />
	        <telerik:RadMenuItem Header="Custom Command" Command="{Binding MyCommand}" InputGestureText="Ctrl+P" />
	    </telerik:RadMenuItem>
	</telerik:RadMenu>
```

![Rad Menu-Features-Input Gesture Text-01](images/RadMenu_Features_InputGestureText_01.png)

The InputGestureText property __does not associate the input gesture with the menu item__. Instead it only includes text to the menu item. The project should implement the user input in order to execute an action. To make the described gesture work, you can add an [InputBinding](https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.keybinding?view=netframework-4.5) to the RadMenu with the same gesture as the one described with the InputGestureText. 

## See Also  
 * [Commands]({%slug radmenu-features-commands%})
 * [Menu Items]({%slug radmenu-features-menuitems%})
 * [Icons]({%slug radmenu-features-icons%})
