---
title: InvalidOperationException - Cannot use a DependencyObject that Belongs to a Different Thread than its Parent Freezable
description: An InvalidOperationException is thrown if you try to access a **Brush** from a different thread.
type: troubleshooting
page_title: InvalidOperationException when Accessing a Freezable from a Different Thread
slug: kb-invalidoperationexception-freezable
position: 0
tags: InvalidOperationException, freezable, different, thread
ticketid: 1381959
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.2.511</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Telerik UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

An "**InvalidOperationException**: Cannot use a DependencyObject that belongs to a different thread than its parent Freezable." is thrown if you try to access a **Brush** or other Freezable from a different thread.

## Solution

Any public **static** members of the [Freezable](https://docs.microsoft.com/en-us/dotnet/api/system.windows.freezable) type are thread safe. Any instance members, however, are not guaranteed to be thread safe.

When the **IsFrozen** property is **false**, a Freezable object can be accessed only from the thread on which it was created. Attempting to access it from another thread throws an **InvalidOperationException**. The [Invoke](https://docs.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcher.invoke) and [BeginInvoke](https://docs.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcher.begininvoke) methods provide support for marshalling to the correct thread.

When their **IsFrozen** property is **true**, Freezable objects are **free-threaded**. For more information, see [Freezable Objects Overview](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/advanced/freezable-objects-overview).

Thus, to overcome this exception, you need to freeze the Freezable object before using it:

__Example 1: Freeze the Freezable object__
    ```C#
		var brush = (Brush)new BrushConverter().ConvertFrom("#4CAF50");
		if (brush.CanFreeze)
		{
			brush.Freeze();
		}
    ```