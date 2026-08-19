---
title: Does Telerik UI for WPF Provide a RadCheckBox Control?
page_title: RadCheckBox Support in Telerik UI for WPF
description: Find out whether Telerik UI for WPF provides a dedicated RadCheckBox control and which checkbox-related options are supported.
type: how-to
slug: kb-buttons-radcheckbox-control
position: 0
tags: radcheckbox, checkbox, radtogglebutton, radgridview, gridviewcheckboxcolumn
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.812| Telerik UI for WPF |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Determine whether Telerik UI for WPF provides a dedicated `RadCheckBox` control and how to implement checkbox functionality in a WPF application.

## Solution

Telerik UI for WPF does not provide a public control named `RadCheckBox`. Use the standard WPF `CheckBox` when you need a checkbox control:

```XAML
<CheckBox Content="Enable feature"
          IsChecked="{Binding IsEnabled, Mode=TwoWay}" />
```

If your application uses Telerik theme resources, apply the appropriate theme resources to the scope that contains the native WPF `CheckBox`. This keeps the checkbox consistent with the rest of the themed UI.

For a Telerik control that behaves like a checkbox and provides Telerik-specific button styling, use `RadToggleButton`:

```XAML
<telerik:RadToggleButton Content="Enable feature"
                         IsChecked="{Binding IsEnabled, Mode=TwoWay}" />
```

`RadToggleButton` inherits from the native WPF `ToggleButton`, supports `IsChecked`, and also supports three-state behavior through `IsThreeState`.

### Checkbox functionality in RadGridView

When you need a bound checkbox in each row of a `RadGridView`, use `GridViewCheckBoxColumn`:

```XAML
<telerik:RadGridView ItemsSource="{Binding Items}"
                     AutoGenerateColumns="False">
    <telerik:RadGridView.Columns>
        <telerik:GridViewCheckBoxColumn Header="Active"
                                        DataMemberBinding="{Binding IsActive}" />
    </telerik:RadGridView.Columns>
</telerik:RadGridView>
```

`GridViewCheckBoxColumn` is intended for boolean data bound to a grid column. It is not a standalone checkbox control.

## See Also

* [Toggle Button]({%slug radbuttons-features-toggle-button%})
* [CheckBox Column]({%slug gridview-checkbox-column%})
* [RadButtons Overview]({%slug radbuttons-overview%})
