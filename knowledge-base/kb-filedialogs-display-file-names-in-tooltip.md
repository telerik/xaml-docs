---
title: Display File Name in ToolTip
page_title: How to Display a ToolTip for File Names
description: This article shows how to display the names of files in a tooltip.
type: how-to
slug: kb-filedialogs-display-tooltip-on-radlistboxitem
position: 0
tags: filedialogs, tooltip, file name
ticketid: 1568955
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.511</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadFileDialogs for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to display a tooltip that contains the name of a file.

## Solution

The files in the __Extra large icons__, __Large icons__, __Medium icons__, __Small icons__, __List__ and __Tiles__ views, are represented by a `RadListBoxItem`  element. To
display a tooltip for this element, register two new event handlers for the RadListBoxItem class, via the `EventManager.RegisterClassHandler` method. These two handlers will be for the `MouseEnter` and `MouseLeave` events.

__Register new MouseEnter and MouseLeave event handlers__
```C#
    EventManager.RegisterClassHandler(typeof(RadListBoxItem), RadListBoxItem.MouseEnterEvent, new MouseEventHandler(GetOnMouseEnter), true);
    EventManager.RegisterClassHandler(typeof(RadListBoxItem), RadListBoxItem.MouseLeaveEvent, new MouseEventHandler(GetOnLeaveEnter), true);
```
```VB.NET
    EventManager.RegisterClassHandler(GetType(RadListBoxItem), RadListBoxItem.MouseEnterEvent, New MouseEventHandler(GetOnMouseEnter), True)
    EventManager.RegisterClassHandler(GetType(RadListBoxItem), RadListBoxItem.MouseLeaveEvent, New MouseEventHandler(GetOnLeaveEnter), True)
```

To reach the name of a file or a directory, cast the Content property of the RadListBoxItem element to either `FileInfoWrapper` or `DirectoryInfoWrapper` type. The FileInfoWrapper class contains information for the files and DirectoryInfoWrapper class-for directories. The name for the file or directory can be retrieved, through the `Name` property of both of these classes.

__Cast the Content property and retrieve the file/directory name__
```C#
    private static void GetOnMouseEnter(object sender, MouseEventArgs e)
    {
        RadListBoxItem item = (RadListBoxItem)sender;

        if (item.Content is FileInfoWrapper)
        {
            FileInfoWrapper infoWrapper = item.Content as FileInfoWrapper;
            string fileName = infoWrapper.Name;
        }
        else if (item.Content is DirectoryInfoWrapper)
        {
            DirectoryInfoWrapper directoryInfoWrapper = item.Content as DirectoryInfoWrapper;
            string directoryName = directoryInfoWrapper.Name;
        }
    }
```
```VB.NET
    Private Shared Sub GetOnMouseEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim item As RadListBoxItem = CType(sender, RadListBoxItem)

        If TypeOf item.Content Is FileInfoWrapper Then
            Dim infoWrapper As FileInfoWrapper = TryCast(item.Content, FileInfoWrapper)
            Dim fileName As String = infoWrapper.Name
        ElseIf TypeOf item.Content Is DirectoryInfoWrapper Then
            Dim directoryInfoWrapper As DirectoryInfoWrapper = TryCast(item.Content,    DirectoryInfoWrapper)
            Dim directoryName As String = directoryInfoWrapper.Name
        End If
    End Sub
```

Create a `ToolTip` class instance and set its `Content` property to the name of the file/directory. Then, set this instance to the `ToolTip` property of the `RadListBoxItem` element.

__Create and set ToolTip for RadListBoxItem__
```C#
    private static void GetOnMouseEnter(object sender, MouseEventArgs e)
    {
        RadListBoxItem item = (RadListBoxItem)sender;

        if (item.Content is FileInfoWrapper)
        {
            FileInfoWrapper infoWrapper = item.Content as FileInfoWrapper;
            string fileName = infoWrapper.Name;

            if (item.ToolTip != null)
            {
                (item.ToolTip as ToolTip).IsOpen = true;
            }
            else
            {
                var tooltip = new ToolTip() { Content = fileName };
                item.ToolTip = tooltip;
                tooltip.IsOpen = true;
            }
        }
        else if (item.Content is DirectoryInfoWrapper)
        {
            DirectoryInfoWrapper directoryInfoWrapper = item.Content as DirectoryInfoWrapper;
            string directoryName = directoryInfoWrapper.Name;

            if (item.ToolTip != null)
            {
                (item.ToolTip as ToolTip).IsOpen = true;
            }
            else
            {
                var tooltip = new ToolTip() { Content = directoryName };
                item.ToolTip = tooltip;
                tooltip.IsOpen = true;
            }
        }
    }
```
```VB.NET
    Private Shared Sub GetOnMouseEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim item As RadListBoxItem = CType(sender, RadListBoxItem)

        If TypeOf item.Content Is FileInfoWrapper Then
            Dim infoWrapper As FileInfoWrapper = TryCast(item.Content, FileInfoWrapper)
            Dim fileName As String = infoWrapper.Name

            If item.ToolTip IsNot Nothing Then
                (TryCast(item.ToolTip, ToolTip)).IsOpen = True
            Else
                Dim tooltip = New ToolTip() With {
                    .Content = fileName
                }
                item.ToolTip = tooltip
                tooltip.IsOpen = True
            End If
        ElseIf TypeOf item.Content Is DirectoryInfoWrapper Then
            Dim directoryInfoWrapper As DirectoryInfoWrapper = TryCast(item.Content,    DirectoryInfoWrapper)
            Dim directoryName As String = directoryInfoWrapper.Name

            If item.ToolTip IsNot Nothing Then
                (TryCast(item.ToolTip, ToolTip)).IsOpen = True
            Else
                Dim tooltip = New ToolTip() With {
                    .Content = directoryName
                }
                item.ToolTip = tooltip
                tooltip.IsOpen = True
            End If
        End If
    End Sub
```

To control the delay of the initial display of the tooltip, you can use the `RadToolTipService.SetInitialShowDelay` method.

__Set initial delay__
```C#
    RadListBoxItem item = (RadListBoxItem)sender;

    var delay = RadToolTipService.GetInitialShowDelay(item);
    if (delay != 0)
    {
        RadToolTipService.SetInitialShowDelay(item, 0);
    }
```
```VB.NET
    Dim item As RadListBoxItem = CType(sender, RadListBoxItem)

    Dim delay = RadToolTipService.GetInitialShowDelay(item)
    If delay <> 0 Then
        RadToolTipService.SetInitialShowDelay(item, 0)
    End If
```

Inside the registered handler for the `MouseLeave` event, set the `IsOpen` property of the ToolTip property to `False`, to close the tooltip.

__Close the tooltip__
```C#
    private void GetOnLeaveEnter(object sender, MouseEventArgs e)
    {
        RadListBoxItem item = (RadListBoxItem)sender;

        if ((item.ToolTip as ToolTip).IsOpen)
        {
            (item.ToolTip as ToolTip).IsOpen = false;
        }
    }
```
```VB.NET
    Private Sub GetOnLeaveEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim item As RadListBoxItem = CType(sender, RadListBoxItem)
    
        If (TryCast(item.ToolTip, ToolTip)).IsOpen Then
            (TryCast(item.ToolTip, ToolTip)).IsOpen = False
        End If
    End Sub
```