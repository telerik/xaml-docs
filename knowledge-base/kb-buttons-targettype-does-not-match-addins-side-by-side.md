---
title: RadButton TargetType Does Not Match Type of Element in Side-by-Side Add-ins
description: Resolving the "'RadButton' TargetType does not match type of element 'RadButton'" XamlParseException when loading multiple add-ins side by side in ArcGIS Pro, Revit, AutoCAD, or Office.
components: ["buttons"]
type: troubleshooting
page_title: RadButton TargetType Does Not Match Type of Element in Add-in Projects
slug: kb-buttons-targettype-does-not-match-addins-side-by-side
position: 0
tags: radbutton, targettype, addin, arcgis, arcgis pro, revit, autocad, vsto, side-by-side, xamlparseexception
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.812| Telerik UI for WPF |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

When running multiple add-ins or plugins side by side inside a host application (such as ArcGIS Pro 3.6, Revit, AutoCAD, or Office), opening a view or window containing a `RadButton` (or another Telerik control) throws a `XamlParseException`:

`'RadButton' TargetType does not match type of element 'RadButton'.`

This error occurs at runtime when the view or user control is instantiated or when a style targeting `RadButton` is applied.

## Cause

WPF host applications like ArcGIS Pro, Revit, and AutoCAD load third-party add-ins into a single shared process and common application domain (`AppDomain`) or shared default `AssemblyLoadContext`.

When two or more add-ins reference different versions of Telerik UI for WPF assemblies (for example, Add-in A references version `2024.1.130` and Add-in B references version `2025.2.521`), or when one add-in references `Xaml` binaries and another references `NoXaml` binaries:

1. The host process loads whichever version of `Telerik.Windows.Controls.dll` is requested first by the first active add-in.
2. When the second add-in attempts to apply a style where `TargetType="telerik:RadButton"`, the XAML parser resolves `RadButton` from the assembly referenced by the second add-in.
3. Because the instantiated element belongs to the assembly loaded first in the shared process, WPF compares their runtime type identities. Even though both types share the full name `Telerik.Windows.Controls.RadButton`, they originate from different assembly identities or contexts.
4. As a result, WPF determines that the `TargetType` does not match the element's actual runtime type and throws the exception.

## Solution

To resolve this conflict in a shared host process, use one of the following approaches:

### Align Telerik Assembly Versions Across Add-ins

Ensure that all add-ins running within the same host application reference the exact same version and binary distribution (either all `Xaml` or all `NoXaml`) of Telerik UI for WPF. When all add-ins reference identical assembly versions, the single shared assembly loaded in the host process matches the types expected by every add-in.

### Scope Resources Locally

Avoid adding global Telerik theme dictionaries or styles directly to `Application.Current.Resources`. In a plugin host, `Application.Current` belongs to the host application (such as ArcGIS Pro), and modifying its resources affects all other plugins running in the process.

Always merge Telerik theme dictionaries and define custom styles in the local `UserControl.Resources` or `Window.Resources` of your add-in view:

```XAML
<UserControl x:Class="MyArcGISAddin.MyCustomView"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
    <UserControl.Resources>
        <!-- Scope resources and styles locally to the UserControl -->
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml" />
                <ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </UserControl.Resources>
    <Grid>
        <telerik:RadButton Content="Click Me" Width="100" Height="30" />
    </Grid>
</UserControl>
```

## See Also

* [Runtime Exception after adding a Telerik WPF control]({%slug kb-common-xamlparseexception-dlls-mixup%})
* [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%})
* [Telerik License Not Found Dialog Shown When UI for WPF Used in Addin Project]({%slug kb-installation-missing-license-addin-project%})
* [Integration With Visual Studio Tools for Microsoft Office (VSTO) Templates]({%slug kb-common-create-excel-addin%})
* [RadButtons Overview]({%slug radbuttons-overview%})
