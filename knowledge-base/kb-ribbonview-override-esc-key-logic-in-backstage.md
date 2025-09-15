---
title: Override Esc Key Logic of RadRibbonBackstage
page_title: Change RadRibbonBackstage Logic for Escape Key
description: How to override escape key logic of RadRibbonBackstage
type: how-to
slug: kb-ribbonview-override-esc-key-logic-in-backstage
position: 0
tags: ribbonview, escape, key, backstage
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.2.606</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadRibbonView for WPF</td>
	</tr>
</table>

## Description

How to override __Escape__ key logic of the `RadRibbonBackstage` element.

## Solution

To achieve this requirement, create a custom class that derives from the RadRibbonBackstage class.

__Create class that derives from RadRibbonBackstage__
```C#
    public class CustomBackstage : RadRibbonBackstage
    {
    }
```
```VB.NET
Public Class CustomBackstage
    Inherits RadRibbonBackstage
End Class
```

Override the `HandleKey` method that comes from the RadRibbonBackstage class and execute your custom logic.

__Override the HandleKey method__
```C#
    public class CustomBackstage : RadRibbonBackstage
    {
        protected override void HandleKey(KeyEventArgs e)
        {
            if (e.Key == Key.Escape 
                && MessageBox.Show("Do you want to close the backstage?", "Confirmation",   MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                base.HandleKey(e);
            }
        }
    }
```
```VB.NET
    Public Class CustomBackstage
        Inherits RadRibbonBackstage
    
        Protected Overrides Sub HandleKey(ByVal e As KeyEventArgs)
            If e.Key = Key.Escape AndAlso MessageBox.Show("Do you want to close the backstage?",    "Confirmation", MessageBoxButton.YesNo) = MessageBoxResult.Yes Then
                MyBase.HandleKey(e)
            End If
        End Sub
    End Class
```
