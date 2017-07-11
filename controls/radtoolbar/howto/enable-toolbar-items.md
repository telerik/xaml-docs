---
title: Enable / Disable items state
page_title: Enable / Disable items state
description: Enable / Disable items state
slug: radtoolbar-enable-toolbar-items
tags: enable,/,disable,items,state
published: True
position: 3
---

# Enable / Disable items state

You can control the IsEnabled state of the __RadToolBar__ items thus modifying the overall look of the control: 

RadToolBar with enabled items:
![Rad Tool Bar Enabled Items](images/RadToolBar_EnabledItems.png)

RadToolBar with disabled items:
![Rad Tool Bar Disabled Items](images/RadToolBar_DisabledItems.png)

You can disable an item placed inside the __RadToolBar__ by changing its __IsEnabled__ property:

#### __XAML__
{{region radtoolbar-enable-toolbar-items-0}}
    <telerik:RadToolBar x:Name="toolbar">
        <Button IsEnabled="False">
            <Image Source="/Images/Open.png" />
        </Button>
    </telerik:RadToolBar>
{{endregion}}

If you want to disable all __RadToolBar__ items in code behind, you can traverse the Items collection of the control and change the enable state of each item:

#### __C#__
{{region radtoolbar-enable-toolbar-items-1}}
	foreach (object o in toolbar.Items)
	{
		Control control = o as Control;
		if (control != null)
		{
			control.IsEnabled = false;
		}
	}
{{endregion}}

#### __VB.NET__
{{region radtoolbar-enable-toolbar-items-2}}
	For Each o As Object In toolbar.Items
		Dim control As Control = TryCast(o, Control)
		If control IsNot Nothing Then
			control.IsEnabled = False
		End If
	Next
{{endregion}}

> The __TextBlock__ control inherits the __FrameworkElement__, but not the __Control__, i.e. it has not the __IsEnabled__ property. This is the reason that it can not be enabled and disabled.