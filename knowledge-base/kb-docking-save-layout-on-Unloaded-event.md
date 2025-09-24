---
title: Save RadDocking Layout When the Control is Unloaded
page_title: How to Save the Layout of the RadDocking When it is Unloaded
description: This article shows how to save the layout of the RadDocking control when its unloaded.
type: how-to
slug: kb-docking-save-layout-on-unloaded-event
position: 0
tags: docking, load layout, unloaded
ticketid: 1565983
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3 912</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDocking for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to save the layout of the RadDocking control when its unloaded.

## Solution

1. Add a new event handler for the `Unloaded` event of the `RadDocking` using the `EventManager.RegisterClassHandler` static method.

    __Add a new event handler for the Unloaded event of RadDocking__
    ```C#
        EventManager.RegisterClassHandler(typeof(RadDocking), RadDocking.   UnloadedEvent, new RoutedEventHandler(OnUnloaded));
    ```
	```VB.NET
        EventManager.RegisterClassHandler(GetType(RadDocking), RadDocking.  UnloadedEvent, New RoutedEventHandler(OnUnloaded))
    ```

2. Implement the save logic in the newly added event handler for the `Unloaded` event.

    __Sample implementation of saving the layout in the newly added   handler__
    ```C#
        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.   GetUserStoreForAssembly())
            {
                using (var isoStream = storage.OpenFile("RadDocking_Layout.xml",    FileMode.Create))
                {
                    this.radDocking.SaveLayout(isoStream);
                }
            }
        }
    ```
	```VB.NET
        Private Sub OnUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Using storage As IsolatedStorageFile = IsolatedStorageFile. GetUserStoreForAssembly()
                Using isoStream = storage.OpenFile("RadDocking_Layout.xml",     FileMode.Create)
                    Me.radDocking.SaveLayout(isoStream)
                End Using
            End Using
        End Sub
    ```